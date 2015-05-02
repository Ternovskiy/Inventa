using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventaDataModul;
using webInventa.Controllers;


namespace webInventa.Areas.Admin.Controllers
{
    public class Тип_юр__лицаController : BaseController
    {
        // GET: Admin/Тип_юр__лица
        public ActionResult Index()
        {	
            return View(Repository.GetТип_юр__лица);
        }		        

        // GET: Admin/Тип_юр__лица/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Тип_юр__лица/Create
        [HttpPost]
        public ActionResult Create(Тип_юр__лица collection)
        {
            if (ModelState.IsValid)
            try
            {
                Repository.CreateТип_юр__лица(collection);
				logger.Info(User.Identity.Name + " добавил в базу Тип_юр__лица.");
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Тип_юр__лица/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Repository.GetByIdТип_юр__лица(id));
        }

        // POST: Admin/Тип_юр__лица/Edit/5
        [HttpPost]
        public ActionResult Edit(Тип_юр__лица collection)
        {
            if (ModelState.IsValid)
            try
            {
                logger.Info(User.Identity.Name + " изменил в базе Тип_юр__лица.");
                Repository.UpdateТип_юр__лица(collection);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Тип_юр__лица/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Repository.GetByIdТип_юр__лица(id));
        }

        // POST: Admin/Тип_юр__лица/Delete/5
        [HttpPost]
        public ActionResult Delete(Тип_юр__лица collection)
        {
            try
            {
                logger.Info(User.Identity.Name + " удалил в базе Тип_юр__лица.");
                Repository.RemoveТип_юр__лица(collection);
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
