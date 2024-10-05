using AutomatedLibrary;

namespace WebApp.Spec.StepDefinitions
{
    /// <summary>
    ///
    /// </summary>
    [Binding]
    public class CargaMasivaDeRegistrosStepDefinitions
    {
        /// <summary>
        ///
        /// </summary>
        private CoreApplication app;

        /// <summary>
        ///
        /// </summary>
        /// <param name="context"></param>
        public CargaMasivaDeRegistrosStepDefinitions(ScenarioContext scenarioContext)
        {
            // Recupera la instancia de CoreApplication del contexto del escenario
            app = scenarioContext["Application"] as CoreApplication;
        }

        [Given(@"Logueado en el sistema")]
        public void GivenLogueadoEnElSistema()
        {
            app.Start();
        }

        [Given(@"que existe un archivo CSV con el listado de pólizas con todos los campos requeridos")]
        public void GivenQueExisteUnArchivoCSVConElListadoDePolizasConTodosLosCamposRequeridos()
        {
            app.Operate();
        }

        [Given(@"que el usuario está en la página de carga masiva de pólizas")]
        public void GivenQueElUsuarioEstaEnLaPaginaDeCargaMasivaDePolizas()
        {
        }

        [When(@"el usuario selecciona el archivo ""([^""]*)""")]
        public void WhenElUsuarioSeleccionaElArchivo(string p0)
        {
        }

        [When(@"el usuario hace clic en el botón de ""([^""]*)""")]
        public void WhenElUsuarioHaceClicEnElBotonDe(string cargar)
        {
        }

        [Then(@"el sistema debería procesar el archivo y poblar la base de datos de pólizas")]
        public void ThenElSistemaDeberiaProcesarElArchivoYPoblarLaBaseDeDatosDePolizas()
        {
        }

        [Then(@"se muestra un mensaje ""([^""]*)""")]
        public void ThenSeMuestraUnMensaje(string p0)
        {
        }

        [Given(@"que existe un archivo CSV con el listado de pólizas con campos faltantes")]
        public void GivenQueExisteUnArchivoCSVConElListadoDePolizasConCamposFaltantes()
        {
        }

        [Then(@"el sistema debería mostrar un mensaje de error ""([^""]*)""")]
        public void ThenElSistemaDeberiaMostrarUnMensajeDeError(string p0)
        {
        }

        [When(@"el usuario selecciona un archivo con formato diferente a CSV")]
        public void WhenElUsuarioSeleccionaUnArchivoConFormatoDiferenteACSV()
        {
        }
    }
}