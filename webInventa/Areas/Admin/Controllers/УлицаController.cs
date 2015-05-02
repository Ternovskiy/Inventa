using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventaDataModul;
using webInventa.Controllers;


namespace webInventa.Areas.Admin.Controllers
{
    public class УлицаController : BaseController
    {
        // GET: Admin/Улица
        public ActionResult Index()
        {	
            return View(Repository.GetУлица);
        }		        

        // GET: Admin/Улица/Create
        public ActionResult Create()
        {
            ViewBag.Drop = new SelectList(Repository.GetТип_улицы, "Код", "Название");
            return View();
        }

        // POST: Admin/Улица/Create
        [HttpPost]
        public ActionResult Create(Улица collection)
        {
            if (ModelState.IsValid)
            try
            {
                Repository.CreateУлица(collection);
				logger.Info(User.Identity.Name + " добавил в базу Улица.");
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Улица/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Drop = new SelectList(Repository.GetТип_улицы, "Код", "Название");
            return View(Repository.GetByIdУлица(id));
        }

        // POST: Admin/Улица/Edit/5
        [HttpPost]
        public ActionResult Edit(Улица collection)
        {
            if (ModelState.IsValid)
            try
            {
                logger.Info(User.Identity.Name + " изменил в базе Улица.");
                Repository.UpdateУлица(collection);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Улица/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Repository.GetByIdУлица(id));
        }

        // POST: Admin/Улица/Delete/5
        [HttpPost]
        public ActionResult Delete(Улица collection)
        {
            try
            {
                logger.Info(User.Identity.Name + " удалил в базе Улица.");
                Repository.RemoveУлица(collection);
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
