#pragma checksum "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\Blogs\AdminBlogList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec59a2d3d0e46c0fe2437da2c5103c5435a3c79a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blogs_AdminBlogList), @"mvc.1.0.view", @"/Views/Blogs/AdminBlogList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec59a2d3d0e46c0fe2437da2c5103c5435a3c79a", @"/Views/Blogs/AdminBlogList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90cb3f5e5fccb52a0e0063a49cbc18bcf1ae0e0b", @"/Views/_ViewImports.cshtml")]
    public class Views_Blogs_AdminBlogList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MVCWEB.Models.Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\Blogs\AdminBlogList.cshtml"
  
    ViewData["Title"] = "AdminBlogList";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>List of Blogs</h2>
<br />
<table class=""table table-bordered table-primary""> 
    <tr>
        <th>ID</th>
        <th>Title</th>
        <th>Category</th>
        <th>Date</th>
        <th>Delete</th>
        <th>Update</th>
        <th>Details</th>
        <th>Comments</th>
    </tr>
");
#nullable restore
#line 21 "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\Blogs\AdminBlogList.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\Blogs\AdminBlogList.cshtml"
           Write(item.BlogID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\Blogs\AdminBlogList.cshtml"
           Write(item.BlogHeader);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\Blogs\AdminBlogList.cshtml"
           Write(item.Categories.CategoriesName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\Blogs\AdminBlogList.cshtml"
           Write(item.BlogDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 707, "\"", 740, 2);
            WriteAttributeValue("", 714, "/Blogs/Delete/", 714, 14, true);
#nullable restore
#line 28 "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\Blogs\AdminBlogList.cshtml"
WriteAttributeValue("", 728, item.BlogID, 728, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 800, "\"", 831, 2);
            WriteAttributeValue("", 807, "/Blogs/Edit/", 807, 12, true);
#nullable restore
#line 29 "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\Blogs\AdminBlogList.cshtml"
WriteAttributeValue("", 819, item.BlogID, 819, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Edit</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 890, "\"", 924, 2);
            WriteAttributeValue("", 897, "/Blogs/Details/", 897, 15, true);
#nullable restore
#line 30 "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\Blogs\AdminBlogList.cshtml"
WriteAttributeValue("", 912, item.BlogID, 912, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Details</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 986, "\"", 1028, 2);
            WriteAttributeValue("", 993, "/Blog/GetCommentByBlog/", 993, 23, true);
#nullable restore
#line 31 "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\Blogs\AdminBlogList.cshtml"
WriteAttributeValue("", 1016, item.BlogID, 1016, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-dark\">Comments</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 33 "C:\Users\TSULUKIDZE\Desktop\MVCWEB\Views\Blogs\AdminBlogList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<a href=\"/Blogs/Create/\" class=\"btn btn-primary\">Add New Blog</a>\r\n\r\n");
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
