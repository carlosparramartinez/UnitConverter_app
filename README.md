# Conversor de Unidades en ASP.NET Core MVC

Este proyecto es una aplicación web desarrollada en **ASP.NET Core MVC** que permite realizar conversiones entre distintas unidades de **longitud**, **peso** y **temperatura**.
https://roadmap.sh/projects/unit-converter
##  Funcionalidades
    - Conversión entre unidades de **longitud**: milímetros, centímetros, metros, kilómetros, pulgadas, pies, yardas, millas.
    - Conversión entre unidades de **peso**: miligramos, gramos, kilogramos, libras, onzas, toneladas.
    - Conversión entre unidades de **temperatura**: Celsius, Fahrenheit, Kelvin.
    - Interfaz limpia y sencilla.
    - Arquitectura basada en MVC (Modelo-Vista-Controlador).

##  Estructura del Proyecto
    UnitConverterApp/
    ├── Controllers/
    │ └── ConverterController.cs
    ├── Models/
    │ ├── ConversionModel.cs
    │ ├── WeightModel.cs
    │ └── TemperatureModel.cs
    ├── Views/
    │ └── Converter/
    │ ├── Length.cshtml
    │ ├── Weight.cshtml
    │ └── Temperature.cshtml
    ├── wwwroot/
    │ ├── css/
    │ └── js/
    ├── Program.cs
    ├── Startup.cs (si existe)
    └── UnitConverterApp.csproj

##  Ejecución del Proyecto
    1. Clona el repositorio o descarga el código fuente.
    2. Abre el proyecto con Visual Studio o VS Code.
    3. Restaura los paquetes con:
    ```bash
    dotnet restore
##  Ejecuta el proyecto
    dotnet run
    Abre tu navegador en https://localhost:5001 o http://localhost:5120
    (al ejecutar donetrun te dara el link del enlace local donde se vera el proyecto
    puede variar el puerto)