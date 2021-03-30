using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Webapp.Filters
{
    public class SimpleCacheAttribute : Attribute, IResourceFilter
    {
        private Dictionary<PathString, IActionFilter> CachedResponses = new Dictionary<PathString, IActionFilter>();
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            PathString path = context.HttpContext.Request.Path;
            if (CachedResponses.ContainsKey(path))
            {
                context.Result = (IActionResult)CachedResponses[path];
                CachedResponses.Remove(path);
            }
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            CachedResponses.Add(context.HttpContext.Request.Path, (IActionFilter)context.Result);
        }
    }
}
