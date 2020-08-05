#pragma checksum "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\Pages\Registros\RPedidos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77c330f2640a7fff44421cbb7facd4844a805967"
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
#line 5 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\Pages\Registros\RPedidos.razor"
using AutosoftService.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\Pages\Registros\RPedidos.razor"
using AutosoftService.BLL;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/RPedidos")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/RPedios/{PedidoId:int}")]
    public partial class RPedidos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 199 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\Pages\Registros\RPedidos.razor"
       

    [Parameter]
    public int PedidoId { get; set; }
    private Pedidos pedidos = new Pedidos();


    Proveedores proveedores = new Proveedores();
    private List<Proveedores> ListaProveedores = new List<Proveedores>();
    private string ProveedorSelect { get; set; }


    Articulos articulos = new Articulos();
    private List<Articulos> ListaArticulos = new List<Articulos>();
    private string ArticuloSelect { get; set; }


    private int unidad = 0;
    private decimal precio = 0;
    decimal importe = 0;
    private int existencia = 0;






    protected override void OnInitialized()
    {

        ListaProveedores = BLL.ProveedorBLL.GetList(e => true);
        ListaArticulos = ArticuloBLL.GetList(e => true);
        pedidos = new Pedidos();
        proveedores = new Proveedores();
        articulos = new Articulos();
        Nuevo();
        Buscar();

        base.OnInitialized();
    }



    private void Buscar()
    {
        if (pedidos.PedidoId != 0)
        {
            var encontrado = PedidoBLL.Buscar(pedidos.PedidoId);

            if (encontrado != null)
            {
                this.pedidos = encontrado;
            }
            else
            {
                toas.ShowWarning("NO ENCONTRADO", "Fallo");
            }
        }
    }



    private void Nuevo()
    {
        this.pedidos = new Pedidos();
        ArticuloSelect = "0";
        unidad = 0;
        existencia = 0;
        precio = 0;
        ProveedorSelect = "0";
    }



    private void Guardar()
    {

        CalcularSubtotal();
        if (ProveedorSelect == null)
        {
            toas.ShowInfo("Ingrese un Proveedor", "Info");
        }
        else
        {
            pedidos.ProveedorId = Convert.ToInt32(ProveedorSelect);

            if (pedidos.Pedido_Detalle.Count == 0)
            {
                toas.ShowInfo("Ingrese un Articulo al detalle", "Info");
            }
            else
            {
                if (PedidoBLL.Guardar(pedidos))
                {
                    Nuevo();
                    toas.ShowSuccess("Factura Guardada", "Exito");
                }
                else
                {
                    toas.ShowError("Error al guardar Factura", "Fallo");
                }
            }
        }
    }


    private void Eliminar()
    {
        bool paso;

        paso = PedidoBLL.Eliminar(pedidos.PedidoId);

        if (paso)
        {
            Nuevo();
            toas.ShowWarning("ELIMINADO");
        }
        else
        {
            toas.ShowError("NO SE PUDO ELIMINAR");
        }
    }


    private void Agregar()
    {
        
        var articuloTemp = ArticuloBLL.Buscar(Convert.ToInt32(ArticuloSelect));
        var proveedorTemp = ProveedorBLL.Buscar(Convert.ToInt32(ProveedorSelect));


        if (ArticuloSelect == null)
        {
            toas.ShowWarning("Debe ingresar un Articulo");
        }
        else
        {
            if (ProveedorSelect == null)
            {

                toas.ShowWarning("Debe ingresar un Proveedor");
            }
            else
            {
                if (unidad == 0)
                {

                    toas.ShowWarning("Debe ingresar una cantidad");
                }
                else
                {
                    pedidos.Pedido_Detalle.Add(new PedidoD()
                    {
                        PedidoId = pedidos.PedidoId,
                        ArticuloId = articuloTemp.ArticuloId,
                        ProveedorId = proveedorTemp.ProveedorId,
                        Descripcion = articuloTemp.Descripcion,
                        Precio = precio,
                        Unidad = unidad
                    });

                    articulos = new Articulos();

                    CalcularSubtotal();

                    ArticuloSelect = "0";
                    unidad = 0;
                    ProveedorSelect = "0";
                    existencia = 0;
                    precio = 0;

                }
            }
        }
    }



    private void Remover(PedidoD detalle)
    {
        pedidos.Pedido_Detalle.Remove(detalle);
        CalcularSubtotal();
    }







    private void LlenaComboxProveedor()
    {
        try
        {
            pedidos.ProveedorId = Convert.ToInt32(ProveedorSelect);
        }
        catch (Exception)
        {

        }
    }



    private void LlenaComboxArticulo()
    {
        try
        {
            pedidos.ArticuloId = Convert.ToInt32(ArticuloSelect);

            var articuloTemp = ArticuloBLL.Buscar(Convert.ToInt32(ArticuloSelect));

            if (articuloTemp != null)
            {
                precio = Convert.ToDecimal(articuloTemp.Precio.ToString("N2"));
                existencia = articuloTemp.Existencia;
            }

        }

        catch (Exception)
        {
            toas.ShowError("Algo salio mal", "Error");
        }

    }


    private void CalcularSubtotal()
    {
        decimal Result = 0;

        foreach (var item in pedidos.Pedido_Detalle)
        {
            Result += item.Precio * item.Unidad;
        }

        pedidos.Subtotal = Result;
    }




    public string GetNombreProveedor(int id)
    {
        Proveedores proveedores = ProveedorBLL.Buscar(id);
        if (proveedores != null)
        {
            return proveedores.Nombre;
        }
        id = 0;
        return "Error...";
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toas { get; set; }
    }
}
#pragma warning restore 1591
