#pragma checksum "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\Blogs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1dafb8b3390e2f7f73ef58d0256fe51fb6477153"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blogs_Index), @"mvc.1.0.view", @"/Views/Blogs/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1dafb8b3390e2f7f73ef58d0256fe51fb6477153", @"/Views/Blogs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90cb3f5e5fccb52a0e0063a49cbc18bcf1ae0e0b", @"/Views/_ViewImports.cshtml")]
    public class Views_Blogs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MVCWEB.Models.Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\Blogs\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/LayoutProje.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 66 "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\Blogs\Index.cshtml"
  string color = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"site-section\">\r\n    <div class=\"container\">\r\n        <div class=\"row mb-5\">\r\n            <div class=\"col-12\">\r\n                <h2>View  Blogs </h2>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 75 "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\Blogs\Index.cshtml"
             foreach (var i in Model)
            {
                if (i.Categories.CategoriesName == "Tech")
                {
                    color = "post-category text-white bg-info mb-3";
                }

                if (i.Categories.CategoriesName == "Film")
                {
                    color = "post-category text-white bg-danger mb-3";
                }

                if (i.Categories.CategoriesName == "Travel")
                {
                    color = "post-category text-white bg-warning mb-3";
                }

                if (i.Categories.CategoriesName == "Sport")
                {
                    color = "post-category text-white bg-success mb-3";
                }

                if (i.Categories.CategoriesName == "Politics")
                {
                    color = "post-category text-white bg-danger mb-3";
                }


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 mb-4\">\r\n                    <div class=\"entry2\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 3183, "\"", 3214, 2);
            WriteAttributeValue("", 3190, "/Blogs/Details/", 3190, 15, true);
#nullable restore
#line 104 "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\Blogs\Index.cshtml"
WriteAttributeValue("", 3205, i.BlogID, 3205, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 3220, "\"", 3238, 1);
#nullable restore
#line 104 "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\Blogs\Index.cshtml"
WriteAttributeValue("", 3226, i.BlogImage, 3226, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height:210px\" alt=\"Image\" class=\"img-fluid rounded\"></a>\r\n                        <div class=\"excerpt\">\r\n                            <span");
            BeginWriteAttribute("class", " class=\"", 3385, "\"", 3399, 1);
#nullable restore
#line 106 "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\Blogs\Index.cshtml"
WriteAttributeValue("", 3393, color, 3393, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 106 "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\Blogs\Index.cshtml"
                                            Write(i.Categories.CategoriesName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n                            <h2><a");
            BeginWriteAttribute("href", " href=\"", 3474, "\"", 3505, 2);
            WriteAttributeValue("", 3481, "/Blogs/Details/", 3481, 15, true);
#nullable restore
#line 108 "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\Blogs\Index.cshtml"
WriteAttributeValue("", 3496, i.BlogID, 3496, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 108 "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\Blogs\Index.cshtml"
                                                              Write(i.BlogHeader);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\r\n                            <div class=\"post-meta align-items-center text-left clearfix\">\r\n                                <figure class=\"author-figure mb-0 mr-3 float-left\"><img");
            BeginWriteAttribute("src", " src=\"", 3709, "\"", 3736, 1);
#nullable restore
#line 110 "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\Blogs\Index.cshtml"
WriteAttributeValue("", 3715, i.Writer.WriterImage, 3715, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Image\" class=\"img-fluid\"></figure>\r\n                                <span class=\"d-inline-block mt-1\">By <a href=\"#\">");
#nullable restore
#line 111 "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\Blogs\Index.cshtml"
                                                                            Write(i.Writer.WriterN_S);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></span>\r\n                                <span>&nbsp;-&nbsp; ");
#nullable restore
#line 112 "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\Blogs\Index.cshtml"
                                                Write(((DateTime)i.BlogDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n\r\n                            <p>");
#nullable restore
#line 115 "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\Blogs\Index.cshtml"
                          Write(i.BlogDetail.Substring(0, i.BlogDetail.Substring(0, 200).LastIndexOf("")));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</p>\r\n                            <p><a");
            BeginWriteAttribute("href", " href=\"", 4187, "\"", 4218, 2);
            WriteAttributeValue("", 4194, "/Blogs/Details/", 4194, 15, true);
#nullable restore
#line 116 "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\Blogs\Index.cshtml"
WriteAttributeValue("", 4209, i.BlogID, 4209, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Read More</a></p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 120 "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\Blogs\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MVCWEB.Models.Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591