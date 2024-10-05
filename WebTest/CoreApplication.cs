using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Configuration;

namespace AutomatedLibrary
{
    /// <summary>
    ///
    /// </summary>
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
        public void Start()
        {
            // Obt�n la URL desde la configuraci�n
            string baseUrl = "http://www.youtube.com";
            // Navegar a YouTube
            driver.Navigate().GoToUrl(baseUrl);
            driver.Manage().Window.Maximize();
        }

        /// <summary>
        ///
        /// </summary>
        public void Operate()
        {
            // Configura un wait expl�cito
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

            // Espera hasta que el input de b�squeda est� visible
            IWebElement inputSearch = wait.Until(drv => drv.FindElement(By.CssSelector("input#search")));
            inputSearch.SendKeys("spec flow tutorial");

            // Espera hasta que el bot�n de b�squeda sea clickeable
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
            // Cierra el driver despu�s de cada prueba
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
            }
        }
    }
}