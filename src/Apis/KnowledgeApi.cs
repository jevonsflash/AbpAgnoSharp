using Volo.Abp.AgnoSharp.Attributes;
using WebApiClientCore;
using WebApiClientCore.Attributes;
using WebApiClientCore.Parameters;

namespace Volo.Abp.AgnoSharp.Apis
{
    /// <summary>
    /// Knowledge API
    /// </summary>
    [LoggingFilter, AgnoAuth]
    public interface IKnowledgeApi
    {
        /// <summary>
        /// List Content
        /// </summary>
        [HttpGet("/knowledge/content")]
        public ITask<HttpResponseMessage> GetContent(
            [PathQuery] string? db_id = null,
            [PathQuery] int? page = null,
            [PathQuery] int? limit = null
        );

        /// <summary>
        /// Create Content
        /// </summary>
        [HttpPost("/knowledge/content")]
        public ITask<HttpResponseMessage> PostContent(
            [JsonContent] object requestBody
        );

        /// <summary>
        /// Get Content by ID
        /// </summary>
        [HttpGet("/knowledge/content/{content_id}")]
        public ITask<HttpResponseMessage> GetContentById(
            string content_id,
            [PathQuery] string? db_id = null
        );

        /// <summary>
        /// Update Content
        /// </summary>
        [HttpPut("/knowledge/content/{content_id}")]
        public ITask<HttpResponseMessage> PutContent(
            string content_id,
            [JsonContent] object requestBody
        );

        /// <summary>
        /// Delete Content
        /// </summary>
        [HttpDelete("/knowledge/content/{content_id}")]
        public ITask<HttpResponseMessage> DeleteContent(
            string content_id,
            [PathQuery] string? db_id = null
        );

        /// <summary>
        /// Get Content Status
        /// </summary>
        [HttpGet("/knowledge/content/{content_id}/status")]
        public ITask<HttpResponseMessage> GetContentStatus(
            string content_id,
            [PathQuery] string? db_id = null
        );

        /// <summary>
        /// Search Knowledge
        /// </summary>
        [HttpPost("/knowledge/search")]
        public ITask<HttpResponseMessage> PostKnowledgeSearch(
            [JsonContent] object requestBody
        );

        /// <summary>
        /// Get Knowledge Config
        /// </summary>
        [HttpGet("/knowledge/config")]
        public ITask<HttpResponseMessage> GetKnowledgeConfig(
            [PathQuery] string? db_id = null
        );
    }
}

