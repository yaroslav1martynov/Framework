﻿using EAAutoFramework.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAAutoFramework.Extansions
{
    public static class WebDriverExtansions
    {

        //JS
        public static void WaitForPageLoaded(this IWebDriver driver)
        {
            driver.WaitForCondition(dri
                 =>
                 {
                     string state = dri.ExecuteJs("return document.readyState").ToString();
                     return state == "complete";
                 }, 10);
        }


        public static void WaitForCondition<T>(this T obj, Func<T, bool> condition, int timeOut)
        {
            Func<T, bool> execute =
                (arg) =>
                {
                    try
                    {
                        return condition(arg);
                    }
                    catch
                    {
                        return false;
                    }
                };

            var stopWatch = Stopwatch.StartNew();
            while(stopWatch.ElapsedMilliseconds < timeOut)
            {
                if (execute(obj))
                {
                    break;
                }
            }
        }
        //JS
        internal static object ExecuteJs(this IWebDriver driver, string script)
        {
            return ((IJavaScriptExecutor)DriverContext.Driver).ExecuteScript(script);
        }

    }
}
