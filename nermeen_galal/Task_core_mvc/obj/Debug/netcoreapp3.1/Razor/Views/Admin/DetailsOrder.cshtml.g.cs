#pragma checksum "D:\asd\nermeen_galal\Task_core_mvc\Views\Admin\DetailsOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2de451f4e8545f306a3c84f1164f321ae063f22d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_DetailsOrder), @"mvc.1.0.view", @"/Views/Admin/DetailsOrder.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2de451f4e8545f306a3c84f1164f321ae063f22d", @"/Views/Admin/DetailsOrder.cshtml")]
    public class Views_Admin_DetailsOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Task_core_mvc.ViewModel.OrderVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\asd\nermeen_galal\Task_core_mvc\Views\Admin\DetailsOrder.cshtml"
  
    ViewData["Title"] = "DetailsOrder";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>DetailsOrder</h1>\r\n\r\n<div>\r\n    <h4>Order</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "D:\asd\nermeen_galal\Task_core_mvc\Views\Admin\DetailsOrder.cshtml"
       Write(Html.DisplayName("Product"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "D:\asd\nermeen_galal\Task_core_mvc\Views\Admin\DetailsOrder.cshtml"
       Write(Html.DisplayFor(model => model.prodectname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "D:\asd\nermeen_galal\Task_core_mvc\Views\Admin\DetailsOrder.cshtml"
       Write(Html.DisplayName("Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "D:\asd\nermeen_galal\Task_core_mvc\Views\Admin\DetailsOrder.cshtml"
       Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "D:\asd\nermeen_galal\Task_core_mvc\Views\Admin\DetailsOrder.cshtml"
       Write(Html.DisplayName("Count"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "D:\asd\nermeen_galal\Task_core_mvc\Views\Admin\DetailsOrder.cshtml"
       Write(Html.DisplayFor(model => model.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n      \r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 856, "\"", 880, 1);
#nullable restore
#line 36 "D:\asd\nermeen_galal\Task_core_mvc\Views\Admin\DetailsOrder.cshtml"
WriteAttributeValue("", 871, Model.ID, 871, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Task_core_mvc.ViewModel.OrderVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
