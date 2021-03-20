using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Routing;
using Platform.Services;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.FileProviders;
using System.Threading.Tasks;
using Microsoft.AspNetCore.HostFiltering;
using Platform.Models;
using Microsoft.EntityFrameworkCore;

namespace Platform
{
    public class Startup
    {
        public Startup(IConfiguration config)
        {
            Configuration = config;
        }
        private IConfiguration Configuration;
        public void ConfigureServices(IServiceCollection servires)
        {
            servires.AddDistributedSqlServerCache(opt =>
            {
                opt.ConnectionString = Configuration["ConnectionStrings:CacheConnection"];
                opt.SchemaName = "dbo";
                opt.TableName = "DataCache";
            });
            servires.AddResponseCaching();
            servires.AddSingleton<IResponseFormatter, HtmlResponseFormatter>();
            servires.AddDbContext<CalculationContext>(opts => {
                opts.UseSqlServer(Configuration["ConnectionStrings:CalcConnection"]);
            });
            servires.AddTransient<SeedData>();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IHostApplicationLifetime lifttime, SeedData seedData)
        {
            app.UseDeveloperExceptionPage();
            app.UseResponseCaching();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapEndPoint<SumEndpoint>("/sum/{count:int=100000000}");
                
                endpoints.MapFallback("/", async context =>
                {
                    await context.Response.WriteAsync("Hello");
                });
            });
            bool cmdLineInit = (Configuration["INITDB"] ?? "false") == "true";
            if (env.IsDevelopment() || cmdLineInit)
            {
                seedData.SeedDatabase();
                if (cmdLineInit)
                {
                    lifttime.StopApplication();
                }
            }
        }
        #region Example ConfigureServices
        //public Startup(IConfiguration config)
        //{
        //    Configuration = config;
        //}
        //private IConfiguration Configuration;

        //public void ConfigureServices(IServiceCollection services)
        //{
        //servires.Configure<CookiePolicyOptions>(opt =>
        //   {
        //       opt.CheckConsentNeeded = context => true;
        //   });
        //   servires.AddDistributedMemoryCache();
        //   servires.AddSession(options =>
        //   {
        //       options.IdleTimeout = TimeSpan.FromMinutes(30);
        //       options.Cookie.IsEssential = true;
        //   });
        //   servires.AddHsts(opt =>
        //   {
        //       opt.MaxAge = TimeSpan.FromDays(1);
        //       opt.IncludeSubDomains = true;
        //   });
        //   servires.Configure<HostFilteringOptions>(opt =>
        //   {
        //       opt.AllowedHosts.Clear();
        //       opt.AllowedHosts.Add("*");
        //   });  
        //servires.Configure<MesageOptions>(Configuration.GetSection("Location"));

        //services.Configure<MesageOptions>(options =>
        //{
        //    options.CityName = "Albany";
        //});
        //services.Configure<RouteOptions>(opts =>
        //{
        //    opts.ConstraintMap.Add("countrName", typeof(CountryRouteConstraint));
        //});
        //services.AddSingleton<IResponseFormatter, HtmlResponseFormatter>();
        //services.AddScoped<IResponseFormatter, GuidService>();
        //services.AddScoped<IResponseFormatter, TimeResponseFormatter>();
        //services.AddScoped<IResponseFormatter>(ServiceProvider =>
        //{
        //string typeName = Configuration["services:IResponseFormatter"];
        //return (IResponseFormatter)ActivatorUtilities.CreateInstance (ServiceProvider, typeName == null
        //      ? typeof(GuidService) : Type.GetType(typeName, true));
        //});
        //services.AddScoped<ITimeStamper, DefaultTimeStamper>();
        //services.AddScoped<IResponseFormatter, TextResponeFormatter>();
        //services.AddScoped<IResponseFormatter, HtmlResponseFormatter>();
        //services.AddSingleton(typeof(ICollection<>), typeof(List<>));

        //}
        //services.AddScoped<IResponseFormatter, GuidService>();
        #endregion
        #region EXAMPLE
        //public void Configure(IApplicationBuilder app, IWebHostEnvironment env /*,IResponseFormatter formatter*/ /*IOptions<MesageOptions> msgOptions */)
        //{
        //    app.UseDeveloperExceptionPage();
        //app.UseDeveloperExceptionPage();
        //app.UseExceptionHandler("/error.html");
        //if (env.IsProduction())
        //{
        //    app.UseHsts();
        //}
        //app.UseHttpsRedirection();
        //app.UseStatusCodePages("text/html", ResponseStrings.DefaultResponse);
        //app.UseCookiePolicy();
        //app.UseRouting();
        //app.UseSession();
        //app.UseMiddleware<ConsentMiddleware>();
        //app.UseStaticFiles();
        //app.Use(async (context, next) =>
        //{
        //    if (context.Request.Path == "/error")
        //    {
        //        context.Response.StatusCode = StatusCodes.Status400BadRequest;
        //        await Task.CompletedTask;
        //    }
        //    else await next();
        //});
        //app.Run(context =>
        //{
        //    throw new Exception("Something has gone wrong");
        //});

        //app.UseEndpoints(endpoints =>
        //{
        //    endpoints.MapGet("/cookie", async context =>
        //    {
        //        int counter1 = int.Parse(context.Request.Cookies["counter1"] ?? "0") + 1;
        //        context.Response.Cookies.Append("counter1", counter1.ToString(), new CookieOptions
        //        {
        //            MaxAge = TimeSpan.FromMinutes(30),
        //            IsEssential = true
        //        });
        //        int counter2 = int.Parse(context.Request.Cookies["counter2"] ?? "0") + 1;
        //        context.Response.Cookies.Append("counter2", counter2.ToString(), new CookieOptions
        //        {
        //            MaxAge = TimeSpan.FromMinutes(30)
        //        });
        //        await context.Response.WriteAsync($"Counter1: {counter1}, Counter2: {counter2}");
        //    });
        //    endpoints.MapGet("clear", context =>
        //    {
        //        context.Response.Cookies.Delete("counter1");
        //        context.Response.Cookies.Delete("counter2");
        //        context.Response.Redirect("/");
        //        return Task.CompletedTask;
        //    });
        //    endpoints.MapGet("/cookie", async context =>
        //    {
        //        int counter1 = (context.Session.GetInt32("counter1") ?? 0) + 1;
        //        int counter2 = (context.Session.GetInt32("counter2") ?? 0) + 1;
        //        context.Session.SetInt32("counter1", counter1);
        //        context.Session.SetInt32("counter2", counter2);
        //        await context.Session.CommitAsync();
        //        await context.Response.WriteAsync($"Counter1: {counter1}, Counnter2: {counter2}");

        //    });

        //    endpoints.MapFallback(async context =>
        //    {
        //        await context.Response.WriteAsync($"Hello");
        //    });
        //});
        //    app.UseRouting();

        //    app.UseEndpoints(endpoints =>
        //    {
        //        endpoints.MapGet("/string", async context =>
        //        {
        //            ICollection<string> collection = context.RequestServices.GetService<ICollection<string>>();
        //            collection.Add($"Request { DateTime.Now.ToLongTimeString() }");
        //            foreach (string str in collection)
        //            {
        //                await context.Response.WriteAsync($"String: {str} \n");
        //            }
        //        });
        //        endpoints.MapGet("/int", async context =>
        //        {
        //            ICollection<int> collection = context.RequestServices.GetService<ICollection<int>>();
        //            collection.Add(collection.Count() + 1);
        //            foreach (int val in collection)
        //            {
        //                await context.Response.WriteAsync($"Int: {val}\n");
        //            }
        //        });
        //    });
        //app.UseMiddleware<WeatherMiddleware>();
        //app.UseMiddleware<LocationMiddleware>();
        //app.Use(async (context, next) =>
        //{
        //    string defaultDebug = Configuration["Logging:LogLevel:Default"];
        //    string envir = Configuration["ASPNETCORE_ENVIRONMENT"];
        //    await context.Response.WriteAsync($"The config setting is: {defaultDebug}\n");
        //    await context.Response.WriteAsync($"The env setting is: {envir}\n");

        //    string wsId = Configuration["WebService:Id"];
        //    string wsKey = Configuration["WebService:Key"];
        //    await context.Response.WriteAsync($"ID: {wsId}\n");
        //    await context.Response.WriteAsync($"Key: {wsKey}\n");
        //});
        //app.Use(async (context, next) =>
        //{
        //    if (context.Request.Path == "/middleware/function")
        //    {
        //        //await TextResponeFormatter.singleton.Format(context, "Middleware Funcion: It is snowing in Chicaggo");
        //        //await TypeBroker.Formatter.Format(context, "Middleware Funcion: It is snowing in Chicaggo");
        //        await formatter.Format(context, "Middleware Funcion: It is snowing in Chicaggo");
        //    }
        //    else await next();
        //});
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
        //app.UseRouting();
        //app.UseEndpoints(endpoints =>
        //{
        //    endpoints.MapGet("{first}/{second}/{*catchall}", async context =>
        //    {
        //        await context.Response.WriteAsync($"Request was routed\n");
        //        foreach (var kvp in context.Request.RouteValues)
        //        {
        //            await context.Response.WriteAsync($"{kvp.Key} : {kvp.Value} \n");
        //        }
        //    });
        //    endpoints.MapGet("{first:int}/{second:bool}", async context =>
        //    {
        //        await context.Response.WriteAsync($"Request was routed\n");
        //        foreach (var kvp in context.Request.RouteValues)
        //        {
        //            await context.Response.WriteAsync($"{kvp.Key} : {kvp.Value} \n");
        //        }
        //    });
        //    endpoints.MapGet("capital/{country:countryName}", Capital.Endpoints);
        //    endpoints.MapGet("files/{filename}.{ext}", async context =>
        //    {
        //        await context.Response.WriteAsync($"Request was routed 2\n");
        //        foreach (var kvp in context.Request.RouteValues)
        //        {
        //            await context.Response.WriteAsync($"{kvp.Key} : {kvp.Value} \n");
        //        }
        //    });
        //    //endpoints.MapGet("capital/{country=France}", Capital.Endpoints);
        //    endpoints.MapGet("capital/{country:regex(^uk|france|monaco$)}", Capital.Endpoints);
        //    endpoints.MapGet("size/{city?}", Population.Endpoints).WithMetadata(new RouteNameMetadata("population"));

        //    endpoints.MapFallback(async context =>
        //    {
        //        await context.Response.WriteAsync("Routed to fallback endpoint");
        //    });

        //});

        //app.Use(async (context, next) =>
        //{
        //    await context.Response.WriteAsync("Temiral Middleware Reached");
        //});
        //endpoints.MapGet("/endpoint/class", WeatherEndpoint.Endpoint);
        //endpoints.MapWeather("endpoints/class");
        //endpoints.MapEndPoint<WeatherEndpoint>("/endpoint/class");
        //endpoints.MapGet("/endpoint/function", async context =>
        //{
        //    //await TextResponeFormatter.singleton.Format(context, $"Endpoint function: It is sunny in USA");
        //    //await TypeBroker.Formatter.Format(context, $"Endpoint function: It is sunny in USA");
        //    IResponseFormatter formatter = app.ApplicationServices.GetService<IResponseFormatter>();
        //    await formatter.Format(context, "Endpoint function: It is sunny in USA");
        //});
        //endpoints.MapGet("/single", async context =>
        //{
        //    IResponseFormatter formatter = context.RequestServices.GetService<IResponseFormatter>();
        //    await formatter.Format(context, "Single service");
        //});
        //endpoints.MapGet("/", async context =>
        //{
        //    IResponseFormatter formatter = context.RequestServices.GetServices<IResponseFormatter>().First(f => f.RichOutput);
        //    await formatter.Format(context, "Multiple service");
        //});
        #endregion

    }
}
