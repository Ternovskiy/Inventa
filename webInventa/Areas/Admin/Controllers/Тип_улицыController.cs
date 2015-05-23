using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventaDataModul;
using webInventa.Controllers;


namespace webInventa.Areas.Admin.Controllers
{
    public class Тип_улицыController : BaseController
    {
        // GET: Admin/Тип_улицы
        public ActionResult Index()
        {
            //logger.Info("Application about click");
            return View(Repository.GetТип_улицы);
        }		        

        // GET: Admin/Тип_улицы/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Тип_улицы/Create
        [HttpPost]
        public ActionResult Create(Тип_улицы collection)
        {
            if (ModelState.IsValid)
            try
            {
                // TODO: Add insert logic here
                Repository.CreateТип_улицы(collection);
                try
                {logger.Info(User.Identity.Name + " добавил в базу Тип улицы("+collection.Название+").");
                }
                catch { }
                
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                try
                {logger.Error(User.Identity.Name + " - " + ex.Message);
                }
                catch{}
                
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Тип_улицы/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Repository.GetByIdТип_улицы(id));
        }

        // POST: Admin/Тип_улицы/Edit/5
        [HttpPost]
        public ActionResult Edit(Тип_улицы collection)
        {
            if (ModelState.IsValid)
            try
            {
                var s = Repository.GetByIdТип_улицы(collection.Код).Название;
                Repository.UpdateТип_улицы(collection);
                try
                {
                    logger.Info(User.Identity.Name + " изменил в базе Тип улицы(" + s + " => " + collection.Название + ").");
                }
                catch { } 
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Тип_улицы/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Repository.GetByIdТип_улицы(id));
        }

        // POST: Admin/Тип_улицы/Delete/5
        [HttpPost]
        public ActionResult Delete(Тип_улицы collection)
        {
            try
            {
                // TODO: Add delete logic here
                Repository.RemoveТип_улицы(collection);
                try
                {
                    logger.Info(User.Identity.Name + " удалил в базе Тип улицы(" + collection.Код + ").");
                }
                catch { } 
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View();
            }
        }
    }
}
