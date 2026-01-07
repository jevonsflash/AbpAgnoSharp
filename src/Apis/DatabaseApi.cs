using Volo.Abp.AgnoSharp.Attributes;
using WebApiClientCore;
using WebApiClientCore.Attributes;
using WebApiClientCore.Parameters;

namespace Volo.Abp.AgnoSharp.Apis
{
    /// <summary>
    /// Database API
    /// </summary>
    [LoggingFilter, AgnoAuth]
    public interface IDatabaseApi
    {
        /// <summary>
        /// Migrate All Databases
        /// </summary>
        [HttpPost("/databases/all/migrate")]
        public ITask<HttpResponseMessage> PostMigrateAllDatabases(
            [PathQuery] string? target_version = null
        );

        /// <summary>
        /// Migrate Database
        /// </summary>
        [HttpPost("/databases/{db_id}/migrate")]
        public ITask<HttpResponseMessage> PostMigrateDatabase(
            string db_id,
            [PathQuery] string? target_version = null
        );
    }
}

