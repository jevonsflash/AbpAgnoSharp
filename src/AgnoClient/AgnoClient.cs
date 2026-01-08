using System.Net.Http;
using Volo.Abp.AgnoSharp.Apis;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Options;
using WebApiClientCore;

namespace Volo.Abp.AgnoSharp;

public abstract class AgnoClient<T> : ITransientDependency
    where T : notnull
{
    public string AgnoApiKey { get; set; }

    public T Api { get; set; }

    public AgnoClient(IOptionsMonitor<AbpAgnoSharpOptions> options, IServiceProvider serviceProvider)
    {
        Api = (T)serviceProvider.GetRequiredService<T>();
        AgnoApiKey = options.CurrentValue?.ApiKey ?? string.Empty;
    }
}

/// <summary>
/// Agno Agent Client
/// </summary>
public class AgentClient : AgnoClient<IAgentApi>, IAgentApi
{
    public AgentClient(IOptionsMonitor<AbpAgnoSharpOptions> options, IServiceProvider serviceProvider)
        : base(options, serviceProvider) { }

    public ITask<HttpResponseMessage> GetAgents(string? db_id = null, int? page = null, int? limit = null)
        => Api.GetAgents(db_id, page, limit);

    public ITask<HttpResponseMessage> PostAgents(object requestBody)
        => Api.PostAgents(requestBody);

    public ITask<HttpResponseMessage> GetAgentById(string agent_id, string? db_id = null)
        => Api.GetAgentById(agent_id, db_id);

    public ITask<HttpResponseMessage> PutAgent(string agent_id, object requestBody)
        => Api.PutAgent(agent_id, requestBody);

    public ITask<HttpResponseMessage> DeleteAgent(string agent_id, string? db_id = null)
        => Api.DeleteAgent(agent_id, db_id);

    public ITask<HttpResponseMessage> PostAgentRun(string agent_id, object requestBody)
        => Api.PostAgentRun(agent_id, requestBody);

    public ITask<HttpResponseMessage> GetAgentRun(string agent_id, string run_id, string? db_id = null)
        => Api.GetAgentRun(agent_id, run_id, db_id);

    public ITask<HttpResponseMessage> PostAgentRunStop(string agent_id, string run_id)
        => Api.PostAgentRunStop(agent_id, run_id);

    public ITask<HttpResponseMessage> GetAgentSessions(string agent_id, string? user_id = null, string? db_id = null, int? page = null, int? limit = null)
        => Api.GetAgentSessions(agent_id, user_id, db_id, page, limit);

    public ITask<HttpResponseMessage> PostAgentSessions(string agent_id, object requestBody)
        => Api.PostAgentSessions(agent_id, requestBody);

    public ITask<HttpResponseMessage> GetAgentSession(string agent_id, string session_id, string? db_id = null)
        => Api.GetAgentSession(agent_id, session_id, db_id);

    public ITask<HttpResponseMessage> PutAgentSession(string agent_id, string session_id, object requestBody)
        => Api.PutAgentSession(agent_id, session_id, requestBody);

    public ITask<HttpResponseMessage> DeleteAgentSession(string agent_id, string session_id, string? db_id = null)
        => Api.DeleteAgentSession(agent_id, session_id, db_id);
}

/// <summary>
/// Agno Team Client
/// </summary>
public class TeamClient : AgnoClient<ITeamApi>, ITeamApi
{
    public TeamClient(IOptionsMonitor<AbpAgnoSharpOptions> options, IServiceProvider serviceProvider)
        : base(options, serviceProvider) { }

    public ITask<HttpResponseMessage> GetTeams(string? db_id = null, int? page = null, int? limit = null)
        => Api.GetTeams(db_id, page, limit);

    public ITask<HttpResponseMessage> PostTeams(object requestBody)
        => Api.PostTeams(requestBody);

    public ITask<HttpResponseMessage> GetTeamById(string team_id, string? db_id = null)
        => Api.GetTeamById(team_id, db_id);

    public ITask<HttpResponseMessage> PutTeam(string team_id, object requestBody)
        => Api.PutTeam(team_id, requestBody);

    public ITask<HttpResponseMessage> DeleteTeam(string team_id, string? db_id = null)
        => Api.DeleteTeam(team_id, db_id);

    public ITask<HttpResponseMessage> PostTeamRun(string team_id, object requestBody)
        => Api.PostTeamRun(team_id, requestBody);

    public ITask<HttpResponseMessage> GetTeamRun(string team_id, string run_id, string? db_id = null)
        => Api.GetTeamRun(team_id, run_id, db_id);

