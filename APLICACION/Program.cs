using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PARCIAL1.Cliente_API; // Aseg�rate de tener acceso a tu clase ApiClient

var builder = WebApplication.CreateBuilder(args);

// No necesitas la configuraci�n de la base de datos local

// Agregar servicios a la colecci�n
builder.Services.AddControllersWithViews();

// Agregar el cliente API como un servicio
var apiBaseUri = "https://localhost:7128"; // Reemplaza con la URL de tu API
builder.Services.AddSingleton(new ApiClient(apiBaseUri));

var app = builder.Build();

// Configurar el pipeline de solicitud HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "custom",
    pattern: "{controller=Alquilers}/{action=Principal}/{id?}"); // Configurar la p�gina de inicio aqu�

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Alquilers}/{action=Index}/{id?}");

app.Run();

