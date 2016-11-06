using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Bearcats_Football;
using Bearcats_Football.Controllers;
using System.Web.Routing;
using Bearcats_Football.Models;

namespace FootballTest
{
    [TestClass]
    public class ControllerTest
    {
        [TestMethod]
        public void Index()
        {
            //Arrange
            HomeController controller = new HomeController(); 

            //Act
            ViewResult result = controller.Index() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            ViewResult result = controller.About() as ViewResult;

            //Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void IndexPage()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            ViewResult result = controller.IndexPage() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Contact()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            ViewResult result = controller.Contact() as ViewResult;

            //Assert      
            Assert.AreEqual("Your contact page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Glossary()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            ViewResult result = controller.Glossary() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ColumnBasic()
        {
            ColumnBasicController controller = new ColumnBasicController();

            ViewResult result = controller.ColumnBasic() as ViewResult;

            Assert.IsNull(result);
        }

        [TestMethod]
        public void Waterfall()
        {
            WaterfallController controller = new WaterfallController();

            ViewResult result = controller.Waterfall() as ViewResult;

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void LineBasic()
        {
            LineBasicController controller = new LineBasicController();

            ViewResult result = controller.LineBasic() as ViewResult;

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void BarStacked()
        {
            BarStackedController controller = new BarStackedController();

            ViewResult result = controller.BarStacked() as ViewResult;

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void BarBasic()
        {
            BarBasicController controller = new BarBasicController();

            ViewResult result = controller.BarBasic() as ViewResult;

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void AreaBasic()
        {
            AreaBasicController controller = new AreaBasicController();

            ViewResult result = controller.AreaBasic() as ViewResult;

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void count()
        {
            Rushes rushes = new Rushes();

            int result = rushes.count;

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void opponent_team()
        {
            Rushes rushes = new Rushes();

            String result = rushes.opponent_team;

            Assert.IsNull(result);
        }
    }
}
