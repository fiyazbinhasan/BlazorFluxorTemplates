using BlazorFluxorWasm.Store.FetchDataUseCase;
using Fluxor;

namespace BlazorFluxorServer.Store.FetchDataUseCase
{
    public class Reducers
    {
        [ReducerMethod(typeof(FetchDataAction))]
        public static FetchDataState ReduceFetchDataAction(FetchDataState state) =>
            state with { IsLoading = true, Forecasts = null, Error = null };


        [ReducerMethod]
        public static FetchDataState ReduceFetchDataSuccessAction(FetchDataState state, FetchDataSuccessAction action) =>
            state with { IsLoading = false, Forecasts = action.Forecasts, Error = null };


        [ReducerMethod]
        public static FetchDataState ReduceFetchDataErrorAction(FetchDataState state, FetchDataErrorAction action) =>
            state with { IsLoading = false, Forecasts = null, Error = action.Error };
    }
}
