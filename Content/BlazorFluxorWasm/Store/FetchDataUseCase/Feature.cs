using BlazorFluxorWasm.Data;
using Fluxor;

namespace BlazorFluxorWasm.Store.FetchDataUseCase
{
    public class Feature : Feature<FetchDataState>
    {
        public override string GetName() => "FetchData";
        protected override FetchDataState GetInitialState() => new(false, Array.Empty<WeatherForecast>(), string.Empty);
    }
}
