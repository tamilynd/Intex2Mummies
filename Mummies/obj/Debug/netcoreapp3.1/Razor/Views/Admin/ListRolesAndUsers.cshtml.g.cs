#pragma checksum "/Users/masonmuir/Documents/GitHub/Intex2Mummies/Mummies/Views/Admin/ListRolesAndUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ee1a2af2fbe7ecebdb3adf0ad0887a871a8a716"
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
#line 1 "/Users/masonmuir/Documents/GitHub/Intex2Mummies/Mummies/Views/_ViewImports.cshtml"
using Mummies;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/masonmuir/Documents/GitHub/Intex2Mummies/Mummies/Views/_ViewImports.cshtml"
using Mummies.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/masonmuir/Documents/GitHub/Intex2Mummies/Mummies/Views/_ViewImports.cshtml"
using Mummies.Models.MummyDb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/masonmuir/Documents/GitHub/Intex2Mummies/Mummies/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/masonmuir/Documents/GitHub/Intex2Mummies/Mummies/Views/_ViewImports.cshtml"
using Mummies.Models.ViewModels.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/masonmuir/Documents/GitHub/Intex2Mummies/Mummies/Views/_ViewImports.cshtml"
using Mummies.Models.ViewModels.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/masonmuir/Documents/GitHub/Intex2Mummies/Mummies/Views/_ViewImports.cshtml"
using Mummies.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ee1a2af2fbe7ecebdb3adf0ad0887a871a8a716", @"/Views/Admin/ListRolesAndUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e9103aeaaff8b63fa23f2538724ebf50faa66d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ListRolesAndUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleUserListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: #002e5d; color:white;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditUsersInRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/masonmuir/Documents/GitHub/Intex2Mummies/Mummies/Views/Admin/ListRolesAndUsers.cshtml"
   
    ViewBag.Title = "Site Roles";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n<h1>Manage User Roles &emsp;");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ee1a2af2fbe7ecebdb3adf0ad0887a871a8a7166604", async() => {
                WriteLiteral("Create New User");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h1>\n<br />\n<div class=\"row\">\n    <div class=\"col-2\"></div>\n    <div class=\"col-5 align-content-center text-center\">\n        <div class=\"card mb-3 w-75 align-items-center\">\n            <div class=\"card-header w-100\">\n                <p><small>Role ID: ");
#nullable restore
#line 14 "/Users/masonmuir/Documents/GitHub/Intex2Mummies/Mummies/Views/Admin/ListRolesAndUsers.cshtml"
                              Write(ViewBag.Researcher.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\n            </div>\n            <div class=\"card-title\">\n                <br />\n                <h3>Researchers</h3>\n            </div>\n            <div class=\"card-body\">\n                <h4>Users</h4>\n");
#nullable restore
#line 22 "/Users/masonmuir/Documents/GitHub/Intex2Mummies/Mummies/Views/Admin/ListRolesAndUsers.cshtml"
                 foreach (var user in Model.ResearchUsers)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <hr />\n                    <h6> ");
#nullable restore
#line 25 "/Users/masonmuir/Documents/GitHub/Intex2Mummies/Mummies/Views/Admin/ListRolesAndUsers.cshtml"
                    Write(user.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h6>\n                    <p><small>User ID: ");
#nullable restore
#line 26 "/Users/masonmuir/Documents/GitHub/Intex2Mummies/Mummies/Views/Admin/ListRolesAndUsers.cshtml"
                                  Write(user.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\n");
#nullable restore
#line 27 "/Users/masonmuir/Documents/GitHub/Intex2Mummies/Mummies/Views/Admin/ListRolesAndUsers.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n            <div class=\"card-footer w-100\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ee1a2af2fbe7ecebdb3adf0ad0887a871a8a71610037", async() => {
                WriteLiteral("Edit Users");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "/Users/masonmuir/Documents/GitHub/Intex2Mummies/Mummies/Views/Admin/ListRolesAndUsers.cshtml"
                                                                         WriteLiteral(ViewBag.researcher.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n    <div class=\"col-5 align-content-center text-center\">\n        <div class=\"card mb-3 w-75 align-items-center\">\n            <div class=\"card-header w-100\">\n                <p><small>Role ID: ");
#nullable restore
#line 37 "/Users/masonmuir/Documents/GitHub/Intex2Mummies/Mummies/Views/Admin/ListRolesAndUsers.cshtml"
                              Write(ViewBag.Researcher.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\n            </div>\n            <div class=\"card-title\">\n                <br />\n                <h3>Admin</h3>\n            </div>\n            <div class=\"card-body\">\n                <h4>Users</h4>\n");
#nullable restore
#line 45 "/Users/masonmuir/Documents/GitHub/Intex2Mummies/Mummies/Views/Admin/ListRolesAndUsers.cshtml"
                 foreach (var user in Model.AdminUsers)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <hr />\n                    <h6> ");
#nullable restore
#line 48 "/Users/masonmuir/Documents/GitHub/Intex2Mummies/Mummies/Views/Admin/ListRolesAndUsers.cshtml"
                    Write(user.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h6>\n                    <p><small>User ID: ");
#nullable restore
#line 49 "/Users/masonmuir/Documents/GitHub/Intex2Mummies/Mummies/Views/Admin/ListRolesAndUsers.cshtml"
                                  Write(user.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\n");
#nullable restore
#line 50 "/Users/masonmuir/Documents/GitHub/Intex2Mummies/Mummies/Views/Admin/ListRolesAndUsers.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n            <div class=\"card-footer w-100\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ee1a2af2fbe7ecebdb3adf0ad0887a871a8a71614486", async() => {
                WriteLiteral("Edit Users");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "/Users/masonmuir/Documents/GitHub/Intex2Mummies/Mummies/Views/Admin/ListRolesAndUsers.cshtml"
                                                                         WriteLiteral(ViewBag.admin.Id);

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
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n    \n</div>");
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
