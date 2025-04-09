using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumSpecFlowC
{
    public class ActionsHeroApp
    {
        private readonly IWebDriver _driver;

        public ActionsHeroApp(IWebDriver driver) 
        {
            _driver = driver;
        }
        public void ClickAbTestingButton() 
        {
            _driver.FindElement(PagesHeroApp.AbTestingButton).Click();
        }
        public void ClickAddRemoveElementButton()
        {
            _driver.FindElement(PagesHeroApp.AddRemoveElementsButton).Click();
        }
    }
}
