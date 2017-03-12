using EAAutoFramework.Config;
using EAAutoFramework.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAAutoFramework.Base
{
    public abstract class BaseSpep : Base
    {
        public virtual void NaviateSite()
        {
            DriverContext.Browser.GoToUrl(Settings.AUT);
            LogHelpers.Write("Open the browser !!!");
        }
    }
}

