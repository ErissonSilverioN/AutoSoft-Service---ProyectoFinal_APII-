#pragma checksum "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal9\AutosoftService\Pages\Consultas\CArticulos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca0c89be4f06453a2158f16c663625f8c1b8069b"
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
#line 1 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal9\AutosoftService\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal9\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal9\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal9\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal9\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal9\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal9\AutosoftService\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal9\AutosoftService\_Imports.razor"
using AutosoftService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal9\AutosoftService\_Imports.razor"
using AutosoftService.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal9\AutosoftService\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal9\AutosoftService\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal9\AutosoftService\Pages\Consultas\CArticulos.razor"
using AutosoftService.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal9\AutosoftService\Pages\Consultas\CArticulos.razor"
using AutosoftService.Model.Consultas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal9\AutosoftService\Pages\Consultas\CArticulos.razor"
using AutosoftService.BLL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal9\AutosoftService\Pages\Consultas\CArticulos.razor"
using AutosoftService.DAL;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CArticulos")]
    public partial class CArticulos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 177 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal9\AutosoftService\Pages\Consultas\CArticulos.razor"
       


    DateTime Desde;
    DateTime Hasta;

    string ValorInventario;
    string Filtro;
    string Criterio;
    bool FiltrarFecha;


    Proveedores proveedorTemp = new Proveedores();


    public List<Articulos> listaArticulos = new List<Articulos>();

    List<ArticulosConsult> ListaArticulos { get; set; }
    List<ArticulosConsult> ListadoPaginado { get; set; }

    double Paginas = 0;
    double Elementos = 0;
    int PaginaActual = 0;

    Contexto db = new Contexto();
    Paginacion paginacion = new Paginacion();

    List<ArticulosConsult> listaTemp = new List<ArticulosConsult>();

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
        listaArticulos = ArticuloBLL.GetList(e => true);

        ListaArticulos = new List<ArticulosConsult>();

        foreach (var item in listaArticulos)
        {
            ArticulosConsult articulos = new ArticulosConsult();
            articulos.ArticuloId = item.ArticuloId;
            articulos.Descripcion = item.Descripcion;
            articulos.Fecha = item.Fecha;
            proveedorTemp = ProveedorBLL.Buscar(item.ProveedorId);
            articulos.Proveedor = (proveedorTemp == null) ? "Proveedor Eliminado" : proveedorTemp.Nombre;
            articulos.Costo = item.Costo;
            articulos.Existencia = item.Existencia;
            articulos.ValorInventario = (articulos.Existencia * articulos.Costo);


            ListaArticulos.Add(articulos);
            TotalInventario();
        }

        IniciarPaginacion();
    }



    public void IniciarPaginacion()
    {
        PaginaActual = 1;
        Elementos = ListaArticulos.Count();
        Paginas = Math.Ceiling(Elementos / paginacion.Mostrar);
        ListadoPaginado = ListaArticulos.Take(paginacion.Mostrar).ToList();
    }

    private void PaginaSiguiente()
    {
        if (PaginaActual < Paginas)
        {
            PaginaActual++;
            ListadoPaginado = ListaArticulos
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
            ListadoPaginado = ListaArticulos
                .Skip((PaginaActual - 1) * paginacion.Mostrar)
                .Take(paginacion.Mostrar)
                .ToList();
        }
    }

    public void FiltrarPorLaFecha()
    {
        if (Filtro == "0")
            listaTemp = ListaArticulos;

        if (FiltrarFecha == true && listaTemp.Count > 0)
        {
            ListaArticulos = new List<ArticulosConsult>();
            foreach (var item in listaTemp)
            {
                if (item.Fecha.Date >= Desde.Date && item.Fecha.Date <= Hasta.Date)
                {
                    ListaArticulos.Add(item);
                }
            }

            FiltrarFecha = false;
        }
        else
        {
            ListaArticulos = new List<ArticulosConsult>();
            ListaArticulos = listaTemp;
            TotalInventario();
        }
        IniciarPaginacion();
    }



    private void TotalInventario()
    {
        decimal Total = 0;

        if (ListaArticulos != null)

            foreach(var item in ListaArticulos)
            {
                Total +=  item.ValorInventario;
            }

        ValorInventario = Convert.ToString(Total.ToString("N2"));


    }






    private void Buscar()
    {
        if (Filtro == "0")
        {
            LlenarLista();
            FiltrarPorLaFecha();
        }
        else
        {
            if (Criterio == "")
            {
                toast.ShowInfo("Ingrese un criterio de busqueda");
            }
            else
            {
                LlenarLista();
                List<ArticulosConsult> listaTemp = ListaArticulos;

                switch (Filtro)
                {
                    case "0":
                        listaArticulos = ArticuloBLL.GetList(e => true);
                        break;

                    case "1":
                        listaTemp = new List<ArticulosConsult>();
                        foreach (var item in listaArticulos)
                        {
                            if (Convert.ToString(item.ArticuloId).Contains(Criterio))
                            {
                                ArticulosConsult articulos = new ArticulosConsult();
                                articulos.ArticuloId = item.ArticuloId;
                                articulos.Descripcion = item.Descripcion;
                                articulos.Fecha = item.Fecha;
                                proveedorTemp = ProveedorBLL.Buscar(item.ProveedorId);
                                articulos.Proveedor = (proveedorTemp == null) ? "Proveedor Eliminado" : proveedorTemp.Nombre;
                                articulos.Costo = item.Costo;
                                articulos.Existencia = item.Existencia;
                                articulos.Existencia = item.Existencia;
                                articulos.ValorInventario = (articulos.Existencia * articulos.Costo);

                                listaTemp.Add(articulos);
                            }
                        }
                        break;

                    case "2":
                        listaTemp = new List<ArticulosConsult>();

                        foreach (var item in listaArticulos)
                        {
                            if (item.Descripcion.Contains(Criterio))
                            {
                                ArticulosConsult articulos = new ArticulosConsult();
                                articulos.ArticuloId = item.ArticuloId;
                                articulos.Descripcion = item.Descripcion;
                                articulos.Fecha = item.Fecha;
                                proveedorTemp = ProveedorBLL.Buscar(item.ProveedorId);
                                articulos.Proveedor = (proveedorTemp == null) ? "Proveedor Eliminado" : proveedorTemp.Nombre;
                                articulos.Costo = item.Costo;
                                articulos.Existencia = item.Existencia;
                                articulos.ValorInventario = (articulos.Existencia * articulos.Costo);


                                listaTemp.Add(articulos);
                            }
                        }
                        break;



                    case "3":
                        listaTemp = new List<ArticulosConsult>();
                        foreach (var item in listaArticulos)
                        {
                            proveedorTemp = ProveedorBLL.Buscar(item.ProveedorId);
                            if (proveedorTemp.Nombre.Contains(Criterio))
                            {
                                ArticulosConsult articulos = new ArticulosConsult();
                                articulos.ArticuloId = item.ArticuloId;
                                articulos.Descripcion = item.Descripcion;
                                articulos.Fecha = item.Fecha;
                                articulos.Proveedor = proveedorTemp.Nombre;
                                articulos.Costo = item.Costo;
                                articulos.Existencia = item.Existencia;
                                articulos.ValorInventario = (articulos.Existencia * articulos.Costo);


                                listaTemp.Add(articulos);
                            }
                        }
                        break;

                    case "4":
                        listaTemp = new List<ArticulosConsult>();
                        foreach (var item in listaArticulos)
                        {
                            if (Convert.ToString(item.Existencia).Contains(Criterio))
                            {
                                ArticulosConsult articulos = new ArticulosConsult();
                                articulos.ArticuloId = item.ArticuloId;
                                articulos.Descripcion = item.Descripcion;
                                articulos.Fecha = item.Fecha;
                                proveedorTemp = ProveedorBLL.Buscar(item.ProveedorId);
                                articulos.Proveedor = proveedorTemp.Nombre;
                                articulos.Costo = item.Costo;
                                articulos.Existencia = item.Existencia;
                                articulos.ValorInventario = (articulos.Existencia * articulos.Costo);


                                listaTemp.Add(articulos);
                            }
                        }
                        break;

                    case "5":
                        listaTemp = new List<ArticulosConsult>();
                        foreach (var item in listaArticulos)
                        {
                            if (Convert.ToString(item.Costo).Contains(Criterio))
                            {
                                ArticulosConsult articulos = new ArticulosConsult();
                                articulos.ArticuloId = item.ArticuloId;
                                articulos.Descripcion = item.Descripcion;
                                articulos.Fecha = item.Fecha;
                                proveedorTemp = ProveedorBLL.Buscar(item.ProveedorId);
                                articulos.Proveedor = proveedorTemp.Nombre;
                                articulos.Costo = item.Costo;
                                articulos.Existencia = item.Existencia;
                                articulos.ValorInventario = (articulos.Existencia * articulos.Costo);


                                listaTemp.Add(articulos);
                            }
                        }
                        break;
                }
                if (FiltrarFecha == true)
                {
                    ListaArticulos = new List<ArticulosConsult>();

                    foreach (var item in listaTemp)
                    {
                        if (item.Fecha.Date >= Desde.Date && item.Fecha.Date <= Hasta.Date)
                        {
                            ListaArticulos.Add(item);
                        }
                    }
                    FiltrarFecha = false;
                }
                else
                {
                    ListaArticulos = new List<ArticulosConsult>();
                    ListaArticulos = listaTemp;
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
