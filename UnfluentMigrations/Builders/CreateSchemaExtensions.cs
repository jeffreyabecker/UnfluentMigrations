using UnfluentMigrations.Operations;
using UnfluentMigrations.Operations.Model;

namespace UnfluentMigrations.Builders
{
    public static class CreateSchemaExtensions
    {
        public static OperationBuilderSurface<CreateSchemaOperation> CreateSchema(this IMigrationBuilder builder, string schema, string catalog = null)
        {
            var op = new CreateSchemaOperation
            {
                Name = new ObjectName(catalog, schema, null)
            };
            builder.AddOperation(op);
            return new OperationBuilderSurface<CreateSchemaOperation>(op);
        }
    }
}