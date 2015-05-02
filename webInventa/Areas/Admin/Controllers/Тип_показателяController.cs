using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventaDataModul;
using webInventa.Controllers;


namespace webInventa.Areas.Admin.Controllers
{
    public class Тип_показателяController : BaseController
    {
        // GET: Admin/Тип_показателя
        public ActionResult Index()
        {	
            return View(Repository.GetТип_показателя);
        }		        

        // GET: Admin/Тип_показателя/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Тип_показателя/Create
        [HttpPost]
        public ActionResult Create(Тип_показателя collection)
        {
            if (ModelState.IsValid)
            try
            {
                Repository.CreateТип_показателя(collection);
				logger.Info(User.Identity.Name + " добавил в базу Тип_показателя.");
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Тип_показателя/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Repository.GetByIdТип_показателя(id));
        }

        // POST: Admin/Тип_показателя/Edit/5
        [HttpPost]
        public ActionResult Edit(Тип_показателя collection)
        {
            if (ModelState.IsValid)
            try
            {
                logger.Info(User.Identity.Name + " изменил в базе Тип_показателя.");
                Repository.UpdateТип_показателя(collection);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Тип_показателя/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Repository.GetByIdТип_показателя(id));
        }

        // POST: Admin/Тип_показателя/Delete/5
        [HttpPost]
        public ActionResult Delete(Тип_показателя collection)
        {
            try
            {
                logger.Info(User.Identity.Name + " удалил в базе Тип_показателя.");
                Repository.RemoveТип_показателя(collection);
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
