using BlazorServerWithFluxor.Application;

namespace BlazorServerWithFluxor.State.Actions;

public record WeatherForecastSuccessAction
{
    public WeatherForecastSuccessAction(WeatherForecast[] data)
    {
        this.Data = data;
    }

    public WeatherForecast[] Data { get; }
}
