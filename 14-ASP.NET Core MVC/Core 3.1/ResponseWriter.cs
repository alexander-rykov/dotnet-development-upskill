using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace CoreMvcDemo
{
    public class ResponseWriter : IResponseWriter
    {
        private readonly StringBuilder _stringBuilder;

        public ResponseWriter()
        {
            _stringBuilder = new StringBuilder();
        }

        public void AddText(string text)
        {
            _stringBuilder.AppendLine(text);
        }

        public async Task WriteAsync(HttpResponse response)
        {
            await response.WriteAsync(_stringBuilder.ToString());
        }
    }
}