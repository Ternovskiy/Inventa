using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventaDataModul;
using webInventa.Controllers;


namespace webInventa.Areas.Admin.Controllers
{
    public class Вид_показателяController : BaseController
    {
        // GET: Admin/Вид_показателя
        public ActionResult Index()
        {	
            return View(Repository.GetВид_показателя);
        }		        

        // GET: Admin/Вид_показателя/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Вид_показателя/Create
        [HttpPost]
        public ActionResult Create(Вид_показателя collection)
        {
            if (ModelState.IsValid)
            try
            {
                Repository.CreateВид_показателя(collection);
				logger.Info(User.Identity.Name + " добавил в базу Вид_показателя.");
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Вид_показателя/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Repository.GetByIdВид_показателя(id));
        }

        // POST: Admin/Вид_показателя/Edit/5
        [HttpPost]
        public ActionResult Edit(Вид_показателя collection)
        {
            if (ModelState.IsValid)
            try
            {
                logger.Info(User.Identity.Name + " изменил в базе Вид_показателя.");
                Repository.UpdateВид_показателя(collection);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Вид_показателя/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Repository.GetByIdВид_показателя(id));
        }

        // POST: Admin/Вид_показателя/Delete/5
        [HttpPost]
        public ActionResult Delete(Вид_показателя collection)
        {
            try
            {
                logger.Info(User.Identity.Name + " удалил в базе Вид_показателя.");
                Repository.RemoveВид_показателя(collection);
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
