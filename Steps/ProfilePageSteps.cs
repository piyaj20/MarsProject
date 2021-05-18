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
    public class ProfilePageSteps
    {
        private readonly IWebDriver driver;
        private ProfilePage profilePage;
        private LoginPage loginPage;
        

        public ProfilePageSteps()
        {
               
            driver = new ChromeDriver();
            loginPage = new LoginPage(driver);
            profilePage = new ProfilePage(driver);       


        }

        
        [Given("I am logged in")]
        public void GiveIAmLoggedIn()
        {
            loginPage.LoginSteps(driver);
            Console.WriteLine("I am logged in");
        }

        [Given("I am at the profile page")]
        public void IAmAtTheProfilePage()
        {
            profilePage.ValidateAtProfilePage();
            
        }

        [When("I click on Add New under Language tab")]
        public void WhenIClickOnAddNew()
        {
            profilePage.AddNewButton(driver);
        }

        [When("I enter the details for the new Language")]
        public void WhenIEnterDetailsForNewLanguage()
        {
            profilePage.AddLanguage(driver);
        }

        [When("I click on Add")]
        public void WhenIClickOnAdd()
        {
            profilePage.AddLangButton(driver);
        }

        [Then("I validate the language details are added successfully")]
        public void ValidateTheLanguageDetailsAreAddedSuccessfully()
        {
            profilePage.ValidateNewRecord(driver);
        }

        
        [When("I click on edit under Language tab")]
        public void WhenIClickOnEditLanguageButton()
        {
            profilePage.editLanguage(driver);
        }


        [When("I edit the details for the Language")]
        public void WhenIEditDetailsForLanguage()
        {
            profilePage.editLanguageDetails(driver);
        }


        [When("I click on Update")]
        public void WhenIClickOnUpdate()
        {
            profilePage.updateLanguageButton(driver);
        }

        [Then("I validate the language details are updated successfully")]
        public void ValidateTheLanguageDetailsAreUpdatedSuccessfully()
        {
            profilePage.validateDetailsUpdated(driver);
        }


        [When("I click on delete under Language tab")]
        public void WhenIClickOnDeleteLanguageButton()
        {
            profilePage.deleteLanguage(driver);
        }

        [Then("I validate the language details are deleted successfully")]
        public void ValidateTheLanguageDetailsAreDeletedSuccessfully()
        {
            profilePage.validateLanguageDeleted(driver);
        }


    }
}
