#pragma checksum "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4dace27a2f51ee9f46f79635356dfda95d6b0945"
// <auto-generated/>
#pragma warning disable 1591
namespace SistemaVentasJones.Client.Pages.Ventas
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
#line 3 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    public partial class FormVenta : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 6 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
                  venta

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
                                        OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "form-field mt-2 mb-2");
                __builder2.AddAttribute(6, "b-zdixc85q91");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group row");
                __builder2.AddAttribute(9, "hidden", 
#nullable restore
#line 8 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
                                             ocultaclientes

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(10, "b-zdixc85q91");
                __builder2.AddMarkupContent(11, "<label class=\"col-3 col-form-label\" b-zdixc85q91>Cliente</label>\r\n            ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "col");
                __builder2.AddAttribute(14, "b-zdixc85q91");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "input-group");
                __builder2.AddAttribute(17, "b-zdixc85q91");
                global::__Blazor.SistemaVentasJones.Client.Pages.Ventas.FormVenta.TypeInference.CreateInputSelect_0(__builder2, 18, 19, "form-control select2", 20, 
#nullable restore
#line 13 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
                                              venta.ClienteId

#line default
#line hidden
#nullable disable
                , 21, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => venta.ClienteId = __value, venta.ClienteId)), 22, () => venta.ClienteId, 23, (__builder3) => {
                    __builder3.AddMarkupContent(24, "<option selected value=\"0\" b-zdixc85q91>Seleccione cliente</option>");
#nullable restore
#line 15 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
                         foreach (var cliente in clientes)
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(25, "option");
                    __builder3.AddAttribute(26, "value", 
#nullable restore
#line 17 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
                                            cliente.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(27, "b-zdixc85q91");
#nullable restore
#line 17 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
__builder3.AddContent(28, cliente.Nombre);

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(29, " | Cédula:");
#nullable restore
#line 17 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
__builder3.AddContent(30, cliente.Cedula);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 18 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
                        }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                ");
                global::__Blazor.SistemaVentasJones.Client.Pages.Ventas.FormVenta.TypeInference.CreateValidationMessage_1(__builder2, 32, 33, 
#nullable restore
#line 21 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
                                          () => venta.ClienteId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n\r\n        ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "form-group");
                __builder2.AddAttribute(37, "b-zdixc85q91");
#nullable restore
#line 26 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
             for (int i = 0; i < venta.DetalleVentas.Count; i++)
            {
                var indice = i;
                var detalle = venta.DetalleVentas[i];
                listadetalle = venta.DetalleVentas;


#line default
#line hidden
#nullable disable
                __builder2.OpenElement(38, "h5");
                __builder2.AddAttribute(39, "b-zdixc85q91");
                __builder2.AddContent(40, "Detalle #");
#nullable restore
#line 32 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
__builder2.AddContent(41, i + 1);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.OpenComponent<global::MudBlazor.MudCard>(42);
                __builder2.AddAttribute(43, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(44, "div");
                    __builder3.AddAttribute(45, "class", "row");
                    __builder3.AddAttribute(46, "b-zdixc85q91");
                    __builder3.OpenElement(47, "div");
                    __builder3.AddAttribute(48, "class", "col-12 form-group");
                    __builder3.AddAttribute(49, "b-zdixc85q91");
                    __builder3.OpenElement(50, "div");
                    __builder3.AddAttribute(51, "class", "d-flex justify-content-between align-items-center m-1");
                    __builder3.AddAttribute(52, "b-zdixc85q91");
                    __builder3.AddMarkupContent(53, "<label b-zdixc85q91>Artículo</label>\r\n                                ");
                    __builder3.OpenElement(54, "button");
                    __builder3.AddAttribute(55, "type", "button");
                    __builder3.AddAttribute(56, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
                                                                  () => venta.DetalleVentas.RemoveAt(indice)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(57, "class", "btn btn-danger btn-sm");
                    __builder3.AddAttribute(58, "style", "border-radius:10px");
                    __builder3.AddAttribute(59, "b-zdixc85q91");
                    __builder3.AddMarkupContent(60, "<i class=\"oi oi-trash\" b-zdixc85q91></i>");
                    __builder3.OpenElement(61, "text");
                    __builder3.AddAttribute(62, "style", "color:white");
                    __builder3.AddAttribute(63, "b-zdixc85q91");
                    __builder3.AddMarkupContent(64, "Quitar ítem ");
#nullable restore
#line 41 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
__builder3.AddContent(65, indice + 1);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(66, "\r\n\r\n                            ");
                    global::__Blazor.SistemaVentasJones.Client.Pages.Ventas.FormVenta.TypeInference.CreateInputSelect_2(__builder3, 67, 68, true, 69, "form-control", 70, 
#nullable restore
#line 45 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
                                                      detalle.ArticuloId

#line default
#line hidden
#nullable disable
                    , 71, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => detalle.ArticuloId = __value, detalle.ArticuloId)), 72, () => detalle.ArticuloId, 73, (__builder4) => {
                        __builder4.AddMarkupContent(74, "<option selected value b-zdixc85q91>Seleccione un artículo</option>");
#nullable restore
#line 47 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
                                 foreach (var articulo in articulos)
                                {
                                    if (articulo.StockActual > 0)
                                    {

#line default
#line hidden
#nullable disable
                        __builder4.OpenElement(75, "option");
                        __builder4.AddAttribute(76, "value", 
#nullable restore
#line 51 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
                                                        articulo.Id

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddAttribute(77, "b-zdixc85q91");
#nullable restore
#line 51 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
__builder4.AddContent(78, articulo.Nombre);

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(79, " | C$ ");
#nullable restore
#line 51 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
__builder4.AddContent(80, articulo.PrecioUnitario);

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(81, " | STOCK: ");
#nullable restore
#line 51 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
__builder4.AddContent(82, articulo.StockActual);

#line default
#line hidden
#nullable disable
                        __builder4.CloseElement();
#nullable restore
#line 52 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
                                    }
                                }

#line default
#line hidden
#nullable disable
                    }
                    );
                    __builder3.AddMarkupContent(83, "\r\n\r\n                            ");
                    global::__Blazor.SistemaVentasJones.Client.Pages.Ventas.FormVenta.TypeInference.CreateValidationMessage_3(__builder3, 84, 85, 
#nullable restore
#line 56 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
                                                      () => detalle.ArticuloId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.CloseElement();
#nullable restore
#line 60 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
                     foreach (var art in articulos)
                    {
                        if (detalle.ArticuloId == art.Id)
                        {
                            cantidadmax = art.StockActual;
                            detalle.Precio = art.PrecioUnitario;
                        }
                    }

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(86, "div");
                    __builder3.AddAttribute(87, "class", "row");
                    __builder3.AddAttribute(88, "b-zdixc85q91");
                    __builder3.OpenElement(89, "div");
                    __builder3.AddAttribute(90, "class", "col-5 form-group");
                    __builder3.AddAttribute(91, "b-zdixc85q91");
                    __builder3.AddMarkupContent(92, "<label b-zdixc85q91>Cantidad</label>\r\n                            ");
                    global::__Blazor.SistemaVentasJones.Client.Pages.Ventas.FormVenta.TypeInference.CreateMudNumericField_4(__builder3, 93, 94, "Ingrese la cantidad", 95, 
#nullable restore
#line 73 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
                                                                                                                 Variant.Outlined

#line default
#line hidden
#nullable disable
                    , 96, 
#nullable restore
#line 74 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
                                                  1

#line default
#line hidden
#nullable disable
                    , 97, 
#nullable restore
#line 74 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
                                                           cantidadmax

#line default
#line hidden
#nullable disable
                    , 98, 
#nullable restore
#line 74 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
                                                                              1

#line default
#line hidden
#nullable disable
                    , 99, 
#nullable restore
#line 73 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
                                                          detalle.Cantidad

#line default
#line hidden
#nullable disable
                    , 100, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => detalle.Cantidad = __value, detalle.Cantidad)));
                    __builder3.AddMarkupContent(101, "\r\n                            ");
                    global::__Blazor.SistemaVentasJones.Client.Pages.Ventas.FormVenta.TypeInference.CreateValidationMessage_5(__builder3, 102, 103, 
#nullable restore
#line 75 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
                                                      () => detalle.Cantidad

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(104, "\r\n\r\n                        ");
                    __builder3.OpenElement(105, "div");
                    __builder3.AddAttribute(106, "class", "col-5 form-group");
                    __builder3.AddAttribute(107, "b-zdixc85q91");
                    __builder3.AddMarkupContent(108, "<label b-zdixc85q91>Descuento</label>\r\n                            ");
                    global::__Blazor.SistemaVentasJones.Client.Pages.Ventas.FormVenta.TypeInference.CreateMudNumericField_6(__builder3, 109, 110, "Ingrese el descuento por producto", 111, 
#nullable restore
#line 81 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
                                                                                                                                Variant.Outlined

#line default
#line hidden
#nullable disable
                    , 112, 
#nullable restore
#line 82 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
                                                  0

#line default
#line hidden
#nullable disable
                    , 113, 
#nullable restore
#line 82 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
                                                          100

#line default
#line hidden
#nullable disable
                    , 114, 
#nullable restore
#line 82 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
                                                                     5

#line default
#line hidden
#nullable disable
                    , 115, 
#nullable restore
#line 81 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
                                                          detalle.Descuento

#line default
#line hidden
#nullable disable
                    , 116, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => detalle.Descuento = __value, detalle.Descuento)));
                    __builder3.AddMarkupContent(117, "\r\n                            ");
                    global::__Blazor.SistemaVentasJones.Client.Pages.Ventas.FormVenta.TypeInference.CreateValidationMessage_7(__builder3, 118, 119, 
#nullable restore
#line 83 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
                                                      () => detalle.Descuento

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(120, "\r\n\r\n                        ");
                    __builder3.OpenElement(121, "div");
                    __builder3.AddAttribute(122, "class", "col-5");
                    __builder3.AddAttribute(123, "b-zdixc85q91");
                    __builder3.AddMarkupContent(124, "<div class=\"d-flex justify-content-start mb-2 ml-2 mr-2\" b-zdixc85q91><h3 b-zdixc85q91>Subtotal</h3></div>\r\n                            ");
                    __builder3.OpenElement(125, "div");
                    __builder3.AddAttribute(126, "class", "d-flex justify-content-end mt-3 ml-2 mr-2");
                    __builder3.AddAttribute(127, "b-zdixc85q91");
                    __builder3.OpenElement(128, "h4");
                    __builder3.AddAttribute(129, "b-zdixc85q91");
                    __builder3.OpenElement(130, "b");
                    __builder3.AddAttribute(131, "b-zdixc85q91");
                    __builder3.AddContent(132, "C$ ");
#nullable restore
#line 91 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
__builder3.AddContent(133, Math.Round(detalle.SubTotal,2));

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 105 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(134, "div");
                __builder2.AddAttribute(135, "class", "btn-group");
                __builder2.AddAttribute(136, "b-zdixc85q91");
                __builder2.OpenElement(137, "button");
                __builder2.AddAttribute(138, "type", "button");
                __builder2.AddAttribute(139, "class", "btn btn-success");
                __builder2.AddAttribute(140, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 109 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
                            () => venta.DetalleVentas.Add(new DetalleVenta())

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(141, "b-zdixc85q91");
                __builder2.AddMarkupContent(142, "\r\n                    Agregar detalle\r\n                ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(143, "\r\n\r\n            ");
                __builder2.OpenElement(144, "div");
                __builder2.AddAttribute(145, "class", "d-flex justify-content-end py-2");
                __builder2.AddAttribute(146, "b-zdixc85q91");
                __builder2.OpenElement(147, "button");
                __builder2.AddAttribute(148, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 115 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
                                    () => CalcularTotal()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(149, "type", "button");
                __builder2.AddAttribute(150, "class", "");
                __builder2.AddAttribute(151, "style", "border:none");
                __builder2.AddAttribute(152, "b-zdixc85q91");
                __builder2.AddMarkupContent(153, "<h3 b-zdixc85q91><b b-zdixc85q91>TOTAL: <br b-zdixc85q91></b></h3>");
#nullable restore
#line 117 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
                     if (venta.Total != 0)
                    {


#line default
#line hidden
#nullable disable
                __builder2.OpenElement(154, "h2");
                __builder2.AddAttribute(155, "b-zdixc85q91");
                __builder2.OpenElement(156, "b");
                __builder2.AddAttribute(157, "b-zdixc85q91");
                __builder2.AddMarkupContent(158, "<br b-zdixc85q91>C$ ");
#nullable restore
#line 120 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
__builder2.AddContent(159, Math.Round(venta.Total,2));

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 121 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(160, "\r\n\r\n            ");
                __builder2.OpenElement(161, "div");
                __builder2.AddAttribute(162, "class", "btn-group btn-block");
                __builder2.AddAttribute(163, "b-zdixc85q91");
                __builder2.OpenElement(164, "button");
                __builder2.AddAttribute(165, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 126 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
                                    () => CalcularTotal()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(166, "type", "submit");
                __builder2.AddAttribute(167, "class", "btn btn-success");
                __builder2.AddAttribute(168, "b-zdixc85q91");
                __builder2.AddMarkupContent(169, "<i class=\"oi oi-check\" b-zdixc85q91></i>");
                __builder2.OpenElement(170, "text");
                __builder2.AddAttribute(171, "style", "color:white");
                __builder2.AddAttribute(172, "b-zdixc85q91");
#nullable restore
#line 126 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
__builder2.AddContent(173, textSubmit);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(174, "\r\n                ");
                __builder2.OpenElement(175, "button");
                __builder2.AddAttribute(176, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 127 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
                                   Volver

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(177, "class", "btn btn-danger");
                __builder2.AddAttribute(178, "b-zdixc85q91");
                __builder2.AddMarkupContent(179, "<i class=\"oi oi-x\" b-zdixc85q91></i>");
                __builder2.AddMarkupContent(180, "<text style=\"color:white\" b-zdixc85q91> Cancelar y volver atrás</text>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(181, "\r\n    ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(182);
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 134 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
       
    [Parameter] public Venta venta { get; set; } = new Venta();
    [Parameter] public List<Cliente> clientes { get; set; } = new List<Cliente>();
    [Parameter] public List<Articulo> articulos { get; set; } = new List<Articulo>();
    [Parameter] public EventCallback OnValidSubmit { get; set; }
    [Parameter] public string textSubmit { get; set; }

    public decimal Iva = 15M / 100M;

    public bool ocultaclientes = false;

    public List<DetalleVenta> listadetalle { get; set; } = new List<DetalleVenta>();

    public int cantidadmax { get; set; } //cantidad maxima de un articulo por su stock

    decimal CalcularTotal()
    {
        venta.Total = 0;
        if (listadetalle.Count > 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 154 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
             for (int i = 0; i < listadetalle.Count; i++)
            {
                venta.Total += listadetalle[i].SubTotalConDescuento;
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 157 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Ventas\FormVenta.razor"
             
        }
        return venta.Total;
    }


    void Volver()
    {
        NavigationManager.NavigateTo("/lista-ventas");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
namespace __Blazor.SistemaVentasJones.Client.Pages.Ventas.FormVenta
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, global::System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "required", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateMudNumericField_4<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, T __arg2, int __seq3, T __arg3, int __seq4, T __arg4, int __seq5, T __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg6)
        {
        __builder.OpenComponent<global::MudBlazor.MudNumericField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Min", __arg2);
        __builder.AddAttribute(__seq3, "Max", __arg3);
        __builder.AddAttribute(__seq4, "Step", __arg4);
        __builder.AddAttribute(__seq5, "Value", __arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateMudNumericField_6<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, T __arg2, int __seq3, T __arg3, int __seq4, T __arg4, int __seq5, T __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg6)
        {
        __builder.OpenComponent<global::MudBlazor.MudNumericField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Min", __arg2);
        __builder.AddAttribute(__seq3, "Max", __arg3);
        __builder.AddAttribute(__seq4, "Step", __arg4);
        __builder.AddAttribute(__seq5, "Value", __arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", __arg6);
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
