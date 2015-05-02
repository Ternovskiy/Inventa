using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventaDataModul;
using webInventa.Controllers;


namespace webInventa.Areas.Admin.Controllers
{
    public class СобытиеController : BaseController
    {
        // GET: Admin/Событие
        public ActionResult Index()
        {	
            return View(Repository.GetСобытие);
        }		        

        // GET: Admin/Событие/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Событие/Create
        [HttpPost]
        public ActionResult Create(Событие collection)
        {
            if (ModelState.IsValid)
            try
            {
                Repository.CreateСобытие(collection);
				logger.Info(User.Identity.Name + " добавил в базу Событие.");
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Событие/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Repository.GetByIdСобытие(id));
        }

        // POST: Admin/Событие/Edit/5
        [HttpPost]
        public ActionResult Edit(Событие collection)
        {
            if (ModelState.IsValid)
            try
            {
                logger.Info(User.Identity.Name + " изменил в базе Событие.");
                Repository.UpdateСобытие(collection);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Событие/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Repository.GetByIdСобытие(id));
        }

        // POST: Admin/Событие/Delete/5
        [HttpPost]
        public ActionResult Delete(Событие collection)
        {
            try
            {
                logger.Info(User.Identity.Name + " удалил в базе Событие.");
                Repository.RemoveСобытие(collection);
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
