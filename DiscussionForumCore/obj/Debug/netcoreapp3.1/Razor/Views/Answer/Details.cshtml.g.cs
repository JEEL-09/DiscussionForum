#pragma checksum "C:\Users\Jeel Faldu\Downloads\WDDN_DotNetCore_Project_CE021_CE140-master\WDDN_DotNetCore_Project_CE021_CE140\DiscussionForumCore\Views\Answer\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "269f082abdd92f47e06e9a79daf91ed0aa07f2d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Answer_Details), @"mvc.1.0.view", @"/Views/Answer/Details.cshtml")]
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
#line 2 "C:\Users\Jeel Faldu\Downloads\WDDN_DotNetCore_Project_CE021_CE140-master\WDDN_DotNetCore_Project_CE021_CE140\DiscussionForumCore\Views\_ViewImports.cshtml"
using DiscussionForumCore.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jeel Faldu\Downloads\WDDN_DotNetCore_Project_CE021_CE140-master\WDDN_DotNetCore_Project_CE021_CE140\DiscussionForumCore\Views\_ViewImports.cshtml"
using DiscussionForumCore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Jeel Faldu\Downloads\WDDN_DotNetCore_Project_CE021_CE140-master\WDDN_DotNetCore_Project_CE021_CE140\DiscussionForumCore\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Jeel Faldu\Downloads\WDDN_DotNetCore_Project_CE021_CE140-master\WDDN_DotNetCore_Project_CE021_CE140\DiscussionForumCore\Views\Answer\Details.cshtml"
using DiscussionForumCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"269f082abdd92f47e06e9a79daf91ed0aa07f2d8", @"/Views/Answer/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"079974e6c8bf931aa6bed9c121dd4082f50e9aba", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Answer_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("loginImg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("post_img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width:100%;max-height:15vw;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-height: 5vh; text-align: center;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Answer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "C:\Users\Jeel Faldu\Downloads\WDDN_DotNetCore_Project_CE021_CE140-master\WDDN_DotNetCore_Project_CE021_CE140\DiscussionForumCore\Views\Answer\Details.cshtml"
  
    var PhotoPath = "~/images/" + Model.question1.PhotoPath;
    string userId = ViewBag.UserId;
    var ProfilePicPath = "~/images/" + Model.question1.ProfilePic;
    var ProfilePicPath1 = "~/images/" + Model.answer1.ProfilePic;

    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h3 style=""display:flex;align-items:center;justify-content:center;""> Question </h3>


<div style=""margin-top:1rem"">
    <div class=""row justify-content-center m-1"">
        <div class=""col-sm-8"">
            <div class=""card"">
                <div class=""card-header"" style=""display:flex ; "">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "269f082abdd92f47e06e9a79daf91ed0aa07f2d87259", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 21 "C:\Users\Jeel Faldu\Downloads\WDDN_DotNetCore_Project_CE021_CE140-master\WDDN_DotNetCore_Project_CE021_CE140\DiscussionForumCore\Views\Answer\Details.cshtml"
                                                  WriteLiteral(ProfilePicPath);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 21 "C:\Users\Jeel Faldu\Downloads\WDDN_DotNetCore_Project_CE021_CE140-master\WDDN_DotNetCore_Project_CE021_CE140\DiscussionForumCore\Views\Answer\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    <div class=\"post_user\">\n                        <h5>");
#nullable restore
#line 23 "C:\Users\Jeel Faldu\Downloads\WDDN_DotNetCore_Project_CE021_CE140-master\WDDN_DotNetCore_Project_CE021_CE140\DiscussionForumCore\Views\Answer\Details.cshtml"
                       Write(Model.question1.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                    </div>\n\n                </div>\n                <div class=\"card-body\">\n                    <h4>");
#nullable restore
#line 28 "C:\Users\Jeel Faldu\Downloads\WDDN_DotNetCore_Project_CE021_CE140-master\WDDN_DotNetCore_Project_CE021_CE140\DiscussionForumCore\Views\Answer\Details.cshtml"
                   Write(Model.question1.question);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                </div>\n");
#nullable restore
#line 30 "C:\Users\Jeel Faldu\Downloads\WDDN_DotNetCore_Project_CE021_CE140-master\WDDN_DotNetCore_Project_CE021_CE140\DiscussionForumCore\Views\Answer\Details.cshtml"
                 if (Model.question1.PhotoPath != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card-body text-center\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "269f082abdd92f47e06e9a79daf91ed0aa07f2d810937", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\Jeel Faldu\Downloads\WDDN_DotNetCore_Project_CE021_CE140-master\WDDN_DotNetCore_Project_CE021_CE140\DiscussionForumCore\Views\Answer\Details.cshtml"
                                                              WriteLiteral(PhotoPath);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 33 "C:\Users\Jeel Faldu\Downloads\WDDN_DotNetCore_Project_CE021_CE140-master\WDDN_DotNetCore_Project_CE021_CE140\DiscussionForumCore\Views\Answer\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </div>\n");
