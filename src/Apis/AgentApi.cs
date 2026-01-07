using Volo.Abp.AgnoSharp.Attributes;
using WebApiClientCore;
using WebApiClientCore.Attributes;
using WebApiClientCore.Parameters;

namespace Volo.Abp.AgnoSharp.Apis
{
    /// <summary>
    /// Agent API
    /// </summary>
    [LoggingFilter, AgnoAuth]
    public interface IAgentApi
    {
        /// <summary>
        /// List Agents
        /// </summary>
        [HttpGet("/agents")]
        public ITask<HttpResponseMessage> GetAgents(
            [PathQuery] string? db_id = null,
            [PathQuery] int? page = null,
            [PathQuery] int? limit = null
        );

        /// <summary>
        /// Create Agent
        /// </summary>
        [HttpPost("/agents")]
        public ITask<HttpResponseMessage> PostAgents(
            [FormContent] object requestBody
        );

        /// <summary>
        /// Get Agent by ID
        /// </summary>
        [HttpGet("/agents/{agent_id}")]
        public ITask<HttpResponseMessage> GetAgentById(
            string agent_id,
            [PathQuery] string? db_id = null
        );

        /// <summary>
        /// Update Agent
        /// </summary>
        [HttpPut("/agents/{agent_id}")]
        public ITask<HttpResponseMessage> PutAgent(
            string agent_id,
            [FormContent] object requestBody
        );

        /// <summary>
        /// Delete Agent
        /// </summary>
        [HttpDelete("/agents/{agent_id}")]
        public ITask<HttpResponseMessage> DeleteAgent(
            string agent_id,
            [PathQuery] string? db_id = null
        );

        /// <summary>
        /// Run Agent
        /// </summary>
        [HttpPost("/agents/{agent_id}/runs")]
        public ITask<HttpResponseMessage> PostAgentRun(
            string agent_id,
            [FormContent] object requestBody
        );

        /// <summary>
        /// Get Agent Run
        /// </summary>
        [HttpGet("/agents/{agent_id}/runs/{run_id}")]
        public ITask<HttpResponseMessage> GetAgentRun(
            string agent_id,
            string run_id,
            [PathQuery] string? db_id = null
        );

        /// <summary>
        /// Stop Agent Run
        /// </summary>
        [HttpPost("/agents/{agent_id}/runs/{run_id}/stop")]
        public ITask<HttpResponseMessage> PostAgentRunStop(
            string agent_id,
            string run_id
        );

        /// <summary>
        /// List Agent Sessions
        /// </summary>
        [HttpGet("/agents/{agent_id}/sessions")]
        public ITask<HttpResponseMessage> GetAgentSessions(
            string agent_id,
            [PathQuery] string? user_id = null,
            [PathQuery] string? db_id = null,
            [PathQuery] int? page = null,
            [PathQuery] int? limit = null
        );

        /// <summary>
        /// Create Agent Session
        /// </summary>
        [HttpPost("/agents/{agent_id}/sessions")]
        public ITask<HttpResponseMessage> PostAgentSessions(
            string agent_id,
            [FormContent] object requestBody
        );

        /// <summary>
        /// Get Agent Session
        /// </summary>
        [HttpGet("/agents/{agent_id}/sessions/{session_id}")]
        public ITask<HttpResponseMessage> GetAgentSession(
            string agent_id,
            string session_id,
            [PathQuery] string? db_id = null
        );

        /// <summary>
        /// Update Agent Session
        /// </summary>
        [HttpPut("/agents/{agent_id}/sessions/{session_id}")]
        public ITask<HttpResponseMessage> PutAgentSession(
            string agent_id,
            string session_id,
            [FormContent] object requestBody
        );

        /// <summary>
        /// Delete Agent Session
        /// </summary>
        [HttpDelete("/agents/{agent_id}/sessions/{session_id}")]
        public ITask<HttpResponseMessage> DeleteAgentSession(
            string agent_id,
            string session_id,
            [PathQuery] string? db_id = null
        );
    }
}

