using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventaDataModul;
using webInventa.Controllers;


namespace webInventa.Areas.Admin.Controllers
{
    public class Фр__труд__договораController : BaseController
    {
        // GET: Admin/Фр__труд__договора
        public ActionResult Index()
        {	
            return View(Repository.GetФр__труд__договора);
        }		        

        // GET: Admin/Фр__труд__договора/Create
        public ActionResult Create()
        {
            ViewBag.Drop1 = new SelectList(Repository.GetФизическое_лицо, "Код", "ФамилияИО");
            ViewBag.Drop2 = new SelectList(Repository.GetЮридическое_лицо, "Код", "Юр_лицо_Тип");
            ViewBag.Drop3 = new SelectList(Repository.GetДолжность, "Код", "Название");
            return View();
        }

        // POST: Admin/Фр__труд__договора/Create
        [HttpPost]
        public ActionResult Create(Фр__труд__договора collection)
        {
            if (ModelState.IsValid)
            try
            {
                Repository.CreateФр__труд__договора(collection);
				logger.Info(User.Identity.Name + " добавил в базу Фр__труд__договора.");
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Фр__труд__договора/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Drop1 = new SelectList(Repository.GetФизическое_лицо, "Код", "ФамилияИО");
            ViewBag.Drop2 = new SelectList(Repository.GetЮридическое_лицо, "Код", "Юр_лицо_Тип");
            ViewBag.Drop3 = new SelectList(Repository.GetДолжность, "Код", "Название");
            return View(Repository.GetByIdФр__труд__договора(id));
        }

        // POST: Admin/Фр__труд__договора/Edit/5
        [HttpPost]
        public ActionResult Edit(Фр__труд__договора collection)
        {
            if (ModelState.IsValid)
            try
            {
                logger.Info(User.Identity.Name + " изменил в базе Фр__труд__договора.");
                Repository.UpdateФр__труд__договора(collection);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Фр__труд__договора/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Repository.GetByIdФр__труд__договора(id));
        }

        // POST: Admin/Фр__труд__договора/Delete/5
        [HttpPost]
        public ActionResult Delete(Фр__труд__договора collection)
        {
            try
            {
                logger.Info(User.Identity.Name + " удалил в базе Фр__труд__договора.");
                Repository.RemoveФр__труд__договора(collection);
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
