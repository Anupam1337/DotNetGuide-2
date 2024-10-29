using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Common.Middleware
{
    public class RequestMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine($"Request Method: {context.Request.Method}, Path: {context.Request.Path}");
            await _next(context);
        }
    }
}
