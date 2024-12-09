using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CSharpSeleniumFramework.PageObjects
{
	public class LoginPage
	{
		private IWebDriver driver;

		public LoginPage(IWebDriver driver)
		{
			this.driver = driver;
			PageFactory.InitElements(driver, this);
			//'this' refers to current class page object
			//initelements method connects all findsby annotation with driver
        }

		//Page Object factory
		[FindsBy(How = How.Id, Using = "username")]
		private IWebElement username;

		[FindsBy(How = How.XPath, Using = "//div[@class='form-group'][5]/label/span/input")]
		private IWebElement checkBox;

        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement password;

        [FindsBy(How = How.CssSelector, Using = "input[value='Sign In']")]
        private IWebElement signInButton;

		public ProductsPage validLogin(string user, string pass)
		{
			username.SendKeys(user);
			password.SendKeys(pass);
			checkBox.Click();
			signInButton.Click();

			return new ProductsPage(driver);
		}

        public IWebElement getUserName()
		{
			return username;
		}
		//Encapsulation example hiding variable by making username private but making getUsername method as public 


	}
}

