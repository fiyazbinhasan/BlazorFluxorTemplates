using BlazorFluxorServer.Data;
using System.Collections.Generic;

namespace BlazorFluxorServer.Store.FetchDataUseCase
{
    public record FetchDataState(bool IsLoading, IEnumerable<WeatherForecast> Forecasts, string Error);
}
