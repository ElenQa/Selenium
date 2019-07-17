using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FirstWebProject
{
    class Open2tabs
    {
        public void OpenTwotabs( )
        {
            IWebDriver driver;

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            driver.Url = "https://www.google.com";

            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            js.ExecuteScript("window.open();");


            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.Url = "https://www.facebook.com/";

            System.Threading.Thread.Sleep(5000);
            driver.Quit();

        }
    }
}