    public ITask<HttpResponseMessage> PostTeamRunStop(string team_id, string run_id)
        => Api.PostTeamRunStop(team_id, run_id);

    public ITask<HttpResponseMessage> GetTeamSessions(string team_id, string? user_id = null, string? db_id = null, int? page = null, int? limit = null)
        => Api.GetTeamSessions(team_id, user_id, db_id, page, limit);

    public ITask<HttpResponseMessage> PostTeamSessions(string team_id, object requestBody)
        => Api.PostTeamSessions(team_id, requestBody);

    public ITask<HttpResponseMessage> GetTeamSession(string team_id, string session_id, string? db_id = null)
        => Api.GetTeamSession(team_id, session_id, db_id);

    public ITask<HttpResponseMessage> PutTeamSession(string team_id, string session_id, object requestBody)
        => Api.PutTeamSession(team_id, session_id, requestBody);

    public ITask<HttpResponseMessage> DeleteTeamSession(string team_id, string session_id, string? db_id = null)
        => Api.DeleteTeamSession(team_id, session_id, db_id);
}

/// <summary>
/// Agno Workflow Client
/// </summary>
public class WorkflowClient : AgnoClient<IWorkflowApi>, IWorkflowApi
{
    public WorkflowClient(IOptionsMonitor<AbpAgnoSharpOptions> options, IServiceProvider serviceProvider)
        : base(options, serviceProvider) { }

    public ITask<HttpResponseMessage> GetWorkflows(string? db_id = null, int? page = null, int? limit = null)
        => Api.GetWorkflows(db_id, page, limit);

    public ITask<HttpResponseMessage> PostWorkflows(object requestBody)
        => Api.PostWorkflows(requestBody);

    public ITask<HttpResponseMessage> GetWorkflowById(string workflow_id, string? db_id = null)
        => Api.GetWorkflowById(workflow_id, db_id);

    public ITask<HttpResponseMessage> PutWorkflow(string workflow_id, object requestBody)
        => Api.PutWorkflow(workflow_id, requestBody);

    public ITask<HttpResponseMessage> DeleteWorkflow(string workflow_id, string? db_id = null)
        => Api.DeleteWorkflow(workflow_id, db_id);

    public ITask<HttpResponseMessage> PostWorkflowRun(string workflow_id, object requestBody)
        => Api.PostWorkflowRun(workflow_id, requestBody);

    public ITask<HttpResponseMessage> GetWorkflowRun(string workflow_id, string run_id, string? db_id = null)
        => Api.GetWorkflowRun(workflow_id, run_id, db_id);

    public ITask<HttpResponseMessage> PostWorkflowRunStop(string workflow_id, string run_id)
        => Api.PostWorkflowRunStop(workflow_id, run_id);

    public ITask<HttpResponseMessage> GetWorkflowSessions(string workflow_id, string? user_id = null, string? db_id = null, int? page = null, int? limit = null)
        => Api.GetWorkflowSessions(workflow_id, user_id, db_id, page, limit);

    public ITask<HttpResponseMessage> PostWorkflowSessions(string workflow_id, object requestBody)
        => Api.PostWorkflowSessions(workflow_id, requestBody);

    public ITask<HttpResponseMessage> GetWorkflowSession(string workflow_id, string session_id, string? db_id = null)
        => Api.GetWorkflowSession(workflow_id, session_id, db_id);

    public ITask<HttpResponseMessage> PutWorkflowSession(string workflow_id, string session_id, object requestBody)
        => Api.PutWorkflowSession(workflow_id, session_id, requestBody);

    public ITask<HttpResponseMessage> DeleteWorkflowSession(string workflow_id, string session_id, string? db_id = null)
        => Api.DeleteWorkflowSession(workflow_id, session_id, db_id);
}

/// <summary>
/// Agno Knowledge Client
/// </summary>
public class KnowledgeClient : AgnoClient<IKnowledgeApi>, IKnowledgeApi
{
    public KnowledgeClient(IOptionsMonitor<AbpAgnoSharpOptions> options, IServiceProvider serviceProvider)
        : base(options, serviceProvider) { }

    public ITask<HttpResponseMessage> GetContent(string? db_id = null, int? page = null, int? limit = null)
        => Api.GetContent(db_id, page, limit);

    public ITask<HttpResponseMessage> PostContent(object requestBody)
        => Api.PostContent(requestBody);

    public ITask<HttpResponseMessage> GetContentById(string content_id, string? db_id = null)
        => Api.GetContentById(content_id, db_id);

    public ITask<HttpResponseMessage> PutContent(string content_id, object requestBody)
        => Api.PutContent(content_id, requestBody);

