using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Opera;
using NUnit.Framework;

namespace FirstWebProject
{
    class NUnitTest
    {
        IWebDriver driver;
        
        [Test]
        public void OpenAppFirefox()
        {
            driver = new FirefoxDriver();
            driver.Url = "https://www.google.com.ua/";
            driver.Close();
        }
        [Test]
        public void OpenAppChrome()
        {
            driver = new ChromeDriver();

            
            driver.Url = "https://www.google.com.ua/";

            
            driver.Close();
        }

       

        [Test]
        public void OpenAppOpera()
        {
            OperaDriverService service = OperaDriverService.CreateDefaultService("C:\\Users\\OChernovolyk\\source\\operadriver", "operadriver.exe");
            var operaOptions = new OperaOptions
            {
                BinaryLocation = "C:\\Users\\OChernovolyk\\AppData\\Local\\Programs\\Opera\\62.0.3331.72\\opera.exe",
                LeaveBrowserRunning = false
            };
            driver = new OperaDriver(service, operaOptions);


            driver.Url = "https://www.google.com.ua/";
            driver.Close();
        }

        [Test]
        public void OpenAppEgde()
        {
            EdgeDriverService service = EdgeDriverService.CreateDefaultService("C:\\Program Files (x86)\\Microsoft WebDriver", "MicrosoftWebDriver.exe");
            //EdgeOptions options = new EdgeOptions();
            //options.PageLoadStrategy =  EdgePageLoadStrategy.Eager;

            driver = new EdgeDriver(service);
            driver.Url = "https://www.google.com.ua/";
            driver.Close();
        }
        }
}

