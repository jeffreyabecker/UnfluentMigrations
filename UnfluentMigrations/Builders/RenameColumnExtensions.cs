using UnfluentMigrations.Operations;
using UnfluentMigrations.Operations.Model;

namespace UnfluentMigrations.Builders
{
    public static class RenameColumnExtensions
    {
        public static OperationBuilderSurface<RenameColumnOperation> RenameColumn(this IMigrationBuilder builder, string oldName, string newName, string table, string schema = null, string catalog = null)
        {
            var op = new RenameColumnOperation
            {
                OldName = new SubObjectName(catalog, schema, table, oldName),
                NewName = new SubObjectName(catalog, schema, table, newName)
            };
            builder.AddOperation(op);
            return new OperationBuilderSurface<RenameColumnOperation>(op);
        }
    }
}