using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventaDataModul;
using webInventa.Controllers;


namespace webInventa.Areas.Admin.Controllers
{
    public class ХостController : BaseController
    {
        // GET: Admin/Хост
        public ActionResult Index()
        {	
            return View(Repository.GetХост);
        }		        

        // GET: Admin/Хост/Create
        public ActionResult Create()
        {
            ViewBag.Drop = new SelectList(Repository.GetАдрес, "Код", "АдресПунктУлицаДом");
            return View();
        }

        // POST: Admin/Хост/Create
        [HttpPost]
        public ActionResult Create(Хост collection)
        {
            if (ModelState.IsValid)
            try
            {
                Repository.CreateХост(collection);
				logger.Info(User.Identity.Name + " добавил в базу Хост.");
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Хост/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Drop = new SelectList(Repository.GetАдрес, "Код", "АдресПунктУлицаДом");
            return View(Repository.GetByIdХост(id));
        }

        // POST: Admin/Хост/Edit/5
        [HttpPost]
        public ActionResult Edit(Хост collection)
        {
            if (ModelState.IsValid)
            try
            {
                logger.Info(User.Identity.Name + " изменил в базе Хост.");
                Repository.UpdateХост(collection);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Хост/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Repository.GetByIdХост(id));
        }

        // POST: Admin/Хост/Delete/5
        [HttpPost]
        public ActionResult Delete(Хост collection)
        {
            try
            {
                logger.Info(User.Identity.Name + " удалил в базе Хост.");
                Repository.RemoveХост(collection);
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
