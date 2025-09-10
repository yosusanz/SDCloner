<h1>SDCloner</h1>

<p>
  <img src="https://img.shields.io/badge/C%23-239120?style=flat&logo=dotnet&logoColor=white" alt="C# .NET" />
  <img src="https://img.shields.io/badge/WinForms-0078D7?style=flat&logo=windows&logoColor=white" alt="WinForms" />
  <img src="https://img.shields.io/badge/licencia-Apache%202.0-green?style=flat-square" alt="Licencia: Apache 2.0">
</p> 

<section>
  <p align="center">
    <img src="https://github.com/yosusanz/yosusanz/blob/main/images/sdcloner/intro.gif?raw=true" alt="SDCloner Intro" width="480"/>
  </p>
  
  
  <p align="center">C# | .NET8 | WinForms | PowerShell</p>
  <br>
  <p><strong>SDCloner</strong> es una aplicación de escritorio diseñada para <strong>grabar imágenes en unidades extraíbles</strong> de forma paralela, eficiente y controlada, ofreciendo una <strong>interfaz visual clara</strong> y funcionalidades de seguimiento del progreso y tiempo restante estimado.</p>
  <img src="https://github.com/yosusanz/yosusanz/blob/main/images/sdcloner/screenshots.png?raw=true" alt="SDCloner - pantallas splashscreen de la aplicación" width="846"/>
  <p>El proyecto combina la potencia de <strong>C# y WinForms</strong> con scripts de <strong>PowerShell</strong> para la manipulación directa de discos, garantizando que la unidad quede preparada correctamente antes de grabar la imagen.</p>
  <br>
  
  
  <br>
  <h2>🛠️ Casos de uso</h2>
  <ul>
    <li><strong>Producción industrial</strong>: Preparación en paralelo de decenas de microSDs para sistemas embebidos o dispositivos IoT, manteniendo el mismo tiempo de grabación que una única tarjeta.</li>
    <li><strong>Laboratorios y pruebas</strong>: Creación rápida de entornos de test idénticos en múltiples dispositivos, facilitando la validación y reducción de errores humanos.</li>
    <li><strong>Formación y educación</strong>: Distribución ágil de imágenes preconfiguradas a estudiantes o equipos de trabajo, asegurando uniformidad en todos los dispositivos.</li>
    <li><strong>Prototipado y desarrollo</strong>: Iteración más rápida en proyectos de hardware y software al poder generar varias copias de prueba en paralelo.</li>
  </ul>
  
  <br>
  <h2>🧠 Funcionalidad</h2>
  <ul>
    <li>Detección automática de unidades extraíbles conectadas.</li>
    <li>Visualización del nombre de la unidad, volumen y estado de la tarjeta/USB.</li>
    <li>Proceso de grabación controlado con visualización de porcentaje y tiempo restante estimado.</li>
    <li>Eliminación segura de particiones existentes antes de grabar la imagen.</li>
    <li>Soporte para múltiples unidades seleccionadas simultáneamente.</li>
    <li>Paneles de estado visuales: Selección, Grabando, Finalizado y Error.</li>
    <li>Integración con PowerShell para operaciones de disco críticas (lectura/escritura raw).</li>
    <li>Validación de que la imagen cabe en la unidad antes de iniciar el proceso.</li>
    <li>Actualización dinámica de la barra de progreso y tiempo restante en pantalla.</li>
  </ul>
  
  <br> 
  <h2>⚙️ Arquitectura</h2>
  <ul>
    <li><strong>C# .NET 8</strong> con WinForms para la interfaz gráfica.</li>
    <li>Uso de <strong>PowerShell integrado</strong> para gestión de discos y grabación raw.</li>
    <li>Diseño modular.</li>
    <li>Tareas asíncronas y sin bloqueo de la UI.</li>
    <li>Control total de flujo, estado, y reporting de resultados.</li>
  </ul>

  <br>
  <h2>Estructura de carpetas</h2>
  <pre><code>
    📁 AppCore/                   # Núcleo de la aplicación
      📁 Forms/                   # Interfaz gráfica (pantallas y formularios)
        📁 Controls/              # Controles reutilizables de la UI
          📄 DriveControl.cs      # Control principal para unidades
        📄 BurningScreen.cs       # Pantalla de grabación de la SD
        📄 LoadImageFileScreen.cs # Pantalla de selección de archivo IMG
      📁 Helpers/                 # Funciones auxiliares
        📄 SecurityHelper.cs      # Métodos de seguridad y validaciones
      📁 Models/                  # Modelos de dominio
        📄 BurnProgress.cs        # Estado y progreso de la grabación
        📄 ImageFile.cs           # Representación del archivo IMG
        📄 RemovableDrive.cs      # Información de la unidad extraíble
      📁 Services/                # Servicios principales de la lógica
        📄 BurnService.cs         # Lógica de grabación de imágenes
        📄 DriveService.cs        # Gestión de discos y unidades
    📁 Properties/                # Configuración y recursos de WinForms
    📁 Resources/                 # Recursos embebidos (iconos, imágenes)
    📄 App.cs                     # Clase principal de la aplicación
    📄 GlobalVars.cs              # Variables y configuración global
    📄 Program.cs                 # Punto de entrada de la aplicación
    📄 app.manifest               # Configuración de ejecución
  </code></pre>
  
  <br>
  <h2>🚀 Instalación y uso</h2>
  <p>Clona el repositorio y compila desde Visual Studio:</p>
  <ol>
    <li>Ejecuta el proyecto SDCloner.exe.</li>
    <li>Selecciona la imagen que quieres grabar.</li>
    <li>Selecciona una o varias unidades de destino.</li>
    <li>Pulsa <strong>"Grabar"</strong> para iniciar el proceso de grabación.</li>
    <li>Observa el progreso, porcentaje completado y tiempo estimado restante.</li>
    <li>Al finalizar, el sistema muestra un panel de éxito o error según corresponda a cada unidad.</li>
  </ol>

  <br>
  <h2>📄 Licencia</h2>
  <p>
    <strong>Apache License 2.0</strong> – puedes usar esta plantilla libremente en proyectos personales o comerciales.<br>
    Es <strong>obligatorio</strong> mantener el aviso de copyright, la licencia y cualquier nota de atribución.<br>
    Las modificaciones también deben incluir una <strong>nota explicando los cambios</strong> realizados.
  </p>

  <br>
  <p align="center"><i>Desarrollado por <a href="https://www.linkedin.com/in/yosusanz" target="_blank">@yosusanz</a> – más proyectos en mi perfil de <a href="https://github.com/yosusanz" target="_blank">GitHub</a></i></p>
</section>
