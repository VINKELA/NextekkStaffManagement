#pragma checksum "C:\Users\owner\Desktop\New folder\Nextekk\Views\Home\StaffPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70ae3f834b7d30cf2e2c83e54de9a1e17a312da3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_StaffPage), @"mvc.1.0.view", @"/Views/Home/StaffPage.cshtml")]
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
#line 1 "C:\Users\owner\Desktop\New folder\Nextekk\Views\_ViewImports.cshtml"
using NextekkStaffManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\owner\Desktop\New folder\Nextekk\Views\_ViewImports.cshtml"
using NextekkStaffManager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70ae3f834b7d30cf2e2c83e54de9a1e17a312da3", @"/Views/Home/StaffPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1b8e6408857594c449ee0de1d2c5dd55f7ee33a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_StaffPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NextekkStaffManager.Models.StaffPageModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "editStaff", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\owner\Desktop\New folder\Nextekk\Views\Home\StaffPage.cshtml"
  
    ViewData["Title"] = @Model.Firstname;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

        <table class=""table table-striped"">
                <tr>
                    <th colspan =""2""> BASIC INFORMATION</th>
                </tr>
                <tr>
                    <td rowspan=""3""><img src=""\img\avatar.png""></td>
                </tr>            
                <tr>
                    <td>");
