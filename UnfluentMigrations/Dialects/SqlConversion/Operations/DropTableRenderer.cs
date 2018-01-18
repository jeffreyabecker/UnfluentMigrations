using System;
using UnfluentMigrations.Operations;
namespace UnfluentMigrations.Dialects.SqlConversion.Operations
{
    public class DropTableRenderer : OperationRenderer<DropTableOperation>
    {
        private readonly INameQuoter _quoter;
        public DropTableRenderer(INameQuoter quoter)
        {
            _quoter = quoter;
        }

        protected override string RenderSql(DropTableOperation operation)
        {
            return $"DROP TABLE {_quoter.Quote(operation.Name)}";
        }
    }
}