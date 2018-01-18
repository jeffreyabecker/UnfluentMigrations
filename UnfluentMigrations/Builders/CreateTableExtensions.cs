using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using JetBrains.Annotations;
using UnfluentMigrations.Operations;
using UnfluentMigrations.Operations.Model;

namespace UnfluentMigrations.Builders
{
    public static class CreateTableExtensions
    {
        public static OperationBuilderSurface<CreateTableOperation> CreateTable<TColumns>(this IMigrationBuilder builder,  string name,
            Func<ColumnBuilder, TColumns> columns,
            string schema = null,
            string catalog = null,
            Action<CreateTableBuilder<TColumns>> constraints = null)
        {
            var op = new CreateTableOperation {Name = new ObjectName(catalog, schema, name)};
            var colInstance = columns(new ColumnBuilder());
            op.Columns = DecomposeColumns(colInstance, op.Name);
            builder.AddOperation(op);
            return new OperationBuilderSurface<CreateTableOperation>(op);
        }

        private static IList<ColumnDefinition> DecomposeColumns<TColumns>(TColumns cols, ObjectName tableName)
        {
            return typeof(TColumns)
                .GetRuntimeProperties()
                .Where(x => x.CanRead && x.PropertyType == typeof(ColumnDefinition))
                .Select(p =>
                {

                    var value = (ColumnDefinition) p.GetValue(cols);
                    value.Name = tableName.MakeSubObjectName(p.Name);
                    return value;
                })
                .ToList();
        }

        public static ConstraintColumnDefinition Ascending(this ColumnDefinition columnName)
        {
            return new ConstraintColumnDefinition { Column = columnName.Name.Name, Direction = SortDirection.Asc };
        }
        public static ConstraintColumnDefinition Descending(this ColumnDefinition columnName)
        {
            return new ConstraintColumnDefinition { Column = columnName.Name.Name, Direction = SortDirection.Desc };
        }
    }
}