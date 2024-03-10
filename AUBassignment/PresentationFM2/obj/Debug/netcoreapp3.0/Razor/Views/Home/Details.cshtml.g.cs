#pragma checksum "J:\01 Work\01-Development\AUB\AUBassignment\PresentationFM2\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61baf1a49dfff1d8124208c677300255be97a1ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "J:\01 Work\01-Development\AUB\AUBassignment\PresentationFM2\Views\_ViewImports.cshtml"
using PresentationFM2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "J:\01 Work\01-Development\AUB\AUBassignment\PresentationFM2\Views\_ViewImports.cshtml"
using PresentationFM2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61baf1a49dfff1d8124208c677300255be97a1ae", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71465301702cd24abcbbe7343fdaffce5dd34cc5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataModels.Movie>
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "J:\01 Work\01-Development\AUB\AUBassignment\PresentationFM2\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<table>\r\n    <tr>\r\n        <td>\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 197, "\"", 257, 2);
            WriteAttributeValue("", 203, "https://image.tmdb.org/t/p/original/", 203, 36, true);
#nullable restore
#line 13 "J:\01 Work\01-Development\AUB\AUBassignment\PresentationFM2\Views\Home\Details.cshtml"
WriteAttributeValue("", 239, Model.poster_path, 239, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 400px;margin: 0px;\" />\r\n        </td>\r\n        <td>\r\n            <h1 style=\"margin-left:20px\">");
#nullable restore
#line 16 "J:\01 Work\01-Development\AUB\AUBassignment\PresentationFM2\Views\Home\Details.cshtml"
                                    Write(Model.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <div class=\"container\">\r\n\r\n                <div class=\"movie-info\">\r\n\r\n                    <p style=\"font-weight: bold;\">Release Date:</p> ");
#nullable restore
#line 21 "J:\01 Work\01-Development\AUB\AUBassignment\PresentationFM2\Views\Home\Details.cshtml"
                                                               Write(Model.release_date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <p style=\"font-weight: bold;\">Popularity:</p> ");
#nullable restore
#line 22 "J:\01 Work\01-Development\AUB\AUBassignment\PresentationFM2\Views\Home\Details.cshtml"
                                                             Write(Model.popularity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <p style=\"font-weight: bold;\">Overview:</p> ");
#nullable restore
#line 23 "J:\01 Work\01-Development\AUB\AUBassignment\PresentationFM2\Views\Home\Details.cshtml"
                                                           Write(Model.overview);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <p style=\"font-weight: bold;\">Genres:</p>");
#nullable restore
#line 24 "J:\01 Work\01-Development\AUB\AUBassignment\PresentationFM2\Views\Home\Details.cshtml"
                                                         Write(Model.genres == null ? "" : string.Join(", ", Model.genres.Select(c => c.name)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <p style=\"font-weight: bold;\">Spoken Languages:</p>");
#nullable restore
#line 25 "J:\01 Work\01-Development\AUB\AUBassignment\PresentationFM2\Views\Home\Details.cshtml"
                                                                   Write(Model.spoken_languages == null ? "" : string.Join(", ", Model.spoken_languages.Select(c => c.name)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <p style=\"font-weight: bold;\">adult:</p> ");
#nullable restore
#line 26 "J:\01 Work\01-Development\AUB\AUBassignment\PresentationFM2\Views\Home\Details.cshtml"
                                                        Write(Model.adult);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    <p style=\"font-weight: bold;\">DataSource:</p>");
#nullable restore
#line 28 "J:\01 Work\01-Development\AUB\AUBassignment\PresentationFM2\Views\Home\Details.cshtml"
                                                             Write(Model.genres == null ? "Local SQL Database" : "Cloud API");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n");
#nullable restore
#line 31 "J:\01 Work\01-Development\AUB\AUBassignment\PresentationFM2\Views\Home\Details.cshtml"
                 if (Model.genres != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div><p><a");
            BeginWriteAttribute("href", " href=\"", 1367, "\"", 1425, 2);
            WriteAttributeValue("", 1374, "/home/SaveMovieDetails?MovieID=", 1374, 31, true);
#nullable restore
#line 33 "J:\01 Work\01-Development\AUB\AUBassignment\PresentationFM2\Views\Home\Details.cshtml"
WriteAttributeValue("", 1405, Model.id.ToString(), 1405, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-lg\">Save to Local Database</a></p></div>\r\n");
#nullable restore
#line 34 "J:\01 Work\01-Development\AUB\AUBassignment\PresentationFM2\Views\Home\Details.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div><p><a");
            BeginWriteAttribute("href", " href=\"", 1586, "\"", 1646, 2);
            WriteAttributeValue("", 1593, "/home/DeleteMovieDetails?MovieID=", 1593, 33, true);
#nullable restore
#line 37 "J:\01 Work\01-Development\AUB\AUBassignment\PresentationFM2\Views\Home\Details.cshtml"
WriteAttributeValue("", 1626, Model.id.ToString(), 1626, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-lg\" style=\"background: #ba1616;    border-color: #ba1616;\">Delete from Local Database</a></p></div>\r\n");
#nullable restore
#line 38 "J:\01 Work\01-Development\AUB\AUBassignment\PresentationFM2\Views\Home\Details.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n\r\n        </td>\r\n    </tr>\r\n\r\n</table>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61baf1a49dfff1d8124208c677300255be97a1ae9340", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Movie Details</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
        }

        .container {
            max-width: 800px;
            margin: 0 auto;
            padding: 20px;
        }

        .movie-poster {
            max-width: 100%;
            height: auto;
            margin-bottom: 20px;
        }

        .movie-info {
            margin-bottom: 20px;
        }

            .movie-info h1 {
                font-size: 24px;
                margin-bottom: 10px;
            }

            .movie-info p {
                font-size: 16px;
                margin: 5px 0;
            }
    </style>
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61baf1a49dfff1d8124208c677300255be97a1ae11150", async() => {
                WriteLiteral("\r\n\r\n   \r\n\r\n");
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
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataModels.Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
