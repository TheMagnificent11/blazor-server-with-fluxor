using BlazorServerWithFluxor.Application;
using BlazorServerWithFluxor.State.Actions;
using Fluxor;

namespace BlazorServerWithFluxor.State;

#pragma warning disable IDE0060 // Remove unused parameter
public static class WeatherStateReducer
{
    [ReducerMethod]

    public static WeatherState GetForecast(WeatherState state, WeatherForecastAction action)
    {
        return state with { IsLoading = true, Data = Array.Empty<WeatherForecast>() };
    }

    [ReducerMethod]
    public static WeatherState GetForecastSuccess(WeatherState state, WeatherForecastSuccessAction action)
    {
        return state with { IsLoading = false, Data = action.Data };
    }
}
#pragma warning restore IDE0060 // Remove unused parameter
