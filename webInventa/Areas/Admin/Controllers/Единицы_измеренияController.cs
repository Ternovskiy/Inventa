using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventaDataModul;
using webInventa.Controllers;


namespace webInventa.Areas.Admin.Controllers
{
    public class Единицы_измеренияController : BaseController
    {
        // GET: Admin/Единицы_измерения
        public ActionResult Index()
        {	
            return View(Repository.GetЕдиницы_измерения);
        }		        

        // GET: Admin/Единицы_измерения/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Единицы_измерения/Create
        [HttpPost]
        public ActionResult Create(Единицы_измерения collection)
        {
            if (ModelState.IsValid)
            try
            {
                Repository.CreateЕдиницы_измерения(collection);
				logger.Info(User.Identity.Name + " добавил в базу Единицы_измерения.");
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Единицы_измерения/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Repository.GetByIdЕдиницы_измерения(id));
        }

        // POST: Admin/Единицы_измерения/Edit/5
        [HttpPost]
        public ActionResult Edit(Единицы_измерения collection)
        {
            if (ModelState.IsValid)
            try
            {
                logger.Info(User.Identity.Name + " изменил в базе Единицы_измерения.");
                Repository.UpdateЕдиницы_измерения(collection);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Единицы_измерения/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Repository.GetByIdЕдиницы_измерения(id));
        }

        // POST: Admin/Единицы_измерения/Delete/5
        [HttpPost]
        public ActionResult Delete(Единицы_измерения collection)
        {
            try
            {
                logger.Info(User.Identity.Name + " удалил в базе Единицы_измерения.");
                Repository.RemoveЕдиницы_измерения(collection);
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
