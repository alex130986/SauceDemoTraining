using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using NUnit.Framework;
using SauceDemoTraining;

namespace SauceDemoLoginTests.LogInTests
{
    [TestFixture]
    public class SuccesfullLogInTest
    {
        private IWebDriver _driver;
        public BasePage _loginPage;

        [SetUp]
        public void SetUp()
        {
            _driver = new EdgeDriver();
            _loginPage = new BasePage(_driver);
            _driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }

        [Test]
        public void LogInExistingUser_ShouldRedirectToLoggedPage()
        {
            // Arrange
            var userData = new UserData();

            // Act
            _loginPage.NavigateToMainPage();
            _loginPage.DataForSuccessfulLogIn(userData); // Исправлено имя метода

            // Assert
            Assert.That(_loginPage.IsLoggedIn(), Is.True); // Исправлено вызов метода
        }
    }
}