using EAAutoFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using EAAutoFramework.Extansions;

namespace EAEMployeeTest1.Pages
{
   class FirstPageAfterRegistration : BasePage
    {

        [FindsBy(How = How.LinkText, Using = "Форум")]
        IWebElement lnkForum { get; set; }

        [FindsBy(How = How.Id, Using = "#header_pic")]
        IWebElement Tutor { get; set; }


        public ForumPage ClickForum()
        {
            lnkForum.Click();
            return GetInstance<ForumPage>();
        }

        internal void CheckIfLoginExist()
        {
            lnkForum.AssertElementPresent();
        }

        //метод проверки на сушествование 
        internal void CheckIfTxtExist()
        {
            WebElementExtensions.AssertElementPresent(Tutor);
        }

    }
}
