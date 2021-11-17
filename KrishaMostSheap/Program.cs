using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace KrishaMostSheap
{
    class Program
    {
        static void Main(string[] args)
        { 
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://krisha.kz/prodazha/kvartiry/karaganda/");
            Thread.Sleep(1000);
            var btn = driver.FindElement(By.XPath("//button[@class = 'btn-submit search-btn-main']"));
            btn.Click();
            Thread.Sleep(3000);
            var linkSheap = driver.FindElements(By.XPath("//div[@class = 'sort-option-selector']/a[@class = 'link se-link sort-option-link']"));
            linkSheap[0].Click();
            Thread.Sleep(5000);
            var price = driver.FindElement(By.XPath("//section[@class='a-list a-search-list a-list-with-favs']/div[@class='a-card a-storage-live ddl_product ddl_product_link not-colored is-visible']/div[@class='a-card__inc']//div[@class='a-card__price']"));
            string s = string.Empty;
            for (int i = 0; i < price.Text.Length; i++)
            {
                if (char.IsDigit(price.Text[i]))
                {
                    s += price.Text[i];
                }
            }

            int dig = int.Parse(s);
            System.Console.WriteLine($"Цена самой дешевой квартиры: {dig} тг");
            var refToAppartment = driver.FindElement(By.XPath("//section[@class = 'a-list a-search-list a-list-with-favs']/div[@class = 'a-card a-storage-live ddl_product ddl_product_link not-colored is-visible']"));
            Thread.Sleep(5000);
            refToAppartment.Click();
            driver.Close();
        }
    }
}
