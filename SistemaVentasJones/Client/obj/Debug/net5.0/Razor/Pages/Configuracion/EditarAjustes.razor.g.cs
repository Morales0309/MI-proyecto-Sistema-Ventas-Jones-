#pragma checksum "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Configuracion\EditarAjustes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95097a09dcd66dd839f04d68422a01c70e7e091a"
// <auto-generated/>
#pragma warning disable 1591
namespace SistemaVentasJones.Client.Pages.Configuracion
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
#line 5 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Configuracion\EditarAjustes.razor"
           [Authorize(Roles = "admin")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/editar-ajustes/{idAjustes:int}")]
    public partial class EditarAjustes : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Configuracion\EditarAjustes.razor"
                   Volver

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "class", "btn btn-sm btn-secondary");
            __builder.AddMarkupContent(3, "<i class=\"oi oi-arrow-circle-left\"></i> Volver al listado\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\n\n<hr>\n\n");
            __builder.AddMarkupContent(5, "<div class=\"d-flex justify-content-between mb-3\"><h3><b>Editar Configuracion</b></h3></div>\n");
            __builder.OpenComponent<global::SistemaVentasJones.Client.Pages.Configuracion.FormAjustes>(6);
            __builder.AddAttribute(7, "TextBotonSubmit", "Guardar cambios");
            __builder.AddAttribute(8, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 18 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Configuracion\EditarAjustes.razor"
                              EditarArtic

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "Configuracion", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::SistemaVentasJones.Shared.Configuracion>(
#nullable restore
#line 18 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Configuracion\EditarAjustes.razor"
                                                           Configuracion

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\ender\Music\SistemaVentasJones\SistemaVentasJones\Client\Pages\Configuracion\EditarAjustes.razor"
       
    Configuracion Configuracion = new Configuracion();
    [Parameter] public int idAjustes { get; set; }

    protected async override Task OnParametersSetAsync()
    {
        Configuracion = await Http.GetFromJsonAsync<Configuracion>($"/api/Configuracion/{idAjustes}");
    }

    void Volver()
    {
        NavigationManager.NavigateTo("/lista-ajustes");
    }

    async Task EditarArtic()
    {
        var confirmacion = await JS.InvokeAsync<bool>("confirmar", "Editar",
            $"¿Desea editar {Configuracion.NombreSistema}?", "question");
        if (confirmacion)
        {
            var respuesta = await Http.PutAsJsonAsync("/api/Configuracion", Configuracion);

            if (respuesta.IsSuccessStatusCode)
            {
                NavigationManager.NavigateTo("/lista-ajustes");
                await JS.InvokeVoidAsync("simple", "¡Éxito!", "Configuracion editada", "success");
            }
            else
            {
                await JS.InvokeVoidAsync("simple", "Error",
                    "No se pudo editar la Configuracion", "error");
            }
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
#pragma warning restore 1591
