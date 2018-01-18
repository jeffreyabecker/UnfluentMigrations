using System;
using UnfluentMigrations.Operations;

namespace UnfluentMigrations.Dialects.SqlConversion.Renderers
{
    public class AlterColumnRenderer : OperationRenderer<AlterColumnOperation>
    {
        private readonly IDialect _dialect;

        public AlterColumnRenderer(IDialect dialect) { _dialect = dialect; }
        protected override string RenderSql(AlterColumnOperation operation)
        {
            throw new NotImplementedException();
        }
    }
}