    public ITask<HttpResponseMessage> DeleteContent(string content_id, string? db_id = null)
        => Api.DeleteContent(content_id, db_id);

    public ITask<HttpResponseMessage> GetContentStatus(string content_id, string? db_id = null)
        => Api.GetContentStatus(content_id, db_id);

    public ITask<HttpResponseMessage> PostKnowledgeSearch(object requestBody)
        => Api.PostKnowledgeSearch(requestBody);

    public ITask<HttpResponseMessage> GetKnowledgeConfig(string? db_id = null)
        => Api.GetKnowledgeConfig(db_id);
}

/// <summary>
/// Agno Traces Client
/// </summary>
public class TracesClient : AgnoClient<ITracesApi>, ITracesApi
{
    public TracesClient(IOptionsMonitor<AbpAgnoSharpOptions> options, IServiceProvider serviceProvider)
        : base(options, serviceProvider) { }

    public ITask<HttpResponseMessage> GetTraces(string? run_id = null, string? session_id = null, string? user_id = null, string? agent_id = null, string? team_id = null, string? workflow_id = null, string? status = null, string? start_time = null, string? end_time = null, int? page = null, int? limit = null, string? db_id = null)
        => Api.GetTraces(run_id, session_id, user_id, agent_id, team_id, workflow_id, status, start_time, end_time, page, limit, db_id);

    public ITask<HttpResponseMessage> GetTraceById(string trace_id, string? span_id = null, string? run_id = null, string? db_id = null)
        => Api.GetTraceById(trace_id, span_id, run_id, db_id);

    public ITask<HttpResponseMessage> GetTraceSessionStats(string? user_id = null, string? agent_id = null, string? team_id = null, string? workflow_id = null, string? start_time = null, string? end_time = null, int? page = null, int? limit = null, string? db_id = null)
        => Api.GetTraceSessionStats(user_id, agent_id, team_id, workflow_id, start_time, end_time, page, limit, db_id);
}

/// <summary>
/// Agno Memory Client
/// </summary>
public class MemoryClient : AgnoClient<IMemoryApi>, IMemoryApi
{
    public MemoryClient(IOptionsMonitor<AbpAgnoSharpOptions> options, IServiceProvider serviceProvider)
        : base(options, serviceProvider) { }

    public ITask<HttpResponseMessage> GetUserMemories(string user_id, string? agent_id = null, string? team_id = null, string? db_id = null, int? page = null, int? limit = null)
        => Api.GetUserMemories(user_id, agent_id, team_id, db_id, page, limit);

    public ITask<HttpResponseMessage> PostUserMemory(string user_id, object requestBody)
        => Api.PostUserMemory(user_id, requestBody);

    public ITask<HttpResponseMessage> GetUserMemoryById(string user_id, string memory_id, string? db_id = null)
        => Api.GetUserMemoryById(user_id, memory_id, db_id);

    public ITask<HttpResponseMessage> PutUserMemory(string user_id, string memory_id, object requestBody)
        => Api.PutUserMemory(user_id, memory_id, requestBody);

    public ITask<HttpResponseMessage> DeleteUserMemory(string user_id, string memory_id, string? db_id = null)
        => Api.DeleteUserMemory(user_id, memory_id, db_id);

    public ITask<HttpResponseMessage> GetUserStats(string user_id, string? db_id = null)
        => Api.GetUserStats(user_id, db_id);
}

/// <summary>
/// Agno Database Client
/// </summary>
public class DatabaseClient : AgnoClient<IDatabaseApi>, IDatabaseApi
{
    public DatabaseClient(IOptionsMonitor<AbpAgnoSharpOptions> options, IServiceProvider serviceProvider)
        : base(options, serviceProvider) { }

    public ITask<HttpResponseMessage> PostMigrateAllDatabases(string? target_version = null)
        => Api.PostMigrateAllDatabases(target_version);

    public ITask<HttpResponseMessage> PostMigrateDatabase(string db_id, string? target_version = null)
        => Api.PostMigrateDatabase(db_id, target_version);
}



/// <summary>
/// Agno Core
/// </summary>
public class CoreClient : AgnoClient<ICoreApi>, ICoreApi
{
    public CoreClient(IOptionsMonitor<AbpAgnoSharpOptions> options, IServiceProvider serviceProvider)
        : base(options, serviceProvider) { }

    public ITask<HttpResponseMessage> GetModels()
        => Api.GetModels();

    public ITask<HttpResponseMessage> GetStatus()
        => Api.GetStatus();

    public ITask<HttpResponseMessage> GetConfig()
        => Api.GetConfig();

}

