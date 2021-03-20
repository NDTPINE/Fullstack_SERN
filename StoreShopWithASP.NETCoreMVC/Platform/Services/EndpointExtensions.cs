using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Platform.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Microsoft.AspNetCore.Http;

namespace Platform.Services
{
    public static class EndpointExtensions
    {
        public static void MapEndPoint<T>(this IEndpointRouteBuilder app, string path, string methodName = "Endpoint")
        {
            MethodInfo methodInfo = typeof(T).GetMethod(methodName);
            if (methodInfo == null || methodInfo.ReturnType != typeof(Task))
            {
                throw new System.Exception("Method cannot be used");
            }
            T endpointInstance = ActivatorUtilities.CreateInstance<T>(app.ServiceProvider);
            //app.MapGet(path, (RequestDelegate)methodInfo.CreateDelegate(typeof(RequestDelegate), endpointInstance));
            ParameterInfo[] methodParams = methodInfo.GetParameters();
            app.MapGet(path, context => (Task)methodInfo.Invoke(endpointInstance, methodParams.Select(p => p.ParameterType == typeof(HttpContext)
            ? context : context.RequestServices.GetService(p.ParameterType)).ToArray()));
        }
    }
}
