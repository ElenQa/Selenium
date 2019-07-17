using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FirstWebProject
{
    class ExecuteJS
    {
        public void ExecuteJSCode()
        {
            IWebDriver driver;
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Url = "https://google.com/";

            //Execute JS on opened web page
            IJavaScriptExecutor jse = driver as IJavaScriptExecutor;
            jse.ExecuteScript("alert ('test JS')");

            System.Threading.Thread.Sleep(5000);
            driver.Close();
        }
    }
}
