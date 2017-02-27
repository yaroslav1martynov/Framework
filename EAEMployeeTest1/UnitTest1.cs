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
using EAAutoFramework.Config;


namespace EAEMployeeTest1
{
    [TestClass]
    public class UnitTest1: HookInitialize
    {

      

        [TestMethod]
        public void TestMethod1()
        {

            string fileName = Environment.CurrentDirectory.ToString() + "\\Data\\Login.xlsx";
            ExcelHelpers.PopulateInCollection(fileName);
            //Login Page
            CurrentPage = GetInstance<LoginPage>();
            //checking
            CurrentPage.AS<LoginPage>().CheckIfLoginExist();
            CurrentPage.AS<LoginPage>().Login(ExcelHelpers.ReadData(1, "UserName"), ExcelHelpers.ReadData(1, "Password"));
           // Thread.Sleep(3000);
            CurrentPage = CurrentPage.AS<LoginPage>().ClickForum();
           // Thread.Sleep(3000);
            CurrentPage.AS<ForumPage>().ClickContacts();
            // DriverContext.Driver.Quit();//my


        }


        [TestMethod]
        public void TableOperation()
        {
            string fileName = Environment.CurrentDirectory.ToString() + "\\Data\\Login.xlsx";
            ExcelHelpers.PopulateInCollection(fileName);

            CurrentPage = GetInstance<LoginPage>();
            CurrentPage.AS<LoginPage>().Login(ExcelHelpers.ReadData(1, "UserName"), ExcelHelpers.ReadData(1, "Password"));
            CurrentPage = CurrentPage.AS<LoginPage>().ClickForum();
          
            var tabel = CurrentPage.AS<ForumPage>().GetForumListtbl();         
            HtmlTableHelper.ReadTable(tabel);      
            HtmlTableHelper.PerformActionOnCell("0", "Разделы", "Английский язык", "Английский язык");
        }
    }
}
