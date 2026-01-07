using Volo.Abp.AgnoSharp.Attributes;
using WebApiClientCore;
using WebApiClientCore.Attributes;
using WebApiClientCore.Parameters;

namespace Volo.Abp.AgnoSharp.Apis
{
    /// <summary>
    /// Traces API
    /// </summary>
    [LoggingFilter, AgnoAuth]
    public interface ITracesApi
    {
        /// <summary>
        /// List Traces
        /// </summary>
        [HttpGet("/traces")]
        public ITask<HttpResponseMessage> GetTraces(
            [PathQuery] string? run_id = null,
            [PathQuery] string? session_id = null,
            [PathQuery] string? user_id = null,
            [PathQuery] string? agent_id = null,
            [PathQuery] string? team_id = null,
            [PathQuery] string? workflow_id = null,
            [PathQuery] string? status = null,
            [PathQuery] string? start_time = null,
            [PathQuery] string? end_time = null,
            [PathQuery] int? page = null,
            [PathQuery] int? limit = null,
            [PathQuery] string? db_id = null
        );

        /// <summary>
        /// Get Trace by ID
        /// </summary>
        [HttpGet("/traces/{trace_id}")]
        public ITask<HttpResponseMessage> GetTraceById(
            string trace_id,
            [PathQuery] string? span_id = null,
            [PathQuery] string? run_id = null,
            [PathQuery] string? db_id = null
        );

        /// <summary>
        /// Get Trace Statistics by Session
        /// </summary>
        [HttpGet("/trace_session_stats")]
        public ITask<HttpResponseMessage> GetTraceSessionStats(
            [PathQuery] string? user_id = null,
            [PathQuery] string? agent_id = null,
            [PathQuery] string? team_id = null,
            [PathQuery] string? workflow_id = null,
            [PathQuery] string? start_time = null,
            [PathQuery] string? end_time = null,
            [PathQuery] int? page = null,
            [PathQuery] int? limit = null,
            [PathQuery] string? db_id = null
        );
    }
}

