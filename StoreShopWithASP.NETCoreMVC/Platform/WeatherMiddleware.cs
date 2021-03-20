using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Platform.Services;
namespace Platform
{
    public class WeatherMiddleware
    {
        private RequestDelegate next;
        //private IResponseFormatter formatter;

        public WeatherMiddleware(RequestDelegate nextDelegate /*, IResponseFormatter respformatter*/)
        {
            next = nextDelegate;
            //formatter = respformatter;

        }
        public async Task Invoke (HttpContext context, IResponseFormatter formatter, IResponseFormatter formatter1, IResponseFormatter formatter2)
        {
            if (context.Request.Path == "/middleware/class")
            {
                await formatter.Format(context, $"Middleware class: It is raining in London");
                await formatter1.Format(context, string.Empty);
                await formatter2.Format(context, string.Empty);
            }
            else await next(context);

        }
    }
}
