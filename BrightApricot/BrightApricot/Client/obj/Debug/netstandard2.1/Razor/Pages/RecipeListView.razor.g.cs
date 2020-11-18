#pragma checksum "/home/hackerbuddy/repos/BrightApricot/BrightApricot/BrightApricot/Client/Pages/RecipeListView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0b28b2be951c06651ae2d493f6b8a17debbd63b"
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
    public partial class RecipeListView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "RecipeListView");
#nullable restore
#line 2 "/home/hackerbuddy/repos/BrightApricot/BrightApricot/BrightApricot/Client/Pages/RecipeListView.razor"
     foreach (var recipe in Recipes)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BrightApricot.Client.Pages.RecipeListItem>(2);
            __builder.AddAttribute(3, "Recipe", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BrightApricot.Shared.Models.Recipe>(
#nullable restore
#line 4 "/home/hackerbuddy/repos/BrightApricot/BrightApricot/BrightApricot/Client/Pages/RecipeListView.razor"
                                 recipe

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 4 "/home/hackerbuddy/repos/BrightApricot/BrightApricot/BrightApricot/Client/Pages/RecipeListView.razor"
                                                       async () => await SelectRecipe(recipe)

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 5 "/home/hackerbuddy/repos/BrightApricot/BrightApricot/BrightApricot/Client/Pages/RecipeListView.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "/home/hackerbuddy/repos/BrightApricot/BrightApricot/BrightApricot/Client/Pages/RecipeListView.razor"
       
    [Parameter]
    public IEnumerable<Recipe> Recipes { get; set; } = new List<Recipe>();
    
    [Parameter]
    public Recipe RecipeSelected { get;set; }

    [Parameter]
    public EventCallback<Recipe> OnRecipeSelected { get; set; }


    ///<summary>
    /// local event handler for clickAction
    /// </summary>
    private async Task SelectRecipe(Recipe recipe)
    {
        await OnRecipeSelected.InvokeAsync(recipe);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
