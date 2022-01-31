#pragma checksum "D:\Code\MusicOnline\MusicOnline\Pages\Playlist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35e56a8c59a23574f0ca8ad3064198425b0ce3f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MusicOnline.Pages.Pages_Playlist), @"mvc.1.0.razor-page", @"/Pages/Playlist.cshtml")]
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
#line 2 "D:\Code\MusicOnline\MusicOnline\Pages\Playlist.cshtml"
using MusicOnline.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Code\MusicOnline\MusicOnline\Pages\Playlist.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35e56a8c59a23574f0ca8ad3064198425b0ce3f8", @"/Pages/Playlist.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99d7413413586b93877ab8d30d645cc8bdbc4975", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Playlist : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/playlist.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "D:\Code\MusicOnline\MusicOnline\Pages\Playlist.cshtml"
  
    ViewData["Title"] = "Playlist";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "D:\Code\MusicOnline\MusicOnline\Pages\Playlist.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script type=\"text/javascript\">\r\n    var dataPla = ");
#nullable restore
#line 11 "D:\Code\MusicOnline\MusicOnline\Pages\Playlist.cshtml"
             Write(Html.Raw(JsonSerializer.Serialize(Model.lst)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n</script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35e56a8c59a23574f0ca8ad3064198425b0ce3f84214", async() => {
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
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Thể loại nhạc. <button type=""button"" class=""btn btn-outline-success"" onclick=""openPlaylistModal(null);"">Tạo playlist</button></h1>
    <table id=""tblPlaylist"" class=""table table-danger"">
        <tr>
            <th>Mã</th>
            <th>Tên playlist</th>
            <th>Action</th>
        </tr>
");
#nullable restore
#line 22 "D:\Code\MusicOnline\MusicOnline\Pages\Playlist.cshtml"
         foreach (PlaylistDTO p in Model.lst)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr");
            BeginWriteAttribute("id", " id=\"", 754, "\"", 770, 2);
            WriteAttributeValue("", 759, "trPla_", 759, 6, true);
#nullable restore
#line 24 "D:\Code\MusicOnline\MusicOnline\Pages\Playlist.cshtml"
WriteAttributeValue("", 765, p.id, 765, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <td>");
#nullable restore
#line 25 "D:\Code\MusicOnline\MusicOnline\Pages\Playlist.cshtml"
               Write(p.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "D:\Code\MusicOnline\MusicOnline\Pages\Playlist.cshtml"
               Write(p.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <button type=\"button\" class=\"btn btn-outline-primary btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 942, "\"", 977, 3);
            WriteAttributeValue("", 952, "openPlaylistModal(", 952, 18, true);
#nullable restore
#line 28 "D:\Code\MusicOnline\MusicOnline\Pages\Playlist.cshtml"
WriteAttributeValue("", 970, p.id, 970, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 975, ");", 975, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Sửa</button>\r\n                    <button type=\"button\" class=\"btn btn-outline-danger btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1072, "\"", 1104, 3);
            WriteAttributeValue("", 1082, "deletePlaylist(", 1082, 15, true);
#nullable restore
#line 29 "D:\Code\MusicOnline\MusicOnline\Pages\Playlist.cshtml"
WriteAttributeValue("", 1097, p.id, 1097, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1102, ");", 1102, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Xóa</button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 32 "D:\Code\MusicOnline\MusicOnline\Pages\Playlist.cshtml"
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
                <h5 class=""modal-title"">Cập nhật thể loại - <span id=""spanId""></span></h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""form-group"">
                    <label for=""exampleInputEmail1"">Tên thể loại</label>
                    <input type=""email"" class=""form-control"" id=""txtPlaylistName"" aria-describedby=""PlaylistNameHelp"" placeholder=""Nhập tên playlist"">
                    <small id=""PlaylistNameHelp"" class=""form-text text-muted"">Tên playlist không được để trống.</small>
                </div>
            </div>
            <div class=""modal-footer"">
");
            WriteLiteral(@"                <button type=""button"" class=""btn btn-primary"" onclick=""savePlaylist();"">Lưu thay đổi</button>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Đóng</button>
            </div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MusicOnline.Pages.PlaylistModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MusicOnline.Pages.PlaylistModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MusicOnline.Pages.PlaylistModel>)PageContext?.ViewData;
        public MusicOnline.Pages.PlaylistModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
