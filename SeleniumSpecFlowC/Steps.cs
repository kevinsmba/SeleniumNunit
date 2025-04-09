using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SeleniumSpecFlowC
{
    public class Tests
         //changing the comments 
    {
        private IWebDriver _driver;
        private ActionsHeroApp _actions;

        [SetUp]
        public void Setup()
        {
            // Initialize ChromeDriver
            _driver = new ChromeDriver();

            // Navigate to the testing page
            _driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");

            // Maximize the browser window (optional)
            _driver.Manage().Window.Maximize();
        }

        [Test]
        public void ABTesting()
        {
            _actions.ClickAbTestingButton();
            Assert.That(_driver.Url, Does.Contain("/abtest"));
        }

        [Test]
        public void AddRemoveElements() 
        {
            _actions.ClickAddRemoveElementButton();
            Assert.That(_driver.Url, Does.Contain("/add_remove_elements/"));
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Close();
        }
    }
}