#pragma checksum "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9e28ad8b03b8cce5eae53ae089197e3b6aa7336"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\_ViewImports.cshtml"
using MVCWEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\_ViewImports.cshtml"
using MVCWEB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9e28ad8b03b8cce5eae53ae089197e3b6aa7336", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90cb3f5e5fccb52a0e0063a49cbc18bcf1ae0e0b", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/LayoutProje.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"site-section bg-light\">\r\n    <div class=\"container\">\r\n        <div class=\"row align-items-stretch retro-layout-2\">\r\n            <div class=\"col-md-4\">\r\n                <a href=\"single.html\" class=\"h-entry mb-30 v-height gradient\"");
            BeginWriteAttribute("style", " style=\"", 337, "\"", 390, 4);
            WriteAttributeValue("", 345, "background-image:", 345, 17, true);
            WriteAttributeValue(" ", 362, "url(\'", 363, 6, true);
#nullable restore
#line 11 "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\Blog\Index.cshtml"
WriteAttributeValue("", 368, ViewBag.blogImage1, 368, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 387, "\');", 387, 3, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                    <div class=\"text\">\r\n                        <h2>");
#nullable restore
#line 14 "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\Blog\Index.cshtml"
                       Write(ViewBag.blogTitle1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <span class=\"date\">");
#nullable restore
#line 15 "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\Blog\Index.cshtml"
                                       Write(((DateTime)ViewBag.blogDate1).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                </a>\r\n                <a href=\"single.html\" class=\"h-entry v-height gradient\"");
            BeginWriteAttribute("style", " style=\"", 719, "\"", 772, 4);
            WriteAttributeValue("", 727, "background-image:", 727, 17, true);
            WriteAttributeValue(" ", 744, "url(\'", 745, 6, true);
#nullable restore
#line 18 "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\Blog\Index.cshtml"
WriteAttributeValue("", 750, ViewBag.blogImage2, 750, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 769, "\');", 769, 3, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                    <div class=\"text\">\r\n                        <h2>");
#nullable restore
#line 21 "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\Blog\Index.cshtml"
                       Write(ViewBag.blogTitle2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <span class=\"date\">");
#nullable restore
#line 22 "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\Blog\Index.cshtml"
                                       Write(((DateTime)ViewBag.blogDate2).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                </a>\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n                <a href=\"single.html\" class=\"h-entry img-5 h-100 gradient\"");
            BeginWriteAttribute("style", " style=\"", 1160, "\"", 1213, 4);
            WriteAttributeValue("", 1168, "background-image:", 1168, 17, true);
            WriteAttributeValue(" ", 1185, "url(\'", 1186, 6, true);
#nullable restore
#line 27 "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1191, ViewBag.blogImage5, 1191, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1210, "\');", 1210, 3, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                    <div class=\"text\">\r\n                        <div class=\"post-categories mb-3\">\r\n                            <span class=\"post-category bg-danger\">Politics</span>\r\n                        </div>\r\n                        <h2>");
#nullable restore
#line 33 "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\Blog\Index.cshtml"
                       Write(ViewBag.blogTitle5);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <span class=\"date\">");
#nullable restore
#line 34 "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\Blog\Index.cshtml"
                                       Write(((DateTime)ViewBag.blogDate5).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                </a>\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n                <a href=\"single.html\" class=\"h-entry mb-30 v-height gradient\"");
            BeginWriteAttribute("style", " style=\"", 1779, "\"", 1832, 4);
            WriteAttributeValue("", 1787, "background-image:", 1787, 17, true);
            WriteAttributeValue(" ", 1804, "url(\'", 1805, 6, true);
#nullable restore
#line 39 "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1810, ViewBag.blogImage3, 1810, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1829, "\');", 1829, 3, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                    <div class=\"text\">\r\n                        <h2>");
#nullable restore
#line 42 "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\Blog\Index.cshtml"
                       Write(ViewBag.blogTitle3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <span class=\"date\">>");
#nullable restore
#line 43 "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\Blog\Index.cshtml"
                                        Write(((DateTime)ViewBag.blogDate3).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                </a>\r\n                <a href=\"single.html\" class=\"h-entry v-height gradient\"");
            BeginWriteAttribute("style", " style=\"", 2162, "\"", 2215, 4);
            WriteAttributeValue("", 2170, "background-image:", 2170, 17, true);
            WriteAttributeValue(" ", 2187, "url(\'", 2188, 6, true);
#nullable restore
#line 46 "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2193, ViewBag.blogImage4, 2193, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2212, "\');", 2212, 3, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                    <div class=\"text\">\r\n                        <h2>");
#nullable restore
#line 49 "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\Blog\Index.cshtml"
                       Write(ViewBag.blogTitle4);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <span class=\"date\">");
#nullable restore
#line 50 "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\Blog\Index.cshtml"
                                       Write(((DateTime)ViewBag.blogDate4).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                </a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
