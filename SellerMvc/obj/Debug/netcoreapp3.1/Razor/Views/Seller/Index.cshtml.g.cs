#pragma checksum "C:\Users\Dell\source\repos\SellerMvc\Views\Seller\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05c23a32b9583ef54751a495d7136afcd12987f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Seller_Index), @"mvc.1.0.view", @"/Views/Seller/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05c23a32b9583ef54751a495d7136afcd12987f4", @"/Views/Seller/Index.cshtml")]
    public class Views_Seller_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SellerMvc.Models.Seller>>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Dell\source\repos\SellerMvc\Views\Seller\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05c23a32b9583ef54751a495d7136afcd12987f42902", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05c23a32b9583ef54751a495d7136afcd12987f43961", async() => {
                WriteLiteral(@"
    <table>
        <tr>
            <td>ID</td>
            <td>SellerName</td>
            <td>Password</td>
            <td>CompanyName</td>
            <td>GSTIN</td>
            <td>AboutCompany</td>
            <td>Address</td>
            <td>Website</td>
            <td>EmailId</td>
            <td>MobioleNo</td>
        </tr>
");
#nullable restore
#line 27 "C:\Users\Dell\source\repos\SellerMvc\Views\Seller\Index.cshtml"
         foreach (var e in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 30 "C:\Users\Dell\source\repos\SellerMvc\Views\Seller\Index.cshtml"
       Write(e.sid);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 31 "C:\Users\Dell\source\repos\SellerMvc\Views\Seller\Index.cshtml"
       Write(e.sname);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 32 "C:\Users\Dell\source\repos\SellerMvc\Views\Seller\Index.cshtml"
       Write(e.spassword);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 33 "C:\Users\Dell\source\repos\SellerMvc\Views\Seller\Index.cshtml"
       Write(e.scompanyname);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 34 "C:\Users\Dell\source\repos\SellerMvc\Views\Seller\Index.cshtml"
       Write(e.sgstin);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 35 "C:\Users\Dell\source\repos\SellerMvc\Views\Seller\Index.cshtml"
       Write(e.saboucompany);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 36 "C:\Users\Dell\source\repos\SellerMvc\Views\Seller\Index.cshtml"
       Write(e.saddress);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 37 "C:\Users\Dell\source\repos\SellerMvc\Views\Seller\Index.cshtml"
       Write(e.swebsite);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 38 "C:\Users\Dell\source\repos\SellerMvc\Views\Seller\Index.cshtml"
       Write(e.semailid);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 39 "C:\Users\Dell\source\repos\SellerMvc\Views\Seller\Index.cshtml"
       Write(e.smobileno);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n    </tr>\r\n");
#nullable restore
#line 41 "C:\Users\Dell\source\repos\SellerMvc\Views\Seller\Index.cshtml"
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SellerMvc.Models.Seller>> Html { get; private set; }
    }
}
#pragma warning restore 1591
