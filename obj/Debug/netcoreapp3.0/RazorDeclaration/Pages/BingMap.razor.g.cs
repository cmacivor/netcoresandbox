#pragma checksum "c:\Users\macivoce\WebApplication1\Pages\BingMap.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce550cbedc3fc3a64dd4ffa424e9407e2f462ef1"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
        }
        #pragma warning restore 1998
#line 51 "c:\Users\macivoce\WebApplication1\Pages\BingMap.razor"
            
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
