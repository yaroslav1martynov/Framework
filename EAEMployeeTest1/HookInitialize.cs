using EAAutoFramework.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace EAEMployeeTest1

{
    [Binding]
   public class HookInitialize : TestInitializeHook
    {

        public HookInitialize() : base(BrowserType.FireFox)
        {
            InitializeSettings();
           // NaviateSite();
        }


        [BeforeFeature]
        public static void TestStart()
        {
            HookInitialize init = new HookInitialize();
        }

    }
}
