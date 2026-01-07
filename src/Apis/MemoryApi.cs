using Volo.Abp.AgnoSharp.Attributes;
using WebApiClientCore;
using WebApiClientCore.Attributes;
using WebApiClientCore.Parameters;

namespace Volo.Abp.AgnoSharp.Apis
{
    /// <summary>
    /// Memory API
    /// </summary>
    [LoggingFilter, AgnoAuth]
    public interface IMemoryApi
    {
        /// <summary>
        /// List User Memories
        /// </summary>
        [HttpGet("/memory/user/{user_id}")]
        public ITask<HttpResponseMessage> GetUserMemories(
            string user_id,
            [PathQuery] string? agent_id = null,
            [PathQuery] string? team_id = null,
            [PathQuery] string? db_id = null,
            [PathQuery] int? page = null,
            [PathQuery] int? limit = null
        );

        /// <summary>
        /// Create User Memory
        /// </summary>
        [HttpPost("/memory/user/{user_id}")]
        public ITask<HttpResponseMessage> PostUserMemory(
            string user_id,
            [JsonContent] object requestBody
        );

        /// <summary>
        /// Get User Memory by ID
        /// </summary>
        [HttpGet("/memory/user/{user_id}/{memory_id}")]
        public ITask<HttpResponseMessage> GetUserMemoryById(
            string user_id,
            string memory_id,
            [PathQuery] string? db_id = null
        );

        /// <summary>
        /// Update User Memory
        /// </summary>
        [HttpPut("/memory/user/{user_id}/{memory_id}")]
        public ITask<HttpResponseMessage> PutUserMemory(
            string user_id,
            string memory_id,
            [JsonContent] object requestBody
        );

        /// <summary>
        /// Delete User Memory
        /// </summary>
        [HttpDelete("/memory/user/{user_id}/{memory_id}")]
        public ITask<HttpResponseMessage> DeleteUserMemory(
            string user_id,
            string memory_id,
            [PathQuery] string? db_id = null
        );

        /// <summary>
        /// Get User Stats
        /// </summary>
        [HttpGet("/memory/user/{user_id}/stats")]
        public ITask<HttpResponseMessage> GetUserStats(
            string user_id,
            [PathQuery] string? db_id = null
        );
    }
}

