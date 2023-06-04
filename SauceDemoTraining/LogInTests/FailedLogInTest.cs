using OpenQA.Selenium.Edge;
using OpenQA.Selenium;

namespace SauceDemoTraining.LogInTests
{
    [TestFixture]
    public class FailedLogInTest
    {
        private IWebDriver _driver;
        public DataForTests _loginPage;

        [SetUp]
        public void SetUp()
        {
            _driver = new EdgeDriver();
            _loginPage = new DataForTests(_driver);
            _driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }

        [Test]
        public void LogInExistingUser_ShouldNotRedirectToLoggedPage()
        {
            // Arrange
            var userData = new UserData();

            // Act
            _loginPage.NavigateToMainPage();
            _loginPage.DataForFailedLogIn(userData);

            // Assert
            Assert.That(_loginPage.IsNotLoggedIn, Is.True);
        }
    }
}