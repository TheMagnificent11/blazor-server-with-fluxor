using BlazorServerWithFluxor.Application;

namespace BlazorServerWithFluxor.State;

public record WeatherState
{
    public bool IsLoading { get; set; }
    public WeatherForecast[] Data { get; set; } = Array.Empty<WeatherForecast>();
}
