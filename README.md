# Leitor QRCode

[English](#en) | [Português](#pt-BR)

---

<a name="pt-BR"></a>
## 🇧🇷 Português

## 📋 Descrição

O **Leitor QRCode** é um aplicativo mobile desenvolvido em **.NET MAUI** para leitura de QR Codes.

Após a leitura, o conteúdo do QR Code é automaticamente copiado para a área de transferência do dispositivo, permitindo seu uso imediato em outros aplicativos.

## 🛠️ Tecnologias Utilizadas

* **Linguagem:** C#
* **Framework:** .NET
* **Interface:** .NET MAUI (XAML + C#)
* **Plataformas:** Android, iOS, Windows e macOS
* **IDE:** Visual Studio 2022

---

## 📁 Estrutura do Projeto

```text
LeitorQRCode/
├── 📁 Platforms/
│   ├── Android
│   ├── iOS
│   ├── MacCatalyst
│   ├── Tizen
│   └── Windows
├── 📁 Properties/
│   └── launchSettings.json
├── 📁 Resources/
│   ├── AppIcon
│   ├── Fonts
│   ├── Images
│   ├── Raw
│   ├── Splash
│   └── Styles
├── App.xaml
├── App.xaml.cs
├── AppShell.xaml
├── AppShell.xaml.cs
├── LeitorQRCode.csproj
├── MainPage.xaml
├── MainPage.xaml.cs
├── MauiProgram.cs
├── Qrcode.xaml
└── Qrcode.xaml.cs
```

---

## 📦 Instalação

### Pré-requisitos

* Visual Studio 2022 ou superior
* Carga de trabalho **.NET MAUI**
* .NET SDK 7.0 ou superior
* Android SDK (para testes Android)
* Emulador Android (opcional)

### Como utilizar

1. Clone o repositório:

```bash
git clone https://github.com/guilherme-rodrigues-de-queiroz/Leitor_QRCode.git
```

2. Entre na pasta do projeto:

```bash
cd Leitor_QRCode
```

3. Abra a solução no Visual Studio.

4. Escolha a plataforma desejada (Android, Windows, iOS ou macOS).

5. Pressione **F5** para compilar e executar o aplicativo.

---

## ✨ Funcionalidades

* Leitura de QR Codes utilizando a câmera.
* Cópia automática do conteúdo para a área de transferência.
* Interface simples e intuitiva.
* Aplicação multiplataforma com .NET MAUI.

---

## 📝 Observações

* No Android é necessário conceder permissão para uso da câmera.
* Para executar no iOS é necessário um ambiente macOS com Xcode instalado.

---

## 🏢 Sobre

Este projeto foi desenvolvido como uma aplicação simples e multiplataforma para demonstrar a leitura de QR Codes utilizando **.NET MAUI**, oferecendo uma forma rápida de capturar e copiar informações presentes em códigos QR.

---

<a name="en"></a>
## 🇺🇸 English

## 📋 Description

**Leitor QRCode** is a mobile application built with **.NET MAUI** for scanning QR Codes.

Once a QR Code is scanned, its content is automatically copied to the device's clipboard, making it easy to paste into other applications.

## 🛠️ Technologies

* **Language:** C#
* **Framework:** .NET
* **UI:** .NET MAUI (XAML + C#)
* **Platforms:** Android, iOS, Windows, and macOS
* **IDE:** Visual Studio 2022

---

## 📁 Project Structure

```text
LeitorQRCode/
├── 📁 Platforms/
│   ├── Android
│   ├── iOS
│   ├── MacCatalyst
│   ├── Tizen
│   └── Windows
├── 📁 Properties/
│   └── launchSettings.json
├── 📁 Resources/
│   ├── AppIcon
│   ├── Fonts
│   ├── Images
│   ├── Raw
│   ├── Splash
│   └── Styles
├── App.xaml
├── App.xaml.cs
├── AppShell.xaml
├── AppShell.xaml.cs
├── LeitorQRCode.csproj
├── MainPage.xaml
├── MainPage.xaml.cs
├── MauiProgram.cs
├── Qrcode.xaml
└── Qrcode.xaml.cs
```

---

## 📦 Installation

### Requirements

* Visual Studio 2022 or later
* .NET MAUI workload installed
* .NET SDK 7.0 or later
* Android SDK (for Android testing)
* Android Emulator (optional)

### Getting Started

1. Clone the repository:

```bash
git clone https://github.com/guilherme-rodrigues-de-queiroz/Leitor_QRCode.git
```

2. Open the project folder:

```bash
cd Leitor_QRCode
```

3. Open the solution in Visual Studio.

4. Select the target platform (Android, Windows, iOS, or macOS).

5. Press **F5** to build and run the application.

---

## ✨ Features

* Scan QR Codes using the device camera.
* Automatically copy scanned content to the clipboard.
* Simple and intuitive user interface.
* Cross-platform application built with .NET MAUI.

---

## 📝 Notes

* Camera permission is required on Android devices.
* Running the application on iOS requires macOS with Xcode installed.

---

## 🏢 About

This project was developed as a lightweight cross-platform application demonstrating QR Code scanning with **.NET MAUI**. Its goal is to provide a fast and convenient way to capture QR Code content and automatically copy it to the clipboard.
