#pragma checksum "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\ListaUsuarios.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7258bd91d802110fc5b9a9433a5ba113d891bc6a"
// <auto-generated/>
#pragma warning disable 1591
namespace SistemaVentasJones.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using SistemaVentasJones.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using SistemaVentasJones.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using SistemaVentasJones.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using SistemaVentasJones.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using MudBlazor.ThemeManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using MudBlazor.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using CsvHelper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using OfficeOpenXml;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using OfficeOpenXml.Style;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\ListaUsuarios.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\ListaUsuarios.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\ListaUsuarios.razor"
           [Authorize(Roles = "admin")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/lista-usuarios")]
    public partial class ListaUsuarios : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 11 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\ListaUsuarios.razor"
 if (Usuarios == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class=\"d-flex justify-content-center align-items-center\" style=\"height:24rem\"><div class=\"spinner-border text-success\" role=\"status\"><span class=\"sr-only\">Cargando...</span></div></div>");
#nullable restore
#line 18 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\ListaUsuarios.razor"
}
else if (Usuarios.Count == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<div class=\"d-flex justify-content-center align-items-center\" style=\"height:24rem\"><text>No se encontraron usuarios.</text></div>");
#nullable restore
#line 24 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\ListaUsuarios.razor"
}
else
{


#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<br>");
            global::__Blazor.SistemaVentasJones.Client.Pages.ListaUsuarios.TypeInference.CreateMudTable_0(__builder, 3, 4, 
#nullable restore
#line 30 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\ListaUsuarios.razor"
                      Usuarios

#line default
#line hidden
#nullable disable
            , 5, 
#nullable restore
#line 30 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\ListaUsuarios.razor"
                                       true

#line default
#line hidden
#nullable disable
            , 6, 
#nullable restore
#line 30 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\ListaUsuarios.razor"
                                                         Breakpoint.Sm

#line default
#line hidden
#nullable disable
            , 7, (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudTh>(8);
                __builder2.AddAttribute(9, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(10, "Nombre");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(12);
                __builder2.AddAttribute(13, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(14, "Apellido");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(16);
                __builder2.AddAttribute(17, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(18, "Email");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(20);
                __builder2.AddAttribute(21, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(22, "Usuario");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(24);
                __builder2.AddAttribute(25, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(26, "Teléfono");
                }
                ));
                __builder2.CloseComponent();
            }
            , 27, (context) => (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudTd>(28);
                __builder2.AddAttribute(29, "DataLabel", (object)("Nombre"));
                __builder2.AddAttribute(30, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 39 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\ListaUsuarios.razor"
__builder3.AddContent(31, context.NombreyApellido);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(33);
                __builder2.AddAttribute(34, "DataLabel", (object)("Apellido"));
                __builder2.AddAttribute(35, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 40 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\ListaUsuarios.razor"
__builder3.AddContent(36, context.Apellido);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(38);
                __builder2.AddAttribute(39, "DataLabel", (object)("Email"));
                __builder2.AddAttribute(40, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 41 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\ListaUsuarios.razor"
__builder3.AddContent(41, context.Email);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(42, "\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(43);
                __builder2.AddAttribute(44, "DataLabel", (object)("User name"));
                __builder2.AddAttribute(45, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 42 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\ListaUsuarios.razor"
__builder3.AddContent(46, context.UserName);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(47, "\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(48);
                __builder2.AddAttribute(49, "DataLabel", (object)("Telefono"));
                __builder2.AddAttribute(50, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 43 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\ListaUsuarios.razor"
__builder3.AddContent(51, context.PhoneNumber);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
            }
            );
#nullable restore
#line 46 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\ListaUsuarios.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\ListaUsuarios.razor"
       


    private List<IdentityRole> roles = new List<IdentityRole>();
    private List<ApplicationUser> Usuarios { get; set; } = new List<ApplicationUser>();

    private string nombreRol { get; set; }
    private string usuarioId { get; set; }

    protected override async Task OnInitializedAsync()
    {
        roles = await Http.GetFromJsonAsync<List<IdentityRole>>($"api/roles/");
        Usuarios = await Http.GetFromJsonAsync<List<ApplicationUser>>($"api/roles/usuarios");
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.SistemaVentasJones.Client.Pages.ListaUsuarios
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTable_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::MudBlazor.Breakpoint __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", (object)__arg0);
        __builder.AddAttribute(__seq1, "Hover", (object)__arg1);
        __builder.AddAttribute(__seq2, "Breakpoint", (object)__arg2);
        __builder.AddAttribute(__seq3, "HeaderContent", (object)__arg3);
        __builder.AddAttribute(__seq4, "RowTemplate", (object)__arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
