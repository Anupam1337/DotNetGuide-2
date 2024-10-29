using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;
using System.Net;
namespace Common.Middleware
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception)
            {
                context.Response.ContentType = "application/json";
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                var errorResponse = new { status = "error", message = "An unexpected error occurred." };
                await context.Response.WriteAsync(System.Text.Json.JsonSerializer.Serialize(errorResponse));
            }
        }
    }
}
