using System;
using UnfluentMigrations.Operations;

namespace UnfluentMigrations.Dialects.SqlConversion.Renderers
{
    public class DropUniqueConstraintRenderer : OperationRenderer<DropUniqueConstraintOperation>
    {
        private readonly IDialect _dialect;

        public DropUniqueConstraintRenderer(IDialect dialect) { _dialect = dialect; }
        protected override string RenderSql(DropUniqueConstraintOperation operation)
        {
            throw new NotImplementedException();
        }
    }
}
