#pragma checksum "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\REntradaArticulos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6402cf64d53e43d4861abb255db8f98edba9a14d"
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
#line 5 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\REntradaArticulos.razor"
using AutosoftService.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\REntradaArticulos.razor"
using AutosoftService.BLL;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/REntradaArticulos")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/REntradaArticulos/{EntradasArtId:int}")]
    public partial class REntradaArticulos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\REntradaArticulos.razor"
                     entradasArticulos

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\REntradaArticulos.razor"
                                                       Guardar

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n\r\n        ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "card");
                __builder2.AddMarkupContent(9, "\r\n\r\n\r\n            ");
                __builder2.AddMarkupContent(10, "<div class=\"card-header\">\r\n                <div class=\"text-center\">\r\n                    <h3>Entrada de Articulos</h3>\r\n                </div>\r\n            </div>\r\n\r\n            ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "card-body");
                __builder2.AddMarkupContent(13, "\r\n\r\n\r\n\r\n                ");
                __builder2.OpenElement(14, "form");
                __builder2.AddMarkupContent(15, "\r\n                    ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "form-row");
                __builder2.AddMarkupContent(18, "\r\n\r\n                        <div class=\"col-sm-0     col-md-0     col-lg-1     col-xl-1\"></div>\r\n\r\n\r\n                        ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-group col-sm-5     col-md-5     col-lg-3     col-xl-3     ");
                __builder2.AddMarkupContent(21, "\r\n                            ");
                __builder2.AddMarkupContent(22, "<label><b>Entrada ID</b></label>\r\n                            ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "input-group");
                __builder2.AddMarkupContent(25, "\r\n                                ");
                __Blazor.AutosoftService.Pages.Registros.REntradaArticulos.TypeInference.CreateInputNumber_0(__builder2, 26, 27, "form-control", 28, 
#nullable restore
#line 36 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\REntradaArticulos.razor"
                                                           entradasArticulos.EntradasArtId

#line default
#line hidden
#nullable disable
                , 29, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => entradasArticulos.EntradasArtId = __value, entradasArticulos.EntradasArtId)), 30, () => entradasArticulos.EntradasArtId);
                __builder2.AddMarkupContent(31, "\r\n                                ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "input-group-append");
                __builder2.AddMarkupContent(34, "\r\n                                    ");
                __builder2.OpenElement(35, "button");
                __builder2.AddAttribute(36, "type", "button");
                __builder2.AddAttribute(37, "class", "btn btn-primary");
                __builder2.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\REntradaArticulos.razor"
                                                                                            Buscar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(39, "<span class=\"oi oi-magnifying-glass\">Buscar</span>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n\r\n\r\n                        <div class=\"col-sm-3     col-md-2     col-lg-4     col-xl-4\"></div>\r\n\r\n                        ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "form-group col-sm-4     col-md-5     col-lg-3     col-xl-3     ");
                __builder2.AddMarkupContent(46, "\r\n                            ");
                __builder2.AddMarkupContent(47, "<label><b>Fecha</b></label>\r\n                            ");
                __Blazor.AutosoftService.Pages.Registros.REntradaArticulos.TypeInference.CreateInputDate_1(__builder2, 48, 49, "form-control", 50, 
#nullable restore
#line 48 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\REntradaArticulos.razor"
                                                     entradasArticulos.Fecha

#line default
#line hidden
#nullable disable
                , 51, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => entradasArticulos.Fecha = __value, entradasArticulos.Fecha)), 52, () => entradasArticulos.Fecha);
                __builder2.AddMarkupContent(53, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n\r\n\r\n\r\n                        <div class=\"col-sm-2   col-md-2   col-lg-0  col-xl-0\"></div>\r\n\r\n\r\n                        ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "form-group col-sm-8     col-md-8     col-lg-8     col-xl-8    ");
                __builder2.AddMarkupContent(57, "\r\n                            ");
                __builder2.AddMarkupContent(58, "<label><b>Articulo</b></label>\r\n                            ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "input-group ");
                __builder2.AddMarkupContent(61, "\r\n\r\n                                ");
                __Blazor.AutosoftService.Pages.Registros.REntradaArticulos.TypeInference.CreateInputSelect_2(__builder2, 62, 63, "form-control", 64, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 60 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\REntradaArticulos.razor"
                                                                                                           LlenaCombo

#line default
#line hidden
#nullable disable
                ), 65, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 60 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\REntradaArticulos.razor"
                                                                                                                                 LlenaCombo

#line default
#line hidden
#nullable disable
                ), 66, 
#nullable restore
#line 60 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\REntradaArticulos.razor"
                                                           ArticuloSelect

#line default
#line hidden
#nullable disable
                , 67, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ArticuloSelect = __value, ArticuloSelect)), 68, () => ArticuloSelect, 69, (__builder3) => {
                    __builder3.AddMarkupContent(70, "\r\n                                    ");
                    __builder3.AddMarkupContent(71, "<option value=\"0\" disabled selected>Seleccione un Articulo</option>\r\n");
#nullable restore
#line 62 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\REntradaArticulos.razor"
                                     if (listaarticulos.Count == 0)
                                    {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(72, "                                        ");
                    __builder3.AddMarkupContent(73, "<option value disabled>No hay Articulo Registrado</option>\r\n");
#nullable restore
#line 65 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\REntradaArticulos.razor"
                                    }
                                    else
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\REntradaArticulos.razor"
                                         foreach (var item in listaarticulos)
                                        {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(74, "                                            ");
                    __builder3.OpenElement(75, "option");
                    __builder3.AddAttribute(76, "value", 
#nullable restore
#line 70 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\REntradaArticulos.razor"
                                                            item.ArticuloId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(77, 
#nullable restore
#line 70 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\REntradaArticulos.razor"
                                                                              item.Descripcion

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(78, "\r\n");
#nullable restore
#line 71 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\REntradaArticulos.razor"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\REntradaArticulos.razor"
                                         
                                    }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(79, "                                ");
                }
                );
                __builder2.AddMarkupContent(80, "\r\n                                ");
                __Blazor.AutosoftService.Pages.Registros.REntradaArticulos.TypeInference.CreateValidationMessage_3(__builder2, 81, 82, 
#nullable restore
#line 74 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\REntradaArticulos.razor"
                                                          ()=>entradasArticulos.ArticuloId

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(83, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n\r\n                        <div class=\"form-group col-sm-4     col-md-4     col-lg-1    col-xl-1     \"></div>\r\n\r\n                        <div class=\"col-sm-2   col-md-2   col-lg-0  col-xl-0\"></div>\r\n\r\n                        ");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "form-group col-sm-6     col-md-6     col-lg-4     col-xl-4    ");
                __builder2.AddMarkupContent(88, "\r\n                            ");
                __builder2.AddMarkupContent(89, "<label><b>Cantidad</b></label>\r\n                            ");
                __builder2.OpenElement(90, "div");
                __builder2.AddAttribute(91, "class", "input-group ");
                __builder2.AddMarkupContent(92, "\r\n                                ");
                __Blazor.AutosoftService.Pages.Registros.REntradaArticulos.TypeInference.CreateInputNumber_4(__builder2, 93, 94, "form-control", 95, 
#nullable restore
#line 85 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\REntradaArticulos.razor"
                                                           entradasArticulos.Cantidad

#line default
#line hidden
#nullable disable
                , 96, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => entradasArticulos.Cantidad = __value, entradasArticulos.Cantidad)), 97, () => entradasArticulos.Cantidad);
                __builder2.AddMarkupContent(98, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(100, "\r\n\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n\r\n\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n\r\n\r\n\r\n            ");
                __builder2.OpenElement(104, "div");
                __builder2.AddAttribute(105, "class", "card-footer");
                __builder2.AddMarkupContent(106, "\r\n                ");
                __builder2.OpenElement(107, "div");
                __builder2.AddAttribute(108, "class", "form-group text-center");
                __builder2.AddAttribute(109, "display:", true);
                __builder2.AddAttribute(110, "inline-block", true);
                __builder2.AddMarkupContent(111, "\r\n                    ");
                __builder2.OpenElement(112, "button");
                __builder2.AddAttribute(113, "type", "button");
                __builder2.AddAttribute(114, "class", "btn btn-lg btn-primary");
                __builder2.AddAttribute(115, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 100 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\REntradaArticulos.razor"
                                                                                   Limpiar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(116, "<i class=\"fa fa-plus\"></i> Nuevo");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(117, "\r\n                    ");
                __builder2.AddMarkupContent(118, "<button type=\"submit\" class=\"btn btn-lg btn-success\"><i class=\"fa fa-save\"></i> Guardar</button>\r\n                    ");
                __builder2.OpenElement(119, "button");
                __builder2.AddAttribute(120, "type", "button");
                __builder2.AddAttribute(121, "class", "btn btn-lg btn-danger");
                __builder2.AddAttribute(122, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 102 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\REntradaArticulos.razor"
                                                                                  Eliminar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(123, "<i class=\"fa fa-trash\"></i> Eliminar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(124, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(125, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(126, "\r\n\r\n\r\n\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(127, "\r\n\r\n\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 114 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal00\AutosoftService\Pages\Registros\REntradaArticulos.razor"
       

    [Parameter]
    public int EntradasArtId { get; set; }

    private EntradasArticulos entradasArticulos = new EntradasArticulos();

    Articulos articulos = new Articulos();
    ArticuloBLL articuloBLL = new ArticuloBLL();
    private List<Articulos> listaarticulos = new List<Articulos>();
    private string ArticuloSelect { get; set; }





    protected override void OnInitialized()
    {

        listaarticulos = ArticuloBLL.GetList(e => true);
        entradasArticulos = new EntradasArticulos();
        Limpiar();
      
        if (EntradasArtId != 0)
        {
            entradasArticulos.EntradasArtId = EntradasArtId;
            Buscar();
        }
        base.OnInitialized();
    }


    private void Buscar()
    {
        EntradasArticulos entradaTemp = BLL.EntradaArtBLL.Buscar(entradasArticulos.EntradasArtId);

        if (entradaTemp != null)
        {
            Limpiar();
            entradasArticulos = entradaTemp;
            ArticuloSelect = entradasArticulos.EntradasArtId.ToString();


        }
        else
        {

            Limpiar();
            toast.ShowError("La Entrada no Existe", "Fallo");

        }
    }


    private void Limpiar()
    {

        this.entradasArticulos = new EntradasArticulos();
        ArticuloSelect = "0";




    }




    private void Guardar()
    {
        LlenaCombo();

        if (EntradaArtBLL.Guardar(entradasArticulos))
        {
            Limpiar();
            ArticuloSelect = "0";
            toast.ShowSuccess("Entrada guardada correctamente", "Exito");

        }
        else
        {
            toast.ShowError("Error al guardar la entrada", "Fallo");
        }

    }



    private void Eliminar()
    {
        EntradasArticulos entradaTemp = EntradaArtBLL.Buscar(entradasArticulos.EntradasArtId);

        if (entradaTemp != null)
        {
            if (EntradaArtBLL.Eliminar(entradasArticulos.EntradasArtId))
            {
                Limpiar();
                toast.ShowSuccess("Entrada eliminada correctamente.", "Exito");


            }
            else
            {
                toast.ShowError("Error al eliminar la entrada", "Fallo");

            }
        }

    }


    private void LlenaCombo()
    {
        entradasArticulos.ArticuloId = Convert.ToInt32(ArticuloSelect);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toast { get; set; }
    }
}
namespace __Blazor.AutosoftService.Pages.Registros.REntradaArticulos
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
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.Object __arg1, int __seq2, global::System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "onchange", __arg1);
        __builder.AddAttribute(__seq2, "onclick", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.AddAttribute(__seq6, "ChildContent", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
