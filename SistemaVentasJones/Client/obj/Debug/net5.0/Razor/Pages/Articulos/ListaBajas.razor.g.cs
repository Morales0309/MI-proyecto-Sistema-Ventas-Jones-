#pragma checksum "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Articulos\ListaBajas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6ab069d6e380313a2d4f0b6d798c9e08f35d391"
// <auto-generated/>
#pragma warning disable 1591
namespace SistemaVentasJones.Client.Pages.Articulos
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
#line 5 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Articulos\ListaBajas.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Articulos\ListaBajas.razor"
           [Authorize(Roles = "admin, empleado")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/lista-articulos-bajas")]
    public partial class ListaBajas : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "d-flex position-sticky justify-content-between");
            __builder.AddAttribute(2, "b-fe5mhgtcfu");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(3);
            __builder.AddAttribute(4, "Roles", (object)("admin"));
            __builder.AddAttribute(5, "Authorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "btn-group mr-2");
                __builder2.AddAttribute(8, "b-fe5mhgtcfu");
                __builder2.OpenElement(9, "button");
                __builder2.AddAttribute(10, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Articulos\ListaBajas.razor"
                                  CrearArticulo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "class", "btn btn-success");
                __builder2.AddAttribute(12, "b-fe5mhgtcfu");
                __builder2.AddMarkupContent(13, "<i class=\"oi oi-plus\" b-fe5mhgtcfu></i> Agregar artículo");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\n    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "input-group");
            __builder.AddAttribute(17, "style", "width:60%");
            __builder.AddAttribute(18, "b-fe5mhgtcfu");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "class", "form-control");
            __builder.AddAttribute(21, "type", "text");
            __builder.AddAttribute(22, "placeholder", "Nombre artículo");
            __builder.AddAttribute(23, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Articulos\ListaBajas.razor"
                                                                                     NombreArtFiltro

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NombreArtFiltro = __value, NombreArtFiltro));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(25, "b-fe5mhgtcfu");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n        ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "input-group-append");
            __builder.AddAttribute(29, "b-fe5mhgtcfu");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Articulos\ListaBajas.razor"
                              Filtrar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "class", "btn btn-primary");
            __builder.AddAttribute(33, "type", "button");
            __builder.AddAttribute(34, "b-fe5mhgtcfu");
            __builder.AddMarkupContent(35, "<i class=\"oi oi-magnifying-glass\" b-fe5mhgtcfu></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n            ");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Articulos\ListaBajas.razor"
                              Limpiar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "class", "btn btn-danger");
            __builder.AddAttribute(40, "type", "button");
            __builder.AddAttribute(41, "b-fe5mhgtcfu");
            __builder.AddMarkupContent(42, "<i class=\"oi oi-delete\" b-fe5mhgtcfu></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n\n");
            __builder.AddMarkupContent(44, "<div class=\"d-flex justify-content-between mt-2 mb-2\" b-fe5mhgtcfu><div class=\"btn-group\" b-fe5mhgtcfu><a href=\"/lista-articulos\" style=\"background:none; border: none\" b-fe5mhgtcfu><b b-fe5mhgtcfu>Volver a artículos</b></a></div></div>");
