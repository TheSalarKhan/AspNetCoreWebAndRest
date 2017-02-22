# Hello world!

This project is a template for making web applications in ASP NET. It is specifically designed for applications that require
a traditional web frontend as well as a REST API for integration with mobile applications/

## This application consists of:

*   ASP NET CORE 1.1.0
*   Razor Templating engine
*   Entity Framework Core 1.1.0 (MS-SQL SERVER by default)
*   Dependancy Injection
*   Swagger UI, for REST API documentation
*   Command line tools for EntityFrameworkCore
*   Braintree payment gateway
*   SendGrid emailing API.


## Conventions

Usually .NET CORE apps have the following directory structure which is not suitable for large projects. 
When the number of files go up, it becomes confusing:
* Usual .NET CORE APP:
*   App/
*       Controllers/
*           Module1Controller.cs
*           Module2Controller.cs
*       Services/
*           Module1Service.cs
*           Module2Service.cs
*       Models/
*           Module1Model.cs
*           Module2Model.cs

But In this template we use the following directory structure, which is way more manageable. Inspired by Python's Django framework.
* Super cool .NET CORE APP:
*   App/
*       Modules/
*           Module1/
*               Controllers/
*                   Module1Controller.cs
*               Services/
*                   Module1Service.cs
*               Models/
*                   Module1Model.cs
*               Entities/
*                   Module1ReqRes.cs
*           Module2/
*               Controllers/
*                   Module2Controller.cs
*              Services/
*                  Module2Service.cs
*              Models/
*                  Module2Model.cs
*               Entities/
*                   Module2ReqRes.cs

I could not find a way around structuring views though!

## Base classes!
*   The module 'BaseModule' defines some base classes for Controllers, Models, Services, and request response objects.
*   BaseController: Its a controller that implements injectable logic, just extend from it and implement the required constructor.
*   BaseService: Its a service that implements injectable logic, just extend from it and implement the required constructor.
*   BaseResponse: A basic response object.
*   UserRequest: A request object with UserId attribute. Extend from this instead of declaring UserId whenever required. DRY (Don't repeat yourself).


## Magic numbers!

## Overview

*   [Conceptual overview of what is ASP.NET Core](https://go.microsoft.com/fwlink/?LinkId=518008)
*   [Fundamentals of ASP.NET Core such as Startup and middleware.](https://go.microsoft.com/fwlink/?LinkId=699320)
*   [Working with Data](https://go.microsoft.com/fwlink/?LinkId=398602)
*   [Security](https://go.microsoft.com/fwlink/?LinkId=398603)
*   [Client side development](https://go.microsoft.com/fwlink/?LinkID=699321)
*   [Develop on different platforms](https://go.microsoft.com/fwlink/?LinkID=699322)
*   [Read more on the documentation site](https://go.microsoft.com/fwlink/?LinkID=699323)

## Run & Deploy

*   [Run your app](https://go.microsoft.com/fwlink/?LinkID=517851)
*   [Run tools such as EF migrations and more](https://go.microsoft.com/fwlink/?LinkID=517853)
*   [Publish to Microsoft Azure Web Apps](https://go.microsoft.com/fwlink/?LinkID=398609)

We would love to hear your [feedback](https://go.microsoft.com/fwlink/?LinkId=518015)
