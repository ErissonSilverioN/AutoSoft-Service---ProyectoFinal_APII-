#pragma checksum "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Registros\RCliente.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "563b58e2b5ad9503c45c3a2c341c5756f13714fe"
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
#line 4 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Registros\RCliente.razor"
using Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Registros\RCliente.razor"
using BLL;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/RClientes")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/RClientes/{ClienteId:int}")]
    public partial class RCliente : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Registros\RCliente.razor"
                 cliente

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Registros\RCliente.razor"
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
                __builder2.AddMarkupContent(10, "<div class=\"card-header\">\r\n            <h1>Registro de Clientes</h1>\r\n        </div>\r\n\r\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "card-body");
                __builder2.AddMarkupContent(13, "\r\n            <form></form>\r\n            ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "form-row align-items-center");
                __builder2.AddMarkupContent(16, "\r\n                ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "col");
                __builder2.AddMarkupContent(19, "\r\n                    ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-group");
                __builder2.AddMarkupContent(22, "\r\n                        ");
                __builder2.AddMarkupContent(23, "<label>ID</label>\r\n                        ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "input-group");
                __builder2.AddMarkupContent(26, "\r\n                            ");
                __Blazor.AutosoftService.Pages.Registros.RCliente.TypeInference.CreateInputNumber_0(__builder2, 27, 28, "form-control col-4", 29, 
#nullable restore
#line 27 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Registros\RCliente.razor"
                                                      cliente.ClienteId

#line default
#line hidden
#nullable disable
                , 30, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.ClienteId = __value, cliente.ClienteId)), 31, () => cliente.ClienteId);
                __builder2.AddMarkupContent(32, "\r\n                            ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "input-group-append");
                __builder2.AddMarkupContent(35, "\r\n                                ");
                __builder2.OpenElement(36, "button");
                __builder2.AddAttribute(37, "type", "button");
                __builder2.AddAttribute(38, "class", "btn btn-primary");
                __builder2.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Registros\RCliente.razor"
                                                                                        Buscar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(40, "<i class=\"fa fa-search\"></i> Buscar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n\r\n            ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "form-group");
                __builder2.AddMarkupContent(49, "\r\n                ");
                __builder2.AddMarkupContent(50, "<label>Cliente</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(51);
                __builder2.AddAttribute(52, "class", "form-control");
                __builder2.AddAttribute(53, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 39 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Registros\RCliente.razor"
                                        cliente.Nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(54, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.Nombre = __value, cliente.Nombre))));
                __builder2.AddAttribute(55, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cliente.Nombre));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(56, "\r\n                ");
                __Blazor.AutosoftService.Pages.Registros.RCliente.TypeInference.CreateValidationMessage_1(__builder2, 57, 58, 
#nullable restore
#line 40 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Registros\RCliente.razor"
                                          () => cliente.Nombre

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(59, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n\r\n            ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "form-group");
                __builder2.AddMarkupContent(63, "\r\n                ");
                __builder2.AddMarkupContent(64, "<label>Fecha de Nacimiento</label>\r\n                ");
                __Blazor.AutosoftService.Pages.Registros.RCliente.TypeInference.CreateInputDate_2(__builder2, 65, 66, "form-control", 67, 
#nullable restore
#line 46 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Registros\RCliente.razor"
                                        cliente.Fecha

#line default
#line hidden
#nullable disable
                , 68, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.Fecha = __value, cliente.Fecha)), 69, () => cliente.Fecha);
                __builder2.AddMarkupContent(70, "\r\n                ");
                __Blazor.AutosoftService.Pages.Registros.RCliente.TypeInference.CreateValidationMessage_3(__builder2, 71, 72, 
#nullable restore
#line 47 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Registros\RCliente.razor"
                                          () => cliente.Fecha

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(73, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n\r\n            ");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "form-group");
                __builder2.AddMarkupContent(77, "\r\n                ");
                __builder2.AddMarkupContent(78, "<label>Cédula </label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(79);
                __builder2.AddAttribute(80, "class", "form-control");
                __builder2.AddAttribute(81, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 53 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Registros\RCliente.razor"
                                        cliente.Cedula

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(82, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.Cedula = __value, cliente.Cedula))));
                __builder2.AddAttribute(83, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cliente.Cedula));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(84, "\r\n                ");
                __Blazor.AutosoftService.Pages.Registros.RCliente.TypeInference.CreateValidationMessage_4(__builder2, 85, 86, 
#nullable restore
#line 54 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Registros\RCliente.razor"
                                          () => cliente.Cedula

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(87, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n\r\n            ");
                __builder2.OpenElement(89, "div");
                __builder2.AddAttribute(90, "class", "form-group");
                __builder2.AddMarkupContent(91, "\r\n                ");
                __builder2.AddMarkupContent(92, "<label>Teléfono </label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(93);
                __builder2.AddAttribute(94, "class", "form-control");
                __builder2.AddAttribute(95, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 60 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Registros\RCliente.razor"
                                        cliente.Telefono

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(96, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.Telefono = __value, cliente.Telefono))));
                __builder2.AddAttribute(97, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cliente.Telefono));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(98, "\r\n                ");
                __Blazor.AutosoftService.Pages.Registros.RCliente.TypeInference.CreateValidationMessage_5(__builder2, 99, 100, 
#nullable restore
#line 61 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Registros\RCliente.razor"
                                          () => cliente.Telefono

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(101, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n\r\n            ");
                __builder2.OpenElement(103, "div");
                __builder2.AddAttribute(104, "class", "form-group");
                __builder2.AddMarkupContent(105, "\r\n                ");
                __builder2.AddMarkupContent(106, "<label>Dirección</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(107);
                __builder2.AddAttribute(108, "class", "form-control");
                __builder2.AddAttribute(109, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 67 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Registros\RCliente.razor"
                                        cliente.Direccion

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(110, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.Direccion = __value, cliente.Direccion))));
                __builder2.AddAttribute(111, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cliente.Direccion));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(112, "\r\n                ");
                __Blazor.AutosoftService.Pages.Registros.RCliente.TypeInference.CreateValidationMessage_6(__builder2, 113, 114, 
#nullable restore
#line 68 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Registros\RCliente.razor"
                                          () => cliente.Direccion

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(115, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(116, "\r\n\r\n            ");
                __builder2.OpenElement(117, "div");
                __builder2.AddAttribute(118, "class", "form-group");
                __builder2.AddMarkupContent(119, "\r\n                ");
                __builder2.AddMarkupContent(120, "<label>Email</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(121);
                __builder2.AddAttribute(122, "class", "form-control");
                __builder2.AddAttribute(123, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 74 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Registros\RCliente.razor"
                                        cliente.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(124, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.Email = __value, cliente.Email))));
                __builder2.AddAttribute(125, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cliente.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(126, "\r\n                ");
                __Blazor.AutosoftService.Pages.Registros.RCliente.TypeInference.CreateValidationMessage_7(__builder2, 127, 128, 
#nullable restore
#line 75 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Registros\RCliente.razor"
                                          () => cliente.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(129, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(130, "\r\n\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(131, "\r\n\r\n        ");
                __builder2.OpenElement(132, "div");
                __builder2.AddAttribute(133, "class", "card-footer");
                __builder2.AddMarkupContent(134, "\r\n            ");
                __builder2.OpenElement(135, "div");
                __builder2.AddAttribute(136, "class", "form-group text-center");
                __builder2.AddAttribute(137, "display:", true);
                __builder2.AddAttribute(138, "inline-block", true);
                __builder2.AddMarkupContent(139, "\r\n                ");
                __builder2.OpenElement(140, "button");
                __builder2.AddAttribute(141, "type", "button");
                __builder2.AddAttribute(142, "class", "btn btn-lg btn-primary");
                __builder2.AddAttribute(143, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 83 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Registros\RCliente.razor"
                                                                               Nuevo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(144, "<i class=\"fa fa-plus\"></i> Nuevo");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(145, "\r\n                ");
                __builder2.AddMarkupContent(146, "<button type=\"submit\" class=\"btn btn-lg btn-success\"><i class=\"fa fa-save\"></i> Guardar</button>\r\n                ");
                __builder2.OpenElement(147, "button");
                __builder2.AddAttribute(148, "type", "button");
                __builder2.AddAttribute(149, "class", "btn btn-lg btn-danger");
                __builder2.AddAttribute(150, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 85 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Registros\RCliente.razor"
                                                                              Eliminar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(151, "<i class=\"fa fa-trash\"></i> Eliminar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(152, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(153, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(154, "\r\n\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(155, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 95 "C:\Users\PANDA\Source\Repos\AutosoftService-ProyectoFinal7\AutosoftService\Pages\Registros\RCliente.razor"
      

    [Parameter]
    public int ClienteId { get; set; }

    Clientes cliente = new Clientes();

    private Usuarios Usuario = new Usuarios();

    public bool paso { get; set; }

    protected override void OnInitialized()
    {
        Nuevo();
        if (ClienteId > 0)
        {
            var Auxclientes = ClienteBLL.Buscar(ClienteId);
            if (Auxclientes != null)
                this.cliente = Auxclientes;
            else
                toast.ShowWarning("No encontrado.");
        }


    }

    private void Nuevo()
    {
        this.cliente = new Clientes();

    }

    private void Buscar()
    {
        if (cliente.ClienteId > 0)
        {
            var encontrado = ClienteBLL.Buscar(cliente.ClienteId);

            if (encontrado != null)
            {
                this.cliente = encontrado;
            }
            else
            {
                toast.ShowWarning("No encontrado");


            }
        }
    }

    private void Guardar()
    {
        bool guardo = ClienteBLL.Guardar(cliente);

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

        elimino = ClienteBLL.Eliminar(cliente.ClienteId);

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
namespace __Blazor.AutosoftService.Pages.Registros.RCliente
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
        public static void CreateInputDate_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
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
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
