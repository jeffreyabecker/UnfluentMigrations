using System.Data;
using UnfluentMigrations.Operations.Model;

namespace UnfluentMigrations.Builders
{
    public class ColumnBuilder
    {
        public ColumnDefinition Column<T>(string storeType = null, bool? unicode = null, int? size = null,
            int? precision = null, bool nullable = false,
            object defaultValue = null, string defaultValueSql = null, string computedColumnExpression = null,
            string collationName = null, DbType? explicitDbType = null)
        {
            return new ColumnDefinition
            {

                Type = ColumnDefinition.InferType(explicitDbType, typeof(T), storeType, size, precision),
                DefaultValue = defaultValue,
                IsNullable = nullable,
                Unicode = unicode,
                DefaultValueSql = defaultValueSql,
                ComputedColumnExpressionSql = computedColumnExpression,
                CollationName = null,
                
            };
        }
    }
}