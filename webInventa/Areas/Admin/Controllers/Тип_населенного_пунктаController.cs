using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventaDataModul;
using webInventa.Controllers;


namespace webInventa.Areas.Admin.Controllers
{
    public class Тип_населенного_пунктаController : BaseController
    {
        // GET: Admin/Тип_населенного_пункта
        public ActionResult Index()
        {	
            return View(Repository.GetТип_населенного_пункта);
        }		        

        // GET: Admin/Тип_населенного_пункта/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Тип_населенного_пункта/Create
        [HttpPost]
        public ActionResult Create(Тип_населенного_пункта collection)
        {
            if (ModelState.IsValid)
            try
            {
                Repository.CreateТип_населенного_пункта(collection);
				logger.Info(User.Identity.Name + " добавил в базу Тип_населенного_пункта.");
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Тип_населенного_пункта/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Repository.GetByIdТип_населенного_пункта(id));
        }

        // POST: Admin/Тип_населенного_пункта/Edit/5
        [HttpPost]
        public ActionResult Edit(Тип_населенного_пункта collection)
        {
            if (ModelState.IsValid)
            try
            {
                logger.Info(User.Identity.Name + " изменил в базе Тип_населенного_пункта.");
                Repository.UpdateТип_населенного_пункта(collection);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Тип_населенного_пункта/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Repository.GetByIdТип_населенного_пункта(id));
        }

        // POST: Admin/Тип_населенного_пункта/Delete/5
        [HttpPost]
        public ActionResult Delete(Тип_населенного_пункта collection)
        {
            try
            {
                logger.Info(User.Identity.Name + " удалил в базе Тип_населенного_пункта.");
                Repository.RemoveТип_населенного_пункта(collection);
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
