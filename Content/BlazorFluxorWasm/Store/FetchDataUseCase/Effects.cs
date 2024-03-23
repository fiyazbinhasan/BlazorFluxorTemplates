using BlazorFluxorWasm.Data;
using Fluxor;
using System.Net.Http.Json;

namespace BlazorFluxorWasm.Store.FetchDataUseCase
{
    public class Effects
    {
        private readonly HttpClient _httpClient;

        public Effects(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [EffectMethod(typeof(FetchDataAction))]
        public async Task HandleAsync(IDispatcher dispatcher)
        {
            try
            {
                var forecasts = await _httpClient.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
                dispatcher.Dispatch(new FetchDataSuccessAction(forecasts ??= []));
            }
            catch (Exception ex)
            {
                dispatcher.Dispatch(new FetchDataErrorAction(ex.Message));
            }
        }
    }
}
