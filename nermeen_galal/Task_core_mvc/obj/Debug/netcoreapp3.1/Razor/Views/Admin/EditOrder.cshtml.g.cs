#pragma checksum "D:\nermeen_galal\Task_core_mvc\Views\Admin\EditOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db517f6bfe62170b57a8e6a090c482482d8a33d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_EditOrder), @"mvc.1.0.view", @"/Views/Admin/EditOrder.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db517f6bfe62170b57a8e6a090c482482d8a33d9", @"/Views/Admin/EditOrder.cshtml")]
    public class Views_Admin_EditOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Task_core_mvc.Models.Order>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\nermeen_galal\Task_core_mvc\Views\Admin\EditOrder.cshtml"
  
    ViewData["Title"] = "EditOrder";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>EditOrder</h1>

<h4>Order</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""EditOrder"" method=""post"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""ID"" />
            <div class=""form-group"">
                <label asp-for=""ProductID"" class=""control-label"">Product Name</label>

                <select name=""ProductID"" class=""form-control""");
            BeginWriteAttribute("asp-items", " asp-items=\"", 595, "\"", 653, 1);
#nullable restore
#line 20 "D:\nermeen_galal\Task_core_mvc\Views\Admin\EditOrder.cshtml"
WriteAttributeValue("", 607, new SelectList(ViewBag.Product,"ID","Name"), 607, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" ></select>

                <span asp-validation-for=""ProductID"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Date"" class=""control-label""></label>
                <input name=""Date"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 934, "\"", 953, 1);
#nullable restore
#line 26 "D:\nermeen_galal\Task_core_mvc\Views\Admin\EditOrder.cshtml"
WriteAttributeValue("", 942, Model.Date, 942, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"/>
                <span asp-validation-for=""Date"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Count"" class=""control-label""></label>
                <input name=""Count"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 1220, "\"", 1240, 1);
#nullable restore
#line 31 "D:\nermeen_galal\Task_core_mvc\Views\Admin\EditOrder.cshtml"
WriteAttributeValue("", 1228, Model.Count, 1228, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"/>
                <span asp-validation-for=""Count"" class=""text-danger""></span>
            </div>
           
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 47 "D:\nermeen_galal\Task_core_mvc\Views\Admin\EditOrder.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Task_core_mvc.Models.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591