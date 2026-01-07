# AbpAgnoSharp

AbpAgnoSharp 是一个用于对接 Agno AgentOS 服务的 ABP Framework 集成库。

[![NuGet](https://img.shields.io/nuget/v/AbpAgnoSharp.svg)](https://www.nuget.org/packages/AbpAgnoSharp/)
[![NuGet](https://img.shields.io/nuget/dt/AbpAgnoSharp.svg)](https://www.nuget.org/packages/AbpAgnoSharp/)

## 功能特性

- 完整的 Agno AgentOS API 支持
  - Agent API - 代理管理
  - Team API - 团队管理
  - Workflow API - 工作流管理
  - Knowledge API - 知识库管理
  - Traces API - 追踪管理
  - Memory API - 记忆管理
  - Database API - 数据库管理

- 基于 WebApiClientCore 的 HTTP 客户端
- 自动认证处理
- 支持 JSON 序列化/反序列化（Snake Case）
- 依赖注入支持

## 安装

### 通过 NuGet 安装

```bash
dotnet add package AbpAgnoSharp
```

或通过 Package Manager Console：

```powershell
Install-Package AbpAgnoSharp
```

### 通过项目引用安装

在您的 ABP 项目中添加项目引用：

```xml
<ProjectReference Include="..\AbpAgnoSharp\AbpAgnoSharp.csproj" />
```

## 配置

在 `appsettings.json` 中配置 Agno 服务：

```json
{
  "AI": {
    "Agno": {
      "ApiKey": "your-api-key",
      "BaseUrl": "http://localhost:7777",
      "EnableLogging": false
    }
  }
}
```

## 使用示例

### 1. 在模块中注册

```csharp
[DependsOn(typeof(AbpAgnoSharpModule))]
public class YourModule : AbpModule
{
    // ...
}
```

### 2. 注入并使用 Client

```csharp
public class YourService : ITransientDependency
{
    private readonly AgentClient _agentClient;

    public YourService(AgentClient agentClient)
    {
        _agentClient = agentClient;
    }

    public async Task GetAgentsAsync()
    {
        var response = await _agentClient.GetAgents();
        // 处理响应
    }
}
```

### 3. 直接使用 API 接口

```csharp
public class YourService : ITransientDependency
{
    private readonly IAgentApi _agentApi;

    public YourService(IAgentApi agentApi)
    {
        _agentApi = agentApi;
    }

    public async Task GetAgentsAsync()
    {
        var response = await _agentApi.GetAgents();
        // 处理响应
    }
}
```

## API 客户端

项目提供了以下客户端类：

- `AgentClient` - 代理操作
- `TeamClient` - 团队操作
- `WorkflowClient` - 工作流操作
- `KnowledgeClient` - 知识库操作
- `TracesClient` - 追踪操作
- `MemoryClient` - 记忆操作
- `DatabaseClient` - 数据库操作

## 依赖项

- Volo.Abp (10.0.1)
- WebApiClientCore (2.1.5)
- WebApiClientCore.Extensions.OAuths (2.1.5)

## 许可证

本项目采用 [MIT 许可证](LICENSE)。

## 贡献

欢迎提交 Issue 和 Pull Request！

## 相关链接

- [Agno AgentOS 文档](http://localhost:7777/docs)
- [ABP Framework 文档](https://docs.abp.io/)
- [项目仓库](https://github.com/jevonsflash/AbpAgnoSharp)

