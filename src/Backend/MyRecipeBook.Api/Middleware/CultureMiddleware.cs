using System.Globalization;

namespace MyRecipeBook.Api.Middleware
{
    /// <summary>
    /// Classe Middleware para interceptar durante start da aplicação
    /// </summary>
    public class CultureMiddleware
    {
        private readonly RequestDelegate _next;

        public CultureMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var requestedCulture = context.Request.Headers.AcceptLanguage.FirstOrDefault();

            var cultureInfo = new CultureInfo(requestedCulture);

            CultureInfo.CurrentCulture = cultureInfo;
            CultureInfo.CurrentUICulture = cultureInfo;

            // para fazer com que a execução da aplicação continue
            await _next(context);
        }
    }
}
