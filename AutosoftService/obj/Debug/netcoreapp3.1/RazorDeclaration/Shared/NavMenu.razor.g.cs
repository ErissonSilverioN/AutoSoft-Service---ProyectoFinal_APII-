#pragma checksum "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal6\AutosoftService\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8effaf8f31765b7bdbff107eb18c22441e6950b3"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AutosoftService.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal6\AutosoftService\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal6\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal6\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal6\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal6\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal6\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal6\AutosoftService\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal6\AutosoftService\_Imports.razor"
using AutosoftService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal6\AutosoftService\_Imports.razor"
using AutosoftService.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal6\AutosoftService\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal6\AutosoftService\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 196 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal6\AutosoftService\Shared\NavMenu.razor"
       



    private bool collapseNavMenu = true;

    private bool stateRegister = false;
    private bool stateConsultas = false;
 

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

    private void ToggleRegistrosMenu()
    {
        stateRegister = !stateRegister;
        stateConsultas = false;
        
    }

    private void ToggleConsultasMenu()
    {
        stateConsultas = !stateConsultas;
        stateRegister = false;
      
    }

 

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
