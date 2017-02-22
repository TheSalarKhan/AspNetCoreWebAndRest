# Hello world!

This project is a template for making web applications in ASP NET. It is specifically designed for applications that require
a traditional web frontend as well as a REST API for integration with mobile applications/

## This application consists of:

*   ASP NET CORE 1.1.0
*   Razor Templating engine
*   Entity Framework Core 1.1.0 (MS-SQL SERVER by default)
*   Database seeder.
*   Dependancy Injection
*   Swagger UI, for REST API documentation
*   Command line tools for EntityFrameworkCore
*   Braintree payment gateway
*   SendGrid emailing API.


## Conventions

Usually .NET CORE apps have the following directory structure which is not suitable for large projects. 
When the number of files go up, it becomes confusing:
```
Usual .NET CORE APP:
   App/
       Controllers/
           Module1Controller.cs
           Module2Controller.cs
       Services/
           Module1Service.cs
           Module2Service.cs
       Models/
           Module1Model.cs
           Module2Model.cs
```

But In this template we use the following directory structure, which is way more manageable. Inspired by Python's Django framework.

```
Super cool .NET CORE APP:
   App/
       Modules/
           Module1/
               Controllers/
                   Module1Controller.cs
               Services/
                   Module1Service.cs
               Models/
                   Module1Model.cs
               Entities/
                   Module1ReqRes.cs
           Module2/
               Controllers/
                   Module2Controller.cs
              Services/
                  Module2Service.cs
              Models/
                  Module2Model.cs
               Entities/
                   Module2ReqRes.cs
```

I could not find a way around structuring views though!

## Base classes!
   The module 'BaseModule' defines some base classes for Controllers, Models, Services, and request response objects.
```
   BaseController: Its a controller that implements injectable logic, just extend from it and implement the required constructor.
   BaseService: Its a service that implements injectable logic, just extend from it and implement the required constructor.
   BaseResponse: A basic response object.
   UserRequest: A request object with UserId attribute. Extend from this instead of declaring UserId whenever required. DRY (Don't repeat yourself).
```


## Magic numbers!
* Constant/Constants.cs is where all the magic numbers must be declared.

## Deploy to azure!
This template is deployment ready for AZURE, simple create a project and setup git deployment method. After that whenever
you push to AZURE the project will get deployed.

## Adding and running migrations
After you have created EF models in your Module/your_module/Models folder under the namespace Application.Models. Simply run
```
$ dotnet ef database migrations add migartion_name
```
This will add a migration. To apply the migration to the database, make sure you have provided the connection string in Database/ApplicationDbContext.cs
and then run:
```
$ dotnet ef database update
```
If you want to clean the database then execute '$ dotnet ef database update 0' first.

## Database Seeder.
The database seeder is located at Database/DbSeeder/DbSeeder.cs. The seeder simply provides you access to your database context in the method 'SeedData()'
whatever you write in there will be run the next time you execute the application.

## Run Application
To run the app simply write: 'dotnet run'. Make sure to run 'dotnet restore' the first time, and after everytime you make a change to project.json
