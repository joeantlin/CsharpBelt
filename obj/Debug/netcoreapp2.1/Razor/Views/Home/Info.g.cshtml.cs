#pragma checksum "C:\coding_dojo\C#\BeltExam\Views\Home\Info.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2289ce8fcb78f909cab19e4db29a046c51c9995"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Info), @"mvc.1.0.view", @"/Views/Home/Info.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Info.cshtml", typeof(AspNetCore.Views_Home_Info))]
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
#line 1 "C:\coding_dojo\C#\BeltExam\Views\_ViewImports.cshtml"
using BeltExam;

#line default
#line hidden
#line 2 "C:\coding_dojo\C#\BeltExam\Views\_ViewImports.cshtml"
using BeltExam.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2289ce8fcb78f909cab19e4db29a046c51c9995", @"/Views/Home/Info.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a84119000702c45f5036e3e300b27d647b6aca13", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Info : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 140, true);
            WriteLiteral("<nav>\r\n    <h1>Dojo activity Center</h1>\r\n\r\n    <div><a href=\"/\">Home</a></div>\r\n    <div><a href=\"/logout\">Logout</a></div>\r\n</nav>\r\n\r\n<h2>");
            EndContext();
            BeginContext(141, 23, false);
#line 8 "C:\coding_dojo\C#\BeltExam\Views\Home\Info.cshtml"
Write(ViewBag.ThisEvent.Title);

#line default
#line hidden
            EndContext();
            BeginContext(164, 31, true);
            WriteLiteral("</h2>\r\n\r\n<p>Event Coordinator: ");
            EndContext();
            BeginContext(196, 35, false);
#line 10 "C:\coding_dojo\C#\BeltExam\Views\Home\Info.cshtml"
                 Write(ViewBag.ThisEvent.Creator.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(231, 22, true);
            WriteLiteral("</p>\r\n<p>Description: ");
            EndContext();
            BeginContext(254, 29, false);
#line 11 "C:\coding_dojo\C#\BeltExam\Views\Home\Info.cshtml"
           Write(ViewBag.ThisEvent.Description);

#line default
#line hidden
            EndContext();
            BeginContext(283, 36, true);
            WriteLiteral("</p>\r\n\r\n<p>Participants:</p>\r\n<ul>\r\n");
            EndContext();
#line 15 "C:\coding_dojo\C#\BeltExam\Views\Home\Info.cshtml"
     foreach(Participant i in @ViewBag.ThisEvent.Participants)
    {

#line default
#line hidden
            BeginContext(390, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(403, 16, false);
#line 17 "C:\coding_dojo\C#\BeltExam\Views\Home\Info.cshtml"
       Write(i.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(419, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 18 "C:\coding_dojo\C#\BeltExam\Views\Home\Info.cshtml"
    }

#line default
#line hidden
            BeginContext(433, 9, true);
            WriteLiteral("</ul>\r\n\r\n");
            EndContext();
#line 21 "C:\coding_dojo\C#\BeltExam\Views\Home\Info.cshtml"
  
    bool isTrue = false;
    

#line default
#line hidden
#line 23 "C:\coding_dojo\C#\BeltExam\Views\Home\Info.cshtml"
     foreach(var k in @ViewBag.ThisEvent.Participants)
    {
        if(k.UserId == @ViewBag.ThisUser.Id)
        {
            isTrue = true;
        }
    }

#line default
#line hidden
#line 29 "C:\coding_dojo\C#\BeltExam\Views\Home\Info.cshtml"
     
    if (isTrue)
    {

#line default
#line hidden
            BeginContext(662, 18, true);
            WriteLiteral("        <button><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 680, "\'", 750, 1);
#line 32 "C:\coding_dojo\C#\BeltExam\Views\Home\Info.cshtml"
WriteAttributeValue("", 687, string.Format("/deleteparticipant/{0}", @ViewBag.ThisEvent.Id), 687, 63, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(751, 24, true);
            WriteLiteral(">Unjoin</a></button>  \r\n");
            EndContext();
#line 33 "C:\coding_dojo\C#\BeltExam\Views\Home\Info.cshtml"
    }
    else {
        if (@ViewBag.ThisEvent.UserID ==  @ViewBag.ThisUser.Id)
        {

#line default
#line hidden
            BeginContext(870, 22, true);
            WriteLiteral("            <button><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 892, "\"", 928, 2);
            WriteAttributeValue("", 899, "/delete/", 899, 8, true);
#line 37 "C:\coding_dojo\C#\BeltExam\Views\Home\Info.cshtml"
WriteAttributeValue("", 907, ViewBag.ThisEvent.Id, 907, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(929, 32, true);
            WriteLiteral(">Cancel Activity</a></button> \r\n");
            EndContext();
#line 38 "C:\coding_dojo\C#\BeltExam\Views\Home\Info.cshtml"
        } 
        else {

#line default
#line hidden
            BeginContext(989, 22, true);
            WriteLiteral("            <button><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1011, "\"", 1055, 2);
            WriteAttributeValue("", 1018, "/newparticipant/", 1018, 16, true);
#line 40 "C:\coding_dojo\C#\BeltExam\Views\Home\Info.cshtml"
WriteAttributeValue("", 1034, ViewBag.ThisEvent.Id, 1034, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1056, 20, true);
            WriteLiteral(">Join</a></button>\r\n");
            EndContext();
#line 41 "C:\coding_dojo\C#\BeltExam\Views\Home\Info.cshtml"
            
        }
    }

#line default
#line hidden
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