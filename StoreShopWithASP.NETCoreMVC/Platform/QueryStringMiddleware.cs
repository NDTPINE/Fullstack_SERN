using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Platform
{
    public class QueryStringMiddleware
    {
        private RequestDelegate next;
        public QueryStringMiddleware(RequestDelegate nextDelegate)
        {
            next = nextDelegate;
        }
        public QueryStringMiddleware()
        {

        }
        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Method == HttpMethods.Get && context.Request.Query["custom"] == "true")
            {
                await context.Response.WriteAsync("Class-based Middleware \n");
            }
            if (next != null) await next(context);
        }
    }
    public class LocationMiddleware
    {
        private RequestDelegate next;
        private MesageOptions options;
        public LocationMiddleware(RequestDelegate requestDelegate, IOptions<MesageOptions> opts)
        {
            next = requestDelegate;
            options = opts.Value;
        }
        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Path == "/location")
            {
                await context.Response.WriteAsync($"{options.CityName} , {options.CountryName}");
            }
            else await next(context);
        }
    }
}
