using EAAutoFramework.Base;
using EAAutoFramework.Extansions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EAEMployeeTest1.Pages
{
    internal class HomePage : BasePage
    {

        [FindsBy(How = How.Id, Using = "login")]
        IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Id, Using = "passw")]
        IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Id, Using = "submit_it")]
        IWebElement btnLogin { get; set; }


        public void Login(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
        }

        public FirstPageAfterRegistration ClickLoginButton()
        {
            btnLogin.Submit();
            return GetInstance<FirstPageAfterRegistration>();
        }

        internal void CheckIfLoginExist()
        {
            btnLogin.GetLinkText();
        }


    }
}
