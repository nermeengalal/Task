#pragma checksum "D:\nermeen_galal\Task_core_mvc\Views\AcountAdmin\AddRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "026cd919f99d1ee66257b28f32334fca220ee514"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AcountAdmin_AddRole), @"mvc.1.0.view", @"/Views/AcountAdmin/AddRole.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"026cd919f99d1ee66257b28f32334fca220ee514", @"/Views/AcountAdmin/AddRole.cshtml")]
    public class Views_AcountAdmin_AddRole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\nermeen_galal\Task_core_mvc\Views\AcountAdmin\AddRole.cshtml"
  
    ViewBag.Title = "Add New Role";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<form asp-action=""AddRole"" method=""post"" >
    <div asp-validation-summary=""All"" class=""text-danger"">
    </div>
    <div class=""form-group row"">
        <label asp-for=""RoleName"" class=""col-sm-2 col-form-label"">Role Name</label>
        <div class=""col-sm-10"">
            <input name=""RoleName"" class=""form-control"" placeholder=""Name"">
            <span asp-validation-for=""RoleName"" class=""text-danger""></span>
        </div>
    </div>

    <div class=""form-group row"">
        <div class=""col-sm-10"">
            <button type=""submit"" class=""btn btn-primary"" style=""width:auto"">
                Add Role
            </button>
        </div>
    </div>
</form>
");
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
