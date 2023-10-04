using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace BankingEx.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class HeaderValidation
    {
        private readonly RequestDelegate _next;

        public HeaderValidation(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            string headerValue = httpContext.Request.Headers["MyItem"][0];
            if (string.Compare(headerValue, "\"Ravi\"", true) == 0)
            {
                return _next(httpContext);
            }

            httpContext.Response.StatusCode = 401;
            return httpContext.Response.WriteAsync("Request Cant Process!");
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class HeaderValidationExtensions
    {
        public static IApplicationBuilder UseHeaderValidation(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<HeaderValidation>();
        }
    }
}
