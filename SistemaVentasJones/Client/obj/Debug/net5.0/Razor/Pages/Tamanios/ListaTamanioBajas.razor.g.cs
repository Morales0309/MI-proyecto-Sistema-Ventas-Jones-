#pragma checksum "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Tamanios\ListaTamanioBajas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09ef120f31bc5b8a3d6d5a63da6c7c6297686846"
// <auto-generated/>
#pragma warning disable 1591
namespace SistemaVentasJones.Client.Pages.Tamanios
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
#line 7 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Tamanios\ListaTamanioBajas.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Tamanios\ListaTamanioBajas.razor"
           [Authorize(Roles = "admin")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/lista-tamanios-bajas")]
    public partial class ListaTamanioBajas : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::MudBlazor.MudButton>(0);
            __builder.AddAttribute(1, "Variant", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Variant>(
#nullable restore
#line 9 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Tamanios\ListaTamanioBajas.razor"
                    Variant.Filled

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(2, "StartIcon", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 9 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Tamanios\ListaTamanioBajas.razor"
                                                Icons.Material.Filled.Create

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "Color", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 9 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Tamanios\ListaTamanioBajas.razor"
                                                                                     Color.Success

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "Size", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Size>(
#nullable restore
#line 9 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Tamanios\ListaTamanioBajas.razor"
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
#line 10 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Tamanios\ListaTamanioBajas.razor"
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
            __builder.AddMarkupContent(10, "\r\n\r\n");
            __builder.AddMarkupContent(11, "<div class=\"d-flex justify-content-between mt-2 mb-2\"><div class=\"btn-group\"><a href=\"/lista-marcas\" style=\"background:none; border:none\">\r\n            &nbsp;&nbsp;<b>Marcas activas</b></a></div></div>");
#nullable restore
#line 22 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Tamanios\ListaTamanioBajas.razor"
 if (Tamanio == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(12, "<div class=\"d-flex justify-content-center align-items-center\" style=\"height:24rem\"><div class=\"spinner-border text-success\" role=\"status\"><span class=\"sr-only\">Cargando...</span></div></div>");
#nullable restore
#line 29 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Tamanios\ListaTamanioBajas.razor"
}
else if (Tamanio.Count == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(13, "<div class=\"d-flex justify-content-center align-items-center\" style=\"height:24rem\"><text>No se encontraron tamaños.</text></div>");
#nullable restore
#line 35 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Tamanios\ListaTamanioBajas.razor"
}
else
{

#line default
#line hidden
#nullable disable
            global::__Blazor.SistemaVentasJones.Client.Pages.Tamanios.ListaTamanioBajas.TypeInference.CreateMudTable_0(__builder, 14, 15, 
#nullable restore
#line 38 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Tamanios\ListaTamanioBajas.razor"
                      Tamanio

#line default
#line hidden
#nullable disable
            , 16, 
#nullable restore
#line 38 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Tamanios\ListaTamanioBajas.razor"
                                       dense

#line default
#line hidden
#nullable disable
            , 17, 
#nullable restore
#line 38 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Tamanios\ListaTamanioBajas.razor"
                                                      hover

#line default
#line hidden
#nullable disable
            , 18, 
#nullable restore
#line 38 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Tamanios\ListaTamanioBajas.razor"
                                                                        bordered

#line default
#line hidden
#nullable disable
            , 19, 
#nullable restore
#line 38 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Tamanios\ListaTamanioBajas.razor"
                                                                                            striped

#line default
#line hidden
#nullable disable
            , 20, 
#nullable restore
#line 38 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Tamanios\ListaTamanioBajas.razor"
                                                                                                             new Func<Tamanios,bool>(FilterFunc1)

#line default
#line hidden
#nullable disable
            , 21, 
#nullable restore
#line 39 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Tamanios\ListaTamanioBajas.razor"
                              selectedItem1

#line default
#line hidden
#nullable disable
            , 22, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedItem1 = __value, selectedItem1)), 23, (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudText>(24);
                __builder2.AddAttribute(25, "Typo", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 41 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Tamanios\ListaTamanioBajas.razor"
                           Typo.h6

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(26, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(27, "Tamaños descontinuados");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudSpacer>(29);
                __builder2.CloseComponent();
            }
            , 30, (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudTh>(31);
                __builder2.AddAttribute(32, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(33, "Nombre");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(35);
                __builder2.AddAttribute(36, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(37, "Fecha registro");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(39);
                __builder2.AddAttribute(40, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(41, "Acciones");
                }
                ));
                __builder2.CloseComponent();
            }
            , 42, (context) => (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudTd>(43);
                __builder2.AddAttribute(44, "DataLabel", (object)("Nombre"));
                __builder2.AddAttribute(45, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 51 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Tamanios\ListaTamanioBajas.razor"
__builder3.AddContent(46, context.Nombre);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(47, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(48);
                __builder2.AddAttribute(49, "DataLabel", (object)("Fecha"));
                __builder2.AddAttribute(50, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 52 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Tamanios\ListaTamanioBajas.razor"
__builder3.AddContent(51, context.Fecha);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\r\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(53);
                __builder2.AddAttribute(54, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<global::MudBlazor.MudFab>(55);
                    __builder3.AddAttribute(56, "Color", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 54 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Tamanios\ListaTamanioBajas.razor"
                               Color.Error

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(57, "StartIcon", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 54 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Tamanios\ListaTamanioBajas.razor"
                                                        Icons.Material.Filled.Edit

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(58, "Size", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Size>(
#nullable restore
#line 54 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Tamanios\ListaTamanioBajas.razor"
                                                                                          Size.Small

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(59, "onclick", (object)(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Tamanios\ListaTamanioBajas.razor"
                                () => NavigationManager.NavigateTo($"/editar-tamanio/{context.Id}")

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            , 60, (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudTablePager>(61);
                __builder2.CloseComponent();
            }
            );
#nullable restore
#line 63 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Tamanios\ListaTamanioBajas.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Tamanios\ListaTamanioBajas.razor"
       
    private bool dense = false;
    private bool hover = true;
    private bool striped = true;
    private bool bordered = true;
    private string searchString1 = "";
    private Tamanios selectedItem1 = null;
    private HashSet<Tamanios> selectedItems = new HashSet<Tamanios>();


    public List<Tamanios> Tamanio { get; set; } //muestra todos los Categoria
    Tamanios objTamanio = new Tamanios();

    private string NombreArtFiltro = String.Empty; //filtros

    protected bool lista = false;
    protected bool card = true;

    protected override async Task OnInitializedAsync()
    {
        await CargarTamanios();
    }

    async Task CargarTamanios()
    {
        var httpResponse = await Http.GetAsync($"api/tamanios/bajas");
        if (httpResponse.IsSuccessStatusCode)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            Tamanio = JsonSerializer.Deserialize<List<Tamanios>>(responseString,
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
        else
        {
            Console.WriteLine("Error");
        }
    }


    void CrearArticulo()
    {
        NavigationManager.NavigateTo("creararticulo");
    }

    private async Task Filtrar()
    {
        await CargarTamanios();
    }

    private async Task Limpiar()
    {
        NombreArtFiltro = string.Empty;
        await CargarTamanios();
    }

    // esta es la funcion de filtrado de MudBlazor
    private bool FilterFunc1(Tamanios element) => FilterFunc(element, searchString1);

    private bool FilterFunc(Tamanios element, string searchString)
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.SistemaVentasJones.Client.Pages.Tamanios.ListaTamanioBajas
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
    }
}
#pragma warning restore 1591
