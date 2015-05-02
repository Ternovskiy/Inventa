using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventaDataModul;
using webInventa.Controllers;


namespace webInventa.Areas.Admin.Controllers
{
    public class ДолжностьController : BaseController
    {
        // GET: Admin/Должность
        public ActionResult Index()
        {	
            return View(Repository.GetДолжность);
        }		        

        // GET: Admin/Должность/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Должность/Create
        [HttpPost]
        public ActionResult Create(Должность collection)
        {
            if (ModelState.IsValid)
            try
            {
                Repository.CreateДолжность(collection);
				logger.Info(User.Identity.Name + " добавил в базу Должность.");
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Должность/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Repository.GetByIdДолжность(id));
        }

        // POST: Admin/Должность/Edit/5
        [HttpPost]
        public ActionResult Edit(Должность collection)
        {
            if (ModelState.IsValid)
            try
            {
                logger.Info(User.Identity.Name + " изменил в базе Должность.");
                Repository.UpdateДолжность(collection);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Должность/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Repository.GetByIdДолжность(id));
        }

        // POST: Admin/Должность/Delete/5
        [HttpPost]
        public ActionResult Delete(Должность collection)
        {
            try
            {
                logger.Info(User.Identity.Name + " удалил в базе Должность.");
                Repository.RemoveДолжность(collection);
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
