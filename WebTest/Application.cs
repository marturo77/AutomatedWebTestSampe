using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace AutomatedTest
{
    /// <summary>
    ///
    /// </summary>
    public class Application
    {
        /// <summary>
        /// Driver para ejecutar la prueba
        /// </summary>
        private IWebDriver driver;

        /// <summary>
        ///
        /// </summary>
        [SetUp]
        public void Setup()
        {
            // Inicializa el driver antes de cada prueba
            driver = new FirefoxDriver();
        }

        /// <summary>
        ///
        /// </summary>
        [TearDown]
        public void Teardown()
        {
            // Cierra el driver despu�s de cada prueba
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
            }
        }

        /// <summary>
        ///
        /// </summary>
        [Test]
        public void MakeLogin()
        {
            try
            {
                // Navegar a YouTube
                driver.Navigate().GoToUrl("https://www.youtube.com");
                driver.Manage().Window.Maximize();

                // Configura un wait expl�cito
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

                // Espera hasta que el input de b�squeda est� visible
                IWebElement inputSearch = wait.Until(drv => drv.FindElement(By.CssSelector("input#search")));
                inputSearch.SendKeys("petro");

                // Espera hasta que el bot�n de b�squeda sea clickeable
                IWebElement button = wait.Until(drv => drv.FindElement(By.CssSelector("button#search-icon-legacy")));
                button.Click();

                // Espera para observar el resultado (solo como ejemplo)
                wait.Until(drv => drv.FindElement(By.CssSelector("#contents")).Displayed);
            }
            catch (Exception ex)
            {
                Assert.Fail($"La prueba fall� debido a: {ex.Message}");
            }
        }
    }
}