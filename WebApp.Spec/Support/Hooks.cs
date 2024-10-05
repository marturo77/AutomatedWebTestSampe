using AutomatedLibrary;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace WebApp.Spec.Support
{
    [Binding]
    public class Hooks
    {
        /// <summary>
        ///
        /// </summary>
        private readonly ScenarioContext _scenarioContext;

        /// <summary>
        ///
        /// </summary>
        private CoreApplication application;

        /// <summary>
        ///
        /// </summary>
        /// <param name="scenarioContext"></param>
        public Hooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        /// <summary>
        ///
        /// </summary>
        [BeforeScenario]
        public void Inicializate()
        {
            // Inicializa CoreApplication antes de cada escenario
            IWebDriver driver = new FirefoxDriver();
            application = new CoreApplication();
            application.Inicializate(driver);

            // Almacena la instancia de CoreApplication en ScenarioContext
            _scenarioContext["Application"] = application;
        }

        /// <summary>
        ///
        /// </summary>
        [AfterScenario]
        public void CleanUp()
        {
            // Recupera la instancia de CoreApplication del contexto y la cierra
            if (_scenarioContext.TryGetValue("Application", out CoreApplication app))
            {
                app.Close();
            }
        }
    }
}