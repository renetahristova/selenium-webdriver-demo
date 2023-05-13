using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace title_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Инициализиране на Chrome driver
            IWebDriver driver = new ChromeDriver();

            // Навигиране до уеб страницата за тестване
            driver.Navigate().GoToUrl("https://demoqa.com");

            string title = driver.Title;

            Console.WriteLine(title);

            driver.Quit();
        }
    }
}