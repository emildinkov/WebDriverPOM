using OpenQA.Selenium;

namespace POMExercise.Pages
{
    public class LoginPage : BasePage
    {
        // Create Locators for elements
        private readonly By userNameField = By.Id("user-name");

        private readonly By passwordField = By.Id("password");

        private readonly By loginButton = By.Id("login-button");

        private readonly By errorMessage = By.XPath("// div[@class='error-message-container error']//h3");
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        // Create method for Fill username
        public void FillUserName(string username)
        {
            Type(userNameField, username);
        }

        // Create method for Fill password
        public void FillPassword(string password)
        {
            Type(passwordField, password);
        }

        // Create method for click Login button
        public void ClickLoginButton()
        {
            Click(loginButton);
        }

        // Create method for return Error Message
        public string GetErrorMessage()
        {
            return GetText(errorMessage);
        }

        // Create Main method for all methods
        public void LoginUser(string username, string password)
        {
            FillUserName(username);
            FillPassword(password);
            ClickLoginButton();
        }
    }
}
