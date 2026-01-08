using Volo.Abp.AgnoSharp.Attributes;
using WebApiClientCore;
using WebApiClientCore.Attributes;
using WebApiClientCore.Parameters;

namespace Volo.Abp.AgnoSharp.Apis
{
    /// <summary>
    /// Core API
    /// </summary>
    [LoggingFilter, AgnoAuth]
    public interface ICoreApi
    {
        /// <summary>
        /// Get Health
        /// </summary>
        [HttpGet("/health")]
        public ITask<HttpResponseMessage> GetStatus();

        /// <summary>
        /// Get Config
        /// </summary>
        [HttpGet("/config")]
        public ITask<HttpResponseMessage> GetConfig();


        /// <summary>
        /// Get Models
        /// </summary>
        [HttpGet("/models")]
        public ITask<HttpResponseMessage> GetModels();



    }
}

