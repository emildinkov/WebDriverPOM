using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Collections.ObjectModel;

namespace POMExercise.Pages
{
    public class BasePage
    {
        protected IWebDriver driver;

        protected WebDriverWait wait;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        // Create Find Element method
        protected IWebElement FindElement(By by)
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(by));
        }

        // Create Find Elements method
        protected ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return driver.FindElements(by);
        }

        // Create Click method
        protected void Click(By by)
        {
            FindElement(by).Click();
        }

        // Create Type method
        protected void Type(By by, string text)
        {
            var element = FindElement(by);
            element.Clear();
            element.SendKeys(text);
        }

        // Create GetText method which find element and return his text
        protected string GetText(By by)
        {
            var element = FindElement(by);
            return element.Text;
        }
    }
}
