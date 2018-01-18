using UnfluentMigrations.Operations;
using UnfluentMigrations.Operations.Model;

namespace UnfluentMigrations.Builders
{
    public static class DropTableExtensions
    {
        public static OperationBuilderSurface<DropTableOperation> DropTable(this IMigrationBuilder builder, string name, string schema = null, string catalog = null)
        {
            var op = new DropTableOperation
            {
                Name = new ObjectName(catalog, schema, name)
            };
            builder.AddOperation(op);
            return new OperationBuilderSurface<DropTableOperation>(op);
        }
    }
}