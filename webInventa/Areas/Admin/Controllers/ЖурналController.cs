using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventaDataModul;
using webInventa.Controllers;


namespace webInventa.Areas.Admin.Controllers
{
    public class ЖурналController : BaseController
    {
        // GET: Admin/Журнал
        public ActionResult Index()
        {	
            return View(Repository.GetЖурнал);
        }		        

        // GET: Admin/Журнал/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Журнал/Create
        [HttpPost]
        public ActionResult Create(Журнал collection)
        {
            if (ModelState.IsValid)
            try
            {
                Repository.CreateЖурнал(collection);
				logger.Info(User.Identity.Name + " добавил в базу Журнал.");
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Журнал/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Repository.GetByIdЖурнал(id));
        }

        // POST: Admin/Журнал/Edit/5
        [HttpPost]
        public ActionResult Edit(Журнал collection)
        {
            if (ModelState.IsValid)
            try
            {
                logger.Info(User.Identity.Name + " изменил в базе Журнал.");
                Repository.UpdateЖурнал(collection);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Журнал/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Repository.GetByIdЖурнал(id));
        }

        // POST: Admin/Журнал/Delete/5
        [HttpPost]
        public ActionResult Delete(Журнал collection)
        {
            try
            {
                logger.Info(User.Identity.Name + " удалил в базе Журнал.");
                Repository.RemoveЖурнал(collection);
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
