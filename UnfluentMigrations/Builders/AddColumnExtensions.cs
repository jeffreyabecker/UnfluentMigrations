using System.Data;
using UnfluentMigrations.Operations;
using UnfluentMigrations.Operations.Model;

namespace UnfluentMigrations.Builders
{
    public static class AddColumnExtensions
    {

        public static OperationBuilderSurface<AddColumnOperation> AddColumn<T>(this IMigrationBuilder builder,
            string name, string table, string schema = null, string catalog = null,
            string storeType = null, bool? unicode = null, int? size = null, int? precision = null, bool nullable = false,
            object defaultValue = null, string defaultValueSql = null, string computedColumnExpression = null,
            string collationName = null, DbType? explicitDbType = null)
        {
            var op = new AddColumnOperation
            {
                Column = new ColumnDefinition
                {
                    Name = new SubObjectName { Catalog = catalog, ParentName = table, Name = name, Schema = schema },
                    Type = ColumnDefinition.InferType(explicitDbType, typeof(T), storeType, size, precision),
                    DefaultValue = defaultValue,
                    IsNullable = nullable,
                    Unicode = unicode,
                    DefaultValueSql = defaultValueSql,
                    ComputedColumnExpressionSql = computedColumnExpression,
                    CollationName = null,
                }
            };
            builder.AddOperation(op);
            return new OperationBuilderSurface<AddColumnOperation>(op);
        }
    }
}