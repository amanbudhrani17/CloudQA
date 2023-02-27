using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

class Program
{
    static void Main(string[] args)
    {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://app.cloudqa.io/home/AutomationPracticeForm");
        
        IWebElement ShadowDOM = driver.FindElement(By.Id("shadowdomautomationtestform"));

        IWebElement firstName = ShadowDOM.FindElement(By.Id("fname"));
        firstName.SendKeys("Aman");

        IWebElement lastName = ShadowDOM.FindElement(By.Id("lname"));
        lastName.SendKeys("Budhrani");

        IWebElement gender = ShadowDOM.FindElement(By.Id("male"));
        gender.Click();

        IWebElement state = ShadowDOM.FindElement(By.Id("state"));
        state.SendKeys("India");

        IWebElement reading = ShadowDOM.FindElement(By.Id("Reading"));
        reading.Click();

        IWebElement cricket = ShadowDOM.FindElement(By.Id("Cricket"));
        cricket.Click();

        IWebElement aboutYourself = ShadowDOM.FindElement(By.Name("About"));
        aboutYourself.Click();
        aboutYourself.SendKeys("I am a software engineer.");

        IWebElement description = ShadowDOM.FindElement(By.Name("description"));
        description.Click();
        description.SendKeys("I am a student of IIIT Guwahati.");

        // To Close the browser uncomment this.
        // driver.Quit();
    }
}



