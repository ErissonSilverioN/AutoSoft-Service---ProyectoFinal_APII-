#pragma checksum "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\RVehiculos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4f482637fb7543e940f7ed0d96b767f38ad99fc"
// <auto-generated/>
#pragma warning disable 1591
namespace AutosoftService.Pages.Registros
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
#line 4 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\RVehiculos.razor"
using Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\RVehiculos.razor"
using BLL;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Vehiculos")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Vehiculos/{VehiculoId:int}")]
    public partial class RVehiculos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\RVehiculos.razor"
                 vehiculos

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\RVehiculos.razor"
                                           Guardar

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "card w-100");
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.AddMarkupContent(10, "<div class=\"card-header\">\r\n            <h1>Registro de Vehiculos</h1>\r\n        </div>\r\n\r\n    ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "card-body");
                __builder2.AddMarkupContent(13, "\r\n        <form></form>\r\n        ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "form-row align-items-center");
                __builder2.AddMarkupContent(16, "\r\n            ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "col");
                __builder2.AddMarkupContent(19, "\r\n                ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-group");
                __builder2.AddMarkupContent(22, "\r\n                    ");
                __builder2.AddMarkupContent(23, "<label><b>ID</b></label>\r\n                    ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "input-group");
                __builder2.AddMarkupContent(26, "\r\n                        ");
                __Blazor.AutosoftService.Pages.Registros.RVehiculos.TypeInference.CreateInputNumber_0(__builder2, 27, 28, "form-control col-4", 29, 
#nullable restore
#line 27 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\RVehiculos.razor"
                                                  vehiculos.VehiculoId

#line default
#line hidden
#nullable disable
                , 30, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vehiculos.VehiculoId = __value, vehiculos.VehiculoId)), 31, () => vehiculos.VehiculoId);
                __builder2.AddMarkupContent(32, "\r\n                        ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "input-group-append");
                __builder2.AddMarkupContent(35, "\r\n                            ");
                __builder2.OpenElement(36, "button");
                __builder2.AddAttribute(37, "type", "button");
                __builder2.AddAttribute(38, "class", "btn btn-primary");
                __builder2.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\RVehiculos.razor"
                                                                                    Buscar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(40, "<i class=\"fa fa-search\"></i> Buscar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n\r\n        ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "form-group");
                __builder2.AddMarkupContent(49, "\r\n            ");
                __builder2.AddMarkupContent(50, "<label><b>Descripcion</b></label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(51);
                __builder2.AddAttribute(52, "class", "form-control");
                __builder2.AddAttribute(53, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 39 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\RVehiculos.razor"
                                    vehiculos.Descripcion

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(54, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vehiculos.Descripcion = __value, vehiculos.Descripcion))));
                __builder2.AddAttribute(55, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => vehiculos.Descripcion));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(56, "\r\n            ");
                __Blazor.AutosoftService.Pages.Registros.RVehiculos.TypeInference.CreateValidationMessage_1(__builder2, 57, 58, 
#nullable restore
#line 40 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\RVehiculos.razor"
                                      () => vehiculos.Descripcion

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(59, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n        ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "form-group");
                __builder2.AddMarkupContent(63, "\r\n            ");
                __builder2.AddMarkupContent(64, "<label><b>Cliente</b></label>\r\n            ");
                __builder2.OpenElement(65, "select");
                __builder2.AddAttribute(66, "class", "form-control");
                __builder2.AddAttribute(67, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 45 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\RVehiculos.razor"
                                                vehiculos.ClienteId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(68, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => vehiculos.ClienteId = __value, vehiculos.ClienteId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(69, "\r\n                ");
                __builder2.OpenElement(70, "option");
                __builder2.AddAttribute(71, "disabled", "disabled");
                __builder2.AddAttribute(72, "selected", "selected");
                __builder2.AddMarkupContent(73, "Elija una opción");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n");
#nullable restore
#line 47 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\RVehiculos.razor"
                 foreach (var auxiliar in LlenarComboCliente())
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(75, "                    ");
                __builder2.OpenElement(76, "option");
                __builder2.AddAttribute(77, "value", 
#nullable restore
#line 49 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\RVehiculos.razor"
                                    auxiliar.ClienteId

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(78, 
#nullable restore
#line 49 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\RVehiculos.razor"
                                                         auxiliar.Nombre

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n");
#nullable restore
#line 50 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\RVehiculos.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(80, "            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n            ");
                __Blazor.AutosoftService.Pages.Registros.RVehiculos.TypeInference.CreateValidationMessage_2(__builder2, 82, 83, 
#nullable restore
#line 52 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\RVehiculos.razor"
                                      () => vehiculos.ClienteId

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(84, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n    ");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "form-group");
                __builder2.AddMarkupContent(88, "\r\n        ");
                __builder2.AddMarkupContent(89, "<label><b>Tipo de Vehiculos</b></label>\r\n        ");
                __Blazor.AutosoftService.Pages.Registros.RVehiculos.TypeInference.CreateInputSelect_3(__builder2, 90, 91, "form-control", 92, 
#nullable restore
#line 57 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\RVehiculos.razor"
                                   vehiculos.TipoVehiculo

#line default
#line hidden
#nullable disable
                , 93, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vehiculos.TipoVehiculo = __value, vehiculos.TipoVehiculo)), 94, () => vehiculos.TipoVehiculo, 95, (__builder3) => {
                    __builder3.AddMarkupContent(96, "\r\n            ");
                    __builder3.AddMarkupContent(97, "<option value disabled selected>Seleccione un Tipo</option>\r\n            ");
                    __builder3.AddMarkupContent(98, "<option value=\"Carro\">Carro</option>\r\n            ");
                    __builder3.AddMarkupContent(99, "<option value=\"Camionetas\">Camionetas</option>\r\n            ");
                    __builder3.AddMarkupContent(100, "<option value=\"Jeepetas\">Jeepetas</option>\r\n            ");
                    __builder3.AddMarkupContent(101, "<option value=\"Motores\">Motores</option>\r\n            ");
                    __builder3.AddMarkupContent(102, "<option value=\"Camiones\">Camiones</option>\r\n        ");
                }
                );
                __builder2.AddMarkupContent(103, "\r\n        ");
                __Blazor.AutosoftService.Pages.Registros.RVehiculos.TypeInference.CreateValidationMessage_4(__builder2, 104, 105, 
#nullable restore
#line 65 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\RVehiculos.razor"
                                  () => vehiculos.TipoVehiculo

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(106, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(107, "\r\n\r\n        ");
                __builder2.OpenElement(108, "div");
                __builder2.AddAttribute(109, "class", "form-group");
                __builder2.AddMarkupContent(110, "\r\n            ");
                __builder2.AddMarkupContent(111, "<label><b>Placa </b></label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(112);
                __builder2.AddAttribute(113, "class", "form-control");
                __builder2.AddAttribute(114, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 71 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\RVehiculos.razor"
                                    vehiculos.Placa

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(115, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vehiculos.Placa = __value, vehiculos.Placa))));
                __builder2.AddAttribute(116, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => vehiculos.Placa));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(117, "\r\n            ");
                __Blazor.AutosoftService.Pages.Registros.RVehiculos.TypeInference.CreateValidationMessage_5(__builder2, 118, 119, 
#nullable restore
#line 72 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\RVehiculos.razor"
                                      () =>vehiculos.Placa

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(120, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(121, "\r\n\r\n        ");
                __builder2.OpenElement(122, "div");
                __builder2.AddAttribute(123, "class", "form-group");
                __builder2.AddMarkupContent(124, "\r\n            ");
                __builder2.AddMarkupContent(125, "<label><b>Año</b></label>\r\n            ");
                __Blazor.AutosoftService.Pages.Registros.RVehiculos.TypeInference.CreateInputNumber_6(__builder2, 126, 127, "form-control", 128, 
#nullable restore
#line 78 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\RVehiculos.razor"
                                      vehiculos.Año

#line default
#line hidden
#nullable disable
                , 129, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vehiculos.Año = __value, vehiculos.Año)), 130, () => vehiculos.Año);
                __builder2.AddMarkupContent(131, "\r\n            ");
                __Blazor.AutosoftService.Pages.Registros.RVehiculos.TypeInference.CreateValidationMessage_7(__builder2, 132, 133, 
#nullable restore
#line 79 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\RVehiculos.razor"
                                      () => vehiculos.Año

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(134, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(135, "\r\n\r\n        ");
                __builder2.OpenElement(136, "div");
                __builder2.AddAttribute(137, "class", "form-group");
                __builder2.AddMarkupContent(138, "\r\n            ");
                __builder2.AddMarkupContent(139, "<label><b>Fecha</b></label>\r\n            ");
                __Blazor.AutosoftService.Pages.Registros.RVehiculos.TypeInference.CreateInputDate_8(__builder2, 140, 141, "form-control", 142, 
#nullable restore
#line 85 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\RVehiculos.razor"
                                    vehiculos.Fecha

#line default
#line hidden
#nullable disable
                , 143, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => vehiculos.Fecha = __value, vehiculos.Fecha)), 144, () => vehiculos.Fecha);
                __builder2.AddMarkupContent(145, "\r\n            ");
                __Blazor.AutosoftService.Pages.Registros.RVehiculos.TypeInference.CreateValidationMessage_9(__builder2, 146, 147, 
#nullable restore
#line 86 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\RVehiculos.razor"
                                      () => vehiculos.Fecha

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(148, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(149, "\r\n\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(150, "\r\n\r\n        ");
                __builder2.OpenElement(151, "div");
                __builder2.AddAttribute(152, "class", "card-footer");
                __builder2.AddMarkupContent(153, "\r\n            ");
                __builder2.OpenElement(154, "div");
                __builder2.AddAttribute(155, "class", "form-group text-center");
                __builder2.AddAttribute(156, "display:", true);
                __builder2.AddAttribute(157, "inline-block", true);
                __builder2.AddMarkupContent(158, "\r\n                ");
                __builder2.OpenElement(159, "button");
                __builder2.AddAttribute(160, "type", "button");
                __builder2.AddAttribute(161, "class", "btn btn-lg btn-primary");
                __builder2.AddAttribute(162, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 94 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\RVehiculos.razor"
                                                                               Nuevo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(163, "<i class=\"fa fa-plus\"></i> Nuevo");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(164, "\r\n                ");
                __builder2.AddMarkupContent(165, "<button type=\"submit\" class=\"btn btn-lg btn-success\"><i class=\"fa fa-save\"></i> Guardar</button>\r\n                ");
                __builder2.OpenElement(166, "button");
                __builder2.AddAttribute(167, "type", "button");
                __builder2.AddAttribute(168, "class", "btn btn-lg btn-danger");
                __builder2.AddAttribute(169, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 96 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\RVehiculos.razor"
                                                                              Eliminar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(170, "<i class=\"fa fa-trash\"></i> Eliminar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(171, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(172, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(173, "\r\n\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(174, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 106 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\RVehiculos.razor"
      

    [Parameter]
    public int VehiculoId { get; set; }

    Vehiculos vehiculos = new Vehiculos();

    private Usuarios Usuario = new Usuarios();

    public bool paso { get; set; }

    protected override void OnInitialized()
    {
        Nuevo();
        if (VehiculoId> 0)
        {
            var Auxvehiculos = VehiculoBLL.Buscar(VehiculoId);
            if (Auxvehiculos != null)
                this.vehiculos = Auxvehiculos;
            else
                toast.ShowWarning("No encontrado.");
        }


    }

    public List<Clientes> LlenarComboCliente()
    {
        List<Clientes> listaClientes = new List<Clientes>();

        try
        {
            listaClientes = ClienteBLL.GetList(c => true);
        }
        catch (Exception)
        {
            throw;
        }

        return listaClientes;
    }


    private void Nuevo()
    {
        this.vehiculos = new Vehiculos();

    }

    private void Buscar()
    {
        if (vehiculos.VehiculoId> 0)
        {
            var encontrado = VehiculoBLL.Buscar(vehiculos.VehiculoId);

            if (encontrado != null)
            {
                this.vehiculos = encontrado;
            }
            else
            {
                toast.ShowWarning("No encontrado");


            }
        }
    }

    private void Guardar()
    {
        bool guardo = VehiculoBLL.Guardar(vehiculos);

        if (guardo)
        {
            Nuevo();
            toast.ShowSuccess("Guardado correctamente");

        }
        else
        {
            toast.ShowError("No fue posible guardar");

        }
    }

    private void Eliminar()
    {
        bool elimino;

        elimino = VehiculoBLL.Eliminar(vehiculos.VehiculoId);

        if (elimino)
        {
            Nuevo();
            toast.ShowSuccess("Eliminado correctamente");

        }
        else
        {
            toast.ShowError("No fue posible eliminar");

        }
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toast { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
namespace __Blazor.AutosoftService.Pages.Registros.RVehiculos
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_9<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
