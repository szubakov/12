#pragma checksum "C:\Praktika\BFStabilityEvaluation\BFStabilityEvaluation\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cac8e91d7dbad244c8b0ab5f2c2c4c793365ad6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Praktika\BFStabilityEvaluation\BFStabilityEvaluation\Views\_ViewImports.cshtml"
using BFStabilityEvaluation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Praktika\BFStabilityEvaluation\BFStabilityEvaluation\Views\_ViewImports.cshtml"
using BFStabilityEvaluation.Extension;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Praktika\BFStabilityEvaluation\BFStabilityEvaluation\Views\_ViewImports.cshtml"
using BFStabilityEvaluation.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Praktika\BFStabilityEvaluation\BFStabilityEvaluation\Views\_ViewImports.cshtml"
using BFStabilityEvaluation.Models.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cac8e91d7dbad244c8b0ab5f2c2c4c793365ad6e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40a510c2e8e6577c4100991e016f7411053b9ab4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Praktika\BFStabilityEvaluation\BFStabilityEvaluation\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Стабильность работы доменной печи";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-4\">\r\n            <ul class=\"list-group\">\r\n");
#nullable restore
#line 11 "C:\Praktika\BFStabilityEvaluation\BFStabilityEvaluation\Views\Home\Index.cshtml"
                 foreach (var sign in Model.StabilitySigns)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"list-group-item\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 365, "\"", 430, 1);
#nullable restore
#line 14 "C:\Praktika\BFStabilityEvaluation\BFStabilityEvaluation\Views\Home\Index.cshtml"
WriteAttributeValue("", 372, Url.Action("Index", "Home", new { id = sign.StabSignId }), 372, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
#nullable restore
#line 15 "C:\Praktika\BFStabilityEvaluation\BFStabilityEvaluation\Views\Home\Index.cshtml"
                       Write(sign.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </a> - ");
#nullable restore
#line 16 "C:\Praktika\BFStabilityEvaluation\BFStabilityEvaluation\Views\Home\Index.cshtml"
                          Write(Functions.RoundSmart(StabilityCore.GetStabilityValue(sign.StabSignId, Model.StabilitySignKriteriums)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </li>\r\n");
#nullable restore
#line 18 "C:\Praktika\BFStabilityEvaluation\BFStabilityEvaluation\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n        <div class=\"col-8\">\r\n            <h2><span class=\"bi bi-boxes text-info fs-3\"></span> ");
#nullable restore
#line 22 "C:\Praktika\BFStabilityEvaluation\BFStabilityEvaluation\Views\Home\Index.cshtml"
                                                            Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
            <table class=""table table-hover table-client text-center caption-top"">
                <thead>
                    <tr>
                        <th>Параметр</th>

                        <th>Ранг</th>
                        <th>Возможное отклонение</th>
                        <th>Отклонение факт</th>
                        <th>Значение</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 35 "C:\Praktika\BFStabilityEvaluation\BFStabilityEvaluation\Views\Home\Index.cshtml"
                     foreach (var item in Model.StabilitySignKriteriums.Where(d => d.StabSignId == Model.CurrentSignId))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td class=\"text-left\">");
#nullable restore
#line 38 "C:\Praktika\BFStabilityEvaluation\BFStabilityEvaluation\Views\Home\Index.cshtml"
                                             Write(item.Parameter?.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                            <td>");
#nullable restore
#line 40 "C:\Praktika\BFStabilityEvaluation\BFStabilityEvaluation\Views\Home\Index.cshtml"
                           Write(item.Rang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 41 "C:\Praktika\BFStabilityEvaluation\BFStabilityEvaluation\Views\Home\Index.cshtml"
                           Write(item.AcceptableDelta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 43 "C:\Praktika\BFStabilityEvaluation\BFStabilityEvaluation\Views\Home\Index.cshtml"
                           Write(Functions.RoundSmart(item.Parameter.ParameterValues.Select(x => x.Value).StdDev()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                <p>");
#nullable restore
#line 46 "C:\Praktika\BFStabilityEvaluation\BFStabilityEvaluation\Views\Home\Index.cshtml"
                              Write(Functions.RoundSmart(item.Parameter.ParameterValues.Select(x => x.Value).Average()));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 49 "C:\Praktika\BFStabilityEvaluation\BFStabilityEvaluation\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
