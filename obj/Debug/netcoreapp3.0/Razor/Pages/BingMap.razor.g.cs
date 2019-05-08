#pragma checksum "c:\Users\macivoce\BlazorDemo\Pages\BingMap.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b71b381b020b2f932cf85df00e09b3991d4e086"
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
            builder.OpenElement(9, "div");
            builder.AddAttribute(10, "class", "modal fade");
            builder.AddAttribute(11, "id", "addressModal");
            builder.AddAttribute(12, "tabindex", "-1");
            builder.AddAttribute(13, "role", "dialog");
            builder.AddAttribute(14, "aria-labelledby", "exampleModalLabel");
            builder.AddAttribute(15, "aria-hidden", "true");
            builder.AddMarkupContent(16, "\r\n  ");
            builder.OpenElement(17, "div");
            builder.AddAttribute(18, "class", "modal-dialog");
            builder.AddAttribute(19, "role", "document");
            builder.AddMarkupContent(20, "\r\n    ");
            builder.OpenElement(21, "div");
            builder.AddAttribute(22, "class", "modal-content");
            builder.AddMarkupContent(23, "\r\n      ");
            builder.AddMarkupContent(24, @"<div class=""modal-header"">
        <h5 class=""modal-title"" id=""exampleModalLabel"">Address Modal</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      ");
            builder.OpenElement(25, "div");
            builder.AddAttribute(26, "class", "modal-body");
            builder.AddMarkupContent(27, "\r\n          ");
            builder.OpenElement(28, "div");
            builder.AddAttribute(29, "class", "row");
            builder.AddMarkupContent(30, "\r\n             ");
            builder.OpenElement(31, "div");
            builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, CloseModal));
            builder.AddAttribute(33, "style", "cursor:pointer");
            builder.AddAttribute(34, "class", "alert alert-primary");
            builder.AddMarkupContent(35, "\r\n                ");
            builder.AddContent(36, RetrievedAddress.addressLine);
            builder.AddMarkupContent(37, "\r\n             ");
            builder.CloseElement();
            builder.AddMarkupContent(38, "\r\n          ");
            builder.CloseElement();
            builder.AddMarkupContent(39, "\r\n      ");
            builder.CloseElement();
            builder.AddMarkupContent(40, "\r\n      ");
            builder.AddMarkupContent(41, "<div class=\"modal-footer\">\r\n        <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Close</button>\r\n        <button type=\"button\" class=\"btn btn-primary\">Save changes</button>\r\n      </div>\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(42, "\r\n  ");
            builder.CloseElement();
            builder.AddMarkupContent(43, "\r\n");
            builder.CloseElement();
            builder.AddMarkupContent(44, "\r\n<br>\r\n");
            builder.AddMarkupContent(45, "<h4>You selected</h4>\r\n");
            builder.OpenElement(46, "div");
            builder.AddAttribute(47, "class", "row");
            builder.AddMarkupContent(48, "\r\n   ");
            builder.OpenElement(49, "div");
            builder.AddAttribute(50, "class", "col-md-6");
            builder.AddMarkupContent(51, "\r\n     ");
            builder.OpenElement(52, "div");
            builder.AddAttribute(53, "class", "form-group");
            builder.AddMarkupContent(54, "\r\n       ");
            builder.AddMarkupContent(55, "<label><strong>Retrieved Address Line</strong></label>\r\n       ");
            builder.OpenElement(56, "label");
            builder.AddContent(57, AddressForDisplay.addressLine);
            builder.CloseElement();
            builder.AddMarkupContent(58, "\r\n     ");
            builder.CloseElement();
            builder.AddMarkupContent(59, "\r\n   ");
            builder.CloseElement();
            builder.AddMarkupContent(60, "\r\n   ");
            builder.OpenElement(61, "div");
            builder.AddAttribute(62, "class", "col-md-6");
            builder.AddMarkupContent(63, "\r\n     ");
            builder.OpenElement(64, "div");
            builder.AddAttribute(65, "class", "form-group");
            builder.AddMarkupContent(66, "\r\n       ");
            builder.AddMarkupContent(67, "<label><strong>Country</strong></label>\r\n       ");
            builder.OpenElement(68, "label");
            builder.AddContent(69, AddressForDisplay.countryRegion);
            builder.AddContent(70, " ");
            builder.CloseElement();
            builder.AddMarkupContent(71, "\r\n     ");
            builder.CloseElement();
            builder.AddMarkupContent(72, "\r\n   ");
            builder.CloseElement();
            builder.AddMarkupContent(73, "\r\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 51 "c:\Users\macivoce\BlazorDemo\Pages\BingMap.razor"
            
  //not sure, but I think these need to be private
    private BingServer.Address RetrievedAddress = new BingServer.Address();

    private BingServer.Address AddressForDisplay = new BingServer.Address();

    public async Task<object> OpenModal()
    {
        //first let's call the Bing service
        var address = await BingMapService.GetAddresses();

        RetrievedAddress = address.resourceSets.FirstOrDefault().resources.FirstOrDefault().address;

        return JsRuntime.InvokeAsync<object>("BingMap.OpenModalOnSearch"); 
    }

    //Note: whenever running a javascript method, it needs to be async. Not sure if it needs to return a Task<object>, but this is the only way I can get it to work right now.
    private async Task<object> CloseModal()
    {
       //this is apparently all that's required to populate a separate set of fields on the page when this method is invoked. The RetrievedAddress object still has its values
       AddressForDisplay = RetrievedAddress;

       return  await JsRuntime.InvokeAsync<object>("BingMap.HideModal"); 
    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BingMapService BingMapService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
