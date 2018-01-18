using System;
using UnfluentMigrations.Operations;

namespace UnfluentMigrations.Dialects.SqlConversion.Renderers
{
    public class RenameTableRenderer : OperationRenderer<RenameTableOperation>
    {
        private readonly IDialect _dialect;

        public RenameTableRenderer(IDialect dialect) { _dialect = dialect; }
        protected override string RenderSql(RenameTableOperation operation)
        {
            throw new NotImplementedException();
        }
    }
}
