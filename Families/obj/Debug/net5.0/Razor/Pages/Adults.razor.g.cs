#pragma checksum "C:\Users\Gosia\RiderProjects\Families\Families\Pages\Adults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f53b68a543285501055411567a660e2b2d88aacd"
// <auto-generated/>
#pragma warning disable 1591
namespace Families.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Gosia\RiderProjects\Families\Families\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gosia\RiderProjects\Families\Families\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Gosia\RiderProjects\Families\Families\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Gosia\RiderProjects\Families\Families\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Gosia\RiderProjects\Families\Families\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Gosia\RiderProjects\Families\Families\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Gosia\RiderProjects\Families\Families\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Gosia\RiderProjects\Families\Families\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Gosia\RiderProjects\Families\Families\_Imports.razor"
using Families;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Gosia\RiderProjects\Families\Families\_Imports.razor"
using Families.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gosia\RiderProjects\Families\Families\Pages\Adults.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/adults")]
    public partial class Adults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "adultspage");
            __builder.AddAttribute(2, "b-0g5o9kjpes");
            __builder.AddMarkupContent(3, "<div class=\"svgimg\" b-0g5o9kjpes><img src=\"Images/adults.svg\" alt=\"Adults\" b-0g5o9kjpes></div>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "adult-table");
            __builder.AddAttribute(6, "b-0g5o9kjpes");
            __builder.AddMarkupContent(7, @"<thead b-0g5o9kjpes><tr b-0g5o9kjpes><th b-0g5o9kjpes>ID</th>
            <th b-0g5o9kjpes>First Name</th>
            <th b-0g5o9kjpes>Last Name</th>
            <th b-0g5o9kjpes>Age</th>
            <th b-0g5o9kjpes>Job Title</th>
            <th b-0g5o9kjpes>Salary</th>
            <th b-0g5o9kjpes>Details</th></tr></thead>
        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddAttribute(9, "b-0g5o9kjpes");
#nullable restore
#line 22 "C:\Users\Gosia\RiderProjects\Families\Families\Pages\Adults.razor"
         foreach (var item in adults)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "tr");
            __builder.AddAttribute(11, "b-0g5o9kjpes");
            __builder.OpenElement(12, "td");
            __builder.AddAttribute(13, "b-0g5o9kjpes");
            __builder.AddContent(14, 
#nullable restore
#line 25 "C:\Users\Gosia\RiderProjects\Families\Families\Pages\Adults.razor"
                     item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddAttribute(17, "b-0g5o9kjpes");
            __builder.AddContent(18, 
#nullable restore
#line 26 "C:\Users\Gosia\RiderProjects\Families\Families\Pages\Adults.razor"
                     item.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "td");
            __builder.AddAttribute(21, "b-0g5o9kjpes");
            __builder.AddContent(22, 
#nullable restore
#line 27 "C:\Users\Gosia\RiderProjects\Families\Families\Pages\Adults.razor"
                     item.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "td");
            __builder.AddAttribute(25, "b-0g5o9kjpes");
            __builder.AddContent(26, 
#nullable restore
#line 28 "C:\Users\Gosia\RiderProjects\Families\Families\Pages\Adults.razor"
                     item.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "td");
            __builder.AddAttribute(29, "b-0g5o9kjpes");
            __builder.AddContent(30, 
#nullable restore
#line 29 "C:\Users\Gosia\RiderProjects\Families\Families\Pages\Adults.razor"
                     item.JobTitle.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(32);
            __builder.AddAttribute(33, "Policy", "MustBeAdministrator");
            __builder.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(35, "td");
                __builder2.AddAttribute(36, "b-0g5o9kjpes");
                __builder2.AddContent(37, 
#nullable restore
#line 31 "C:\Users\Gosia\RiderProjects\Families\Families\Pages\Adults.razor"
                         item.JobTitle.Salary

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(38, "\r\n                ");
            __builder.OpenElement(39, "td");
            __builder.AddAttribute(40, "b-0g5o9kjpes");
            __builder.OpenComponent<Families.Pages.PopupBox>(41);
            __builder.AddAttribute(42, "id", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 34 "C:\Users\Gosia\RiderProjects\Families\Families\Pages\Adults.razor"
                                   item.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 37 "C:\Users\Gosia\RiderProjects\Families\Families\Pages\Adults.razor"

        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\Gosia\RiderProjects\Families\Families\Pages\Adults.razor"
       
    
    private IList<Adult> adults;

    protected override async Task OnInitializedAsync()
    {
        adults = AdultsData.GetAllAdults();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private InterfaceAdultsData AdultsData { get; set; }
    }
}
#pragma warning restore 1591