using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using ProgramacionWebTrabajoPracticoN3;
using ProgramacionWebTrabajoPracticoN3.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// 1. Configurar HttpClient apuntando a tu backend en HTTPS
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7133/") });

// 2. Registrar nuestro LocalStorageService nativo
builder.Services.AddScoped<LocalStorageService>();

// 3. Registrar el proveedor de estado de autenticación (lo crearemos en el próximo paso)
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
builder.Services.AddAuthorizationCore();

// 4. Registrar los servicios de MudBlazor para la UI
builder.Services.AddMudServices();

await builder.Build().RunAsync();