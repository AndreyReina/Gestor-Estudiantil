# 📘 GestorEstudiantes

## 📌 Descripción

**GestorEstudiantes** es una aplicación de escritorio desarrollada en **C# (.NET Windows Forms)** como proyecto académico integrador.
Permite registrar, visualizar y gestionar estudiantes, sus calificaciones y enviar reportes académicos por correo electrónico.

---

## 🚀 Funcionalidades

* **Registro de estudiantes** con datos:

  * Nombre
  * Edad
  * Género
  * Intereses (Deportes, Música, Arte)
  * Notas (Nota1, Nota2, Nota3)

* **Gestión de información:**

  * Guardar y cargar datos en formato **CSV** mediante una librería propia (`LibreriaSerializadores`).
  * Cálculo automático del **promedio** y el **estado académico** (Aprobado/Reprobado).
  * Visualización en un **DataGridView** y un **ListBox**.

* **Búsqueda y Resultados:**

  * Buscar estudiantes por nombre.
  * Mostrar detalles en un formulario de resultados (`FrmResultado`).

* **Envío de correos electrónicos:**

  * Formulario de envío de correo (`FrmCorreos`).
  * Posibilidad de notificar a los estudiantes su promedio y estado académico.

---

## 🏗️ Estructura del Proyecto

```
GestorEstudiantes.sln
│
├── GestorEstudiantes/              # Proyecto principal (Windows Forms)
│   ├── FrmPrincipal.cs              # Formulario principal
│   ├── FrmResultado.cs              # Formulario de resultados
│   ├── FrmCorreos.cs                # Formulario de envío de correos
│   ├── Estudiante.cs                # Clase que representa un estudiante
│   ├── Program.cs                   # Punto de entrada de la aplicación
│   └── Properties/                  # Configuración del proyecto
│
├── LibreriaSerializadores/          # Biblioteca de clases (Class Library)
│   ├── SerializadorCsv.cs           # Métodos para guardar/cargar CSV
│   └── Properties/AssemblyInfo.cs   # Información del ensamblado
│
└── estudiantes.csv                  # Archivo de datos (ejemplo)
```

---

## 📂 Ejemplo de CSV

El sistema utiliza archivos **CSV** para almacenar los datos de los estudiantes.
Formato esperado:

```csv
Nombre,Edad,Genero,Deportes,Musica,Arte,Nota1,Nota2,Nota3
Juan Pérez,20,Masculino,true,false,false,3.5,4.0,2.8
María López,22,Femenino,false,true,true,4.5,3.8,4.2
Carlos Ruiz,19,Masculino,true,true,false,2.5,2.8,3.0
Ana Torres,21,Femenino,false,false,true,5.0,4.8,4.9
```

---

## ⚙️ Requisitos

* **Visual Studio 2022** o superior
* **.NET 8.0 Windows Desktop Runtime**
* Librería `System.Net.Mail` para el envío de correos
* Acceso a un **servidor SMTP** válido (ej: Gmail con contraseña de aplicación, Outlook/Office365, servidor institucional)

---

## 📧 Configuración del correo

En el formulario `FrmCorreos`, debes configurar el servidor SMTP:

* **Para Gmail:**

  * Servidor: `smtp.gmail.com`
  * Puerto: `587`
  * SSL: `true`
  * Usuario: tu correo Gmail
  * Contraseña: contraseña de aplicación

* **Para Office365/Outlook:**

  * Servidor: `smtp.office365.com`
  * Puerto: `587`
  * SSL: `true`
  * Usuario: tu correo institucional
  * Contraseña: tu contraseña institucional (si SMTP Auth está habilitado)

---

## 👨‍💻 Autores

* **Andrey Alexander Reina Carrillo**
  Estudiante de Ingeniería de Sistemas – CUN

---

## 📷 Capturas

<img width="792" height="544" alt="image" src="https://github.com/user-attachments/assets/5f8a7401-4dec-423a-b609-fff5b86c8101" />
<img width="788" height="539" alt="image" src="https://github.com/user-attachments/assets/6b013423-a4ad-4006-8c60-6c35183ed178" />
<img width="788" height="541" alt="image" src="https://github.com/user-attachments/assets/4b42d0ad-4b46-4f2b-970d-0e3330ea29b2" />
<img width="407" height="296" alt="image" src="https://github.com/user-attachments/assets/2d191e02-395b-4030-bc3b-e5d8ea3bba1d" />
<img width="789" height="541" alt="image" src="https://github.com/user-attachments/assets/1ffe195b-5599-4d7c-a5e1-7c9c1e4d4daf" />
<img width="790" height="538" alt="image" src="https://github.com/user-attachments/assets/32774e15-c2df-44c2-b68e-eb64a211d469" />
<img width="446" height="378" alt="image" src="https://github.com/user-attachments/assets/92c74944-86b7-49b7-a6d4-fa9c92376846" />
<img width="450" height="375" alt="image" src="https://github.com/user-attachments/assets/2aebdada-6a34-4514-bea5-dfa5ef2693a8" />

