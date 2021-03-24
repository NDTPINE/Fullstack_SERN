using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Webapp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Webapp.TagHelpers;

namespace Webapp
{
    public class Startup
    {
        public Startup(IConfiguration config)
        {
            Configuration = config;

        }
        private IConfiguration Configuration { get; set; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DataContext>(opt =>
            {
                opt.UseSqlServer(Configuration["ConnectionStrings:ProductConnection"]);
                opt.EnableSensitiveDataLogging(true);
            });
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddRazorPages().AddRazorRuntimeCompilation();
            services.AddDistributedMemoryCache();
            services.AddSession(op =>
            {
                op.Cookie.IsEssential = true;
            });
            services.Configure<RazorPagesOptions>(opt =>
            {
                opt.Conventions.AddPageRoute("/Index", "/extra/page/{id:long?}");
            });
            services.AddSingleton<CitiesData>();
            services.AddTransient<ITagHelperComponent, TimeTagHelperComponent>();
            services.AddTransient<ITagHelperComponent, TableFooterTagHelperComponent>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, DataContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapDefaultControllerRoute();
                endpoints.MapRazorPages();

            });
            SeedData.SeedDatabase(context); 
        }
    }
}
#region EXAMPLE
/* //services.AddControllers().AddNewtonsoftJson().AddXmlDataContractSerializerFormatters();
services.Configure<MvcNewtonsoftJsonOptions>(opt =>
{
    opt.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
});
services.Configure<MvcOptions>(option =>
{
    option.RespectBrowserAcceptHeader = true;
    option.ReturnHttpNotAcceptable = true;
});
services.AddSwaggerGen(opt =>
{
    opt.SwaggerDoc("v1", new OpenApiInfo { Title = "WebApp", Version = "v1" });
});
//services.Configure<JsonOptions>(opt => { opt.JsonSerializerOptions.IgnoreNullValues = true; });

app.UseMiddleware<TestMiddleware>();

app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/", async context =>
    {
        await context.Response.WriteAsync("Hello World!");
    });
    //endpoints.MapWebService();
    endpoints.MapControllers();
});
app.UseSwagger();
app.UseSwaggerUI(opt =>
{
    opt.SwaggerEndpoint("/swagger/v1/swagger.json", "WebApp");
});


*/
#endregion
