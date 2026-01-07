using Volo.Abp.AgnoSharp.Attributes;
using WebApiClientCore;
using WebApiClientCore.Attributes;
using WebApiClientCore.Parameters;

namespace Volo.Abp.AgnoSharp.Apis
{
    /// <summary>
    /// Workflow API
    /// </summary>
    [LoggingFilter, AgnoAuth]
    public interface IWorkflowApi
    {
        /// <summary>
        /// List Workflows
        /// </summary>
        [HttpGet("/workflows")]
        public ITask<HttpResponseMessage> GetWorkflows(
            [PathQuery] string? db_id = null,
            [PathQuery] int? page = null,
            [PathQuery] int? limit = null
        );

        /// <summary>
        /// Create Workflow
        /// </summary>
        [HttpPost("/workflows")]
        public ITask<HttpResponseMessage> PostWorkflows(
            [JsonContent] object requestBody
        );

        /// <summary>
        /// Get Workflow by ID
        /// </summary>
        [HttpGet("/workflows/{workflow_id}")]
        public ITask<HttpResponseMessage> GetWorkflowById(
            string workflow_id,
            [PathQuery] string? db_id = null
        );

        /// <summary>
        /// Update Workflow
        /// </summary>
        [HttpPut("/workflows/{workflow_id}")]
        public ITask<HttpResponseMessage> PutWorkflow(
            string workflow_id,
            [JsonContent] object requestBody
        );

        /// <summary>
        /// Delete Workflow
        /// </summary>
        [HttpDelete("/workflows/{workflow_id}")]
        public ITask<HttpResponseMessage> DeleteWorkflow(
            string workflow_id,
            [PathQuery] string? db_id = null
        );

        /// <summary>
        /// Run Workflow
        /// </summary>
        [HttpPost("/workflows/{workflow_id}/run")]
        public ITask<HttpResponseMessage> PostWorkflowRun(
            string workflow_id,
            [JsonContent] object requestBody
        );

        /// <summary>
        /// Get Workflow Run
        /// </summary>
        [HttpGet("/workflows/{workflow_id}/run/{run_id}")]
        public ITask<HttpResponseMessage> GetWorkflowRun(
            string workflow_id,
            string run_id,
            [PathQuery] string? db_id = null
        );

        /// <summary>
        /// Stop Workflow Run
        /// </summary>
        [HttpPost("/workflows/{workflow_id}/run/{run_id}/stop")]
        public ITask<HttpResponseMessage> PostWorkflowRunStop(
            string workflow_id,
            string run_id
        );

        /// <summary>
        /// List Workflow Sessions
        /// </summary>
        [HttpGet("/workflows/{workflow_id}/sessions")]
        public ITask<HttpResponseMessage> GetWorkflowSessions(
            string workflow_id,
            [PathQuery] string? user_id = null,
            [PathQuery] string? db_id = null,
            [PathQuery] int? page = null,
            [PathQuery] int? limit = null
        );

        /// <summary>
        /// Create Workflow Session
        /// </summary>
        [HttpPost("/workflows/{workflow_id}/sessions")]
        public ITask<HttpResponseMessage> PostWorkflowSessions(
            string workflow_id,
            [JsonContent] object requestBody
        );

        /// <summary>
        /// Get Workflow Session
        /// </summary>
        [HttpGet("/workflows/{workflow_id}/sessions/{session_id}")]
        public ITask<HttpResponseMessage> GetWorkflowSession(
            string workflow_id,
            string session_id,
            [PathQuery] string? db_id = null
        );

        /// <summary>
        /// Update Workflow Session
        /// </summary>
        [HttpPut("/workflows/{workflow_id}/sessions/{session_id}")]
        public ITask<HttpResponseMessage> PutWorkflowSession(
            string workflow_id,
            string session_id,
            [JsonContent] object requestBody
        );

        /// <summary>
        /// Delete Workflow Session
        /// </summary>
        [HttpDelete("/workflows/{workflow_id}/sessions/{session_id}")]
        public ITask<HttpResponseMessage> DeleteWorkflowSession(
            string workflow_id,
            string session_id,
            [PathQuery] string? db_id = null
        );
    }
}

