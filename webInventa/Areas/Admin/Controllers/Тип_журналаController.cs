using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventaDataModul;
using webInventa.Controllers;


namespace webInventa.Areas.Admin.Controllers
{
    public class Тип_журналаController : BaseController
    {
        // GET: Admin/Тип_журнала
        public ActionResult Index()
        {	
            return View(Repository.GetТип_журнала);
        }		        

        // GET: Admin/Тип_журнала/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Тип_журнала/Create
        [HttpPost]
        public ActionResult Create(Тип_журнала collection)
        {
            if (ModelState.IsValid)
            try
            {
                Repository.CreateТип_журнала(collection);
				logger.Info(User.Identity.Name + " добавил в базу Тип_журнала.");
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Тип_журнала/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Repository.GetByIdТип_журнала(id));
        }

        // POST: Admin/Тип_журнала/Edit/5
        [HttpPost]
        public ActionResult Edit(Тип_журнала collection)
        {
            if (ModelState.IsValid)
            try
            {
                logger.Info(User.Identity.Name + " изменил в базе Тип_журнала.");
                Repository.UpdateТип_журнала(collection);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Тип_журнала/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Repository.GetByIdТип_журнала(id));
        }

        // POST: Admin/Тип_журнала/Delete/5
        [HttpPost]
        public ActionResult Delete(Тип_журнала collection)
        {
            try
            {
                logger.Info(User.Identity.Name + " удалил в базе Тип_журнала.");
                Repository.RemoveТип_журнала(collection);
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
