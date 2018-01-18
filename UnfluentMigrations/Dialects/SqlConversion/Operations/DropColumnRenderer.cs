using System;
using UnfluentMigrations.Operations;
namespace UnfluentMigrations.Dialects.SqlConversion.Operations
{
    public class DropColumnRenderer : OperationRenderer<DropColumnOperation>
    {
        private readonly INameQuoter _quoter;
        public DropColumnRenderer(INameQuoter quoter)
        {
            _quoter = quoter;
        }

        protected override string RenderSql(DropColumnOperation operation)
        {
            throw new NotImplementedException();

        }
    }
}