#pragma checksum "C:\Users\Dell\source\repos\HandsOnMVCModelValidations\Views\User\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1c70e7b315fa0218db30c1b5c93b6944d21a1ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Login), @"mvc.1.0.view", @"/Views/User/Login.cshtml")]
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
#line 1 "C:\Users\Dell\source\repos\HandsOnMVCModelValidations\Views\_ViewImports.cshtml"
using HandsOnMVCModelValidations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dell\source\repos\HandsOnMVCModelValidations\Views\_ViewImports.cshtml"
using HandsOnMVCModelValidations.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1c70e7b315fa0218db30c1b5c93b6944d21a1ef", @"/Views/User/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"704007baf1dc9824fb5c6c9d9abf46b976d6c108", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Dell\source\repos\HandsOnMVCModelValidations\Views\User\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Login</h1>\r\n");
#nullable restore
#line 7 "C:\Users\Dell\source\repos\HandsOnMVCModelValidations\Views\User\Login.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table>\r\n    <tr>\r\n        <td>UserName</td>\r\n        <td>");
#nullable restore
#line 12 "C:\Users\Dell\source\repos\HandsOnMVCModelValidations\Views\User\Login.cshtml"
       Write(Html.TextBox("nm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Password</td>\r\n        <td>");
#nullable restore
#line 16 "C:\Users\Dell\source\repos\HandsOnMVCModelValidations\Views\User\Login.cshtml"
       Write(Html.Password("psd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td colspan=\"2\">\r\n        <input type=\"submit\" value=\"Login\" class=\"btn btn-primary\" />\r\n        </td>\r\n\r\n    </tr>\r\n    <tr>\r\n        \r\n        <td><span class=\"text-danger\">");
#nullable restore
#line 26 "C:\Users\Dell\source\repos\HandsOnMVCModelValidations\Views\User\Login.cshtml"
                                 Write(ViewData["err"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n    </tr>\r\n</table>\r\n");
#nullable restore
#line 29 "C:\Users\Dell\source\repos\HandsOnMVCModelValidations\Views\User\Login.cshtml"
}

#line default
#line hidden
#nullable disable
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
