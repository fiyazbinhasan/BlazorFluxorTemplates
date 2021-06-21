using BlazorFluxorWasm.Data;

namespace BlazorFluxorWasm.Store.FetchDataUseCase
{
    public record FetchDataAction();
    public record FetchDataSuccessAction(WeatherForecast[] Forecasts);
    public record FetchDataErrorAction(string Error);
}