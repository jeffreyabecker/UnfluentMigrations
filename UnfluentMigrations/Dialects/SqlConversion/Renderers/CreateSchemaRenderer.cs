using UnfluentMigrations.Operations;

namespace UnfluentMigrations.Dialects.SqlConversion.Renderers
{
    public class CreateSchemaRenderer : OperationRenderer<CreateSchemaOperation>
    {
        private readonly IDialect _dialect;

        public CreateSchemaRenderer(IDialect dialect) { _dialect = dialect; }
        protected override string RenderSql(CreateSchemaOperation operation)
        {
            return $"CREATE SCHEMA {_dialect.Quote(operation.Name)}";
        }
    }
}
