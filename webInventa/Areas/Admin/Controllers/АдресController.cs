using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using InventaDataModul;
using Ninject.Infrastructure.Language;
using webInventa.Controllers;


namespace webInventa.Areas.Admin.Controllers
{
    public class АдресController : BaseController
    {
        // GET: Admin/Адрес
        public ActionResult Index()
        {	
            return View(Repository.GetАдрес);
        }		        

        // GET: Admin/Адрес/Create
        public ActionResult Create()
        {
            
            var drop1= Repository.GetФизическое_лицо.Select(p =>
                new SelectListItem
                {
                    Text = p.Фамилия+" "+p.Имя[0]+". "+p.Отчество[0]+".",
                    Value = p.Код.ToString()
                }).ToList();
            drop1.Add(new SelectListItem{Selected = true, Text = "-",Value = ""});
            ViewBag.Drop1 = drop1;

            ViewBag.Drop2 = Repository.GetНаселенный_пункт.Select(p => new SelectListItem
            {
                Text = p.Тип_населенного_пункта.Название + " " + p.Название,
                Value = p.Код.ToString()
            }).ToList();

            ViewBag.Drop3 = Repository.GetУлица.Select(p => new SelectListItem
            {
                Text = p.Тип_улицы.Название+" "+p.Название,
                Value = p.Код.ToString()
            }).ToList();

            return View();
        }

        // POST: Admin/Адрес/Create
        [HttpPost]
        public ActionResult Create(Адрес collection)
        {
            if (ModelState.IsValid)
            try
            {
                Repository.CreateАдрес(collection);
				logger.Info(User.Identity.Name + " добавил в базу Адрес.");
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Адрес/Edit/5
        public ActionResult Edit(int id)
        {
            var drop1 = Repository.GetФизическое_лицо.Select(p =>
                new SelectListItem
                {
                    Text = p.Фамилия + " " + p.Имя[0] + ". " + p.Отчество[0] + ".",
                    Value = p.Код.ToString()
                }).ToList();
            drop1.Add(new SelectListItem {Text = "-", Value = "", Selected= Repository.GetByIdАдрес(id).Код_физического_лица==null });
            ViewBag.Drop1 = drop1;

            ViewBag.Drop2 = Repository.GetНаселенный_пункт.Select(p => new SelectListItem
            {
                Text = p.Тип_населенного_пункта.Название + " " + p.Название,
                Value = p.Код.ToString()
            }).ToList();

            ViewBag.Drop3 = Repository.GetУлица.Select(p => new SelectListItem
            {
                Text = p.Тип_улицы.Название + " " + p.Название,
                Value = p.Код.ToString()
            }).ToList();

            return View(Repository.GetByIdАдрес(id));
        }

        // POST: Admin/Адрес/Edit/5
        [HttpPost]
        public ActionResult Edit(Адрес collection)
        {
            if (ModelState.IsValid)
            try
            {
                logger.Info(User.Identity.Name + " изменил в базе Адрес.");
                Repository.UpdateАдрес(collection);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Адрес/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Repository.GetByIdАдрес(id));
        }

        // POST: Admin/Адрес/Delete/5
        [HttpPost]
        public ActionResult Delete(Адрес collection)
        {
            try
            {
                logger.Info(User.Identity.Name + " удалил в базе Адрес.");
                Repository.RemoveАдрес(collection);
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
