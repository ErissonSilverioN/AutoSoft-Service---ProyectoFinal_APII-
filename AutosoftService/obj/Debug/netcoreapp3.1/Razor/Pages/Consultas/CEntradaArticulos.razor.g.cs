#pragma checksum "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Consultas\CEntradaArticulos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "487b58add67afdbe1f55a4e167cf5715b7af83fa"
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
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Consultas\CEntradaArticulos.razor"
                 Lista

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n\r\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "card");
                __builder2.AddMarkupContent(6, "\r\n\r\n    \r\n        ");
                __builder2.AddMarkupContent(7, "<div class=\"card-header\">\r\n            <div class=\"text-center\">\r\n                <h3>Consulta de Entrada</h3>\r\n            </div>\r\n        </div>\r\n\r\n        ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "card-body");
                __builder2.AddMarkupContent(10, "\r\n\r\n\r\n            ");
                __builder2.OpenElement(11, "form");
                __builder2.AddMarkupContent(12, "\r\n\r\n                <br>\r\n\r\n                ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "form-row");
                __builder2.AddMarkupContent(15, "\r\n\r\n                    <div class=\"col-sm-0     col-md-0     col-lg-1     col-xl-2\"></div>\r\n\r\n                    ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "form-inline DivConsulta col-sm-12     col-md-6     col-lg-5     col-xl-4");
                __builder2.AddMarkupContent(18, "\r\n                        ");
                __builder2.AddMarkupContent(19, "<label for=\"Filtro\" class=\"LabelConsulta     col-sm-3     col-md-2\">Filtro: </label>\r\n                        ");
                __builder2.OpenElement(20, "select");
                __builder2.AddAttribute(21, "class", "form-control     col-sm-8     col-md-9");
                __builder2.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Consultas\CEntradaArticulos.razor"
                                                                                      Filtro

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Filtro = __value, Filtro));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(24, "\r\n                            ");
                __builder2.OpenElement(25, "option");
                __builder2.AddAttribute(26, "value", "0");
                __builder2.AddContent(27, "Todo");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n                            ");
                __builder2.OpenElement(29, "option");
                __builder2.AddAttribute(30, "value", "1");
                __builder2.AddContent(31, "Codigo");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n\r\n\r\n                    ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "form-inline DivConsulta col-sm-12     col-md-6     col-lg-5     col-xl-4");
                __builder2.AddMarkupContent(37, "\r\n                        ");
                __builder2.AddMarkupContent(38, "<label for=\"Criterio\" class=\"LabelConsulta     col-sm-3      col-md-2\">Criterio: </label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(39);
                __builder2.AddAttribute(40, "class", "form-control     col-sm-8     col-md-9");
                __builder2.AddAttribute(41, "placeholder", "Criterio");
                __builder2.AddAttribute(42, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 43 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Consultas\CEntradaArticulos.razor"
                                                 Criterio

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Criterio = __value, Criterio))));
                __builder2.AddAttribute(44, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Criterio));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, "\r\n                        ");
                __builder2.OpenElement(46, "p");
                __builder2.AddAttribute(47, "class", "validation-message");
                __builder2.AddContent(48, " ");
                __builder2.AddContent(49, 
#nullable restore
#line 44 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Consultas\CEntradaArticulos.razor"
                                                        Mensaje

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(50, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n\r\n                    <div class=\"col-sm-0     col-md-0     col-lg-1     col-xl-2\"></div>\r\n\r\n                    <br>\r\n\r\n\r\n                    ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "DivConsulta text-center     col-12");
                __builder2.AddMarkupContent(55, "\r\n                        ");
                __builder2.OpenElement(56, "input");
                __builder2.AddAttribute(57, "class", "ml-1");
                __builder2.AddAttribute(58, "type", "checkbox");
                __builder2.AddAttribute(59, "style", "margin-top:15px");
                __builder2.AddAttribute(60, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 53 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Consultas\CEntradaArticulos.razor"
                                                                         Filtro_Fecha

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(61, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Filtro_Fecha = __value, Filtro_Fecha));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "&nbsp;&nbsp;Filtrar por Fecha\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n\r\n                    <div class=\"col-sm-0     col-md-0     col-lg-1     col-xl-2\"></div>\r\n\r\n\r\n                    ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "form-inline DivConsulta col-sm-12     col-md-6     col-lg-5     col-xl-4");
                __builder2.AddMarkupContent(66, "\r\n                        ");
                __builder2.AddMarkupContent(67, "<label for=\"Desde\" class=\"LabelConsulta     col-sm-3     col-md-2\">Desde: </label>\r\n                        ");
                __Blazor.AutosoftService.Pages.Consultas.CEntradaArticulos.TypeInference.CreateInputDate_0(__builder2, 68, 69, "form-control     col-sm-8     col-md-9", 70, 
#nullable restore
#line 61 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Consultas\CEntradaArticulos.razor"
                                                 Desde

#line default
#line hidden
#nullable disable
                , 71, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Desde = __value, Desde)), 72, () => Desde);
                __builder2.AddMarkupContent(73, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n\r\n\r\n                    ");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "form-inline DivConsulta col-sm-12     col-md-6     col-lg-5     col-xl-4");
                __builder2.AddMarkupContent(77, "\r\n                        ");
                __builder2.AddMarkupContent(78, "<label for=\"Hasta\" class=\"LabelConsulta     col-sm-3     col-md-2\">Hasta: </label>\r\n                        ");
                __Blazor.AutosoftService.Pages.Consultas.CEntradaArticulos.TypeInference.CreateInputDate_1(__builder2, 79, 80, "form-control     col-sm-8     col-md-9", 81, 
#nullable restore
#line 67 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Consultas\CEntradaArticulos.razor"
                                                 Hasta

#line default
#line hidden
#nullable disable
                , 82, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Hasta = __value, Hasta)), 83, () => Hasta);
                __builder2.AddMarkupContent(84, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n\r\n\r\n                    \r\n                    ");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "DivConsulta text-center     container     col-sm-12     col-md-12          col-lg-1     col-xl-1");
                __builder2.AddMarkupContent(88, "\r\n                        ");
                __builder2.OpenElement(89, "button");
                __builder2.AddAttribute(90, "type", "button");
                __builder2.AddAttribute(91, "class", "btn btn-primary");
                __builder2.AddAttribute(92, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Consultas\CEntradaArticulos.razor"
                                                                                Buscar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(93, " Buscar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n\r\n\r\n                    <div class=\"col-sm-0     col-md-0     col-lg-1     col-xl-2\"></div>\r\n\r\n\r\n                    ");
                __builder2.OpenElement(96, "table");
                __builder2.AddAttribute(97, "class", "table");
                __builder2.AddAttribute(98, "style", "margin-top: 20px");
                __builder2.AddMarkupContent(99, "\r\n                        ");
                __builder2.AddMarkupContent(100, @"<thead class=""thead-light"">
                            <tr>
                                <th>Codigo</th>
                                <th>Fecha</th>
                                <th>Codigo Articulo</th>
                                <th>Cantidad</th>
                                <th></th>
                            </tr>
                        </thead>
                        ");
                __builder2.OpenElement(101, "tbody");
                __builder2.AddMarkupContent(102, "\r\n");
#nullable restore
#line 91 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Consultas\CEntradaArticulos.razor"
                             if (Paginado.Count == 0)
                            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(103, "                                ");
                __builder2.AddMarkupContent(104, "<tr>\r\n                                    <th colspan=\"12\" style=\"color:black; text-align: center\">\"No hay datos que mostrar\"</th>\r\n                                </tr>\r\n");
#nullable restore
#line 96 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Consultas\CEntradaArticulos.razor"
                            }
                            else
                            {

                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Consultas\CEntradaArticulos.razor"
                                 foreach (var item in Paginado)
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(105, "                                    ");
                __builder2.OpenElement(106, "tr");
                __builder2.AddMarkupContent(107, "\r\n                                        ");
                __builder2.OpenElement(108, "th");
                __builder2.AddContent(109, 
#nullable restore
#line 103 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Consultas\CEntradaArticulos.razor"
                                             item.EntradasArtId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(110, "\r\n                                        ");
                __builder2.OpenElement(111, "th");
                __builder2.AddContent(112, 
#nullable restore
#line 104 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Consultas\CEntradaArticulos.razor"
                                             item.Fecha.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(113, "\r\n                                        ");
                __builder2.OpenElement(114, "th");
                __builder2.AddContent(115, 
#nullable restore
#line 105 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Consultas\CEntradaArticulos.razor"
                                             item.ArticuloId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(116, "\r\n                                        ");
                __builder2.OpenElement(117, "th");
                __builder2.AddContent(118, 
#nullable restore
#line 106 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Consultas\CEntradaArticulos.razor"
                                             item.Cantidad

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(119, "\r\n\r\n\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(120, "\r\n");
#nullable restore
#line 110 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Consultas\CEntradaArticulos.razor"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Consultas\CEntradaArticulos.razor"
                                 
                            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(121, "                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(122, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(123, "\r\n\r\n\r\n\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(124, "\r\n\r\n\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(125, "\r\n            ");
                __builder2.OpenElement(126, "div");
                __builder2.AddAttribute(127, "class", "card-footer text-center");
                __builder2.AddMarkupContent(128, "\r\n                ");
                __builder2.OpenElement(129, "button");
                __builder2.AddAttribute(130, "class", "btn btn-outline-success");
                __builder2.AddAttribute(131, "data-toggle", "modal");
                __builder2.AddAttribute(132, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 122 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Consultas\CEntradaArticulos.razor"
                                                                                      PDF

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(133, "data-target", "#myModals");
                __builder2.AddMarkupContent(134, "<i class=\"oi oi-print\"></i> Generar Reporte");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(135, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(136, "\r\n            ");
                __builder2.OpenElement(137, "div");
                __builder2.AddAttribute(138, "class", "card-footer");
                __builder2.AddMarkupContent(139, "\r\n                ");
                __builder2.OpenElement(140, "div");
                __builder2.AddAttribute(141, "class", "form-row col-12 justify-content-center");
                __builder2.AddMarkupContent(142, "\r\n                    ");
                __builder2.OpenElement(143, "nav");
                __builder2.AddAttribute(144, "aria-label", "Page navigation example");
                __builder2.AddMarkupContent(145, "\r\n                        ");
                __builder2.OpenElement(146, "ul");
                __builder2.AddAttribute(147, "class", "pagination");
                __builder2.AddMarkupContent(148, "\r\n                            ");
                __builder2.OpenElement(149, "li");
                __builder2.AddAttribute(150, "class", "page-item");
                __builder2.AddMarkupContent(151, "\r\n                                ");
                __builder2.OpenElement(152, "a");
                __builder2.AddAttribute(153, "class", "page-link");
                __builder2.AddAttribute(154, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 129 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Consultas\CEntradaArticulos.razor"
                                                               PaginaAnterior

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(155, "\r\n                                    <span class=\"oi oi-media-skip-backward\"></span>\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(156, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(157, "\r\n\r\n");
#nullable restore
#line 134 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Consultas\CEntradaArticulos.razor"
                             for (int i = 1; i <= Paginas; i++)
                            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(158, "                                ");
                __builder2.OpenElement(159, "li");
                __builder2.AddAttribute(160, "class", "page-item disabled");
                __builder2.OpenElement(161, "a");
                __builder2.AddAttribute(162, "class", "page-link");
                __builder2.AddContent(163, 
#nullable restore
#line 136 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Consultas\CEntradaArticulos.razor"
                                                                                     i

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(164, "\r\n");
#nullable restore
#line 137 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Consultas\CEntradaArticulos.razor"
                            }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(165, "\r\n                            ");
                __builder2.OpenElement(166, "li");
                __builder2.AddAttribute(167, "class", "page-item");
                __builder2.AddMarkupContent(168, "\r\n                                ");
                __builder2.OpenElement(169, "a");
                __builder2.AddAttribute(170, "class", "page-link");
                __builder2.AddAttribute(171, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 140 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Consultas\CEntradaArticulos.razor"
                                                               PaginaSiguiente

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(172, "\r\n                                    <span class=\"oi oi-media-skip-forward\"></span>\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(173, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(174, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(175, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(176, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(177, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(178, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(179, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(180, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(181, "\r\n\r\n");
            __builder.OpenElement(182, "div");
            __builder.AddAttribute(183, "class", "modal fade");
            __builder.AddAttribute(184, "id", "myModals");
            __builder.AddAttribute(185, "tabindex", "-1");
            __builder.AddAttribute(186, "role", "dialog");
            __builder.AddAttribute(187, "aria-labelledby", "myModalsLabel");
            __builder.AddAttribute(188, "aria-hidden", "true");
            __builder.AddMarkupContent(189, "\r\n    ");
            __builder.OpenElement(190, "div");
            __builder.AddAttribute(191, "class", "modal-dialog");
            __builder.AddMarkupContent(192, "\r\n        ");
            __builder.OpenElement(193, "div");
            __builder.AddAttribute(194, "class", "modal-content m-md-auto");
            __builder.AddMarkupContent(195, "\r\n            ");
            __builder.AddMarkupContent(196, "<div class=\"modal-header\">\r\n                <button type=\"button\" class=\"close text-danger\" data-dismiss=\"modal\" aria-hidden=\"true\">×</button>\r\n                <h4 class=\"modal-title\"></h4>\r\n            </div>\r\n            ");
            __builder.OpenElement(197, "div");
            __builder.AddAttribute(198, "class", "modal-body");
            __builder.AddMarkupContent(199, "\r\n                ");
            __builder.OpenElement(200, "div");
            __builder.AddAttribute(201, "style", "text-align: center;");
            __builder.AddMarkupContent(202, "\r\n                    ");
            __builder.OpenElement(203, "iframe");
            __builder.AddAttribute(204, "src", 
#nullable restore
#line 161 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Consultas\CEntradaArticulos.razor"
                                  pdfContent

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(205, "style", "width:950px; height:600px;");
            __builder.AddAttribute(206, "frameborder", "0");
            __builder.CloseElement();
            __builder.AddMarkupContent(207, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(208, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(209, "\r\n            ");
            __builder.AddMarkupContent(210, "<div class=\"modal-footer\">\r\n                <button type=\"button\" class=\"btn btn-default\" data-dismiss=\"modal\">Close</button>\r\n            </div>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(211, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(212, "\r\n");
            __builder.CloseElement();
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
namespace __Blazor.AutosoftService.Pages.Consultas.CEntradaArticulos
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
