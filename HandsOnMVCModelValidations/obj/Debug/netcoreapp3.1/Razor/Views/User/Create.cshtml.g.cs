#pragma checksum "C:\Users\Dell\source\repos\HandsOnMVCModelValidations\Views\User\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b203505ab739d88fa5edccfbaea0ec19da00990"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Create), @"mvc.1.0.view", @"/Views/User/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b203505ab739d88fa5edccfbaea0ec19da00990", @"/Views/User/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"704007baf1dc9824fb5c6c9d9abf46b976d6c108", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Dell\source\repos\HandsOnMVCModelValidations\Views\User\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Create</h1>\r\n");
#nullable restore
#line 7 "C:\Users\Dell\source\repos\HandsOnMVCModelValidations\Views\User\Create.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-bordered\">\r\n    <tr>\r\n        <td>\r\n            Name\r\n        </td>\r\n       \r\n        <td>");
#nullable restore
#line 15 "C:\Users\Dell\source\repos\HandsOnMVCModelValidations\Views\User\Create.cshtml"
       Write(Html.TextBoxFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 16 "C:\Users\Dell\source\repos\HandsOnMVCModelValidations\Views\User\Create.cshtml"
       Write(Html.ValidationMessageFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>\r\n            Email\r\n        </td>\r\n        <td>");
#nullable restore
#line 22 "C:\Users\Dell\source\repos\HandsOnMVCModelValidations\Views\User\Create.cshtml"
       Write(Html.TextBoxFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 23 "C:\Users\Dell\source\repos\HandsOnMVCModelValidations\Views\User\Create.cshtml"
       Write(Html.ValidationMessageFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n    </tr>\r\n    <tr>\r\n        <td>\r\n            DOB\r\n        </td>\r\n\r\n        <td>");
#nullable restore
#line 31 "C:\Users\Dell\source\repos\HandsOnMVCModelValidations\Views\User\Create.cshtml"
       Write(Html.TextBoxFor(m => m.DOB,null,new { @type="Date"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 32 "C:\Users\Dell\source\repos\HandsOnMVCModelValidations\Views\User\Create.cshtml"
       Write(Html.ValidationMessageFor(m => m.DOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>\r\n            Country\r\n        </td>\r\n");
            WriteLiteral("        <td>");
#nullable restore
#line 39 "C:\Users\Dell\source\repos\HandsOnMVCModelValidations\Views\User\Create.cshtml"
       Write(Html.DropDownListFor(m => m.Country,ViewBag.country as SelectList,"Select Country"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 40 "C:\Users\Dell\source\repos\HandsOnMVCModelValidations\Views\User\Create.cshtml"
       Write(Html.ValidationMessageFor(m => m.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>\r\n            UserName\r\n        </td>\r\n        <td>");
#nullable restore
#line 46 "C:\Users\Dell\source\repos\HandsOnMVCModelValidations\Views\User\Create.cshtml"
       Write(Html.TextBoxFor(m => m.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 47 "C:\Users\Dell\source\repos\HandsOnMVCModelValidations\Views\User\Create.cshtml"
       Write(Html.ValidationMessageFor(m => m.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>\r\n            Password\r\n        </td>\r\n        <td>");
#nullable restore
#line 53 "C:\Users\Dell\source\repos\HandsOnMVCModelValidations\Views\User\Create.cshtml"
       Write(Html.PasswordFor(m=>m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 54 "C:\Users\Dell\source\repos\HandsOnMVCModelValidations\Views\User\Create.cshtml"
       Write(Html.ValidationMessageFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td colspan=\"2\"><input type=\"submit\" value=\"Register\" /> </td>\r\n    </tr>\r\n</table>\r\n");
#nullable restore
#line 60 "C:\Users\Dell\source\repos\HandsOnMVCModelValidations\Views\User\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
