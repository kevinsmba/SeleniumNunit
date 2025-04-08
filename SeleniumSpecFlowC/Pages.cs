using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumSpecFlowC
{
    public class PagesHeroApp
    {
        private readonly IWebDriver _driver;

        public PagesHeroApp (IWebDriver driver) 
        { 
            driver = _driver;
        }

        private IWebElement AbTestingButton => _driver.FindElement(By.XPath(
                "//a[text()='A/B Testing' and @href='/abtest']"
            ));
        private IWebElement AddRemoveElementsButton => _driver.FindElement(By.XPath(
                "//a[text()='Add/Remove Elements' and @href='/add_remove_elements/']"
            ));
    }
}
