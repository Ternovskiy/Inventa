using System;
using System.Linq;
using System.Web.Mvc;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using InventaDataModul;
using NUnit.Framework;
using webInventa.Controllers;

namespace webInventa.Test
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            var controller = new TypeStreetController();

            controller.Repository = new MockRepository().Object;

            var result2 = controller.Index();

            var result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result.Model);


            var list = (IQueryable<Тип_улицы>) result.Model;
            Assert.AreEqual(list.Count(),2);
            Console.WriteLine(list.ToArray()[0].Название);
        }

        [Test]
        public void TestMethod2()
        {
            var controller = new TypeStreetController();

            controller.Repository = new MockRepository().Object;

            var result2 = controller.Index();

            var result = controller.Index() as ViewResult;
            

            var list = (IQueryable<Тип_улицы>)result.Model;

            Assert.AreEqual(list.ToArray()[0].Название, "Терешклвой");

            Console.WriteLine(list.ToArray()[0].Название);
        }
    }
}
