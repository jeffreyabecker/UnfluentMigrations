using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnfluentMigrations.Operations;
using UnfluentMigrations.Operations.Model;

namespace UnfluentMigrations.Builders
{
    public static class CreateConstraintExtensions
    {
        public static ConstraintColumnDefinition Ascending(this string columnName)
        {
            return new ConstraintColumnDefinition {Column = columnName, Direction = SortDirection.Asc};
        }
        public static ConstraintColumnDefinition Descending(this string columnName)
        {
            return new ConstraintColumnDefinition { Column = columnName, Direction = SortDirection.Desc };
        }
        public static OperationBuilderSurface<CreateUniqueConstratintOperation> CreateUniqueConstraint(
            IMigrationBuilder builder, string name, string table, IEnumerable<ConstraintColumnDefinition> columns,
            string schema = null, string catalog = null)
        {
            var op = new CreateUniqueConstratintOperation
            {
                Name = new SubObjectName(catalog, schema, table, name),
                Columns = columns.ToList()
            };
            builder.AddOperation(op);
            return new OperationBuilderSurface<CreateUniqueConstratintOperation>(op);
        }
        public static OperationBuilderSurface<CreateUniqueConstratintOperation> CreateUniqueConstraint(
            IMigrationBuilder builder, string name, string table, ConstraintColumnDefinition column,
            string schema = null, string catalog = null)
        {
            return CreateUniqueConstraint(builder, name, table, new[] {column}, schema, catalog);
        }
        public static OperationBuilderSurface<CreateUniqueConstratintOperation> CreateUniqueConstraint(
            IMigrationBuilder builder, string name, string table, string[] columns,
            string schema = null, string catalog = null)
        {
            return CreateUniqueConstraint(builder, name, table, columns.Select(x=>Ascending(x)), schema, catalog);
        }
        public static OperationBuilderSurface<CreateUniqueConstratintOperation> CreateUniqueConstraint(
            IMigrationBuilder builder, string name, string table, string column,
            string schema = null, string catalog = null)
        {
            return CreateUniqueConstraint(builder, name, table, new []{column}, schema, catalog);
        }
        public static OperationBuilderSurface<CreatePrimaryKeyConstraintOperation> CreatePrimaryKeyConstraintOperation(
            IMigrationBuilder builder, string name, string table, IEnumerable<ConstraintColumnDefinition> columns,
            string schema = null, string catalog = null)
        {
            var op = new CreatePrimaryKeyConstraintOperation
            {
                Name = new SubObjectName(catalog, schema, table, name),
                Columns = columns.ToList()
            };
            builder.AddOperation(op);
            return new OperationBuilderSurface<CreatePrimaryKeyConstraintOperation>(op);
        }
        public static OperationBuilderSurface<CreatePrimaryKeyConstraintOperation> CreatePrimaryKey(
            IMigrationBuilder builder, string name, string table, ConstraintColumnDefinition column,
            string schema = null, string catalog = null)
        {
            return CreatePrimaryKeyConstraintOperation(builder, name, table, new[] { column }, schema, catalog);
        }
        public static OperationBuilderSurface<CreatePrimaryKeyConstraintOperation> CreatePrimaryKey(
            IMigrationBuilder builder, string name, string table, string[] columns,
            string schema = null, string catalog = null)
        {
            return CreatePrimaryKeyConstraintOperation(builder, name, table, columns.Select(x => Ascending(x)), schema, catalog);
        }
        public static OperationBuilderSurface<CreatePrimaryKeyConstraintOperation> CreatePrimaryKey(
            IMigrationBuilder builder, string name, string table, string column,
            string schema = null, string catalog = null)
        {
            return CreatePrimaryKey(builder, name, table, new[] { column }, schema, catalog);
        }
    }
}
