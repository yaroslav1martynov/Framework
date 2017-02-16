using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using EAEMployeeTest1.Pages;
using EAAutoFramework.Base;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using EAAutoFramework.Helpers;
using OpenQA.Selenium.Support.UI;



namespace EAEMployeeTest1
{
    [TestClass]
    public class UnitTest1:Base
    {
        string url = "http://www.tutor.com.ua/index.php";

        public object TimeUnit { get; private set; }

        public void OpenBrowser(BrowserType browserType) //= BrowserType.FireFox)
        {
            switch (browserType)
            {
                case BrowserType.InternetExplorer:
                    DriverContext.Driver = new InternetExplorerDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                 
                    break;
                case BrowserType.FireFox:
                    DriverContext.Driver = new FirefoxDriver();
                    DriverContext.Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
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

        private IWebDriver IWebDriver_driver(ITimeouts timeouts)
        {
            throw new NotImplementedException();
        }

        // public object TimeUnit { get; private set; }

        [TestMethod]
        public void TestMethod1()
        {
            //  DriverContext.Driver = new FirefoxDriver();        
            // DriverContext.Driver.Navigate().GoToUrl(url);

            string fileName = Environment.CurrentDirectory.ToString() + "\\Data\\Login.xlsx";
            ExcelHelpers.PopulateInCollection(fileName);


            LogHelpers.CreateLogFile();
            OpenBrowser(BrowserType.FireFox);
            LogHelpers.Write("Open the browser !!!");
       
            DriverContext.Browser.GoToUrl(url);
           // DriverContext.Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));///????wait
            LogHelpers.Write("Navigated to the page");


            CurrentPage = GetInstance<LoginPage>();

           // CurrentPage.AS<LoginPage>().ClickLoginLink();

            CurrentPage.AS<LoginPage>().Login(ExcelHelpers.ReadData(1, "UserName"), ExcelHelpers.ReadData(1, "Password"));
            Thread.Sleep(3000);
            CurrentPage = CurrentPage.AS<LoginPage>().ClickForum();
            Thread.Sleep(3000);
            CurrentPage.AS<ForumPage>().ClickContacts();
            // DriverContext.Driver.Quit();//my

        }
        [TestMethod]
        public void TableOperation()
        {
            string fileName = Environment.CurrentDirectory.ToString() + "\\Data\\Login.xlsx";
            ExcelHelpers.PopulateInCollection(fileName);


            LogHelpers.CreateLogFile();
            OpenBrowser(BrowserType.FireFox);
            LogHelpers.Write("Open the browser !!!");

            DriverContext.Browser.GoToUrl(url);
            DriverContext.Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));//????wait
            LogHelpers.Write("Navigated to the page !!!");



            CurrentPage = GetInstance<LoginPage>();

            CurrentPage.AS<LoginPage>().Login(ExcelHelpers.ReadData(1, "UserName"), ExcelHelpers.ReadData(1, "Password"));
  
            CurrentPage = CurrentPage.AS<LoginPage>().ClickForum();
          
            var tabel = CurrentPage.AS<ForumPage>().GetForumListtbl();
           
            HtmlTableHelper.ReadTable(tabel);
         
            HtmlTableHelper.PerformActionOnCell("0", "Разделы", "Английский язык", "Английский язык");
        }
    }
}
