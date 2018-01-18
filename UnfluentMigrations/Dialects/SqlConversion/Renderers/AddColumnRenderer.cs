using System;
using UnfluentMigrations.Operations;

namespace UnfluentMigrations.Dialects.SqlConversion.Renderers
{
    public class AddColumnRenderer : OperationRenderer<AddColumnOperation>
    {
        private readonly IDialect _dialect;

        public AddColumnRenderer(IDialect dialect) { _dialect = dialect; }
        protected override string RenderSql(AddColumnOperation operation)
        {
            throw new NotImplementedException();
        }
    }
}
