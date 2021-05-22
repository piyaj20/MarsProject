using MarsProject.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProject.Pages
{
    class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public LoginPage()
        {

        }

        public void login(string emailAddress, string password)
        {
            LoginSteps(driver);
            SignIn(driver);
            EnterCredentials(driver, emailAddress, password);

        }
        public void LoginSteps(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("http://localhost:5000");

            //maximize browser
            driver.Manage().Window.Maximize();
            
        }

        public void SignIn(IWebDriver driver)
        {

            Wait.ElementExists(driver, "XPath", "//*[@id='home']/div/div/div[1]/div/a", 20);
            //click sign in 
            IWebElement SignIn = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
            SignIn.Click();
        }

       

        internal void EnterCredentials(IWebDriver driver, string emailAddress, string password)
        {

            try
            {
              //Wait.ElementExists(driver, "XPath", "/html/body/div[2]/div/div/div[1]/div/div[1]/input", 20);
                //Enter email address
            IWebElement EmailAddress = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
                Console.WriteLine("Enter Email Address" + emailAddress);
                EmailAddress.SendKeys(emailAddress);

                //Enter password
                IWebElement Password = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
                Console.WriteLine("Enter Password" + password);
                Password.SendKeys(password);

                //Click Login
                IWebElement LoginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]"));
                LoginButton.Click();
            }
            catch (Exception msg)
            {
                Assert.Fail("Test failed at SignIn page", msg.Message);
            }

        }

       
    }

}