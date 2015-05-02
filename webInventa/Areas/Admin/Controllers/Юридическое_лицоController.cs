using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventaDataModul;
using webInventa.Controllers;


namespace webInventa.Areas.Admin.Controllers
{
    public class Юридическое_лицоController : BaseController
    {
        // GET: Admin/Юридическое_лицо
        public ActionResult Index()
        {
            return View(Repository.GetЮридическое_лицо);
        }		        

        // GET: Admin/Юридическое_лицо/Create
        public ActionResult Create()
        {
            ViewBag.Drop1 = new SelectList(Repository.GetТип_юр__лица, "Код", "Название");
            var drop2 = Repository.GetЮридическое_лицо.Select(p => new SelectListItem
            {
                Value = p.Код.ToString(),
                Text = p.Тип_юр__лица.Название+" "+p.Название
            }).ToList();
            drop2.Add(new SelectListItem(){Selected = true,Text = "-",Value = ""});
            ViewBag.Drop2 = drop2;
            return View();
        }

        // POST: Admin/Юридическое_лицо/Create
        [HttpPost]
        public ActionResult Create(Юридическое_лицо collection)
        {
            if (ModelState.IsValid)
            try
            {
                Repository.CreateЮридическое_лицо(collection);
				logger.Info(User.Identity.Name + " добавил в базу Юридическое_лицо.");
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Юридическое_лицо/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Drop1 = new SelectList(Repository.GetТип_юр__лица, "Код", "Название");
            var drop2 = Repository.GetЮридическое_лицо.Select(p => new SelectListItem
            {
                Value = p.Код.ToString(),
                Text = p.Тип_юр__лица.Название + " " + p.Название
            }).ToList();
            drop2.Add(new SelectListItem{ Selected = Repository.GetByIdЮридическое_лицо(id).Код_юрид__лица==null,
                Text = "-", Value = "" });
            drop2.RemoveAll(p => p.Value == id.ToString());
            ViewBag.Drop2 = drop2;
            return View(Repository.GetByIdЮридическое_лицо(id));
        }

        // POST: Admin/Юридическое_лицо/Edit/5
        [HttpPost]
        public ActionResult Edit(Юридическое_лицо collection)
        {
            if (ModelState.IsValid)
            try
            {
                logger.Info(User.Identity.Name + " изменил в базе Юридическое_лицо.");
                Repository.UpdateЮридическое_лицо(collection);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Юридическое_лицо/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Repository.GetByIdЮридическое_лицо(id));
        }

        // POST: Admin/Юридическое_лицо/Delete/5
        [HttpPost]
        public ActionResult Delete(Юридическое_лицо collection)
        {
            try
            {
                logger.Info(User.Identity.Name + " удалил в базе Юридическое_лицо.");
                Repository.RemoveЮридическое_лицо(collection);
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
