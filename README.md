# Leitor QRCode

Aplicativo para leitura de Qr Codes desenvolvido em .NET MAUI.

## 📋 Descrição

O Leitor QRCode é uma app mobile que faz a leitura de QR Codes e pega o conteúdo copiando para a área de transferência.

## 🛠️ Tecnologias Utilizadas

- **Linguagem:** C# 
- **Framework:** .NET
- **Interface:** MAUI (XAML + C#) — multiplataforma (Android, iOS, Windows, macOS)
- **IDE:** Visual Studio 2022

## 📁 Estrutura do Projeto

```
Leitor QrCode/
├── 📁 Platforms/
│   ├── 📁 Android               # Permissões e configurações exclusivas para Android
│   ├── 📁 MacCatalyst           # Suporte para execução no macOS via Mac Catalyst
│   ├── 📁 Tizen                 # Suporte opcional a dispositivos com sistema Tizen (ex: smartwatches Samsung)
│   ├── 📁 Windows               # Arquivos para suporte à plataforma Windows
│   └── 📁 IOS                   # Configurações específicas para dispositivos iOS
├── 📁 Properties/
│   └── launchSettings.json      # Define os perfis de execução e depuração do projeto           
├── 📁 Resources/
│   ├── 📁 AppIcon               # Ícones da aplicação para cada plataforma
│   ├── 📁 Fonts                 # Fontes personalizadas usadas na interface      
│   ├── 📁 Images                # Imagens utilizadas no app           
│   ├── 📁 Raw                   # Recursos brutos como arquivos de áudio, vídeo ou texto
│   ├── 📁 Splash                # ela de carregamento inicial (splash screen)
│   └── 📁 Styles                # Arquivos de estilo (temas, cores, etc)
├── App.xaml                     # Define estilos e recursos globais para o app
├── App.xaml.cs                  # Código de inicialização da aplicação (classe `App`)
├── AppShell.xaml                # Gerencia a estrutura de navegação da aplicação (como rotas e abas)
├── AppShell.xaml.cs             # Código relacionado à lógica de navegação definida no `AppShell.xaml`
├── Leitor QRCode.csproj         # Arquivo de configuração do projeto. Define frameworks, pacotes NuGet, recursos e diretórios incluídos
├── MainPage.xaml                # Interface da página principal
├── MainPage.xaml.cs             # Código por trás da `MainPage`, com a lógica de interface e eventos
├── MauiProgram.cs               # Ponto de entrada do aplicativo. Responsável por configurar serviços, injeção de dependência e inicialização do MAUI
├── Qrcode.xaml                  # Interface visual da página de leitura/exibição de QR Code
└── Qrcode.xaml.cs               # Lógica de funcionamento da página `Qrcode.xaml`
```

## 📦 Instalação e Uso

### Pré-requisitos
- [Visual Studio 2022/2025](https://visualstudio.microsoft.com/) com a carga de trabalho **.NET MAUI**
- .NET SDK 7.0 ou superior
- Android SDK instalado (para testes em emulador/dispositivo)
- Emulador Android configurado (opcional, mas recomendado)

### Como usar
1. Clone o repositório:
   ```bash
   git clone https://github.com/guilherme-rodrigues-de-queiroz/Leitor_QRCode.git
   ```
   ```bash
   cd leitor-qrcode
   ```
2. Abra o projeto no Visual Studio.
3. Selecione a plataforma de destino (Android, Windows, etc.).
4. Pressione F5 para compilar e executar o aplicativo.

---   

**Nota:** Para Android, é necessário conceder permissão de uso da câmera e para iOS, a execução depende de um ambiente Mac com Xcode instalado.
