using Fluxor;

namespace BlazorFluxorWasm.Store.FetchDataUseCase
{
    public class Feature : Feature<FetchDataState>
    {
        public override string GetName() => "FetchData";
        protected override FetchDataState GetInitialState() => new(false, null, null);
    }
}
