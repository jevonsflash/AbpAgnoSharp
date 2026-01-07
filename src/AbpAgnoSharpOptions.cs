namespace Volo.Abp.AgnoSharp
{
    public class AbpAgnoSharpOptions
    {
        public string ApiKey { get; set; } = string.Empty;

        public bool EnableLogging { get; set; } = false;

        public string BaseUrl { get; set; } = "http://localhost:7777";
    }
}

