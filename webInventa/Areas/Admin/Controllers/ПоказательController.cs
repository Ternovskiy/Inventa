using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventaDataModul;
using Ninject.Infrastructure.Language;
using webInventa.Controllers;


namespace webInventa.Areas.Admin.Controllers
{
    public class ПоказательController : BaseController
    {
        // GET: Admin/Показатель
        public ActionResult Index()
        {	
            return View(Repository.GetПоказатель);
        }		        

        // GET: Admin/Показатель/Create
        public ActionResult Create()
        {
            //var drop1 = new SelectList(Repository.GetЕдиницы_измерения, "Код", "Представление");

            var drop1 = Repository.GetЕдиницы_измерения.Select(p => new SelectListItem
            {
                Value = p.Код.ToString(),
                Text = p.Представление
            }).ToList();
            drop1.Add(new SelectListItem { Selected = true, Text = "-", Value = "" });
            ViewBag.Drop1 = drop1; 
            ViewBag.Drop2 = new SelectList(Repository.GetВид_показателя, "Код", "Название");
            ViewBag.Drop3 = new SelectList(Repository.GetТип_показателя, "Код", "Название");
            //var Drop4 = new SelectList(Repository.GetПоказатель, "Код", "Представление").ToList();
            var Drop4 = Repository.GetПоказатель.Select(p => new SelectListItem
            {
                Value = p.Код.ToString(),
                Text = p.Представление
            }).ToList();
            Drop4.Add(new SelectListItem { Selected = true, Text = "-", Value = "" });
            ViewBag.Drop4 =Drop4;
            return View();
        }

        // POST: Admin/Показатель/Create
        [HttpPost]
        public ActionResult Create(Показатель collection)
        {
            if (ModelState.IsValid)
            try
            {
                Repository.CreateПоказатель(collection);
				logger.Info(User.Identity.Name + " добавил в базу Показатель.");
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Показатель/Edit/5
        public ActionResult Edit(int id)
        {
            var drop1 = Repository.GetЕдиницы_измерения.Select(p => new SelectListItem
            {
                Value = p.Код.ToString(),
                Text = p.Представление
            }).ToList();
            drop1.Add(new SelectListItem { Selected = true, Text = "-", Value = "" });
            ViewBag.Drop1 = drop1;
            ViewBag.Drop2 = new SelectList(Repository.GetВид_показателя, "Код", "Название");
            ViewBag.Drop3 = new SelectList(Repository.GetТип_показателя, "Код", "Название");
            //var Drop4 = new SelectList(Repository.GetПоказатель, "Код", "Представление").ToList();
            var Drop4 = Repository.GetПоказатель.Select(p => new SelectListItem
            {
                Value = p.Код.ToString(),
                Text = p.Представление
            }).ToList();
            Drop4.Add(new SelectListItem { Selected = true, Text = "-", Value = "" });
            ViewBag.Drop4 = Drop4;
            return View(Repository.GetByIdПоказатель(id));
        }

        // POST: Admin/Показатель/Edit/5
        [HttpPost]
        public ActionResult Edit(Показатель collection)
        {
            if (ModelState.IsValid)
            try
            {
                logger.Info(User.Identity.Name + " изменил в базе Показатель.");
                Repository.UpdateПоказатель(collection);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Показатель/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Repository.GetByIdПоказатель(id));
        }

        // POST: Admin/Показатель/Delete/5
        [HttpPost]
        public ActionResult Delete(Показатель collection)
        {
            try
            {
                logger.Info(User.Identity.Name + " удалил в базе Показатель.");
                Repository.RemoveПоказатель(collection);
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
