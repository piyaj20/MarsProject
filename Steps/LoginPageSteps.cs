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

        /*fterScenario]
        public void RunAfterEveryTest()
        {
            driver.Close();
        }*/

        [Given("I am at the login page")]
        public void GiveIAmAtTheLoginPage()
        {
            //LoginPage loginPage = new LoginPage();
            loginPage.LoginSteps(driver);
            Console.WriteLine("I am at the login page");
        }

        [When("I click on Sign In")]
        public void WhenIClickOnSignIn()
        {
            //LoginPage loginPage = new LoginPage();
            loginPage.SignIn(driver);
            Console.WriteLine("I click on Sign In");
        }

        [Then(@"I login with (.*) and with (.*)")]
        public void ThenIEnterValidCredentials(string username, string password)
        {
            //LoginPage loginPage = new LoginPage();
            loginPage.EnterCredentials(driver, username, password);
            Console.WriteLine("I login with username =" + username + " and with password =" + password);
        }

    }
    
}
