using AutomatedLibrary;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace WebApp.Spec.Support
{
    /// <summary>
    ///
    /// </summary>
    public class CoreContext
    {
        /// <summary>
        ///
        /// </summary>
        public CoreApplication Application { get; }

        /// <summary>
        ///
        /// </summary>
        internal CoreContext()
        {
            // Inicializa el navegador antes de cada escenario
            Application = new CoreApplication();
            IWebDriver driver = new FirefoxDriver();
            Application.Inicializate(driver);
        }
    }
}