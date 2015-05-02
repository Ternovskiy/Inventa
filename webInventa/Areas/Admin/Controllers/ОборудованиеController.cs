using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventaDataModul;
using webInventa.Controllers;


namespace webInventa.Areas.Admin.Controllers
{
    public class ОборудованиеController : BaseController
    {
        // GET: Admin/Оборудование
        public ActionResult Index()
        {	
            return View(Repository.GetОборудование);
        }

        public ActionResult ListПоказатели(int id)
        {
            return PartialView(Repository.GetПоказательОборудование.Where(p=>p.Код_Оборудования==id));
        }

        // GET: Admin/Оборудование/Create
        public ActionResult Create()
        {
            ViewBag.Drop = new SelectList(Repository.GetЮридическое_лицо, "Код", "Юр_лицо_Тип");
            return View();
        }

        // POST: Admin/Оборудование/Create
        [HttpPost]
        public ActionResult Create(Оборудование collection)
        {
            if (ModelState.IsValid)
            try
            {
                Repository.CreateОборудование(collection);
				logger.Info(User.Identity.Name + " добавил в базу Оборудование.");
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }


        // GET: Admin/Оборудование/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Drop = new SelectList(Repository.GetЮридическое_лицо, "Код", "Юр_лицо_Тип");
            return View(Repository.GetByIdОборудование(id));
        }

        public ActionResult EditListПоказатели(int id)
        {
            //ViewBag.Drop = Repository.GetПоказательОборудование.Select(p => new SelectListItem()
            //{
            //    Text = p.Показатель.Представление,
            //    Value = p.Код_Показателя.ToString()
            //}).ToList();
            return PartialView(Repository.GetПоказательОборудование.Where(p => p.Код_Оборудования == id));
        }

        // POST: Admin/Оборудование/Edit/5
        [HttpPost]
        public ActionResult Edit(Оборудование collection)
        {
            if (ModelState.IsValid)
            try
            {
                logger.Info(User.Identity.Name + " изменил в базе Оборудование.");
                Repository.UpdateОборудование(collection);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Оборудование/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Repository.GetByIdОборудование(id));
        }

        // POST: Admin/Оборудование/Delete/5
        [HttpPost]
        public ActionResult Delete(Оборудование collection)
        {
            try
            {
                logger.Info(User.Identity.Name + " удалил в базе Оборудование.");
                Repository.RemoveОборудование(collection);
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
