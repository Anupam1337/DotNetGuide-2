using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace CommonNew.Middleware
{
    public class RequestValidationMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestValidationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Add validation logic
            // Example validation logic
            if (!context.Request.Headers.ContainsKey("Authorization"))
            {
                context.Response.StatusCode = 400;
                await context.Response.WriteAsync("Authorization header is missing.");
                return;
            }

            await _next(context);
        }
    }
}
