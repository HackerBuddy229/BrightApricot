#pragma checksum "C:\Users\Rasmus\repos\BrightApricot\BrightApricot\BrightApricot\Client\Pages\RecipeListItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d91a8af630a33cb3f793496b7a6a671dadec544e"
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
#line 1 "C:\Users\Rasmus\repos\BrightApricot\BrightApricot\BrightApricot\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rasmus\repos\BrightApricot\BrightApricot\BrightApricot\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Rasmus\repos\BrightApricot\BrightApricot\BrightApricot\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Rasmus\repos\BrightApricot\BrightApricot\BrightApricot\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Rasmus\repos\BrightApricot\BrightApricot\BrightApricot\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Rasmus\repos\BrightApricot\BrightApricot\BrightApricot\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Rasmus\repos\BrightApricot\BrightApricot\BrightApricot\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Rasmus\repos\BrightApricot\BrightApricot\BrightApricot\Client\_Imports.razor"
using BrightApricot.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Rasmus\repos\BrightApricot\BrightApricot\BrightApricot\Client\_Imports.razor"
using BrightApricot.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Rasmus\repos\BrightApricot\BrightApricot\BrightApricot\Client\_Imports.razor"
using BrightApricot.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Rasmus\repos\BrightApricot\BrightApricot\BrightApricot\Client\_Imports.razor"
using BrightApricot.Client.Interfaces;

#line default
#line hidden
#nullable disable
    public partial class RecipeListItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "RecipeListItem");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "img");
            __builder.AddAttribute(4, "src", 
#nullable restore
#line 2 "C:\Users\Rasmus\repos\BrightApricot\BrightApricot\BrightApricot\Client\Pages\RecipeListItem.razor"
               Recipe.DataUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(5, "alt", "photo");
            __builder.AddAttribute(6, "class", "item-content recipe-image");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "recipe-card-info");
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "div");
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "h3");
            __builder.AddAttribute(14, "class", "item-content");
            __builder.AddContent(15, 
#nullable restore
#line 5 "C:\Users\Rasmus\repos\BrightApricot\BrightApricot\BrightApricot\Client\Pages\RecipeListItem.razor"
                                      Recipe.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenComponent<BrightApricot.Client.Pages.AccentBar>(18);
            __builder.AddAttribute(19, "Title", "View");
            __builder.AddAttribute(20, "Onclick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 7 "C:\Users\Rasmus\repos\BrightApricot\BrightApricot\BrightApricot\Client\Pages\RecipeListItem.razor"
                                         OnSelected

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    \r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\Rasmus\repos\BrightApricot\BrightApricot\BrightApricot\Client\Pages\RecipeListItem.razor"
       
    [Parameter]
    public Recipe Recipe { get; set; }

    [Parameter]
    public EventCallback OnSelected { get;set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591