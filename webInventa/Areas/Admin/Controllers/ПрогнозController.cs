using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventaDataModul;
using Ninject;
using webInventa.Areas.Admin.Models;
using webInventa.Controllers;

namespace webInventa.Areas.Admin.Controllers
{
    public class ПрогнозController : BaseController
    {

        [Inject]
        public NeuronNet NeuronNet { get; set; }

        [Inject]
        public ModelPrediction modelPrediction { get; set; }
        
        // GET: Admin/Прогноз
        public ActionResult Index()
        {
		//sdasdasd
            return View();
        }

        public ActionResult Seting()
        {
            return View(modelPrediction);
        }


        public List<double[]> Learn()
        {
            NeuronNet.Net = new NeuronLayer[modelPrediction.V.Length - 1];
            for (int i = 1; i < modelPrediction.V.Length; i++)
            {
                NeuronNet.Net[i - 1] = new NeuronLayer(modelPrediction.V[i - 1], modelPrediction.V[i]);
            }

            NeuronNet.Normaliz_MAX_IN = new double[modelPrediction.V[0]];
            NeuronNet.Normaliz_MIN_IN = new double[modelPrediction.V[0]];
            NeuronNet.Normaliz_MAX_OUT = new double[modelPrediction.V.Last()];
            NeuronNet.Normaliz_MIN_OUT = new double[modelPrediction.V.Last()];

            NeuronNet.Normalize = true;
            NeuronNet.AutoNormalize = true;
            NeuronNet.LearnCountIteration = modelPrediction.Epoh;
            NeuronNet.LearnMoment = modelPrediction.Moment;
            NeuronNet.LearnSpeed = modelPrediction.Speed;
            NeuronNet.LearnMaxError = modelPrediction.MaxError;
            NeuronNet.LearnMaxErrorFlag = false;
            NeuronNet.LearnMaxErrorConstanta = true;

            List<ViborkaListItem> viborka = Repository.GetСобытие.Select(l => new ViborkaListItem()
            {
                IN = {},
                OUT = {}
            }).ToList();
            return NeuronNet.Learn(viborka);
        }
    }
}