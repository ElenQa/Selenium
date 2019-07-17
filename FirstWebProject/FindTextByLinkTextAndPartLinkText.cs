using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome; 

namespace FirstWebProject
{
    class FindTextByLinkTextAndPartLinkText
    {
        public void FindTextPart()
        {
            IWebDriver driver;
            IWebElement element0;
            IWebElement element1;

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            driver.Url = "https://google.com/";

            //find element by text in link and click on it
            element0 = driver.FindElement(By.LinkText("Gmail"));
            element0.Click();

            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            js.ExecuteScript("window.open();");

            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.Url = "https://google.com/";

            //find element by partial text in link and click on it
            element0 = driver.FindElement(By.PartialLinkText("браже"));
            element0.Click();


           driver.Close();
        }
                
    }
}
