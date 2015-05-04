using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventaDataModul;
using webInventa.Controllers;


namespace webInventa.Areas.Admin.Controllers
{
    public class UsersController : BaseController
    {
        // GET: Admin/Users
        public ActionResult Index()
        {	
            return View(Repository.GetUsers);
        }		        

        
        // GET: Admin/Users/Edit/5
        public ActionResult Edit(string id)
        {
            var item = Repository.GetByIdUsers(id);
            item.RoleAdmin = item.AspNetUserRoles.Any(p => p.AspNetRoles.Name == "admin");
            item.RoleUser = item.AspNetUserRoles.Any(p => p.AspNetRoles.Name == "user");
            item.RoleBoss = item.AspNetUserRoles.Any(p => p.AspNetRoles.Name == "boss");
            item.RoleEquipment = item.AspNetUserRoles.Any(p => p.AspNetRoles.Name == "equipment");
            var drop1 = Repository.GetФизическое_лицо.Select(p =>
                new SelectListItem
                {
                    Text = p.Фамилия + " " + p.Имя[0] + ". " + p.Отчество[0] + ".",
                    Value = p.Код.ToString()
                }).ToList();
            drop1.Add(new SelectListItem { Text = "-", Value = "", Selected =item.IdUser == null });
            ViewBag.Drop1 = drop1;
            return View(item);
        }

        // POST: Admin/Users/Edit/5
        [HttpPost]
        public ActionResult Edit(Users collection)
        {
            if (ModelState.IsValid)
            try
            {
                logger.Info(User.Identity.Name + " изменил в базе Users.");
                Repository.UpdateUsers(collection);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
				logger.Error(User.Identity.Name + " - " + ex.Message);
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: Admin/Users/Delete/5
        public ActionResult Delete(string id)
        {
            return View(Repository.GetByIdUsers(id));
        }

        // POST: Admin/Users/Delete/5
        [HttpPost]
        public ActionResult Delete(Users collection)
        {
            try
            {
                logger.Info(User.Identity.Name + " удалил в базе Users.");
                Repository.RemoveUsers(collection);
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
