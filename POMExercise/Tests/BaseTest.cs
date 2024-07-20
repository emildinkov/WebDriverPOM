using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using POMExercise.Pages;

namespace POMExercise.Tests
{
    public class BaseTest
    {
        protected IWebDriver driver;

        protected LoginPage loginPage;

        protected InventoryPage inventoryPage;

        protected CartPage cartPage;

        protected CheckoutPage checkoutPage;

        protected HiddenMenuPage hiddenMenuPage;

        [SetUp]
        public void SetUp()
        {
            // Functionality for very easy password
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddUserProfilePreference("profile.password_manager_enabled", false);

            driver = new ChromeDriver(chromeOptions);

            // Window Browser full Maximaze
            driver.Manage().Window.Maximize();

            // Set Implicit wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            loginPage = new LoginPage(driver);
            inventoryPage = new InventoryPage(driver);
            cartPage = new CartPage(driver);
            checkoutPage = new CheckoutPage(driver);
            hiddenMenuPage = new HiddenMenuPage(driver);
        }

        [TearDown]
        public void TearDown()
        {
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
            }
        }

        // Create method Login
        protected void Login(string username, string password)
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            var loginPage = new LoginPage(driver);
            loginPage.LoginUser(username, password);
        }
    }
}
