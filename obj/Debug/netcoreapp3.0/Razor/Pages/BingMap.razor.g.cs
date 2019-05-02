#pragma checksum "c:\Users\macivoce\WebApplication1\Pages\BingMap.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b91060a6179fe751019e68903a52447d43504ac5"
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
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/bingmap")]
    public class BingMap : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, "<h2>Bing address validation demo</h2>\r\n");
            builder.AddMarkupContent(1, "<label>Client Address:</label>\r\n");
            builder.OpenElement(2, "input");
            builder.AddAttribute(3, "type", "text");
            builder.AddAttribute(4, "class", "form-control");
            builder.AddAttribute(5, "onblur", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIFocusEventArgs>(this, OpenModal));
            builder.AddAttribute(6, "id", "inputClientAddress");
            builder.AddAttribute(7, "placeholder", "Search Address");
            builder.CloseElement();
            builder.AddMarkupContent(8, "\r\n\r\n\r\n");
            builder.AddMarkupContent(9, @"<div class=""modal fade"" id=""addressModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
  <div class=""modal-dialog"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"" id=""exampleModalLabel"">Address Modal</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
          
      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
        <button type=""button"" class=""btn btn-primary"">Save changes</button>
      </div>
    </div>
  </div>
</div>");
        }
        #pragma warning restore 1998
#line 31 "c:\Users\macivoce\WebApplication1\Pages\BingMap.razor"
            

    public async Task<object> OpenModal()
    {
        //first let's call the Bing service
        var address = await BingMapService.GetAddresses();

        return JsRuntime.InvokeAsync<object>("BingMap.OpenModalOnSearch"); 
    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BingMapService BingMapService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
