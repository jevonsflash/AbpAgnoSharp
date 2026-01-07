using System.Net.Http.Headers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace Volo.Abp.AgnoSharp.Attributes;

public class AgnoAuthAttribute : ApiFilterAttribute
{
    protected AbpAgnoSharpOptions? Options;
    public override Task OnRequestAsync(ApiRequestContext context)
    {
        var options =
            context.HttpContext.ServiceProvider.GetRequiredService<IOptionsMonitor<AbpAgnoSharpOptions>>();
        Options = options.CurrentValue;
        var tokenType = "Bearer";
        var token = Options.ApiKey;
        context.HttpContext.RequestMessage.Headers.Authorization = new AuthenticationHeaderValue(
            tokenType,
            token
        );
        return Task.CompletedTask;
    }

    public override Task OnResponseAsync(ApiResponseContext context)
    {
        return Task.CompletedTask;
    }
}

