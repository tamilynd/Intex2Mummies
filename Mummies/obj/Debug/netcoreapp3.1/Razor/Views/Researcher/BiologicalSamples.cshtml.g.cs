#pragma checksum "/Users/masonmuir/Documents/GitHub/Intex2Mummies/Mummies/Views/Researcher/BiologicalSamples.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af5c812310b903d99f5eea5953b856185c431f37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Researcher_BiologicalSamples), @"mvc.1.0.view", @"/Views/Researcher/BiologicalSamples.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af5c812310b903d99f5eea5953b856185c431f37", @"/Views/Researcher/BiologicalSamples.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e9103aeaaff8b63fa23f2538724ebf50faa66d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Researcher_BiologicalSamples : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"


<!--For Biological Samples Table-->
<!--
<form>
    <div>
        <div>
            <h2>
                Biological Samples
            </h2>
        </div>

        <div>
            <label asp-for="""">Rack: </label>
            <input class=""form-control"" asp-for="""" />
        </div>

        <div>
            <label asp-for="""">Bag: </label>
            <input class=""form-control"" asp-for="""" />
        </div>

        <div>
            <label asp-for="""">Date: </label>
            <input class=""form-control"" asp-for="""" />
        </div>

        <div>
            <label asp-for="""">Previously Sampled: </label>
            <select class=""form-control"" id=""PreviouslySampled"" name=""PreviouslySampled"" asp-for="""">
                <option value=""Y"">Yes</option>
                <option value=""N"">No</option>
            </select>
        </div>

        <div>
            <label asp-for="""">Notes: </label>
            <input class=""form-control"" asp-for="""" />
        </div>

        <div>
            <label asp-for=""");
            WriteLiteral("\">Initials: </label>\n            <input class=\"form-control\" asp-for=\"\" />\n        </div>\n\n    </div>\n</form>\n\n-->\n");
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
