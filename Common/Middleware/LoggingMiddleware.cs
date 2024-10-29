using Microsoft.AspNetCore.Http;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Common.Middleware
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var request = context.Request;
            var logMessage = $"Request: {request.Method} {request.Path} at {DateTime.UtcNow}\n";
            await File.AppendAllTextAsync("logs.txt", logMessage);

            await _next(context);

            logMessage = $"Response: {context.Response.StatusCode} at {DateTime.UtcNow}\n";
            await File.AppendAllTextAsync("logs.txt", logMessage);
        }
    }
}
