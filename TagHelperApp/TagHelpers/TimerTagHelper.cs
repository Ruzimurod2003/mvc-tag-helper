using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHelperApp.TagHelpers
{
    public class TimerTagHelper:TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";            // заменяет тег <timer> тегом <div>
            // устанавливаем содержимое элемента
            output.Content.SetContent($"Текущее время: {DateTime.Now.ToString("HH:mm:ss")}");

            output.TagMode = TagMode.StartTagAndEndTag;
            // элемент перед тегом
            output.PreElement.SetHtmlContent("<h4>Дата и время</h4>");
            // элемент после тега
            output.PostElement.SetHtmlContent($"<div>Дата: {DateTime.Now.ToString("dd/MM/yyyy")}</div>");

            output.Attributes.SetAttribute("style", "color:red;");
            output.Attributes.SetAttribute("class", "timer");

            output.Attributes.Add(new TagHelperAttribute("name","time"));
        }
    }
}
