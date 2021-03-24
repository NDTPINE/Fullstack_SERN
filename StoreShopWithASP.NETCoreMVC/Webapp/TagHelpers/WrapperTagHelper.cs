using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Webapp.TagHelpers
{
    [HtmlTargetElement("*", Attributes ="[wrap=true]")]
    public class WrapperTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            TagBuilder elem = new TagBuilder("div");
            elem.Attributes["class"] = "bg-primary text-white text-center p-2 m-2";
            elem.InnerHtml.AppendHtml("Wrapper");

            output.PreElement.AppendHtml(elem);
            output.PostElement.AppendHtml(elem);
        }
    }
}
