using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace selenium_webdriver_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Инициализиране на Chrome driver
            IWebDriver driver = new ChromeDriver();

            // Навигиране до уеб страницата за тестване
            driver.Navigate().GoToUrl("https://demoqa.com/text-box");

            // Намиране на полето за име по id и попълване на стойност

            IWebElement nameInput = driver.FindElement(By.Id("userName"));
            nameInput.SendKeys("John");

            // Намиране на полето за имейл по id и попълване на стойност

            IWebElement emailInput = driver.FindElement(By.Id("userEmail"));
            emailInput.SendKeys("john@gmail.com");

            // Намиране на полето за адрес по id и попълване на стойност

            IWebElement currnetInput = driver.FindElement(By.Id("currentAddress"));
            currnetInput.SendKeys("Current");

            // Намиране на полето за адрес по id и попълване на стойност

            IWebElement permanentInput = driver.FindElement(By.Id("permanentAddress"));
            permanentInput.SendKeys("Permanent");

            // Намиране на бутона чрез css селектор

            IWebElement submitButton = driver.FindElement(By.CssSelector("#submit"));

            // Скролване надолу по страницата за да се види бутона чрез метод
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", submitButton);

            // Кликане върху бутона
            submitButton.Click();


            // Взимане на резултата от полето за име 
            IWebElement resultBox = driver.FindElement(By.CssSelector("#name"));
            string actualName = resultBox.Text;

            // Очакван резултат
            string expectedName = "Name:John";

            // Проверка дали очакваният резултат отговаря на реалният резултат
            if (actualName.Equals(expectedName))
            {
                Console.WriteLine("Name is correct: " + actualName);
            }
            else
            {
                Console.WriteLine("Name is incorrect. Expected: " + expectedName + ", Actual: " + actualName);
            }

        }
    }
}