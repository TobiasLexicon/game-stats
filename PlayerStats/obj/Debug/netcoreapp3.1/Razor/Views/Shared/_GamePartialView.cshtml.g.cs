#pragma checksum "/Users/tobiasengberg/Projects/PlayerStats/PlayerStats/Views/Shared/_GamePartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "757488e915dc25902c50fed8ab8908f14c4c95d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__GamePartialView), @"mvc.1.0.view", @"/Views/Shared/_GamePartialView.cshtml")]
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
#line 1 "/Users/tobiasengberg/Projects/PlayerStats/PlayerStats/Views/_ViewImports.cshtml"
using PlayerStats;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/tobiasengberg/Projects/PlayerStats/PlayerStats/Views/_ViewImports.cshtml"
using PlayerStats.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/tobiasengberg/Projects/PlayerStats/PlayerStats/Views/_ViewImports.cshtml"
using PlayerStats.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"757488e915dc25902c50fed8ab8908f14c4c95d2", @"/Views/Shared/_GamePartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72376ffd6befda1a6598e2c1c3d504c7933b85aa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__GamePartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GameViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<tr>\r\n    <td>\r\n        ");
#nullable restore
#line 5 "/Users/tobiasengberg/Projects/PlayerStats/PlayerStats/Views/Shared/_GamePartialView.cshtml"
   Write(Html.DisplayFor(modelItem => Model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 8 "/Users/tobiasengberg/Projects/PlayerStats/PlayerStats/Views/Shared/_GamePartialView.cshtml"
   Write(Html.DisplayFor(modelItem => Model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 11 "/Users/tobiasengberg/Projects/PlayerStats/PlayerStats/Views/Shared/_GamePartialView.cshtml"
   Write(Html.DisplayFor(modelItem => Model.HomeTeamName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 260, "\"", 342, 6);
            WriteAttributeValue("", 270, "getCityName(\'", 270, 13, true);
#nullable restore
#line 12 "/Users/tobiasengberg/Projects/PlayerStats/PlayerStats/Views/Shared/_GamePartialView.cshtml"
WriteAttributeValue("", 283, Url.Action("GetTeamCity", "Game"), 283, 34, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 317, "\',", 317, 2, true);
            WriteAttributeValue(" ", 319, "\'", 320, 2, true);
#nullable restore
#line 12 "/Users/tobiasengberg/Projects/PlayerStats/PlayerStats/Views/Shared/_GamePartialView.cshtml"
WriteAttributeValue("", 321, Model.HomeTeamName, 321, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 340, "\')", 340, 2, true);
            EndWriteAttribute();
            WriteLiteral("><sup>*</sup></a>\r\n\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 16 "/Users/tobiasengberg/Projects/PlayerStats/PlayerStats/Views/Shared/_GamePartialView.cshtml"
   Write(Html.DisplayFor(modelItem => Model.AwayTeamName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 463, "\"", 545, 6);
            WriteAttributeValue("", 473, "getCityName(\'", 473, 13, true);
#nullable restore
#line 17 "/Users/tobiasengberg/Projects/PlayerStats/PlayerStats/Views/Shared/_GamePartialView.cshtml"
WriteAttributeValue("", 486, Url.Action("GetTeamCity", "Game"), 486, 34, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 520, "\',", 520, 2, true);
            WriteAttributeValue(" ", 522, "\'", 523, 2, true);
#nullable restore
#line 17 "/Users/tobiasengberg/Projects/PlayerStats/PlayerStats/Views/Shared/_GamePartialView.cshtml"
WriteAttributeValue("", 524, Model.AwayTeamName, 524, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 543, "\')", 543, 2, true);
            EndWriteAttribute();
            WriteLiteral("><sup>*</sup></a>\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 20 "/Users/tobiasengberg/Projects/PlayerStats/PlayerStats/Views/Shared/_GamePartialView.cshtml"
   Write(Html.DisplayFor(modelItem => Model.Result));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n</tr>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GameViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591