#nullable restore
#line 35 "C:\Users\Jeel Faldu\Downloads\WDDN_DotNetCore_Project_CE021_CE140-master\WDDN_DotNetCore_Project_CE021_CE140\DiscussionForumCore\Views\Answer\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
</div>

<h3 style=""display:flex;align-items:center;justify-content:center;""> Answer </h3>


<div>
    
    <div class=""row justify-content-center m-1"">
        <div class=""col-sm-8"">
            <div class=""card"" >
                <div class=""card-header"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "269f082abdd92f47e06e9a79daf91ed0aa07f2d813884", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\Jeel Faldu\Downloads\WDDN_DotNetCore_Project_CE021_CE140-master\WDDN_DotNetCore_Project_CE021_CE140\DiscussionForumCore\Views\Answer\Details.cshtml"
                                                  WriteLiteral(ProfilePicPath1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 50 "C:\Users\Jeel Faldu\Downloads\WDDN_DotNetCore_Project_CE021_CE140-master\WDDN_DotNetCore_Project_CE021_CE140\DiscussionForumCore\Views\Answer\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    <div class=\"post_user\">\n                        <h5>");
#nullable restore
#line 52 "C:\Users\Jeel Faldu\Downloads\WDDN_DotNetCore_Project_CE021_CE140-master\WDDN_DotNetCore_Project_CE021_CE140\DiscussionForumCore\Views\Answer\Details.cshtml"
                       Write(Model.answer1.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                    </div>\n                </div>\n                <div class=\"card-body\" style=\"display: flex; \">\n                    <h5>");
#nullable restore
#line 56 "C:\Users\Jeel Faldu\Downloads\WDDN_DotNetCore_Project_CE021_CE140-master\WDDN_DotNetCore_Project_CE021_CE140\DiscussionForumCore\Views\Answer\Details.cshtml"
                   Write(Model.answer1.answer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                    <br />\n                </div>\n            </div>\n        </div>\n    </div>\n\n</div>\n<div>\n");
#nullable restore
#line 65 "C:\Users\Jeel Faldu\Downloads\WDDN_DotNetCore_Project_CE021_CE140-master\WDDN_DotNetCore_Project_CE021_CE140\DiscussionForumCore\Views\Answer\Details.cshtml"
     if (Model.answer1.appUserId == @userId)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "269f082abdd92f47e06e9a79daf91ed0aa07f2d817577", async() => {
                WriteLiteral("<i class=\"bi bi-pencil-square\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "C:\Users\Jeel Faldu\Downloads\WDDN_DotNetCore_Project_CE021_CE140-master\WDDN_DotNetCore_Project_CE021_CE140\DiscussionForumCore\Views\Answer\Details.cshtml"
                                                                                                    WriteLiteral(Model.answer1.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 68 "C:\Users\Jeel Faldu\Downloads\WDDN_DotNetCore_Project_CE021_CE140-master\WDDN_DotNetCore_Project_CE021_CE140\DiscussionForumCore\Views\Answer\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    &nbsp;&nbsp;&nbsp;\n");
#nullable restore
#line 70 "C:\Users\Jeel Faldu\Downloads\WDDN_DotNetCore_Project_CE021_CE140-master\WDDN_DotNetCore_Project_CE021_CE140\DiscussionForumCore\Views\Answer\Details.cshtml"
     if (Model.answer1.appUserId == @userId)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "269f082abdd92f47e06e9a79daf91ed0aa07f2d820819", async() => {
                WriteLiteral(" <i class=\"bi bi-trash-fill\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "C:\Users\Jeel Faldu\Downloads\WDDN_DotNetCore_Project_CE021_CE140-master\WDDN_DotNetCore_Project_CE021_CE140\DiscussionForumCore\Views\Answer\Details.cshtml"
                                                                                                      WriteLiteral(Model.answer1.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 73 "C:\Users\Jeel Faldu\Downloads\WDDN_DotNetCore_Project_CE021_CE140-master\WDDN_DotNetCore_Project_CE021_CE140\DiscussionForumCore\Views\Answer\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    &nbsp;&nbsp;&nbsp;\n</div>\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
