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
            ViewBag.Drop1 = Repository.GetФр__труд__договора.Select(p =>
                new SelectListItem
                {
                    Text = p.Физическое_лицо.ФамилияИО,
                    Value = p.Номер.ToString()
                }).ToList();

            ViewBag.Drop2 = Repository.GetТип_работ.Select(p =>
                new SelectListItem
                {
                    Text = p.Название,
                    Value = p.Код.ToString()
                }).ToList();

            ViewBag.Drop3 = Repository.GetОборудование.Select(p =>
                new SelectListItem
                {
                    Text = p.Номер.ToString(),
                    Value = p.Номер.ToString()
                }).ToList();
            ViewBag.Drop4 = Repository.GetХост.Select(p =>
                new SelectListItem
                {
                    Text = p.IP_адрес,
                    Value = p.Номер.ToString()
                }).ToList();

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
