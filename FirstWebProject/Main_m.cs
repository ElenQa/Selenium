using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;


namespace FirstWebProject
{
    class Main_m
    {
        static void Main(string[] args)
        {
            
            //open  2 different tabs of browser
            Open2tabs o = new Open2tabs();
            o.OpenTwotabs();

            //opens GoogleNews and search if news contains text fragment. Write result in file
            FindTextPartInNews f = new FindTextPartInNews();
            f.FindText();

            //search elements on the site and send keys. 
            SearchByElement s = new SearchByElement();
            s.FindElement();

            //search elemenets by link or partial link text
            FindTextByLinkTextAndPartLinkText f1 = new FindTextByLinkTextAndPartLinkText();
            f1.FindTextPart();

            //execute JS code
            ExecuteJS e = new ExecuteJS();
            e.ExecuteJSCode();

            //chech if element exist and click on it if exist
            ElementExist e1 = new ElementExist();
            e1.CheckIfElementExist();





            //open with user existing GChrome profile
            //ChromeOptions CO = new ChromeOptions();
            //CO.AddArgument("--user-data-dir=C:/Users/OChernovolyk/AppData/Local/Google/Chrome/User Data/Profile 1");
            //CO.AddArgument("--disable-extensions");
            //driver = new ChromeDriver(CO);
            //driver.Url = "https://google.com/";


            //TimeOuts variants
               //WebDriverWait w = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
               //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);




        }
    }
}