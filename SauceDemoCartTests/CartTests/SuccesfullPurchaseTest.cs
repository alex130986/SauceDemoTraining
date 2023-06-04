using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using SauceDemoTraining;

namespace SauceDemoCartTests.CartTests
{
    [TestFixture]
    public class SuccesfullPurchaseTest
    {
        private IWebDriver _driver;
        public DataForTests _loggedInUser;

        [SetUp]
        public void SetUp()
        {
            _driver = new EdgeDriver();
            _loggedInUser = new DataForTests(_driver);
            _driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }

        [Test]
        public void LogInExistingUser_ShouldAddProductToCartAndPurchase()
        {
            // Arrange
            var userData = new UserData();

            // Act
            _loggedInUser.NavigateToMainPage();
            _loggedInUser.DataForSuccesfullLogIn(userData);
            _loggedInUser.DataForPurchase(userData);

            // Assert
            Assert.That(_loggedInUser.IsSuccesfullPurchase, Is.True);
        }
    }
}