#pragma checksum "C:\Users\DELL\Desktop\Ulbra\Linguagem Comercial I\crudproduto\produto\Views\Produto\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6ce095ed77ea15861967112828733b6370770b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Edit), @"mvc.1.0.view", @"/Views/Produto/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/Edit.cshtml", typeof(AspNetCore.Views_Produto_Edit))]
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
#line 1 "C:\Users\DELL\Desktop\Ulbra\Linguagem Comercial I\crudproduto\produto\Views\_ViewImports.cshtml"
using produto;

#line default
#line hidden
#line 2 "C:\Users\DELL\Desktop\Ulbra\Linguagem Comercial I\crudproduto\produto\Views\_ViewImports.cshtml"
using produto.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6ce095ed77ea15861967112828733b6370770b7", @"/Views/Produto/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"667dce90de44abc4055c2060ed7980affe146966", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 35, true);
            WriteLiteral("<div class=\"form-horizontal\">\r\n    ");
            EndContext();
            BeginContext(35, 1480, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6ce095ed77ea15861967112828733b6370770b74049", async() => {
                BeginContext(69, 152, true);
                WriteLiteral("\r\n\r\n        <div class=\"form-group\">\r\n            <label>Id</label>\r\n            <input  class=\"form-control\"\r\n                    type=\"text\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", "\r\n                    value=\"", 221, "\"", 259, 1);
#line 8 "C:\Users\DELL\Desktop\Ulbra\Linguagem Comercial I\crudproduto\produto\Views\Produto\Edit.cshtml"
WriteAttributeValue("", 250, Model.id, 250, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(260, 186, true);
                WriteLiteral("/>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <label>Fabricante</label>\r\n            <input  class=\"form-control\"\r\n                    type=\"text\" name=\"fabricante\"");
                EndContext();
                BeginWriteAttribute("value", "\r\n                    value=\"", 446, "\"", 492, 1);
#line 15 "C:\Users\DELL\Desktop\Ulbra\Linguagem Comercial I\crudproduto\produto\Views\Produto\Edit.cshtml"
WriteAttributeValue("", 475, Model.fabricante, 475, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(493, 184, true);
                WriteLiteral("/>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <label>Categoria</label>\r\n            <input  class=\"form-control\"\r\n                    type=\"text\" name=\"categoria\"");
                EndContext();
                BeginWriteAttribute("value", "\r\n                    value=\"", 677, "\"", 722, 1);
#line 22 "C:\Users\DELL\Desktop\Ulbra\Linguagem Comercial I\crudproduto\produto\Views\Produto\Edit.cshtml"
WriteAttributeValue("", 706, Model.categoria, 706, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(723, 178, true);
                WriteLiteral("/>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <label>Modelo</label>\r\n            <input  class=\"form-control\"\r\n                    type=\"text\" name=\"modelo\"");
                EndContext();
                BeginWriteAttribute("value", "\r\n                    value=\"", 901, "\"", 943, 1);
#line 29 "C:\Users\DELL\Desktop\Ulbra\Linguagem Comercial I\crudproduto\produto\Views\Produto\Edit.cshtml"
WriteAttributeValue("", 930, Model.modelo, 930, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(944, 187, true);
                WriteLiteral("/>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <label>Ano Fabricação</label>\r\n            <input  class=\"form-control\"\r\n                    type=\"text\" name=\"ano_fab\"");
                EndContext();
                BeginWriteAttribute("value", "\r\n                    value=\"", 1131, "\"", 1174, 1);
#line 36 "C:\Users\DELL\Desktop\Ulbra\Linguagem Comercial I\crudproduto\produto\Views\Produto\Edit.cshtml"
WriteAttributeValue("", 1160, Model.ano_fab, 1160, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1175, 174, true);
                WriteLiteral("/>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <label>Tipo</label>\r\n            <input  class=\"form-control\"\r\n                    type=\"text\" name=\"tipo\"");
                EndContext();
                BeginWriteAttribute("value", "\r\n                    value=\"", 1349, "\"", 1389, 1);
#line 43 "C:\Users\DELL\Desktop\Ulbra\Linguagem Comercial I\crudproduto\produto\Views\Produto\Edit.cshtml"
WriteAttributeValue("", 1378, Model.tipo, 1378, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1390, 118, true);
                WriteLiteral("/>\r\n        </div>\r\n\r\n        <input  class=\"btn btn-primary\" \r\n                type=\"submit\" value=\"Salvar\"/>\r\n\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1515, 8, true);
            WriteLiteral("\r\n</div>");
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
