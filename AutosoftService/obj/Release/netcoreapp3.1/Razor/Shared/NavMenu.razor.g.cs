#pragma checksum "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal34\AutosoftService\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d6a67d9a3f490eb1fd505810ec3e32b2270d5cb"
// <auto-generated/>
#pragma warning disable 1591
namespace AutosoftService.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal34\AutosoftService\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal34\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal34\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal34\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal34\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal34\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal34\AutosoftService\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal34\AutosoftService\_Imports.razor"
using AutosoftService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal34\AutosoftService\_Imports.razor"
using AutosoftService.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal34\AutosoftService\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal34\AutosoftService\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal34\AutosoftService\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark ");
            __builder.AddMarkupContent(2, "\r\n\r\n\r\n    ");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href=\" \" style=\"   text-shadow: #f8d77b; color: #0c3682;\r\n        font-size: 30px;\r\n        text-align: center;\r\n        font-family: Luminari, fantasy;\r\n        text-decoration: underline\r\n    \"> AUTOSOFT SERVICE</a>\r\n\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal34\AutosoftService\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(7, "\r\n        <span class=\"navbar-toggler-icon\"></span>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(10);
            __builder.AddAttribute(11, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.AddMarkupContent(13, @"<a>
            <span aria-hidden=""true"" class=""mdi:location-exit"" style=""color:white; text-align:center""> </span>

            <p style=""color:ghostwhite; font-size:20px; font-family:Georgia, 'Times New Roman', Times, serif,cursive; text-align:center; margin-top: 20px"">
                ¡¡LA SOLUCION A TU NEGOCIO!!

            </p>
        </a>




    ");
            }
            ));
            __builder.AddAttribute(14, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(15, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(16, "\r\n\r\n\r\n\r\n\r\n");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", 
#nullable restore
#line 43 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal34\AutosoftService\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal34\AutosoftService\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.OpenElement(21, "ul");
            __builder.AddAttribute(22, "class", "nav flex-column");
            __builder.AddMarkupContent(23, "\r\n\r\n\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(24);
            __builder.AddAttribute(25, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(26, "\r\n                ");
                __builder2.OpenElement(27, "li");
                __builder2.AddAttribute(28, "class", "nav-item px-3");
                __builder2.AddMarkupContent(29, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(30);
                __builder2.AddAttribute(31, "class", "nav-link");
                __builder2.AddAttribute(32, "href", "");
                __builder2.AddAttribute(33, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 50 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal34\AutosoftService\Shared\NavMenu.razor"
                                                             NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(35, "\r\n                        <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Home\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n\r\n\r\n                ");
                __builder2.OpenElement(38, "li");
                __builder2.AddAttribute(39, "class", "nav-item px-3");
                __builder2.AddMarkupContent(40, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(41);
                __builder2.AddAttribute(42, "class", "nav-link");
                __builder2.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal34\AutosoftService\Shared\NavMenu.razor"
                                                        ToggleRegistrosMenu

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(45, "\r\n                        <span class=\"oi oi-plus\" aria-hidden=\"true\"></span> Registros\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\r\n");
#nullable restore
#line 61 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal34\AutosoftService\Shared\NavMenu.razor"
                     if (stateRegister)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(47, "                        ");
                __builder2.OpenElement(48, "ul");
                __builder2.AddAttribute(49, "class", "children");
                __builder2.AddMarkupContent(50, "\r\n                            ");
                __builder2.OpenElement(51, "li");
                __builder2.AddAttribute(52, "class", "list-unstyled");
                __builder2.AddMarkupContent(53, "\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(54);
                __builder2.AddAttribute(55, "class", "nav-link");
                __builder2.AddAttribute(56, "href", "/RUsuarios");
                __builder2.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(58, "\r\n                                    <span aria-hidden=\"true\" class=\"oi oi-person\" style=\"color:white\"></span>");
                    __builder3.AddMarkupContent(59, "<p style=\"color:white; font-size:14px; vertical-align:central; margin-top: 18px\">Usuarios</p>\r\n                                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(60, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n                            ");
                __builder2.OpenElement(62, "li");
                __builder2.AddAttribute(63, "class", "list-unstyled");
                __builder2.AddMarkupContent(64, "\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(65);
                __builder2.AddAttribute(66, "class", "nav-link");
                __builder2.AddAttribute(67, "href", "/RClientes");
                __builder2.AddAttribute(68, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(69, "\r\n                                    <span aria-hidden=\"true\" class=\"oi oi-people\" style=\"color:white\"></span>");
                    __builder3.AddMarkupContent(70, "<p style=\"color:white; font-size:14px; vertical-align:central; margin-top: 18px\">Clientes</p>\r\n                                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(71, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n\r\n                            ");
                __builder2.OpenElement(73, "li");
                __builder2.AddAttribute(74, "class", "list-unstyled");
                __builder2.AddMarkupContent(75, "\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(76);
                __builder2.AddAttribute(77, "class", "nav-link");
                __builder2.AddAttribute(78, "href", "/RProveedores");
                __builder2.AddAttribute(79, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(80, "\r\n                                    <span aria-hidden=\"true\" class=\"oi oi-people\" style=\"color:white\"></span>");
                    __builder3.AddMarkupContent(81, "<p style=\"color:white; font-size:14px; vertical-align:central; margin-top: 18px\">Proveedores</p>\r\n                                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(82, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n\r\n                            ");
                __builder2.OpenElement(84, "li");
                __builder2.AddAttribute(85, "class", "list-unstyled");
                __builder2.AddMarkupContent(86, "\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(87);
                __builder2.AddAttribute(88, "class", "nav-link");
                __builder2.AddAttribute(89, "href", "/RPedidos");
                __builder2.AddAttribute(90, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(91, "\r\n                                    <span aria-hidden=\"true\" class=\"oi oi-cart\" style=\"color:white\"></span>");
                    __builder3.AddMarkupContent(92, "<p style=\"color:white; font-size:14px; vertical-align:central; margin-top: 18px\">Pedidos</p>\r\n                                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(93, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n\r\n                            ");
                __builder2.OpenElement(95, "li");
                __builder2.AddAttribute(96, "class", "list-unstyled");
                __builder2.AddMarkupContent(97, "\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(98);
                __builder2.AddAttribute(99, "class", "nav-link");
                __builder2.AddAttribute(100, "href", "/Vehiculos");
                __builder2.AddAttribute(101, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(102, "\r\n                                    <span aria-hidden=\"true\" class=\"oi oi-wrench\" style=\"color:white\"></span>");
                    __builder3.AddMarkupContent(103, "<p style=\"color:white; font-size:14px; vertical-align:central; margin-top: 18px\">Vehiculos</p>\r\n                                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(104, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\r\n\r\n                            ");
                __builder2.OpenElement(106, "li");
                __builder2.AddAttribute(107, "class", "list-unstyled");
                __builder2.AddMarkupContent(108, "\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(109);
                __builder2.AddAttribute(110, "class", "nav-link");
                __builder2.AddAttribute(111, "href", "/rArticulos");
                __builder2.AddAttribute(112, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(113, "\r\n                                    <span aria-hidden=\"true\" class=\"oi oi-tags\" style=\"color:white\"></span>");
                    __builder3.AddMarkupContent(114, "<p style=\"color:white; font-size:14px; vertical-align:central; margin-top: 18px\">Articulos</p>\r\n                                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(115, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(116, "\r\n\r\n                            ");
                __builder2.OpenElement(117, "li");
                __builder2.AddAttribute(118, "class", "list-unstyled");
                __builder2.AddMarkupContent(119, "\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(120);
                __builder2.AddAttribute(121, "class", "nav-link");
                __builder2.AddAttribute(122, "href", "/rEntradaArticulos");
                __builder2.AddAttribute(123, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(124, "\r\n                                    <span aria-hidden=\"true\" class=\"oi oi-clipboard\" style=\"color:white\"></span>");
                    __builder3.AddMarkupContent(125, "<p style=\"color:white; font-size:14px; vertical-align:central; margin-top: 18px\">Entrada de Articuos</p>\r\n                                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(126, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(127, "\r\n\r\n                            ");
                __builder2.OpenElement(128, "li");
                __builder2.AddAttribute(129, "class", "list-unstyled");
                __builder2.AddMarkupContent(130, "\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(131);
                __builder2.AddAttribute(132, "class", "nav-link");
                __builder2.AddAttribute(133, "href", "/RFacturas");
                __builder2.AddAttribute(134, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(135, "\r\n                                    <span aria-hidden=\"true\" class=\"oi oi-credit-card\" style=\"color:white\"></span>");
                    __builder3.AddMarkupContent(136, "<p style=\"color:white; font-size:14px; vertical-align:central; margin-top: 18px\">Facturas</p>\r\n                                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(137, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(138, "\r\n\r\n                            ");
                __builder2.OpenElement(139, "li");
                __builder2.AddAttribute(140, "class", "list-unstyled");
                __builder2.AddMarkupContent(141, "\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(142);
                __builder2.AddAttribute(143, "class", "nav-link");
                __builder2.AddAttribute(144, "href", "/RPagos");
                __builder2.AddAttribute(145, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(146, "\r\n                                    <span aria-hidden=\"true\" class=\"oi oi-dollar\" style=\"color:white\"></span>");
                    __builder3.AddMarkupContent(147, "<p style=\"color:white; font-size:14px; vertical-align:central; margin-top: 18px\">Pagos</p>\r\n                                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(148, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(149, "\r\n\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(150, "\r\n");
#nullable restore
#line 118 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal34\AutosoftService\Shared\NavMenu.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(151, "                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(152, "\r\n\r\n\r\n\r\n                ");
                __builder2.OpenElement(153, "li");
                __builder2.AddAttribute(154, "class", "nav-item px-3");
                __builder2.AddMarkupContent(155, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(156);
                __builder2.AddAttribute(157, "class", "nav-link");
                __builder2.AddAttribute(158, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 125 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal34\AutosoftService\Shared\NavMenu.razor"
                                                        ToggleConsultasMenu

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(159, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(160, "\r\n                        <span class=\"oi oi-folder\" aria-hidden=\"true\"></span> Consultas\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(161, "\r\n");
#nullable restore
#line 128 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal34\AutosoftService\Shared\NavMenu.razor"
                     if (stateConsultas)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(162, "                        ");
                __builder2.OpenElement(163, "ul");
                __builder2.AddAttribute(164, "class", "children");
                __builder2.AddMarkupContent(165, "\r\n                            ");
                __builder2.OpenElement(166, "li");
                __builder2.AddAttribute(167, "class", "list-unstyled");
                __builder2.AddMarkupContent(168, "\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(169);
                __builder2.AddAttribute(170, "class", "nav-link");
                __builder2.AddAttribute(171, "href", "/CUsuarios");
                __builder2.AddAttribute(172, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(173, "\r\n                                    <span aria-hidden=\"true\" class=\"oi oi-person\" style=\"color:white\"></span>");
                    __builder3.AddMarkupContent(174, "<p style=\"color:white; font-size:14px; vertical-align:central; margin-top: 18px\">Usuarios</p>\r\n                                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(175, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(176, "\r\n                            ");
                __builder2.OpenElement(177, "li");
                __builder2.AddAttribute(178, "class", "list-unstyled");
                __builder2.AddMarkupContent(179, "\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(180);
                __builder2.AddAttribute(181, "class", "nav-link");
                __builder2.AddAttribute(182, "href", "/Cclientes");
                __builder2.AddAttribute(183, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(184, "\r\n                                    <span aria-hidden=\"true\" class=\"oi oi-people\" style=\"color:white\"></span>");
                    __builder3.AddMarkupContent(185, "<p style=\"color:white; font-size:14px; vertical-align:central; margin-top: 18px\">Clientes</p>\r\n                                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(186, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(187, "\r\n\r\n                            ");
                __builder2.OpenElement(188, "li");
                __builder2.AddAttribute(189, "class", "list-unstyled");
                __builder2.AddMarkupContent(190, "\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(191);
                __builder2.AddAttribute(192, "class", "nav-link");
                __builder2.AddAttribute(193, "href", "/CProveedores");
                __builder2.AddAttribute(194, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(195, "\r\n                                    <span aria-hidden=\"true\" class=\"oi oi-people\" style=\"color:white\"></span>");
                    __builder3.AddMarkupContent(196, "<p style=\"color:white; font-size:14px; vertical-align:central; margin-top: 18px\">Proveedores</p>\r\n                                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(197, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(198, "\r\n\r\n                            ");
                __builder2.OpenElement(199, "li");
                __builder2.AddAttribute(200, "class", "list-unstyled");
                __builder2.AddMarkupContent(201, "\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(202);
                __builder2.AddAttribute(203, "class", "nav-link");
                __builder2.AddAttribute(204, "href", "/CPedidos");
                __builder2.AddAttribute(205, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(206, "\r\n                                    <span aria-hidden=\"true\" class=\"oi oi-cart\" style=\"color:white\"></span>");
                    __builder3.AddMarkupContent(207, "<p style=\"color:white; font-size:14px; vertical-align:central; margin-top: 18px\">Pedidos</p>\r\n                                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(208, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(209, "\r\n\r\n                            ");
                __builder2.OpenElement(210, "li");
                __builder2.AddAttribute(211, "class", "list-unstyled");
                __builder2.AddMarkupContent(212, "\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(213);
                __builder2.AddAttribute(214, "class", "nav-link");
                __builder2.AddAttribute(215, "href", "/CVehiculos");
                __builder2.AddAttribute(216, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(217, "\r\n                                    <span aria-hidden=\"true\" class=\"oi oi-wrench\" style=\"color:white\"></span>");
                    __builder3.AddMarkupContent(218, "<p style=\"color:white; font-size:14px; vertical-align:central; margin-top: 18px\">Vehiculos</p>\r\n                                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(219, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(220, "\r\n\r\n                            ");
                __builder2.OpenElement(221, "li");
                __builder2.AddAttribute(222, "class", "list-unstyled");
                __builder2.AddMarkupContent(223, "\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(224);
                __builder2.AddAttribute(225, "class", "nav-link");
                __builder2.AddAttribute(226, "href", "/CArticulos");
                __builder2.AddAttribute(227, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(228, "\r\n                                    <span aria-hidden=\"true\" class=\"oi oi-tags\" style=\"color:white\"></span>");
                    __builder3.AddMarkupContent(229, "<p style=\"color:white; font-size:14px; vertical-align:central; margin-top: 18px\">Articulos</p>\r\n                                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(230, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(231, "\r\n\r\n                            ");
                __builder2.OpenElement(232, "li");
                __builder2.AddAttribute(233, "class", "list-unstyled");
                __builder2.AddMarkupContent(234, "\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(235);
                __builder2.AddAttribute(236, "class", "nav-link");
                __builder2.AddAttribute(237, "href", "/CEntradaArticulos");
                __builder2.AddAttribute(238, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(239, "\r\n                                    <span aria-hidden=\"true\" class=\"oi oi-clipboard\" style=\"color:white\"></span>");
                    __builder3.AddMarkupContent(240, "<p style=\"color:white; font-size:14px; vertical-align:central; margin-top: 18px\">Entrada de Articuos</p>\r\n                                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(241, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(242, "\r\n\r\n                            ");
                __builder2.OpenElement(243, "li");
                __builder2.AddAttribute(244, "class", "list-unstyled");
                __builder2.AddMarkupContent(245, "\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(246);
                __builder2.AddAttribute(247, "class", "nav-link");
                __builder2.AddAttribute(248, "href", "/CFacturas");
                __builder2.AddAttribute(249, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(250, "\r\n                                    <span aria-hidden=\"true\" class=\"oi oi-credit-card\" style=\"color:white\"></span>");
                    __builder3.AddMarkupContent(251, "<p style=\"color:white; font-size:14px; vertical-align:central; margin-top: 18px\">Facturas</p>\r\n                                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(252, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(253, "\r\n\r\n                            ");
                __builder2.OpenElement(254, "li");
                __builder2.AddAttribute(255, "class", "list-unstyled");
                __builder2.AddMarkupContent(256, "\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(257);
                __builder2.AddAttribute(258, "class", "nav-link");
                __builder2.AddAttribute(259, "href", "/CPagos");
                __builder2.AddAttribute(260, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(261, "\r\n                                    <span aria-hidden=\"true\" class=\"oi oi-dollar\" style=\"color:white\"></span>");
                    __builder3.AddMarkupContent(262, "<p style=\"color:white; font-size:14px; vertical-align:central; margin-top: 18px\">Pagos</p>\r\n                                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(263, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(264, "\r\n\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(265, "\r\n");
#nullable restore
#line 185 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal34\AutosoftService\Shared\NavMenu.razor"

                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(266, "                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(267, "\r\n\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(268, "\r\n\r\n\r\n\r\n\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(269, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 201 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal34\AutosoftService\Shared\NavMenu.razor"
       



    private bool collapseNavMenu = true;

    private bool stateRegister = false;
    private bool stateConsultas = false;


    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

    private void ToggleRegistrosMenu()
    {
        stateRegister = !stateRegister;
        stateConsultas = false;

    }

    private void ToggleConsultasMenu()
    {
        stateConsultas = !stateConsultas;
        stateRegister = false;

    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591