using System;
using UnfluentMigrations.Dialects.DataAccess;
using UnfluentMigrations.Operations;
namespace UnfluentMigrations.Dialects.SqlConversion.Operations
{
    public class ExecuteSqlStatementRenderer : OperationRenderer<ExecuteSqlStatementOperation>
    {
        private readonly INameQuoter _quoter;
        public ExecuteSqlStatementRenderer(INameQuoter quoter)
        {
            _quoter = quoter;
        }

        protected override SqlStatement Render(ExecuteSqlStatementOperation operation)
        {
            return operation.SqlStatement;
        }

        protected override string RenderSql(ExecuteSqlStatementOperation operation)
        {
            return "";

        }
    }
}