using System;
using UnfluentMigrations.Operations;
namespace UnfluentMigrations.Dialects.SqlConversion.Operations
{
    public class CreateSequenceRenderer : OperationRenderer<CreateSequenceOperation>
    {
        private readonly INameQuoter _quoter;
        public CreateSequenceRenderer(INameQuoter quoter)
        {
            _quoter = quoter;
        }

        protected override string RenderSql(CreateSequenceOperation operation)
        {
            throw new NotImplementedException();

        }
    }
}