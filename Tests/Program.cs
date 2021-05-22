using MarsProject.Pages;
using MarsProject.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace MarsProject
{
    [TestFixture]
    class Program : CommonDriver
    {
        /*static void Main(string[] args);
        {
        
        }
        */

        [SetUp]
        public void LoginProfile()
        {
            Console.WriteLine("Hello World!");

            // Open Browser and launch portal
            driver = new ChromeDriver();


            //page objects for login
            LoginPage loginObj = new LoginPage(driver);
            loginObj.LoginSteps(driver);
        }

        [Test]
        public void AddLanguageTest(IWebDriver driver, string Language)
        {
            //page objects for ProfilePage
            ProfilePage profileObj = new ProfilePage(driver);
            profileObj.AddLanguage(driver, Language);

        }

        [Test]
       public void EditLanguageTest()
        {
            //page objects for ProfilePage
            ProfilePage profileObj = new ProfilePage(driver);
            profileObj.editLanguage(driver);

        }
        

        /*
        [Test]
        public void DeleteLanguageTest()
        {
            //page objects for ProfilePage
            ProfilePage profileObj = new ProfilePage(driver);
            profileObj.deleteLanguage(driver);
        }
        */

       [TearDown]
        public void FinalSteps()
        {
            //close driver
            driver.Close();

        }

    }
}
