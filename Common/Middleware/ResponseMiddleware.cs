using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Common.Middleware
{
    public class ResponseMiddleware
    {
        private readonly RequestDelegate _next;

        public ResponseMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            await _next(context);

            if (context.Response.StatusCode == StatusCodes.Status200OK)
            {
                context.Response.ContentType = "application/json";
                await context.Response.WriteAsync("{\"status\":\"success\",\"data\":null}");
            }
        }
    }
}
