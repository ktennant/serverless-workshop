# Serverless Workshop

## Getting Started

### Clone this repo

`git clone https://github.com/ktennant/serverless-workshop.git`

> Git can be installed via the command line using `choco install git` for Windows or `brew install git` for Mac.

### Install Visual Studio or Visual Studio Code

Examples will be done is VS Code; however, Visual Studio users will be just fine.

[Download VS Code][download-vs-code]
[Download Visual Studio][download-visual-studio]

### Install latest versions of .NET Core SDK

If using Visual Studio, just make sure Visual Studio has latest updates; otherwise, [directly download the SDK][dotnet-install].

Verify your install with `dotnet --info` from a command line.

### Install a REST Client

Download either [Postman][postman-download] or [Insomnia][insomnia-download]; or install with a terminal.

`choco install postman` or `choco install insomnia-rest-api-client` for Windows.

`brew cask install postman` or `brew cask install insomnia` for Mac.

### Install .NET Core Lambda Tools

```sh
dotnet tool install --global Amazon.Lambda.Tools --version 3.3.1
```

Verify install with `dotnet lambda`. This should print the help documentation.

> Note: Path issues can be resolved by restarting your terminal.

### Install .NET Core Lambda Blueprint Templates

```sh
dotnet new -i "Amazon.Lambda.Templates::*"
```

Verify install with `dotnet new --list`. You should see several `serverless.*` templates.

## Outline

1. Up and Running
1. Create a Web API
1. BREAK
1. Package code for deployment
1. AWS Quick Tour
1. Create serverless infrastructure with AWS console
1. Lunch Break
1. [Testing][testing-tool] and debugging serverless architecture
1. Break
1. Panel discussion
1. Q and A

## Useful Resources

- [dotnet lambda tooling][dotnet-lambda-tooling]
- [Serverless Code Patterns][serverless-code-patterns]
- [Amazon.Lambda.AspNetCoreServer][lambda-aspnetcoreserver]
- [Custom Authorizer Guide][custom-authorizer-guide]
- [AWS Lambda .NET Learning Resources][aws-dotnet-resources]
- [AWS Console][aws-console]

[dotnet-install]: https://dotnet.microsoft.com/download
[download-vs-code]: https://code.visualstudio.com/download
[download-visual-studio]: https://visualstudio.microsoft.com/downloads/
[testing-tool]: http://hstream-serverless-workshop.s3-website-us-east-1.amazonaws.com/
[dotnet-lambda-tooling]: https://github.com/aws/aws-extensions-for-dotnet-cli
[serverless-code-patterns]: https://serverless.com/blog/serverless-architecture-code-patterns/
[lambda-aspnetcoreserver]: https://github.com/aws/aws-lambda-dotnet/blob/master/Libraries/src/Amazon.Lambda.AspNetCoreServer/README.md
[custom-authorizer-guide]: https://www.alexdebrie.com/posts/lambda-custom-authorizers/
[aws-dotnet-resources]: https://github.com/aws/aws-lambda-dotnet#learning-resources
[postman-download]: https://www.getpostman.com/downloads/
[insomnia-download]: https://insomnia.rest/download/
[aws-console]: https://hs-training-sbx.signin.aws.amazon.com/console
