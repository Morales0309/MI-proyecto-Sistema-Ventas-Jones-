#pragma checksum "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Shared\DashboardPowerBi.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a17fdacf70a3f61703cdde42bef9bbb3e7f8691a"
// <auto-generated/>
#pragma warning disable 1591
namespace SistemaVentasJones.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\_Imports.razor"
using SistemaVentasJones.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\_Imports.razor"
using SistemaVentasJones.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\_Imports.razor"
using SistemaVentasJones.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\_Imports.razor"
using SistemaVentasJones.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\_Imports.razor"
using MudBlazor.ThemeManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\_Imports.razor"
using MudBlazor.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\_Imports.razor"
using CsvHelper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\_Imports.razor"
using OfficeOpenXml;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\_Imports.razor"
using OfficeOpenXml.Style;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    public partial class DashboardPowerBi : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<iframe title=\"PanelFinal\" src=\"https://app.powerbi.com/view?r=eyJrIjoiMzJkNGNlYWUtNjAzNS00OWYyLTgyN2MtZjYwOTA1ZTg1N2E5IiwidCI6ImU0NzY0NmZlLWRhMjctNDUxOC04NDM2LTVmOGIxNThiYTEyNyIsImMiOjR9\" frameborder=\"0\" allowtransparency=\"true\"></iframe>\r\n\r\n\r\n");
            __builder.AddMarkupContent(1, "<style>\r\n    iframe {\r\n        width: 100%;\r\n        height: 100vh;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
