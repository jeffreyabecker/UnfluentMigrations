using System;
using UnfluentMigrations.Operations;

namespace UnfluentMigrations.Dialects.SqlConversion.Renderers
{
    public class DropTableRenderer : OperationRenderer<DropTableOperation>
    {
        private readonly IDialect _dialect;

        public DropTableRenderer(IDialect dialect) { _dialect = dialect; }
        protected override string RenderSql(DropTableOperation operation)
        {
            throw new NotImplementedException();
        }
    }
}
