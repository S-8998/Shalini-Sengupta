using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumLearning
{
	public class Locators
	{
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();

            //implicit wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.Manage().Window.Maximize();
            driver.Url = "https://rahulshettyacademy.com/loginpagePractise/";

        }

        [Test]
        public void LocatorsIdentification()
        {
            driver.FindElement(By.Id("username")).SendKeys("rahulshettyacademy");
            driver.FindElement(By.Id("username")).Clear();
            driver.FindElement(By.Id("username")).SendKeys("rahulshetty");

            driver.FindElement(By.Name("password")).SendKeys("123456");

            //  tagname[attribute='value'] css selector
            //driver.FindElement(By.CssSelector("input[value='Sign In']")).Click();
            // #id -> #terms .classname .text-info (short css selectors)

            //xpath  --  //tagname[@attribute='value']
            driver.FindElement(By.XPath("//div[@class='form-group'][5]/label/span/input")).Click();
            //driver.FindElement(By.CssSelector(".text-info span input")).Click();

            driver.FindElement(By.XPath("//input[@value='Sign In']")).Click();

            //explicit wait
            WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromSeconds(8));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions
                .TextToBePresentInElementValue(driver.FindElement(By.XPath("//input[@name='signin']")),"Sign In"));

            String errorMessage = driver.FindElement(By.ClassName("alert-danger")).Text;
            TestContext.Progress.WriteLine(errorMessage);

            IWebElement link = driver.FindElement(By.LinkText("Free Access to InterviewQues/ResumeAssistance/Material"));

            //validate the url of the text
            String hrefAttr = link.GetAttribute("href");
            String expectedUrl = "https://rahulshettyacademy.com/documents-request";

            Assert.AreEqual(expectedUrl, hrefAttr);

            

        }
    }
}

