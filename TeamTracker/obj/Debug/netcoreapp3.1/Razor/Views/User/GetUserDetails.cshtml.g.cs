#pragma checksum "I:\IIHT\TeamTracker\Jr_FSE_PA\Project\TeamTracker\TeamTracker\Views\User\GetUserDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31c883b80ef09af6693025eabebea00554796851"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_GetUserDetails), @"mvc.1.0.view", @"/Views/User/GetUserDetails.cshtml")]
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
#line 1 "I:\IIHT\TeamTracker\Jr_FSE_PA\Project\TeamTracker\TeamTracker\Views\_ViewImports.cshtml"
using TeamTracker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "I:\IIHT\TeamTracker\Jr_FSE_PA\Project\TeamTracker\TeamTracker\Views\_ViewImports.cshtml"
using TeamTracker.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31c883b80ef09af6693025eabebea00554796851", @"/Views/User/GetUserDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61f580ce25c4671f33b10e437903cbfb45f88580", @"/Views/_ViewImports.cshtml")]
    public class Views_User_GetUserDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "I:\IIHT\TeamTracker\Jr_FSE_PA\Project\TeamTracker\TeamTracker\Views\User\GetUserDetails.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31c883b80ef09af6693025eabebea005547968514287", async() => {
                WriteLiteral("\r\n\r\n    <div>\r\n        <input type=\"button\" value=\"AddNewTeams\"");
                BeginWriteAttribute("onclick", " onclick=\"", 127, "\"", 186, 3);
                WriteAttributeValue("", 137, "location.href=\'", 137, 15, true);
#nullable restore
#line 12 "I:\IIHT\TeamTracker\Jr_FSE_PA\Project\TeamTracker\TeamTracker\Views\User\GetUserDetails.cshtml"
WriteAttributeValue("", 152, Url.Action("CreateUser", "User"), 152, 33, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 185, "\'", 185, 1, true);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    </div>\r\n    <div>\r\n        <input type=\"button\" value=\"HomePage\"");
                BeginWriteAttribute("onclick", " onclick=\"", 260, "\"", 314, 3);
                WriteAttributeValue("", 270, "location.href=\'", 270, 15, true);
#nullable restore
#line 15 "I:\IIHT\TeamTracker\Jr_FSE_PA\Project\TeamTracker\TeamTracker\Views\User\GetUserDetails.cshtml"
WriteAttributeValue("", 285, Url.Action("Index", "Home"), 285, 28, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 313, "\'", 313, 1, true);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    </div>\r\n    <hr />\r\n");
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
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31c883b80ef09af6693025eabebea005547968516567", async() => {
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
#nullable restore
#line 33 "I:\IIHT\TeamTracker\Jr_FSE_PA\Project\TeamTracker\TeamTracker\Views\User\GetUserDetails.cshtml"
         foreach (var list in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 36 "I:\IIHT\TeamTracker\Jr_FSE_PA\Project\TeamTracker\TeamTracker\Views\User\GetUserDetails.cshtml"
               Write(list.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "I:\IIHT\TeamTracker\Jr_FSE_PA\Project\TeamTracker\TeamTracker\Views\User\GetUserDetails.cshtml"
               Write(list.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 38 "I:\IIHT\TeamTracker\Jr_FSE_PA\Project\TeamTracker\TeamTracker\Views\User\GetUserDetails.cshtml"
               Write(list.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 39 "I:\IIHT\TeamTracker\Jr_FSE_PA\Project\TeamTracker\TeamTracker\Views\User\GetUserDetails.cshtml"
               Write(list.UserType);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 40 "I:\IIHT\TeamTracker\Jr_FSE_PA\Project\TeamTracker\TeamTracker\Views\User\GetUserDetails.cshtml"
               Write(list.Status);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 41 "I:\IIHT\TeamTracker\Jr_FSE_PA\Project\TeamTracker\TeamTracker\Views\User\GetUserDetails.cshtml"
               Write(list.InterviewStatus);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 42 "I:\IIHT\TeamTracker\Jr_FSE_PA\Project\TeamTracker\TeamTracker\Views\User\GetUserDetails.cshtml"
               Write(list.ReportingTo);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 43 "I:\IIHT\TeamTracker\Jr_FSE_PA\Project\TeamTracker\TeamTracker\Views\User\GetUserDetails.cshtml"
               Write(list.Mobile);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31c883b80ef09af6693025eabebea005547968519686", async() => {
                    WriteLiteral("EditUser");
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
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31c883b80ef09af6693025eabebea0055479685110927", async() => {
                    WriteLiteral("DeleteUser");
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
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 49 "I:\IIHT\TeamTracker\Jr_FSE_PA\Project\TeamTracker\TeamTracker\Views\User\GetUserDetails.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n");
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
            WriteLiteral("\r\n</html>");
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