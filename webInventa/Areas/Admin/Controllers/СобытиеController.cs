using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventaDataModul;
using webInventa.Controllers;


namespace webInventa.Areas.Admin.Controllers
{
    public class СобытиеController : BaseController
    {
        // GET: Admin/Событие
        public ActionResult Index()
        {	
            return View(Repository.GetСобытие);
        }		        

        // GET: Admin/Событие/Create
        public ActionResult Create()
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
            ViewBag.Drop5 = Repository.GetЖурнал.Select(
                p => new SelectListItem
                {
                    Value = p.Номер.ToString(),
                    Text = p.Название
                }
                ).ToList();

            ViewBag.Drop6 = Repository.GetХост.Select(
                p => new SelectListItem()
                {
                    Value = p.Номер.ToString(),
                    Text = p.IP_адрес
                }
                ).ToList();

            ViewBag.Drop7 = Repository.GetТег.Select(
                p => new SelectListItem()
                {
                    Text = p.Название,
                    Value = p.Код.ToString()
                }
                ).ToList();
            ViewBag.Drop8 = Repository.GetТип_лога.Select(
                p => new SelectListItem()
                {
                    Value = p.Код.ToString(),
                    Text = p.Название
                }
                ).ToList();
            var m = new Событие();
            m.ModelЛог=new Лог();
            m.ModelПоказатель=new Показатель();
            return View(m);
        }

        // POST: Admin/Событие/Create
        [HttpPost]
        public ActionResult Create(Событие collection)
        {
            if (ModelState.IsValid)
            try
            {
                Repository.CreateСобытие(collection);
				logger.Info(User.Identity.Name + " добавил в базу Событие.");
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Событие/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Repository.GetByIdСобытие(id));
        }

        // POST: Admin/Событие/Edit/5
        [HttpPost]
        public ActionResult Edit(Событие collection)
        {
            if (ModelState.IsValid)
            try
            {
                logger.Info(User.Identity.Name + " изменил в базе Событие.");
                Repository.UpdateСобытие(collection);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Событие/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Repository.GetByIdСобытие(id));
        }

        // POST: Admin/Событие/Delete/5
        [HttpPost]
        public ActionResult Delete(Событие collection)
        {
            try
            {
                logger.Info(User.Identity.Name + " удалил в базе Событие.");
                Repository.RemoveСобытие(collection);
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
