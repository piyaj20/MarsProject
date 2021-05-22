using MarsProject.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Support.UI;

namespace MarsProject.Pages
{
    class ProfilePage
    {
        private IWebDriver driver;

        public ProfilePage(IWebDriver driver)
        {
            this.driver = driver;
        }


        public bool ValidateAtProfilePage()
        {
            Wait.ElementExists(driver, "XPath", "//a[contains(text(),'Skills')]", 30);
            IWebElement DescriptionText = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3"));
            return DescriptionText.Displayed;
        }



        public void ClickDescriptionIcon()
        {
            Wait.ElementExists(driver, "XPath", "//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[1]/h3[1]/span[1]", 20);

            //click description icon
            IWebElement DescriptionIcon = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[1]/h3[1]/span[1]"));
            DescriptionIcon.Click();
        }

        
        public void EnterDescription(string description)
        {
            Wait.ElementExists(driver, "CssSelector", "div.ui:nth-child(1) div.ui.fluid.container div.ui.grid div.row div.eight.wide.column div.ui.fluid.card:nth-child(1) div.content form.ui.form div.tooltip-target.ui.grid div.row div.ui.twelve.wide.column div.field:nth-child(1) > textarea:nth-child(1)", 30);
            //enter description
            IWebElement Description = driver.FindElement(By.CssSelector("div.ui:nth-child(1) div.ui.fluid.container div.ui.grid div.row div.eight.wide.column div.ui.fluid.card:nth-child(1) div.content form.ui.form div.tooltip-target.ui.grid div.row div.ui.twelve.wide.column div.field:nth-child(1) > textarea:nth-child(1)"));
            Description.Clear();
            Description.SendKeys(description);
        }


        public void ClickSave()
        {
            //click save
            IWebElement Save = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/form[1]/div[1]/div[1]/div[2]/button[1]"));
            Save.Click();

        }


        public bool ValidateSavedDescription(string description)
        {
            Wait.ElementExists(driver, "CssSelector", "div.ui:nth-child(2) div.ui.fluid.container div.ui.grid div.row div.eight.wide.column div.ui.fluid.card:nth-child(1) div.content div:nth-child(1) > span:nth-child(2)", 40);

            //validate description is saved
            IWebElement SavedDescription = driver.FindElement(By.CssSelector("div.ui:nth-child(2) div.ui.fluid.container div.ui.grid div.row div.eight.wide.column div.ui.fluid.card:nth-child(1) div.content div:nth-child(1) > span:nth-child(2)"));
            if (SavedDescription.Text == description)
            {
                Console.WriteLine("Description is saved, test passed");
                return true;
            }
            else
            {
                Console.WriteLine("Description is not saved, test failed");
                return false;
            }
        }



        public void AddNewButton(IWebDriver driver)
        {
            Wait.ElementExists(driver, "XPath", "//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]", 40);

            //Add Language
            IWebElement AddNewButton = driver.FindElement(By.CssSelector("div.ui:nth-child(1) div.ui.fluid.container div.ui.grid div.row div.eight.wide.column form.ui.form:nth-child(2) div.ui.bottom.attached.tab.segment.active.tooltip-target:nth-child(2) div.row div.twelve.wide.column.scrollTable div.form-wrapper table.ui.fixed.table thead:nth-child(1) tr:nth-child(1) th.right.aligned:nth-child(3) > div.ui.teal.button"));
            AddNewButton.Click();

        }


