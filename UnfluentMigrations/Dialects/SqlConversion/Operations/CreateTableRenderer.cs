using System;
using UnfluentMigrations.Operations;
namespace UnfluentMigrations.Dialects.SqlConversion.Operations
{
    public class CreateTableRenderer : OperationRenderer<CreateTableOperation>
    {
        private readonly INameQuoter _quoter;
        public CreateTableRenderer(INameQuoter quoter)
        {
            _quoter = quoter;
        }

        protected override string RenderSql(CreateTableOperation operation)
        {
            throw new NotImplementedException();

        }
    }
}