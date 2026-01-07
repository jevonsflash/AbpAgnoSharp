using Volo.Abp.AgnoSharp.Attributes;
using WebApiClientCore;
using WebApiClientCore.Attributes;
using WebApiClientCore.Parameters;

namespace Volo.Abp.AgnoSharp.Apis
{
    /// <summary>
    /// Team API
    /// </summary>
    [LoggingFilter, AgnoAuth]
    public interface ITeamApi
    {
        /// <summary>
        /// List Teams
        /// </summary>
        [HttpGet("/teams")]
        public ITask<HttpResponseMessage> GetTeams(
            [PathQuery] string? db_id = null,
            [PathQuery] int? page = null,
            [PathQuery] int? limit = null
        );

        /// <summary>
        /// Create Team
        /// </summary>
        [HttpPost("/teams")]
        public ITask<HttpResponseMessage> PostTeams(
            [JsonContent] object requestBody
        );

        /// <summary>
        /// Get Team by ID
        /// </summary>
        [HttpGet("/teams/{team_id}")]
        public ITask<HttpResponseMessage> GetTeamById(
            string team_id,
            [PathQuery] string? db_id = null
        );

        /// <summary>
        /// Update Team
        /// </summary>
        [HttpPut("/teams/{team_id}")]
        public ITask<HttpResponseMessage> PutTeam(
            string team_id,
            [JsonContent] object requestBody
        );

        /// <summary>
        /// Delete Team
        /// </summary>
        [HttpDelete("/teams/{team_id}")]
        public ITask<HttpResponseMessage> DeleteTeam(
            string team_id,
            [PathQuery] string? db_id = null
        );

        /// <summary>
        /// Run Team
        /// </summary>
        [HttpPost("/teams/{team_id}/run")]
        public ITask<HttpResponseMessage> PostTeamRun(
            string team_id,
            [JsonContent] object requestBody
        );

        /// <summary>
        /// Get Team Run
        /// </summary>
        [HttpGet("/teams/{team_id}/run/{run_id}")]
        public ITask<HttpResponseMessage> GetTeamRun(
            string team_id,
            string run_id,
            [PathQuery] string? db_id = null
        );

        /// <summary>
        /// Stop Team Run
        /// </summary>
        [HttpPost("/teams/{team_id}/run/{run_id}/stop")]
        public ITask<HttpResponseMessage> PostTeamRunStop(
            string team_id,
            string run_id
        );

        /// <summary>
        /// List Team Sessions
        /// </summary>
        [HttpGet("/teams/{team_id}/sessions")]
        public ITask<HttpResponseMessage> GetTeamSessions(
            string team_id,
            [PathQuery] string? user_id = null,
            [PathQuery] string? db_id = null,
            [PathQuery] int? page = null,
            [PathQuery] int? limit = null
        );

        /// <summary>
        /// Create Team Session
        /// </summary>
        [HttpPost("/teams/{team_id}/sessions")]
        public ITask<HttpResponseMessage> PostTeamSessions(
            string team_id,
            [JsonContent] object requestBody
        );

        /// <summary>
        /// Get Team Session
        /// </summary>
        [HttpGet("/teams/{team_id}/sessions/{session_id}")]
        public ITask<HttpResponseMessage> GetTeamSession(
            string team_id,
            string session_id,
            [PathQuery] string? db_id = null
        );

        /// <summary>
        /// Update Team Session
        /// </summary>
        [HttpPut("/teams/{team_id}/sessions/{session_id}")]
        public ITask<HttpResponseMessage> PutTeamSession(
            string team_id,
            string session_id,
            [JsonContent] object requestBody
        );

        /// <summary>
        /// Delete Team Session
        /// </summary>
        [HttpDelete("/teams/{team_id}/sessions/{session_id}")]
        public ITask<HttpResponseMessage> DeleteTeamSession(
            string team_id,
            string session_id,
            [PathQuery] string? db_id = null
        );
    }
}

