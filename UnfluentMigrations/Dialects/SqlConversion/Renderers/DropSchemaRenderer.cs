using System;
using UnfluentMigrations.Operations;

namespace UnfluentMigrations.Dialects.SqlConversion.Renderers
{
    public class DropSchemaRenderer : OperationRenderer<DropSchemaOperation>
    {
        private readonly IDialect _dialect;

        public DropSchemaRenderer(IDialect dialect) { _dialect = dialect; }
        protected override string RenderSql(DropSchemaOperation operation)
        {
            throw new NotImplementedException();
        }
    }
}
