#pragma checksum "D:\Code\MusicOnline\MusicOnline\Pages\Genre.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95666999a106d1d796ed145a29c36edcfa33925a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MusicOnline.Pages.Pages_Genre), @"mvc.1.0.razor-page", @"/Pages/Genre.cshtml")]
namespace MusicOnline.Pages
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
#line 1 "D:\Code\MusicOnline\MusicOnline\Pages\_ViewImports.cshtml"
using MusicOnline;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Code\MusicOnline\MusicOnline\Pages\Genre.cshtml"
using MusicOnline.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Code\MusicOnline\MusicOnline\Pages\Genre.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95666999a106d1d796ed145a29c36edcfa33925a", @"/Pages/Genre.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99d7413413586b93877ab8d30d645cc8bdbc4975", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Genre : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/genre.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\Code\MusicOnline\MusicOnline\Pages\Genre.cshtml"
  
    ViewData["Title"] = "Chủ đề";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95666999a106d1d796ed145a29c36edcfa33925a3641", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 9 "D:\Code\MusicOnline\MusicOnline\Pages\Genre.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script type=\"text/javascript\">\r\n    var dataGen = ");
#nullable restore
#line 11 "D:\Code\MusicOnline\MusicOnline\Pages\Genre.cshtml"
             Write(Html.Raw(JsonSerializer.Serialize(Model.lst)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
</script>

<div class=""text-center"">
    <h1 class=""display-4"">Chủ đề. <button type=""button"" class=""btn btn-outline-success"" onclick=""openModal(null)"">Thêm mới thể loại</button></h1>
    <table id=""tblGenre"" class=""table table-danger"">
        <tr>
            <th>Mã chủ đề</th>
            <th>Tên chủ đề</th>
            <th>Action</th>
        </tr>
");
#nullable restore
#line 22 "D:\Code\MusicOnline\MusicOnline\Pages\Genre.cshtml"
         foreach(GenreDTO g in Model.lst)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr");
            BeginWriteAttribute("id", " id=\"", 741, "\"", 757, 2);
            WriteAttributeValue("", 746, "trGen_", 746, 6, true);
#nullable restore
#line 24 "D:\Code\MusicOnline\MusicOnline\Pages\Genre.cshtml"
WriteAttributeValue("", 752, g.id, 752, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <td>");
#nullable restore
#line 25 "D:\Code\MusicOnline\MusicOnline\Pages\Genre.cshtml"
                   Write(g.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "D:\Code\MusicOnline\MusicOnline\Pages\Genre.cshtml"
                   Write(g.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <button type=\"button\" class=\"btn btn-outline-primary btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 945, "\"", 972, 3);
            WriteAttributeValue("", 955, "openModal(", 955, 10, true);
#nullable restore
#line 28 "D:\Code\MusicOnline\MusicOnline\Pages\Genre.cshtml"
WriteAttributeValue("", 965, g.id, 965, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 970, ");", 970, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Sửa</button>\r\n                        <button type=\"button\" class=\"btn btn-outline-danger btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1071, "\"", 1100, 3);
            WriteAttributeValue("", 1081, "deleteGenre(", 1081, 12, true);
#nullable restore
#line 29 "D:\Code\MusicOnline\MusicOnline\Pages\Genre.cshtml"
WriteAttributeValue("", 1093, g.id, 1093, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1098, ");", 1098, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Xóa</button>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 32 "D:\Code\MusicOnline\MusicOnline\Pages\Genre.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </table>
</div>
<div id=""divModal"" class=""modal"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Cập nhật chủ đề - <span id=""spanId""></span></h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""form-group"">
                    <label for=""exampleInputEmail1"">Tên chủ đề</label>
                    <input type=""email"" class=""form-control"" id=""txtGenreName"" aria-describedby=""genreNameHelp"" placeholder=""Nhập tên chủ đề"">
                    <small id=""genreNameHelp"" class=""form-text text-muted"">Tên chủ đề không được để trống.</small>
                </div>
            </div>
            <div class=""modal-footer"">
                <");
            WriteLiteral("button type=\"button\" class=\"btn btn-primary\" onclick=\"saveGenre();\">Lưu thay đổi</button>\r\n                <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Đóng</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MusicOnline.Pages.GenreModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MusicOnline.Pages.GenreModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MusicOnline.Pages.GenreModel>)PageContext?.ViewData;
        public MusicOnline.Pages.GenreModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
