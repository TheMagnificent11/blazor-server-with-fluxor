using BlazorServerWithFluxor.State.Actions;

namespace BlazorServerWithFluxor.Pages;

public partial class Index
{
    protected override void OnInitialized()
    {
        base.OnInitialized();
        this.Dispatcher.Dispatch(new WeatherForecastAction());
    }
}
