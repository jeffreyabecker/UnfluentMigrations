using System;
using UnfluentMigrations.Operations;

namespace UnfluentMigrations.Dialects.SqlConversion.Renderers
{
    public class CreateIndexRenderer : OperationRenderer<CreateIndexOperation>
    {
        private readonly IDialect _dialect;

        public CreateIndexRenderer(IDialect dialect) { _dialect = dialect; }
        protected override string RenderSql(CreateIndexOperation operation)
        {
            throw new NotImplementedException();
        }
    }
}
