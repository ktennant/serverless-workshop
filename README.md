# Serverless Workshop

## Getting Started

### Clone this repo; obviously

`git clone https://github.com/ktennant/serverless-workshop.git`

### Install Git

`choco install git` for Windows or `brew install git` for Mac.

### Install latest versions of .Net Core SDK

If using Visual Studio, just make sure Visual Studio has latest updates; otherwise, [directly download the SDK][dotnet-install].

### Install a REST Client

Postman or Insomnia are preferred.

`choco install postman` or `choco install insomnia-rest-api-client` for Windows.

`brew cask install postman` or `brew cask install insomnia` for Mac.

### Install .Net Core Lambda Tools

```sh
dotnet tool install -g Amazon.Lambda.Tools
dotnet new -i "Amazon.Lambda.Templates::*"
```

## Outline

TBD

[dotnet-install]: https://dotnet.microsoft.com/download
