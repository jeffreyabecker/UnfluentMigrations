using UnfluentMigrations.Operations;
using UnfluentMigrations.Operations.Model;

namespace UnfluentMigrations.Builders
{
    public static class DropForeignKeyExtensions
    {
        public static OperationBuilderSurface<DropForeignKeyConstraintOperation> DropForeignKey(this IMigrationBuilder builder, string name, string table, string schema = null, string catalog = null)
        {

            var op = new DropForeignKeyConstraintOperation
            {
                Name = new SubObjectName(catalog, schema, table, name)
            };
            builder.AddOperation(op);
            return new OperationBuilderSurface<DropForeignKeyConstraintOperation>(op);
        }
    }
}