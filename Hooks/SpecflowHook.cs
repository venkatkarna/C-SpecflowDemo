using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProjectDemo.Hooks
{
  
[Binding]
    public class SpecFlowHooks
    {
        private IWebDriver driver;

        // Initialize WebDriver before the scenario
        [BeforeScenario]
        public void InitializeWebDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless");        
            options.AddArgument("--disable-gpu");    
            options.AddArgument("--no-sandbox");     

            driver = new ChromeDriver(options);
        }

        [AfterScenario]
        public void CloseWebDriver()
        {
            driver.Quit();
        }

        // Property to access the driver in your step definitions
        public IWebDriver Driver => driver;
    }

}

