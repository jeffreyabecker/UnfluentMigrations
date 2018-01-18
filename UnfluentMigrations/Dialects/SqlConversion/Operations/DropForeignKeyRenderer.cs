using System;
using UnfluentMigrations.Operations;
namespace UnfluentMigrations.Dialects.SqlConversion.Operations
{
    public class DropForeignKeyRenderer : OperationRenderer<DropForeignKeyOperation>
    {
        private readonly INameQuoter _quoter;
        public DropForeignKeyRenderer(INameQuoter quoter)
        {
            _quoter = quoter;
        }

        protected override string RenderSql(DropForeignKeyOperation operation)
        {
            throw new NotImplementedException();

        }
    }
}