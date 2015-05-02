using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventaDataModul;
using webInventa.Controllers;


namespace webInventa.Areas.Admin.Controllers
{
    public class Тип_логаController : BaseController
    {
        // GET: Admin/Тип_лога
        public ActionResult Index()
        {	
            return View(Repository.GetТип_лога);
        }		        

        // GET: Admin/Тип_лога/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Тип_лога/Create
        [HttpPost]
        public ActionResult Create(Тип_лога collection)
        {
            if (ModelState.IsValid)
            try
            {
                Repository.CreateТип_лога(collection);
				logger.Info(User.Identity.Name + " добавил в базу Тип_лога.");
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Тип_лога/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Repository.GetByIdТип_лога(id));
        }

        // POST: Admin/Тип_лога/Edit/5
        [HttpPost]
        public ActionResult Edit(Тип_лога collection)
        {
            if (ModelState.IsValid)
            try
            {
                logger.Info(User.Identity.Name + " изменил в базе Тип_лога.");
                Repository.UpdateТип_лога(collection);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Тип_лога/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Repository.GetByIdТип_лога(id));
        }

        // POST: Admin/Тип_лога/Delete/5
        [HttpPost]
        public ActionResult Delete(Тип_лога collection)
        {
            try
            {
                logger.Info(User.Identity.Name + " удалил в базе Тип_лога.");
                Repository.RemoveТип_лога(collection);
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
