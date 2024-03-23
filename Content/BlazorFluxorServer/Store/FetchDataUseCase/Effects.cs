using BlazorFluxorServer.Data;
using Fluxor;

namespace BlazorFluxorServer.Store.FetchDataUseCase
{
    public class Effects
    {
        private readonly WeatherForecastService _weatherForecastService;

        public Effects(WeatherForecastService weatherForecastService)
        {
            _weatherForecastService = weatherForecastService;
        }

        [EffectMethod(typeof(FetchDataAction))]
        public async Task HandleAsync(IDispatcher dispatcher)
        {
            try
            {
                var forecasts = await _weatherForecastService.GetForecastAsync(DateTime.Now);
                dispatcher.Dispatch(new FetchDataSuccessAction(forecasts));
            }
            catch (Exception ex)
            {
                dispatcher.Dispatch(new FetchDataErrorAction(ex.Message));
            }
        }
    }
}
