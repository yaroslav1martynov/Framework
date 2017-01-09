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
    class Courses: BasePage
    {
        //  [FindsBy(How = How.CssSelector, Using = "button.button--full-width")]
        // public IWebElement lnkMoreImpresshons { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a.button.button--green.button--split-effect")]
        public IWebElement prodolgit { get; set; }
       
        public Prodoljit ClickProdoljyt()
        {
            prodolgit.Click();
            return new Prodoljit();
        }      
    }
}
