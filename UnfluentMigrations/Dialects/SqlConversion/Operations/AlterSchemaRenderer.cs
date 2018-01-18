using System;
using UnfluentMigrations.Operations;
namespace UnfluentMigrations.Dialects.SqlConversion.Operations
{
    public class AlterSchemaRenderer : OperationRenderer<AlterSchemaOperation>
    {
        private readonly INameQuoter _quoter;
        public AlterSchemaRenderer(INameQuoter quoter)
        {
            _quoter = quoter;
        }

        protected override string RenderSql(AlterSchemaOperation operation)
        {
            throw new NotImplementedException();

        }
    }
}