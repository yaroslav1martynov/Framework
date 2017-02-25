using EAAutoFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAEMployeeTest1.Pages
{
    class ForumPage: BasePage
    {

        [FindsBy(How = How.LinkText, Using = "Контакты")]
        IWebElement lnkCreatecontacts { get; set; }

        [FindsBy(How = How.ClassName, Using = "forum")]//"forum"
        IWebElement tblForumList { get; set; }


        public Contacts ClickContacts()
        {
            lnkCreatecontacts.Click();
            return new Contacts();
        }     
        

        public IWebElement GetForumListtbl()
        {
            return tblForumList;
        }
    }
}
