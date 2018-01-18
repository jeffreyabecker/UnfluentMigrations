using System;
using UnfluentMigrations.Operations;

namespace UnfluentMigrations.Dialects.SqlConversion.Renderers
{
    public class DropIndexRenderer : OperationRenderer<DropIndexOperation>
    {
        private readonly IDialect _dialect;

        public DropIndexRenderer(IDialect dialect) { _dialect = dialect; }
        protected override string RenderSql(DropIndexOperation operation)
        {
            throw new NotImplementedException();
        }
    }
}
