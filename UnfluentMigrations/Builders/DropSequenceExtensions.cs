using UnfluentMigrations.Operations;
using UnfluentMigrations.Operations.Model;

namespace UnfluentMigrations.Builders
{
    public static class DropSequenceExtensions
    {
        public static OperationBuilderSurface<DropSequenceOperation> DropSequence(this IMigrationBuilder builder, string name, string schema = null, string catalog = null)
        {
            var op = new DropSequenceOperation
            {
                Name = new ObjectName(catalog, schema, name)
            };
            builder.AddOperation(op);
            return new OperationBuilderSurface<DropSequenceOperation>(op);
        }
    }
}