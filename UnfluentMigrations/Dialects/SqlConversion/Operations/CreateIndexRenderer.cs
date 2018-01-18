using System;
using UnfluentMigrations.Operations;
namespace UnfluentMigrations.Dialects.SqlConversion.Operations
{
    public class CreateIndexRenderer : OperationRenderer<CreateIndexOperation>
    {
        private readonly INameQuoter _quoter;
        public CreateIndexRenderer(INameQuoter quoter)
        {
            _quoter = quoter;
        }

        protected override string RenderSql(CreateIndexOperation operation)
        {
            throw new NotImplementedException();

        }
    }
}