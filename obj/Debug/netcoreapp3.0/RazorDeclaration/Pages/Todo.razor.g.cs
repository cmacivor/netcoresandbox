#pragma checksum "c:\Users\macivoce\BlazorDemo\Pages\Todo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "136936e46c55a30a7d8def001166b9029de664e3"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorDemo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Components.Forms;
    using Microsoft.AspNetCore.Components.Layouts;
    using Microsoft.AspNetCore.Components.Routing;
    using Microsoft.JSInterop;
    using BlazorDemo.Shared;
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/todo")]
    public class Todo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 18 "c:\Users\macivoce\BlazorDemo\Pages\Todo.razor"
            
    private IList<TodoItem> todos = new List<TodoItem>();
    private string newTodo;

    private void AddTodo()
    {
        if (!string.IsNullOrWhiteSpace(newTodo))
        {
            todos.Add(new TodoItem { Title = newTodo});
            newTodo = string.Empty;
        } 
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
