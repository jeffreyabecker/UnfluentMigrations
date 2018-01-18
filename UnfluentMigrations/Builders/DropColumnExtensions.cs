using UnfluentMigrations.Operations;
using UnfluentMigrations.Operations.Model;

namespace UnfluentMigrations.Builders
{
    public static class DropColumnExtensions
    {
        public static OperationBuilderSurface<DropColumnOperation> DropColumn(this IMigrationBuilder builder, string name, string table, string schema = null, string catalog = null)
        {
            var op = new DropColumnOperation
            {
                Name = new SubObjectName(catalog, schema, table, name)
            };
            builder.AddOperation(op);
            return new OperationBuilderSurface<DropColumnOperation>(op);
        }
    }
}