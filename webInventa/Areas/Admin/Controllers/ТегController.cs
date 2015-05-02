using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventaDataModul;
using webInventa.Controllers;


namespace webInventa.Areas.Admin.Controllers
{
    public class ТегController : BaseController
    {
        // GET: Admin/Тег
        public ActionResult Index()
        {	
            return View(Repository.GetТег);
        }		        

        // GET: Admin/Тег/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Тег/Create
        [HttpPost]
        public ActionResult Create(Тег collection)
        {
            if (ModelState.IsValid)
            try
            {
                Repository.CreateТег(collection);
				logger.Info(User.Identity.Name + " добавил в базу Тег.");
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Тег/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Repository.GetByIdТег(id));
        }

        // POST: Admin/Тег/Edit/5
        [HttpPost]
        public ActionResult Edit(Тег collection)
        {
            if (ModelState.IsValid)
            try
            {
                logger.Info(User.Identity.Name + " изменил в базе Тег.");
                Repository.UpdateТег(collection);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Тег/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Repository.GetByIdТег(id));
        }

        // POST: Admin/Тег/Delete/5
        [HttpPost]
        public ActionResult Delete(Тег collection)
        {
            try
            {
                logger.Info(User.Identity.Name + " удалил в базе Тег.");
                Repository.RemoveТег(collection);
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
