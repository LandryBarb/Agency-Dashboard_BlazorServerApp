// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorServerAgencyDashboard.Features.Home
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\BlazorServer\BlazorServerAgencyDashboard\BlazorServerAgencyDashboard\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\BlazorServer\BlazorServerAgencyDashboard\BlazorServerAgencyDashboard\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\BlazorServer\BlazorServerAgencyDashboard\BlazorServerAgencyDashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\BlazorServer\BlazorServerAgencyDashboard\BlazorServerAgencyDashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\BlazorServer\BlazorServerAgencyDashboard\BlazorServerAgencyDashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\BlazorServer\BlazorServerAgencyDashboard\BlazorServerAgencyDashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\BlazorServer\BlazorServerAgencyDashboard\BlazorServerAgencyDashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\BlazorServer\BlazorServerAgencyDashboard\BlazorServerAgencyDashboard\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\BlazorServer\BlazorServerAgencyDashboard\BlazorServerAgencyDashboard\_Imports.razor"
using BlazorServerAgencyDashboard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\BlazorServer\BlazorServerAgencyDashboard\BlazorServerAgencyDashboard\_Imports.razor"
using BlazorServerAgencyDashboard.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\BlazorServer\BlazorServerAgencyDashboard\BlazorServerAgencyDashboard\_Imports.razor"
using BlazorServerAgencyDashboard.Features;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\BlazorServer\BlazorServerAgencyDashboard\BlazorServerAgencyDashboard\_Imports.razor"
using BlazorServerAgencyDashboard.Features.Layout;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\BlazorServer\BlazorServerAgencyDashboard\BlazorServerAgencyDashboard\_Imports.razor"
using BlazorServerAgencyDashboard.Features.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\BlazorServer\BlazorServerAgencyDashboard\BlazorServerAgencyDashboard\_Imports.razor"
using BlazorServerAgencyDashboard.Features.Buttons;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/clients")]
    public partial class ClientsPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\BlazorServer\BlazorServerAgencyDashboard\BlazorServerAgencyDashboard\Features\Home\ClientsPage.razor"
       
    Client client = new Client();
   
    protected override async Task OnInitializedAsync()
    {
        await ClientService.GetClients();
    }

    void ShowClient(int id)
    {
        navMan.NavigateTo($"client/{id}");
    }
    void AddNewClient()
    {
        navMan.NavigateTo("client");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navMan { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClientService ClientService { get; set; }
    }
}
#pragma warning restore 1591
