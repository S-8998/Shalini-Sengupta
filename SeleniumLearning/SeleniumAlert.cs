using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumLearning
{
	public class SeleniumAlert
	{
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.Manage().Window.Maximize();
            driver.Url = "https://rahulshettyacademy.com/AutomationPractice/";

        }

        [Test]
        public void frames()
        {
            IWebElement framescroll =  driver.FindElement(By.Id("courses-iframe"));
            //scroll - javascript executor
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true)",framescroll);
            
            //frame id, frame name, frame index
            driver.SwitchTo().Frame("courses-iframe");
            driver.FindElement(By.LinkText("All Access Plan")).Click();
            TestContext.Progress.WriteLine(driver.FindElement(By.CssSelector("h1")).Text);

            //switching out from the frame
            driver.SwitchTo().DefaultContent();
            TestContext.Progress.WriteLine(driver.FindElement(By.CssSelector("h1")).Text);
        }

        [Test]
        public void test_Alert()
        {
            String name = "Rahul";
            driver.FindElement(By.Id("name")).SendKeys(name);
            driver.FindElement(By.XPath("//input[@onclick='displayConfirm()']")).Click();

            String alertText = driver.SwitchTo().Alert().Text;
            driver.SwitchTo().Alert().Accept();

            // driver.SwitchTo().Alert().SendKeys(""); -- to send any value to alert

            StringAssert.Contains(name, alertText);
        }

        [Test]
        public void test_AutoSuggestiveDropdown()
        {
            driver.FindElement(By.Id("autocomplete")).SendKeys("ind");
            Thread.Sleep(3000);

            IList<IWebElement> countries = driver.FindElements(By.XPath("//li[@class='ui-menu-item']/div"));

            foreach (IWebElement country in countries)
            {
                if(country.Text.Equals("India"))
                {
                    country.Click();
                }
            }

            //for runtime given values like india, which values we give by script we use getattribute
            TestContext.Progress.WriteLine(driver.FindElement(By.Id("autocomplete")).GetAttribute("value"));
        }

        [Test]
        public void test_Actions()
        {
            //driver.Url = "https://rahulshettyacademy.com/";
            Actions a = new Actions(driver);

            //for every action you need to give perform method

            //a.MoveToElement(driver.FindElement(By.CssSelector("a.dropdown-toggle"))).Perform();
            //a.MoveToElement(driver.FindElement(By.XPath("//ul[@class='dropdown-menu']/li[1]/a"))).Click().Perform();

            driver.Url = "https://demoqa.com/droppable";
            a.DragAndDrop(driver.FindElement(By.Id("draggable")), driver.FindElement(By.Id("droppable"))).Perform();

            //contextClick is for right click
        }
    }
}

