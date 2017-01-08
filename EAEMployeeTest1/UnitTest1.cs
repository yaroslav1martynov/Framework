using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using EAEMployeeTest1.Pages;
using EAAutoFramework.Base;

namespace EAEMployeeTest1
{
    [TestClass]
    public class UnitTest1
    {
        string url = "https://htmlacademy.ru/";
      

        [TestMethod]
        public void TestMethod1()
        {
            DriverContext.Driver = new FirefoxDriver();
            DriverContext.Driver.Navigate().GoToUrl(url);

            LoginPage page = new LoginPage();

            page.ClickLoginLink();
            page.Login("pliushkin2197@mail.ru", "ghjuhfvbcn");

            Courses courses = page.ClickCourses();
            courses.ClickProdoljyt();
          
         
        }
    }
}
