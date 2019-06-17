# MusicBrainz
Techincal Assessment

Project MusicBrainz RESTful API built with ASP.NET Core 2.2 with decoupled, maintainable architecture.

## Frameworks and Libraries
- [ASP.NET Core 2.2](https://docs.microsoft.com/pt-br/aspnet/core/?view=aspnetcore-2.2);
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/) (for data access);
- [Entity Framework In-Memory Provider](https://docs.microsoft.com/en-us/ef/core/miscellaneous/testing/in-memory) (for testing purposes);
- [AutoMapper](https://automapper.org/) (for mapping resources and models);

## Connection String
Please use the database script attach to setup the database and modify connection string in the project.

## IIS 
Publish Api and setup IIS sever.

## How to Test

First, install [.NET Core 2.2](https://dotnet.microsoft.com/download/dotnet-core/2.2). 
To test all endpoints, you need to use Postman(https://www.getpostman.com/).

Navigate to ```http://localhost:65397/api/artist/search/joh/2/5``` \. 
Navigate to ```http://localhost:65397/api/artist/a74b1b7f-71a5-4011-9441-d0b5e4122711/releases``` \. 
Navigate to ```http://localhost:65397/api/artist/c44e9c22-ef82-4a77-9bcd-af6c958446d6/albums``` \. 

## 
