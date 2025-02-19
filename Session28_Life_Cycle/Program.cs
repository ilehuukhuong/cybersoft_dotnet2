using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Session28_Life_Cycle;
using Session28_Life_Cycle.Service;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://apistore.cybersoft.edu.vn/api/") });
builder.Services.AddScoped<ProductService>();

await builder.Build().RunAsync();
