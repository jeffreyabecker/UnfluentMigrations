using System;
using UnfluentMigrations.Operations;

namespace UnfluentMigrations.Dialects.SqlConversion.Renderers
{
    public class ExecuteSqlStatementRenderer : OperationRenderer<ExecuteSqlStatementOperation>
    {
        private readonly IDialect _dialect;

        public ExecuteSqlStatementRenderer(IDialect dialect) { _dialect = dialect; }
        protected override string RenderSql(ExecuteSqlStatementOperation operation)
        {
            throw new NotImplementedException();
        }
    }
}
