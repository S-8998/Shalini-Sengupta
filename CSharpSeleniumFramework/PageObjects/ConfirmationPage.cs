using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace CSharpSeleniumFramework.PageObjects
{
	public class ConfirmationPage
	{
        IWebDriver driver;
		public ConfirmationPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            
        }

        [FindsBy(How = How.Id, Using = ("country"))]
        private IWebElement countryDropdown;

        [FindsBy(How = How.XPath, Using = ("//label[@for='checkbox2']"))]
        private IWebElement checkbox;

        [FindsBy(How = How.XPath, Using = ("//input[@type='submit']"))]
        private IWebElement submitButton;

        [FindsBy(How = How.XPath, Using = ("//div[contains(@class,'alert')]"))]
        private IWebElement alertMessage;

        public IWebElement country()
        {
            countryDropdown.SendKeys("ind");
            return countryDropdown;
        }

        public IWebElement checkboxClick()
        {
            checkbox.Click();
            return checkbox;
        }

        public IWebElement submit()
        {
            submitButton.Click();
            return submitButton;
        }

        public IWebElement alert()
        {
            return alertMessage;
        }

        public void waitForCountryDisplay()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.LinkText("India")));
            driver.FindElement(By.LinkText("India")).Click();
        }
        
    }
}

