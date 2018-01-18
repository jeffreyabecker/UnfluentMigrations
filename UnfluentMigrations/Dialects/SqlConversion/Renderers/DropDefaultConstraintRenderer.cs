using System;
using UnfluentMigrations.Operations;

namespace UnfluentMigrations.Dialects.SqlConversion.Renderers
{
    public class DropDefaultConstraintRenderer : OperationRenderer<DropDefaultConstraintOperation>
    {
        private readonly IDialect _dialect;

        public DropDefaultConstraintRenderer(IDialect dialect) { _dialect = dialect; }
        protected override string RenderSql(DropDefaultConstraintOperation operation)
        {
            throw new NotImplementedException();
        }
    }
}
