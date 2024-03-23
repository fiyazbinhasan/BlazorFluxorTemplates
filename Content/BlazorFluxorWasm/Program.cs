using BlazorFluxorWasm;
using Fluxor;
using Fluxor.Blazor.Web.ReduxDevTools;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddFluxor(opt =>
{
    opt.ScanAssemblies(typeof(Program).Assembly);
    opt.UseRouting();
#if DEBUG
    opt.UseReduxDevTools();
#endif
});

await builder.Build().RunAsync();
