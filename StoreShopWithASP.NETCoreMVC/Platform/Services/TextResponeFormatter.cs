using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Platform.Services
{
    public class TextResponeFormatter : IResponseFormatter
    {
        private int responseCounter = 0;
        private static TextResponeFormatter shared;
        public async Task Format(HttpContext context, string content)
        {
            await context.Response.WriteAsync($"Response {++responseCounter}: \n {content} ");
        }
        public static TextResponeFormatter singleton
        {
            get
            {
                if (shared == null) shared = new TextResponeFormatter();
                return shared;
            } 
        }
    }
}
