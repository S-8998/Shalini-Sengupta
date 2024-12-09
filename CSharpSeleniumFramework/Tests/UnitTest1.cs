using System;
using System.Linq;
using AngleSharp.Text;
using CSharpSeleniumFramework.PageObjects;
using CSharpSeleniumFramework.utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using WebDriverManager.DriverConfigs.Impl;

namespace CSharpSeleniumFramework
{
    [Parallelizable(ParallelScope.Self)]
    public class E2ETest : BaseClass
    {
        //run all data sets of test in parallel - All
        //run all test menthods in one class parallel
        //run all test files in project parallel

        [Parallelizable(ParallelScope.All)]
        [Test]
        //[TestCase("rahulshettyacademy", "learning")] //sending test data
        [TestCaseSource("AddTestDataConfig"),Category("Regression")]

        public void EndToEndFlow(String username, String password, String[] expectedProducts)
        {
            //String[] expectedProducts = { "iphone X", "Blackberry" };
            String[] actualProducts = new string[2];

            LoginPage loginPage = new LoginPage(getDriver());
            ProductsPage productsPage = loginPage.validLogin(username,password);

            productsPage.waitForPageDisplay();


            IList<IWebElement> products = productsPage.getCards();

            foreach (IWebElement product in products)
            {
                if (expectedProducts.Contains(product.FindElement(productsPage.getCardTitle()).Text))
                {
                    product.FindElement(productsPage.addToCartButton()).Click();
                }

            }

            CheckOutPage checkOutPage = productsPage.checkoutButton();

            IList<IWebElement> models = checkOutPage.getCards();
            for (int i = 0; i < models.Count; i++)
            {
                actualProducts[i] = models[i].Text;

            }

            Assert.AreEqual(expectedProducts, actualProducts);

            ConfirmationPage confirmationPage = checkOutPage.checkout();

            confirmationPage.country();
            confirmationPage.waitForCountryDisplay();

            confirmationPage.checkboxClick();
            confirmationPage.submit();

            String alertmessage = confirmationPage.alert().Text;
            //Assert.AreEqual(" Thank you! Your order will be delivered in next few weeks :-)", alertmessage);

            StringAssert.Contains("Success", alertmessage);
        }

        [Test,Category("Smoke")]
        public void LocatorsIdentification()
        {
            driver.Value.FindElement(By.Id("username")).SendKeys("rahulshettyacademy");
            driver.Value.FindElement(By.Id("username")).Clear();
            driver.Value.FindElement(By.Id("username")).SendKeys("rahulshetty");

            driver.Value.FindElement(By.Name("password")).SendKeys("123456");

            //  tagname[attribute='value'] css selector
            //driver.FindElement(By.CssSelector("input[value='Sign In']")).Click();
            // #id -> #terms .classname .text-info (short css selectors)

            //xpath  --  //tagname[@attribute='value']
            driver.Value.FindElement(By.XPath("//div[@class='form-group'][5]/label/span/input")).Click();
            //driver.FindElement(By.CssSelector(".text-info span input")).Click();

            driver.Value.FindElement(By.XPath("//input[@value='Sign In']")).Click();

            //explicit wait
            WebDriverWait wait = new WebDriverWait(driver.Value, TimeSpan.FromSeconds(8));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions
                .TextToBePresentInElementValue(driver.Value.FindElement(By.XPath("//input[@name='signin']")), "Sign In"));

            String errorMessage = driver.Value.FindElement(By.ClassName("alert-danger")).Text;
            TestContext.Progress.WriteLine(errorMessage);

            IWebElement link = driver.Value.FindElement(By.LinkText("Free Access to InterviewQues/ResumeAssistance/Material"));

            //validate the url of the text
            String hrefAttr = link.GetAttribute("href");
            String expectedUrl = "https://rahulshettyacademy.com/documents-request";

            Assert.AreEqual(expectedUrl, hrefAttr);

        }

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

        public static IEnumerable<TestCaseData> AddTestDataConfig() //returning multiple testdata so need to make a Enumerable
        {
            yield return new TestCaseData(getDataParser().extractData("username"), getDataParser().extractData("password"), getDataParser().extractDataArray("products"));
            //getdataparser class coming from baseclass and from that we are calling jsonreader object and that is calling extractdata method

            yield return new TestCaseData(getDataParser().extractData("username_wrong"), getDataParser().extractData("password_wrong"), getDataParser().extractDataArray("products"));
        }
    }
}


