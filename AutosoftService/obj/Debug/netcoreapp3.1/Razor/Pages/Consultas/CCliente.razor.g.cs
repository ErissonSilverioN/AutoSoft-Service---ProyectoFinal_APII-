#pragma checksum "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal\AutosoftService\Pages\Consultas\CCliente.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba0da98ae504a3f53388ce810bec29b2eec273ba"
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
#line 1 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal\AutosoftService\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal\AutosoftService\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal\AutosoftService\_Imports.razor"
using AutosoftService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal\AutosoftService\_Imports.razor"
using AutosoftService.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal\AutosoftService\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal\AutosoftService\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal\AutosoftService\Pages\Consultas\CCliente.razor"
using BLL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal\AutosoftService\Pages\Consultas\CCliente.razor"
using Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Ccliente")]
    public partial class CCliente : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<div class=\"card-header\">\r\n        <h3>Consultas De Clientes</h3>\r\n    </div>\r\n\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "input-group mb-4");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "input-group");
            __builder.AddMarkupContent(12, "\r\n\r\n                ");
            __builder.AddMarkupContent(13, "<label for=\"filtro\">Filtro: </label>\r\n                ");
            __builder.OpenElement(14, "select");
            __builder.AddAttribute(15, "class", "form-control ml-3 mr-3");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal\AutosoftService\Pages\Consultas\CCliente.razor"
                                                              Filtro

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Filtro = __value, Filtro));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "option");
            __builder.AddAttribute(20, "value", true);
            __builder.AddAttribute(21, "disabled", true);
            __builder.AddAttribute(22, "selected", true);
            __builder.AddContent(23, "Seleccione un filtro");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "option");
            __builder.AddAttribute(26, "value", "Todo");
            __builder.AddContent(27, "Todo");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.OpenElement(29, "option");
            __builder.AddAttribute(30, "value", "ID");
            __builder.AddContent(31, "ID");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.OpenElement(33, "option");
            __builder.AddAttribute(34, "value", "Nombre");
            __builder.AddContent(35, "Nombre");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.OpenElement(37, "option");
            __builder.AddAttribute(38, "value", "Cedula");
            __builder.AddContent(39, "cedula");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n\r\n                ");
            __builder.AddMarkupContent(42, "<label for=\"criterio ml-3 mr-3\"> Criterio: </label>\r\n                ");
            __builder.OpenElement(43, "input");
            __builder.AddAttribute(44, "type", "search");
            __builder.AddAttribute(45, "class", "form-control ml-3 mr-3");
            __builder.AddAttribute(46, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal\AutosoftService\Pages\Consultas\CCliente.razor"
                                                                                 Criterio

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Criterio = __value, Criterio));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n\r\n                ");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "type", "button");
            __builder.AddAttribute(51, "class", "btn btn-primary");
            __builder.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal\AutosoftService\Pages\Consultas\CCliente.razor"
                                                                        Buscar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(53, "Buscar ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n\r\n        ");
            __builder.OpenElement(57, "table");
            __builder.AddAttribute(58, "class", " table mb-3 mt-3");
            __builder.AddAttribute(59, "id", "example");
            __builder.AddMarkupContent(60, "\r\n            ");
            __builder.AddMarkupContent(61, @"<thead class=""thead-light"">
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
            __builder.OpenElement(62, "tbody");
            __builder.AddMarkupContent(63, "\r\n\r\n");
#nullable restore
#line 48 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal\AutosoftService\Pages\Consultas\CCliente.razor"
                 foreach (var item in lista)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(64, "                    ");
            __builder.OpenElement(65, "tr");
            __builder.AddAttribute(66, "class", "table-striped");
            __builder.AddMarkupContent(67, "\r\n                        ");
            __builder.OpenElement(68, "td");
            __builder.AddContent(69, 
#nullable restore
#line 51 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal\AutosoftService\Pages\Consultas\CCliente.razor"
                             item.ClienteId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                        ");
            __builder.OpenElement(71, "td");
            __builder.AddContent(72, 
#nullable restore
#line 52 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal\AutosoftService\Pages\Consultas\CCliente.razor"
                             item.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                        ");
            __builder.OpenElement(74, "td");
            __builder.AddContent(75, 
#nullable restore
#line 53 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal\AutosoftService\Pages\Consultas\CCliente.razor"
                             item.Cedula

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                        ");
            __builder.OpenElement(77, "td");
            __builder.AddContent(78, 
#nullable restore
#line 54 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal\AutosoftService\Pages\Consultas\CCliente.razor"
                             item.Telefono

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                        ");
            __builder.OpenElement(80, "td");
            __builder.AddContent(81, 
#nullable restore
#line 55 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal\AutosoftService\Pages\Consultas\CCliente.razor"
                             item.Direccion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                        ");
            __builder.OpenElement(83, "td");
            __builder.AddContent(84, 
#nullable restore
#line 56 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal\AutosoftService\Pages\Consultas\CCliente.razor"
                             item.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                        ");
            __builder.OpenElement(86, "td");
            __builder.AddContent(87, 
#nullable restore
#line 57 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal\AutosoftService\Pages\Consultas\CCliente.razor"
                             item.Fecha

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n");
#nullable restore
#line 59 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal\AutosoftService\Pages\Consultas\CCliente.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(90, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 70 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal\AutosoftService\Pages\Consultas\CCliente.razor"
       

    private List<Clientes> lista { get; set; }
    //  private List<Usuarios> listapaginada { get; set; }

    private string Filtro { get; set; }
    private string Criterio { get; set; }







    protected override void OnInitialized()
    {
        lista = ClienteBLL.GetList(C => true);
        Filtro = "Todo";

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
