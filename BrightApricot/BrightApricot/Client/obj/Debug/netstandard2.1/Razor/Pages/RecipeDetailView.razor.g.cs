#pragma checksum "/home/hackerbuddy/repos/BrightApricot/BrightApricot/BrightApricot/Client/Pages/RecipeDetailView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab50ebbd73982b222c5a3b7023d19141c74eb017"
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
    public partial class RecipeDetailView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "RecipeDetailView");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "img");
            __builder.AddAttribute(4, "src", 
#nullable restore
#line 2 "/home/hackerbuddy/repos/BrightApricot/BrightApricot/BrightApricot/Client/Pages/RecipeDetailView.razor"
               Recipe.DataUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(5, "alt", 
#nullable restore
#line 2 "/home/hackerbuddy/repos/BrightApricot/BrightApricot/BrightApricot/Client/Pages/RecipeDetailView.razor"
                                     Recipe.Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(6, "class", "RecipeImage");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "RecipeDetailView-text");
            __builder.AddMarkupContent(10, "\n        ");
            __builder.OpenElement(11, "h3");
            __builder.AddContent(12, 
#nullable restore
#line 4 "/home/hackerbuddy/repos/BrightApricot/BrightApricot/BrightApricot/Client/Pages/RecipeDetailView.razor"
             Recipe.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n        ");
            __builder.OpenElement(14, "article");
            __builder.AddContent(15, 
#nullable restore
#line 5 "/home/hackerbuddy/repos/BrightApricot/BrightApricot/BrightApricot/Client/Pages/RecipeDetailView.razor"
                  Recipe.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, " \n    <hr style=\"width: 95%; margin-bottom: 5px;\">\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "/home/hackerbuddy/repos/BrightApricot/BrightApricot/BrightApricot/Client/Pages/RecipeDetailView.razor"
       
    [Parameter]
    public Recipe Recipe { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
