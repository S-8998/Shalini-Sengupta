using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumLearning
{
	public class SeleniumFirstTest
	{
		IWebDriver driver;

		[SetUp]
		public void StartBrowser()
		{
            //Methods of webdriver interface - getUrl,click
            //chromedriver.exe take all actions on chrome browser

            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
			driver = new ChromeDriver();
			//driver = new FirefoxDriver(); //geckodriver

            driver.Manage().Window.Maximize();

            //ChromeDriver driver = new ChromeDriver();
        }


		[Test]
		public void Test1()
		{ 
            //driver.Navigate().GoToUrl("https://rahulshettyacademy.com");

            driver.Url = "https://rahulshettyacademy.com/loginpagePractise/";

			TestContext.Progress.WriteLine(driver.Title);
            TestContext.Progress.WriteLine(driver.Url);

			//driver.PageSource -- captures all html elements of webpage

			//driver.Close();
			//driver.Quit();
        }
	}
}

