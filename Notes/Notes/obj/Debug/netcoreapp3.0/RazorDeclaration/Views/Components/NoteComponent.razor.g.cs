#pragma checksum "C:\repos\Examples\Notes\Notes\Views\Components\NoteComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "585608207d5712e86db3c0cf9ae680c173a2af03"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Notes.Views.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\repos\Examples\Notes\Notes\Views\Components\NoteComponent.razor"
using Notes.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\repos\Examples\Notes\Notes\Views\Components\NoteComponent.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\repos\Examples\Notes\Notes\Views\Components\NoteComponent.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
    public partial class NoteComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\repos\Examples\Notes\Notes\Views\Components\NoteComponent.razor"
       

    protected override void OnInitialized()
    {
        Model = new Note
        {
            Id = 1,
            Description = "Hello, World!",
            Title = "Hello"
        };
    }

    public void OnMouseOver() => Class = "clr-selected";

    public void OnMouseOut() => Class = "";

    public Task OnMouseClick(int noteId) => OnMouseClicked.InvokeAsync(noteId);

    [Parameter]
    public Note Model { get; set; }

    [Parameter]
    public EventCallback<int> OnMouseClicked { get; set; }

    public string Class { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
