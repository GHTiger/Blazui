using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Blazui.Component;
using Blazui.Component.Lang;
using Blazui.Markdown;

namespace Blazui.ClientRender
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddBaseAddressHttpClient();
            await builder.Services.AddBlazuiServicesAsync();
            builder.Services.AddMarkdown();
            await builder.Build().RunAsync();
        }
    }
}
