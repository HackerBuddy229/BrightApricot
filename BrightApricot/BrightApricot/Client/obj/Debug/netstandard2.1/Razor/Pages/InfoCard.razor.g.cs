#pragma checksum "/home/hackerbuddy/repos/BrightApricot/BrightApricot/BrightApricot/Client/Pages/InfoCard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4f12673cae60bd3b9dc2a2b14b0688ee6cbf1cc"
// <auto-generated/>
#pragma warning disable 1591
namespace BrightApricot.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/hackerbuddy/repos/BrightApricot/BrightApricot/BrightApricot/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/hackerbuddy/repos/BrightApricot/BrightApricot/BrightApricot/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/hackerbuddy/repos/BrightApricot/BrightApricot/BrightApricot/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/hackerbuddy/repos/BrightApricot/BrightApricot/BrightApricot/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/hackerbuddy/repos/BrightApricot/BrightApricot/BrightApricot/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/hackerbuddy/repos/BrightApricot/BrightApricot/BrightApricot/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/hackerbuddy/repos/BrightApricot/BrightApricot/BrightApricot/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/hackerbuddy/repos/BrightApricot/BrightApricot/BrightApricot/Client/_Imports.razor"
using BrightApricot.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/hackerbuddy/repos/BrightApricot/BrightApricot/BrightApricot/Client/_Imports.razor"
using BrightApricot.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/hackerbuddy/repos/BrightApricot/BrightApricot/BrightApricot/Client/_Imports.razor"
using BrightApricot.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/hackerbuddy/repos/BrightApricot/BrightApricot/BrightApricot/Client/_Imports.razor"
using BrightApricot.Client.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/home/hackerbuddy/repos/BrightApricot/BrightApricot/BrightApricot/Client/Pages/InfoCard.razor"
using BrightApricot.Client.Enums;

#line default
#line hidden
#nullable disable
    public partial class InfoCard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "InfoCard");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddMarkupContent(4, "\n        ");
            __builder.OpenElement(5, "h1");
            __builder.AddContent(6, 
#nullable restore
#line 4 "/home/hackerbuddy/repos/BrightApricot/BrightApricot/BrightApricot/Client/Pages/InfoCard.razor"
             Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n        <hr>\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddMarkupContent(10, "\n        ");
            __builder.AddContent(11, 
#nullable restore
#line 8 "/home/hackerbuddy/repos/BrightApricot/BrightApricot/BrightApricot/Client/Pages/InfoCard.razor"
         Description

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(12, "\n        <br>\n");
#nullable restore
#line 10 "/home/hackerbuddy/repos/BrightApricot/BrightApricot/BrightApricot/Client/Pages/InfoCard.razor"
         if (ListType == ListType.Ordered) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "            ");
            __builder.OpenElement(14, "ol");
            __builder.AddMarkupContent(15, "\n");
#nullable restore
#line 12 "/home/hackerbuddy/repos/BrightApricot/BrightApricot/BrightApricot/Client/Pages/InfoCard.razor"
                 foreach (var item in List){

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "                    ");
            __builder.OpenElement(17, "li");
            __builder.AddContent(18, " ");
            __builder.AddContent(19, 
#nullable restore
#line 13 "/home/hackerbuddy/repos/BrightApricot/BrightApricot/BrightApricot/Client/Pages/InfoCard.razor"
                          item

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(20, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n");
#nullable restore
#line 14 "/home/hackerbuddy/repos/BrightApricot/BrightApricot/BrightApricot/Client/Pages/InfoCard.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n");
#nullable restore
#line 16 "/home/hackerbuddy/repos/BrightApricot/BrightApricot/BrightApricot/Client/Pages/InfoCard.razor"
        } else {

#line default
#line hidden
#nullable disable
            __builder.AddContent(24, "            ");
            __builder.OpenElement(25, "ul");
            __builder.AddMarkupContent(26, "\n");
#nullable restore
#line 18 "/home/hackerbuddy/repos/BrightApricot/BrightApricot/BrightApricot/Client/Pages/InfoCard.razor"
                 foreach (var item in List)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "                    ");
            __builder.OpenElement(28, "li");
            __builder.AddContent(29, " ");
            __builder.AddContent(30, 
#nullable restore
#line 20 "/home/hackerbuddy/repos/BrightApricot/BrightApricot/BrightApricot/Client/Pages/InfoCard.razor"
                          item

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(31, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n");
#nullable restore
#line 21 "/home/hackerbuddy/repos/BrightApricot/BrightApricot/BrightApricot/Client/Pages/InfoCard.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(33, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n");
#nullable restore
#line 23 "/home/hackerbuddy/repos/BrightApricot/BrightApricot/BrightApricot/Client/Pages/InfoCard.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(35, "        \n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n    \n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "/home/hackerbuddy/repos/BrightApricot/BrightApricot/BrightApricot/Client/Pages/InfoCard.razor"
       
    [Parameter]
    public string Title { get; set; }

    [Parameter]
    public string Description { get; set; } = string.Empty;

    [Parameter]
    public IEnumerable<string> List { get; set; } = new List<string>();

    [Parameter]
    public ListType ListType { get; set; } = ListType.Unordered;


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591