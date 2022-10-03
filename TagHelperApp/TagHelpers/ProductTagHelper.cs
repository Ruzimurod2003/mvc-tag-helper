using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using TagHelperApp.Models;

namespace TagHelperApp.TagHelpers
{
    public class ProductTagHelper : TagHelper
    {
        public StyleInfo Style { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "button";
            string style = $"width:{Style.Width};height:{Style.Height};color:{Style.Color};";
            output.Attributes.Add("style", style);
            output.Attributes.Add("class", "btn btn-info");
            output.Content.AppendHtml("<p>Привет все</p>");
        }
    }
}
