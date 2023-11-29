using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using VisitaFacil.Dados;

var builder = WebApplication.CreateBuilder(args);

// Configure the application services
builder.Services.AddControllersWithViews();

// Add database context configuration
builder.Services.AddDbContext<Contexto>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MinhaConexaoSQL"));
});

// Rest of the ConfigureServices configuration

var app = builder.Build();

// Configure the HTTP request pipeline

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();// Adicione isso para configurar a autenticação
app.UseAuthentication(); // Adicione isso para configurar a autenticação


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); //home index

app.Run();
