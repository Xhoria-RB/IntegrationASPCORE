#pragma checksum "C:\Users\Ricardo Bibieca\source\repos\VTigerCore\VTigerCore\Views\Products\CreateProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21e6034bdc2020f74f075fa6ae945706dcd9a519"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_CreateProducts), @"mvc.1.0.view", @"/Views/Products/CreateProducts.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/CreateProducts.cshtml", typeof(AspNetCore.Views_Products_CreateProducts))]
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
#line 1 "C:\Users\Ricardo Bibieca\source\repos\VTigerCore\VTigerCore\Views\_ViewImports.cshtml"
using VTigerCore;

#line default
#line hidden
#line 2 "C:\Users\Ricardo Bibieca\source\repos\VTigerCore\VTigerCore\Views\_ViewImports.cshtml"
using VTigerCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21e6034bdc2020f74f075fa6ae945706dcd9a519", @"/Views/Products/CreateProducts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8054b5f86ab4349c6965ed969a9309f598380dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_CreateProducts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Ricardo Bibieca\source\repos\VTigerCore\VTigerCore\Views\Products\CreateProducts.cshtml"
  
    ViewData["Title"] = "New Products";

#line default
#line hidden
            BeginContext(50, 39, true);
            WriteLiteral("\r\n<div class=\"çontainer\">\r\n\r\n\r\n    <h2>");
            EndContext();
            BeginContext(90, 17, false);
#line 9 "C:\Users\Ricardo Bibieca\source\repos\VTigerCore\VTigerCore\Views\Products\CreateProducts.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(107, 1956, true);
            WriteLiteral(@"</h2>
    <hr />
    <div>

        <div class=""row"">
            <div class=""col-md-4"">
                <asp:Label ID=""Label1"" runat=""server"" Text=""Product name:""></asp:Label>
                <asp:TextBox ID=""txtProductName"" runat=""server"" class=""form-control""></asp:TextBox>
            </div>

            <div class=""col-md-4"">
                <asp:Label ID=""Label2"" runat=""server"" Text=""Product active""></asp:Label>
                <asp:CheckBox ID=""cxbProductActive"" runat=""server"" />
            </div>
        </div>

        <div class=""row"">
            <div class=""col-md-4"">
                <asp:Label ID=""Label7"" runat=""server"" Text=""Unit price""></asp:Label>
                <asp:TextBox ID=""txtUnitPrice"" runat=""server"" class=""form-control""></asp:TextBox>
            </div>
            <div class=""col-md4"">
                <asp:Label ID=""Label8"" runat=""server"" Text=""Taxes""></asp:Label>
                <asp:TextBox ID=""txtTaxes"" runat=""server"" class=""form-control""></asp:TextBox>
   ");
            WriteLiteral(@"         </div>
        </div>
        <div class=""row"">
            <div class=""col-md-4"">
                <asp:Label ID=""Label9"" runat=""server"" Text=""Qt. in stock:""></asp:Label>
                <asp:TextBox ID=""txtQtStock"" runat=""server"" class=""form-control""></asp:TextBox>
            </div>
            <div class=""col-md-4"">
                <asp:Label ID=""Label10"" runat=""server"" Text=""Handler""></asp:Label>

                <asp:DropDownList ID=""ddLHandler"" runat=""server"" Height=""20px"" Width=""150px"" class=""form-control"">
                </asp:DropDownList>
                <br />
                <br />
                <asp:Button ID=""btnCancel"" runat=""server"" Height=""58px"" Text=""Cancel"" Width=""107px"" class=""btn btn-danger"" />
                <asp:Button ID=""btnSave"" runat=""server"" Height=""58px"" Text=""Save"" Width=""107px"" class=""btn btn-success"" />
            </div>
        </div>
    </div>
</div>
");
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
