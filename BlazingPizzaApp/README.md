# BlazingPizzaApp, the Blazor Workshope
This is me building the BlazingPizzaApp workshop project, for self learning Blazor.
https://github.com/dotnet-presentations/blazor-workshop/

Completed and Published: https://blazingpizzaappudara.azurewebsites.net

![BlazingPizzaApp Screenshot](https://raw.githubusercontent.com/UdaraAlwis/Blazor-Playground/master/BlazingPizzaApp/Screenshots/1%20PWA.png)

#### Notes: 
1. The most comprehensive end to end blazor self learning experience ever!
2. Its better to build Page UIs with separate Components put together.
3. ```NavigationManager``` allows you to programmatically Navigate in your Blazor app.
4. Save the state of a page in the DI container ```builder.Services.AddScoped<OrderState>();```
5. Saving the state will help you retain data during page navigation
6. Using Annotations on the data model you can easily implement Server side data validation
7. Using ```EditForm```, you implement client side data validation
8. A nicer way to display input data field validation is by using ```ValidationMessage```.
9. ```[Authorize]``` on the API Controller, to enforce Authorization for all incoming calls.
10. To enable the authentication services, for your Blazor Client add a call to ```AddApiAuthorization``` in Program.cs  
11. ```RemoteAuthenticatorView``` component orchestrates the authentication flow.
12. ```CascadingAuthenticationState``` wraps to let you inherit auth state to child elements.
13. ```AuthorizeView```  will let you control displaying of elements based on auth state.
14. Use the ```IAccessTokenProvider``` injected to the pages for aquire AccessTokens.
15. ```AuthenticationStateTask``` lets you check programmatically if the user is logged in or not.
16. ```AuthorizeRouteView``` controls the direct access to routes based on auth state
17. Redirecting will make you lose state, but you can preserve it by implementing ```RemoteAuthenticationState```.
18. Inject ```IJSRuntime``` to invoke JavaScript functions with ```JSRuntime.InvokeVoidAsync()``` method.
19. Build Templated Components to increase the reusability of Components.
20. Easily set up PWA features (installable, offline, push notifications) for Blazor, with ```service-worker.js``` configuration.
21. Use ```WebPush``` to set up Push Notifications in your Blazor application and Server backend.
22. Displaying and handling the received Push Notification is set up in ```service-worker.js```.
23. To Publish to Azure, you need to create an ```App Service``` and ```Hosting Plan``` of Basic tier or higher.
24. Finally you need to set up a signing key with ```Azure Key Vault``` for the IdentityServer.

![BlazingPizzaApp Screenshot](https://raw.githubusercontent.com/UdaraAlwis/Blazor-Playground/master/BlazingPizzaApp/Screenshots/2%20Web%20App.png)

![BlazingPizzaApp Screenshot]()

![BlazingPizzaApp Screenshot]()

![BlazingPizzaApp Screenshot]()

![BlazingPizzaApp Screenshot]()

![BlazingPizzaApp Screenshot]()

![BlazingPizzaApp Screenshot]()

![BlazingPizzaApp Screenshot]()






![BlazingPizzaApp Screenshot](https://raw.githubusercontent.com/UdaraAlwis/Blazor-Playground/master/BlazingPizzaApp/Screenshots/10%20Publish%20to%20Azure.png)

