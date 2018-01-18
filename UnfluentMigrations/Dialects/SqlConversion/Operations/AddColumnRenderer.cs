using System;
using UnfluentMigrations.Operations;
namespace UnfluentMigrations.Dialects.SqlConversion.Operations
{
    public class AddColumnRenderer : OperationRenderer<AddColumnOperation>
    {
        private readonly INameQuoter _quoter;
        public AddColumnRenderer(INameQuoter quoter)
        {
            _quoter = quoter;
        }

        protected override string RenderSql(AddColumnOperation operation)
        {
            throw new NotImplementedException();

        }
    }
}