using System;
using UnfluentMigrations.Operations;

namespace UnfluentMigrations.Dialects.SqlConversion.Renderers
{
    public class CreateUniqueConstraintRenderer : OperationRenderer<CreateUniqueConstraintOperation>
    {
        private readonly IDialect _dialect;

        public CreateUniqueConstraintRenderer(IDialect dialect) { _dialect = dialect; }
        protected override string RenderSql(CreateUniqueConstraintOperation operation)
        {
            throw new NotImplementedException();
        }
    }
}
