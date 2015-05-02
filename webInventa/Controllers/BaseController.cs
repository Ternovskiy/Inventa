using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventaDataModul;
using Ninject;

namespace webInventa.Controllers
{
    public class BaseController : Controller
    {
        [Inject]
        public IRepository Repository { get; set; }

        public NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
    }
}