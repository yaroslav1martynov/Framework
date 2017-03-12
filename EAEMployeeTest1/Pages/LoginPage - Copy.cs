using EAAutoFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using EAAutoFramework.Extansions;

namespace EAEMployeeTest1.Pages
{
   class LoginPage : BasePage
    {



        [FindsBy(How = How.Id, Using = "login")]
        IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Id, Using = "passw")]
        IWebElement txtPassword{ get; set; }

        [FindsBy(How = How.Id, Using = "submit_it")]
        IWebElement btnLogin { get; set; }


        public void Login(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
        }

        public HomePage ClickLoginButton()
        {
            btnLogin.Submit();
            return GetInstance<HomePage>();
        }


        public ForumPage ClickForum()
        {
            lnkForum.Click();
            return GetInstance<ForumPage>();
        }

        //метод проверки на сушествование 
        internal void CheckIfLoginExist()
        {
            txtUserName.AssertElementPresent();
        }
    }
}
