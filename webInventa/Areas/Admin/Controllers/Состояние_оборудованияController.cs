using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventaDataModul;
using webInventa.Controllers;


namespace webInventa.Areas.Admin.Controllers
{
    public class Состояние_оборудованияController : BaseController
    {
        // GET: Admin/Состояние_оборудования
        public ActionResult Index()
        {	
            return View(Repository.GetСостояние_оборудования);
        }		        

        // GET: Admin/Состояние_оборудования/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Состояние_оборудования/Create
        [HttpPost]
        public ActionResult Create(Состояние_оборудования collection)
        {
            if (ModelState.IsValid)
            try
            {
                Repository.CreateСостояние_оборудования(collection);
				logger.Info(User.Identity.Name + " добавил в базу Состояние_оборудования.");
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Состояние_оборудования/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Repository.GetByIdСостояние_оборудования(id));
        }

        // POST: Admin/Состояние_оборудования/Edit/5
        [HttpPost]
        public ActionResult Edit(Состояние_оборудования collection)
        {
            if (ModelState.IsValid)
            try
            {
                logger.Info(User.Identity.Name + " изменил в базе Состояние_оборудования.");
                Repository.UpdateСостояние_оборудования(collection);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Состояние_оборудования/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Repository.GetByIdСостояние_оборудования(id));
        }

        // POST: Admin/Состояние_оборудования/Delete/5
        [HttpPost]
        public ActionResult Delete(Состояние_оборудования collection)
        {
            try
            {
                logger.Info(User.Identity.Name + " удалил в базе Состояние_оборудования.");
                Repository.RemoveСостояние_оборудования(collection);
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
