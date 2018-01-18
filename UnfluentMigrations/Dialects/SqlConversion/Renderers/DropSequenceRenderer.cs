using System;
using UnfluentMigrations.Operations;

namespace UnfluentMigrations.Dialects.SqlConversion.Renderers
{
    public class DropSequenceRenderer : OperationRenderer<DropSequenceOperation>
    {
        private readonly IDialect _dialect;

        public DropSequenceRenderer(IDialect dialect) { _dialect = dialect; }
        protected override string RenderSql(DropSequenceOperation operation)
        {
            throw new NotImplementedException();
        }
    }
}
