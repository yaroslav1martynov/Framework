using EAAutoFramework.Base;
using EAEMployeeTest1.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace EAEMployeeTest1.Steps
{
    [Binding]
    public class LoginSteps : BaseSpep

    {
        [Given(@"I have navigated to the application")]
        public void GivenIHaveNavigatedToTheApplication()
        {
            NaviateSite();
            CurrentPage = GetInstance<HomePage>();
        }


        [Given(@"I see application opened")]
        public void GivenISeeApplicationOpened()
        {
            CurrentPage.AS<HomePage>().CheckIfLoginExist();
        }


        [When(@"I enter UserName and Password")]
        public void WhenIEnterUserNameAndPassword(Table table1)
        {
            dynamic data = table1.CreateDynamicInstance();

           CurrentPage = CurrentPage.AS<HomePage>().Login(data.UserName, data.Password);
        }


      [Then(@"I clic login button")]
        public void ThenIClickLoginButton()
        {
            CurrentPage.AS<HomePage>().ClickLoginButton();
        }

        [Then(@"I should see the username with hallo")]
        public void ThenIsSouldSeeTheДоброПожаловать()
        {
         CurrentPage.AS<FirstPageAfterRegistration>().CheckIfTxtExist();           
        }





    }
}
