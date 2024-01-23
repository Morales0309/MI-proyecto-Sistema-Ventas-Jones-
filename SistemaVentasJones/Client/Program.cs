using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MudBlazor.Services;
using SistemaVentasJones.Client;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasJones.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddHttpClient("SistemaVentasJones.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
                .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

            //builder.Services.AddHttpClient<HttpClientConToken>(
            //  cliente => cliente.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
            //  .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

            //builder.Services.AddHttpClient<HttpClientSinToken>(
            //  cliente => cliente.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));

            // Supply HttpClient instances that include access tokens when making requests to the server project
            builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("SistemaVentasJones.ServerAPI"));

            builder.Services.AddApiAuthorization();
            builder.Services.AddMudServices();


            await builder.Build().RunAsync();
        }
        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddOptions();
            services.AddApiAuthorization();

        }
    }
}
