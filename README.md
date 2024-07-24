# SauceDemo Automated Testing Project

## Overview
This project contains automated tests for the SauceDemo website (https://www.saucedemo.com/). It uses Selenium WebDriver with C# and NUnit framework to perform various tests including login, purchase flow, and cart operations.

## Project Structure
- `SauceDemoTraining/`: Contains the main testing framework
  - `BasePage.cs`: Base class for page objects
  - `LocatorsAndUrls.cs`: Contains all locators and URLs used in tests
  - `UserData.cs`: Class to manage user data for tests
- `SauceDemoLoginTests/`: Contains login-related tests
- `SauceDemoCartTests/`: Contains cart and purchase-related tests

## Prerequisites
- .NET Core SDK (version X.X or higher)
- Edge WebDriver (ensure it's in your system PATH)
- NUnit 3 Test Adapter (for running tests in Visual Studio)

## Setup
1. Clone the repository:

git clone https://github.com/your-username/saucedemo-testing.git
text
2. Open the solution in Visual Studio or your preferred IDE.
3. Restore NuGet packages.

## Running Tests
- To run all tests: Use the Test Explorer in Visual Studio or run the following command in the terminal:

dotnet test
text
- To run specific test classes or methods, use the Test Explorer or specify the test in the command line:

dotnet test --filter "FullyQualifiedName~SuccesfullLogInTest"
text

## Test Cases
1. Successful Login
2. Failed Login
3. Add to Cart
4. Remove from Cart
5. Complete Purchase Flow

## Contributing
Please read CONTRIBUTING.md for details on our code of conduct, and the process for submitting pull requests.

## License
This project is licensed under the MIT License - see the LICENSE.md file for details.

## Acknowledgments
- SauceDemo for providing a great platform for practice
- Selenium WebDriver community
- NUnit framework developers
