#pragma checksum "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListaCaja.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ed88569957dfeaae0ace3b511eb24b27ed98ba4"
// <auto-generated/>
#pragma warning disable 1591
namespace SistemaVentasJones.Client.Pages.Caja
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using SistemaVentasJones.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using SistemaVentasJones.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using SistemaVentasJones.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using SistemaVentasJones.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using MudBlazor.ThemeManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using MudBlazor.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using CsvHelper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using OfficeOpenXml;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using OfficeOpenXml.Style;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListaCaja.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListaCaja.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/listado-caja")]
    public partial class ListaCaja : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "d-flex position-sticky justify-content-between mb-1");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "input-group");
            __builder.AddAttribute(4, "style", "width:60%");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "class", "form-control");
            __builder.AddAttribute(7, "type", "date");
            __builder.AddAttribute(8, "placeholder", "Fecha venta");
            __builder.AddAttribute(9, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListaCaja.razor"
                                                                                 FechaFiltro

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(10, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => FechaFiltro = __value, FechaFiltro, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "input-group-append");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListaCaja.razor"
                              Filtrar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "class", "btn btn-primary");
            __builder.AddAttribute(17, "type", "button");
            __builder.AddMarkupContent(18, "<i class=\"oi oi-magnifying-glass\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n            ");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListaCaja.razor"
                              Limpiar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "class", "btn btn-danger");
            __builder.AddAttribute(23, "type", "button");
            __builder.AddMarkupContent(24, "<i class=\"oi oi-delete\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 19 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListaCaja.razor"
 if (caja == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(25, "<div class=\"d-flex justify-content-center align-items-center\" style=\"height:24rem\"><div class=\"spinner-border-sm text-success\" role=\"status\"><span class=\"sr-only\">Cargando...</span></div></div>");
#nullable restore
#line 26 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListaCaja.razor"
}
else if (caja.Count == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(26, "<div class=\"d-flex justify-content-center align-items-center\" style=\"height:24rem\"><text>No se encontró ninguna caja.</text></div>");
#nullable restore
#line 32 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListaCaja.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::MudBlazor.MudButtonGroup>(27);
            __builder.AddAttribute(28, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 35 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListaCaja.razor"
                           Color.Primary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Variant>(
#nullable restore
#line 35 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListaCaja.razor"
                                                   Variant.Outlined

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudTooltip>(31);
                __builder2.AddAttribute(32, "Text", "Exportar esta tabla a excel");
                __builder2.AddAttribute(33, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 36 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListaCaja.razor"
                                                              Color.Tertiary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "Placement", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Placement>(
#nullable restore
#line 36 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListaCaja.razor"
                                                                                         Placement.Bottom

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "Arrow", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 36 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListaCaja.razor"
                                                                                                                  true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<global::MudBlazor.MudButton>(37);
                    __builder3.AddAttribute(38, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Variant>(
#nullable restore
#line 37 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListaCaja.razor"
                                Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(39, "StartIcon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 37 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListaCaja.razor"
                                                            Icons.Custom.FileFormats.FileExcel

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(40, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListaCaja.razor"
                             ExportarExcel

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(41, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 39 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListaCaja.razor"
                          Color.Warning

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(42, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(43, "Excel");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            global::__Blazor.SistemaVentasJones.Client.Pages.Caja.ListaCaja.TypeInference.CreateMudTable_0(__builder, 44, 45, 
#nullable restore
#line 43 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListaCaja.razor"
                      caja

#line default
#line hidden
#nullable disable
            , 46, "mb-4", 47, 
#nullable restore
#line 43 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListaCaja.razor"
                                                              _groupDefinition

#line default
#line hidden
#nullable disable
            , 48, 
#nullable restore
#line 43 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListaCaja.razor"
                                                                                        dense

#line default
#line hidden
#nullable disable
            , 49, 
#nullable restore
#line 43 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListaCaja.razor"
                                                                                                       hover

#line default
#line hidden
#nullable disable
            , 50, 
#nullable restore
#line 43 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListaCaja.razor"
                                                                                                                         bordered

#line default
#line hidden
#nullable disable
            , 51, 
#nullable restore
#line 43 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListaCaja.razor"
                                                                                                                                             striped

#line default
#line hidden
#nullable disable
            , 52, 
#nullable restore
#line 43 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListaCaja.razor"
                                                                                                                                                              new Func<Caja,bool>(FilterFunc1)

#line default
#line hidden
#nullable disable
            , 53, 
#nullable restore
#line 44 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListaCaja.razor"
                              selectedItem1

#line default
#line hidden
#nullable disable
            , 54, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedItem1 = __value, selectedItem1)), 55, (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudText>(56);
                __builder2.AddAttribute(57, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 46 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListaCaja.razor"
                           Typo.h6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(59, "Entradas/salidas");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(60, "\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudSpacer>(61);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(62, "\n            ");
                global::__Blazor.SistemaVentasJones.Client.Pages.Caja.ListaCaja.TypeInference.CreateMudTextField_1(__builder2, 63, 64, "Buscar...", 65, 
#nullable restore
#line 48 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListaCaja.razor"
                                                                                         Adornment.Start

#line default
#line hidden
#nullable disable
                , 66, 
#nullable restore
#line 48 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListaCaja.razor"
                                                                                                                          Icons.Material.Filled.Search

#line default
#line hidden
#nullable disable
                , 67, 
#nullable restore
#line 48 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListaCaja.razor"
                                                                                                                                                                  Size.Medium

#line default
#line hidden
#nullable disable
                , 68, "mt-0", 69, 
#nullable restore
#line 48 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListaCaja.razor"
                                       searchString1

#line default
#line hidden
#nullable disable
                , 70, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => searchString1 = __value, searchString1)));
            }
            , 71, (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudTh>(72);
                __builder2.AddAttribute(73, "Style", "width:50px;");
                __builder2.AddAttribute(74, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(75, "Nr");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(76, "\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(77);
                __builder2.AddAttribute(78, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(79, "Fecha");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(80, "\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(81);
                __builder2.AddAttribute(82, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(83, "Entrada");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(84, "\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(85);
                __builder2.AddAttribute(86, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(87, "Salida");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(88, "\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(89);
                __builder2.AddAttribute(90, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(91, "Saldo");
                }
                ));
                __builder2.CloseComponent();
            }
            , 92, (context) => (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudTh>(93);
                __builder2.AddAttribute(94, "Style", "display:none");
                __builder2.AddAttribute(95, "Class", "mud-table-cell-custom-group");
                __builder2.AddAttribute(96, "colspan", "5");
                __builder2.AddAttribute(97, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 59 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListaCaja.razor"
__builder3.AddContent(98, $"{context.GroupName}: {context.Key}");

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
            }
            , 99, (context) => (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudTd>(100);
                __builder2.AddAttribute(101, "DataLabel", "Id");
                __builder2.AddAttribute(102, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 62 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListaCaja.razor"
__builder3.AddContent(103, context.Id);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(104, "\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(105);
                __builder2.AddAttribute(106, "DataLabel", "Fecha");
                __builder2.AddAttribute(107, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 63 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListaCaja.razor"
__builder3.AddContent(108, context.Fecha.ToLongDateString());

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(109, "\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(110);
                __builder2.AddAttribute(111, "DataLabel", "Ingresos");
                __builder2.AddAttribute(112, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 64 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListaCaja.razor"
__builder3.AddContent(113, context.Ingresos.ToString("C",CultureInfo.CreateSpecificCulture("ni-NI")));

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(114, "\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(115);
                __builder2.AddAttribute(116, "DataLabel", "Egresos");
                __builder2.AddAttribute(117, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 66 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListaCaja.razor"
__builder3.AddContent(118, context.Egresos.ToString("C",CultureInfo.CreateSpecificCulture("ni-NI")));

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 68 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListaCaja.razor"
             if(context.Saldo < 0 )
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<global::MudBlazor.MudTd>(119);
                __builder2.AddAttribute(120, "Style", "color:red");
                __builder2.AddAttribute(121, "DataLabel", "Saldo");
                __builder2.AddAttribute(122, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 70 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListaCaja.razor"
__builder3.AddContent(123, context.Saldo.ToString("C",CultureInfo.CreateSpecificCulture("ni-NI")));

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 71 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListaCaja.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<global::MudBlazor.MudTd>(124);
                __builder2.AddAttribute(125, "Style", "color:green");
                __builder2.AddAttribute(126, "DataLabel", "Saldo");
                __builder2.AddAttribute(127, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 74 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListaCaja.razor"
__builder3.AddContent(128, context.Saldo.ToString("0,0.00"));

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(129, ")");
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 75 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListaCaja.razor"
            }

#line default
#line hidden
#nullable disable
            }
            , 130, (context) => (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudTh>(131);
                __builder2.AddAttribute(132, "Class", "mud-table-cell-custom-group mud-table-cell-custom-group-footer");
                __builder2.AddAttribute(133, "colspan", "5");
                __builder2.AddAttribute(134, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(135, "div");
                    __builder3.AddAttribute(136, "style", "color:red;font-size:20px;font-weight:700;");
                    __builder3.AddContent(137, "Saldo total: ");
#nullable restore
#line 80 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListaCaja.razor"
__builder3.AddContent(138, context.Items.Sum((e) => e.Saldo));

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            , 139, (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudTablePager>(140);
                __builder2.CloseComponent();
            }
            );
#nullable restore
#line 87 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListaCaja.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 88 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListaCaja.razor"
       
    public List<Caja> caja { get; set; }

    private bool dense = false;
    private bool hover = true;
    private bool striped = true;
    private bool bordered = true;
    private string searchString1 = "";
    private Caja selectedItem1 = null;
    private HashSet<Caja> selectedItems = new HashSet<Caja>();

    private DateTime FechaFiltro = DateTime.Today;

    private TableGroupDefinition<Caja> _groupDefinition = new()
        {
            GroupName = "Fecha",
            Indentation = false,
            Expandable = false,
            Selector = (e) => e.Fecha.ToLongDateString()
        };

    

    protected override async Task OnInitializedAsync()
    {
        try
        {
            await CargarCaja();
        }
        catch (AccessTokenNotAvailableException exception)
        {
            exception.Redirect();
        }
    }

    async Task CargarCaja()
    {
        string fecha = Convert.ToString(FechaFiltro);

        var httpResponse = await Http.GetAsync($"api/caja/filtro?fecha={fecha}");
        if (httpResponse.IsSuccessStatusCode)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            caja = JsonSerializer.Deserialize<List<Caja>>(responseString,
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
        else
        {
            Console.WriteLine("Error en caja");
        }
    }
 

    void CrearVenta()
    {
        NavigationManager.NavigateTo("crear-caja");
    }

    private async Task Filtrar()
    {
        await CargarCaja();
    }

    private async Task Limpiar()
    {
        FechaFiltro = DateTime.Today;
        await CargarCaja();
    }

    // esta es la funcion de filtrado de MudBlazor
    private bool FilterFunc1(Caja element) => FilterFunc(element, searchString1);

    private bool FilterFunc(Caja element, string searchString)
    {
        if (string.IsNullOrWhiteSpace(searchString))
            return true;
        if (element.Fecha.ToString().Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        return false;
    }


    private void ExportarExcel()
    {
        using (var package = new ExcelPackage())
        {
            var worksheet = package.Workbook.Worksheets.Add("Caja");
            worksheet.Cells["A1"].Value = "Tienda Jones.";
            using (ExcelRange r = worksheet.Cells["A1:E1"])
            {
                r.Merge = true; r.Style.Font.Bold = true;
                r.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.CenterContinuous;
                worksheet.DefaultColWidth = 60;
                r.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                r.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGreen);
            }
            worksheet.Cells["A2"].Value = $"Salidas / Entradas de dinero en caja {DateTime.Now.ToLongTimeString()}";
            using (ExcelRange r = worksheet.Cells["A2:E2"])
            {
                r.Merge = true;
                r.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.CenterContinuous;
                worksheet.DefaultColWidth = 60;
                r.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                r.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightYellow);
            }

            var tableBody = worksheet.Cells["A3:D3"].LoadFromCollection(
    from f in caja
    select new { f.Id, f.Fecha, f.Ingresos, f.Egresos, f.Saldo }, true);

            var header = worksheet.Cells["A3:E3"];
            worksheet.DefaultColWidth = 32;
            tableBody.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

            //  esto afectal cuerpo

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

            JS.GuardarComo($"Informe_EntradasSalidas_{DateTime.Now.ToShortDateString()}.xlsx", package.GetAsByteArray());
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
namespace __Blazor.SistemaVentasJones.Client.Pages.Caja.ListaCaja
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTable_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::MudBlazor.TableGroupDefinition<T> __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::System.Boolean __arg5, int __seq6, global::System.Boolean __arg6, int __seq7, global::System.Func<T, global::System.Boolean> __arg7, int __seq8, T __arg8, int __seq9, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg9, int __seq10, global::Microsoft.AspNetCore.Components.RenderFragment __arg10, int __seq11, global::Microsoft.AspNetCore.Components.RenderFragment __arg11, int __seq12, global::Microsoft.AspNetCore.Components.RenderFragment<global::MudBlazor.TableGroupData<global::System.Object, T>> __arg12, int __seq13, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg13, int __seq14, global::Microsoft.AspNetCore.Components.RenderFragment<global::MudBlazor.TableGroupData<global::System.Object, T>> __arg14, int __seq15, global::Microsoft.AspNetCore.Components.RenderFragment __arg15)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "GroupFooterClass", __arg1);
        __builder.AddAttribute(__seq2, "GroupBy", __arg2);
        __builder.AddAttribute(__seq3, "Dense", __arg3);
        __builder.AddAttribute(__seq4, "Hover", __arg4);
        __builder.AddAttribute(__seq5, "Bordered", __arg5);
        __builder.AddAttribute(__seq6, "Striped", __arg6);
        __builder.AddAttribute(__seq7, "Filter", __arg7);
        __builder.AddAttribute(__seq8, "SelectedItem", __arg8);
        __builder.AddAttribute(__seq9, "SelectedItemChanged", __arg9);
        __builder.AddAttribute(__seq10, "ToolBarContent", __arg10);
        __builder.AddAttribute(__seq11, "HeaderContent", __arg11);
        __builder.AddAttribute(__seq12, "GroupHeaderTemplate", __arg12);
        __builder.AddAttribute(__seq13, "RowTemplate", __arg13);
        __builder.AddAttribute(__seq14, "GroupFooterTemplate", __arg14);
        __builder.AddAttribute(__seq15, "PagerContent", __arg15);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Adornment __arg1, int __seq2, global::System.String __arg2, int __seq3, global::MudBlazor.Size __arg3, int __seq4, global::System.String __arg4, int __seq5, T __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg6)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Placeholder", __arg0);
        __builder.AddAttribute(__seq1, "Adornment", __arg1);
        __builder.AddAttribute(__seq2, "AdornmentIcon", __arg2);
        __builder.AddAttribute(__seq3, "IconSize", __arg3);
        __builder.AddAttribute(__seq4, "Class", __arg4);
        __builder.AddAttribute(__seq5, "Value", __arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", __arg6);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
