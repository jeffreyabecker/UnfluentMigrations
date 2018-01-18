using System;
using UnfluentMigrations.Operations;

namespace UnfluentMigrations.Dialects.SqlConversion.Renderers
{
    public class DropForeignKeyConstraintRenderer : OperationRenderer<DropForeignKeyConstraintOperation>
    {
        private readonly IDialect _dialect;

        public DropForeignKeyConstraintRenderer(IDialect dialect) { _dialect = dialect; }
        protected override string RenderSql(DropForeignKeyConstraintOperation operation)
        {
            throw new NotImplementedException();
        }
    }
}
