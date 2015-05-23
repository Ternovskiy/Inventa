using System;
using System.Linq;
using System.Web.Mvc;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using InventaDataModul;
using NUnit.Framework;
using webInventa.Areas.Admin.Controllers;
using webInventa.Controllers;

namespace webInventa.Test
{
    [TestFixture]
    public class UnitTestTypeStreet
    {
        [Test]
        public void TestMethodList()
        {//Проверка списка всех типов улиц
            var controller = new Тип_улицыController();
            controller.Repository = new MockRepository().Object;
            var result = controller.Index() as ViewResult;
            //Assert.IsNotNull(result.Model);
            //var list = (IQueryable<Тип_улицы>) result.Model;
            //Assert.AreEqual(list.Count(),2);
            //Assert.AreEqual(list.ToArray()[0].Название, "Проспект");
            //Assert.AreEqual(list.ToArray()[1].Название, "Улица");
        }
        [Test]
        public void TestMethodCreate()
        {//Проверка операции добавления
            var controller = new Тип_улицыController();
            controller.Repository = new MockRepository().Object;
            var result = controller.Create(new Тип_улицы{Код = 3,Название = "Переулок"}) as ViewResult;
            //Assert.IsNotNull(result.Model);
            //var list = (IQueryable<Тип_улицы>)result.Model;
            //Assert.AreEqual(list.ToArray()[2].Название, "Переулок");
        }
        [Test]
        public void TestMethodUpdata()
        {//Проверка операции редактирования
            var controller = new Тип_улицыController();
            controller.Repository = new MockRepository().Object;
            var result = controller.Edit(new Тип_улицы { Код = 1, Название = "Переулок" }) as ViewResult;
            //Assert.IsNotNull(result.Model);
            //var list = (IQueryable<Тип_улицы>)result.Model;
            //Assert.AreEqual(list.ToArray()[0].Название, "Переулок");
        }
        [Test]
        public void TestMethodDelete()
        {//Проверка операции Удаления
            var controller = new Тип_улицыController();
            controller.Repository = new MockRepository().Object;
            var result = controller.Delete(new Тип_улицы { Код = 1}) as ViewResult;
            //Assert.IsNotNull(result.Model);
            //var list = (IQueryable<Тип_улицы>)result.Model;
            //Assert.AreEqual(list.Count(), 1);
            //Assert.AreEqual(list.ToArray()[0].Название, "Улица");
        }
    }
}
