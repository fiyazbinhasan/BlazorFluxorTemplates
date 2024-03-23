using Fluxor;

namespace BlazorFluxorServer.Store.CounterUseCase
{
    [FeatureState]
    public record CounterState
    {
        public int Count { get; init; }

        private CounterState() { }

        public CounterState(int count)
        {
            Count = count;
        }
    }
}
