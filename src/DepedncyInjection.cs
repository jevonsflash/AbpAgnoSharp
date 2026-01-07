using System.Text.Json;
using System.Text.Json.Serialization;
using Volo.Abp.AgnoSharp;
using Volo.Abp.AgnoSharp.Apis;
using Microsoft.Extensions.Options;

namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddAgnoSharp(
        this IServiceCollection services
    )
    {
        services.ConfigureAgnoApi<IAgentApi>()
            .ConfigureAgnoApi<ITeamApi>()
            .ConfigureAgnoApi<IWorkflowApi>()
            .ConfigureAgnoApi<IKnowledgeApi>()
            .ConfigureAgnoApi<ITracesApi>()
            .ConfigureAgnoApi<IMemoryApi>()
            .ConfigureAgnoApi<IDatabaseApi>();

        return services;
    }

    private static IServiceCollection ConfigureAgnoApi<TApi>(this IServiceCollection services)
        where TApi : class
    {
        return services
            .AddHttpApi<TApi>(
                (apiOptions, sp) =>
                {
                    var agnoOptions = sp.GetRequiredService<IOptions<AbpAgnoSharpOptions>>().Value;
                    apiOptions.HttpHost = new Uri(agnoOptions.BaseUrl);

                    // 序列化配置
                    apiOptions.JsonDeserializeOptions.PropertyNamingPolicy =
                        JsonNamingPolicy.SnakeCaseLower;
                    apiOptions.JsonDeserializeOptions.DefaultIgnoreCondition =
                        JsonIgnoreCondition.WhenWritingNull;
                    apiOptions.JsonDeserializeOptions.Converters.Add(
                        new JsonStringEnumConverter(JsonNamingPolicy.SnakeCaseLower)
                    );

                    apiOptions.JsonSerializeOptions.PropertyNamingPolicy =
                        JsonNamingPolicy.SnakeCaseLower;
                    apiOptions.JsonSerializeOptions.DefaultIgnoreCondition =
                        JsonIgnoreCondition.WhenWritingNull;
                    apiOptions.JsonSerializeOptions.Converters.Add(
                        new JsonStringEnumConverter(JsonNamingPolicy.SnakeCaseLower)
                    );

                    apiOptions.KeyValueSerializeOptions.IgnoreNullValues = true;
                    apiOptions.KeyValueSerializeOptions.PropertyNamingPolicy =
                        JsonNamingPolicy.SnakeCaseLower;
                    apiOptions.KeyValueSerializeOptions.Converters.Add(
                        new JsonStringEnumConverter(JsonNamingPolicy.SnakeCaseLower)
                    );

                    apiOptions.UseLogging = agnoOptions.EnableLogging;
                }
            )
            .Services;
    }
}

