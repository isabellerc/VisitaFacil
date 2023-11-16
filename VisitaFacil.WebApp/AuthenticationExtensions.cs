using Microsoft.AspNetCore.Authentication.Cookies;

namespace VisitaFacil.WebApp
{
    public static class AuthenticationExtensions
    {
        public static void ConfigureAuthentication(this IServiceCollection services)
        {
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = "/Idoso"; // Página de login
                    options.AccessDeniedPath = "/Conta/AcessoNegado"; // Página de acesso negado
                    options.Cookie.Name = "Cookies";
                });
        }
    }
}
