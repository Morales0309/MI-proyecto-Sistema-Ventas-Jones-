#pragma checksum "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Shared\NavBar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f472ba846160e773765a4fee1b816812240ca13b"
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
    public partial class NavBar : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::MudBlazor.MudPaper>(0);
            __builder.AddAttribute(1, "Width", (object)("250px"));
            __builder.AddAttribute(2, "Class", (object)("d-inline-flex py-3"));
            __builder.AddAttribute(3, "Elevation", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 1 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Shared\NavBar.razor"
                                                              0

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudNavMenu>(5);
                __builder2.AddAttribute(6, "Rounded", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 4 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Shared\NavBar.razor"
                         true

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(7, "Margin", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Margin>(
#nullable restore
#line 4 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Shared\NavBar.razor"
                                       Margin.Dense

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(8, "Color", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 4 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Shared\NavBar.razor"
                                                            Color.Dark

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(9, "Class", (object)("mud-width-full custom-menu"));
                __builder2.AddAttribute(10, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<global::MudBlazor.MudText>(11);
                    __builder3.AddAttribute(12, "Typo", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 5 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Shared\NavBar.razor"
                       Typo.h6

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(13, "Class", (object)("px-4"));
                    __builder3.AddAttribute(14, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(15, "Sistema ventas Jones");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(16, "\r\n        ");
                    __builder3.OpenComponent<global::MudBlazor.MudDivider>(17);
                    __builder3.AddAttribute(18, "Class", (object)("my-2"));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(19, "\r\n\r\n        ");
                    __builder3.OpenComponent<global::MudBlazor.MudNavLink>(20);
                    __builder3.AddAttribute(21, "Href", (object)("/"));
                    __builder3.AddAttribute(22, "Icon", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 8 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Shared\NavBar.razor"
                                    Icons.Filled.Dashboard

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(23, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(24, "Reportes");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(25, "\r\n\r\n        ");
                    __builder3.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(26);
                    __builder3.AddAttribute(27, "Roles", (object)("admin"));
                    __builder3.AddAttribute(28, "Authorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder4) => {
                        __builder4.OpenComponent<global::MudBlazor.MudNavLink>(29);
                        __builder4.AddAttribute(30, "Href", (object)("/lista-compras"));
                        __builder4.AddAttribute(31, "Icon", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 12 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Shared\NavBar.razor"
                                                         Icons.Filled.ShoppingBag

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(32, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(33, "Compras");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(34, "\r\n\r\n        \r\n\r\n\r\n       ");
                    __builder3.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(35);
                    __builder3.AddAttribute(36, "Roles", (object)("admin"));
                    __builder3.AddAttribute(37, "Authorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder4) => {
                        __builder4.OpenComponent<global::MudBlazor.MudNavGroup>(38);
                        __builder4.AddAttribute(39, "Title", (object)("Catálogos"));
                        __builder4.AddAttribute(40, "Icon", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 22 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Shared\NavBar.razor"
                                                      Icons.Filled.AccountTree

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(41, "Expanded", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 22 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Shared\NavBar.razor"
                                                                                          true

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(42, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<global::MudBlazor.MudNavLink>(43);
                            __builder5.AddAttribute(44, "Href", (object)("/lista-marcas"));
                            __builder5.AddAttribute(45, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(46, "Marcas");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(47, "                   \r\n                    ");
                            __builder5.OpenComponent<global::MudBlazor.MudNavLink>(48);
                            __builder5.AddAttribute(49, "Href", (object)("/lista-tamanios"));
                            __builder5.AddAttribute(50, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(51, "Tamaños");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(52, "\r\n                    ");
                            __builder5.OpenComponent<global::MudBlazor.MudNavLink>(53);
                            __builder5.AddAttribute(54, "Href", (object)("/indexcategoria"));
                            __builder5.AddAttribute(55, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(56, "Categorías");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(57, "\r\n                    ");
                            __builder5.OpenComponent<global::MudBlazor.MudNavLink>(58);
                            __builder5.AddAttribute(59, "Color", (object)("Color.Primary"));
                            __builder5.AddAttribute(60, "Href", (object)("/lista-clientes"));
                            __builder5.AddAttribute(61, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(62, "Clientes");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(63, "\r\n                    ");
                            __builder5.OpenComponent<global::MudBlazor.MudNavLink>(64);
                            __builder5.AddAttribute(65, "Href", (object)("/lista-proveedores"));
                            __builder5.AddAttribute(66, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(67, "Proveedores");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(68, "\r\n\r\n        ");
                    __builder3.OpenComponent<global::MudBlazor.MudNavLink>(69);
                    __builder3.AddAttribute(70, "Href", (object)("/lista-articulos"));
                    __builder3.AddAttribute(71, "Icon", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 32 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Shared\NavBar.razor"
                                                   Icons.Filled.AddShoppingCart

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(72, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(73, "Administracion de productos");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(74, "\r\n                   \r\n            ");
                    __builder3.OpenComponent<global::MudBlazor.MudNavLink>(75);
                    __builder3.AddAttribute(76, "Href", (object)("/lista-ventas"));
                    __builder3.AddAttribute(77, "Icon", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 34 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Shared\NavBar.razor"
                                                    Icons.Filled.ShoppingBag

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(78, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(79, "Ventas");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(80, "\r\n        \r\n        ");
                    __builder3.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(81);
                    __builder3.AddAttribute(82, "Roles", (object)("admin"));
                    __builder3.AddAttribute(83, "Authorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder4) => {
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(84, "\r\n\r\n        ");
                    __builder3.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(85);
                    __builder3.AddAttribute(86, "Roles", (object)("admin"));
                    __builder3.AddAttribute(87, "Authorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder4) => {
                        __builder4.OpenComponent<global::MudBlazor.MudNavGroup>(88);
                        __builder4.AddAttribute(89, "Title", (object)("Ajustes"));
                        __builder4.AddAttribute(90, "Icon", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 45 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Shared\NavBar.razor"
                                                    Icons.Filled.Settings

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(91, "Expanded", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 45 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Shared\NavBar.razor"
                                                                                     true

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(92, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<global::MudBlazor.MudNavLink>(93);
                            __builder5.AddAttribute(94, "Href", (object)("/lista-usuarios"));
                            __builder5.AddAttribute(95, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(96, "Usuarios");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(97, "\r\n                    ");
                            __builder5.OpenComponent<global::MudBlazor.MudNavLink>(98);
                            __builder5.AddAttribute(99, "Href", (object)("/roles"));
                            __builder5.AddAttribute(100, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(101, "Asignar Roles");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(102, "\r\n                    ");
                            __builder5.OpenComponent<global::MudBlazor.MudNavLink>(103);
                            __builder5.AddAttribute(104, "Href", (object)("/lista-ajustes"));
                            __builder5.AddAttribute(105, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(106, "Configuracion");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(107, "\r\n\r\n");
            __builder.AddMarkupContent(108, @"<style>
    mud-appbar {
        width: 100%;
        display: flex;
        z-index: var(--mud-zindex-appbar);
        position: relative;
        box-sizing: border-box;
        flex-shrink: 0;
        flex-direction: column;
        color: var(--mud-palette-appbar-text);
        background-color: mediumpurple;
        transition: margin 225ms cubic-bezier(0,0,.2,1) 0ms,width 225ms cubic-bezier(0,0,.2,1) 0ms;
    }
    .custom-menu {
        background-color: #604ce4; /* Dark blue color, you can change this */
        color: #fff; /* Text color */
        /* Add any additional styles as needed */
    }

        .custom-menu a {
            color: #fff; /* Link color */
            transition: background-color 0.3s; /* Agregamos una transición suave al color de fondo */
        }

            .custom-menu a:hover {
                background-color: #FFFFFF; /* Darker blue on hover, you can change this */
            }

            .custom-menu a:active {
                background-color: #8B0000; /* Dark red on click, you can change this */
            }

    .mud-avatar-img {
        width: 60px;
        height: 60px;
    }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 94 "C:\Users\Lenovo i5 12va Gen\Desktop\Nueva carpeta\MI-proyecto-Sistema-Ventas-Jones-\SistemaVentasJones\Client\Shared\NavBar.razor"
       
    [Parameter]
    public bool SideBarOpen { get; set; }   

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
