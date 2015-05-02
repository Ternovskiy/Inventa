using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webInventa.Areas.Admin.Controllers
{
    public class ПоказательОборудованиеController : Controller
    {
        // GET: Admin/ПоказательОборудование
        public ActionResult Index(int IdОборудование)
        {
		//sdasdasd
            return View();
        }

        public PartialViewResult Create(int IdОборудование)
        {
            return PartialView();
        }

        //[HttpPost]
        //public ActionResult Create(Оборудование collection)
        //{
        //    if (ModelState.IsValid)
        //        try
        //        {
        //            Repository.CreateОборудование(collection);
        //            logger.Info(User.Identity.Name + " добавил в базу Оборудование.");
        //            return RedirectToAction("Index");
        //        }
        //        catch (Exception ex)
        //        {
        //            logger.Error(User.Identity.Name + " - " + ex.Message);
        //            ModelState.AddModelError("", ex.Message);
        //        }
        //    return View();
        //}
    }
}