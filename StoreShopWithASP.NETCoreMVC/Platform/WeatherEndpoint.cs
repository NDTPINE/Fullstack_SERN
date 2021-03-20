using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Platform.Services;

namespace Platform
{
    public class WeatherEndpoint
    {
        //private IResponseFormatter formatter;
        //public WeatherEndpoint(IResponseFormatter respFormatter)
        //{
            //formatter = respFormatter;
        //}
        public async Task Endpoint(HttpContext context , IResponseFormatter formatter)
        {
            await formatter.Format(context, "Endpoint Class: It is cloudy in Milan");
        }
    }
}
