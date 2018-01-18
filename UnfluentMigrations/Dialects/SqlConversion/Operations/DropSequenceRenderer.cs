using System;
using UnfluentMigrations.Operations;
namespace UnfluentMigrations.Dialects.SqlConversion.Operations
{
    public class DropSequenceRenderer : OperationRenderer<DropSequenceOperation>
    {
        private readonly INameQuoter _quoter;
        public DropSequenceRenderer(INameQuoter quoter)
        {
            _quoter = quoter;
        }

        protected override string RenderSql(DropSequenceOperation operation)
        {
            return $"DROP SEQUENCE {_quoter.Quote(operation.Name)}";

        }
    }
}