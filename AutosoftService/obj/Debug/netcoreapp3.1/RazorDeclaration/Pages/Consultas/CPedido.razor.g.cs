#pragma checksum "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal6\AutosoftService\Pages\Consultas\CPedido.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b311bc7c44f9262785352bab0879645df27d970f"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AutosoftService.Pages.Consultas
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
#nullable restore
#line 3 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal6\AutosoftService\Pages\Consultas\CPedido.razor"
using AutosoftService.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal6\AutosoftService\Pages\Consultas\CPedido.razor"
using AutosoftService.Model.Consultas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal6\AutosoftService\Pages\Consultas\CPedido.razor"
using AutosoftService.BLL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal6\AutosoftService\Pages\Consultas\CPedido.razor"
using AutosoftService.DAL;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CPedidos")]
    public partial class CPedido : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 166 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal6\AutosoftService\Pages\Consultas\CPedido.razor"
       


    DateTime Desde;
    DateTime Hasta;

    string Filtro;
    string Criterio;

    bool FiltrarFecha;


    Proveedores proveedorTemp = new Proveedores();
    Articulos articuloTemp = new Articulos();
    Pedidos pedidoTemp = new Pedidos();

    public List<Pedidos> listadoPedidos = new List<Pedidos>();

    List<PedidosConsult> ListaPedidos { get; set; }
    List<PedidosConsult> ListadoPaginado { get; set; }

    double Paginas = 0;
    double Elementos = 0;
    int PaginaActual = 0;

    Contexto db = new Contexto();
    Paginacion paginacion = new Paginacion();

    List<PedidosConsult> listadoTemp = new List<PedidosConsult>();

    protected override void OnInitialized()
    {
        Filtro = "0";
        Criterio = string.Empty;
        Desde = DateTime.Now;
        Hasta = DateTime.Now;
        FiltrarFecha = false;


        LlenarLista();
    }



    private void LlenarLista()
    {
        listadoPedidos = PedidoBLL.GetList(e => true);
        ListaPedidos = new List<PedidosConsult>();

        foreach (var item in listadoPedidos)
        {
            PedidosConsult pedidos = new PedidosConsult();
            pedidos.PedidoId = item.PedidoId;
            articuloTemp = ArticuloBLL.Buscar(item.ArticuloId);
            pedidos.Articulo = (articuloTemp == null) ? "Articulo Eliminado" : articuloTemp.Descripcion;
            proveedorTemp = ProveedorBLL.Buscar(item.ProveedorId);
            pedidos.Proveedor = (proveedorTemp == null) ? "Proveedor Eliminado" : proveedorTemp.Nombre;
            pedidoTemp = PedidoBLL.Buscar(item.PedidoId);
            //pedidos.Subtotal = (pedidoTemp == null) ? "Pedido Eliminado" : pedidoTemp.Subtotal;
            pedidos.Fecha = item.Fecha;
            pedidos.FechaEntrega = item.FechaEntrega;

            ListaPedidos.Add(pedidos);
        }

        IniciarPaginacion();
    }

    public void IniciarPaginacion()
    {
        PaginaActual = 1;
        Elementos = ListaPedidos.Count();
        Paginas = Math.Ceiling(Elementos / paginacion.Mostrar);
        ListadoPaginado = ListaPedidos.Take(paginacion.Mostrar).ToList();
    }

    private void PaginaSiguiente()
    {
        if (PaginaActual < Paginas)
        {
            PaginaActual++;
            ListadoPaginado = ListaPedidos
                .Skip((PaginaActual - 1) * paginacion.Mostrar)
                .Take(paginacion.Mostrar)
                .ToList();
        }
    }

    private void PaginaAnterior()
    {
        if (PaginaActual > 1)
        {
            PaginaActual--;
            ListadoPaginado = ListaPedidos
                .Skip((PaginaActual - 1) * paginacion.Mostrar)
                .Take(paginacion.Mostrar)
                .ToList();
        }
    }



    public void FiltrarFechas()
    {
        if (Filtro == "0")
            listadoTemp = ListaPedidos;

        if (FiltrarFecha == true && listadoTemp.Count > 0)
        {
            ListaPedidos = new List<PedidosConsult>();

            foreach (var item in listadoTemp)
            {
                if (item.Fecha.Date >= Desde.Date && item.Fecha.Date <= Hasta.Date)
                {
                    ListaPedidos.Add(item);
                }
            }

            FiltrarFecha = false;
        }
        else
        {
            ListaPedidos = new List<PedidosConsult>();
            ListaPedidos = listadoTemp;
        }

        IniciarPaginacion();
    }




    private void Buscar()
    {
        if (Filtro == "0")
        {
            LlenarLista();
            FiltrarFechas();
        }
        else
        {
            if (Criterio == "")
            {
                toast.ShowInfo("Debe ingresar un criterio");
            }
            else
            {
                LlenarLista();
                List<PedidosConsult> listadoTemp = ListaPedidos;

                switch (Filtro)
                {
                    case "0":
                        listadoPedidos = PedidoBLL.GetList(e => true);
                        break;

                    case "1":
                        listadoTemp = new List<PedidosConsult>();

                        foreach (var item in listadoPedidos)
                        {
                            if (Convert.ToString(item.PedidoId).Contains(Criterio))
                            {
                                PedidosConsult pedidos = new PedidosConsult();
                                pedidos.PedidoId = item.PedidoId;
                                articuloTemp = ArticuloBLL.Buscar(item.ArticuloId);
                                pedidos.Articulo = (articuloTemp == null) ? "Articulo Eliminado" : articuloTemp.Descripcion;
                                proveedorTemp = ProveedorBLL.Buscar(item.ProveedorId);
                                pedidos.Proveedor = (proveedorTemp == null) ? "Proveedor Eliminado" : proveedorTemp.Nombre;
                                pedidoTemp = PedidoBLL.Buscar(item.PedidoId);
                                //pedidos.Subtotal = (pedidoTemp == null) ? "Pedido Eliminado" : pedidoTemp.Subtotal;
                                pedidos.Fecha = item.Fecha;
                                pedidos.FechaEntrega = item.FechaEntrega;

                                listadoTemp.Add(pedidos);
                            }
                        }
                        break;

                    case "2":
                        listadoTemp = new List<PedidosConsult>();

                        foreach (var item in listadoPedidos)
                        {
                            articuloTemp = ArticuloBLL.Buscar(item.ArticuloId);
                            if (articuloTemp.Descripcion.Contains(Criterio))
                            {
                                PedidosConsult pedidos = new PedidosConsult();
                                pedidos.PedidoId = item.PedidoId;
                                articuloTemp = ArticuloBLL.Buscar(item.ArticuloId);
                                pedidos.Articulo = (articuloTemp == null) ? "Articulo Eliminado" : articuloTemp.Descripcion;
                                proveedorTemp = ProveedorBLL.Buscar(item.ProveedorId);
                                pedidos.Proveedor = (proveedorTemp == null) ? "Proveedor Eliminado" : proveedorTemp.Nombre;
                                pedidoTemp = PedidoBLL.Buscar(item.PedidoId);
                                //pedidos.Subtotal = (pedidoTemp == null) ? "Pedido Eliminado" : pedidoTemp.Subtotal;
                                pedidos.Fecha = item.Fecha;
                                pedidos.FechaEntrega = item.FechaEntrega;

                                listadoTemp.Add(pedidos);
                            }
                        }
                        break;

                    case "3":
                        listadoTemp = new List<PedidosConsult>();

                        foreach (var item in listadoPedidos)
                        {
                            proveedorTemp = ProveedorBLL.Buscar(item.ProveedorId);
                            if (proveedorTemp.Nombre.Contains(Criterio))
                            {
                                PedidosConsult pedidos = new PedidosConsult();
                                pedidos.PedidoId = item.PedidoId;
                                articuloTemp = ArticuloBLL.Buscar(item.ArticuloId);
                                pedidos.Articulo = (articuloTemp == null) ? "Articulo Eliminado" : articuloTemp.Descripcion;
                                proveedorTemp = ProveedorBLL.Buscar(item.ProveedorId);
                                pedidos.Proveedor = (proveedorTemp == null) ? "Proveedor Eliminado" : proveedorTemp.Nombre;
                                pedidoTemp = PedidoBLL.Buscar(item.PedidoId);
                                //pedidos.Subtotal = (pedidoTemp == null) ? "Pedido Eliminado" : pedidoTemp.Subtotal;
                                pedidos.Fecha = item.Fecha;
                                pedidos.FechaEntrega = item.FechaEntrega;

                                listadoTemp.Add(pedidos);
                            }
                        }
                        break;

                   

                }
                if (FiltrarFecha == true)
                {
                    ListaPedidos = new List<PedidosConsult>();

                    foreach (var item in listadoTemp)
                    {
                        if (item.Fecha.Date >= Desde.Date && item.Fecha.Date <= Hasta.Date)
                        {
                            ListaPedidos.Add(item);
                        }
                    }
                    FiltrarFecha = false;
                }
                else
                {
                    ListaPedidos = new List<PedidosConsult>();
                    ListaPedidos = listadoTemp;
                }
            }
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toast { get; set; }
    }
}
#pragma warning restore 1591
