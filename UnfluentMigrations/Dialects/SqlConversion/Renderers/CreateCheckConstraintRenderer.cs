using System;
using UnfluentMigrations.Operations;

namespace UnfluentMigrations.Dialects.SqlConversion.Renderers
{
    public class CreateCheckConstraintRenderer : OperationRenderer<CreateCheckConstraintOperation>
    {
        private readonly IDialect _dialect;

        public CreateCheckConstraintRenderer(IDialect dialect) { _dialect = dialect; }
        protected override string RenderSql(CreateCheckConstraintOperation operation)
        {
            throw new NotImplementedException();
        }
    }
}
