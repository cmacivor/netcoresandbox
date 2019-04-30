#pragma checksum "c:\Users\macivoce\WebApplication1\Pages\CaseForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c84e6af0d63e4a3b1c9599372f31985b74b00812"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication1.Pages
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
    using WebApplication1.Shared;
    using WebApplication1.Data;
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/caseform")]
    public class CaseForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, "<h3>Case Form Sandbox</h3>\r\n\r\n");
            builder.AddMarkupContent(1, "<button type=\"button\" class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#exampleModal\">\r\n  Launch demo modal\r\n</button>\r\n<br>\r\n");
            builder.OpenElement(2, "div");
            builder.AddAttribute(3, "class", "modal fade");
            builder.AddAttribute(4, "id", "exampleModal");
            builder.AddAttribute(5, "tabindex", "-1");
            builder.AddAttribute(6, "role", "dialog");
            builder.AddAttribute(7, "aria-labelledby", "exampleModalLabel");
            builder.AddAttribute(8, "aria-hidden", "true");
            builder.AddMarkupContent(9, "\r\n  ");
            builder.OpenElement(10, "div");
            builder.AddAttribute(11, "class", "modal-dialog");
            builder.AddAttribute(12, "role", "document");
            builder.AddMarkupContent(13, "\r\n    ");
            builder.OpenElement(14, "div");
            builder.AddAttribute(15, "class", "modal-content");
            builder.AddMarkupContent(16, "\r\n      ");
            builder.AddMarkupContent(17, @"<div class=""modal-header"">
        <h5 class=""modal-title"" id=""exampleModalLabel"">Modal title</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      ");
            builder.OpenElement(18, "div");
            builder.AddAttribute(19, "class", "modal-body");
            builder.AddMarkupContent(20, "\r\n          ");
            builder.OpenElement(21, "div");
            builder.AddAttribute(22, "class", "row");
            builder.AddMarkupContent(23, "\r\n              ");
            builder.OpenElement(24, "div");
            builder.AddAttribute(25, "class", "col-md-12");
            builder.AddMarkupContent(26, "\r\n                  ");
            builder.OpenElement(27, "div");
            builder.AddAttribute(28, "class", "form-group");
            builder.AddMarkupContent(29, "\r\n                      ");
            builder.AddMarkupContent(30, "<label for=\"inputPlacementCharges\">Placement Charges*</label>\r\n                      ");
            builder.OpenElement(31, "input");
            builder.AddAttribute(32, "type", "text");
            builder.AddAttribute(33, "onblur", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIFocusEventArgs>(this, GetOffensesBySearchString));
            builder.AddAttribute(34, "class", "form-control");
            builder.AddAttribute(35, "id", "inputPlacementCharges");
            builder.AddAttribute(36, "placeholder", "Pick Charge Code");
            builder.AddAttribute(37, "value", Microsoft.AspNetCore.Components.BindMethods.GetValue(searchParam));
            builder.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchParam = __value, searchParam));
            builder.CloseElement();
            builder.AddMarkupContent(39, "\r\n                  ");
            builder.CloseElement();
            builder.AddMarkupContent(40, "\r\n              ");
            builder.CloseElement();
            builder.AddMarkupContent(41, "\r\n          ");
            builder.CloseElement();
            builder.AddMarkupContent(42, "\r\n          ");
            builder.OpenElement(43, "div");
            builder.AddAttribute(44, "class", "row");
            builder.AddMarkupContent(45, "\r\n              ");
            builder.OpenElement(46, "div");
            builder.AddAttribute(47, "class", "col-m-12");
            builder.AddMarkupContent(48, "\r\n                ");
            builder.OpenElement(49, "ul");
            builder.AddAttribute(50, "id", "ulSearchResult");
            builder.AddAttribute(51, "class", "list-group");
            builder.AddMarkupContent(52, "\r\n");
#line 33 "c:\Users\macivoce\WebApplication1\Pages\CaseForm.razor"
                     if (offenses != null && offenses.Any())
                    {
                        

#line default
#line hidden
#line 35 "c:\Users\macivoce\WebApplication1\Pages\CaseForm.razor"
                         foreach (var offense in offenses)
                        {   
                            var item = offense;

#line default
#line hidden
            builder.AddContent(53, "                            ");
            builder.OpenElement(54, "li");
            builder.AddAttribute(55, "class", "list-group-item");
            builder.OpenElement(56, "span");
            builder.AddAttribute(57, "style", "cursor: pointer;");
            builder.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, e => @RemoveItem(@offense.Description)));
            builder.AddAttribute(59, "class", "oi oi-x");
            builder.CloseElement();
            builder.AddContent(60, offense.Description);
            builder.AddContent(61, " ");
            builder.CloseElement();
            builder.AddMarkupContent(62, "\r\n");
#line 39 "c:\Users\macivoce\WebApplication1\Pages\CaseForm.razor"
                        }

#line default
#line hidden
#line 39 "c:\Users\macivoce\WebApplication1\Pages\CaseForm.razor"
                         
                    }                 

#line default
#line hidden
            builder.AddContent(63, "                ");
            builder.CloseElement();
            builder.AddMarkupContent(64, "            \r\n              ");
            builder.CloseElement();
            builder.AddMarkupContent(65, "\r\n          ");
            builder.CloseElement();
            builder.AddMarkupContent(66, "\r\n      ");
            builder.CloseElement();
            builder.AddMarkupContent(67, "\r\n      ");
            builder.AddMarkupContent(68, "<div class=\"modal-footer\">\r\n        <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Close</button>\r\n        <button type=\"button\" class=\"btn btn-primary\">Save changes</button>\r\n      </div>\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(69, "\r\n  ");
            builder.CloseElement();
            builder.AddMarkupContent(70, "\r\n");
            builder.CloseElement();
            builder.AddMarkupContent(71, "\r\n<br>\r\n");
            builder.AddMarkupContent(72, "<h4>Lifecycle events</h4>\r\n<br>\r\n");
#line 55 "c:\Users\macivoce\WebApplication1\Pages\CaseForm.razor"
 foreach (var evt in LifecycleEvents) { 

#line default
#line hidden
            builder.AddContent(73, "    ");
            builder.OpenElement(74, "li");
            builder.AddContent(75, evt);
            builder.CloseElement();
            builder.AddMarkupContent(76, "\r\n");
#line 57 "c:\Users\macivoce\WebApplication1\Pages\CaseForm.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 60 "c:\Users\macivoce\WebApplication1\Pages\CaseForm.razor"
            
    List<string> LifecycleEvents { get; set; } = new List<string>();

    List<Offense> offenses;
    private string searchParam;

    private string itemToRemove;

    protected override void OnInit()
    {
        LifecycleEvents.Add("OnInit");
    }

    protected override void OnAfterRender()
    {
        LifecycleEvents.Add("OnAfterRender");
    }

    public async Task<List<Offense>> GetOffensesBySearchString()
    {
        if (offenses != null && offenses.Any())
        {
            offenses.Clear();
        }

        if (!string.IsNullOrEmpty(searchParam))
        {
            offenses = await OffenseService.GetOffenses();

            offenses = offenses.Where(x => offenses.Any(y => x.Description.ToLower().Contains(searchParam))).ToList();
            searchParam = string.Empty;
        }
        
        return offenses;
    }


    public void RemoveItem(string test)
    {
       var itemToRemove = offenses.FirstOrDefault(x => x.Description == test);

       offenses.Remove(itemToRemove); 
    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OffenseService OffenseService { get; set; }
    }
}
#pragma warning restore 1591