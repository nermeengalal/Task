#pragma checksum "D:\asd\nermeen_galal\Task_core_mvc\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "969e82d4ccad3d4361ee13937a065da8d9f3dac3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"969e82d4ccad3d4361ee13937a065da8d9f3dac3", @"/Views/Admin/Index.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 3 "D:\asd\nermeen_galal\Task_core_mvc\Views\Admin\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div>
    <div margin:0 auto"" class=""tablecontainer table-responsive"">
        <a class=""popup btn btn-primary"" href=""/Admin/add"" style=""margin-bottom:20px; margin-top:20px;"">add</a>

        <table id=""myDatatable"" class=""table table-striped table-bordered"" style=""width:100%"">
            <thead>
                <tr>
                    <th>Name</th>
                    <th>Quantity</th>
                    <th>Edit</th>
                    <th>Delete</th>
                </tr>
            </thead>
        </table>
    </div>

</div>



");
            DefineSection("Scripts", async() => {
                WriteLiteral(@" 
<script>
    $(document).ready(function () {
        var oTable = $('#myDatatable').DataTable({
            ""processing"": true,
            ""serverSide"": true,
            ""filter"": true,
            ""ajax"": {
                ""url"": '/Admin/GetallProduct',
                ""type"": ""POST"",
                ""datatype"": ""json""
            },
            ""columnDefs"": [{
                ""targets"": [0],
                ""visible"": false,
                ""searchable"": false
            }],
            ""columns"": [
                { ""data"": 'Name', ""width"": ""20%"" },
                { ""data"": 'Quantity',  ""width"": ""20%"" },
                {
                    ""data"": ""ID"", ""width"": ""20%"", ""render"": function (data) {
                        return '<a class=""popup btn btn-default"" href=""/Bank/Save/' + data + '"">Edit</a>';
                    }
                },
                {
                    ""data"": ""ID"", ""width"": ""20%"", ""render"": function (data) {
                        return '<a ");
                WriteLiteral(@"class=""popup btn btn-danger"" href=""/Bank/Delete/' + data + '"">Delete</a>';
                    }
                }
            ]
        })

        $('.tablecontainer').on('click', 'a.popup', function (e) {
            e.preventDefault();
            OpenPopup($(this).attr('href'));
        })
        function OpenPopup(pageUrl) {
            var $pageContent = $('<div/>');
            $pageContent.load(pageUrl, function () {
                $('#popupForm', $pageContent).removeData('validator');
                $('#popupForm', $pageContent).removeData('unobtrusiveValidation');
                $.validator.unobtrusive.parse('form');

            });

            $dialog = $('<div class=""popupWindow "" style=""overflow:auto""></div>')
                .html($pageContent)
                .dialog({
                    draggable: false,
                    autoOpen: false,
                    resizable: false,
                    model: true,
                    title: 'admin',
             ");
                WriteLiteral(@"       height: 300,
                    width: ""50%"",
                    close: function () {
                        $dialog.dialog('destroy').remove();
                    }
                })

            $('.popupWindow').on('submit', '#popupForm', function (e) {
                var url = $('#popupForm')[0].action;
                $.ajax({
                    type: ""POST"",
                    url: url,
                    data: $('#popupForm').serialize(),
                    success: function (data) {
                        if (data.status) {
                            toastr.success(data.message, 'Success Alert', { timeOut: 3000 });
                            $dialog.dialog('close');
                            oTable.ajax.reload();
                        }
                    }
                })

                e.preventDefault();
            })
            $dialog.dialog('open');
        }
    })
</script>
");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
