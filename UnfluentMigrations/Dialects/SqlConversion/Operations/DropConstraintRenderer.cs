using System;
using UnfluentMigrations.Operations;
namespace UnfluentMigrations.Dialects.SqlConversion.Operations
{
    public class DropConstraintRenderer : OperationRenderer<DropConstraintOperation>
    {
        private readonly INameQuoter _quoter;
        public DropConstraintRenderer(INameQuoter quoter)
        {
            _quoter = quoter;
        }

        protected override string RenderSql(DropConstraintOperation operation)
        {
            throw new NotImplementedException();

        }
    }
}