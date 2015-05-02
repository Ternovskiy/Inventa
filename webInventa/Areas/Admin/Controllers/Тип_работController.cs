using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventaDataModul;
using webInventa.Controllers;


namespace webInventa.Areas.Admin.Controllers
{
    public class Тип_работController : BaseController
    {
        // GET: Admin/Тип_работ
        public ActionResult Index()
        {	
            return View(Repository.GetТип_работ);
        }		        

        // GET: Admin/Тип_работ/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Тип_работ/Create
        [HttpPost]
        public ActionResult Create(Тип_работ collection)
        {
            if (ModelState.IsValid)
            try
            {
                Repository.CreateТип_работ(collection);
				logger.Info(User.Identity.Name + " добавил в базу Тип_работ.");
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Тип_работ/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Repository.GetByIdТип_работ(id));
        }

        // POST: Admin/Тип_работ/Edit/5
        [HttpPost]
        public ActionResult Edit(Тип_работ collection)
        {
            if (ModelState.IsValid)
            try
            {
                logger.Info(User.Identity.Name + " изменил в базе Тип_работ.");
                Repository.UpdateТип_работ(collection);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Тип_работ/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Repository.GetByIdТип_работ(id));
        }

        // POST: Admin/Тип_работ/Delete/5
        [HttpPost]
        public ActionResult Delete(Тип_работ collection)
        {
            try
            {
                logger.Info(User.Identity.Name + " удалил в базе Тип_работ.");
                Repository.RemoveТип_работ(collection);
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
