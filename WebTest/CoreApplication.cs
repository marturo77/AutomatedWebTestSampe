using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomatedLibrary
{
    /// <summary>
    ///
    /// </summary>
    [TestFixture, Timeout(15000)]
    public class CoreApplication
    {
        /// <summary>
        ///
        /// </summary>
        public void Inicializate(IWebDriver d)
        {
            driver = d;
        }

        /// <summary>
        /// Driver para ejecutar la prueba
        /// </summary>
        private IWebDriver driver;

        /// <summary>
        ///
        /// </summary>
        public void StartApplication()
        {
            // Navegar a YouTube
            driver.Navigate().GoToUrl("https://www.youtube.com");
            driver.Manage().Window.Maximize();

            // Configura un wait explícito
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

            // Espera hasta que el input de búsqueda esté visible
            IWebElement inputSearch = wait.Until(drv => drv.FindElement(By.CssSelector("input#search")));
            inputSearch.SendKeys("petro");

            // Espera hasta que el botón de búsqueda sea clickeable
            IWebElement button = wait.Until(drv => drv.FindElement(By.CssSelector("button#search-icon-legacy")));
            button.Click();

            // Espera para observar el resultado (solo como ejemplo)
            wait.Until(drv => drv.FindElement(By.CssSelector("#contents")).Displayed);
        }

        /// <summary>
        ///
        /// </summary>
        public void Close()
        {
            // Cierra el driver después de cada prueba
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
            }
        }
    }
}