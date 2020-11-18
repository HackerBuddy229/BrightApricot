// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 1 "/home/hackerbuddy/repos/BrightApricot/BrightApricot/BrightApricot/Client/Pages/ActionButton.razor"
using BrightApricot.Client.Enums;

#line default
#line hidden
#nullable disable
    public partial class ActionButton : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "/home/hackerbuddy/repos/BrightApricot/BrightApricot/BrightApricot/Client/Pages/ActionButton.razor"
       
    [Parameter]
    public EventCallback CreateAction { get; set; }
    [Parameter]
    public EventCallback EditAction { get; set; }
    [Parameter]
    public EventCallback SaveAction { get; set; }

    [Parameter]
    public ActionTypes Action { get; set; }

    ///<summary>
    /// allows external refresh of the icon
    /// </summary>
    public void UpdateAction() => StateHasChanged();

    ///<summary>
    ///interperts what icon to show
    /// </summary>
    /// <returns>The "class" corresponding to the correct fa icon</returns>
    private string ActionSymbol => Action switch {
        ActionTypes.Create => "fa-plus",
        ActionTypes.Edit => "fa-pencil-alt",
        ActionTypes.Save => "fa-check",
        _ => "fa-exclamation-triangle"
    };

    ///<summary>
    /// the event handler for the click action
    /// </summary>
    private async void TriggerAction()
    {
        switch (Action)
        {
            case ActionTypes.Edit:
                await EditAction.InvokeAsync(null);
                break;

            case ActionTypes.Create:
                await CreateAction.InvokeAsync(null);
                break;

            case ActionTypes.Save:
                await SaveAction.InvokeAsync(null);
                break;
            default:
                break;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
