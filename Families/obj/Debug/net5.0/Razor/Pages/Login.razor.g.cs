#pragma checksum "C:\Users\Gosia\RiderProjects\AssignmentFamilies\Families\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4aa6ae485d2634d77c2b61febea37242b983093"
// <auto-generated/>
#pragma warning disable 1591
namespace LoginComponent
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Gosia\RiderProjects\AssignmentFamilies\Families\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gosia\RiderProjects\AssignmentFamilies\Families\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Gosia\RiderProjects\AssignmentFamilies\Families\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Gosia\RiderProjects\AssignmentFamilies\Families\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Gosia\RiderProjects\AssignmentFamilies\Families\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Gosia\RiderProjects\AssignmentFamilies\Families\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Gosia\RiderProjects\AssignmentFamilies\Families\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Gosia\RiderProjects\AssignmentFamilies\Families\_Imports.razor"
using Families;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Gosia\RiderProjects\AssignmentFamilies\Families\_Imports.razor"
using Families.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Gosia\RiderProjects\AssignmentFamilies\Families\Pages\Login.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Gosia\RiderProjects\AssignmentFamilies\Families\Pages\Login.razor"
using WebFamilies_Assignment.Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "maincontainer");
            __builder.AddAttribute(2, "b-jvg13b0ihw");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container-login");
            __builder.AddAttribute(5, "b-jvg13b0ihw");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "container-leftside");
            __builder.AddAttribute(8, "b-jvg13b0ihw");
            __builder.AddMarkupContent(9, "<label class=\"loginlabel\" b-jvg13b0ihw>Username</label>\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "form-group");
            __builder.AddAttribute(12, "b-jvg13b0ihw");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "type", "text");
            __builder.AddAttribute(15, "placeholder", "user name");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\Gosia\RiderProjects\AssignmentFamilies\Families\Pages\Login.razor"
                                                                        username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(18, "b-jvg13b0ihw");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.AddMarkupContent(20, "<label class=\"loginlabel\" b-jvg13b0ihw>Password</label>\r\n            ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "form-group");
            __builder.AddAttribute(23, "b-jvg13b0ihw");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "type", "password");
            __builder.AddAttribute(26, "placeholder", "password");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\Gosia\RiderProjects\AssignmentFamilies\Families\Pages\Login.razor"
                                                                           password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(29, "b-jvg13b0ihw");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n\r\n            ");
            __builder.OpenElement(31, "a");
            __builder.AddAttribute(32, "class", "button1");
            __builder.AddAttribute(33, "href", "");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\Gosia\RiderProjects\AssignmentFamilies\Families\Pages\Login.razor"
                                                 PerformLogin

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "b-jvg13b0ihw");
            __builder.AddMarkupContent(36, "\r\n                Login\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "errorLabel");
            __builder.AddAttribute(40, "b-jvg13b0ihw");
            __builder.AddContent(41, 
#nullable restore
#line 26 "C:\Users\Gosia\RiderProjects\AssignmentFamilies\Families\Pages\Login.razor"
                                     errorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.AddMarkupContent(43, "<div class=\"svgimg\" b-jvg13b0ihw><img src=\"Images/login.svg\" alt=\"Women on the laptop\" b-jvg13b0ihw></div>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\Gosia\RiderProjects\AssignmentFamilies\Families\Pages\Login.razor"
       

    private string username;
    private string password;
    private string errorMessage;

    public async Task PerformLogin()
    {
        errorMessage = "";
        try
        {
            ((CustomAuthenticationStateProvider) AuthenticationStateProvider).ValidateLogin(username, password);
            username = "";
            password = "";
            NavigationManager.NavigateTo("/");
        }
        catch (Exception e)
        {
            errorMessage = e.Message;
        }
    }


    public void OnLogout()
    {
        username = "";
        password = "";
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
