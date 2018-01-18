using System.Data;
using UnfluentMigrations.Operations;
using UnfluentMigrations.Operations.Model;

namespace UnfluentMigrations.Builders
{
    public static class CreateSequenceExtensions
    {
        public static OperationBuilderSurface<CreateSequenceOperation> CreateSequence(this IMigrationBuilder builder, string name, string schema=null, string catalog = null, DbType dbType = DbType.Int64, long? startValue=null, long? increment = null, long? minValue = null, long? maxValue=null, bool cycle=false, int? cache = null)
        {
            var op = new CreateSequenceOperation
            {
                Name = new ObjectName(catalog, schema, name),
                Cycle = cycle,
                StartWith = startValue,
                MaxValue = maxValue,
                MinValue = minValue,
                Increment = increment,
                DbType = dbType,
                Cache = cache
            };
            builder.AddOperation(op);
            return new OperationBuilderSurface<CreateSequenceOperation>(op);
        }
    }
}