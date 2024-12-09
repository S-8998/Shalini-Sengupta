using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CSharpSeleniumFramework.PageObjects
{
	public class CheckOutPage
	{
        IWebDriver driver;
        public CheckOutPage(IWebDriver driver)
		{
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = ("//h4[@class='media-heading']/a[@href='#']"))]
        private IList<IWebElement> checkoutCards;

        [FindsBy(How = How.XPath, Using = ("//button[contains(text(),'Checkout')]"))]
        private IWebElement checkoutButton;

        public IList<IWebElement> getCards()
		{
			return checkoutCards;
		}

        public ConfirmationPage checkout()
        {
            checkoutButton.Click();
            return new ConfirmationPage(driver);
        }
    }
}