        public void AddLanguage(IWebDriver driver, string Language)
        {
            Wait.ElementExists(driver, "XPath", "//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/input[1]", 30);

            //Enter Language
            IWebElement AddLanguage = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/input[1]"));
            AddLanguage.SendKeys(Language);


            //Select level
            SelectElement LanguageLevel = new SelectElement(driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/div[2]/select[1]")));
            LanguageLevel.SelectByValue("level");
            //IWebElement Level1 = driver.FindElement(By.CssSelector("div.ui:nth-child(1) div.ui.fluid.container div.ui.grid div.row div.eight.wide.column form.ui.form:nth-child(2) div.ui.bottom.attached.tab.segment.active.tooltip-target:nth-child(2) div.row div.twelve.wide.column.scrollTable div.form-wrapper div.fields div.five.wide.field:nth-child(2) select.ui.dropdown > option:nth-child(4)"));
            //Level1.Click();

        }


        public void AddLangButton(IWebDriver driver)
        {
            //Click on Add
            IWebElement AddLangButton = driver.FindElement(By.CssSelector("div.ui:nth-child(1) div.ui.fluid.container div.ui.grid div.row div.eight.wide.column form.ui.form:nth-child(2) div.ui.bottom.attached.tab.segment.active.tooltip-target:nth-child(2) div.row div.twelve.wide.column.scrollTable div.form-wrapper div.fields div.six.wide.field:nth-child(3) > input.ui.teal.button:nth-child(1)"));
            AddLangButton.Click();

        }


        public void ValidateNewRecord(string Language)
        {

            Wait.ElementExists(driver, "CssSelector", "div.ui:nth-child(1) div.ui.fluid.container div.ui.grid div.row div.eight.wide.column form.ui.form:nth-child(2) div.ui.bottom.attached.tab.segment.active.tooltip-target:nth-child(2) div.row div.twelve.wide.column.scrollTable div.form-wrapper table.ui.fixed.table tbody:nth-child(5) tr:nth-child(1) > td:nth-child(1)", 30);
            //Validate the details are added successfully

            IWebElement NewRecord = driver.FindElement(By.CssSelector("div.ui:nth-child(1) div.ui.fluid.container div.ui.grid div.row div.eight.wide.column form.ui.form:nth-child(2) div.ui.bottom.attached.tab.segment.active.tooltip-target:nth-child(2) div.row div.twelve.wide.column.scrollTable div.form-wrapper table.ui.fixed.table tbody:nth-child(5) tr:nth-child(1) > td:nth-child(1)"));


            // Assert
            if (NewRecord.Text == Language)
            {
                Console.WriteLine("Language added, test passed");
                Assert.Pass("Language added, test passed");
            }
            else
            {
                Console.WriteLine("test failed");
                Assert.Fail("test failed");
            }
        }



        public void ClickSkills()
        {
            Wait.ElementExists(driver, "XPath", "//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[1]/h3[1]/span[1]", 20);

            //click skills tab            

            IWebElement SkillsTab = driver.FindElement(By.XPath("//a[contains(text(),'Skills')]"));
            SkillsTab.Click();            
           
        }

        public void ClickAddNewSkill()
        {

            //click add new for skill
            IWebElement AddNewSkill = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned > div"));
            AddNewSkill.Click();
            
        }


        public void EnterSkill(string skill)
        {
            Wait.ElementExists(driver, "CssSelector", "div.ui:nth-child(1) div.ui.fluid.container div.ui.grid div.row div.eight.wide.column form.ui.form:nth-child(2) div.ui.bottom.attached.tab.segment.tooltip-target.active:nth-child(3) div.row div.twelve.wide.column.scrollTable div.form-wrapper div.fields div.five.wide.field:nth-child(1) > input:nth-child(1)", 30);

            //enter skill
            IWebElement Skills = driver.FindElement(By.CssSelector("div.ui:nth-child(1) div.ui.fluid.container div.ui.grid div.row div.eight.wide.column form.ui.form:nth-child(2) div.ui.bottom.attached.tab.segment.tooltip-target.active:nth-child(3) div.row div.twelve.wide.column.scrollTable div.form-wrapper div.fields div.five.wide.field:nth-child(1) > input:nth-child(1)"));
            Skills.SendKeys(skill);
            Console.WriteLine("Skill entered");
            
        }

        public void ChooseSkillLevel(string level)
        {
            SelectElement oSelect = new SelectElement(driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/div[2]/select[1]")));
            oSelect.SelectByValue("level");

            //choose skill level
           // IWebElement SkillLevel = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > select"));
           // SkillLevel.Click();

        }

        public void ClickAddSkill()
        {
            //click add for skill
            IWebElement AddSkill = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > span > input.ui.teal.button"));
            AddSkill.Click();
        }

        public bool ValidateAddedSkill(string skill)
        {
            Wait.ElementExists(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]", 30);

            //validate skill is added
            IWebElement AddedSkill = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));

            if (AddedSkill.Text == skill)
            {
                Console.WriteLine("Skill is added, test passed");
                return true;
            }
            else
            {
                Console.WriteLine("Skill is not added, test failed");
                return false;
            }
        }




