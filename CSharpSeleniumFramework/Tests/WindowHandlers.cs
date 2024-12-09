using System;
using CSharpSeleniumFramework.utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace CSharpSeleniumFramework
{
    [Parallelizable(ParallelScope.Self)]
    public class WindowHandlers :BaseClass
	{

        [Test]
        public void WindowHandle()
        {
            String email = "mentor@rahulshettyacademy.com";
            String parentWindow = driver.Value.CurrentWindowHandle;
            driver.Value.FindElement(By.ClassName("blinkingText")).Click();

            Assert.AreEqual(2, driver.Value.WindowHandles.Count);
            String childWindow = driver.Value.WindowHandles[1];

            driver.Value.SwitchTo().Window(childWindow);

            TestContext.Progress.WriteLine(driver.Value.FindElement(By.CssSelector(".red")).Text);

            String text = driver.Value.FindElement(By.CssSelector(".red")).Text;

            String[] splitedText = text.Split("at");
            String[] trimmedString = splitedText[1].Trim().Split(" ");

            Assert.AreEqual(email, trimmedString[0]);

            driver.Value.SwitchTo().Window(parentWindow);
            driver.Value.FindElement(By.Id("username")).SendKeys(trimmedString[0]);
        }
    }
}

