using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHelperApp.TagHelpers
{
    public class TestTagHelper : TagHelper
    {
        public bool SecondsIncluded { get; set; }
        public string? Color { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var now = DateTime.Now;
            var time = String.Empty;
            if (SecondsIncluded)    // если true добавляем секунды
                time = now.ToString("HH:mm:ss");
            else
                time = now.ToString("HH:mm");

            output.TagName = "div";
            output.TagMode = TagMode.StartTagAndEndTag;
            // устанавливаем цвет
            output.Attributes.SetAttribute("style", $"color:{Color};");

            output.Content.SetContent(time);
        }
    }
}
