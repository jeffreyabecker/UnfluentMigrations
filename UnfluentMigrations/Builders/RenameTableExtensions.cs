using UnfluentMigrations.Operations;
using UnfluentMigrations.Operations.Model;

namespace UnfluentMigrations.Builders
{
    public static class RenameTableExtensions
    {
        public static OperationBuilderSurface<RenameTableOperation> RenameTable(this IMigrationBuilder builder, string oldName, string newName, string oldSchema = null, string newSchema = null, string catalog = null)
        {
            var op = new RenameTableOperation
            {
                OldName = new ObjectName(catalog, oldSchema, oldName),
                NewName = new ObjectName(catalog, newSchema, newName)
            };
            builder.AddOperation(op);
            return new OperationBuilderSurface<RenameTableOperation>(op);
        }
    }
}