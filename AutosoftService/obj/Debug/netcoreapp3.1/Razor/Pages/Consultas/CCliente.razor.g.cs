#pragma checksum "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CCliente.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36a63e36b0a5e265765b510d0b1cfc163c7c76f2"
// <auto-generated/>
#pragma warning disable 1591
namespace AutosoftService.Pages.Consultas
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\_Imports.razor"
using AutosoftService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\_Imports.razor"
using AutosoftService.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CCliente.razor"
using BLL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CCliente.razor"
using Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Cclientes")]
    public partial class CCliente : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CCliente.razor"
                 listapaginada

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "card");
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.AddMarkupContent(9, "<div class=\"card-header\" style=\"        background-color: #6378F0\r\n\">\r\n        <h3>Consultas De Clientes</h3>\r\n    </div>\r\n\r\n    ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "card-body");
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "input-group mb-4");
                __builder2.AddMarkupContent(15, "\r\n            ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "input-group");
                __builder2.AddMarkupContent(18, "\r\n\r\n                ");
                __builder2.AddMarkupContent(19, "<label for=\"filtro\">Filtro: </label>\r\n                ");
                __builder2.OpenElement(20, "select");
                __builder2.AddAttribute(21, "class", "form-control ml-3 mr-3");
                __builder2.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CCliente.razor"
                                                              Filtro

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Filtro = __value, Filtro));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(24, "\r\n                    ");
                __builder2.OpenElement(25, "option");
                __builder2.AddAttribute(26, "value", true);
                __builder2.AddAttribute(27, "disabled", true);
                __builder2.AddAttribute(28, "selected", true);
                __builder2.AddContent(29, "Seleccione un filtro");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                    ");
                __builder2.OpenElement(31, "option");
                __builder2.AddAttribute(32, "value", "Todo");
                __builder2.AddContent(33, "Todo");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n                    ");
                __builder2.OpenElement(35, "option");
                __builder2.AddAttribute(36, "value", "ID");
                __builder2.AddContent(37, "ID");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n                    ");
                __builder2.OpenElement(39, "option");
                __builder2.AddAttribute(40, "value", "Nombre");
                __builder2.AddContent(41, "Nombre");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                    ");
                __builder2.OpenElement(43, "option");
                __builder2.AddAttribute(44, "value", "Cedula");
                __builder2.AddContent(45, "cedula");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n\r\n                ");
                __builder2.AddMarkupContent(48, "<label for=\"criterio ml-3 mr-3\"> Criterio: </label>\r\n                ");
                __builder2.OpenElement(49, "input");
                __builder2.AddAttribute(50, "type", "search");
                __builder2.AddAttribute(51, "class", "form-control ml-3 mr-3");
                __builder2.AddAttribute(52, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CCliente.razor"
                                                                                 Criterio

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Criterio = __value, Criterio));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n\r\n                ");
                __builder2.OpenElement(55, "button");
                __builder2.AddAttribute(56, "type", "button");
                __builder2.AddAttribute(57, "class", "btn btn-primary");
                __builder2.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CCliente.razor"
                                                                        Buscar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(59, "Buscar ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n\r\n        ");
                __builder2.OpenElement(63, "table");
                __builder2.AddAttribute(64, "class", " table mb-3 mt-3");
                __builder2.AddAttribute(65, "id", "example");
                __builder2.AddMarkupContent(66, "\r\n            ");
                __builder2.AddMarkupContent(67, @"<thead class=""thead-light"">
                <tr>
                    <th>ID</th>
                    <th>Nombre</th>
                    <th>Cedula</th>
                    <th>Telefono</th>
                    <th>Direccion</th>
                    <th>Email</th>
                    <th>Fecha</th>
                </tr>
            </thead>
            ");
                __builder2.OpenElement(68, "tbody");
                __builder2.AddMarkupContent(69, "\r\n");
#nullable restore
#line 48 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CCliente.razor"
                 if (listapaginada.Count == 0)
                {
                    toast.ShowWarning("No hay datos");
                }
                else
                {

                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CCliente.razor"
                     foreach (var item in listapaginada)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(70, "                        ");
                __builder2.OpenElement(71, "tr");
                __builder2.AddAttribute(72, "class", "table-striped");
                __builder2.AddMarkupContent(73, "\r\n                            ");
                __builder2.OpenElement(74, "td");
                __builder2.AddContent(75, 
#nullable restore
#line 58 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CCliente.razor"
                                 item.ClienteId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n                            ");
                __builder2.OpenElement(77, "td");
                __builder2.AddContent(78, 
#nullable restore
#line 59 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CCliente.razor"
                                 item.Nombre

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n                            ");
                __builder2.OpenElement(80, "td");
                __builder2.AddContent(81, 
#nullable restore
#line 60 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CCliente.razor"
                                 item.Cedula

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n                            ");
                __builder2.OpenElement(83, "td");
                __builder2.AddContent(84, 
#nullable restore
#line 61 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CCliente.razor"
                                 item.Telefono

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n                            ");
                __builder2.OpenElement(86, "td");
                __builder2.AddContent(87, 
#nullable restore
#line 62 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CCliente.razor"
                                 item.Direccion

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n                            ");
                __builder2.OpenElement(89, "td");
                __builder2.AddContent(90, 
#nullable restore
#line 63 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CCliente.razor"
                                 item.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n                            ");
                __builder2.OpenElement(92, "td");
                __builder2.AddContent(93, 
#nullable restore
#line 64 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CCliente.razor"
                                 item.Fecha

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n");
#nullable restore
#line 66 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CCliente.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CCliente.razor"
                     
                }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(96, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\r\n        ");
                __builder2.OpenElement(99, "div");
                __builder2.AddAttribute(100, "class", "form-row col-12 justify-content-center");
                __builder2.AddMarkupContent(101, "\r\n            ");
                __builder2.OpenElement(102, "nav");
                __builder2.AddMarkupContent(103, "\r\n                ");
                __builder2.OpenElement(104, "ul");
                __builder2.AddAttribute(105, "class", "pagination");
                __builder2.AddMarkupContent(106, "\r\n                    ");
                __builder2.OpenElement(107, "li");
                __builder2.AddAttribute(108, "class", "page-item bt");
                __builder2.AddMarkupContent(109, "\r\n                        ");
                __builder2.OpenElement(110, "a");
                __builder2.AddAttribute(111, "class", "page-link");
                __builder2.AddAttribute(112, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 75 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CCliente.razor"
                                                       PaginaAnterior

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(113, "\r\n                            <span class=\"oi oi-media-skip-backward \"></span>\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(114, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(115, "\r\n\r\n");
#nullable restore
#line 80 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CCliente.razor"
                     for (int i = 1; i <= Paginas; i++)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(116, "                        ");
                __builder2.OpenElement(117, "li");
                __builder2.AddAttribute(118, "class", " " + (
#nullable restore
#line 82 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CCliente.razor"
                                      PaginaActual == i ? "text-danger" : "page-item"

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(119, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 82 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CCliente.razor"
                                                                                                  Mover

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(120, " ");
                __builder2.OpenElement(121, "a");
                __builder2.AddAttribute(122, "class", "page-link disabled");
                __builder2.AddContent(123, 
#nullable restore
#line 82 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CCliente.razor"
                                                                                                                                         i

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(124, "\r\n");
#nullable restore
#line 83 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CCliente.razor"

                    }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(125, "\r\n                    ");
                __builder2.OpenElement(126, "li");
                __builder2.AddAttribute(127, "class", "page-item");
                __builder2.AddMarkupContent(128, "\r\n                        ");
                __builder2.OpenElement(129, "a");
                __builder2.AddAttribute(130, "class", "page-link");
                __builder2.AddAttribute(131, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 87 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CCliente.razor"
                                                       PaginaSiguiente

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(132, "\r\n                            <span class=\"oi oi-media-skip-forward \"></span>\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(133, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(134, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(135, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(136, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(137, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(138, "\r\n\r\n");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(139, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 100 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CCliente.razor"
       

    private List<Clientes> lista { get; set; }
    private List<Clientes> listapaginada { get; set; }

    private string Filtro { get; set; }
    private string Criterio { get; set; }
    Paginacion paginacion = new Paginacion();
    double Paginas = 0;
    double Elementos = 0;
    int PaginaActual = 0;






    protected override void OnInitialized()
    {
        lista = ClienteBLL.GetList(C => true);
        Filtro = "Todo";
        IniciarPaginacion();
    }



    public void IniciarPaginacion()
    {
        PaginaActual = 1;
        Elementos = lista.Count();
        Paginas = Math.Ceiling(Elementos / paginacion.Mostrar);
        listapaginada = lista.Take(paginacion.Mostrar).ToList();
    }

    private void PaginaSiguiente()
    {
        if (PaginaActual < Paginas)
        {
            PaginaActual++;
            listapaginada = lista
                .Skip((PaginaActual - 1) * paginacion.Mostrar)
                .Take(paginacion.Mostrar)
                .ToList();
        }
    }
    private void Mover()
    {
        if (PaginaActual < Paginas)
        {
            PaginaActual++;
            listapaginada = lista
                .Skip((PaginaActual - 1) * paginacion.Mostrar)
                .Take(paginacion.Mostrar)
                .ToList();
        }
        else if (PaginaActual > 1)
        {
            PaginaActual--;
            listapaginada = lista
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
            listapaginada = lista
                .Skip((PaginaActual - 1) * paginacion.Mostrar)
                .Take(paginacion.Mostrar)
                .ToList();
        }
    }




    private void Buscar()
    {
        try
        {
            if (Filtro == null)
            {
                toast.ShowWarning("Selecciones un filtro");
            }
            else
            {
                if (Filtro != null)
                {

                    switch (Filtro)
                    {
                        case "Todo":
                            lista= ClienteBLL.GetList(e => true);

                            break;
                        case "Id":
                            lista = ClienteBLL.GetList(e => e.ClienteId == Convert.ToInt32(Criterio));
                            break;
                        case "Nombre":
                            lista = ClienteBLL.GetList(e => e.Nombre == Criterio);
                            break;
                        case "Cedula":
                            lista = ClienteBLL.GetList(e => e.Cedula == Criterio);
                            break;

                    }
                }
                else
                {
                    toast.ShowWarning("debes de insertar un dato al criterio");
                }
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toast { get; set; }
    }
}
#pragma warning restore 1591
