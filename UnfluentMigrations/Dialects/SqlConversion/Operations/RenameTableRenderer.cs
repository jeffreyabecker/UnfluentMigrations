using System;
using UnfluentMigrations.Operations;
namespace UnfluentMigrations.Dialects.SqlConversion.Operations
{
    public class RenameTableRenderer : OperationRenderer<RenameTableOperation>
    {
        private readonly INameQuoter _quoter;
        public RenameTableRenderer(INameQuoter quoter)
        {
            _quoter = quoter;
        }

        protected override string RenderSql(RenameTableOperation operation)
        {
            throw new NotImplementedException("There is no standard sql for renaming a table, please use a derived class");

        }
    }
}