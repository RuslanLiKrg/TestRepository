using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyStatSelenium
{
    class Program
    {
        const string loginStr = "LiXR_fo93";
        const string passwordStr = "j0I335jh";
        static void Main(string[] args)
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://mystat.itstep.org");
            Thread.Sleep(1000);
            var login = driver.FindElement(By.XPath("//input[@id = 'username']"));
            login.SendKeys(loginStr);
            Thread.Sleep(1000);
            var password = driver.FindElement(By.XPath("//input[@id='password']"));
            password.SendKeys(passwordStr);
            Thread.Sleep(1000);
            var btn = driver.FindElement(By.XPath("//button[@class='login-action']"));
            btn.Click();
            Thread.Sleep(5000);

        }
    }
}
