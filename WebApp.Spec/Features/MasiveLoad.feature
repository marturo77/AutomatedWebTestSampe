Feature: Carga Masiva de Registros

Quiero cargar un archivo csv para poblar una tabla con la informacion de polizas

@CargaMasiva
Scenario: Carga masiva de archivo CSV con éxito
	Given que existe un archivo CSV con el listado de pólizas con todos los campos requeridos
	And que el usuario está en la página de carga masiva de pólizas
	When el usuario selecciona el archivo "polizas.csv"
	And el usuario hace clic en el botón de "Cargar"
	Then el sistema debería procesar el archivo y poblar la base de datos de pólizas
	And se muestra un mensaje "Archivo cargado exitosamente con X pólizas procesadas"
	 

Scenario: Carga de archivo CSV con campos faltantes
	Given que existe un archivo CSV con el listado de pólizas con campos faltantes
	And que el usuario está en la página de carga masiva de pólizas
	When el usuario selecciona el archivo "polizas_incompleto.csv"
	And el usuario hace clic en el botón de "Cargar"
	Then el sistema debería mostrar un mensaje de error "El archivo contiene campos faltantes y no puede ser procesado"

Scenario: Carga de archivo en formato incorrecto
	Given que el usuario está en la página de carga masiva de pólizas
	When el usuario selecciona un archivo con formato diferente a CSV
	And el usuario hace clic en el botón de "Cargar"
	Then el sistema debería mostrar un mensaje de error "Formato de archivo no soportado. Solo se permiten archivos CSV"
