using OpenQA.Selenium;

namespace SeleniumSpecFlowC
{
    public static class PagesHeroApp
    {
        public static By AbTestingButton => By.XPath(
                "//a[text()='A/B Testing' and @href='/abtest']"
            );
        public static By AddRemoveElementsButton => By.XPath(
                "//a[text()='Add/Remove Elements' and @href='/add_remove_elements/']"
            );
    }
}
