using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventaDataModul
{
    #region Other

    public class Neuron
    {
        public Neuron(int v)
        {
            W = new double[v];
            for (int i = 0; i < W.Length; i++)
            {
                W[i] = 0.5;
            }
        }

        /// <summary>
        /// Веса
        /// </summary>
        public double[] W;

        public double Param_Sigmoids = 1;

        public double Sum(double[] IN)
        {
            double OUT = 0;
            for (int i = 0; i < W.Length; i++)
            {
                OUT += W[i] * IN[i];
            }
            var o=fun(OUT);
            return o;
        }
        /// <summary>
        /// Функция активации нейрона
        /// </summary>
        /// <param name="IN"></param>
        /// <returns></returns>
        double fun(double IN)
        {
            return 1 / (1 + Math.Exp(-1 * Param_Sigmoids * IN));
        }

    }


    public class NeuronLayer
    {
        public NeuronLayer(int v, int n)
        {
            Layer = new Neuron[n];
            OUT = new double[n];
            G = new double[n];
            for (int i = 0; i < n; i++)
            {
                Layer[i] = new Neuron(v);
            }
        }

        /// <summary>
        /// Нейроны
        /// </summary>
        public Neuron[] Layer;

        public double[] OUT;

        public double[] IN;

        public double[] G;

        public double[] Sum(double[] In)
        {
            IN = In;
            for (int i = 0; i < OUT.Length; i++)
            {
                OUT[i] = Layer[i].Sum(IN);
            }
            return OUT;//0.53120937337375629        0.62976513490915476
        }

        #region To learn net
        /// <summary>
        /// Расчет градиетов слоя
        /// </summary>
        /// <param name="WG">Градиенты предыдущего слоя или ошибка обучения</param>
        /// <returns></returns>
        public double[] FormG(double[] WG)
        {//-0.50476513490915476   out=0.62976513490915476
            for (int i = 0; i < G.Length; i++)
            {
                G[i] = OUT[i] * (1 - OUT[i]) * WG[i];
            }

            double[] wg = new double[Layer[0].W.Length];
            for (int i = 0; i < wg.Length; i++)
            {
                wg[i] = 0;
                for (int j = 0; j < G.Length; j++)
                {
                    wg[i] += G[j] * Layer[j].W[i];
                }
            }
            return wg;//-0.058845774274037581
        }

        /// <summary>
        /// Коректировка весов
        /// </summary>
        /// <param name="n">Ошибка обучения</param>
        public void CorrectionWeight(double n)
        {
            for (int i = 0; i < G.Length; i++)
            {
                for (int j = 0; j < Layer[i].W.Length; j++)
                {
                    Layer[i].W[j] += IN[j] * n * G[i];
                }
            }
        }
        #endregion
    }

    public class ViborkaListItem
    {
        public double[] IN { get; set; }
        public double[] OUT { get; set; }
    }
    #endregion

    public class NeuronNet
    {
        public NeuronNet(int[] V)
        {
            Net = new NeuronLayer[V.Length - 1];
            for (int i = 1; i < V.Length; i++)
            {
                Net[i - 1] = new NeuronLayer(V[i - 1], V[i]);
            }

            Normaliz_MAX_IN = new double[V[0]]; 
            Normaliz_MIN_IN = new double[V[0]];
            Normaliz_MAX_OUT=new double[V.Last()];
            Normaliz_MIN_OUT=new double[V.Last()];

            Normalize = true;
            AutoNormalize = true;
            LearnCountIteration = int.MaxValue;
            LearnMoment = 0.9;
            LearnSpeed = 0.2;
            LearnMaxError = 0.02;
            LearnMaxErrorFlag = false;
            LearnMaxErrorConstanta = true;
        }

        /// <summary>
        /// Слои
        /// </summary>
        public NeuronLayer[] Net;

        #region Normalize

        public double[] Normaliz_MAX_IN { get; set; }
        public double[] Normaliz_MIN_IN { get; set; }
        public double[] Normaliz_MAX_OUT { get; set; }
        public double[] Normaliz_MIN_OUT { get; set; }
        public bool Normalize { get; set; }
        public bool AutoNormalize { get; set; }

        public double fun_normir_IN(double X, double MIN, double MAX)
        {
            return (X - MIN)/(MAX - MIN);
        }

        public double fun_normir_OUT(double X, double MIN, double MAX)
        {
            return X*(MAX - MIN) + MIN;
        }

        void AutoSetNormalize(List<ViborkaListItem> viborka)
        {
            for (int i = 0; i < Normaliz_MAX_IN.Length; i++)
            {
                Normaliz_MAX_IN[i] = viborka.Max(p => p.IN[i]);
                Normaliz_MIN_IN[i] = viborka.Min(p => p.IN[i]);
            }
            for (int i = 0; i < Normaliz_MAX_OUT.Length; i++)
            {
                Normaliz_MAX_OUT[i] = viborka.Max(p => p.OUT[i]);
                Normaliz_MIN_OUT[i] = viborka.Min(p => p.OUT[i]);
            }
        }

        #endregion


        #region Operand main
        /// <summary>
        /// Посчитать результат сети
        /// </summary>
        /// <param name="IN">Входной массив</param>
        /// <returns></returns>
        public double[] Sum(double[] IN)
        {
            double[] OUT;
            
            if (Normalize)
            {
                var _IN = new double[IN.Length];
                for (int i = 0; i < IN.Length; i++)
                {
                    _IN[i] = fun_normir_IN(IN[i],Normaliz_MIN_IN[i],Normaliz_MAX_IN[i]);
                }
                OUT = Net[0].Sum(_IN);
            }
            else
            {
                OUT = Net[0].Sum(IN);
            }

            for (int i = 1; i < Net.Length; i++)
            {
                OUT = Net[i].Sum(OUT);
            }
            if (Normalize)
            {
                for (int i = 0; i < OUT.Length; i++)
                {
                    OUT[i] = fun_normir_OUT(OUT[i],Normaliz_MIN_OUT[i],Normaliz_MAX_OUT[i]);
                }
            }
            return OUT;
        }

        /// <summary>
        /// Посчитать максисимальную ошибку обучения
        /// </summary>
        /// <param name="IN">Вход</param>
        /// <param name="OUT">Ожидаемый Выход</param>
        /// <returns></returns>
        public double LearnError(double[] IN, double[] OUT)
        {
            double[] E = new double[OUT.Length];
            Sum(IN).CopyTo(E, 0);
            for (int i = 0; i < E.Length; i++)
            {
                E[i] = OUT[i] - E[i];
            }
            return E.Max();
        }
        /// <summary>
        /// Одна итерация обучения
        /// </summary>
        /// <param name="IN"></param>
        /// <param name="OUT"></param>
        /// <param name="n">Скорость обучения</param>
        /// <returns></returns>
        public double LearnIteration(double[] IN, double[] OUT, double n)
        {
            double[] E = new double[OUT.Length];
            Sum(IN).CopyTo(E, 0);
            for (int i = 0; i < E.Length; i++)
            {
                if (Normalize)
                {
                    E[i] = fun_normir_IN(OUT[i],Normaliz_MIN_OUT[i],Normaliz_MAX_OUT[i]) - fun_normir_IN(E[i],Normaliz_MIN_OUT[i],Normaliz_MAX_OUT[i]);
                }
                else
                {                        //-0.50476513490915476
                    E[i] = OUT[i] - E[i];//-0.50476513490915476
                }
            }

            double[] WG = Net.Last().FormG(E);

            for (int i = Net.Length - 2; i >= 0; i--)
            {
                WG = Net[i].FormG(WG);
            }
            //-0.058845774274037581 -0.058845774274037581
            for (int i = 0; i < Net.Length; i++)
            {
                Net[i].CorrectionWeight(n);
            }

            return E.Max();
        }
        #endregion

        #region Educate

        public int LearnCountIteration { get; set; }
        public double LearnSpeed { get; set; }
        public double LearnMoment { get; set; }
        public double LearnMaxError { get; set; }
        public bool LearnMaxErrorFlag { get; set; }
        public bool LearnMaxErrorConstanta { get; set; }


        public List<double[]> Learn(List<ViborkaListItem> viborka)
        {
            if (AutoNormalize)
            {
                AutoSetNormalize(viborka);
            }
            var er = new List<double[]>();
            for (int i = 0; i < LearnCountIteration; i++)
            {
                double k = 0;
                double max2 = int.MaxValue;
                double max = 0;
                double s = 0;
                for (int j = 0; j < viborka.Count; j++)
                {
                    var a1 = viborka[j];
                    s = LearnIteration(a1.IN, a1.OUT, LearnSpeed);
                    k += s*s;
                    s = Math.Abs(s);
                    if (max < s) max = s;
                }
                LearnSpeed = LearnSpeed*LearnMoment;

                k /= 2;

                er.Add(new double[] {max, k});
                if (LearnMaxErrorFlag && LearnMaxError > s) break;
                if (LearnMaxErrorConstanta && max2 < max) break;
                max2 = max;
            }
            return er;
        }

        #endregion

    }
}
