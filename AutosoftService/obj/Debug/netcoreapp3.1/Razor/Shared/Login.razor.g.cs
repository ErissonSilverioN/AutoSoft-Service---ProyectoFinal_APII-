#pragma checksum "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\Shared\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea9515bec754f27034bda5ed26ac2fa6a7195b9e"
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
#line 1 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\_Imports.razor"
using AutosoftService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\_Imports.razor"
using AutosoftService.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\Shared\Login.razor"
using System.Web;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        ");
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "container");
                __builder2.AddMarkupContent(5, "\r\n\r\n            ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "style", @"        margin: 0;
        background-color:darkblue;
        box-sizing: padding-box;
        max-width: 500px;
        padding: 22px;
        box-shadow: 8px 14px 38px #e1c559;
        margin: auto;
        margin-top: 115px;
        border-radius: 16px;");
                __builder2.AddMarkupContent(8, "\r\n\r\n\r\n\r\n                ");
                __builder2.AddMarkupContent(9, @"<div class=""text-center"">
                    <h1 style=""        font-family: Impact, Charcoal, sans-serif; text-decoration: underline; color:antiquewhite"">
                        AutoSoft Service Login
                    </h1>
                </div>


                <br>
                <br>

                ");
                __builder2.OpenElement(10, "form");
                __builder2.AddAttribute(11, "class", "form-group");
                __builder2.AddMarkupContent(12, "\r\n\r\n                    ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "form-group");
                __builder2.AddMarkupContent(15, "\r\n\r\n                        ");
                __builder2.OpenElement(16, "input");
                __builder2.AddAttribute(17, "type", "text");
                __builder2.AddAttribute(18, "class", "form-control");
                __builder2.AddAttribute(19, "id", "Usuario");
                __builder2.AddAttribute(20, "aria-describedby", "Usuario");
                __builder2.AddAttribute(21, "placeholder", "Usuario");
                __builder2.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 40 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\Shared\Login.razor"
                                                                       Username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Username = __value, Username));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n\r\n                    ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "form-group");
                __builder2.AddMarkupContent(28, "\r\n\r\n                        ");
                __builder2.OpenElement(29, "input");
                __builder2.AddAttribute(30, "type", "password");
                __builder2.AddAttribute(31, "class", "form-control");
                __builder2.AddAttribute(32, "id", "exampleInputPassword1");
                __builder2.AddAttribute(33, "placeholder", "Contraseña");
                __builder2.AddAttribute(34, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 46 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\Shared\Login.razor"
                                                                           Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Password = __value, Password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n\r\n\r\n                    <br>\r\n\r\n\r\n\r\n                    ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "form-group");
                __builder2.AddMarkupContent(40, "\r\n\r\n                        ");
                __builder2.OpenElement(41, "a");
                __builder2.AddAttribute(42, "class", " font-weight-bold btn btn-info btn-info px-4");
                __builder2.AddAttribute(43, "href", "/login?paramUsername=" + (
#nullable restore
#line 57 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\Shared\Login.razor"
                                                       encode(@Username)

#line default
#line hidden
#nullable disable
                ) + "&paramPassword=" + (
#nullable restore
#line 57 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\Shared\Login.razor"
                                                                                        encode(@Password)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "target", "_top");
                __builder2.AddContent(45, "Iniciar Sesion");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n\r\n\r\n                        ");
                __builder2.AddMarkupContent(47, "<a class=\" font-weight-bold  btn btn-warning btn-warning px-4\" href=\"/RUsuarios \" target=\"_top\">Registrarse</a>\r\n\r\n\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n\r\n\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n\r\n\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "C:\Users\Emerson\Source\Repos\AutosoftService-ProyectoFinal4\AutosoftService\Shared\Login.razor"
       






    string Username = "";

    string Password = "";



    private string encode(string param)

    {



        return HttpUtility.UrlEncode(param);


    }






#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toast { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRunTime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
