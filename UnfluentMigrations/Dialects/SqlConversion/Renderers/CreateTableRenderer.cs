using System;
using UnfluentMigrations.Operations;

namespace UnfluentMigrations.Dialects.SqlConversion.Renderers
{
    public class CreateTableRenderer : OperationRenderer<CreateTableOperation>
    {
        private readonly IDialect _dialect;

        public CreateTableRenderer(IDialect dialect) { _dialect = dialect; }
        protected override string RenderSql(CreateTableOperation operation)
        {
            throw new NotImplementedException();
        }
    }
}
