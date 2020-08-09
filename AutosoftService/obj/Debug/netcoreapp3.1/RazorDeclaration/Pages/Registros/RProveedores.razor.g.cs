#pragma checksum "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal15\AutosoftService\Pages\Registros\RProveedores.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e78922a8b627544508f6e122d73f3b9d65377ebe"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AutosoftService.Pages.Registros
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal15\AutosoftService\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal15\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal15\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal15\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal15\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal15\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal15\AutosoftService\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal15\AutosoftService\_Imports.razor"
using AutosoftService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal15\AutosoftService\_Imports.razor"
using AutosoftService.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal15\AutosoftService\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal15\AutosoftService\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal15\AutosoftService\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal15\AutosoftService\Pages\Registros\RProveedores.razor"
using Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal15\AutosoftService\Pages\Registros\RProveedores.razor"
using BLL;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/RProveedores")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/RProveedores/{ProveedorId:int}")]
    public partial class RProveedores : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 103 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal15\AutosoftService\Pages\Registros\RProveedores.razor"
      

    [Parameter]
    public int ProveedorId{ get; set; }

    Proveedores proveedores = new Proveedores();

    private Usuarios Usuario = new Usuarios();

    public bool paso { get; set; }

    protected override void OnInitialized()
    {
        Nuevo();
        if (ProveedorId > 0)
        {
            var Auxproveedores = ProveedorBLL.Buscar(ProveedorId);
            if (Auxproveedores != null)
                this.proveedores = Auxproveedores;
            else
                toast.ShowWarning("No encontrado.");
        }


    }

    private void Nuevo()
    {
        this.proveedores = new Proveedores();

    }

    private void Buscar()
    {
        if (proveedores.ProveedorId > 0)
        {
            var encontrado = ProveedorBLL.Buscar(proveedores.ProveedorId);

            if (encontrado != null)
            {
                this.proveedores = encontrado;
            }
            else
            {
                toast.ShowWarning("No encontrado");


            }
        }
    }

    private void Guardar()
    {
        bool guardo = ProveedorBLL.Guardar(proveedores);

        if (guardo)
        {
            Nuevo();
            toast.ShowSuccess("Guardado correctamente");

        }
        else
        {
            toast.ShowError("No fue posible guardar");

        }
    }

    private void Eliminar()
    {
        bool elimino;

        elimino = ProveedorBLL.Eliminar(proveedores.ProveedorId);

        if (elimino)
        {
            Nuevo();
            toast.ShowSuccess("Eliminado correctamente");

        }
        else
        {
            toast.ShowError("No fue posible eliminar");

        }
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toast { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
