#pragma checksum "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\BlazorServer\BlazorServerAgencyDashboard\BlazorServerAgencyDashboard\Features\Buttons\EditButton.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bae24f3c3a665d530160d7ead0101f181aa8c6be"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServerAgencyDashboard.Features.Buttons
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
    public partial class EditButton : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddMultipleAttributes(1, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 1 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\BlazorServer\BlazorServerAgencyDashboard\BlazorServerAgencyDashboard\Features\Buttons\EditButton.razor"
                         EditParameters

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line (1,43)-(1,50) 24 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\BlazorServer\BlazorServerAgencyDashboard\BlazorServerAgencyDashboard\Features\Buttons\EditButton.razor"
__builder.AddContent(2, btnText);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "C:\Users\Landry Barb II\Documents\WebDevelopment\Blazor\BlazorServer\BlazorServerAgencyDashboard\BlazorServerAgencyDashboard\Features\Buttons\EditButton.razor"
       

    [Parameter]
    public string btnText { get; set; }

      [Parameter(CaptureUnmatchedValues = true)]
  public Dictionary<string, object> EditParameters{ get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591