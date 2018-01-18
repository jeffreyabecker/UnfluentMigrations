using System;
using UnfluentMigrations.Operations;

namespace UnfluentMigrations.Dialects.SqlConversion.Renderers
{
    public class RenameColumnRenderer : OperationRenderer<RenameColumnOperation>
    {
        private readonly IDialect _dialect;

        public RenameColumnRenderer(IDialect dialect) { _dialect = dialect; }
        protected override string RenderSql(RenameColumnOperation operation)
        {
            throw new NotImplementedException();
        }
    }
}
