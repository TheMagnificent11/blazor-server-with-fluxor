using Fluxor;

namespace BlazorServerWithFluxor.State;

public class WeatherStateFeature : Feature<WeatherState>
{
    public override string GetName() => nameof(WeatherState);

    protected override WeatherState GetInitialState() => new();
}
