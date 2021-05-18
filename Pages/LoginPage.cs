using OpenQA.Selenium;
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

        public void LoginSteps(IWebDriver driver)
        {
            navigateToLoginPage(driver);
            clickSignin(driver);
            enterCredentials(driver);
            clickLoginButton(driver);
            validateLoggedInSuccessfully(driver);

        }

              
        public void navigateToLoginPage(IWebDriver driver)
        {
            // Open Browser and launch the portal            
            driver.Navigate().GoToUrl("http://localhost:5000/");

            //maximize browser
            driver.Manage().Window.Maximize();
           
           System.Threading.Thread.Sleep(4000);
            
        }

       public void clickSignin(IWebDriver driver) 
        {
            //  Click on Signin
            IWebElement Signin = driver.FindElement(By.XPath("//a[contains(text(),'Sign In')]"));
            Signin.Click();
            System.Threading.Thread.Sleep(2000);
        }
        
        public void enterCredentials(IWebDriver driver)
        {
            //  Enter Username
            IWebElement Username = driver.FindElement(By.Name("email"));
            Username.SendKeys("piyaj.20@gmail.com");

            //  Enter Password
            IWebElement Password = driver.FindElement(By.Name("password"));
            Password.SendKeys("Priyanka@20");

            IWebElement Rememberme = driver.FindElement(By.XPath("/ html / body / div[2] / div / div / div[1] / div / div[3] / div / input"));
            Rememberme.Click();

        }

        public void clickLoginButton(IWebDriver driver)
        {
            //identify and click login button
            IWebElement LoginButton = driver.FindElement(By.CssSelector("body > div.ui.page.modals.dimmer.transition.visible.active > div > div > div:nth-child(1) > div > div:nth-child(5) > button"));
            LoginButton.Click();

            System.Threading.Thread.Sleep(4000);
        }

        public bool validateLoggedInSuccessfully(IWebDriver driver)
        {
            //System.Threading.Thread.Sleep(1000);
            // validate if the user is logged in successfully
            IWebElement testdomain = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]"));


            if (testdomain.Text == "Test domain")
            {

                Console.WriteLine("Logged in successfully, test passed");
                return true;
            }
            else
            {
                Console.WriteLine("Logged in failed, test failed");
                return false;
            }
        }
        

    }
}
