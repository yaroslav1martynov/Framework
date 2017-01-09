using EAAutoFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace EAEMployeeTest1.Pages
{
    class LoginPage : BasePage
    {
        [FindsBy(How = How.LinkText, Using = "Войти")]
        public IWebElement lnkLogin { get; set; }

        //клик Курсы
        [FindsBy(How = How.CssSelector, Using = "ul.main-nav__list:nth-child(1) > li:nth-child(1) > a")]
        IWebElement lnkCuorse { get; set; }

        [FindsBy(How = How.Id, Using = "login-email")]
        IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Id, Using = "login-password")]
        IWebElement txtPassword{ get; set; }

        [FindsBy(How = How.CssSelector, Using = "input.button--full-width")]
        IWebElement btnLogin { get; set; }


        public void Login(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
            btnLogin.Submit();
        }

        public void ClickLoginLink()
        {
            lnkLogin.Click();
        }

        public Courses ClickCourses()
        {
            lnkCuorse.Click();
            return GetInstance<Courses>();
            // return new Courses();
        }
    }
}
