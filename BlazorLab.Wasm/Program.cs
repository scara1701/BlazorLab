using BlazorLab.MyLib.Services;
using BlazorLab.MyLib.ViewModels;
using BlazorLab.Wasm.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorLab.Wasm
{
    public class Program
    {
        public IServiceProvider Services { get; }
        public static Program Current => (Program)Program.Current;
        public NavigationViewModel NavVM => Services.GetService<NavigationViewModel>();

        public static async Task Main(string[] args)
        {

            GetNumberService getNumberService = new GetNumberService(100);

            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped<IGetNumberService>(x => getNumberService);
            builder.Services.AddScoped<IDialogService, DialogService>();
            builder.Services.AddScoped<INavigationService, NavigationService>();
            builder.Services.AddScoped<INavigationViewModel,NavigationViewModel>();
            builder.Services.AddTransient<IMainViewModel, MainViewModel>();
            builder.Services.AddTransient<IDetailsViewModel, DetailsViewModel>();

            await builder.Build().RunAsync();
        }
    }
}
