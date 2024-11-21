using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProjectDemo.StepDefinitions
{

    [Binding]
    public class Sample
    {
        private IWebDriver driver;

        [Given(@"open the browser")]
        public void GivenOpenTheBrowser()
        {
            driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

        }

        [When(@"Enter the URL")]
        public void WhenEnterTheURL()
        {
            driver.Url = "https://www.youtube.com/";
            Thread.Sleep(5000);
        }

        [Then(@"Search for TestersTalk")]
        public void ThenSearchForTestersTalk()
        {
            driver.FindElement(By.XPath("//input[@id='search']")).SendKeys("TestersTalk");
            driver.FindElement(By.XPath("//input[@id='search']")).SendKeys(Keys.Enter);
            Thread.Sleep(5000);
            driver.Quit();

        }

    }
}
