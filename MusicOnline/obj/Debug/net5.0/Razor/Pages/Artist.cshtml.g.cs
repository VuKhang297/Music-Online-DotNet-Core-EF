#pragma checksum "D:\Code\MusicOnline\MusicOnline\Pages\Artist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a51b4bf50f74cfafe4766ef8751167aa3d0caae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MusicOnline.Pages.Pages_Artist), @"mvc.1.0.razor-page", @"/Pages/Artist.cshtml")]
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
#line 2 "D:\Code\MusicOnline\MusicOnline\Pages\Artist.cshtml"
using MusicOnline.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Code\MusicOnline\MusicOnline\Pages\Artist.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a51b4bf50f74cfafe4766ef8751167aa3d0caae", @"/Pages/Artist.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99d7413413586b93877ab8d30d645cc8bdbc4975", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Artist : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/artist.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "D:\Code\MusicOnline\MusicOnline\Pages\Artist.cshtml"
  
    ViewData["Title"] = "Ngh??? s??";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a51b4bf50f74cfafe4766ef8751167aa3d0caae3651", async() => {
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
#line 9 "D:\Code\MusicOnline\MusicOnline\Pages\Artist.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script type=\"text/javascript\">\r\n    var dataArt = ");
#nullable restore
#line 11 "D:\Code\MusicOnline\MusicOnline\Pages\Artist.cshtml"
             Write(Html.Raw(JsonSerializer.Serialize(Model.lst)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
</script>
<div class=""text-center"">
    <h1 class=""display-4"">Ngh??? s??. <button type=""button"" class=""btn btn-outline-success"" onclick=""openModal(null);"">Th??m m???i ngh??? s??</button></h1>
    <table id=""tblArtist"" class=""table table-danger"">
        <tr>
            <th>M?? ngh??? s??</th>
            <th>T??n ngh??? s??</th>
            <th>Profile</th>
            <th>Action</th>
        </tr>
");
#nullable restore
#line 22 "D:\Code\MusicOnline\MusicOnline\Pages\Artist.cshtml"
         foreach (ArtistDTO a in Model.lst)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr");
            BeginWriteAttribute("id", " id=\"", 762, "\"", 778, 2);
            WriteAttributeValue("", 767, "trGen_", 767, 6, true);
#nullable restore
#line 24 "D:\Code\MusicOnline\MusicOnline\Pages\Artist.cshtml"
WriteAttributeValue("", 773, a.id, 773, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <td>");
#nullable restore
#line 25 "D:\Code\MusicOnline\MusicOnline\Pages\Artist.cshtml"
       Write(a.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 26 "D:\Code\MusicOnline\MusicOnline\Pages\Artist.cshtml"
       Write(a.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 27 "D:\Code\MusicOnline\MusicOnline\Pages\Artist.cshtml"
       Write(a.profile);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>\r\n            <button type=\"button\" class=\"btn btn-outline-primary btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 947, "\"", 974, 3);
            WriteAttributeValue("", 957, "openModal(", 957, 10, true);
#nullable restore
#line 29 "D:\Code\MusicOnline\MusicOnline\Pages\Artist.cshtml"
WriteAttributeValue("", 967, a.id, 967, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 972, ");", 972, 2, true);
            EndWriteAttribute();
            WriteLiteral(">S???a</button>\r\n            <button type=\"button\" class=\"btn btn-outline-danger btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1061, "\"", 1091, 3);
            WriteAttributeValue("", 1071, "deleteArtist(", 1071, 13, true);
#nullable restore
#line 30 "D:\Code\MusicOnline\MusicOnline\Pages\Artist.cshtml"
WriteAttributeValue("", 1084, a.id, 1084, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1089, ");", 1089, 2, true);
            EndWriteAttribute();
            WriteLiteral(">X??a</button>\r\n        </td>\r\n    </tr>\r\n");
#nullable restore
#line 33 "D:\Code\MusicOnline\MusicOnline\Pages\Artist.cshtml"
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
                <h5 class=""modal-title"">C???p nh???t ngh??? s?? - <span id=""spanId""></span></h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""form-group"">
                    <label for=""exampleInputEmail1"">T??n ngh??? s??</label>
                    <input type=""text"" class=""form-control"" id=""txtArtistName"" aria-describedby=""ArtistNameHelp"" placeholder=""Nh???p t??n ngh??? s??"">
                    <label for=""exampleInputEmail1"">Profile</label>
                    <input type=""text"" class=""form-control"" id=""txtArtistProfile"" aria-describedby=""ArtistProfileHelp"" placeholder=""Nh???p profile");
            WriteLiteral(@""">
                    <small id=""ArtistNameHelp"" class=""form-text text-muted"">T??n ngh??? s?? kh??ng ???????c ????? tr???ng.</small>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-primary"" onclick=""saveArtist();"">L??u thay ?????i</button>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">????ng</button>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MusicOnline.Pages.ArtistModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MusicOnline.Pages.ArtistModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MusicOnline.Pages.ArtistModel>)PageContext?.ViewData;
        public MusicOnline.Pages.ArtistModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
