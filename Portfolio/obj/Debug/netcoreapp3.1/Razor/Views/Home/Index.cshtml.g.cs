#pragma checksum "C:\Users\Isaiah Young\RiderProjects\Online Portfolio\Portfolio\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f44abe18ce6ad9155acb00fdf62ecc2aec764ca6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Isaiah Young\RiderProjects\Online Portfolio\Portfolio\Views\_ViewImports.cshtml"
using Portfolio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Isaiah Young\RiderProjects\Online Portfolio\Portfolio\Views\_ViewImports.cshtml"
using Portfolio.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f44abe18ce6ad9155acb00fdf62ecc2aec764ca6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14b089f288ca91d7bb6cf58ee5e119daea2fa329", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ArtGallery>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Style/CSS/Main.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("fadeOutPage()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "About", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Contact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: #fafafa; height: max-content"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Isaiah Young\RiderProjects\Online Portfolio\Portfolio\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Isaiah Young";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<meta name=”viewport” content=”width=device-width, initial-scale=1″>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f44abe18ce6ad9155acb00fdf62ecc2aec764ca67115", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f44abe18ce6ad9155acb00fdf62ecc2aec764ca67377", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script src=\"lib/jquery/dist/jquery.min.js\"></script>\r\n    <script src=\"js/site.js\"></script>\r\n    \r\n    <style>\r\n       \r\n        \r\n    </style>\r\n    \r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f44abe18ce6ad9155acb00fdf62ecc2aec764ca69528", async() => {
                WriteLiteral("\r\n\r\n<div id=\"navbar\">\r\n    <div style=\"width: 100%; height: 100%; background-color: #1b1e21; opacity: .5\">\r\n        <div id=\"navs\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f44abe18ce6ad9155acb00fdf62ecc2aec764ca69943", async() => {
                    WriteLiteral("HOME");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f44abe18ce6ad9155acb00fdf62ecc2aec764ca611681", async() => {
                    WriteLiteral("ABOUT");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f44abe18ce6ad9155acb00fdf62ecc2aec764ca613421", async() => {
                    WriteLiteral("CONTACT");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
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
</div>

<div id=""pageWrapper"">
<div id=""intro-section"" style=""transform: translateY(-5vh)"">
    <div id=""nameSection"">
        <h1>ISAIAH YOUNG</h1>
        <h2>
            <span class=""careerLink"" style=""animation-delay: 1s"" onclick=""scrollToElement('softwareTitle')"">FULL STACK DEVELOPER</span> |
            <span class=""careerLink"" style=""animation-delay: 1.2s"" onclick=""scrollToElement('engineerTitle')"">ENGINEER</span> |
            <span class=""careerLink"" style=""animation-delay: 1.4s"" onclick=""scrollToElement('leaderTitle')"">LEADER</span> |
            <span class=""careerLink"" style=""animation-delay: 1.6s"" onclick=""scrollToElement('artistTitle')"">ARTIST</span>
        </h2>
        <p>
            With a degree in Mechanical Engineering (graduate Nov. 2020), over a year of experience writing clean, full
            stack code for technical subject matter, and a highly developed artistic talent, I bring a well-rounded ability
            to turn technical needs");
                WriteLiteral(" into efficient code and an intuitive and aesthetic user experience.\r\n        </p>\r\n    </div>\r\n    <div id=\"intro-image-container\"></div>\r\n</div>\r\n\r\n\r\n<div>\r\n");
                WriteLiteral(@"
    <div id=""softwareTitle"" class=""sectionTitle"">
        <h1>DEVELOPER</h1>
    </div>

    <div style=""width: 95vw; margin: auto; display: flex; justify-content: space-around"">

        <div class=""career-row"" id=""softwareSection"" style=""width: 55%"">
            <div>
                <h1 id=""software-development"">SOFTWARE DEVELOPER</h1>
                <h2>ENERGY SYSTEMS LABORATORY <br/> TEXAS A&M</h2>
                <div");
                BeginWriteAttribute("style", " style=\"", 2557, "\"", 2565, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    <div>
                        <p>The Lab focuses on energy-related research, energy efficiency, and emissions reduction. Working
                            here requires not only an ability to code but a working knowledge of mechanical engineering.
                            As a software developer at the ESL, I take great care in crafting efficient, readable code
                            that gives as much to our users as it does to my fellow developers. Being a part of the ESL
                            software team means:
                        </p>
                    </div>
                    <div>
                        <p class=""bullet"">&#8226; Learning to write full stack code for data analysis and visualization</p>
                        <p class=""bullet"">&#8226; Developing front-end, user-oriented interfaces</p>
                        <p class=""bullet"">&#8226; Debugging, maintaining, and improving self-documenting legacy code</p>
                       ");
                WriteLiteral(@" <p class=""bullet"">&#8226; Collaborating with a team of engineers to design unit-test software</p>
                    </div>
                </div>
            </div>
        </div>

        <div class=""career-row"" id=""softwareSkills"">
            <h2 style=""text-align: center"">SKILLS</h2>
            <div>
                <span>C#</span>
                <div class=""skillLevel"">
                    <div style=""width: 90%""></div>
                </div>
            </div>
            <div>
                <span>JavaScript</span>
                <div class=""skillLevel"">
                    <div style=""width: 70%""></div>
                </div>
            </div>
            <div>
                <span>HTML5</span>
                <div class=""skillLevel"">
                    <div style=""width: 100%""></div>
                </div>
            </div>
            <div>
                <span>CSS3</span>
                <div class=""skillLevel"">
                    <div style=""width: 100%""><");
                WriteLiteral(@"/div>
                </div>
            </div>
            <div>
                <span>jQuery</span>
                <div class=""skillLevel"">
                    <div style=""width: 40%""></div>
                </div>
            </div>
            <div>
                <span>Python</span>
                <div class=""skillLevel"">
                    <div style=""width: 20%""></div>
                </div>
            </div>
            <div>
                <span>SQL Database</span>
                <div class=""skillLevel"">
                    <div style=""width: 10%""></div>
                </div>
            </div>
        </div>
    </div>

    <div id=""engineerTitle"" class=""sectionTitle"">
        <h1>ENGINEER</h1>
    </div>

    <div style=""width: 95vw; margin: auto; display: flex"">
        <div class=""career-row"" id=""engProjects"">
            <h2>PROJECTS</h2>
            <div id=""biaxialLink"">BIAXIAL TENSILE TESTER</div>
            <div id=""scissorLink"">SCISSOR LIFT</div>
   ");
                WriteLiteral(@"         <div id=""solarLink"">SOLAR HEATED OVEN</div>
            <div style=""margin-bottom: 0"" id=""marbleLink"">MARBLE SORTER</div>
        </div>

        <div class=""career-row"" id=""engineeringSection"">
            <div>
                <h1 id=""engineering"">MECHANICAL ENGINEER</h1>
                <h2>TEXAS A&M UNIVERSITY</h2>
                <p>As a student in one of the top Mechanical Engineering programs in the country, I learn to combine
                    the multi-disciplinary knowledge required of a mechanical engineer with the soft skills and 
                    communication required to be part of an effective team. Several team projects, hands-on lab
                    experience, and an extensive courseload have worked to shape me into the careful, logical, and 
                    diligent engineer I am today. The subjects in which I excel most and have a strong interest include:</p>
                <div id=""engSubjects"">
                    <div class=""engSubject"">THERMODYNAMICS");
                WriteLiteral(@"</div>
                    <div class=""engSubject"">MATERIALS SCIENCE</div>
                    <div class=""engSubject"">SOLAR ENERGY</div>
                    <div class=""engSubject"" id=""designSubject"">MECHANICAL DESIGN</div>
                </div>
            </div>
        </div>
    </div>

    <div id=""leaderTitle"" class=""sectionTitle"">
        <h1>LEADER</h1>
    </div>


    <div style=""margin-top: 5vh; padding: 5vh"">
        <div id=""leaderSection"">
            <div class=""leaderRole"" id=""buccRole"">
                <div id=""buccPic"" class=""circleImg""></div>
                <h1>BUCC BIG EVENT</h1>
                <h2>President | Project ID</h2>
                <p>
                    A community outreach program in which I worked directly with the city of Brenham, Blinn College, and
                    clients to complete 5 projects throughout the community. I supervised sites, executives, funding, and
                    60 volunteers to complete all projects on time and under bud");
                WriteLiteral(@"get.
                </p>
                <p>
                    More info can be found <a href=""https://www.blinn.edu/news/2017/04/blinn-brenham-students-give-back-to-community-buccaneer-big-event.html"" 
                                              target=""_blank"" style=""color: cornflowerblue; cursor: pointer"">here</a>
                </p>
            </div>
            <div class=""leaderRole"" id=""barkRole"">
                <div id=""barkPic"" class=""circleImg""></div>
                <h1>BARK IN THE PARK</h1>
                <H2>Co-founder | Executive</h2>
                <p>
                    A community outreach program which increased the local shelter's adoption rates by 30%. I managed all
                    program aspects including operation, revenue, and volunteer acquisition for 1 year. The program was 
                    praised by the Director of Environmental Health for Kerrville, Raymond Garcia, for its initiative and effectiveness.
                </p>
                <p>
  ");
                WriteLiteral(@"                  More info can be found at BITP's <a href=""https://www.facebook.com/barkintheparkktx/"" target=""_blank"">facebook</a>
                </p>
            </div>
            <div class=""leaderRole"" id=""mcRole"">
                <div id=""mcPic"" class=""circleImg""></div>
                <h1>McDONALDs</h1>
                <H2>Manager</h2>
                <p>
                    As a manager I was tasked with leading a crew of around 15 people much older than myself in a fast-paced
                    environment. This job required that I engage in conflict resolution with customers and co-workers almost
                    everyday. I also trained around 20 new workers and ensured above-and-beyond customer service.

                </p>
            </div>

        </div>
    </div>

    <div id=""artistTitle"" class=""sectionTitle"">
        <h1>ARTIST</h1>
    </div>

    <div class=""career-row"" id=""artistSection"">
        <div id=""slider"">
            <button style=""left: -10%;"" id");
                WriteLiteral("=\"scrollArtLeft\" class=\"scrollArtButton\">&#60;</button>\r\n            <button style=\"right: -10%;\" id=\"scrollArtRight\" class=\"scrollArtButton\">&#62;</button>\r\n            <div style=\"overflow: hidden\">\r\n                <div id=\"slide-track\">\r\n\r\n");
#nullable restore
#line 223 "C:\Users\Isaiah Young\RiderProjects\Online Portfolio\Portfolio\Views\Home\Index.cshtml"
                     foreach (var piece in Model)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div");
                BeginWriteAttribute("id", " id=\"", 10080, "\"", 10096, 1);
#nullable restore
#line 225 "C:\Users\Isaiah Young\RiderProjects\Online Portfolio\Portfolio\Views\Home\Index.cshtml"
WriteAttributeValue("", 10085, piece.Name, 10085, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"slide\" onclick=\"showArtModal(this.id)\">\r\n                            <img class=\"slideImg\"");
                BeginWriteAttribute("src", " src=\"", 10195, "\"", 10217, 1);
#nullable restore
#line 226 "C:\Users\Isaiah Young\RiderProjects\Online Portfolio\Portfolio\Views\Home\Index.cshtml"
WriteAttributeValue("", 10201, piece.Directory, 10201, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 10218, "\"", 10224, 0);
                EndWriteAttribute();
                WriteLiteral("/>\r\n                        </div>\r\n");
#nullable restore
#line 228 "C:\Users\Isaiah Young\RiderProjects\Online Portfolio\Portfolio\Views\Home\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"slide\">\r\n                        <img class=\"slideImg\" src=\"../Style/Images/code.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 10403, "\"", 10409, 0);
                EndWriteAttribute();
                WriteLiteral(@"/>
                    </div>
                </div>
            </div>
        </div>
        <p>
            Being an artist has developed my creativity, refined my attention for detail, and increased my patience. 
            While my drawings are realistic, I enjoy making simple graphics to capture complex ideas and I am currently
            learning Adobe Illustrator to practice and create such works. My artistic approach towards websites is minimilist
            with a desire to make software tools and technical matter pleasing to read and use.
        </p>
    </div>

</div>





<div id=""artModal"" class=""modal"">
    <div class=""modal-content"">
        <span id=""closeArt"">&times;</span>
        <div id=""modalSlider"">
            <button id=""scrollModalLeft"" class=""scrollArtButton"">&#60;</button>
            <button id=""scrollModalRight"" class=""scrollArtButton"">&#62;</button>
            <div style=""overflow: hidden"">
                <div id=""modal-slide-track"">
");
#nullable restore
#line 258 "C:\Users\Isaiah Young\RiderProjects\Online Portfolio\Portfolio\Views\Home\Index.cshtml"
                     foreach (var piece in Model)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div");
                BeginWriteAttribute("id", " id=", 11524, "", 11539, 1);
#nullable restore
#line 260 "C:\Users\Isaiah Young\RiderProjects\Online Portfolio\Portfolio\Views\Home\Index.cshtml"
WriteAttributeValue("", 11528, piece.Name, 11528, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"modalSlide\">\r\n                            <img class=\"modalImg\"");
                BeginWriteAttribute("src", " src=\"", 11610, "\"", 11632, 1);
#nullable restore
#line 261 "C:\Users\Isaiah Young\RiderProjects\Online Portfolio\Portfolio\Views\Home\Index.cshtml"
WriteAttributeValue("", 11616, piece.Directory, 11616, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 11633, "\"", 11639, 0);
                EndWriteAttribute();
                WriteLiteral("/>\r\n                        </div>\r\n");
#nullable restore
#line 263 "C:\Users\Isaiah Young\RiderProjects\Online Portfolio\Portfolio\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"modalSlide\">\r\n                        <img class=\"modalImg\" src=\"../Style/Images/code.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 11821, "\"", 11827, 0);
                EndWriteAttribute();
                WriteLiteral("/>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n</div>\r\n\r\n<script>\r\n(function(){\r\n    autoScrollArt();\r\n    setTimeout(arguments.callee, 2000);\r\n})();\r\n</script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ArtGallery>> Html { get; private set; }
    }
}
#pragma warning restore 1591
