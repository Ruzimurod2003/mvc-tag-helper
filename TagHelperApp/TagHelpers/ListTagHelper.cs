using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHelperApp.TagHelpers
{
    [HtmlTargetElement("list")]
    public class ListTagHelper : TagHelper
    {
        public List<string> Items { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "ul";
            string itemStrings = "";
            foreach (var item in Items)
            {
                itemStrings += "<li>" + item.ToString() + "</li>";
            }
            output.Content.SetHtmlContent(itemStrings);
        }
    }
}
