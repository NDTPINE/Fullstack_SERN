using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Platform
{
    public static class Population
    {
        //private RequestDelegate next;
        //public Population() { }
        //public Population(RequestDelegate nexttDelegate)
        //{
        //    next = nexttDelegate;
        //}
        //public async Task Invoke(HttpContext context)
        //{
        //    string[] parts = context.Request.Path.ToString().Split("/", StringSplitOptions.RemoveEmptyEntries);
        //    if (parts.Length == 2 && parts[0] == "population")
        //    {
        //        string city = parts[1];
        //        int? pop = null;
        //        switch (city.ToLower())
        //        {
        //            case "london":
        //                pop = 8136000;
        //                break;
        //            case "paris":
        //                pop = 2141000;
        //                break;
        //            case "monaco":
        //                pop = 39000;
        //                break;
        //        }
        //        if (pop.HasValue)
        //        {
        //            await context.Response.WriteAsync($"City {city}, Population: {pop}");
        //            return;
        //        }
        //    }
        //    if (next != null) await next(context);
        //}
        public static async Task Endpoints(HttpContext context)
        {
            int? pop = null;
            string city = context.Request.RouteValues["city"] as string ?? "london";
            switch (city.ToLower())
            {
                case "london":
                    pop = 8136000;
                    break;
                case "paris":
                    pop = 2141000;
                    break;
                case "monaco":
                    pop = 39000;
                    break;
            }
            if (pop.HasValue)
            {
                await context.Response.WriteAsync($"City: {city}, Population: {pop}");
            }
            else context.Response.StatusCode = StatusCodes.Status404NotFound;
        }
    }
}
