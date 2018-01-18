using System;
using UnfluentMigrations.Operations;

namespace UnfluentMigrations.Dialects.SqlConversion.Renderers
{
    public class DropCheckConstraintRenderer : OperationRenderer<DropCheckConstraintOperation>
    {
        private readonly IDialect _dialect;

        public DropCheckConstraintRenderer(IDialect dialect) { _dialect = dialect; }
        protected override string RenderSql(DropCheckConstraintOperation operation)
        {
            throw new NotImplementedException();
        }
    }
}
