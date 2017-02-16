using EAAutoFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace EAEMployeeTest1.Pages
{
    class LoginPage : BasePage
    {

        [FindsBy(How = How.LinkText, Using = "Форум")]
        IWebElement lnkForum { get; set; }

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
            btnLogin.Submit();
        }

       /* public void ClickLoginLink()
        {
           // lnkLogin.Click();
        }*/

        public ForumPage ClickForum()
        {
            lnkForum.Click();
            return GetInstance<ForumPage>();
            // return new Courses();
        }
    }
}
