using Fluxor;

namespace BlazorFluxorWasm.Store.CounterUseCase
{
    public class Feature : Feature<CounterState>
    {
        public override string GetName() => "Counter";
        protected override CounterState GetInitialState() => new(0);
    }
}
