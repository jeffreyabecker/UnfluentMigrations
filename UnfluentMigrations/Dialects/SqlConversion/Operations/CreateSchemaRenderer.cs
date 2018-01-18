using System;
using UnfluentMigrations.Operations;
namespace UnfluentMigrations.Dialects.SqlConversion.Operations
{
    public class CreateSchemaRenderer : OperationRenderer<CreateSchemaOperation>
    {
        private readonly INameQuoter _quoter;
        public CreateSchemaRenderer(INameQuoter quoter)
        {
            _quoter = quoter;
        }

        protected override string RenderSql(CreateSchemaOperation operation)
        {
            throw new NotImplementedException();

        }
    }
}