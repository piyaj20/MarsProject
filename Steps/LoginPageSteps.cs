using MarsProject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsProject.Steps
{
    [Binding]
    public class LoginPageSteps
    {
        private readonly IWebDriver driver;
        private LoginPage loginPage = new LoginPage();

        public LoginPageSteps()
        {
            // Open Browser      
            driver = new ChromeDriver();


            //maximize browser
            driver.Manage().Window.Maximize();

        }

        [AfterScenario]
        public void RunAfterEveryTest()
        {
            driver.Close();
        }

        [Given("I am at the login page")]
        public void GiveIAmAtTheLoginPage()
        {
            //LoginPage loginPage = new LoginPage();
            loginPage.navigateToLoginPage(driver);
            Console.WriteLine("I am at the login page");
        }

        [When("I click on Sign In")]
        public void WhenIClickOnSignIn()
        {
            //LoginPage loginPage = new LoginPage();
            loginPage.clickSignin(driver);
            Console.WriteLine("I click on Sign In");
        }

        [When("I enter valid credentials")]
        public void WhenIEnterValidCredentials()
        {
            //LoginPage loginPage = new LoginPage();
            loginPage.enterCredentials(driver);
            Console.WriteLine("I enter valid credentials");
        }

        [When("I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            //LoginPage loginPage = new LoginPage();
            loginPage.clickLoginButton(driver);
            Console.WriteLine("I click the login button");
        }

        [Then("I should be logged in successfully")]
        public void IShouldBeLoggedInSuccessfully()
        {
            //LoginPage loginPage = new LoginPage();
            bool isLoggedIn = loginPage.validateLoggedInSuccessfully(driver);
            Console.WriteLine("I should be logged in successfully");
            Assert.IsTrue(isLoggedIn);
        }

    }
}
