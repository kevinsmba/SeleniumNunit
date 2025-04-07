using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;

namespace SeleniumSpecFlowC
{
    public class Tests
         //changing the comments 
    {
        private IWebDriver _driver;
        [SetUp]
        public void Setup()
        {
            // Initialize ChromeDriver (use WebDriverManager for auto-setup)
            _driver = new ChromeDriver();

            // Navigate to Google
            _driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");

            // Maximize the browser window (optional)
            _driver.Manage().Window.Maximize();
        }

        [Test]
        public void ABTesting()
        {
            // Using XPath with text + href
            IWebElement link = _driver.FindElement(By.XPath(
                "//a[text()='A/B Testing' and @href='/abtest']"
            ));
            link.Click();

            // Assert the new page loads
            Assert.That(_driver.Url, Does.Contain("/abtest"));
        }
        [TearDown]
        public void TearDown()
        {
            _driver.Close();
        }
    }
}