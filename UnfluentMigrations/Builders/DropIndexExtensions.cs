using UnfluentMigrations.Operations;
using UnfluentMigrations.Operations.Model;

namespace UnfluentMigrations.Builders
{
    public static class DropIndexExtensions
    {
        public static OperationBuilderSurface<DropIndexOperation> DropIndex(this IMigrationBuilder builder, string name, string table, string schema = null, string catalog = null)
        {
            var op = new DropIndexOperation
            {
                Name = new SubObjectName(catalog, schema, table, name)
            };
            builder.AddOperation(op);
            return new OperationBuilderSurface<DropIndexOperation>(op);
        }
    }
}