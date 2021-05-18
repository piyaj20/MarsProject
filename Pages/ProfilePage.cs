using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

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
            //System.Threading.Thread.Sleep(1000);
            // validate if the user is at Profile Page
            IWebElement testdomain = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]"));


            if (testdomain.Text == "Test domain")
            {

                Console.WriteLine("At Profile Page, test passed");
                return true;
            }
            else
            {
                Console.WriteLine("Not at Profile Page, test failed");
                return false;
            }

        }


        public void AddNewButton(IWebDriver driver)
        {
            //Add Language
            IWebElement AddNewButton = driver.FindElement(By.CssSelector("div.ui:nth-child(1) div.ui.fluid.container div.ui.grid div.row div.eight.wide.column form.ui.form:nth-child(2) div.ui.bottom.attached.tab.segment.active.tooltip-target:nth-child(2) div.row div.twelve.wide.column.scrollTable div.form-wrapper table.ui.fixed.table thead:nth-child(1) tr:nth-child(1) th.right.aligned:nth-child(3) > div.ui.teal.button"));
            AddNewButton.Click();
            System.Threading.Thread.Sleep(3500);

        }

        public void AddLanguage(IWebDriver driver)
        {
            //Enter Language
            IWebElement AddLanguage = driver.FindElement(By.CssSelector("div.ui:nth-child(1) div.ui.fluid.container div.ui.grid div.row div.eight.wide.column form.ui.form:nth-child(2) div.ui.bottom.attached.tab.segment.active.tooltip-target:nth-child(2) div.row div.twelve.wide.column.scrollTable div.form-wrapper div.fields div.five.wide.field:nth-child(1) > input:nth-child(1)"));
            AddLanguage.SendKeys("French");

            //Select level
            IWebElement Level = driver.FindElement(By.CssSelector("div.ui:nth-child(1) div.ui.fluid.container div.ui.grid div.row div.eight.wide.column form.ui.form:nth-child(2) div.ui.bottom.attached.tab.segment.active.tooltip-target:nth-child(2) div.row div.twelve.wide.column.scrollTable div.form-wrapper div.fields div.five.wide.field:nth-child(2) > select.ui.dropdown"));
            Level.Click();
            IWebElement Level1 = driver.FindElement(By.CssSelector("div.ui:nth-child(1) div.ui.fluid.container div.ui.grid div.row div.eight.wide.column form.ui.form:nth-child(2) div.ui.bottom.attached.tab.segment.active.tooltip-target:nth-child(2) div.row div.twelve.wide.column.scrollTable div.form-wrapper div.fields div.five.wide.field:nth-child(2) select.ui.dropdown > option:nth-child(4)"));
            Level1.Click();

        }

        
        public void AddLangButton(IWebDriver driver)
        {
            //Click on Add
            IWebElement AddLangButton = driver.FindElement(By.CssSelector("div.ui:nth-child(1) div.ui.fluid.container div.ui.grid div.row div.eight.wide.column form.ui.form:nth-child(2) div.ui.bottom.attached.tab.segment.active.tooltip-target:nth-child(2) div.row div.twelve.wide.column.scrollTable div.form-wrapper div.fields div.six.wide.field:nth-child(3) > input.ui.teal.button:nth-child(1)"));
            AddLangButton.Click();
            System.Threading.Thread.Sleep(2500);
        }


         public void ValidateNewRecord(IWebDriver driver)
         {
            //Validate the details are added successfully

            IWebElement NewRecord = driver.FindElement(By.XPath("//td[contains(text(),'French')]"));


            // Assert
            if (NewRecord.Text == "French")
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


        public void editLanguage(IWebDriver driver)
        {
            IWebElement EditButton = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[4]/tr[1]/td[3]/span[1]/i[1]"));

            EditButton.Click();
            System.Threading.Thread.Sleep(3000);

        }

        public void editLanguageDetails(IWebDriver driver)
        {
            IWebElement EditLang = driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[1]/input[1]"));
            EditLang.Clear();
            //System.Threading.Thread.Sleep(1000);
            IWebElement EditLanguage = driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[1]/input[1]"));
            EditLanguage.SendKeys("German");

        }
        public void updateLanguageButton(IWebDriver driver)
        {
            IWebElement UpdateLang = driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/span[1]/input[1]"));
            UpdateLang.Click();
            System.Threading.Thread.Sleep(2500);
        }

        public void validateDetailsUpdated(IWebDriver driver)
        { 
            //Validate the Language details are updated successfully

            IWebElement EditRecord = driver.FindElement(By.XPath("//td[contains(text(),'German')]"));


            // Assert
            if (EditRecord.Text == "German")
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



        public void deleteLanguage(IWebDriver driver)
        {
            //Delete Language
            System.Threading.Thread.Sleep(2000);
            IWebElement DeleteButton = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[4]/tr[1]/td[3]/span[2]/i[1]"));
            DeleteButton.Click();
            System.Threading.Thread.Sleep(3000);
        }
       
        public void validateLanguageDeleted(IWebDriver driver)
        { 
            
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
    }
}

