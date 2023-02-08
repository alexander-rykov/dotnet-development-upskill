using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace CoreMvcDemo
{
    public interface IResponseWriter
    {
        void AddText(string text);
        Task WriteAsync(HttpResponse response);
    }
}