#pragma checksum "C:\repos\Examples\Notes\Notes\Components\NoteComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bbdc62361a52b487af7dfa8ac4db23c1d8a4218"
// <auto-generated/>
#pragma warning disable 1591
namespace Notes.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\repos\Examples\Notes\Notes\Components\NoteComponent.razor"
using Notes.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\repos\Examples\Notes\Notes\Components\NoteComponent.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\repos\Examples\Notes\Notes\Components\NoteComponent.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
    public partial class NoteComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", (
#nullable restore
#line 6 "C:\repos\Examples\Notes\Notes\Components\NoteComponent.razor"
             Class

#line default
#line hidden
#nullable disable
            ) + " border-bottom");
            __builder.AddAttribute(2, "onmouseover", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\repos\Examples\Notes\Notes\Components\NoteComponent.razor"
                                                OnMouseOver

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "onmouseout", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\repos\Examples\Notes\Notes\Components\NoteComponent.razor"
                                                                          OnMouseOut

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\repos\Examples\Notes\Notes\Components\NoteComponent.razor"
                                                                                                  ()=>OnMouseClick(Model.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "pag-action", "Edit");
            __builder.AddAttribute(6, "page-model", 
#nullable restore
#line 7 "C:\repos\Examples\Notes\Notes\Components\NoteComponent.razor"
                                    Model.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "note-title");
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.AddContent(11, 
#nullable restore
#line 9 "C:\repos\Examples\Notes\Notes\Components\NoteComponent.razor"
         Model.Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "note-body");
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.AddContent(17, 
#nullable restore
#line 12 "C:\repos\Examples\Notes\Notes\Components\NoteComponent.razor"
         Model.Description

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\repos\Examples\Notes\Notes\Components\NoteComponent.razor"
       

    public void OnMouseOver() => Class = "clr-selected";

    public void OnMouseOut() => Class = "";

    public Task OnMouseClick(int noteId) => OnClickNoteCallBack.InvokeAsync(Model);

    [Parameter]
    public Note Model { get; set; }

    [Parameter]
    public EventCallback<Note> OnClickNoteCallBack { get; set; }

    public string Class { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
