#pragma checksum "C:\Users\macivoce\BlazorDemo\Pages\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5532eff908492fd6b5c88608188b45eaf45844d"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 61 "C:\Users\macivoce\BlazorDemo\Pages\Register.razor"
            
    private string userName = string.Empty;
    private string password = string.Empty;
    private string confirmPassword = string.Empty;
    private string userRole = string.Empty;
    private string errorMessage = string.Empty;

    private Dictionary<string, string[]> modelStateErrors = new Dictionary<string, string[]>();

    private async void RegisterUser()
    {
        if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
        {
            await JsRuntime.InvokeAsync<object>("Register.OpenError");
            
            errorMessage = " Please enter all fields";
            this.StateHasChanged();

            return;
        }

        if (password != confirmPassword )
        {
            await JsRuntime.InvokeAsync<object>("Register.OpenError");
            
            errorMessage = "Passwords don't matchs";
            this.StateHasChanged();

            return;
        }

        //save the user here
        var user = new Registration {
            userName = userName,
            password = password,
            confirmPassword = confirmPassword,
            UserRole = userRole
        };

       var errors = await RegistrationService.RegisterUser(user);

       if (errors != null && errors.ModelState.Any())
       {       
            modelStateErrors = errors.ModelState;

            await JsRuntime.InvokeAsync<object>("Register.OpenError");

            //get the page in sync with the server- like refreshing a page in a traditional app. This is necessary because without it, the div opens without the populated error message
            //in Blazor, every single thing seems to cause the page to fire again- even making an an API call
            this.StateHasChanged();
       }
       else
       {
            errorMessage = "Registered!";

            await JsRuntime.InvokeAsync<object>("Register.OpenError");

            this.StateHasChanged();
       }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RegistrationService RegistrationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
