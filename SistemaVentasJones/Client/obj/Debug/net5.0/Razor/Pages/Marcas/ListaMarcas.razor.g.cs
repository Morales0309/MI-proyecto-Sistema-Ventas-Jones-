#pragma checksum "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaMarcas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ccac7dbba77db11a7fc9d82e614e75e145e2236"
// <auto-generated/>
#pragma warning disable 1591
namespace SistemaVentasJones.Client.Pages.Marcas
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
#line 7 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaMarcas.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaMarcas.razor"
           [Authorize(Roles = "admin")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/lista-marcas")]
    public partial class ListaMarcas : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::MudBlazor.MudButton>(0);
            __builder.AddAttribute(1, "Variant", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Variant>(
#nullable restore
#line 9 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaMarcas.razor"
                    Variant.Filled

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(2, "StartIcon", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 9 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaMarcas.razor"
                                                Icons.Material.Filled.Create

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "Color", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 9 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaMarcas.razor"
                                                                                     Color.Success

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "Size", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Size>(
#nullable restore
#line 9 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaMarcas.razor"
                                                                                                          Size.Medium

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(6, "a");
                __builder2.AddAttribute(7, "style", "text-decoration:none; color:#fff;");
                __builder2.AddAttribute(8, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaMarcas.razor"
                                                           CrearArticulo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(9, "Agregar marca");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\n\n");
            __builder.AddMarkupContent(11, "<div class=\"d-flex justify-content-between mt-2 mb-2\"><div class=\"btn-group\"><a href=\"/lista-marcas-bajas\" style=\"background:none; border:none\">\n            &nbsp;&nbsp;<b>Dados de baja</b></a></div></div>\n\n<br>");
#nullable restore
#line 23 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaMarcas.razor"
 if (Marca == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(12, "<div class=\"d-flex justify-content-center align-items-center\" style=\"height:24rem\"><div class=\"spinner-border text-success\" role=\"status\"><span class=\"sr-only\">Cargando...</span></div></div>");
#nullable restore
#line 30 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaMarcas.razor"
}
else if (Marca.Count == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(13, "<div class=\"d-flex justify-content-center align-items-center\" style=\"height:24rem\"><text>No se encontraron marcas.</text></div>");
#nullable restore
#line 36 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaMarcas.razor"
}
else
{



#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::MudBlazor.MudButtonGroup>(14);
            __builder.AddAttribute(15, "Color", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 41 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaMarcas.razor"
                           Color.Primary

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(16, "Variant", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Variant>(
#nullable restore
#line 41 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaMarcas.razor"
                                                   Variant.Outlined

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(17, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudTooltip>(18);
                __builder2.AddAttribute(19, "Text", (object)("Exportar esta tabla a excel"));
                __builder2.AddAttribute(20, "Color", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 42 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaMarcas.razor"
                                                              Color.Tertiary

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(21, "Placement", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Placement>(
#nullable restore
#line 42 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaMarcas.razor"
                                                                                         Placement.Bottom

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(22, "Arrow", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 42 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaMarcas.razor"
                                                                                                                  true

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(23, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<global::MudBlazor.MudButton>(24);
                    __builder3.AddAttribute(25, "Variant", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Variant>(
#nullable restore
#line 43 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaMarcas.razor"
                                Variant.Filled

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(26, "StartIcon", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 43 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaMarcas.razor"
                                                            Icons.Custom.FileFormats.FileExcel

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(27, "onclick", (object)(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaMarcas.razor"
                             ExportarExcel

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(28, "Color", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 45 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaMarcas.razor"
                          Color.Warning

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(29, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(30, "Excel");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(31, "\n    <br>");
            global::__Blazor.SistemaVentasJones.Client.Pages.Marcas.ListaMarcas.TypeInference.CreateMudTable_0(__builder, 32, 33, 
#nullable restore
#line 51 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaMarcas.razor"
                      Marca

#line default
#line hidden
#nullable disable
            , 34, 
#nullable restore
#line 51 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaMarcas.razor"
                                     dense

#line default
#line hidden
#nullable disable
            , 35, 
#nullable restore
#line 51 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaMarcas.razor"
                                                    hover

#line default
#line hidden
#nullable disable
            , 36, 
#nullable restore
#line 51 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaMarcas.razor"
                                                                      bordered

#line default
#line hidden
#nullable disable
            , 37, 
#nullable restore
#line 51 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaMarcas.razor"
                                                                                          striped

#line default
#line hidden
#nullable disable
            , 38, 
#nullable restore
#line 51 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaMarcas.razor"
                                                                                                           new Func<Marcas,bool>(FilterFunc1)

#line default
#line hidden
#nullable disable
            , 39, 
#nullable restore
#line 52 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaMarcas.razor"
                              selectedItem1

#line default
#line hidden
#nullable disable
            , 40, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedItem1 = __value, selectedItem1)), 41, (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudText>(42);
                __builder2.AddAttribute(43, "Typo", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 54 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaMarcas.razor"
                           Typo.h6

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(44, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(45, "Marcas activas");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudSpacer>(47);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(48, "\n            ");
                global::__Blazor.SistemaVentasJones.Client.Pages.Marcas.ListaMarcas.TypeInference.CreateMudTextField_1(__builder2, 49, 50, "Buscar marca...", 51, 
#nullable restore
#line 56 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaMarcas.razor"
                                                                                               Adornment.Start

#line default
#line hidden
#nullable disable
                , 52, 
#nullable restore
#line 56 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaMarcas.razor"
                                                                                                                                Icons.Material.Filled.Search

#line default
#line hidden
#nullable disable
                , 53, 
#nullable restore
#line 56 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaMarcas.razor"
                                                                                                                                                                        Size.Medium

#line default
#line hidden
#nullable disable
                , 54, "mt-0", 55, 
#nullable restore
#line 56 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaMarcas.razor"
                                       searchString1

#line default
#line hidden
#nullable disable
                , 56, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => searchString1 = __value, searchString1)));
            }
            , 57, (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudTh>(58);
                __builder2.AddAttribute(59, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(60, "Nombre");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(61, "\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(62);
                __builder2.AddAttribute(63, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(64, "Descripción");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(65, "\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(66);
                __builder2.AddAttribute(67, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(68, "Fecha registro");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(69, "\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(70);
                __builder2.AddAttribute(71, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(72, "Acciones");
                }
                ));
                __builder2.CloseComponent();
            }
            , 73, (context) => (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudTd>(74);
                __builder2.AddAttribute(75, "DataLabel", (object)("Nombre"));
                __builder2.AddAttribute(76, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 68 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaMarcas.razor"
__builder3.AddContent(77, context.Nombre);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(78, "\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(79);
                __builder2.AddAttribute(80, "DataLabel", (object)("Descripción"));
                __builder2.AddAttribute(81, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 69 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaMarcas.razor"
__builder3.AddContent(82, context.Descripcion);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(83, "\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(84);
                __builder2.AddAttribute(85, "DataLabel", (object)("Fecha"));
                __builder2.AddAttribute(86, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 70 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaMarcas.razor"
__builder3.AddContent(87, context.Fecha);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(88, "\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(89);
                __builder2.AddAttribute(90, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<global::MudBlazor.MudFab>(91);
                    __builder3.AddAttribute(92, "Color", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 72 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaMarcas.razor"
                               Color.Error

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(93, "StartIcon", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 72 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaMarcas.razor"
                                                        Icons.Material.Filled.Edit

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(94, "Size", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Size>(
#nullable restore
#line 72 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaMarcas.razor"
                                                                                          Size.Small

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(95, "onclick", (object)(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaMarcas.razor"
                                () => NavigationManager.NavigateTo($"/editar-marcas/{context.Id}")

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            , 96, (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudTablePager>(97);
                __builder2.CloseComponent();
            }
            );
#nullable restore
#line 81 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaMarcas.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaMarcas.razor"
       
    private bool dense = false;
    private bool hover = true;
    private bool striped = true;
    private bool bordered = true;
    private string searchString1 = "";
    private Marcas selectedItem1 = null;
    private HashSet<Marcas> selectedItems = new HashSet<Marcas>();


    public List<Marcas> Marca { get; set; } //muestra todos los Categoria
    Marcas objMarca = new Marcas();

    private string NombreArtFiltro = String.Empty; //filtros

    protected bool lista = false;
    protected bool card = true;

    protected override async Task OnInitializedAsync()
    {
        await CargarMarcas();
    }

    async Task CargarMarcas()
    {
        var httpResponse = await Http.GetAsync($"api/marcas");
        if (httpResponse.IsSuccessStatusCode)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            Marca = JsonSerializer.Deserialize<List<Marcas>>(responseString,
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
        else
        {
            Console.WriteLine("error");
        }
    }

    void CambiarVista() //  esta parte cambia entre vista de tarjetas o vista de grilla
    {
        lista = !lista;
        card = !card;
    }


    async Task MostrarTodos()
    {
        await CargarMarcas();
    }

    void CrearArticulo()
    {
        NavigationManager.NavigateTo("crearmarca");
    }

    private async Task Filtrar()
    {
        await CargarMarcas();
    }

    private async Task Limpiar()
    {
        NombreArtFiltro = string.Empty;
        await CargarMarcas();
    }

    // esta es la funcion de filtrado de MudBlazor
    private bool FilterFunc1(Marcas element) => FilterFunc(element, searchString1);

    private bool FilterFunc(Marcas element, string searchString)
    {
        if (string.IsNullOrWhiteSpace(searchString))
            return true;
        if (element.Nombre.ToString().Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
 

        return false;
    }

    



    // funcion de exportación de datos de la table a través de Excel
    private void ExportarExcel()
    {
        using (var package = new ExcelPackage())
        {
            var worksheet = package.Workbook.Worksheets.Add("Marcas");
            worksheet.Cells["A1"].Value = "Jones";
            var tableBody = worksheet.Cells["A3:D3"].LoadFromCollection(
                from f in Marca
                select new { f.Id, f.Nombre, f.Descripcion, f.Estado }, true);
            using (ExcelRange r = worksheet.Cells["A1:D1"])
            {
                r.Merge = true; r.Style.Font.Bold = true;
                r.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.CenterContinuous;
                worksheet.DefaultColWidth = 60;
                r.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                r.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGreen);
            }
            worksheet.Cells["A2"].Value = $"Informe de marcas en existencia {DateTime.Now.ToLongTimeString()}";
            using (ExcelRange r = worksheet.Cells["A2:D2"])
            {
                r.Merge = true;
                r.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.CenterContinuous;
                worksheet.DefaultColWidth = 60;
                r.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                r.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightYellow);
            }


            var header = worksheet.Cells["A3:D3"];
            worksheet.DefaultColWidth = 32;
            tableBody.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

            //  esto afecta al cuerpo

            tableBody.Style.Fill.PatternType = ExcelFillStyle.None;
            // bordes
            tableBody.Style.Border.BorderAround(ExcelBorderStyle.Hair);
            worksheet.Cells.Style.Border.BorderAround(ExcelBorderStyle.Hair);

            // fuentes
            header.Style.Font.Bold = true;
            header.Style.Font.Color.SetColor(System.Drawing.Color.Black);

            // Este es el encabezado.
            header.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
            header.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);

            JS.GuardarComo($"Informe_Marcas_{DateTime.Now.ToShortDateString()}.xlsx", package.GetAsByteArray());
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.SistemaVentasJones.Client.Pages.Marcas.ListaMarcas
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
