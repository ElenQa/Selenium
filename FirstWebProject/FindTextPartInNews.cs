using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using OpenQA.Selenium.Support.UI;

namespace FirstWebProject
{
    class FindTextPartInNews
    {

        public void FindText()
        {
            IWebDriver driver;

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://news.google.com/";

            File.Delete("News.txt");
            File.Delete("Result.txt");

            //find by css selector
            List<IWebElement> News = driver.FindElements(By.CssSelector(".ipQwMb a")).ToList();

            //search necessary texr parts and write results to the file 
            for (int i= 0; i < News.Count; i++)
            {
                File.AppendAllText("News.txt", $"{News[i].Text}\r\n");
                string s = News[i].Text;

                if (s.StartsWith("Trump"))
                {
                    File.AppendAllText("Result.txt", "News #"+(i+1)+"start with Trump \r\n");
                }
                if (s.EndsWith("hotel"))
                {
                    File.AppendAllText("Result.txt", "News #" + (i + 1) + "end with hotel \r\n");
                }
                if (s.Contains("US"))
                {
                    File.AppendAllText("Result.txt", "News #" + (i + 1) + "contains US \r\n");
                }
            }

            System.Threading.Thread.Sleep(5000);
            driver.Close();
        }
    }
}
