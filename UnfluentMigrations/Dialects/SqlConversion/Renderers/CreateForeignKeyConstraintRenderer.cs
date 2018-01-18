using System;
using UnfluentMigrations.Operations;

namespace UnfluentMigrations.Dialects.SqlConversion.Renderers
{
    public class CreateForeignKeyConstraintRenderer : OperationRenderer<CreateForeignKeyConstraintOperation>
    {
        private readonly IDialect _dialect;

        public CreateForeignKeyConstraintRenderer(IDialect dialect) { _dialect = dialect; }
        protected override string RenderSql(CreateForeignKeyConstraintOperation operation)
        {
            throw new NotImplementedException();
        }
    }
}
