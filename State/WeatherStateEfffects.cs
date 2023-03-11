using BlazorServerWithFluxor.Application;
using BlazorServerWithFluxor.State.Actions;
using Fluxor;
using MediatR;

namespace BlazorServerWithFluxor.State;

public class WeatherStateEfffects
{
    private readonly IMediator mediator;

    public WeatherStateEfffects(IMediator mediator)
    {
        this.mediator = mediator;
    }

#pragma warning disable IDE0060 // Remove unused parameter
    [EffectMethod]
    public async Task QueryData(WeatherForecastAction action, IDispatcher dispatcher)
    {
        var result = await this.mediator.Send(new WeatherForecastQuery());

        dispatcher.Dispatch(new WeatherForecastSuccessAction(result));
    }
#pragma warning restore IDE0060 // Remove unused parameter
}
