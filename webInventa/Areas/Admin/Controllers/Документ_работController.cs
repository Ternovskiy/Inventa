using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventaDataModul;
using webInventa.Controllers;


namespace webInventa.Areas.Admin.Controllers
{
    public class Документ_работController : BaseController
    {
        // GET: Admin/Документ_работ
        public ActionResult Index()
        {	
            return View(Repository.GetДокумент_работ);
        }		        

        // GET: Admin/Документ_работ/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Документ_работ/Create
        [HttpPost]
        public ActionResult Create(Документ_работ collection)
        {
            if (ModelState.IsValid)
            try
            {
                Repository.CreateДокумент_работ(collection);
				logger.Info(User.Identity.Name + " добавил в базу Документ_работ.");
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Документ_работ/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Repository.GetByIdДокумент_работ(id));
        }

        // POST: Admin/Документ_работ/Edit/5
        [HttpPost]
        public ActionResult Edit(Документ_работ collection)
        {
            if (ModelState.IsValid)
            try
            {
                logger.Info(User.Identity.Name + " изменил в базе Документ_работ.");
                Repository.UpdateДокумент_работ(collection);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Документ_работ/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Repository.GetByIdДокумент_работ(id));
        }

        // POST: Admin/Документ_работ/Delete/5
        [HttpPost]
        public ActionResult Delete(Документ_работ collection)
        {
            try
            {
                logger.Info(User.Identity.Name + " удалил в базе Документ_работ.");
                Repository.RemoveДокумент_работ(collection);
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
