using Microsoft.AspNetCore.Razor.TagHelpers;
using TagHelperApp.Models;

namespace TagHelperApp.TagHelpers
{
    [HtmlTargetElement("user-info")]
    public class UserInfoTagHelper : TagHelper
    {
        public User User { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string userInfo = "";
            output.TagName = "div";
            if (User != null)
            {
                userInfo = $"<p>" +
                            $"Name: <b>{User.Name}</b>" + "<br>" +
                            $"Email: <b>{User.Email}</b>" + "<br>" +
                            $"Password: <b>{User.Password}</b>" +
                           $"</p>";

            }
            output.Content.SetHtmlContent(userInfo);
        }
    }
}
