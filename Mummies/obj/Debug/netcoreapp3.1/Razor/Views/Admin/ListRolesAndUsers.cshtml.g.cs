#pragma checksum "C:\Users\Tam\source\repos\Mummies\Mummies\Views\Admin\ListRolesAndUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba2c5704300876175b7b241b66fb4029303d2ad6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ListRolesAndUsers), @"mvc.1.0.view", @"/Views/Admin/ListRolesAndUsers.cshtml")]
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
#line 1 "C:\Users\Tam\source\repos\Mummies\Mummies\Views\_ViewImports.cshtml"
using Mummies;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tam\source\repos\Mummies\Mummies\Views\_ViewImports.cshtml"
using Mummies.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Tam\source\repos\Mummies\Mummies\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Tam\source\repos\Mummies\Mummies\Views\_ViewImports.cshtml"
using Mummies.Models.ViewModels.Admin;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba2c5704300876175b7b241b66fb4029303d2ad6", @"/Views/Admin/ListRolesAndUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd5b1bd31096afb74c0452d549738fafcc655354", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ListRolesAndUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleUserListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditUsersInRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: #002e5d; color:white;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Tam\source\repos\Mummies\Mummies\Views\Admin\ListRolesAndUsers.cshtml"
   
    ViewBag.Title = "Site Roles";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>All Roles</h1>
<div class=""row"">
    <div class=""col-2""></div>
    <div class=""col-5 align-content-center text-center"">
        <div class=""card mb-3 w-75 align-items-center"">
            <div class=""card-header w-100"">
                <p><small>Role ID: ");
#nullable restore
#line 13 "C:\Users\Tam\source\repos\Mummies\Mummies\Views\Admin\ListRolesAndUsers.cshtml"
                              Write(ViewBag.Researcher.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n            </div>\r\n            <div class=\"card-title\">\r\n                <br />\r\n                <h3>Researchers</h3>\r\n            </div>\r\n            <div class=\"card-body\">\r\n                <h4>Users</h4>\r\n");
#nullable restore
#line 21 "C:\Users\Tam\source\repos\Mummies\Mummies\Views\Admin\ListRolesAndUsers.cshtml"
                 foreach (var user in Model.ResearchUsers)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <hr />\r\n                    <h6> ");
#nullable restore
#line 24 "C:\Users\Tam\source\repos\Mummies\Mummies\Views\Admin\ListRolesAndUsers.cshtml"
                    Write(user.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h6>\r\n                    <p><small>User ID: ");
#nullable restore
#line 25 "C:\Users\Tam\source\repos\Mummies\Mummies\Views\Admin\ListRolesAndUsers.cshtml"
                                  Write(user.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n");
#nullable restore
#line 26 "C:\Users\Tam\source\repos\Mummies\Mummies\Views\Admin\ListRolesAndUsers.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"card-footer w-100\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba2c5704300876175b7b241b66fb4029303d2ad67327", async() => {
                WriteLiteral("Edit Users");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\Tam\source\repos\Mummies\Mummies\Views\Admin\ListRolesAndUsers.cshtml"
                                                                         WriteLiteral(ViewBag.researcher.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-5 align-content-center text-center\">\r\n        <div class=\"card mb-3 w-75 align-items-center\">\r\n            <div class=\"card-header w-100\">\r\n                <p><small>Role ID: ");
#nullable restore
#line 36 "C:\Users\Tam\source\repos\Mummies\Mummies\Views\Admin\ListRolesAndUsers.cshtml"
                              Write(ViewBag.Researcher.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n            </div>\r\n            <div class=\"card-title\">\r\n                <br />\r\n                <h3>Admin</h3>\r\n            </div>\r\n            <div class=\"card-body\">\r\n                <h4>Users</h4>\r\n");
#nullable restore
#line 44 "C:\Users\Tam\source\repos\Mummies\Mummies\Views\Admin\ListRolesAndUsers.cshtml"
                 foreach (var user in Model.AdminUsers)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <hr />\r\n                    <h6> ");
#nullable restore
#line 47 "C:\Users\Tam\source\repos\Mummies\Mummies\Views\Admin\ListRolesAndUsers.cshtml"
                    Write(user.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h6>\r\n                    <p><small>User ID: ");
#nullable restore
#line 48 "C:\Users\Tam\source\repos\Mummies\Mummies\Views\Admin\ListRolesAndUsers.cshtml"
                                  Write(user.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n");
#nullable restore
#line 49 "C:\Users\Tam\source\repos\Mummies\Mummies\Views\Admin\ListRolesAndUsers.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"card-footer w-100\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba2c5704300876175b7b241b66fb4029303d2ad611807", async() => {
                WriteLiteral("Edit Users");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "C:\Users\Tam\source\repos\Mummies\Mummies\Views\Admin\ListRolesAndUsers.cshtml"
                                                                         WriteLiteral(ViewBag.admin.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleUserListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
