using UnfluentMigrations.Operations;
using UnfluentMigrations.Operations.Model;

namespace UnfluentMigrations.Builders
{
    public static class DropSchemaExtensions
    {
        public static OperationBuilderSurface<DropSchemaOperation> DropSchema(this IMigrationBuilder builder, string name, string catalog = null)
        {
            var op = new DropSchemaOperation
            {
                Name = new ObjectName(catalog, name, null)
            };
            builder.AddOperation(op);
            return new OperationBuilderSurface<DropSchemaOperation>(op);
        }
    }
}