        public void editLanguage(IWebDriver driver)
        {
            Wait.ElementExists(driver, "XPath", "//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[4]/tr[1]/td[3]/span[2]/i[1]", 20);
            
            IWebElement EditButton = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[4]/tr[1]/td[3]/span[1]/i[1]"));

            EditButton.Click();


        }

        public void editLanguageDetails(IWebDriver driver, string Languageupdated)
        {

            Wait.ElementExists(driver, "XPath", "//tbody/tr[1]/td[1]/div[1]/div[1]/input[1]", 30);

            IWebElement EditLang = driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[1]/input[1]"));
            EditLang.Clear();
           
            IWebElement EditLanguage = driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[1]/input[1]"));
            EditLanguage.SendKeys("Languageupdated");

        }

        public void updateLanguageButton(IWebDriver driver)
        {
            IWebElement UpdateLang = driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/span[1]/input[1]"));
            UpdateLang.Click();

        }

        public void validateDetailsUpdated(IWebDriver driver, string Languageupdated)
        {
            Wait.ElementExists(driver, "CssSelector", "div.ui:nth-child(1) div.ui.fluid.container div.ui.grid div.row div.eight.wide.column form.ui.form:nth-child(2) div.ui.bottom.attached.tab.segment.active.tooltip-target:nth-child(2) div.row div.twelve.wide.column.scrollTable div.form-wrapper table.ui.fixed.table tbody:nth-child(5) tr:nth-child(1) > td:nth-child(2)", 30);

            //Validate the Language details are updated successfully

            IWebElement EditRecord = driver.FindElement(By.CssSelector("div.ui:nth-child(1) div.ui.fluid.container div.ui.grid div.row div.eight.wide.column form.ui.form:nth-child(2) div.ui.bottom.attached.tab.segment.active.tooltip-target:nth-child(2) div.row div.twelve.wide.column.scrollTable div.form-wrapper table.ui.fixed.table tbody:nth-child(5) tr:nth-child(1) > td:nth-child(1)"));


            // Assert
            if (EditRecord.Text == "Languageupdated")
            {
                Console.WriteLine("Language updated, test passed");
                Assert.Pass("Language updated, test passed");
            }
            else
            {
                Console.WriteLine("test failed");
                Assert.Fail("test failed");
            }
        }


        /*
        public void deleteLanguage(IWebDriver driver)
        {

            Wait.ElementExists(driver, "XPath", "//td[contains(text(),'German')]", 5);

            //Delete Language

            IWebElement DeleteButton = driver.FindElement(By.CssSelector("div.ui:nth-child(1) div.ui.fluid.container div.ui.grid div.row div.eight.wide.column form.ui.form:nth-child(2) div.ui.bottom.attached.tab.segment.active.tooltip-target:nth-child(2) div.row div.twelve.wide.column.scrollTable div.form-wrapper table.ui.fixed.table tbody:nth-child(5) tr:nth-child(1) td.right.aligned:nth-child(3) span.button:nth-child(2) > i.remove.icon"));

            DeleteButton.Click();
            Console.WriteLine("Delete button clicked");

        }

        public void validateLanguageDeleted(IWebDriver driver)
        {

            Wait.ElementExists(driver, "XPath", "//td[contains(text(),'23')]", 30);
            //Validate the Language details are deleted successfully

            IWebElement DeleteRecord = driver.FindElement(By.XPath("//td[contains(text(),'23')]"));


            // Assert
            if (DeleteRecord.Text == "23")
            {
                Console.WriteLine("Language deleted, test passed");
                Assert.Pass("Language deleted, test passed");
            }
            else
            {
                Console.WriteLine("test failed");
                Assert.Fail("test failed");
            }

            //driver.Close();
        }

*/           
    }
}

