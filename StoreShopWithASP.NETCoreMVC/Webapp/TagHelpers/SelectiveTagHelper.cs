using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Webapp.TagHelpers
{
    [HtmlTargetElement ("div", Attributes="show-when-gt, for")]
    public class SelectiveTagHelper : TagHelper
    {
        public decimal ShowWhenGt { get; set; }
        public ModelExpression For { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
         if(For.Model.GetType() == typeof(decimal) && (decimal)For.Model <= ShowWhenGt)
            {
                output.SuppressOutput();
            }   
        }
    }
}
