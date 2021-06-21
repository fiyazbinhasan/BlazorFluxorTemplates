using BlazorFluxorWasm.Data;

namespace BlazorFluxorWasm.Store.FetchDataUseCase
{
    public record FetchDataState(bool IsLoading, WeatherForecast[] Forecasts, string Error);
}
