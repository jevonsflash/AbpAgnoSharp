using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AgnoSharp;
using Volo.Abp.AgnoSharp.Apis;
using Volo.Abp.Modularity;

namespace Volo.Abp.AgnoSharp
{
    public class AbpAgnoSharpModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var configuration = context.Services.GetConfiguration();

            Configure<AbpAgnoSharpOptions>(container =>
            {
                container.ApiKey = configuration["AI:Agno:ApiKey"] ?? string.Empty;
                container.BaseUrl = configuration["AI:Agno:BaseUrl"] ?? "http://localhost:7777";
                container.EnableLogging = bool.Parse(configuration["AI:Agno:EnableLogging"] ?? "false");
            });
            context.Services.AddAgnoSharp();
        }
    }
}

