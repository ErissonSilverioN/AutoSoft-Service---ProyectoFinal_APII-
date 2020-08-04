#pragma checksum "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal6\AutosoftService\Pages\Consultas\CPagos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7dac9665e54e308edd0a96ca68ee0e26ba74edf"
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
#line 3 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal6\AutosoftService\Pages\Consultas\CPagos.razor"
using AutosoftService.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal6\AutosoftService\Pages\Consultas\CPagos.razor"
using AutosoftService.DAL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal6\AutosoftService\Pages\Consultas\CPagos.razor"
using AutosoftService.BLL;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CPagos")]
    public partial class CPagos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 154 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal6\AutosoftService\Pages\Consultas\CPagos.razor"
       



    DateTime Desde;
    DateTime Hasta;

    string Filtro;
    string Criterio;
   
    bool BuscarPorFecha;
    decimal Total = 0;

    Clientes clientes = new Clientes();

    public List<Pagos> listadoPagos = new List<Pagos>();

    List<Pagos> Listado { get; set; }
    List<Pagos> ListadoPaginado { get; set; }

    double Paginas = 0;
    double Elementos = 0;
    int PaginaActual = 0;

    Contexto db = new Contexto();
    Paginacion paginacion = new Paginacion();


    List<Pagos> listaTemp = new List<Pagos>();

    protected override void OnInitialized()
    {
        Filtro = "0";
        Criterio = string.Empty;
        Desde = DateTime.Now;
        Hasta = DateTime.Now;
        BuscarPorFecha = false;
        LlenarLista();
    }




    private void LlenarLista()
    {
        listadoPagos = PagoBLL.GetList(e => true);
        Listado = new List<Pagos>();
        foreach (var item in listadoPagos)
        {
            Pagos pagos = new Pagos();
            pagos.PagoId = item.PagoId;
            clientes = ClienteBLL.Buscar(item.ClienteId);
            pagos.Fecha = item.Fecha;
            pagos.ClienteId = item.ClienteId;
            pagos.Monto = item.Monto;


            Listado.Add(pagos);
        }

        CagarTotal();
        IniciarPaginacion();
    }

    public void IniciarPaginacion()
    {
        PaginaActual = 1;
        Elementos = Listado.Count();
        Paginas = Math.Ceiling(Elementos / paginacion.Mostrar);
        ListadoPaginado = Listado.Take(paginacion.Mostrar).ToList();
    }

    private void PaginaSiguiente()
    {
        if (PaginaActual < Paginas)
        {
            PaginaActual++;
            ListadoPaginado = Listado
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
            ListadoPaginado = Listado
                .Skip((PaginaActual - 1) * paginacion.Mostrar)
                .Take(paginacion.Mostrar)
                .ToList();
        }
    }

    public void FiltrarPorLaFecha()
    {
        if (Filtro == "0")
            listaTemp = Listado;

        if (BuscarPorFecha == true && listaTemp.Count > 0)
        {
            Listado = new List<Pagos>();
            foreach (var item in listaTemp)
            {
                if (item.Fecha.Date >= Desde.Date && item.Fecha.Date <= Hasta.Date)
                {
                    Listado.Add(item);
                }
            }
            BuscarPorFecha = false;
        }
        else
        {
            Listado = new List<Pagos>();
            Listado = listaTemp;
        }

        CagarTotal();
        IniciarPaginacion();
    }

    public void CagarTotal()
    {
        Total = 0;
        if (Listado != null)
            foreach (var item in Listado)
            {
                Total += item.Monto;
            }
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
                toast.ShowInfo("Agregue el criterio de busqueda.");
            }
            else
            {
                LlenarLista();
                listaTemp = Listado;

                switch (Filtro)
                {
                    case "0":
                        listadoPagos = PagoBLL.GetList(e => true);
                        break;

                    case "1":
                        listaTemp = new List<Pagos>();
                        foreach (var item in listadoPagos)
                        {
                            if (Convert.ToString(item.PagoId).Contains(Criterio))
                            {
                                Pagos pagos = new Pagos();
                                pagos.PagoId = item.PagoId;
                                clientes = ClienteBLL.Buscar(item.ClienteId);
                                pagos.ClienteId = Convert.ToInt32(clientes.ClienteId);
                                pagos.Fecha = item.Fecha;
                                pagos.Monto = item.Monto;

                                listaTemp.Add(pagos);
                            }
                        }
                        break;

                    case "2":
                        listaTemp = new List<Pagos>();
                        foreach (var item in listadoPagos)
                        {
                            clientes = ClienteBLL.Buscar(item.ClienteId);
                            if (clientes.Nombre.Contains(Criterio))
                            {
                                Pagos pagos = new Pagos();
                                pagos.PagoId = item.PagoId;
                                pagos.Fecha = item.Fecha;
                                clientes = ClienteBLL.Buscar(item.ClienteId);
                                pagos.ClienteId = clientes.ClienteId;
                                pagos.Monto = item.Monto;

                                listaTemp.Add(pagos);
                            }
                        }
                        break;

                    case "3":
                        listadoPagos = new List<Pagos>();
                        foreach (var item in listadoPagos)
                        {
                            if (Convert.ToString(item.Monto).Contains(Criterio))
                            {
                                Pagos pagos = new Pagos();
                                pagos.PagoId = item.PagoId;
                                pagos.Fecha = item.Fecha;
                                clientes = ClienteBLL.Buscar(item.ClienteId);
                                pagos.ClienteId = clientes.ClienteId;
                                pagos.Monto = item.Monto;

                                listaTemp.Add(pagos);
                            }
                        }
                        break;
                }

                FiltrarPorLaFecha();
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
