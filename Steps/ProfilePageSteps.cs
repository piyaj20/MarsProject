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
            loginPage.login("piyaj.20@gmail.com", "Priyanka@20");
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

        [When("I enter the details for the new Language (.*)")]
        public void WhenIEnterDetailsForNewLanguage(String Language)
        {
            profilePage.AddLanguage(driver, Language);
        }

        [When("I click on Add")]
        public void WhenIClickOnAdd()
        {
            profilePage.AddLangButton(driver);
        }

        [Then("I validate the language (.*) details are added successfully")]
        public void ValidateTheLanguageDetailsAreAddedSuccessfully(String Language)
        {
            profilePage.ValidateNewRecord(Language);
        }

        
        [When("I click on edit under Language tab")]
        public void WhenIClickOnEditLanguageButton()
        {
            profilePage.editLanguage(driver);
        }


        [When("I edit the details for the Language (.*)")]
        public void WhenIEditDetailsForLanguage(String Languageupdated)
        {
            profilePage.editLanguageDetails(driver, Languageupdated);
        }


        [When("I click on Update")]
        public void WhenIClickOnUpdate()
        {
            profilePage.updateLanguageButton(driver);
        }

        [Then("I validate the language (.*) details are updated successfully")]
        public void ValidateTheLanguageDetailsAreUpdatedSuccessfully(String Languageupdated)
        {
            profilePage.validateDetailsUpdated(driver, Languageupdated);
        }


      /*
        
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

        */


        [When("I click skills tab")]
        public void WhenIClickSkillsTab()
        {
            profilePage.ClickSkills();
            Console.WriteLine("I click skills tab");
        }


        [When("I click Add New in skills")]
        public void WhenIClickAddNewSkill()
        {
            profilePage.ClickAddNewSkill();
            Console.WriteLine("I click Add New in skills");
        }

        [When("I enter skill (.*)")]
        public void WhenIEnterSkill(String skill)
        {

            profilePage.EnterSkill(skill);
            Console.WriteLine("I enter skill");
        }

        [When("I choose skill level (.*)")]
        public void WhenIChooseSkillLevel(String level)
        {
            profilePage.ChooseSkillLevel(level);
            Console.WriteLine("I choose skill level");
        }

        [When("I click Add in skills")]
        public void WhenIClikAddSkill()
        {
            profilePage.ClickAddSkill();
            Console.WriteLine("I click add in skills");
        }

        [Then("Skill (.*) should be displayed on the profile page")]
        public void ThenAddedSkillDisplayedOnTheProfilePage(string skill)
        {
            bool IsAddedSkill = profilePage.ValidateAddedSkill(skill);
            Console.WriteLine("Skill should be added and displayed on the profile page");
            Assert.IsTrue(IsAddedSkill);
        }


        [When("I click description icon")]
        public void WhenIClickDescriptionIcon()
        {
            profilePage.ClickDescriptionIcon();
            Console.WriteLine("I click description icon");
        }

        [When("I enter description (.*)")]
        public void WhenIEnterDescription(String description)
        {
            profilePage.EnterDescription(description);
            Console.WriteLine("I enter description");
        }

        [When("I click save")]
        public void WhenIClickSave()
        {
            profilePage.ClickSave();
            Console.WriteLine("I click save");
        }


        [Then("Description (.*) should be displayed on the profile page")]
        public void ThenSavedDescriptionDisplayedOnTheProfilePage(string description)
        {
            bool IsSavedDescription = profilePage.ValidateSavedDescription(description);
            Console.WriteLine("Saved description should be displayed on the profile page");
            Assert.IsTrue(IsSavedDescription);
        }
    }
}
