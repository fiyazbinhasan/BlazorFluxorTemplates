using Fluxor;

namespace BlazorFluxorWasm.Store.CounterUseCase
{
    public class Reducers
    {
        [ReducerMethod]
        public static CounterState ReduceIncrementCounterAction(CounterState state, IncrementCounterAction action) =>
               state with { Count = state.Count + 1 };
    }
}
