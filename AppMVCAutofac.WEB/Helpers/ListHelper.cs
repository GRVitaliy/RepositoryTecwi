using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TamgaMVCAutofac.WEB.Helpers
{
    public static class ListHelper
    {
        public static MvcHtmlString MyPhoneNumberFor(this HtmlHelper html, string item)
        {
            string Number = item;
            return new MvcHtmlString(Number);
        }

    }
}