#nullable restore
#line 32 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Articulos\ListaBajas.razor"
 if (articulo == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(45, "<div class=\"d-flex justify-content-center align-items-center\" style=\"height:24rem\" b-fe5mhgtcfu><div class=\"spinner-border text-success\" role=\"status\" b-fe5mhgtcfu><span class=\"sr-only\" b-fe5mhgtcfu>Cargando...</span></div></div>");
#nullable restore
#line 39 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Articulos\ListaBajas.razor"
}
else if (articulo.Count == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(46, "<div class=\"d-flex justify-content-center align-items-center\" style=\"height:24rem\" b-fe5mhgtcfu><text b-fe5mhgtcfu>No se encontraron artículos.</text></div>");
#nullable restore
#line 45 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Articulos\ListaBajas.razor"
}
else
{        

#line default
#line hidden
#nullable disable
            global::__Blazor.SistemaVentasJones.Client.Pages.Articulos.ListaBajas.TypeInference.CreateMudTable_0(__builder, 47, 48, 
#nullable restore
#line 48 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Articulos\ListaBajas.razor"
                          articulo

#line default
#line hidden
#nullable disable
            , 49, 
#nullable restore
#line 48 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Articulos\ListaBajas.razor"
                                            dense

#line default
#line hidden
#nullable disable
            , 50, 
#nullable restore
#line 48 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Articulos\ListaBajas.razor"
                                                           hover

#line default
#line hidden
#nullable disable
            , 51, 
#nullable restore
#line 48 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Articulos\ListaBajas.razor"
                                                                             bordered

#line default
#line hidden
#nullable disable
            , 52, 
#nullable restore
#line 48 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Articulos\ListaBajas.razor"
                                                                                                 striped

#line default
#line hidden
#nullable disable
            , 53, 
#nullable restore
#line 48 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Articulos\ListaBajas.razor"
                                                                                                                  new Func<Articulo,bool>(FilterFunc1)

#line default
#line hidden
#nullable disable
            , 54, 
#nullable restore
#line 49 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Articulos\ListaBajas.razor"
                                      selectedItem1

#line default
#line hidden
#nullable disable
            , 55, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedItem1 = __value, selectedItem1)), 56, (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudText>(57);
                __builder2.AddAttribute(58, "Typo", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 51 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Articulos\ListaBajas.razor"
                               Typo.h6

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(59, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(60, "Artículos");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(61, "\n                ");
                __builder2.OpenComponent<global::MudBlazor.MudSpacer>(62);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(63, "\n                ");
                global::__Blazor.SistemaVentasJones.Client.Pages.Articulos.ListaBajas.TypeInference.CreateMudTextField_1(__builder2, 64, 65, "Buscar artículo...", 66, 
#nullable restore
#line 53 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Articulos\ListaBajas.razor"
                                                                                                      Adornment.Start

#line default
#line hidden
#nullable disable
                , 67, 
#nullable restore
#line 53 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Articulos\ListaBajas.razor"
                                                                                                                                       Icons.Material.Filled.Search

#line default
#line hidden
#nullable disable
                , 68, 
#nullable restore
#line 53 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Articulos\ListaBajas.razor"
                                                                                                                                                                               Size.Medium

#line default
#line hidden
#nullable disable
                , 69, "mt-0", 70, 
#nullable restore
#line 53 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Articulos\ListaBajas.razor"
                                           searchString1

#line default
#line hidden
#nullable disable
                , 71, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => searchString1 = __value, searchString1)));
            }
            , 72, (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudTh>(73);
                __builder2.AddAttribute(74, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(75, "Nombre");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(76, "\n                ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(77);
                __builder2.AddAttribute(78, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(79, "Descripción");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(80, "\n                ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(81);
                __builder2.AddAttribute(82, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(83, "Precio");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(84, "\n                ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(85);
                __builder2.AddAttribute(86, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(87, "Fecha alta");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(88, "\n                ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(89);
                __builder2.AddAttribute(90, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(91, "Stock");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(92, "\n                ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(93);
                __builder2.AddAttribute(94, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(95, "Acciones");
                }
                ));
                __builder2.CloseComponent();
            }
            , 96, (context) => (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudTd>(97);
                __builder2.AddAttribute(98, "DataLabel", (object)("Nombre"));
                __builder2.AddAttribute(99, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 64 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Articulos\ListaBajas.razor"
__builder3.AddContent(100, context.Nombre);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(101, "\n                ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(102);
                __builder2.AddAttribute(103, "DataLabel", (object)("Descripción"));
                __builder2.AddAttribute(104, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 65 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Articulos\ListaBajas.razor"
__builder3.AddContent(105, context.Descripcion);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(106, "\n                ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(107);
                __builder2.AddAttribute(108, "DataLabel", (object)("Precio"));
                __builder2.AddAttribute(109, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(110, "C$ ");
#nullable restore
#line 66 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Articulos\ListaBajas.razor"
__builder3.AddContent(111, context.PrecioUnitario);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(112, "\n                ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(113);
                __builder2.AddAttribute(114, "DataLabel", (object)("Fecha"));
                __builder2.AddAttribute(115, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 67 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Articulos\ListaBajas.razor"
__builder3.AddContent(116, context.Ultima_Modificación.ToLongDateString());

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(117, "\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(118);
                __builder2.AddAttribute(119, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 69 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Articulos\ListaBajas.razor"
                 if (context.StockActual < context.StockMinimo)
                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(120, "div");
                    __builder3.AddAttribute(121, "class", "chip chip-low");
                    __builder3.AddAttribute(122, "b-fe5mhgtcfu");
#nullable restore
#line 71 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Articulos\ListaBajas.razor"
__builder3.AddContent(123, context.StockActual);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 72 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Articulos\ListaBajas.razor"
                }
                else if (context.StockActual > context.StockMaximo)
                {                    

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(124, "div");
                    __builder3.AddAttribute(125, "class", "chip chip-ex");
                    __builder3.AddAttribute(126, "b-fe5mhgtcfu");
#nullable restore
#line 75 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Articulos\ListaBajas.razor"
__builder3.AddContent(127, context.StockActual);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 76 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Articulos\ListaBajas.razor"
                }
                else
                {                    

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(128, "div");
                    __builder3.AddAttribute(129, "class", "chip chip-normal");
                    __builder3.AddAttribute(130, "b-fe5mhgtcfu");
#nullable restore
#line 79 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Articulos\ListaBajas.razor"
__builder3.AddContent(131, context.StockActual);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 80 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Articulos\ListaBajas.razor"
                }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(132, "     \n            \n            ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(133);
                __builder2.AddAttribute(134, "Roles", (object)("admin"));
                __builder2.AddAttribute(135, "Authorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((contexto) => (__builder3) => {
                    __builder3.OpenComponent<global::MudBlazor.MudTd>(136);
                    __builder3.AddAttribute(137, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<global::MudBlazor.MudFab>(138);
                        __builder4.AddAttribute(139, "Color", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 86 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Articulos\ListaBajas.razor"
                                       Color.Error

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(140, "StartIcon", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 86 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Articulos\ListaBajas.razor"
                                                                Icons.Material.Filled.Edit

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(141, "Size", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Size>(
#nullable restore
#line 86 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Articulos\ListaBajas.razor"
                                                                                                  Size.Small

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(142, "onclick", (object)(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 87 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Articulos\ListaBajas.razor"
                                        () => NavigationManager.NavigateTo($"/editar-articulo/{context.Id}")

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            , 143, (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudTablePager>(144);
                __builder2.CloseComponent();
            }
            );
#nullable restore
#line 97 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Articulos\ListaBajas.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 98 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Articulos\ListaBajas.razor"
       
    public List<Articulo> articulo { get; set; } //muestra todos los articulos
    public List<Categoria> ListaCategorias { get; set; } = new List<Categoria>();

    private bool dense = false;
    private bool hover = true;
    private bool striped = true;
    private bool bordered = true;
    private string searchString1 = "";
    private Articulo selectedItem1 = null;
    private HashSet<Articulo> selectedItems = new HashSet<Articulo>();

    private string NombreArtFiltro = String.Empty; //filtros


    protected override async Task OnInitializedAsync()
    {
        await CargarArticulos();
    }
    async Task CargarArticulos()
    {
        var httpResponse = await Http.GetAsync($"api/articulos/bajas?nombre={NombreArtFiltro}");
        if (httpResponse.IsSuccessStatusCode)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            articulo = JsonSerializer.Deserialize<List<Articulo>>(responseString,
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
        else
        {
            Console.WriteLine("error");
        }
    }
    void CrearArticulo()
    {
        NavigationManager.NavigateTo("crear-articulo");
    }

    private async Task Filtrar()
    {
        await CargarArticulos();
    }

    private async Task Limpiar()
    {
        NombreArtFiltro = string.Empty;
        await CargarArticulos();
    }
    // esta es la funcion de filtrado de MudBlazor
    private bool FilterFunc1(Articulo element) => FilterFunc(element, searchString1);

    private bool FilterFunc(Articulo element, string searchString)
    {
        if (string.IsNullOrWhiteSpace(searchString))
            return true;
        if (element.Nombre.ToString().Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        return false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.SistemaVentasJones.Client.Pages.Articulos.ListaBajas
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
