#pragma checksum "C:\Users\Jeel Faldu\Downloads\WDDN_DotNetCore_Project_CE021_CE140-master\WDDN_DotNetCore_Project_CE021_CE140\DiscussionForumCore\Views\Account\ViewQuestions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9ffdd305b87ffa07f02594ae3eb186b1c01836b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ViewQuestions), @"mvc.1.0.view", @"/Views/Account/ViewQuestions.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9ffdd305b87ffa07f02594ae3eb186b1c01836b", @"/Views/Account/ViewQuestions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"079974e6c8bf931aa6bed9c121dd4082f50e9aba", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_ViewQuestions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DiscussionForumCore.Models.AppUser>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-left:5%;width:6vw;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width:100%;max-height:15vw;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/images/Default.jpg", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Jeel Faldu\Downloads\WDDN_DotNetCore_Project_CE021_CE140-master\WDDN_DotNetCore_Project_CE021_CE140\DiscussionForumCore\Views\Account\ViewQuestions.cshtml"
  
    ViewData["Title"] = "Details";
    var PhotoPath = "~/images/" + Model.ProfilePic;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div class=\"row  justify-content-center\">\n    <h4 style=\"display:flex;align-items:center;justify-content:center;\">\n        User Profile\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9ffdd305b87ffa07f02594ae3eb186b1c01836b6526", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 12 "C:\Users\Jeel Faldu\Downloads\WDDN_DotNetCore_Project_CE021_CE140-master\WDDN_DotNetCore_Project_CE021_CE140\DiscussionForumCore\Views\Account\ViewQuestions.cshtml"
                                                                                                                  WriteLiteral(Model.Id);

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
            WriteLiteral("\n    </h4>\n    <hr />\n\n    <div style=\"display:flex;\">\n");
#nullable restore
#line 17 "C:\Users\Jeel Faldu\Downloads\WDDN_DotNetCore_Project_CE021_CE140-master\WDDN_DotNetCore_Project_CE021_CE140\DiscussionForumCore\Views\Account\ViewQuestions.cshtml"
         if (Model.ProfilePic != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card-body text-center\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d9ffdd305b87ffa07f02594ae3eb186b1c01836b9655", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "C:\Users\Jeel Faldu\Downloads\WDDN_DotNetCore_Project_CE021_CE140-master\WDDN_DotNetCore_Project_CE021_CE140\DiscussionForumCore\Views\Account\ViewQuestions.cshtml"
                                                      WriteLiteral(PhotoPath);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 20 "C:\Users\Jeel Faldu\Downloads\WDDN_DotNetCore_Project_CE021_CE140-master\WDDN_DotNetCore_Project_CE021_CE140\DiscussionForumCore\Views\Account\ViewQuestions.cshtml"
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
            WriteLiteral("\n            </div>\n");
#nullable restore
#line 22 "C:\Users\Jeel Faldu\Downloads\WDDN_DotNetCore_Project_CE021_CE140-master\WDDN_DotNetCore_Project_CE021_CE140\DiscussionForumCore\Views\Account\ViewQuestions.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card-body text-center\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d9ffdd305b87ffa07f02594ae3eb186b1c01836b12355", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#nullable restore
#line 26 "C:\Users\Jeel Faldu\Downloads\WDDN_DotNetCore_Project_CE021_CE140-master\WDDN_DotNetCore_Project_CE021_CE140\DiscussionForumCore\Views\Account\ViewQuestions.cshtml"
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
            WriteLiteral("\n            </div>\n");
#nullable restore
#line 28 "C:\Users\Jeel Faldu\Downloads\WDDN_DotNetCore_Project_CE021_CE140-master\WDDN_DotNetCore_Project_CE021_CE140\DiscussionForumCore\Views\Account\ViewQuestions.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n\n    <div style=\"display:flex;flex-direction:column;justify-content:center;align-items:center\">\n        <h5>Name</h5>\n        ");
#nullable restore
#line 33 "C:\Users\Jeel Faldu\Downloads\WDDN_DotNetCore_Project_CE021_CE140-master\WDDN_DotNetCore_Project_CE021_CE140\DiscussionForumCore\Views\Account\ViewQuestions.cshtml"
   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n        <h5>UserName</h5>\n        ");
#nullable restore
#line 35 "C:\Users\Jeel Faldu\Downloads\WDDN_DotNetCore_Project_CE021_CE140-master\WDDN_DotNetCore_Project_CE021_CE140\DiscussionForumCore\Views\Account\ViewQuestions.cshtml"
   Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n        <h5>Email</h5>\n        ");
#nullable restore
#line 37 "C:\Users\Jeel Faldu\Downloads\WDDN_DotNetCore_Project_CE021_CE140-master\WDDN_DotNetCore_Project_CE021_CE140\DiscussionForumCore\Views\Account\ViewQuestions.cshtml"
   Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n        <h5>University</h5>\n        ");
#nullable restore
#line 39 "C:\Users\Jeel Faldu\Downloads\WDDN_DotNetCore_Project_CE021_CE140-master\WDDN_DotNetCore_Project_CE021_CE140\DiscussionForumCore\Views\Account\ViewQuestions.cshtml"
   Write(Model.University);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n        <h5>Phone Number</h5>\n        ");
#nullable restore
#line 41 "C:\Users\Jeel Faldu\Downloads\WDDN_DotNetCore_Project_CE021_CE140-master\WDDN_DotNetCore_Project_CE021_CE140\DiscussionForumCore\Views\Account\ViewQuestions.cshtml"
   Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n\n    </div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DiscussionForumCore.Models.AppUser> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
