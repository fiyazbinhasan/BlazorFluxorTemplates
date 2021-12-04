using BlazorFluxorWasm.Data;
using Fluxor;

namespace BlazorFluxorWasm.Store.FetchDataUseCase
{
    public class Reducers
    {
        [ReducerMethod]
        public static FetchDataState ReduceFetchDataAction(FetchDataState state, FetchDataAction action) =>
            new(true, Array.Empty<WeatherForecast>(), string.Empty);

        [ReducerMethod]
        public static FetchDataState ReduceFetchDataSuccessAction(FetchDataState state, FetchDataSuccessAction action) =>
            new(false, action.Forecasts, string.Empty);

        [ReducerMethod]
        public static FetchDataState ReduceFetchDataErrorAction(FetchDataState state, FetchDataErrorAction action) =>
            new(false, Array.Empty<WeatherForecast>(), action.Error);
    }
}
