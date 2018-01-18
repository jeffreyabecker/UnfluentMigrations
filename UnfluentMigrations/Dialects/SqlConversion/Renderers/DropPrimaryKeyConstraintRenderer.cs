using System;
using UnfluentMigrations.Operations;

namespace UnfluentMigrations.Dialects.SqlConversion.Renderers
{
    public class DropPrimaryKeyConstraintRenderer : OperationRenderer<DropPrimaryKeyConstraintOperation>
    {
        private readonly IDialect _dialect;

        public DropPrimaryKeyConstraintRenderer(IDialect dialect) { _dialect = dialect; }
        protected override string RenderSql(DropPrimaryKeyConstraintOperation operation)
        {
            throw new NotImplementedException();
        }
    }
}
