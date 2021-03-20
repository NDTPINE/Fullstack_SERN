using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Webapp.Models;

namespace Webapp
{
    public class TestMiddleware
    {
        private RequestDelegate nextDelegate;
        public TestMiddleware(RequestDelegate next)
        {
            nextDelegate = next;
        }
        public async Task Invoke(HttpContext context, DataContext datacontext)
        {
            if (context.Request.Path == "/test")
            {
                await context.Response.WriteAsync($"There are {datacontext.Products.Count()} product\n");
                await context.Response.WriteAsync($"There are {datacontext.Categories.Count()} Categories\n");
                await context.Response.WriteAsync($"There are {datacontext.Suppliers.Count()} Suppliers\n");
            }
            else await nextDelegate(context);
        }
    }
}
