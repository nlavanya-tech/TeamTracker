#pragma checksum "I:\IIHT\TeamTracker\Jr_FSE_PA\Project\TeamTracker\TeamTracker\Views\User\GetUserDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31c883b80ef09af6693025eabebea00554796851"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_GetUserDetails), @"mvc.1.0.view", @"/Views/User/GetUserDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/GetUserDetails.cshtml", typeof(AspNetCore.Views_User_GetUserDetails))]
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
#line 1 "I:\IIHT\TeamTracker\Jr_FSE_PA\Project\TeamTracker\TeamTracker\Views\_ViewImports.cshtml"
using TeamTracker;

#line default
#line hidden
#line 2 "I:\IIHT\TeamTracker\Jr_FSE_PA\Project\TeamTracker\TeamTracker\Views\_ViewImports.cshtml"
using TeamTracker.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31c883b80ef09af6693025eabebea00554796851", @"/Views/User/GetUserDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61f580ce25c4671f33b10e437903cbfb45f88580", @"/Views/_ViewImports.cshtml")]
    public class Views_User_GetUserDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "I:\IIHT\TeamTracker\Jr_FSE_PA\Project\TeamTracker\TeamTracker\Views\User\GetUserDetails.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(29, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(58, 293, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31c883b80ef09af6693025eabebea005547968514440", async() => {
                BeginContext(64, 63, true);
                WriteLiteral("\r\n\r\n    <div>\r\n        <input type=\"button\" value=\"AddNewTeams\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 127, "\"", 186, 3);
                WriteAttributeValue("", 137, "location.href=\'", 137, 15, true);
#line 12 "I:\IIHT\TeamTracker\Jr_FSE_PA\Project\TeamTracker\TeamTracker\Views\User\GetUserDetails.cshtml"
WriteAttributeValue("", 152, Url.Action("CreateUser", "User"), 152, 33, false);

#line default
#line hidden
                WriteAttributeValue("", 185, "\'", 185, 1, true);
                EndWriteAttribute();
                BeginContext(187, 73, true);
                WriteLiteral(" />\r\n    </div>\r\n    <div>\r\n        <input type=\"button\" value=\"HomePage\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 260, "\"", 314, 3);
                WriteAttributeValue("", 270, "location.href=\'", 270, 15, true);
#line 15 "I:\IIHT\TeamTracker\Jr_FSE_PA\Project\TeamTracker\TeamTracker\Views\User\GetUserDetails.cshtml"
WriteAttributeValue("", 285, Url.Action("Index", "Home"), 285, 28, false);

#line default
#line hidden
                WriteAttributeValue("", 313, "\'", 313, 1, true);
                EndWriteAttribute();
                BeginContext(315, 29, true);
                WriteLiteral(" />\r\n    </div>\r\n    <hr />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(351, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(357, 933, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31c883b80ef09af6693025eabebea005547968517013", async() => {
                BeginContext(363, 310, true);
                WriteLiteral(@"
    <table class=""table"">
        <tr>
            <th>FirstName</th>
            <th>LastName</th>
            <th>Email</th>
            <th>UserType</th>
            <th>Status</th>
            <th>InterviewStatus</th>
            <th>ReportingTo</th>
            <th>Mobile</th>
        </tr>
");
                EndContext();
#line 33 "I:\IIHT\TeamTracker\Jr_FSE_PA\Project\TeamTracker\TeamTracker\Views\User\GetUserDetails.cshtml"
         foreach (var list in Model)
        {

#line default
#line hidden
                BeginContext(722, 38, true);
                WriteLiteral("            <tr>\r\n                <td>");
                EndContext();
                BeginContext(761, 14, false);
#line 36 "I:\IIHT\TeamTracker\Jr_FSE_PA\Project\TeamTracker\TeamTracker\Views\User\GetUserDetails.cshtml"
               Write(list.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(775, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(803, 13, false);
#line 37 "I:\IIHT\TeamTracker\Jr_FSE_PA\Project\TeamTracker\TeamTracker\Views\User\GetUserDetails.cshtml"
               Write(list.LastName);

#line default
#line hidden
                EndContext();
                BeginContext(816, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(844, 10, false);
#line 38 "I:\IIHT\TeamTracker\Jr_FSE_PA\Project\TeamTracker\TeamTracker\Views\User\GetUserDetails.cshtml"
               Write(list.Email);

#line default
#line hidden
                EndContext();
                BeginContext(854, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(882, 13, false);
#line 39 "I:\IIHT\TeamTracker\Jr_FSE_PA\Project\TeamTracker\TeamTracker\Views\User\GetUserDetails.cshtml"
               Write(list.UserType);

#line default
#line hidden
                EndContext();
                BeginContext(895, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(923, 11, false);
#line 40 "I:\IIHT\TeamTracker\Jr_FSE_PA\Project\TeamTracker\TeamTracker\Views\User\GetUserDetails.cshtml"
               Write(list.Status);

#line default
#line hidden
                EndContext();
                BeginContext(934, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(962, 20, false);
#line 41 "I:\IIHT\TeamTracker\Jr_FSE_PA\Project\TeamTracker\TeamTracker\Views\User\GetUserDetails.cshtml"
               Write(list.InterviewStatus);

#line default
#line hidden
                EndContext();
                BeginContext(982, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(1010, 16, false);
#line 42 "I:\IIHT\TeamTracker\Jr_FSE_PA\Project\TeamTracker\TeamTracker\Views\User\GetUserDetails.cshtml"
               Write(list.ReportingTo);

#line default
#line hidden
                EndContext();
                BeginContext(1026, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(1054, 11, false);
#line 43 "I:\IIHT\TeamTracker\Jr_FSE_PA\Project\TeamTracker\TeamTracker\Views\User\GetUserDetails.cshtml"
               Write(list.Mobile);

#line default
#line hidden
                EndContext();
                BeginContext(1065, 49, true);
                WriteLiteral("</td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(1114, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31c883b80ef09af6693025eabebea0055479685111237", async() => {
                    BeginContext(1139, 8, true);
                    WriteLiteral("EditUser");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1151, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1173, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31c883b80ef09af6693025eabebea0055479685112721", async() => {
                    BeginContext(1200, 10, true);
                    WriteLiteral("DeleteUser");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1214, 44, true);
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
                EndContext();
#line 49 "I:\IIHT\TeamTracker\Jr_FSE_PA\Project\TeamTracker\TeamTracker\Views\User\GetUserDetails.cshtml"
        }

#line default
#line hidden
                BeginContext(1269, 14, true);
                WriteLiteral("    </table>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1290, 9, true);
            WriteLiteral("\r\n</html>");
            EndContext();
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