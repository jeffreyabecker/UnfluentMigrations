using System;
using UnfluentMigrations.Operations;
namespace UnfluentMigrations.Dialects.SqlConversion.Operations
{
    public class DropSchemaRenderer : OperationRenderer<DropSchemaOperation>
    {
        private readonly INameQuoter _quoter;
        public DropSchemaRenderer(INameQuoter quoter)
        {
            _quoter = quoter;
        }

        protected override string RenderSql(DropSchemaOperation operation)
        {
            return $"DROP SCHEMA {_quoter.Quote(operation.Name)}";

        }
    }
}