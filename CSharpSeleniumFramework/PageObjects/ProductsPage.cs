using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace CSharpSeleniumFramework.PageObjects
{
	public class ProductsPage
	{
		IWebDriver driver;
		By cardTitle = By.CssSelector(".card-title a");
		By addToCart = By.CssSelector(".card-footer button");


        public ProductsPage(IWebDriver driver)
		{
			this.driver = driver;
			PageFactory.InitElements(driver, this);
		}

		
		//IList<IWebElement> products = driver.FindElements(By.TagName("app-card"));

		[FindsBy(How = How.TagName, Using = ("app-card"))]
		private IList<IWebElement> cards;

        [FindsBy(How = How.PartialLinkText, Using = ("Checkout"))]
        private IWebElement checkout;

        public void waitForPageDisplay()
		{
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.PartialLinkText("Checkout")));

        }

		public IList<IWebElement> getCards()
		{
			return cards;
		}

		public By getCardTitle()
		{
            return cardTitle;
		}

        public By addToCartButton()
        {
            return addToCart;
        }

		public CheckOutPage checkoutButton()
		{
			checkout.Click();
			return new CheckOutPage(driver);
        }
    }
}

