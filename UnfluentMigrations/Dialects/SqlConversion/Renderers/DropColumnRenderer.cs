using System;
using UnfluentMigrations.Operations;

namespace UnfluentMigrations.Dialects.SqlConversion.Renderers
{
    public class DropColumnRenderer : OperationRenderer<DropColumnOperation>
    {
        private readonly IDialect _dialect;

        public DropColumnRenderer(IDialect dialect) { _dialect = dialect; }
        protected override string RenderSql(DropColumnOperation operation)
        {
            throw new NotImplementedException();
        }
    }
}
