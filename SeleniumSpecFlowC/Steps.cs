using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

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
            _driver.Navigate().GoToUrl("https://www.google.com");

            // Maximize the browser window (optional)
            _driver.Manage().Window.Maximize();
        }

        [Test]
        public void FirstTest()
        {
            Assert.Pass();
        }
    }
}