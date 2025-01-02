[![GitHub license](https://img.shields.io/github/license/RaptureProject/Client?style=for-the-badge&color=00bb00)](https://github.com/RaptureProject/Client/blob/main/LICENSE.txt)
[![Contributor Covenant](https://img.shields.io/badge/Contributor%20Covenant-2.0-4baaaa?style=for-the-badge)](CODE_OF_CONDUCT.md)
[![GitHub issues](https://img.shields.io/github/issues/RaptureProject/Client?style=for-the-badge)](https://github.com/RaptureProject/Client/issues)

# Rapture Client
This repository contains the Rapture client source code.

# Getting Started
In order to contribute to the client you will need to install a few dependencies, the steps outlined below should get you up and running with a basic development environment.

## Dependencies
Dependencies recommended are as follows:

- [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/), [Visual Studio Code](https://code.visualstudio.com/download), or [JetBrains Rider](https://www.jetbrains.com/rider/)
- [Inno Setup](https://jrsoftware.org/isdl.php)

The code editor you use is really up to you in terms of what you prefer, just keep in mind that Visual Studio 2022 and JetBrains Rider will giive you the best development experience.
You can also choose to use any other code editor if you really want thats not in the list so long as you are willing to go through the extra configuration needed to do so (ex. Vim, NeoVim, Emacs, etc.).

## Run Rapture Client
Once you have all the dependencies listed above you can:

- Run `dotnet publish -c Release` from the `src/Installer` directory.
- Open the `Rapture.Client.sln` file in either Visual Studio 2022, Visual Studio Code, or JetBrains Rider and publish the `Rapture.Client.Installer` project.

After it is built and installed you should be able to connect to a Rapture server.
