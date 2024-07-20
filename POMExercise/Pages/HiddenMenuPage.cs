using OpenQA.Selenium;

namespace POMExercise.Pages
{
    public class HiddenMenuPage : BasePage
    {
        // Locators for Elements
        protected readonly By hamburgerMenuButton = By.Id("react-burger-menu-btn");

        protected readonly By logoutButton = By.Id("logout_sidebar_link");
        public HiddenMenuPage(IWebDriver driver) : base(driver)
        {
        }

        // Create method for click Hamburger menu button
        public void ClickHamburgerMenuButton()
        {
            Click(hamburgerMenuButton);
        }

        // Create method for Click Logout button
        public void ClickLogoutButton()
        {
            Click(logoutButton);
        }

        // Create method for validation that Hamburger menu is open, whether logout button is displayed.
        public bool IsHamburgerMenuOpen()
        {
            return FindElement(logoutButton).Displayed;
        }
    }
}
