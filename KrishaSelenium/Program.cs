using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Diagnostics;
using System.Linq;

namespace KrishaSelenium
{
    class Program
    {
        static void Main(string[] args)
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://krisha.kz");
            Thread.Sleep(1000);
            var btn = driver.FindElement(By.XPath("//button[@class = 'search-btn-main']"));
            btn.Click();
            Thread.Sleep(1000);
            var linkRich = driver.FindElements(By.XPath("//div[@class = 'sort-option-selector']/a[@class = 'link se-link sort-option-link']"));
            linkRich[1].Click();
            var MostRichAppart = driver.FindElement(By.XPath("//section[@class = 'a-list a-search-list a-list-with-favs']/div[@class = 'a-card a-storage-live ddl_product ddl_product_link not-colored is-visible']"));
            MostRichAppart.Click();
            driver.Close();
        }
    }
}
