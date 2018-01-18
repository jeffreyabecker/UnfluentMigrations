using System;
using UnfluentMigrations.Operations;
namespace UnfluentMigrations.Dialects.SqlConversion.Operations
{
    public class AddForeignKeyRenderer : OperationRenderer<CreateForeignKeyConstraintOperation>
    {
        private readonly INameQuoter _quoter;
        public AddForeignKeyRenderer(INameQuoter quoter)
        {
            _quoter = quoter;
        }

        protected override string RenderSql(CreateForeignKeyConstraintOperation operation)
        {
            throw new NotImplementedException();

        }
    }
}