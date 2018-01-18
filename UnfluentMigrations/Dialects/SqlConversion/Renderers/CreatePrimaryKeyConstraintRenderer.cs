using System;
using UnfluentMigrations.Operations;

namespace UnfluentMigrations.Dialects.SqlConversion.Renderers
{
    public class CreatePrimaryKeyConstraintRenderer : OperationRenderer<CreatePrimaryKeyConstraintOperation>
    {
        private readonly IDialect _dialect;

        public CreatePrimaryKeyConstraintRenderer(IDialect dialect) { _dialect = dialect; }
        protected override string RenderSql(CreatePrimaryKeyConstraintOperation operation)
        {
            throw new NotImplementedException();
        }
    }
}
