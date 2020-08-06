#pragma checksum "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Consultas\CEntradaArticulos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "487b58add67afdbe1f55a4e167cf5715b7af83fa"
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
#line 1 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\_Imports.razor"
using AutosoftService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\_Imports.razor"
using AutosoftService.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Consultas\CEntradaArticulos.razor"
using AutosoftService.BLL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Consultas\CEntradaArticulos.razor"
using AutosoftService.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Consultas\CEntradaArticulos.razor"
using AutosoftService.DAL;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CEntradaArticulos")]
    public partial class CEntradaArticulos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 172 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Consultas\CEntradaArticulos.razor"
       

    private List<EntradasArticulos> Lista { get; set; }
    private List<EntradasArticulos> Paginado { get; set; }

    private string Criterio = string.Empty;
    private string Filtro = string.Empty;
    private bool Filtro_Fecha = false;

    private DateTime Desde = DateTime.Now;
    private DateTime Hasta = DateTime.Now;

    private string Mensaje = string.Empty;

    double Paginas = 0;
    double Elementos = 0;
    int PaginaActual = 0;

    Contexto db = new Contexto();
    Paginacion paginacion = new Paginacion();

    public byte[] Data { get; set; }
    public string pdfContent { get; set; }

    protected override void OnInitialized()
    {
        Lista = EntradaArtBLL.GetList(e => true);
        Filtro = "0";
        Desde = DateTime.Now;
        Hasta = DateTime.Now;

        IniciarPaginacion();
    }
    private void PDF()
    {
        AutosoftService.Pages.Reporte.ReporteEntradaArticulo cobros = new Reporte.ReporteEntradaArticulo();

        Data = cobros.Reporte();

        pdfContent = "data:application/pdf;base64,";
        pdfContent += System.Convert.ToBase64String(Data);
    }


    public void IniciarPaginacion()
    {
        PaginaActual = 1;
        Elementos = Lista.Count();
        Paginas = Math.Ceiling(Elementos / paginacion.Mostrar);
        Paginado = Lista.Take(paginacion.Mostrar).ToList();
    }

    private void PaginaSiguiente()
    {
        if (PaginaActual < Paginas)
        {
            PaginaActual++;
            Paginado = Lista
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
            Paginado = Lista
                .Skip((PaginaActual - 1) * paginacion.Mostrar)
                .Take(paginacion.Mostrar)
                .ToList();
        }
    }


    public void FiltrarPorLaFecha()
    {
        if (Filtro_Fecha == true && Lista.Count > 0)
        {
            Lista = Lista.Where(p => p.Fecha.Date >= Desde.Date && p.Fecha.Date <= Hasta.Date).ToList();
            Filtro_Fecha = false;
        }
        IniciarPaginacion();
    }



    private void Buscar()
    {
        if (Filtro == "0")
        {
            Lista = EntradaArtBLL.GetList(e => true);
            FiltrarPorLaFecha();
        }
        else
        {
            if (Criterio == "")
            {
                Mensaje = "Agregue el criterio de busqueda.";
            }
            else
            {
                Lista = EntradaArtBLL.GetList(e => true);
                switch (Filtro)
                {
                    case "1":
                        Lista = Lista.Where(e => e.EntradasArtId.ToString().Contains(Criterio.ToString())).ToList();
                        Mensaje = "";
                        break;
                }
                FiltrarPorLaFecha();
            }

        }
    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
