using System;
using UnfluentMigrations.Operations;
namespace UnfluentMigrations.Dialects.SqlConversion.Operations
{
    public class DropIndexRenderer : OperationRenderer<DropIndexOperation>
    {
        private readonly INameQuoter _quoter;
        public DropIndexRenderer(INameQuoter quoter)
        {
            _quoter = quoter;
        }

        protected override string RenderSql(DropIndexOperation operation)
        {
            throw new NotImplementedException();

        }
    }
}