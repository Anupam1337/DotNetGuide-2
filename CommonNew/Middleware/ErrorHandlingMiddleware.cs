using Microsoft.AspNetCore.Http;
using System.Net;

namespace CommonNew.Middleware
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
            catch (Exception ex)
            {
                context.Response.ContentType = "application/json";
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                var errorResponse = new { status = "error", message = "An unexpected error occurred." + ex.Message.ToString() };
                await context.Response.WriteAsync(System.Text.Json.JsonSerializer.Serialize(errorResponse));
            }
        }
    }
}
