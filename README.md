# Blazor-Playground
Me, myself and I playing around and continusouly learning with Blazor tid bits...

### Get started with ASP.NET Core Blazor
https://docs.microsoft.com/en-us/aspnet/core/blazor/get-started?view=aspnetcore-3.1&tabs=visual-studio
> Project /BlazorClientApp

![BlazorClientApp Screenshot](https://raw.githubusercontent.com/UdaraAlwis/Blazor-Playground/master/Screenshots/BlazorClientApp/Finished.png)

#### Notes:
1. Splitting Counter.razor file with the Counter.razor.cs code behind implementation. 
```csharp
public class CounterBase : ComponentBase
{
	[Parameter]
	public int CurrentCount { get; set; } = 0;

	public void IncrementCount(){ ... }
}
```
2. Extending from ComponentBase and inherited ```@inherits CounterBase``` into Counter.razor page
3. Added Counter.razor as a Component into the Index.razor page
4. Switched from ```HttpClient.GetFromJsonAsync()``` to ```HttpClient.GetAsync()``` with the use of System.Text.Json.JsonSerializer
5. Blazor Client renders content in Client's Web Browser
6. Blazor Client Apps = Blazor WebAssembly Apps
7. Blazor Client Apps cannot directly debug in Visual Studio

-----------------

### Build your first Blazor app
https://docs.microsoft.com/en-us/aspnet/core/tutorials/build-your-first-blazor-app?view=aspnetcore-3.1
> Project /BlazorTodoApp

![BlazorPersonApp Screenshot](https://raw.githubusercontent.com/UdaraAlwis/Blazor-Playground/master/Screenshots/BlazorTodoApp/Finished.png)

#### Notes:
1. In-Memory todo list created in Todo.razor page
2. Adding the Navigation path in NavMenu.razor
3. Data binding with ```@bind="newTodo"``` across web UI elements
4. Adding Bootstrap css decorations for the elements

-----------------

### Intro to Blazor (Preview 7) - Replace JavaScript with client-side C#
https://www.youtube.com/watch?v=CaxR4_fP-FA
> Project /BlazorPersonApp

![BlazorPersonApp Screenshot](https://raw.githubusercontent.com/UdaraAlwis/Blazor-Playground/master/Screenshots/BlazorPersonApp/Finished.png)

#### Notes:
1. ASP.NET Hosted Blazor Client App solution was created.
2. Added a ```PersonController``` API endpoint in the BlazorPersonApp.Server project
3. Implemented Get and Post endpoints in the PersonController and implemented calls to pull data for the Client App

-----------------

### Intro to Blazor Server Side - Includes SQL Data Access and Best Practices
https://www.youtube.com/watch?v=8DNgdphLvag
> Project /BlazorServerApp

![BlazorServerApp Screenshot](https://raw.githubusercontent.com/UdaraAlwis/Blazor-Playground/master/Screenshots/BlazorServerApp/Finished.png)

![BlazorServerApp Database Set up](https://raw.githubusercontent.com/UdaraAlwis/Blazor-Playground/master/Screenshots/BlazorServerApp/Database%20set%20up.png)

#### Notes:
1. You can mix and mingle ASP.NET Core UI Components and Bootstrap Css Style
```html
...
<InputText class="form-control" placeholder="First Name" 
id="firstName" @bind-Value="_newPerson.FirstName" />
...
```
2. Using ```EditForm``` Component with ```DataAnnotationsValidator``` for validating data model
```html
<EditForm class="form-group" Model="@_newPerson" OnValidSubmit="InsertPerson">
    <DataAnnotationsValidator />
    <ValidationSummary />
	...
<EditForm>
```
3. Make sure to create a local Database and set up the following table
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
4. Blazor Server renders content in Server, and uses SignalR WebSockets to transfer data back and forth
5. Blazor Server Apps can directly debug in Visual Studio
6. How to identify Blazor Server project? in the Startup.cs look for ```services.AddServerSideBlazor();```
    
-----------------

### Blazor Server Components - Making Razor Components Easy to Use
https://www.youtube.com/watch?v=JE0tQ4tx0Nc
> Project /BlazorComponentsApp

![BlazorComponentsApp Screenshot](https://raw.githubusercontent.com/UdaraAlwis/Blazor-Playground/master/Screenshots/BlazorComponentsApp/Finished.png)

#### Notes:
1. Created the simple TaskList Component and reused it multiple times in a single page
2. You can use multiple Components in a single page
3. You can also Nest components within each other
4. Remove ```@page "/TaskList"``` so it can't be used as a page

-----------------

### Blazor - app building workshop
https://github.com/dotnet-presentations/blazor-workshop/
> /BlazingPizzaApp

![BlazingPizzaApp Screenshot](https://raw.githubusercontent.com/UdaraAlwis/Blazor-Playground/master/Screenshots/BlazingPizzaApp/Finished.png)



