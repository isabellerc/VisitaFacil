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
app.UseAuthorization();// Adicione isso para configurar a autentica��o
app.UseAuthentication(); // Adicione isso para configurar a autentica��o

//services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
//    .AddCookie(options =>
//    {
//        options.Cookie.Name = "Cookies"; // Pode personalizar o nome do cookie se desejar
//        // Outras configura��es do cookie, se necess�rio
//    });


//Verificar no chat se � necessario isso:
//services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
//    .AddCookie(options =>
//    {
//        options.LoginPath = "/DadosPessoais/Login";
//        options.AccessDeniedPath = "/Home/AccessDenied";
//    });

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); //home index


// essa � a rota para acessar o relatorio dos usuarios cadastrados:
//pattern: "{controller=DadosPessoais}/{action=Index}/{id?}");

app.Run();


