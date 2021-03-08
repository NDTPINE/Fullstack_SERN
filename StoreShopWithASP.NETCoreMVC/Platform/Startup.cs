using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

namespace Platform
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.Configure<MesageOptions>(options =>
            //{
            //    options.CityName = "Albany";
            //});
            services.Configure<RouteOptions>(opts =>
            {
                opts.ConstraintMap.Add("countrName", typeof(CountryRouteConstraint));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IOptions<MesageOptions> msgOptions)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
        #region EXAMPLE
            // Defining Middleware Using a Class
            //app.UseMiddleware<QueryStringMiddleware>();
            // Creating Custom Middleware
            //app.Use(async (context, next) =>
            //{
            //    if (context.Request.Method == HttpMethods.Get && context.Request.Query["custom"] == "true")
            //    {
            //        await context.Response.WriteAsync("CUSTOM MIDDLEWARE \n");
            //    }
            //    await next();
            //});

            //app.Use(async (context, next) =>
            //{
            //    await next();
            //    await context.Response.WriteAsync($"\n Status Code: {context.Response.StatusCode}");
            //});
            //app.Use(async (context, next) =>
            //{
            //    if (context.Request.Path == "/short")
            //    {
            //        await context.Response.WriteAsync($"Request Short Circuited");
            //    }
            //    else { await next(); }
            //});
            // Create pipeline Branches
            //app.Map("/branch", branch =>
            //{
            //    branch.UseMiddleware<QueryStringMiddleware>();
            //    branch.Use(async (context, next) => {
            //        await context.Response.WriteAsync($"Branch Middleware");
            //    });
            //});
            //app.Map("/branch", branch =>
            //{
            //    branch.Run(new QueryStringMiddleware().Invoke);
            //});

            //app.UseMiddleware<QueryStringMiddleware>();
            //app.Use(async (context, next) =>
            //{
            //    if (context.Request.Path == "/location")
            //    {
            //        MesageOptions opts = msgOptions.Value;
            //        await context.Response.WriteAsync($"{opts.CityName}, {opts.CountryName}");
            //    }
            //    else await next();
            //});

            //app.UseMiddleware<LocaionMiddleware>();
            //app.UseRouting();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!");
            //    });
            //});

            //app.UseMiddleware<Population>();
            //app.UseMiddleware<Capital>();

#endregion
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("{first}/{second}/{*catchall}", async context =>
                {
                    await context.Response.WriteAsync($"Request was routed\n");
                    foreach (var kvp in context.Request.RouteValues)
                    {
                        await context.Response.WriteAsync($"{kvp.Key} : {kvp.Value} \n");
                    }
                });
                endpoints.MapGet("{first:int}/{second:bool}", async context =>
                {
                    await context.Response.WriteAsync($"Request was routed\n");
                    foreach (var kvp in context.Request.RouteValues)
                    {
                        await context.Response.WriteAsync($"{kvp.Key} : {kvp.Value} \n");
                    }
                });
                endpoints.MapGet("capital/{country:countryName}", Capital.Endpoints);
                endpoints.MapGet("files/{filename}.{ext}", async context =>
                {
                    await context.Response.WriteAsync($"Request was routed 2\n");
                    foreach (var kvp in context.Request.RouteValues)
                    {
                        await context.Response.WriteAsync($"{kvp.Key} : {kvp.Value} \n");
                    }
                });
                //endpoints.MapGet("capital/{country=France}", Capital.Endpoints);
                endpoints.MapGet("capital/{country:regex(^uk|france|monaco$)}", Capital.Endpoints);
                endpoints.MapGet("size/{city?}", Population.Endpoints).WithMetadata(new RouteNameMetadata("population"));

                endpoints.MapFallback(async context =>
                {
                    await context.Response.WriteAsync("Routed to fallback endpoint");
                });

            });

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Temiral Middleware Reached");
            });

        }
    }
}
