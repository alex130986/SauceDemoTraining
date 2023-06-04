﻿using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using SauceDemoTraining;

namespace SauceDemoLoginTests.LogInTests
{
    [TestFixture]
    public class SuccesfullLogInTest
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
        public void LogInExistingUser_ShouldRedirectToLoggedPage()
        {
            // Arrange
            var userData = new UserData();

            // Act
            _loginPage.NavigateToMainPage();
            _loginPage.DataForSuccesfullLogIn(userData);

            // Assert
            Assert.That(_loginPage.IsLoggedIn, Is.True);
        }
    }
}