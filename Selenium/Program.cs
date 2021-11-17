using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Diagnostics;
using System.Linq;

namespace Selenium
{
    class Program
    {
        static void Main(string[] args)
        {
            //string searching = "I want to believe";
            //var driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("https://www.google.com");
            //Thread.Sleep(1000);
            //var queryDield = driver.FindElement(By.XPath("//input[@name='q']"));
            //queryDield.SendKeys(searching);
            //queryDield.SendKeys(Keys.Enter);
            //Thread.Sleep(1000);
            //var link = driver.FindElements(By.XPath("//div[@class='g']/div/div/div/div/div/a")).First();
            //Thread.Sleep(2000);
            //Console.WriteLine("///////////////////");
            //Console.WriteLine(link.Text);
            //link.Click();
            //Thread.Sleep(2000);

            //Screenshot sc = driver.GetScreenshot();

            //sc.SaveAsFile("D:/a.png", ScreenshotImageFormat.Png);
            //Thread.Sleep(1000);
            Process.Start("MSPaint.exe", "D:/a.png");
            //driver.Close();

        }
    }
}
