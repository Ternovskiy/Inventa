using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventaDataModul;
using webInventa.Controllers;


namespace webInventa.Areas.Admin.Controllers
{
    public class Физическое_лицоController : BaseController
    {
        // GET: Admin/Физическое_лицо
        public ActionResult Index()
        {	
            return View(Repository.GetФизическое_лицо);
        }		        

        // GET: Admin/Физическое_лицо/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Физическое_лицо/Create
        [HttpPost]
        public ActionResult Create(Физическое_лицо collection)
        {
            if (ModelState.IsValid)
            try
            {
                Repository.CreateФизическое_лицо(collection);
				logger.Info(User.Identity.Name + " добавил в базу Физическое_лицо.");
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Физическое_лицо/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Repository.GetByIdФизическое_лицо(id));
        }

        // POST: Admin/Физическое_лицо/Edit/5
        [HttpPost]
        public ActionResult Edit(Физическое_лицо collection)
        {
            if (ModelState.IsValid)
            try
            {
                logger.Info(User.Identity.Name + " изменил в базе Физическое_лицо.");
                Repository.UpdateФизическое_лицо(collection);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Физическое_лицо/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Repository.GetByIdФизическое_лицо(id));
        }

        // POST: Admin/Физическое_лицо/Delete/5
        [HttpPost]
        public ActionResult Delete(Физическое_лицо collection)
        {
            try
            {
                logger.Info(User.Identity.Name + " удалил в базе Физическое_лицо.");
                Repository.RemoveФизическое_лицо(collection);
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
