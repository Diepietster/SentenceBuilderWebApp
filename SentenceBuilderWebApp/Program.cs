using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SentenceBuilderWebApp;
using SentenceBuilderWebApp.APIManager.Data;
using SentenceBuilderWebApp.APIManager.Interface;
using SentenceBuilderWebApp.APIManager.Service;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7163/api/") });
builder.Services.AddScoped<IAPICallManager, APICallManager>();
builder.Services.AddScoped<APICallService>();

await builder.Build().RunAsync();