#nullable restore
#line 15 "C:\Users\owner\Desktop\New folder\Nextekk\Views\Home\StaffPage.cshtml"
                   Write(Model.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 15 "C:\Users\owner\Desktop\New folder\Nextekk\Views\Home\StaffPage.cshtml"
                                    Write(Model.Lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>");
#nullable restore
#line 18 "C:\Users\owner\Desktop\New folder\Nextekk\Views\Home\StaffPage.cshtml"
                   Write(Model.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n\r\n                <tr>\r\n                    <td>Date of Birth</td><td>");
#nullable restore
#line 22 "C:\Users\owner\Desktop\New folder\Nextekk\Views\Home\StaffPage.cshtml"
                                         Write(Model.Dob);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n\r\n                <tr>\r\n                    <td>Marital status</td><td>");
#nullable restore
#line 26 "C:\Users\owner\Desktop\New folder\Nextekk\Views\Home\StaffPage.cshtml"
                                          Write(Model.MaritalStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Number of children</td><td>");
#nullable restore
#line 29 "C:\Users\owner\Desktop\New folder\Nextekk\Views\Home\StaffPage.cshtml"
                                              Write(Model.NoOfChildren);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n\r\n        </table>\r\n\r\n        <table class=\"table table-striped\">\r\n                <tr><th colspan =\"2\"> OTHER INFORMATION</th></tr>\r\n                <tr>\r\n                    <td>Status</td>\r\n");
#nullable restore
#line 38 "C:\Users\owner\Desktop\New folder\Nextekk\Views\Home\StaffPage.cshtml"
                      
                        if(@Model.Active == "Active")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"green\">");
#nullable restore
#line 41 "C:\Users\owner\Desktop\New folder\Nextekk\Views\Home\StaffPage.cshtml"
                                         Write(Model.Active);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 42 "C:\Users\owner\Desktop\New folder\Nextekk\Views\Home\StaffPage.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"red\">Not Active</td>                           \r\n");
#nullable restore
#line 46 "C:\Users\owner\Desktop\New folder\Nextekk\Views\Home\StaffPage.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n                <tr>\r\n                    <td>Day of Employment</td><td>");
#nullable restore
#line 50 "C:\Users\owner\Desktop\New folder\Nextekk\Views\Home\StaffPage.cshtml"
                                             Write(Model.DayEmployed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n\r\n                <tr>\r\n                    <td>Highest Qualification</td><td>");
#nullable restore
#line 54 "C:\Users\owner\Desktop\New folder\Nextekk\Views\Home\StaffPage.cshtml"
                                                 Write(Model.HighestQualification);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n\r\n                <tr>\r\n                    <td>Institution</td><td>");
#nullable restore
#line 58 "C:\Users\owner\Desktop\New folder\Nextekk\Views\Home\StaffPage.cshtml"
                                       Write(Model.School);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Time of Service</td><td>\r\n");
#nullable restore
#line 62 "C:\Users\owner\Desktop\New folder\Nextekk\Views\Home\StaffPage.cshtml"
                           
                             if(!string.IsNullOrEmpty(Model.DayEmployed))
                             {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                 <span>");
#nullable restore
#line 65 "C:\Users\owner\Desktop\New folder\Nextekk\Views\Home\StaffPage.cshtml"
                                  Write(Model.DayEmployed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 66 "C:\Users\owner\Desktop\New folder\Nextekk\Views\Home\StaffPage.cshtml"
                             }

                             if(!string.IsNullOrEmpty(Model.TimeOfService))
                             {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                 <span>to ");
#nullable restore
#line 70 "C:\Users\owner\Desktop\New folder\Nextekk\Views\Home\StaffPage.cshtml"
                                     Write(Model.TimeOfService);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 71 "C:\Users\owner\Desktop\New folder\Nextekk\Views\Home\StaffPage.cshtml"
                             }
                             else if(!string.IsNullOrEmpty(Model.DayEmployed))
                             {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                 <span>to Current</span>\r\n");
#nullable restore
#line 75 "C:\Users\owner\Desktop\New folder\Nextekk\Views\Home\StaffPage.cshtml"
                             }
                         

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Position</td><td>");
#nullable restore
#line 80 "C:\Users\owner\Desktop\New folder\Nextekk\Views\Home\StaffPage.cshtml"
                                    Write(Model.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Promoted Last on</td><td>");
#nullable restore
#line 83 "C:\Users\owner\Desktop\New folder\Nextekk\Views\Home\StaffPage.cshtml"
                                            Write(Model.LastPromoted);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Annual Salary</td><td>");
#nullable restore
#line 86 "C:\Users\owner\Desktop\New folder\Nextekk\Views\Home\StaffPage.cshtml"
                                         Write(Model.AnnualSalary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Subordinates</td>\r\n                        <td>\r\n                   \r\n");
#nullable restore
#line 92 "C:\Users\owner\Desktop\New folder\Nextekk\Views\Home\StaffPage.cshtml"
                              
                                if(Model.Subordinates.Count() ==  0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div>No Subordinates</div>\r\n");
#nullable restore
#line 96 "C:\Users\owner\Desktop\New folder\Nextekk\Views\Home\StaffPage.cshtml"
                                }
                                foreach(var p in Model.Subordinates)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div");
            BeginWriteAttribute("value", " value=", 3555, "", 3574, 1);
#nullable restore
#line 99 "C:\Users\owner\Desktop\New folder\Nextekk\Views\Home\StaffPage.cshtml"
WriteAttributeValue("", 3562, p.Firstname, 3562, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 99 "C:\Users\owner\Desktop\New folder\Nextekk\Views\Home\StaffPage.cshtml"
                                                       Write(p.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 99 "C:\Users\owner\Desktop\New folder\Nextekk\Views\Home\StaffPage.cshtml"
                                                                    Write(p.Lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 100 "C:\Users\owner\Desktop\New folder\Nextekk\Views\Home\StaffPage.cshtml"
                                }

                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n\r\n                </tr>\r\n\r\n        </table>\r\n        <div class=\"row\">\r\n                <div class=\"col\">  \r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70ae3f834b7d30cf2e2c83e54de9a1e17a312da314324", async() => {
                WriteLiteral("\r\n                        <input name=\"Id\"");
                BeginWriteAttribute("value", " value=", 3928, "", 3944, 1);
#nullable restore
#line 111 "C:\Users\owner\Desktop\New folder\Nextekk\Views\Home\StaffPage.cshtml"
WriteAttributeValue("", 3935, Model.Id, 3935, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"hidden\"/>\r\n                        <button type=\"submit\" class=\"btn btn-primary\">Edit</button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col\">  \r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70ae3f834b7d30cf2e2c83e54de9a1e17a312da316582", async() => {
                WriteLiteral("\r\n                        <button type=\"submit\" class=\"btn btn-primary\">Back</button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n        </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NextekkStaffManager.Models.StaffPageModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
