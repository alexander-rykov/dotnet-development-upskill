using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace CoreMvcDemo
{
    public class CustomMiddleware
    {
        private readonly IResponseWriter _responseWriter;

        public CustomMiddleware(RequestDelegate next, IResponseWriter responseWriter)
        {
            _responseWriter = responseWriter;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            context.Response.ContentType = "application/json";
            _responseWriter.AddText("{response: Hello response}");
            await _responseWriter.WriteAsync(context.Response);
        }
    }

    public static class CustomMiddlewareExtensions
    {
        public static IApplicationBuilder UseCustomMiddleware(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomMiddleware>();
        }
    }
}
