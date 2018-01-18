using System;
using UnfluentMigrations.Operations;
namespace UnfluentMigrations.Dialects.SqlConversion.Operations
{
    public class RenameColumnRenderer : OperationRenderer<RenameColumnOperation>
    {
        private readonly INameQuoter _quoter;
        public RenameColumnRenderer(INameQuoter quoter)
        {
            _quoter = quoter;
        }

        protected override string RenderSql(RenameColumnOperation operation)
        {
            throw new NotImplementedException("There is no standard sql for renaming a column, please use a derived class");

        }
    }
}