#pragma checksum "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Pages\Usuarios\ListaUsuarios.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cf4e0872694389ee19eddd90e3872384deefe4b"
// <auto-generated/>
#pragma warning disable 1591
namespace SistemaVentasJones.Client.Pages.Usuarios
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\_Imports.razor"
using SistemaVentasJones.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\_Imports.razor"
using SistemaVentasJones.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\_Imports.razor"
using SistemaVentasJones.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\_Imports.razor"
using SistemaVentasJones.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\_Imports.razor"
using MudBlazor.ThemeManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\_Imports.razor"
using MudBlazor.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\_Imports.razor"
using CsvHelper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\_Imports.razor"
using OfficeOpenXml;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\_Imports.razor"
using OfficeOpenXml.Style;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Pages\Usuarios\ListaUsuarios.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Pages\Usuarios\ListaUsuarios.razor"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "btn-group btn-block my-2");
            __builder.OpenComponent<global::MudBlazor.MudButton>(2);
            __builder.AddAttribute(3, "Link", (object)("/authentication/register"));
            __builder.AddAttribute(4, "Variant", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Variant>(
#nullable restore
#line 13 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Pages\Usuarios\ListaUsuarios.razor"
                                                        Variant.Filled

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "Color", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 14 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Pages\Usuarios\ListaUsuarios.razor"
                      Color.Success

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "Size", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Size>(
#nullable restore
#line 14 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Pages\Usuarios\ListaUsuarios.razor"
                                          Size.Medium

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "Style", (object)("text-decoration :none;"));
            __builder.AddAttribute(8, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(9, "Registrar nuevo usuario");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 16 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Pages\Usuarios\ListaUsuarios.razor"
 if (applicationUsers == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(10, "<div class=\"d-flex justify-content-center align-items-center\" style=\"height:24rem\"><div class=\"spinner-border text-success\" role=\"status\"><span class=\"sr-only\">Cargando...</span></div></div>");
#nullable restore
#line 23 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Pages\Usuarios\ListaUsuarios.razor"
}
else if (applicationUsers.Count == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(11, "<div class=\"d-flex justify-content-center align-items-center\" style=\"height:24rem\"><text>No se encontraron usuarios.</text></div>");
#nullable restore
#line 29 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Pages\Usuarios\ListaUsuarios.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(12, "<br>");
            global::__Blazor.SistemaVentasJones.Client.Pages.Usuarios.ListaUsuarios.TypeInference.CreateMudTable_0(__builder, 13, 14, 
#nullable restore
#line 34 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Pages\Usuarios\ListaUsuarios.razor"
                      applicationUsers

#line default
#line hidden
#nullable disable
            , 15, 
#nullable restore
#line 34 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Pages\Usuarios\ListaUsuarios.razor"
                                                dense

#line default
#line hidden
#nullable disable
            , 16, 
#nullable restore
#line 34 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Pages\Usuarios\ListaUsuarios.razor"
                                                               hover

#line default
#line hidden
#nullable disable
            , 17, 
#nullable restore
#line 34 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Pages\Usuarios\ListaUsuarios.razor"
                                                                                 bordered

#line default
#line hidden
#nullable disable
            , 18, 
#nullable restore
#line 34 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Pages\Usuarios\ListaUsuarios.razor"
                                                                                                     striped

#line default
#line hidden
#nullable disable
            , 19, 
#nullable restore
#line 34 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Pages\Usuarios\ListaUsuarios.razor"
                                                                                                                      new Func<ApplicationUser,bool>(FilterFunc1)

#line default
#line hidden
#nullable disable
            , 20, 
#nullable restore
#line 35 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Pages\Usuarios\ListaUsuarios.razor"
                              selectedItem1

#line default
#line hidden
#nullable disable
            , 21, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedItem1 = __value, selectedItem1)), 22, (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudText>(23);
                __builder2.AddAttribute(24, "Typo", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 37 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Pages\Usuarios\ListaUsuarios.razor"
                           Typo.h6

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(25, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(26, "Usuarios");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudSpacer>(28);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n            ");
                global::__Blazor.SistemaVentasJones.Client.Pages.Usuarios.ListaUsuarios.TypeInference.CreateMudTextField_1(__builder2, 30, 31, "Buscar usuario...", 32, 
#nullable restore
#line 39 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Pages\Usuarios\ListaUsuarios.razor"
                                                                                                 Adornment.Start

#line default
#line hidden
#nullable disable
                , 33, 
#nullable restore
#line 39 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Pages\Usuarios\ListaUsuarios.razor"
                                                                                                                                  Icons.Material.Filled.Search

#line default
#line hidden
#nullable disable
                , 34, 
#nullable restore
#line 39 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Pages\Usuarios\ListaUsuarios.razor"
                                                                                                                                                                          Size.Medium

#line default
#line hidden
#nullable disable
                , 35, "mt-0", 36, 
#nullable restore
#line 39 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Pages\Usuarios\ListaUsuarios.razor"
                                       searchString1

#line default
#line hidden
#nullable disable
                , 37, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => searchString1 = __value, searchString1)));
            }
            , 38, (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudTh>(39);
                __builder2.AddAttribute(40, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(41, "Nombre");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(42, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(43);
                __builder2.AddAttribute(44, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(45, "Apellidos");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(47);
                __builder2.AddAttribute(48, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(49, "Cédula");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(50, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(51);
                __builder2.AddAttribute(52, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(53, "Teléfono");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(54, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(55);
                __builder2.AddAttribute(56, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(57, "Email");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(58, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(59);
                __builder2.AddAttribute(60, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(61, "Nombre de usuario");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(62, "            \r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(63);
                __builder2.AddAttribute(64, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(65, "Acciones");
                }
                ));
                __builder2.CloseComponent();
            }
            , 66, (context) => (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudTd>(67);
                __builder2.AddAttribute(68, "DataLabel", (object)("Nombre"));
                __builder2.AddAttribute(69, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 53 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Pages\Usuarios\ListaUsuarios.razor"
__builder3.AddContent(70, context.NombreyApellido);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(71, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(72);
                __builder2.AddAttribute(73, "DataLabel", (object)("Apellidos"));
                __builder2.AddAttribute(74, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 54 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Pages\Usuarios\ListaUsuarios.razor"
__builder3.AddContent(75, context.Apellido);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(76, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(77);
                __builder2.AddAttribute(78, "DataLabel", (object)("Cédula"));
                __builder2.AddAttribute(79, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 55 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Pages\Usuarios\ListaUsuarios.razor"
__builder3.AddContent(80, context.Cedula);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(81, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(82);
                __builder2.AddAttribute(83, "DataLabel", (object)("Teléfono"));
                __builder2.AddAttribute(84, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 56 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Pages\Usuarios\ListaUsuarios.razor"
__builder3.AddContent(85, context.PhoneNumber);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(86, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(87);
                __builder2.AddAttribute(88, "DataLabel", (object)("Email"));
                __builder2.AddAttribute(89, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 57 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Pages\Usuarios\ListaUsuarios.razor"
__builder3.AddContent(90, context.Email);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(91, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(92);
                __builder2.AddAttribute(93, "DataLabel", (object)("Usuario"));
                __builder2.AddAttribute(94, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 58 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Pages\Usuarios\ListaUsuarios.razor"
__builder3.AddContent(95, context.UserName);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(96, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(97);
                __builder2.AddAttribute(98, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<global::MudBlazor.MudFab>(99);
                    __builder3.AddAttribute(100, "Color", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 60 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Pages\Usuarios\ListaUsuarios.razor"
                               Color.Error

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(101, "StartIcon", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 60 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Pages\Usuarios\ListaUsuarios.razor"
                                                        Icons.Material.Filled.Edit

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(102, "Size", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Size>(
#nullable restore
#line 60 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Pages\Usuarios\ListaUsuarios.razor"
                                                                                          Size.Small

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(103, "onclick", (object)(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 61 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Pages\Usuarios\ListaUsuarios.razor"
                                () => NavigationManager.NavigateTo($"/editar-usuarios/{context.Id}")

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            , 104, (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudTablePager>(105);
                __builder2.CloseComponent();
            }
            );
#nullable restore
#line 69 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Pages\Usuarios\ListaUsuarios.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 70 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Pages\Usuarios\ListaUsuarios.razor"
       
    private bool dense = false;
    private bool hover = true;
    private bool striped = true;
    private bool bordered = true;
    private string searchString1 = "";
    private ApplicationUser selectedItem1 = null;
    private HashSet<ApplicationUser> selectedItems = new HashSet<ApplicationUser>();


    public List<ApplicationUser> applicationUsers { get; set; } //muestra todos los Categoria
    ApplicationUser objUsers = new ApplicationUser();

    private string NombreArtFiltro = String.Empty; //filtros

    protected bool lista = false;
    protected bool card = true;

    protected override async Task OnInitializedAsync()
    {
        await CargarUsuarios();
    }

    async Task CargarUsuarios()
    {
        var httpResponse = await Http.GetAsync($"api/Usuarios");
        if (httpResponse.IsSuccessStatusCode)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            applicationUsers = JsonSerializer.Deserialize<List<ApplicationUser>>(responseString,
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
        else
        {
            Console.WriteLine("Error con usuarios");
        }
    }

    void CambiarVista() //  esta parte cambia entre vista de tarjetas o vista de grilla
    {
        lista = !lista;
        card = !card;
    }


    async Task MostrarTodos()
    {
        await CargarUsuarios();
    }

    void CrearUsuario()
    {
        NavigationManager.NavigateTo("crearusuarios");
    }

    private async Task Filtrar()
    {
        await CargarUsuarios();
    }

    private async Task Limpiar()
    {
        NombreArtFiltro = string.Empty;
        await CargarUsuarios();
    }

    // esta es la funcion de filtrado de MudBlazor
    private bool FilterFunc1(ApplicationUser element) => FilterFunc(element, searchString1);

    private bool FilterFunc(ApplicationUser element, string searchString)
    {
        if (string.IsNullOrWhiteSpace(searchString))
            return true;
        if (element.NombreyApellido.ToString().Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;


        return false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.SistemaVentasJones.Client.Pages.Usuarios.ListaUsuarios
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTable_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::System.Func<T, global::System.Boolean> __arg5, int __seq6, T __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg7, int __seq8, global::Microsoft.AspNetCore.Components.RenderFragment __arg8, int __seq9, global::Microsoft.AspNetCore.Components.RenderFragment __arg9, int __seq10, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg10, int __seq11, global::Microsoft.AspNetCore.Components.RenderFragment __arg11)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", (object)__arg0);
        __builder.AddAttribute(__seq1, "Dense", (object)__arg1);
        __builder.AddAttribute(__seq2, "Hover", (object)__arg2);
        __builder.AddAttribute(__seq3, "Bordered", (object)__arg3);
        __builder.AddAttribute(__seq4, "Striped", (object)__arg4);
        __builder.AddAttribute(__seq5, "Filter", (object)__arg5);
        __builder.AddAttribute(__seq6, "SelectedItem", (object)__arg6);
        __builder.AddAttribute(__seq7, "SelectedItemChanged", (object)__arg7);
        __builder.AddAttribute(__seq8, "ToolBarContent", (object)__arg8);
        __builder.AddAttribute(__seq9, "HeaderContent", (object)__arg9);
        __builder.AddAttribute(__seq10, "RowTemplate", (object)__arg10);
        __builder.AddAttribute(__seq11, "PagerContent", (object)__arg11);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Adornment __arg1, int __seq2, global::System.String __arg2, int __seq3, global::MudBlazor.Size __arg3, int __seq4, global::System.String __arg4, int __seq5, T __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg6)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Placeholder", (object)__arg0);
        __builder.AddAttribute(__seq1, "Adornment", (object)__arg1);
        __builder.AddAttribute(__seq2, "AdornmentIcon", (object)__arg2);
        __builder.AddAttribute(__seq3, "IconSize", (object)__arg3);
        __builder.AddAttribute(__seq4, "Class", (object)__arg4);
        __builder.AddAttribute(__seq5, "Value", (object)__arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", (object)__arg6);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591