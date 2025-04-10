# 🏆 Portafolio QA - Héctor Sandoval

Bienvenido a mi portafolio de pruebas automatizadas. Este repositorio contiene varios proyectos desarrollados para demostrar mi experiencia con diferentes herramientas de testing a lo largo de los años.

## 📚 Contenido
- 🎯 Objetivo del Proyecto
- 📥 Clonación del Repositorio
- 🚀 Proyectos y Pruebas Realizadas
- 🛠️ Tecnologías Utilizadas
- 📂 Estructura del Proyecto
- ▶️ Cómo Ejecutar las Pruebas
- 📸 Capturas de Pantalla / Videos
- 📊 Resumen de Resultados
- 🏆 Contribuciones y Contacto

## 🎯 Objetivo del Proyecto
El objetivo de este repositorio es mostrar mi experiencia y habilidades en pruebas automatizadas utilizando diversas herramientas como SpecFlow con Selenium y SpecFlow con Playwright. Este proyecto forma parte de mi portafolio como QA Automation Tester.

## 📥 Clonación del Repositorio
Para obtener una copia local del proyecto, ejecuta el siguiente comando en tu terminal:

```bash
git clone https://github.com/tu-usuario/tu-repositorio.git
```

## 🚀 Proyectos y Pruebas Realizadas
### SpecFlow con Selenium
- **LoginTests.cs** - Prueba de login exitoso y redirección al home si las credenciales son correctas.
- **PurchaseTests.cs** - Simula el proceso completo de compra de productos, desde la selección hasta la confirmación.

### SpecFlow con Playwright
- **LoginTests.cs** - Prueba de login exitoso y redirección al home si las credenciales son correctas.
- **PurchaseTests.cs** - Simula el proceso completo de compra de productos, desde la selección hasta la confirmación.

## 🛠️ Tecnologías Utilizadas
- 🏗️ SpecFlow (para las pruebas automatizadas)
- 💻 Selenium y Playwright (herramientas de automatización)
- 🌐 C# (lenguaje principal para los tests)
- 🔗 Git y GitHub (control de versiones y repositorio remoto)

## 📂 Estructura del Proyecto
```plaintext
├── SpecFlowSelenium/
│   ├── Dependencias/
│   ├── Drivers/
│   ├── Features/
│   ├── PageObjects/
│   ├── StepDefinitions/
│   ├── Support/
│   ├── AssemblyInfo.cs
│   ├── ImplicitUsings.cs
│   └── NuGet.Config
├── SpecFlowPlaywright/
│   ├── Dependencias/
│   ├── Drivers/
│   ├── Features/
│   ├── PageObjects/
│   ├── StepDefinitions/
│   ├── Support/
│   ├── AssemblyInfo.cs
│   ├── ImplicitUsings.cs
└── README.md
```

### Buenas Prácticas
- **Modularización**: Organiza tu código en módulos y clases para facilitar el mantenimiento y la escalabilidad.
- **Uso de Page Objects**: Implementa el patrón Page Object para separar la lógica de la interfaz de usuario de las pruebas.
- **Sincronización**: Utiliza métodos de espera adecuados para manejar la sincronización entre la aplicación y las pruebas.
- **Reutilización de Código**: Reutiliza métodos y clases comunes para evitar la duplicación de código.
- **Documentación**: Mantén una buena documentación de tu código y pruebas para facilitar la comprensión y colaboración.

## ▶️ Cómo Ejecutar las Pruebas
### Requisitos Previos
Antes de ejecutar las pruebas, asegúrate de tener instalado:
- Node.js
- SpecFlow y Selenium/Playwright instalados en el proyecto
- Git y un entorno configurado

### Ejecutar las pruebas
Para correr las pruebas en modo interactivo (GUI):

```bash
npx cypress open
```

Luego, en la interfaz de Cypress, selecciona el navegador y el test a ejecutar.

Para ejecutar todas las pruebas en modo headless (sin interfaz gráfica):

```bash
npx cypress run
```

## 📸 Capturas de Pantalla / Videos
Cypress genera automáticamente videos al ejecutar las pruebas en modo headless. En este repositorio se incluyen grabaciones representativas de cada prueba realizada:

- 🔹 Login
  🎥 Ver video de prueba de login

- 🔹 Purchase
  🎥 Ver video de flujo de compra de productos

Los videos se encuentran en la carpeta `/cypress/media` ya que Cypress guarda los originales en `/cypress/videos/`, carpeta excluida por el archivo `.gitignore`.

## 📊 Resumen de Resultados
A continuación se presenta el resumen generado automáticamente por Cypress al ejecutar las pruebas en modo headless (`npx cypress run`):

```plaintext
 (Run Finished)
      Spec                                              Tests  Passing  Failing  Pending  Skipped  
 ┌────────────────────────────────────────────────────────────────────────────────────────────────┐
 │ ✔  login.cy.js                              00:05        1        1        -        -        - │
 ├────────────────────────────────────────────────────────────────────────────────────────────────┤
 │ ✔  purchase.cy.js                           00:04        1        1        -        -        - │
 └────────────────────────────────────────────────────────────────────────────────────────────────┘
   ✔  All specs passed!                        00:09        2        2        -        -        -  
   Todas las pruebas fueron exitosas ✅
```

## 🏆 Contribuciones y Contacto
Si tienes alguna sugerencia o quieres contribuir, ¡siéntete libre de hacer un fork y enviar un pull request!

📧 Contacto: hector.sandoval@example.com 🔗 LinkedIn: Héctor Sandoval

¡Gracias por visitar mi repositorio! 🚀
