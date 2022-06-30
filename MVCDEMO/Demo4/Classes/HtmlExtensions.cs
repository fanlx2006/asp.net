using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo4.Classes
{
    public static class HtmlExtensions
    {
        public static MvcHtmlString Submit(this HtmlHelper helper,string value)
        {
            var builder = new TagBuilder("input");
            builder.MergeAttribute("type", "submit");
            builder.MergeAttribute("value", value);
            return MvcHtmlString.Create(builder.ToString(TagRenderMode.SelfClosing));
        }
    }
}