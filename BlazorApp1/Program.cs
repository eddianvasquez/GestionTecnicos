using BlazorApp1.Components.models;
using BlazorApp1.Components.services;
using BlazorApp1.Components.Layout.DAL;
using Microsoft.EntityFrameworkCore;
using BlazorApp1.Components;

var builder = WebApplication.CreateBuilder(args);

// Cadena de conexión
var connectionString = builder.Configuration.GetConnectionString("SqlConStr");

// Servicios
builder.Services.AddRazorComponents().AddInteractiveServerComponents();
builder.Services.AddScoped<TecnicosService>();
builder.Services.AddDbContext<ContextoPrueba>(options =>
    options.UseSqlServer(connectionString));

var app = builder.Build();

// Middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>().AddInteractiveServerRenderMode();

app.Run();
