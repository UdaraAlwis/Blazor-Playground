# Blazor-Playground
Me myself and I playing around with Blazor tid bits...

#### Get started with ASP.NET Core Blazor
https://docs.microsoft.com/en-us/aspnet/core/blazor/get-started?view=aspnetcore-3.1&tabs=visual-studio
> Project /BlazorClientApp

-----------------

#### Build your first Blazor app
https://docs.microsoft.com/en-us/aspnet/core/tutorials/build-your-first-blazor-app?view=aspnetcore-3.1
> Project /BlazorTodoApp

-----------------

#### Intro to Blazor (Preview 7) - Replace JavaScript with client-side C#
https://www.youtube.com/watch?v=CaxR4_fP-FA
> Project /BlazorPersonApp

-----------------

#### Intro to Blazor Server Side - Includes SQL Data Access and Best Practices
https://www.youtube.com/watch?v=8DNgdphLvag
> Project /BlazorServerApp
##### Notes:
You can mix and mingle ASP.NET Core UI Components and Css Style
```html
...
<InputText class="form-control" placeholder="First Name" 
id="firstName" @bind-Value="_newPerson.FirstName" />
...
```
Make sure to create a local Database and set up the following table
```sql
CREATE TABLE [dbo].[People] (
    [Id]           INT          IDENTITY (1, 1) NOT NULL,
    [FirstName]    VARCHAR (50) NULL,
    [LastName]     VARCHAR (50) NULL,
    [DateOfBirth]  DATETIME     NULL,
    [EmailAddress] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
```
    
-----------------

#### Blazor - app building workshop
https://github.com/dotnet-presentations/blazor-workshop/

