using System.Collections.Generic;
using System.Linq;
using UnfluentMigrations.Operations;
using UnfluentMigrations.Operations.Model;

namespace UnfluentMigrations.Builders
{
    public static class CreateIndexExtensions
    {
        public static OperationBuilderSurface<CreateIndexOperation> CreateIndex(this IMigrationBuilder builder, 
            string name, string table, 
            IEnumerable<IndexColumnDefinition> columns,
            IEnumerable<IndexColumnDefinition> includes = null,
            string schema = null, string catalog = null,
            string filter= null)
        {
            var op = new CreateIndexOperation
            {
                Name = new SubObjectName(catalog, schema, table, name),
                Columns = columns.ToList(),
                Includes = (includes ?? new List<IndexColumnDefinition>()).ToList(),
                Filter = filter,
                
            };
            builder.AddOperation(op);
            return new OperationBuilderSurface<CreateIndexOperation>(op);
        }
    }
}