#pragma checksum "D:\Code\MusicOnline\MusicOnline\Pages\Song.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84848b334e3b4905c06f008957ea5b9b8a116f49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MusicOnline.Pages.Pages_Song), @"mvc.1.0.razor-page", @"/Pages/Song.cshtml")]
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
#line 2 "D:\Code\MusicOnline\MusicOnline\Pages\Song.cshtml"
using MusicOnline.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Code\MusicOnline\MusicOnline\Pages\Song.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84848b334e3b4905c06f008957ea5b9b8a116f49", @"/Pages/Song.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99d7413413586b93877ab8d30d645cc8bdbc4975", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Song : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/song.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\Code\MusicOnline\MusicOnline\Pages\Song.cshtml"
  
    ViewData["Title"] = "Bài hát";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "D:\Code\MusicOnline\MusicOnline\Pages\Song.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script type=\"text/javascript\">\r\n    var dataSong = ");
#nullable restore
#line 11 "D:\Code\MusicOnline\MusicOnline\Pages\Song.cshtml"
              Write(Html.Raw(JsonSerializer.Serialize(Model.lst)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    var curPage = 1;\r\n    var totPage = ");
#nullable restore
#line 13 "D:\Code\MusicOnline\MusicOnline\Pages\Song.cshtml"
             Write(Html.Raw(Model.TotalPage));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    \r\n</script>\r\n<script src=\"http://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84848b334e3b4905c06f008957ea5b9b8a116f495467", async() => {
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
    <h1 class=""display-4"">Bài hát. <button type=""button"" class=""btn btn-outline-success"" onclick=""openModal(null)"">Thêm mới bài hát</button></h1>
    <table id=""tblSong"" class=""table table-danger"">
        <tr>
            <th>Mã bài hát</th>
            <th>Tên bài hát</th>
            <th>Album</th>
            <th>Thể loại</th>
            <th>Chủ đề</th>
            <th>Quốc gia</th>
            <th hidden>Lời bài hát</th>
            <th>Sáng tác</th>
            <th>Trình bày</th>
            <th>Tải lên bởi</th>
            <th>Ngày tải lên</th>
            <th>Lượt nghe</th>
            <th>Lượt thích</th>
            <th>File</th>
            <th>Action</th>
        </tr>
        <tbody id=""tbodySong"">
");
#nullable restore
#line 39 "D:\Code\MusicOnline\MusicOnline\Pages\Song.cshtml"
             foreach (SongDTO s in Model.lst)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr");
            BeginWriteAttribute("id", " id=\"", 1322, "\"", 1339, 2);
            WriteAttributeValue("", 1327, "trSong_", 1327, 7, true);
#nullable restore
#line 41 "D:\Code\MusicOnline\MusicOnline\Pages\Song.cshtml"
WriteAttributeValue("", 1334, s.id, 1334, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <td>");
#nullable restore
#line 42 "D:\Code\MusicOnline\MusicOnline\Pages\Song.cshtml"
               Write(s.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 43 "D:\Code\MusicOnline\MusicOnline\Pages\Song.cshtml"
               Write(s.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 44 "D:\Code\MusicOnline\MusicOnline\Pages\Song.cshtml"
               Write(s.albumId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 45 "D:\Code\MusicOnline\MusicOnline\Pages\Song.cshtml"
               Write(s.kindId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 46 "D:\Code\MusicOnline\MusicOnline\Pages\Song.cshtml"
               Write(s.genreId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 47 "D:\Code\MusicOnline\MusicOnline\Pages\Song.cshtml"
               Write(s.country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td hidden>");
#nullable restore
#line 48 "D:\Code\MusicOnline\MusicOnline\Pages\Song.cshtml"
                      Write(s.lyric);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 49 "D:\Code\MusicOnline\MusicOnline\Pages\Song.cshtml"
               Write(s.composed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ...\r\n                </td>\r\n                <td>");
#nullable restore
#line 53 "D:\Code\MusicOnline\MusicOnline\Pages\Song.cshtml"
               Write(s.userId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 54 "D:\Code\MusicOnline\MusicOnline\Pages\Song.cshtml"
               Write(s.createdDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 55 "D:\Code\MusicOnline\MusicOnline\Pages\Song.cshtml"
               Write(s.listens);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 56 "D:\Code\MusicOnline\MusicOnline\Pages\Song.cshtml"
               Write(s.likes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <audio controls>\r\n                        <source");
            BeginWriteAttribute("src", " src=\"", 1946, "\"", 1959, 1);
#nullable restore
#line 59 "D:\Code\MusicOnline\MusicOnline\Pages\Song.cshtml"
WriteAttributeValue("", 1952, s.link, 1952, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"audio/mp3\">\r\n                    </audio>\r\n                </td>\r\n                <td>\r\n                    <button type=\"button\" class=\"btn btn-outline-primary btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2135, "\"", 2167, 3);
            WriteAttributeValue("", 2145, "openLyricModal(", 2145, 15, true);
#nullable restore
#line 63 "D:\Code\MusicOnline\MusicOnline\Pages\Song.cshtml"
WriteAttributeValue("", 2160, s.id, 2160, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2165, ");", 2165, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Sửa</button>\r\n                    <button type=\"button\" class=\"btn btn-outline-danger btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2262, "\"", 2290, 3);
            WriteAttributeValue("", 2272, "deleteSong(", 2272, 11, true);
#nullable restore
#line 64 "D:\Code\MusicOnline\MusicOnline\Pages\Song.cshtml"
WriteAttributeValue("", 2283, s.id, 2283, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2288, ");", 2288, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Xóa</button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 67 "D:\Code\MusicOnline\MusicOnline\Pages\Song.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
    <nav aria-label=""Page navigation example"">
        <ul class=""pagination"">
            <li class=""page-item""><a class=""page-link"" href=""javascript:void(0);"" onclick=""goPrev()"">Previous</a></li>
            <li class=""page-item""><a class=""page-link"" href=""javascript:void(0);""><span id=""spanCurrentPage"">1</span></a></li>
            <li class=""page-item""><a class=""page-link"" href=""javascript:void(0);"" onclick=""goNext()"">Next</a></li>
        </ul>
    </nav>
</div>
<div id=""divModal"" class=""modal"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Cập nhật lời bài hát - <span id=""spanId""></span></h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div c");
            WriteLiteral("lass=\"modal-body\">\r\n                <div class=\"form-group\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84848b334e3b4905c06f008957ea5b9b8a116f4913804", async() => {
                WriteLiteral(@"
                        <label for=""exampleInputEmail1"">Tên bài hát</label>
                        <input type=""email"" class=""form-control"" id=""txtName"" aria-describedby=""SongLyricHelp"" placeholder=""Nhập tên bài hát"">
                        <small id=""SongNameHelp"" class=""form-text text-muted"">Tên bài hát không được để trống.</small>
                        <label for=""exampleInputEmail1"">Sáng tác</label>
                        <input type=""email"" class=""form-control"" id=""txtComposed"" aria-describedby=""SongLyricHelp"" placeholder=""Nhập nhạc sĩ"">
                        <label for=""exampleInputEmail1"">Trình bày</label>
                        <input type=""email"" class=""form-control"" id=""txtSinger"" aria-describedby=""SongLyricHelp"" placeholder=""Nhập ca sĩ"">
                        <label for=""exampleInputEmail1"">Lời bài hát</label>
                        <input type=""email"" class=""form-control"" id=""txtLyric"" aria-describedby=""SongLyricHelp"" placeholder=""Nhập lời bài hát"">
                        <l");
                WriteLiteral(@"abel for=""exampleInputEmail1"">Album</label>
                        <input type=""email"" class=""form-control"" id=""txtAlbum"" aria-describedby=""SongLyricHelp"" placeholder=""Nhập album"">
                        <label for=""exampleInputEmail1"">Thể loại</label>
                        <input type=""email"" class=""form-control"" id=""txtKind"" aria-describedby=""SongLyricHelp"" placeholder=""Nhập thể loại"">
                        <label for=""exampleInputEmail1"">Chủ đề</label>
                        <input type=""email"" class=""form-control"" id=""txtGenre"" aria-describedby=""SongLyricHelp"" placeholder=""Nhập chủ đề"">
                        <input type=""file"" class=""form-control"" id=""inputFile"" accept="".mp3,audio/*""/>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-primary"" onclick=""saveSong();"">Lưu thay đổi</button>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Đóng</button>
            </div>
        </div>
    </div>
</div>
<div id=""lyricModal"" class=""modal"" tabindex=""-2"" role=""dialog"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Cập nhật lời bài hát - <span id=""spanSongId""></span></h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""form-group"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84848b334e3b4905c06f008957ea5b9b8a116f4918201", async() => {
                WriteLiteral("\r\n                        <label for=\"exampleInputEmail1\">Lời bài hát</label>\r\n                        <input type=\"text\" class=\"form-control\" id=\"txtSongLyric\" aria-describedby=\"SongLyricHelp\" placeholder=\"Nhập lời bài hát\">\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-primary"" onclick=""saveSong();"">Lưu thay đổi</button>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Đóng</button>
            </div>
        </div>
    </div>
</div>
<script id=""songTemplate"" type=""text/x-jquery-tmpl"">
    <tr id=""trSong_${id}"">
        <td>${id}</td>
        <td>${name}</td>
        <td>${albumId}</td>
        <td>${kindId}</td>
        <td>${genreId}</td>
        <td>${country}</td>
        <td hidden>${lyric}</td>
        <td>${composed}</td>
        <td>...</td>
        <td>${userId}</td>
        <td>${createdDate}</td>
        <td>${listens}</td>
        <td>${likes}</td>
        <td>
            <audio controls>
                <source src=""${link}"" type=""audio/mp3"">
            </audio>
        </td>
        <td>
            <button type=""button"" class=""btn btn-outline-primary btn-sm"" ");
            WriteLiteral("onclick=\"openLyricModal(${id});\">Sửa</button>\r\n            <button type=\"button\" class=\"btn btn-outline-danger btn-sm\" onclick=\"deleteSong(${id});\">Xóa</button>\r\n        </td>\r\n    </tr>\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MusicOnline.Pages.SongModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MusicOnline.Pages.SongModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MusicOnline.Pages.SongModel>)PageContext?.ViewData;
        public MusicOnline.Pages.SongModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
