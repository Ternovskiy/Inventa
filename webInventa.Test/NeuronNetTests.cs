using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventaDataModul;
using NUnit.Framework;

namespace webInventa.Test
{
    [TestFixture]
    public class NeuronNetTests
    {

        [Test]
        public void Test1()
        {
            //Сеть правильно создаеся и что то считает
            var net = new NeuronNet(new[] {2, 2, 1});

            Console.WriteLine("Count net sloi = "+net.Net.Count());
            Console.WriteLine("out(1,2) = "+net.Sum(new double[]{1,2})[0]);
        }

        [Test]
        public void Test2()
        {
            //Ручной счет, проверка коректировки весов без нормализации
            #region init
            //frolovatv  Nfyz111
            var viborka = new List<ViborkaListItem>();
            viborka.Add(new ViborkaListItem
            {
                IN = new double[] { 0.25, 0 },
                OUT = new double[] { 0.125 }
            });
            viborka.Add(new ViborkaListItem
            {
                IN = new double[] { 0.5, 0.5 },
                OUT = new double[] { 0.375 }
            });
            viborka.Add(new ViborkaListItem
            {
                IN = new double[] { 1, 1 },
                OUT = new double[] { 1 }
            });
            #endregion
            var net = new NeuronNet(new[] { 2, 2, 1 });
            
            net.LearnSpeed = 0.2;
            net.LearnMoment = 1;
            net.Normalize = false;

            //Assert.AreEqual(Math.Round(net.Sum(viborka[1].IN)[0],4), 0.6508, "Sum befor");
            net.LearnIteration(viborka[0].IN, viborka[0].OUT, 0.2);
            Assert.AreEqual(Math.Round(net.Sum(viborka[1].IN)[0], 4), 0.6472, "Sum after");
            
            Assert.AreEqual(Math.Round(net.Net[0].Layer[0].W[0],4), 0.4993);
            Assert.AreEqual(Math.Round(net.Net[0].Layer[0].W[1], 4), 0.5);
            Assert.AreEqual(Math.Round(net.Net[0].Layer[1].W[1], 4), 0.5);
            Assert.AreEqual(Math.Round(net.Net[0].Layer[1].W[0], 4), 0.4993);
            Assert.AreEqual(Math.Round(net.Net[1].Layer[0].W[0], 4), 0.4875);
            Assert.AreEqual(Math.Round(net.Net[1].Layer[0].W[1], 4), 0.4875);
        }

        [Test]
        public void Test2_1()
        {
            //Ручной счет, проверка коректировки весов с нормализации
            #region init

            var viborka = new List<ViborkaListItem>();
            viborka.Add(new ViborkaListItem
            {
                IN = new double[] { 1, 0 },
                OUT = new double[] { 2 }
            });
            viborka.Add(new ViborkaListItem
            {
                IN = new double[] { 2, 1 },
                OUT = new double[] { 6 }
            });
            viborka.Add(new ViborkaListItem
            {
                IN = new double[] { 4, 2 },
                OUT = new double[] { 16 }
            });
            #endregion
            var net = new NeuronNet(new[] { 2, 2, 1 });

            net.LearnSpeed = 0.2;
            net.LearnMoment = 1;
            net.AutoNormalize = false;
            net.Normaliz_MAX_IN=new double[]{4,2};
            net.Normaliz_MIN_IN=new double[]{0,0};
            net.Normaliz_MAX_OUT=new double[]{16};
            net.Normaliz_MIN_OUT=new double[]{0};

            Assert.AreEqual(net.fun_normir_IN(16, net.Normaliz_MIN_OUT[0], net.Normaliz_MAX_OUT[0]),1,"Normlze");
            Assert.AreEqual(net.fun_normir_IN(1, net.Normaliz_MIN_IN[0], net.Normaliz_MAX_IN[0]), 0.25, "Normlze");
            
            var s = Math.Round(net.fun_normir_OUT(0.6508, net.Normaliz_MIN_OUT[0], net.Normaliz_MAX_OUT[0]),2);
           // Assert.AreEqual(Math.Round(net.Sum(viborka[1].IN)[0], 2),s, "Sum befor");
            net.LearnIteration(viborka[0].IN, viborka[0].OUT, 0.2);
            s = Math.Round(net.fun_normir_OUT(0.6472, net.Normaliz_MIN_OUT[0], net.Normaliz_MAX_OUT[0]), 2);
            //Assert.AreEqual(Math.Round(net.Sum(viborka[1].IN)[0], 2 ),s, "Sum after");

            Assert.AreEqual(Math.Round(net.Net[0].Layer[0].W[0], 4), 0.4993,"W 0 0");
            Assert.AreEqual(Math.Round(net.Net[0].Layer[0].W[1], 4), 0.5, "W 0 1");
            Assert.AreEqual(Math.Round(net.Net[0].Layer[1].W[1], 4), 0.5, "W 1 1");
            Assert.AreEqual(Math.Round(net.Net[0].Layer[1].W[0], 4), 0.4993, "W 1 0");
            Assert.AreEqual(Math.Round(net.Net[1].Layer[0].W[0], 4), 0.4875, "W 2 0");
            Assert.AreEqual(Math.Round(net.Net[1].Layer[0].W[1], 4), 0.4875, "W 2 1");
        }

