// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SistemaVentasJones.Client.Pages.Articulos
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using SistemaVentasJones.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using SistemaVentasJones.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "c:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using SistemaVentasJones.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "c:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "c:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "c:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "c:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using SistemaVentasJones.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "c:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "c:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using MudBlazor.ThemeManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "c:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using MudBlazor.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "c:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using CsvHelper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "c:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using OfficeOpenXml;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "c:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using OfficeOpenXml.Style;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "c:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Articulos\ListaArticulo.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Articulos\ListaArticulo.razor"
           [Authorize(Roles = "admin, empleado")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/lista-articulos")]
    public partial class ListaArticulo : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 213 "c:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Articulos\ListaArticulo.razor"
       
    public List<Articulo> articulo { get; set; } //muestra todos los articulos
    public List<Categoria> ListaCategorias { get; set; } = new List<Categoria>();
    public List<Marcas> ListaMarcas { get; set; } = new List<Marcas>();
    public List<Tamanios> ListaTamanios { get; set; } = new List<Tamanios>();

    private decimal PrecioMaximo;

    private bool dense = false;
    private bool hover = true;
    private bool striped = true;
    private bool bordered = true;
    private string searchString1 = "";
    private Articulo selectedItem1 = null;
    private HashSet<Articulo> selectedItems = new HashSet<Articulo>();

    private string NombreArtFiltro = String.Empty; //filtros
    private string MarcaIdFiltro = String.Empty; //filtros
    private string TallaIdFiltro = String.Empty; //filtros
    private string TamanioIdFiltro = String.Empty; //filtros
    private string CategoriaIdFiltro = String.Empty; //filtros

    protected bool lista = true;
    protected bool card = false;

    protected override async Task OnInitializedAsync()
    {
        await CargarArticulos();
        await CargarMarcas();
        await CargarCategorias();
        await CargarTamanio();
    }



    async Task CargarArticulos()
    {
        var httpResponse = await Http.GetAsync($"api/articulos/filtrodos?nombre={NombreArtFiltro}&marcaId={MarcaIdFiltro}&tallaId={TallaIdFiltro}&categoriaId={CategoriaIdFiltro}");
        if (httpResponse.IsSuccessStatusCode)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            articulo = JsonSerializer.Deserialize<List<Articulo>>(responseString,
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
        else
        {
            Console.WriteLine("Error obteniendo los articulos filtrados");
        }
    }

    async Task CargarTamanio()
    {
        var httpResponse = await Http.GetAsync($"api/tamanios");
        if (httpResponse.IsSuccessStatusCode)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            ListaTamanios = JsonSerializer.Deserialize<List<Tamanios>>(responseString,
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
        else
        {
            Console.WriteLine("Error obteniendo el tamanio");
        }
    }

    async Task CargarCategorias()
    {
        var httpResponse = await Http.GetAsync($"api/cate");
        if (httpResponse.IsSuccessStatusCode)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            ListaCategorias = JsonSerializer.Deserialize<List<Categoria>>(responseString,
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
        else
        {
            Console.WriteLine("Error obteniendo la categoria");
        }
    }

    async Task CargarMarcas()
    {
        var httpResponse = await Http.GetAsync($"api/marcas");
        if (httpResponse.IsSuccessStatusCode)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            ListaMarcas = JsonSerializer.Deserialize<List<Marcas>>(responseString,
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
        else
        {
            Console.WriteLine("error");
        }
    }

    public string GetMarcaName(int marcaName)
    {
        // Obtener el nombre de la talla correspondiente utilizando el ID de talla de la lista.
        var marca = ListaMarcas.FirstOrDefault(x => x.Id == marcaName);
        return marca != null ? marca.Nombre : "N/A";
    }

    public string GetTamanioName(int tamanioName)
    {
        // Obtener el nombre de la talla correspondiente utilizando el ID de talla de la lista.
        var tamanio = ListaTamanios.FirstOrDefault(x => x.Id == tamanioName);
        return tamanio != null ? tamanio.Nombre : "N/A";
    }


    void CambiarVista()
    {
        lista = !lista;
        card = !card;
    }

    void MostrarStockBajo()
    {
        articulo = articulo.Where(x => x.StockActual < x.StockMinimo).ToList();
    }


    private string busqueda = "";

    void PorMarca()
    {
        articulo = articulo.Where(x => x.Marca.Nombre == busqueda).ToList();
    }

    async Task MostrarTodos()
    {
        await CargarArticulos();
    }

    void CrearArticulo()
    {
        NavigationManager.NavigateTo("crear-articulo");
    }

    private async Task Filtrar()
    {
        await CargarArticulos();
    }
    private async Task Filtrar2()
    {
        await CargarMarcas();
    }


    private async Task LimpiarTodo()
    {
        NombreArtFiltro = string.Empty;
        CategoriaIdFiltro = string.Empty;
        MarcaIdFiltro = string.Empty;
        TallaIdFiltro = string.Empty;
        TamanioIdFiltro = string.Empty;
        await CargarArticulos();
    }




    private async Task Limpiar()
    {
        NombreArtFiltro = string.Empty;
        await CargarArticulos();
    }
    private async Task LimpiarMarcas()
    {
        MarcaIdFiltro = string.Empty;
        await CargarArticulos();
    }
    private async Task LimpiarTalla()
    {
        TallaIdFiltro = string.Empty;
        await CargarArticulos();
    }
    private async Task LimpiarCategoria()
    {
        CategoriaIdFiltro = string.Empty;
        await CargarArticulos();
    }
    private async Task LimpiarTamanio()
    {
        TamanioIdFiltro = string.Empty;
        await CargarTamanio();
    }

    // esta es la funcion de filtrado de MudBlazor
    private bool FilterFunc1(Articulo element) => FilterFunc(element, searchString1);

    private bool FilterFunc(Articulo element, string searchString)
    {
        if (string.IsNullOrWhiteSpace(searchString))
            return true;
        if (element.Nombre.ToString().Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        if (element.Codigo.ToString().Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;


        return false;
    }



    private void ExportarExcel()
    {
        using (var package = new ExcelPackage())
        {
            var worksheet = package.Workbook.Worksheets.Add("Artículos");
            worksheet.Cells["A1"].Value = "ACJones.";
            var tableBody = worksheet.Cells["A3:E3"].LoadFromCollection(
                from f in articulo
                select new { f.Id, f.Nombre, f.Descripcion, f.Codigo, f.PrecioMayorista, f.PrecioUnitario, f.Estado }, true);
            using (ExcelRange r = worksheet.Cells["A1:H1"])
            {
                r.Merge = true; r.Style.Font.Bold = true;
                r.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.CenterContinuous;
                worksheet.DefaultColWidth = 60;
                r.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                r.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGreen);
            }
            worksheet.Cells["A2"].Value = $"Informe de artículos en existencia {DateTime.Now.ToLongTimeString()}";
            using (ExcelRange r = worksheet.Cells["A2:H2"])
            {
                r.Merge = true;
                r.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.CenterContinuous;
                worksheet.DefaultColWidth = 60;
                r.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                r.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightYellow);
            }


            var header = worksheet.Cells["A3:H3"];
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


            JS.GuardarComo($"Informe_Artículos_{DateTime.Now.ToShortDateString()}.xlsx", package.GetAsByteArray());
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService DialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
