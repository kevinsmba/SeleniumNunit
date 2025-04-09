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
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
            _driver.Manage().Window.Maximize();

            _actions = new ActionsHeroApp(_driver);
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

    //    [TearDown]
    //    public void TearDown()
    //    {
    //        _driver.Close();
    //    }
    }
}