        [Test]
        public void Test3()
        {
            #region init

            var viborka = new List<ViborkaListItem>();
            viborka.Add(new ViborkaListItem
            {
                IN = new double[] { 0.25, 0 },
                OUT = new double[] { 0.125 }
            });
            viborka.Add(new ViborkaListItem
            {
                IN = new double[] { 0.5, 0.5 },
                OUT = new double[] { 0,375 }
            });
            viborka.Add(new ViborkaListItem
            {
                IN = new double[] { 1, 1 },
                OUT = new double[] { 1 }
            });
            #endregion
            var net = new NeuronNet(new[] { 2, 2, 1 });
            //net.Normaliz_MAX = 100;
            net.LearnMaxErrorConstanta = true;
            net.LearnCountIteration = 1000;
            net.LearnSpeed = 0.2;
            net.LearnMoment = 1;
            net.Normalize = false;
            var er = net.Learn(viborka);
            Console.WriteLine("Error = " + er.Last()[0]);
            Console.WriteLine("MaxError = " + er.Last()[1]);
            foreach (ViborkaListItem item in viborka)
            {
                Console.WriteLine(item.IN[0].ToString() + " " + item.IN[1].ToString() + " : " + item.OUT[0].ToString() + " => " + net.Sum(item.IN)[0]);
            }
        }

        [Test]
        public void Test4()
        {
            #region init

            var viborka = new List<ViborkaListItem>();
            viborka.Add(new ViborkaListItem
            {
                IN = new double[] {1, 1},
                OUT = new double[] {3}
            });
            viborka.Add(new ViborkaListItem
            {
                IN = new double[] { 2, 3 },
                OUT = new double[] { 4 }
            });
            viborka.Add(new ViborkaListItem
            {
                IN = new double[] { 3, 4 },
                OUT = new double[] { 5 }
            });
            viborka.Add(new ViborkaListItem
            {
                IN = new double[] { 4, 5 },
                OUT = new double[] { 6 }
            });
            viborka.Add(new ViborkaListItem
            {
                IN = new double[] { 5, 6 },
                OUT = new double[] { 7 }
            });
            viborka.Add(new ViborkaListItem
            {
                IN = new double[] { 6, 7 },
                OUT = new double[] { 8 }
            });

            
            #endregion
            var net = new NeuronNet(new[] { 2, 2, 1 });
            net.LearnMaxErrorConstanta = true;
            net.LearnCountIteration = 1000;
            net.LearnSpeed = 0.2;
            net.LearnMoment = 0.9;
            //net.Normalize = false;
            var er=net.Learn(viborka);
            Console.WriteLine("Error = "+er.Last()[0]);
            Console.WriteLine("MaxError = " + er.Last()[1]);
            foreach (ViborkaListItem item in viborka)
            {
                Console.WriteLine(item.IN[0]+" "+item.IN[1]+" : "+item.OUT[0]+" => "+net.Sum(item.IN)[0]);
            }
        }
    }
}
