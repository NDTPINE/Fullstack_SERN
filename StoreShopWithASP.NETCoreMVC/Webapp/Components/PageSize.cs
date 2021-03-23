using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace Webapp.Components
{
    public class PageSize : ViewComponent 
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = await client.GetAsync("http://apress.com");
            return View(responseMessage.Content.Headers.ContentLength);
        }
    }
}
