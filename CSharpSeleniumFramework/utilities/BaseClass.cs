using System;
using System.Configuration;
using System.Threading;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using WebDriverManager.DriverConfigs.Impl;

namespace CSharpSeleniumFramework.utilities
{
	public class BaseClass
	{
        public ExtentReports extent;
        ExtentTest test;
        String browserName;

        //report file
        [OneTimeSetUp]
        public void SetUp()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectpry = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            String reportPath = projectDirectpry + "/index.html";
            var htmlReporter = new ExtentHtmlReporter(reportPath);
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
            extent.AddSystemInfo("Host Name", "Local host");
            extent.AddSystemInfo("Environment", "QA");
            extent.AddSystemInfo("USER Name", "SHALINI SENGUPTA");
        }

        //public IWebDriver driver;
        public ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();

        [SetUp]
        public void StartBrowser()
        {
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
            browserName = TestContext.Parameters["broswerName"];
            //passing browsername from terminal

            if(browserName==null)
            {
                browserName = ConfigurationManager.AppSettings["browser"];
            }

            InitBrowser(browserName);
            //implicit wait
            driver.Value.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.Value.Manage().Window.Maximize();
            driver.Value.Url = "https://rahulshettyacademy.com/loginpagePractise/";

        }

        public IWebDriver getDriver()
        {
            return driver.Value;
        }

        public void InitBrowser(string browserName)
        {
            switch(browserName)
            {
                //factory design pattern
                case "Firefox":
                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                    driver.Value = new FirefoxDriver();
                    break;

                case "Chrome":
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    driver.Value = new ChromeDriver();
                    break;

                case "Edge":
                    new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                    driver.Value = new EdgeDriver();
                    break;

            }
        }

        public static JsonReader getDataParser()
        {
            return new JsonReader();
        }


        [TearDown]
        public void AfterTest()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = TestContext.CurrentContext.Result.StackTrace;

            DateTime time = DateTime.Now;
            String fileName = "Screenshot_" + time.ToString("h_mm_ss") + ".png";

            if(status.Equals(TestStatus.Failed))
            {
                test.Fail("Test failed", Capturescreenshot(driver.Value, fileName));
                test.Log(Status.Fail, "test failed with log trace" + stackTrace);
            }

            extent.Flush();
            driver.Value.Quit();
        }

        public MediaEntityModelProvider Capturescreenshot(IWebDriver driver,String screenShotName)
        {
            ITakesScreenshot ts = (ITakesScreenshot)driver;
            var screenshot = ts.GetScreenshot().AsBase64EncodedString;
            MediaEntityModelProvider mp = (MediaEntityModelProvider)MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot, screenShotName).Build();
            return mp;
        }
    }
}

