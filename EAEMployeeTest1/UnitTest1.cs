using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using EAEMployeeTest1.Pages;
using EAAutoFramework.Base;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

namespace EAEMployeeTest1
{
    [TestClass]
    public class UnitTest1:Base
    {
        string url = "https://htmlacademy.ru/";

        public void OpenBrowser(BrowserType browserType = BrowserType.FireFox)
        {
            switch (browserType)
            {
                case BrowserType.InternetExplorer:
                    DriverContext.Driver = new InternetExplorerDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.FireFox:
                    DriverContext.Driver = new FirefoxDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.Chrome:
                    DriverContext.Driver = new ChromeDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                default:
                    DriverContext.Driver = new FirefoxDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
            }
        }

       // public object TimeUnit { get; private set; }

        [TestMethod]
        public void TestMethod1()
        {
            //  DriverContext.Driver = new FirefoxDriver();        
            // DriverContext.Driver.Navigate().GoToUrl(url);

            OpenBrowser(BrowserType.FireFox);
            DriverContext.Browser.GoToUrl(url);


            CurrentPage = GetInstance<LoginPage>();
            CurrentPage.AS<LoginPage>().ClickLoginLink();
            CurrentPage.AS<LoginPage>().Login("pliushkin2197@mail.ru", "ghjuhfvbcn");
            Thread.Sleep(3000);
            CurrentPage = CurrentPage.AS<LoginPage>().ClickCourses();
            Thread.Sleep(3000);
            CurrentPage.AS<Courses>().ClickProdoljyt();

        }
    }
}
