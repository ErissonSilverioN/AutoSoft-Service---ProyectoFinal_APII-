#pragma checksum "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\Pages\Registros\RPagos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2eadd76e5537ce6271f7df390a16a147c39852fe"
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
#line 1 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\_Imports.razor"
using AutosoftService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\_Imports.razor"
using AutosoftService.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\Pages\Registros\RPagos.razor"
using AutosoftService.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\Pages\Registros\RPagos.razor"
using AutosoftService.BLL;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/RPagos")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/RPagos/{PagoId:int}")]
    public partial class RPagos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 100 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\Pages\Registros\RPagos.razor"
      


    [Parameter]
    public int PagoId { get; set; }
    private Pagos pagos = new Pagos();


    private Clientes clientes { get; set; }
    List<Clientes> ListaCliente = new List<Clientes>();
    private string ClienteSelect { get; set; }

    private decimal deuda = 0;

    protected override void OnInitialized()
    {
        ListaCliente = ClienteBLL.GetList(e => true);
        pagos = new Pagos();
        Nuevo();

        if (PagoId != 0)
        {
            pagos.PagoId = PagoId;
            Buscar();
        }
    }


    private void Buscar()
    {
        Pagos pagosTemp = PagoBLL.Buscar(pagos.PagoId);

        if (pagosTemp != null)
        {
            Nuevo();
            pagos = pagosTemp;
            ClienteSelect = pagos.ClienteId.ToString();


        }
        else
        {
            Nuevo();
            toast.ShowError("El Pago no existe", "Fallo");

        }
    }



    private void Nuevo()
    {
        this.pagos = new Pagos();
        ClienteSelect = "0";
        deuda = 0;
    }



    private void Guardar()
    {
        var clienteTemp = ClienteBLL.Buscar(Convert.ToInt32(ClienteSelect));

        if (clienteTemp.Deuda <= 0)
        {
            toast.ShowInfo("El cliente no tiene deuda", "Info");

        }
        else

        if (pagos.Monto > clienteTemp.Deuda)
        {
            toast.ShowInfo("El pago es mayor a la Deuda");

        }
        else if (pagos.Monto <= 0)
        {
            toast.ShowInfo("El Monto debe ser mayor a 0.", "Fallo");

        }
        else if (pagos.Monto >= 999999999)
        {
            toast.ShowInfo("El monto no es valido", "Fallo");

        }
        else
        {
            if (PagoBLL.Guardar(pagos))
            {
                Nuevo();
                toast.ShowSuccess("Pago guardado correctamente", "Exito");

            }
            else
            {
                toast.ShowError("Error al guardar el Pago", "Fallo");
            }
        }

    }



    private void Eliminar()
    {
        Pagos pagoTemp = PagoBLL.Buscar(pagos.PagoId);

        if ( pagoTemp!= null)
        {
            if (PagoBLL.Eliminar(pagos.PagoId))
            {
                Nuevo();
                toast.ShowSuccess("Pago eliminado correctamente", "Exito");

            }
            else
            {
                toast.ShowError("Error al eliminar el pago", "Fallo");

            }
        }
        else
        {
            toast.ShowError("Error al eliminar el pago.", "Fallo");

        }
    }


    private void LlenarComboxCliente()
    {
        try
        {
            pagos.ClienteId = Convert.ToInt32(ClienteSelect);

            var clienteTemp = ClienteBLL.Buscar(Convert.ToInt32(ClienteSelect));

            if (clienteTemp != null)
            {
                deuda = clienteTemp.Deuda;
            }

        }
        catch (Exception)
        {
            toast.ShowError("Algo salio mal", "Error");
        }

    }








#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toast { get; set; }
    }
}
#pragma warning restore 1591
