using System;
using UnfluentMigrations.Operations;
namespace UnfluentMigrations.Dialects.SqlConversion.Operations
{
    public class AlterColumnRenderer : OperationRenderer<AlterColumnOperation>
    {
        private readonly INameQuoter _quoter;
        public AlterColumnRenderer(INameQuoter quoter)
        {
            _quoter = quoter;
        }

        protected override string RenderSql(AlterColumnOperation operation)
        {
            throw new NotImplementedException();

        }
    }
}