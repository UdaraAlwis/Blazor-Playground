# Blazor-Playground
Me, myself and I playing around and continusouly learning with Blazor tid bits... for the love of learning and building kickass stuff with .NET platform! ;)

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

#### Notes:
1. The most comprehensive end to end blazor self learning experience ever!
2. Its betetr to build Page UIs with separate Components put together.
3. ```NavigationManager``` allows you to programmatically Navigate in your Blazor app.
4. Save the state of a page in the DI container ```builder.Services.AddScoped<OrderState>();```
5. Saving the state will help you retain data during page navigation
6. Using Annotations on the data model you can easily implement Server side data validation
7. Using ```EditForm```, you implement client side data validation
8. A nicer way to display input data field validation is by using ValidationMessage.
9. ```[Authorize]``` on the API Controller, to enforce Authorization for all incoming calls.
10. Enable the authentication services, add a call to AddApiAuthorization in Program.cs  
11. ```RemoteAuthenticatorView``` component orchestrates the authentication flow.
12. ```CascadingAuthenticationState``` wraps to let you inherit auth state to child elements.
13. ```AuthorizeView```  will let you control displaying of elements based on auth state.
14. Use the ```IAccessTokenProvider``` injected to the pages for aquire AccessTokens.
15. ```AuthenticationStateTask``` lets you check programmatically if the user is logged in or not.
16. ```AuthorizeRouteView``` controls the direct access to routes based on auth state
17. Redirecting will make you lose state, but you can preserve state by implementing ```RemoteAuthenticationState```.
18. 

-----------------


