#pragma checksum "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaBajasMarcas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecc3b3b4a544002966c249233ba6f61c05afe326"
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
#line 25 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaBajasMarcas.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaBajasMarcas.razor"
           [Authorize(Roles = "admin")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/lista-marcas-bajas")]
    public partial class ListaBajasMarcas : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::MudBlazor.MudButton>(0);
            __builder.AddAttribute(1, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Variant>(
#nullable restore
#line 9 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaBajasMarcas.razor"
                    Variant.Filled

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "StartIcon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 9 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaBajasMarcas.razor"
                                                Icons.Material.Filled.Create

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 9 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaBajasMarcas.razor"
                                                                                     Color.Success

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "Size", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Size>(
#nullable restore
#line 9 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaBajasMarcas.razor"
                                                                                                          Size.Medium

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(6, "a");
                __builder2.AddAttribute(7, "style", "text-decoration:none; color:#fff;");
                __builder2.AddAttribute(8, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaBajasMarcas.razor"
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
            __builder.AddMarkupContent(11, "<div class=\"d-flex justify-content-between mt-2 mb-2\"><div class=\"btn-group\"><a href=\"/lista-marcas\" style=\"background:none; border:none\">\n            &nbsp;&nbsp;<b>Marcas activas</b></a></div></div>");
#nullable restore
#line 22 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaBajasMarcas.razor"
 if (Marca == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(12, "<div class=\"d-flex justify-content-center align-items-center\" style=\"height:24rem\"><div class=\"spinner-border text-success\" role=\"status\"><span class=\"sr-only\">Cargando...</span></div></div>");
#nullable restore
#line 29 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaBajasMarcas.razor"
}
else if (Marca.Count == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(13, "<div class=\"d-flex justify-content-center align-items-center\" style=\"height:24rem\"><text>No se encontraron marcas.</text></div>");
#nullable restore
#line 35 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaBajasMarcas.razor"
}
else
{

#line default
#line hidden
#nullable disable
            global::__Blazor.SistemaVentasJones.Client.Pages.Marcas.ListaBajasMarcas.TypeInference.CreateMudTable_0(__builder, 14, 15, 
#nullable restore
#line 38 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaBajasMarcas.razor"
                      Marca

#line default
#line hidden
#nullable disable
            , 16, 
#nullable restore
#line 38 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaBajasMarcas.razor"
                                     dense

#line default
#line hidden
#nullable disable
            , 17, 
#nullable restore
#line 38 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaBajasMarcas.razor"
                                                    hover

#line default
#line hidden
#nullable disable
            , 18, 
#nullable restore
#line 38 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaBajasMarcas.razor"
                                                                      bordered

#line default
#line hidden
#nullable disable
            , 19, 
#nullable restore
#line 38 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaBajasMarcas.razor"
                                                                                          striped

#line default
#line hidden
#nullable disable
            , 20, 
#nullable restore
#line 38 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaBajasMarcas.razor"
                                                                                                           new Func<Marcas,bool>(FilterFunc1)

#line default
#line hidden
#nullable disable
            , 21, 
#nullable restore
#line 39 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaBajasMarcas.razor"
                                  selectedItem1

#line default
#line hidden
#nullable disable
            , 22, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedItem1 = __value, selectedItem1)), 23, (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudText>(24);
                __builder2.AddAttribute(25, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 41 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaBajasMarcas.razor"
                           Typo.h6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(27, "Marcas dadas de baja");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\n            ");
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
                __builder2.AddMarkupContent(34, "\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(35);
                __builder2.AddAttribute(36, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(37, "Descripción");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(39);
                __builder2.AddAttribute(40, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(41, "Fecha registro");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(42, "\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(43);
                __builder2.AddAttribute(44, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(45, "Acciones");
                }
                ));
                __builder2.CloseComponent();
            }
            , 46, (context) => (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudTd>(47);
                __builder2.AddAttribute(48, "DataLabel", "Nombre");
                __builder2.AddAttribute(49, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 52 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaBajasMarcas.razor"
__builder3.AddContent(50, context.Nombre);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(52);
                __builder2.AddAttribute(53, "DataLabel", "Descripción");
                __builder2.AddAttribute(54, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 53 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaBajasMarcas.razor"
__builder3.AddContent(55, context.Descripcion);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(56, "\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(57);
                __builder2.AddAttribute(58, "DataLabel", "Fecha");
                __builder2.AddAttribute(59, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 54 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaBajasMarcas.razor"
__builder3.AddContent(60, context.Fecha);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(61, "\n            ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(62);
                __builder2.AddAttribute(63, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<global::MudBlazor.MudFab>(64);
                    __builder3.AddAttribute(65, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 56 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaBajasMarcas.razor"
                               Color.Error

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(66, "StartIcon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 56 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaBajasMarcas.razor"
                                                        Icons.Material.Filled.Edit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(67, "Size", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Size>(
#nullable restore
#line 56 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaBajasMarcas.razor"
                                                                                          Size.Small

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(68, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaBajasMarcas.razor"
                                    () => NavigationManager.NavigateTo($"/editar-marcas/{context.Id}")

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            , 69, (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudTablePager>(70);
                __builder2.CloseComponent();
            }
            );
#nullable restore
#line 65 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaBajasMarcas.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Marcas\ListaBajasMarcas.razor"
       
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
        var httpResponse = await Http.GetAsync($"api/marcas/bajas");
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

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.SistemaVentasJones.Client.Pages.Marcas.ListaBajasMarcas
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTable_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::System.Func<T, global::System.Boolean> __arg5, int __seq6, T __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg7, int __seq8, global::Microsoft.AspNetCore.Components.RenderFragment __arg8, int __seq9, global::Microsoft.AspNetCore.Components.RenderFragment __arg9, int __seq10, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg10, int __seq11, global::Microsoft.AspNetCore.Components.RenderFragment __arg11)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Dense", __arg1);
        __builder.AddAttribute(__seq2, "Hover", __arg2);
        __builder.AddAttribute(__seq3, "Bordered", __arg3);
        __builder.AddAttribute(__seq4, "Striped", __arg4);
        __builder.AddAttribute(__seq5, "Filter", __arg5);
        __builder.AddAttribute(__seq6, "SelectedItem", __arg6);
        __builder.AddAttribute(__seq7, "SelectedItemChanged", __arg7);
        __builder.AddAttribute(__seq8, "ToolBarContent", __arg8);
        __builder.AddAttribute(__seq9, "HeaderContent", __arg9);
        __builder.AddAttribute(__seq10, "RowTemplate", __arg10);
        __builder.AddAttribute(__seq11, "PagerContent", __arg11);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
