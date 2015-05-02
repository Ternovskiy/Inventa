using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventaDataModul;
using webInventa.Controllers;


namespace webInventa.Areas.Admin.Controllers
{
    public class ЛогController : BaseController
    {
        // GET: Admin/Лог
        public ActionResult Index()
        {	
            return View(Repository.GetЛог);
        }		        

        // GET: Admin/Лог/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Лог/Create
        [HttpPost]
        public ActionResult Create(Лог collection)
        {
            if (ModelState.IsValid)
            try
            {
                Repository.CreateЛог(collection);
				logger.Info(User.Identity.Name + " добавил в базу Лог.");
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Лог/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Repository.GetByIdЛог(id));
        }

        // POST: Admin/Лог/Edit/5
        [HttpPost]
        public ActionResult Edit(Лог collection)
        {
            if (ModelState.IsValid)
            try
            {
                logger.Info(User.Identity.Name + " изменил в базе Лог.");
                Repository.UpdateЛог(collection);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Лог/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Repository.GetByIdЛог(id));
        }

        // POST: Admin/Лог/Delete/5
        [HttpPost]
        public ActionResult Delete(Лог collection)
        {
            try
            {
                logger.Info(User.Identity.Name + " удалил в базе Лог.");
                Repository.RemoveЛог(collection);
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
