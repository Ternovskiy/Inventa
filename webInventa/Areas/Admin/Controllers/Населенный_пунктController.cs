using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventaDataModul;
using webInventa.Controllers;


namespace webInventa.Areas.Admin.Controllers
{
    public class Населенный_пунктController : BaseController
    {
        // GET: Admin/Населенный_пункт
        public ActionResult Index()
        {	
            return View(Repository.GetНаселенный_пункт);
        }		        

        // GET: Admin/Населенный_пункт/Create
        public ActionResult Create()
        {
            ViewBag.Drop = new SelectList(Repository.GetТип_населенного_пункта, "Код", "Название");
            return View();
        }

        // POST: Admin/Населенный_пункт/Create
        [HttpPost]
        public ActionResult Create(Населенный_пункт collection)
        {
            if (ModelState.IsValid)
            try
            {
                Repository.CreateНаселенный_пункт(collection);
				logger.Info(User.Identity.Name + " добавил в базу Населенный_пункт.");
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Населенный_пункт/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Drop = new SelectList(Repository.GetТип_населенного_пункта, "Код", "Название");
            return View(Repository.GetByIdНаселенный_пункт(id));
        }

        // POST: Admin/Населенный_пункт/Edit/5
        [HttpPost]
        public ActionResult Edit(Населенный_пункт collection)
        {
            if (ModelState.IsValid)
            try
            {
                logger.Info(User.Identity.Name + " изменил в базе Населенный_пункт.");
                Repository.UpdateНаселенный_пункт(collection);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Населенный_пункт/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Repository.GetByIdНаселенный_пункт(id));
        }

        // POST: Admin/Населенный_пункт/Delete/5
        [HttpPost]
        public ActionResult Delete(Населенный_пункт collection)
        {
            try
            {
                logger.Info(User.Identity.Name + " удалил в базе Населенный_пункт.");
                Repository.RemoveНаселенный_пункт(collection);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
                return View();
            }
        }
    }
}
