using Microsoft.AspNetCore.Http;
using System.Net.Http;

namespace CommonNew.Middleware
{
    public class ResponseFormattingMiddleware
    {
        private readonly RequestDelegate _next;

        public ResponseFormattingMiddleware(RequestDelegate next)
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
