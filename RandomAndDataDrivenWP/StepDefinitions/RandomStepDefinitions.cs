using NUnit.Framework;
using RandomAndDataDrivenWP.PageObject;
using System;
using TechTalk.SpecFlow;

namespace RandomAndDataDrivenWP.StepDefinitions
{
    [Binding]
    public class RandomStepDefinitions
    {
        RandomPageObject randomPageObject;
        public RandomStepDefinitions()
        { 
            randomPageObject = new RandomPageObject();
        }
        [Given(@"I navigate to the wesbite ""([^""]*)""")]
        public void GivenINavigateToTheWesbite(string url)
        {
            randomPageObject.NavigateToWebsite(url);
        }

        [Given(@"I Click on SignUp")]
        public void GivenIClickOnSignUp()
        {
            randomPageObject.ClickOnSignUP();
        }

        [Given(@"I Enter my Username ""([^""]*)""")]
        public void GivenIEnterMyUsername(string username)
        {
            randomPageObject.EnterUsername(username);
        }

        [Given(@"I Enter my email ""([^""]*)""")]
        public void GivenIEnterMyEmail(string email)
        {
            randomPageObject.EnterEmail(email);
        }

        [Given(@"I Enter passowrd ""([^""]*)""")]
        public void GivenIEnterPassowrd(string password)
        {
            randomPageObject.EnterPassword(password);
        }

        [When(@"I Click on the Sign up button")]
        public void WhenIClickOnTheSignUpButton()
        {
            randomPageObject.ClickOnLogin();
        }

        [Then(@"I Should be able to register succesfully")]
        public void ThenIShouldBeAbleToRegisterSuccesfully()
        {
            Assert.That(randomPageObject.IsNewArticleDisplayed(), Is.True); 
        }
    }
}
