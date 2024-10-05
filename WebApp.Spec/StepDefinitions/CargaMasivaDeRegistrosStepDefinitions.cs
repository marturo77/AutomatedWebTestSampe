using System;
using TechTalk.SpecFlow;

namespace WebApp.Spec.StepDefinitions
{
    [Binding]
    public class CargaMasivaDeRegistrosStepDefinitions
    {
        [Given(@"que existe un archivo CSV con el listado de pólizas con todos los campos requeridos")]
        public void GivenQueExisteUnArchivoCSVConElListadoDePolizasConTodosLosCamposRequeridos()
        {
            throw new PendingStepException();
        }

        [Given(@"que el usuario está en la página de carga masiva de pólizas")]
        public void GivenQueElUsuarioEstaEnLaPaginaDeCargaMasivaDePolizas()
        {
            throw new PendingStepException();
        }

        [When(@"el usuario selecciona el archivo ""([^""]*)""")]
        public void WhenElUsuarioSeleccionaElArchivo(string p0)
        {
            throw new PendingStepException();
        }

        [When(@"el usuario hace clic en el botón de ""([^""]*)""")]
        public void WhenElUsuarioHaceClicEnElBotonDe(string cargar)
        {
            throw new PendingStepException();
        }

        [Then(@"el sistema debería procesar el archivo y poblar la base de datos de pólizas")]
        public void ThenElSistemaDeberiaProcesarElArchivoYPoblarLaBaseDeDatosDePolizas()
        {
            throw new PendingStepException();
        }

        [Then(@"se muestra un mensaje ""([^""]*)""")]
        public void ThenSeMuestraUnMensaje(string p0)
        {
            throw new PendingStepException();
        }

        [Given(@"que existe un archivo CSV con el listado de pólizas con campos faltantes")]
        public void GivenQueExisteUnArchivoCSVConElListadoDePolizasConCamposFaltantes()
        {
            throw new PendingStepException();
        }

        [Then(@"el sistema debería mostrar un mensaje de error ""([^""]*)""")]
        public void ThenElSistemaDeberiaMostrarUnMensajeDeError(string p0)
        {
            throw new PendingStepException();
        }

        [When(@"el usuario selecciona un archivo con formato diferente a CSV")]
        public void WhenElUsuarioSeleccionaUnArchivoConFormatoDiferenteACSV()
        {
            throw new PendingStepException();
        }
    }
}
