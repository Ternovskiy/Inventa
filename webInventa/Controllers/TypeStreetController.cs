using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventaDataModul;
using Ninject;

namespace webInventa.Controllers
{
    public class TypeStreetController : BaseController
    {
        //[Inject]
        //public Repository Repository { get; set; }

        // GET: TypeStreet
        public ActionResult Index()
        {
            return View(Repository.GetТип_улицы);
        }


        // GET: TypeStreet/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TypeStreet/Create
        [HttpPost]
        public ActionResult Create(Тип_улицы collection)
        {
            if (ModelState.IsValid)
            try
            {
                // TODO: Add insert logic here
                Repository.CreateТип_улицы(collection);
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: TypeStreet/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Repository.GetByIdТип_улицы(id));
        }

        // POST: TypeStreet/Edit/5
        [HttpPost]
        public ActionResult Edit(Тип_улицы collection)
        {
            if (ModelState.IsValid)
            try
            {
                // TODO: Add update logic here
                Repository.UpdateТип_улицы(collection);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: TypeStreet/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Repository.GetByIdТип_улицы(id));
        }

        // POST: TypeStreet/Delete/5
        [HttpPost]
        public ActionResult Delete(Тип_улицы collection)
        {
            try
            {
                // TODO: Add delete logic here
                Repository.RemoveТип_улицы(collection);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View();
            }
        }
    }
}
