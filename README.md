# Automated Testing of Web Form using Selenium and C#

This program automates testing of few fields on the web form available at https://app.cloudqa.io/home/AutomationPracticeForm. It uses Selenium with C# to test the fields and ensure that they are working properly.

# Requirements
To run this program, you will need the following installed on your system:

1. Visual Studio (or any other C# IDE)
2. Selenium WebDriver
3. ChromeDriver (for Chrome browser)

# Usage

1. Clone this repository to your local machine.
2. Open the project in Visual Studio (or any other C# IDE).
3. Run the project and wait for the browser to open.
4. The program will automatically fill out some fields of the Shadow DOM web form.

# Testing

This program tests the below fields on the web form:

1. First Name
2. Last Name
3. Gender
4. State
5. Hobbies
6. About Yourself
7. Description

The program ensures that these fields are still working even if the position or any other properties except id, of the HTML elements for these fields change .
