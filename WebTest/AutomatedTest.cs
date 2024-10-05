using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace AutomatedTest
{
    public class AutomatedTest
    {
        /// <summary>
        ///
        /// </summary>
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        ///
        /// </summary>
        [Test]
        public void LoginTest()
        {
            // Configura el driver
            IWebDriver driver = new FirefoxDriver();
            using (driver)
            {
                try
                {
                    driver.Navigate().GoToUrl("https://www.youtube.com");
                    driver.Manage().Window.Maximize();
                    // Configura un wait explícito
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

                    IWebElement inputSearch = driver.FindElement(By.CssSelector("input#search"));
                    inputSearch.SendKeys("petro");

                    // Espera hasta que el botón de búsqueda esté listo para ser clickeado
                    IWebElement button = driver.FindElement(By.CssSelector("button#search-icon-legacy"));
                    button.Click();

                    Thread.Sleep(5000);
                }
                catch (Exception ex)
                {
                    Assert.Fail(ex.Message);
                }
                finally
                {
                    // Cierra el driver
                    driver.Close();
                }

                Assert.Pass();
            }
        }
    }
}