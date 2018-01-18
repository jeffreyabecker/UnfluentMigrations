using System;
using UnfluentMigrations.Operations;
namespace UnfluentMigrations.Dialects.SqlConversion.Operations
{
    public class CreateConstraintRenderer : OperationRenderer<CreateConstraintOperation>
    {
        private readonly INameQuoter _quoter;
        public CreateConstraintRenderer(INameQuoter quoter)
        {
            _quoter = quoter;
        }

        protected override string RenderSql(CreateConstraintOperation operation)
        {
            throw new NotImplementedException();

        }
    }
}