// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SistemaVentasJones.Client.Pages.Clientes
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
#line 6 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Clientes\CrearCliente.razor"
           [Authorize(Roles = "admin, empleado")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/crear-cliente")]
    public partial class CrearCliente : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\Lenovo i5 12va Gen\Desktop\Jones\SistemaVentasJones\SistemaVentasJones\Client\Pages\Clientes\CrearCliente.razor"
       
    public Cliente cliente = new Cliente();

    async Task CrearClient()
    {
        var respuesta = await Http.PostAsJsonAsync("api/clientes", cliente);

        if (respuesta.IsSuccessStatusCode)
        {
            NavigationManager.NavigateTo("/lista-clientes");
            // await JS.InvokeVoidAsync("simple", "¡Éxito!", "Cliente creado", "success");
            Snackbar.Add("Agregada con éxito", Severity.Success, a =>
            a.VisibleStateDuration = 200);
        }
        else
        {
            // await JS.InvokeVoidAsync("simple", "Error",
            //$"DNI: {cliente.Cedula} ya registrado. ", "error");
            Snackbar.Add("Ha ocurrido un error", Severity.Error, a =>
            a.VisibleStateDuration = 200);
        }
    }

    void Volver()
    {
        NavigationManager.NavigateTo("/lista-clientes");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
