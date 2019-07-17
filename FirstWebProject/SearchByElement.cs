using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FirstWebProject
{
    class SearchByElement
    {
         public void FindElement()
        {
            IWebDriver driver;
            IWebElement element0;
            IWebElement element1;
            IWebElement SearchInput;

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://google.com/";

            //find by name and write text to search window
            SearchInput = driver.FindElement(By.Name("q"));
            SearchInput.SendKeys("facebook" + Keys.Enter);

            //find element by id and click on it
            element0 = driver.FindElement(By.Id("gb_70"));
            element0.Click();

            //find element by id and write text to email window
            element1 = driver.FindElement(By.Id("identifierId"));
            element1.SendKeys("123@gmail.com");


            System.Threading.Thread.Sleep(5000);
            driver.Close();
        }
    }
}
