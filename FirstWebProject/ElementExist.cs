using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FirstWebProject
{
    class ElementExist
    {
        public void CheckIfElementExist()
        {
            IWebDriver driver;
            IWebElement SearchInput;
            IWebElement search;

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            IWebElement GetElem(By locator)
            {
  
                List<IWebElement> elements = driver.FindElements(locator).ToList();
                if (elements.Count > 0) return elements[0];
                else return null;

            }

                       
            driver.Url = "https://google.com/";

            SearchInput = GetElem(By.Name("q"));
            SearchInput.SendKeys("facebook");

            search = GetElem(By.LinkText("Увійти"));

            if (search != null)
            {
                search.Click();
                //Console.WriteLine("Element Exist");
            }

            System.Threading.Thread.Sleep(5000);
            driver.Quit();
        }
    }
}
