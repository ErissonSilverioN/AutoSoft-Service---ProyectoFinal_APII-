#pragma checksum "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CArticulos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce9f1507ed5454a883b0c5257a2c636c9cca5170"
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
#line 3 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CArticulos.razor"
using AutosoftService.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CArticulos.razor"
using AutosoftService.BLL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CArticulos.razor"
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
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CArticulos.razor"
                 Lista

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n\r\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "card");
                __builder2.AddMarkupContent(6, "\r\n\r\n\r\n        ");
                __builder2.AddMarkupContent(7, "<div class=\"card-header\">\r\n            <div class=\"text-center\">\r\n                <h3>Consulta de Entrada</h3>\r\n            </div>\r\n        </div>\r\n\r\n\r\n        ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "card-body");
                __builder2.AddMarkupContent(10, "\r\n\r\n            ");
                __builder2.OpenElement(11, "form");
                __builder2.AddMarkupContent(12, "\r\n\r\n                <br>\r\n\r\n\r\n                ");
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
#line 33 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CArticulos.razor"
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
                __builder2.AddMarkupContent(32, "\r\n                            ");
                __builder2.OpenElement(33, "option");
                __builder2.AddAttribute(34, "value", "2");
                __builder2.AddContent(35, "Proveedor");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n                            ");
                __builder2.OpenElement(37, "option");
                __builder2.AddAttribute(38, "value", "3");
                __builder2.AddContent(39, "Precio");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n\r\n\r\n\r\n                    ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "form-inline DivConsulta col-sm-12     col-md-6     col-lg-5     col-xl-4");
                __builder2.AddMarkupContent(45, "\r\n                        ");
                __builder2.AddMarkupContent(46, "<label for=\"Criterio\" class=\"LabelConsulta     col-sm-3      col-md-2\">Criterio: </label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(47);
                __builder2.AddAttribute(48, "class", "form-control     col-sm-8     col-md-9");
                __builder2.AddAttribute(49, "placeholder", "Criterio");
                __builder2.AddAttribute(50, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 45 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CArticulos.razor"
                                                 Criterio

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Criterio = __value, Criterio))));
                __builder2.AddAttribute(52, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Criterio));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, "\r\n                        ");
                __builder2.OpenElement(54, "p");
                __builder2.AddAttribute(55, "class", "validation-message");
                __builder2.AddContent(56, " ");
                __builder2.AddContent(57, 
#nullable restore
#line 46 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CArticulos.razor"
                                                        Mensaje

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(58, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n\r\n                    <div class=\"col-sm-0     col-md-0     col-lg-1     col-xl-2\"></div>\r\n\r\n                    <br>\r\n\r\n                    ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "DivConsulta text-center     col-12");
                __builder2.AddMarkupContent(63, "\r\n                        ");
                __builder2.OpenElement(64, "input");
                __builder2.AddAttribute(65, "class", "ml-1");
                __builder2.AddAttribute(66, "type", "checkbox");
                __builder2.AddAttribute(67, "style", "margin-top:15px");
                __builder2.AddAttribute(68, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 54 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CArticulos.razor"
                                                                         BuscarPorFecha

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(69, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => BuscarPorFecha = __value, BuscarPorFecha));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "&nbsp;&nbsp;Filtrar por Fecha\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n\r\n                    <div class=\"col-sm-0     col-md-0     col-lg-1     col-xl-2\"></div>\r\n\r\n\r\n\r\n                    ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "form-inline DivConsulta col-sm-12     col-md-6     col-lg-5     col-xl-4");
                __builder2.AddMarkupContent(74, "\r\n                        ");
                __builder2.AddMarkupContent(75, "<label for=\"Desde\" class=\"LabelConsulta     col-sm-3     col-md-2\">Desde: </label>\r\n                        ");
                __Blazor.AutosoftService.Pages.Consultas.CArticulos.TypeInference.CreateInputDate_0(__builder2, 76, 77, "form-control     col-sm-8     col-md-9", 78, 
#nullable restore
#line 63 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CArticulos.razor"
                                                 Desde

#line default
#line hidden
#nullable disable
                , 79, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Desde = __value, Desde)), 80, () => Desde);
                __builder2.AddMarkupContent(81, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n\r\n\r\n                    ");
                __builder2.OpenElement(83, "div");
                __builder2.AddAttribute(84, "class", "form-inline DivConsulta col-sm-12     col-md-6     col-lg-5     col-xl-4");
                __builder2.AddMarkupContent(85, "\r\n                        ");
                __builder2.AddMarkupContent(86, "<label for=\"Hasta\" class=\"LabelConsulta     col-sm-3     col-md-2\">Hasta: </label>\r\n                        ");
                __Blazor.AutosoftService.Pages.Consultas.CArticulos.TypeInference.CreateInputDate_1(__builder2, 87, 88, "form-control     col-sm-8     col-md-9", 89, 
#nullable restore
#line 69 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CArticulos.razor"
                                                 Hasta

#line default
#line hidden
#nullable disable
                , 90, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Hasta = __value, Hasta)), 91, () => Hasta);
                __builder2.AddMarkupContent(92, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n\r\n\r\n                    ");
                __builder2.OpenElement(94, "div");
                __builder2.AddAttribute(95, "class", "DivConsulta text-center     container     col-sm-12     col-md-12          col-lg-1     col-xl-1");
                __builder2.AddMarkupContent(96, "\r\n                        ");
                __builder2.OpenElement(97, "button");
                __builder2.AddAttribute(98, "type", "button");
                __builder2.AddAttribute(99, "class", "btn btn-primary");
                __builder2.AddAttribute(100, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CArticulos.razor"
                                                                                Buscar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(101, "Buscar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n\r\n                    <div class=\"col-sm-0     col-md-0     col-lg-1     col-xl-2\"></div>\r\n\r\n\r\n\r\n\r\n                    ");
                __builder2.OpenElement(104, "table");
                __builder2.AddAttribute(105, "class", "table");
                __builder2.AddAttribute(106, "style", "margin-top: 20px");
                __builder2.AddMarkupContent(107, "\r\n                        ");
                __builder2.AddMarkupContent(108, @"<thead class=""thead-light"">
                            <tr>
                                <th>Codigo</th>
                                <th>Descripcion</th>
                                <th>Fecha</th>
                                <th>Proveedor ID</th>
                                <th>Cantidad</th>
                                <th>Precio</th>
                                <th></th>
                            </tr>
                        </thead>
                        ");
                __builder2.OpenElement(109, "tbody");
                __builder2.AddMarkupContent(110, "\r\n");
#nullable restore
#line 95 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CArticulos.razor"
                             if (Paginado.Count == 0)
                            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(111, "                                ");
                __builder2.AddMarkupContent(112, "<tr>\r\n                                    <th colspan=\"12\" style=\"color:black; text-align: center\">\"No hay datos que mostrar\"</th>\r\n                                </tr>\r\n");
#nullable restore
#line 100 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CArticulos.razor"
                            }
                            else
                            {

                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CArticulos.razor"
                                 foreach (var item in Paginado)
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(113, "                                    ");
                __builder2.OpenElement(114, "tr");
                __builder2.AddMarkupContent(115, "\r\n                                        ");
                __builder2.OpenElement(116, "th");
                __builder2.AddContent(117, 
#nullable restore
#line 107 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CArticulos.razor"
                                             item.ArticuloId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(118, "\r\n                                        ");
                __builder2.OpenElement(119, "th");
                __builder2.AddContent(120, 
#nullable restore
#line 108 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CArticulos.razor"
                                             item.Descripcion

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(121, "\r\n                                        ");
                __builder2.OpenElement(122, "th");
                __builder2.AddContent(123, 
#nullable restore
#line 109 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CArticulos.razor"
                                             item.Fecha.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(124, "\r\n                                        ");
                __builder2.OpenElement(125, "th");
                __builder2.AddContent(126, 
#nullable restore
#line 110 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CArticulos.razor"
                                             item.ProveedorId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(127, "\r\n                                        ");
                __builder2.OpenElement(128, "th");
                __builder2.AddContent(129, 
#nullable restore
#line 111 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CArticulos.razor"
                                             item.Existencia

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(130, "\r\n                                        ");
                __builder2.OpenElement(131, "th");
                __builder2.AddContent(132, 
#nullable restore
#line 112 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CArticulos.razor"
                                             item.Precio

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(133, "\r\n                                        \r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(134, "\r\n");
#nullable restore
#line 115 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CArticulos.razor"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CArticulos.razor"
                                 
                            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(135, "                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(136, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(137, "\r\n\r\n\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(138, "\r\n\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(139, "\r\n\r\n\r\n\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(140, "\r\n\r\n\r\n        ");
                __builder2.OpenElement(141, "div");
                __builder2.AddAttribute(142, "class", "card-footer");
                __builder2.AddMarkupContent(143, "\r\n            ");
                __builder2.OpenElement(144, "div");
                __builder2.AddAttribute(145, "class", "form-row col-12 justify-content-center");
                __builder2.AddMarkupContent(146, "\r\n                ");
                __builder2.OpenElement(147, "nav");
                __builder2.AddAttribute(148, "aria-label", "Page navigation example");
                __builder2.AddMarkupContent(149, "\r\n                    ");
                __builder2.OpenElement(150, "ul");
                __builder2.AddAttribute(151, "class", "pagination");
                __builder2.AddMarkupContent(152, "\r\n                        ");
                __builder2.OpenElement(153, "li");
                __builder2.AddAttribute(154, "class", "page-item");
                __builder2.AddMarkupContent(155, "\r\n                            ");
                __builder2.OpenElement(156, "a");
                __builder2.AddAttribute(157, "class", "page-link");
                __builder2.AddAttribute(158, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 135 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CArticulos.razor"
                                                           PaginaAnterior

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(159, "\r\n                                <span class=\"oi oi-media-skip-backward\"></span>\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(160, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(161, "\r\n\r\n");
#nullable restore
#line 140 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CArticulos.razor"
                         for (int i = 1; i <= Paginas; i++)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(162, "                            ");
                __builder2.OpenElement(163, "li");
                __builder2.AddAttribute(164, "class", "page-item disabled");
                __builder2.OpenElement(165, "a");
                __builder2.AddAttribute(166, "class", "page-link");
                __builder2.AddContent(167, 
#nullable restore
#line 142 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CArticulos.razor"
                                                                                 i

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(168, "\r\n");
#nullable restore
#line 143 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CArticulos.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(169, "\r\n                        ");
                __builder2.OpenElement(170, "li");
                __builder2.AddAttribute(171, "class", "page-item");
                __builder2.AddMarkupContent(172, "\r\n                            ");
                __builder2.OpenElement(173, "a");
                __builder2.AddAttribute(174, "class", "page-link");
                __builder2.AddAttribute(175, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 146 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CArticulos.razor"
                                                           PaginaSiguiente

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(176, "\r\n                                <span class=\"oi oi-media-skip-forward\"></span>\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(177, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(178, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(179, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(180, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(181, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(182, "\r\n\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(183, "\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 160 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Consultas\CArticulos.razor"
       


    List<Articulos> Lista { get; set; }
    List<Articulos> Paginado { get; set; }

    string Filtro;
    string Criterio;
    DateTime Desde;
    DateTime Hasta;
    bool BuscarPorFecha;
    string Mensaje;

    public List<Articulos> ListadoArticulos = new List<Articulos>();
    Proveedores proveedores = new Proveedores();


    double Paginas = 0;
    double Elementos = 0;
    int PaginaActual = 0;


    Contexto db = new Contexto();
    Paginacion paginacion = new Paginacion();

    List<Articulos> ListaTemp = new List<Articulos>();


    protected override void OnInitialized()
    {
        Filtro = "0";
        Criterio = string.Empty;
        Desde = DateTime.Now;
        Hasta = DateTime.Now;
        BuscarPorFecha = false;
        Mensaje = string.Empty;
        CargarLista();
    }


    ArticuloBLL articuloBLL = new ArticuloBLL();
    private void CargarLista()
    {
        ListadoArticulos = articuloBLL.GetList(e => true);
        Lista = new List<Articulos>();
        foreach (var item in ListadoArticulos)
        {
            Articulos p = new Articulos();
            p.ArticuloId = item.ArticuloId;
            p.Descripcion = item.Descripcion;
            p.Fecha = item.Fecha;
            p.Categoria = item.Categoria;
            p.ProveedorId = item.ProveedorId;
            p.Precio = item.Precio;
            p.Existencia = item.Existencia;

            Lista.Add(p);
        }

        IniciarPaginacion();
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
        if (Filtro == "0")
            ListaTemp = Lista;

        if (BuscarPorFecha == true && ListaTemp.Count > 0)
        {
            Lista = new List<Articulos>();
            foreach (var item in ListaTemp)
            {
                if (item.Fecha.Date >= Desde.Date && item.Fecha.Date <= Hasta.Date)
                {
                    Lista.Add(item);
                }
            }
            BuscarPorFecha = false;
        }
        else
        {
            Lista = new List<Articulos>();
            Lista = ListaTemp;
        }
        IniciarPaginacion();
    }



    private void Buscar()
    {
        if (Filtro == "0")
        {
            CargarLista();
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
                CargarLista();
                List<Articulos> ListadoTemp = Lista;
                Mensaje = string.Empty;
                switch (Filtro)
                {
                    case "0":
                        ListadoArticulos = articuloBLL.GetList(e => true);
                        break;

                    case "1":
                        ListadoTemp = new List<Articulos>();
                        foreach (var item in ListadoArticulos)
                        {
                            if (Convert.ToString(item.ArticuloId).Contains(Criterio))
                            {
                                Articulos p = new Articulos();
                                p.ArticuloId = item.ArticuloId;
                                p.Descripcion = item.Descripcion;
                                p.Fecha = item.Fecha;
                                p.Categoria = item.Categoria;

                                p.ProveedorId = item.ProveedorId;
                                p.Precio = item.Precio;
                                p.Existencia = item.Existencia;

                                ListadoTemp.Add(p);
                            }
                        }
                        break;


                    case "2":
                        ListadoTemp = new List<Articulos>();
                        foreach (var item in ListadoArticulos)
                        {
                            if (item.Descripcion.Contains(Criterio))
                            {
                                Articulos p = new Articulos();
                                p.ArticuloId = item.ArticuloId;
                                p.Descripcion = item.Descripcion;
                                p.Fecha = item.Fecha;
                                p.Categoria = item.Categoria;

                                p.ProveedorId = item.ProveedorId;
                                p.Precio = item.Precio;
                                p.Existencia = item.Existencia;

                                ListadoTemp.Add(p);
                            }
                        }
                        break;

                        //    case "3":
                        //        ListadoTemp = new List<Articulos>();
                        //        foreach (var item in ListadoArticulos)
                        //        {
                        //            Articulos p = new Articulos();
                        //            p.ArticuloId = item.ArticuloId;
                        //            p.Descripcion = item.Descripcion;
                        //            p.Fecha = item.Fecha;
                        //            p.Categoria = item.Categoria;

                        //            p.ProveedorId = item.ProveedorId;
                        //            p.Precio = item.Precio;
                        //            p.Existencia = item.Existencia;

                        //            ListadoTemp.Add(p);
                        //        }
                        //}
                        //break;




                }
                if (BuscarPorFecha == true)
                {
                    Lista = new List<Articulos>();
                    foreach (var item in ListaTemp)
                    {
                        if (item.Fecha.Date >= Desde.Date && item.Fecha.Date <= Hasta.Date)
                        {
                            Lista.Add(item);
                        }
                    }
                    BuscarPorFecha = false;
                }
                else
                {
                    Lista = new List<Articulos>();
                    Lista = ListaTemp;
                }
            }
        }
    }




#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.AutosoftService.Pages.Consultas.CArticulos
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
