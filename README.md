# Serverless Workshop

## Getting Started

### Clone this repo

`git clone https://github.com/ktennant/serverless-workshop.git`

> Git can be installed via the command line using `choco install git` for Windows or `brew install git` for Mac.

### Install latest versions of .NET Core SDK

If using Visual Studio, just make sure Visual Studio has latest updates; otherwise, [directly download the SDK][dotnet-install].

### Install a REST Client

Postman or Insomnia are preferred.

`choco install postman` or `choco install insomnia-rest-api-client` for Windows.

`brew cask install postman` or `brew cask install insomnia` for Mac.

### Install .NET Core Lambda Tools

```sh
dotnet tool install -g Amazon.Lambda.Tools
dotnet new -i "Amazon.Lambda.Templates::*"
```

## Outline

1. Up and Running
1. Create a Web API
1. BREAK
1. Package code for deployment
1. AWS Quick Tour
1. Create serverless infrastructure with AWS console
1. Lunch Break
1. Testing and debugging serverless architecture
1. Break
1. Panel discussion
1. Q and A

[dotnet-install]: https://dotnet.microsoft.com/download
