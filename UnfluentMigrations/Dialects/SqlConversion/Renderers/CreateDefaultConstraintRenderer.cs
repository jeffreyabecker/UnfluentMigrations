using System;
using UnfluentMigrations.Operations;

namespace UnfluentMigrations.Dialects.SqlConversion.Renderers
{
    public class CreateDefaultConstraintRenderer : OperationRenderer<CreateDefaultConstraintOperation>
    {
        private readonly IDialect _dialect;

        public CreateDefaultConstraintRenderer(IDialect dialect) { _dialect = dialect; }
        protected override string RenderSql(CreateDefaultConstraintOperation operation)
        {
            throw new NotImplementedException();
        }
    }
}
