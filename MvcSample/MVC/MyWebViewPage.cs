using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcSample.MVC
{
    public abstract class MyWebViewPage<TModel>: WebViewPage<TModel>
    {
        public MyHelper Helper { get; set; }

        public MyWebViewPage()
        {
            
        }
      
    }

    public class MyHelper
    {
        public MvcHtmlString HelloWorld()
        {
            return  new MvcHtmlString("Hello World!");
        }
    }
}