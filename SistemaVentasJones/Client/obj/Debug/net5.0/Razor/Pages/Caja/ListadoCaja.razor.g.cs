#pragma checksum "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b5a660b1f5ff46ed6c1b2736b0e27ba34af525e"
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
#line 4 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/lista-caja")]
    public partial class ListadoCaja : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\n    .mud-table-cell-custom-group {\n        font-weight: 500;\n    }\n\n    .mud-table-cell-custom-group-footer {\n        padding-bottom: 50px;\n        text-align: right;\n    }\n</style>\n\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "d-flex position-sticky justify-content-between mb-1");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "input-group");
            __builder.AddAttribute(5, "style", "width:60%");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "class", "form-control");
            __builder.AddAttribute(8, "type", "date");
            __builder.AddAttribute(9, "placeholder", "Fecha venta");
            __builder.AddAttribute(10, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
                                                                                 FechaFiltro

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(11, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => FechaFiltro = __value, FechaFiltro, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "input-group-append");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
                              Filtrar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "class", "btn btn-primary");
            __builder.AddAttribute(18, "type", "button");
            __builder.AddMarkupContent(19, "<i class=\"oi oi-magnifying-glass\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n            ");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
                              Limpiar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "class", "btn btn-danger");
            __builder.AddAttribute(24, "type", "button");
            __builder.AddMarkupContent(25, "<i class=\"oi oi-delete\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 29 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
 if (caja == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(26, "<div class=\"d-flex justify-content-center align-items-center\" style=\"height:24rem\"><div class=\"spinner-border-sm text-success\" role=\"status\"><span class=\"sr-only\">Cargando...</span></div></div>");
#nullable restore
#line 36 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
}
else if (caja.Count == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(27, "<div class=\"d-flex justify-content-center align-items-center\" style=\"height:24rem\"><text>No se encontró ninguna caja.</text></div>");
#nullable restore
#line 42 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::MudBlazor.MudButtonGroup>(28);
            __builder.AddAttribute(29, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 45 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
                           Color.Primary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Variant>(
#nullable restore
#line 45 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
                                                   Variant.Outlined

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudTooltip>(32);
                __builder2.AddAttribute(33, "Text", "Exportar esta tabla a excel");
                __builder2.AddAttribute(34, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 46 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
                                                              Color.Tertiary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "Placement", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Placement>(
#nullable restore
#line 46 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
                                                                                         Placement.Bottom

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "Arrow", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 46 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
                                                                                                                  true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<global::MudBlazor.MudButton>(38);
                    __builder3.AddAttribute(39, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Variant>(
#nullable restore
#line 47 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
                                Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(40, "StartIcon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 47 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
                                                            Icons.Custom.FileFormats.FileExcel

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(41, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
                             ExportarExcel

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(42, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 49 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
                          Color.Warning

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(43, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(44, "Excel");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(45, "\n    ");
            global::__Blazor.SistemaVentasJones.Client.Pages.Caja.ListadoCaja.TypeInference.CreateMudTable_0(__builder, 46, 47, 
#nullable restore
#line 52 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
                     true

#line default
#line hidden
#nullable disable
            , 48, 
#nullable restore
#line 52 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
                                       Breakpoint.Sm

#line default
#line hidden
#nullable disable
            , 49, "500px", 50, 
#nullable restore
#line 52 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
                                                                                  true

#line default
#line hidden
#nullable disable
            , 51, 
#nullable restore
#line 53 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
                  caja

#line default
#line hidden
#nullable disable
            , 52, 
#nullable restore
#line 54 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
                    _groupDefinition

#line default
#line hidden
#nullable disable
            , 53, "background-color:var(--mud-palette-background-grey)", 54, "mb-4", 55, 
#nullable restore
#line 57 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
                 true

#line default
#line hidden
#nullable disable
            , 56, (__builder2) => {
                __builder2.AddMarkupContent(57, "<col style=\"width: 60px;\">\n            <col>\n            <col>\n            <col>\n            <col>\n            <col>");
            }
            , 58, (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudTh>(59);
                __builder2.AddAttribute(60, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(61, "Fecha");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(62, "            \n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(63);
                __builder2.AddAttribute(64, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(65, "Entrada");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(66, "\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(67);
                __builder2.AddAttribute(68, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(69, "Salida");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(70, "\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(71);
                __builder2.AddAttribute(72, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(73, "Saldo");
                }
                ));
                __builder2.CloseComponent();
            }
            , 74, (context) => (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudTh>(75);
                __builder2.AddAttribute(76, "Class", "mud-table-cell-custom-group");
                __builder2.AddAttribute(77, "colspan", "5");
                __builder2.AddAttribute(78, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 73 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
__builder3.AddContent(79, $"{context.GroupName}{context.Key}");

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
            }
            , 80, (context) => (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudTd>(81);
                __builder2.AddAttribute(82, "DataLabel", "Fecha");
                __builder2.AddAttribute(83, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 76 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
__builder3.AddContent(84, context.Fecha);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(85, "                \n                ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(86);
                __builder2.AddAttribute(87, "DataLabel", "Entrada");
                __builder2.AddAttribute(88, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 77 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
__builder3.AddContent(89, context.Ingresos.ToString());

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(90, "\n                ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(91);
                __builder2.AddAttribute(92, "DataLabel", "Salida");
                __builder2.AddAttribute(93, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 78 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
__builder3.AddContent(94, context.Egresos.ToString());

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 79 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
                 if (context.Saldo < 0)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<global::MudBlazor.MudTd>(95);
                __builder2.AddAttribute(96, "Style", "color:red");
                __builder2.AddAttribute(97, "DataLabel", "Saldo");
                __builder2.AddAttribute(98, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 81 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
__builder3.AddContent(99, context.Saldo.ToString());

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 82 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<global::MudBlazor.MudTd>(100);
                __builder2.AddAttribute(101, "Style", "color:blue");
                __builder2.AddAttribute(102, "DataLabel", "Saldo");
                __builder2.AddAttribute(103, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 85 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
__builder3.AddContent(104, context.Saldo.ToString());

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 86 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<global::MudBlazor.MudTd>(105);
                __builder2.AddAttribute(106, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 89 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
                    if(context.IdVenta != 0)
                {                   

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<global::MudBlazor.MudButton>(107);
                    __builder3.AddAttribute(108, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 91 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
                                           () => NavigationManager.NavigateTo($"/ver-ventadetalle/{context.IdVenta}")

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(109, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Variant>(
#nullable restore
#line 92 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
                                Variant.Outlined

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(110, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 92 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
                                                         Color.Success

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(111, "EndIcon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 92 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
                                                                                  Icons.Filled.Payments

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(112, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(113, "Ver venta");
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 93 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
                 if(context.IdCompra != 0)
                {                   

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<global::MudBlazor.MudButton>(114);
                    __builder3.AddAttribute(115, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 96 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
                                           () => NavigationManager.NavigateTo($"/ver-compradetalle/{context.IdCompra}")

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(116, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Variant>(
#nullable restore
#line 97 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
                                Variant.Outlined

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(117, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 97 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
                                                         Color.Success

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(118, "EndIcon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 97 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
                                                                                  Icons.Filled.Payments

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(119, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(120, "Ver compra");
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 98 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
                }               

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
            }
            , 121, (context) => (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudTh>(122);
                __builder2.AddAttribute(123, "Class", "mud-table-cell-custom-group mud-table-cell-custom-group-footer");
                __builder2.AddAttribute(124, "colspan", "5");
                __builder2.AddAttribute(125, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(126, "div");
                    __builder3.AddAttribute(127, "style", "color:black;font-size:20px;font-weight:700;");
                    __builder3.AddMarkupContent(128, "\n                    SALDO ACTUAL:\n                    C$ ");
#nullable restore
#line 105 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
__builder3.AddContent(129, context.Items.OrderByDescending(x => x.Fecha).FirstOrDefault().Saldo.ToString("#.##"));

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            , 130, (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudTablePager>(131);
                __builder2.CloseComponent();
            }
            );
#nullable restore
#line 113 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 115 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Caja\ListadoCaja.razor"
       
    private DateTime FechaFiltro = DateTime.Today;
    public List<Caja> caja { get; set; }
    

    private bool dense = false;
    private bool hover = true;
    private bool striped = true;
    private bool bordered = true;
    private string searchString1 = "";
    private Caja selectedItem1 = null;
    private HashSet<Caja> selectedItems = new HashSet<Caja>();

    public int idventa { get; set; }

    private TableGroupDefinition<Caja> _groupDefinition = new()
        {
            GroupName = "Fecha: ",
            Indentation = true,
            Expandable = true,
            IsInitiallyExpanded = false,
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
            Console.WriteLine("Error cargando datos de caja");
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


    private void ExportarExcel()
    {
        using (var package = new ExcelPackage())
        {
            var worksheet = package.Workbook.Worksheets.Add("Caja");
            worksheet.Cells["A1"].Value = "Tienda Caprichos.";
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
namespace __Blazor.SistemaVentasJones.Client.Pages.Caja.ListadoCaja
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTable_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::MudBlazor.Breakpoint __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.Collections.Generic.IEnumerable<T> __arg4, int __seq5, global::MudBlazor.TableGroupDefinition<T> __arg5, int __seq6, global::System.String __arg6, int __seq7, global::System.String __arg7, int __seq8, global::System.Boolean __arg8, int __seq9, global::Microsoft.AspNetCore.Components.RenderFragment __arg9, int __seq10, global::Microsoft.AspNetCore.Components.RenderFragment __arg10, int __seq11, global::Microsoft.AspNetCore.Components.RenderFragment<global::MudBlazor.TableGroupData<global::System.Object, T>> __arg11, int __seq12, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg12, int __seq13, global::Microsoft.AspNetCore.Components.RenderFragment<global::MudBlazor.TableGroupData<global::System.Object, T>> __arg13, int __seq14, global::Microsoft.AspNetCore.Components.RenderFragment __arg14)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "Hover", __arg0);
        __builder.AddAttribute(__seq1, "Breakpoint", __arg1);
        __builder.AddAttribute(__seq2, "Height", __arg2);
        __builder.AddAttribute(__seq3, "FixedHeader", __arg3);
        __builder.AddAttribute(__seq4, "Items", __arg4);
        __builder.AddAttribute(__seq5, "GroupBy", __arg5);
        __builder.AddAttribute(__seq6, "GroupHeaderStyle", __arg6);
        __builder.AddAttribute(__seq7, "GroupFooterClass", __arg7);
        __builder.AddAttribute(__seq8, "Dense", __arg8);
        __builder.AddAttribute(__seq9, "ColGroup", __arg9);
        __builder.AddAttribute(__seq10, "HeaderContent", __arg10);
        __builder.AddAttribute(__seq11, "GroupHeaderTemplate", __arg11);
        __builder.AddAttribute(__seq12, "RowTemplate", __arg12);
        __builder.AddAttribute(__seq13, "GroupFooterTemplate", __arg13);
        __builder.AddAttribute(__seq14, "PagerContent", __arg14);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
