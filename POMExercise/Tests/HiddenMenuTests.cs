namespace POMExercise.Tests
{
    public class HiddenMenuTests : BaseTest
    {
        [SetUp]
        public void setUp()
        {
            Login("standard_user", "secret_sauce");
        }

        [Test]
        public void TestOpenMenu()
        {
            hiddenMenuPage.ClickHamburgerMenuButton();

            Assert.That(hiddenMenuPage.IsHamburgerMenuOpen(), Is.True, "Hamburger menu was not open");
        }

        [Test]
        public void TestLogout()
        {
            hiddenMenuPage.ClickHamburgerMenuButton();
            hiddenMenuPage.ClickLogoutButton();

            Assert.That(driver.Url, Is.EqualTo("https://www.saucedemo.com/"), "User was not logged out");
        }
    }
}
