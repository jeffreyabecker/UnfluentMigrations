
using System.Collections.Generic;
using System.Linq;
using UnfluentMigrations.Operations;
using UnfluentMigrations.Operations.Model;

namespace UnfluentMigrations.Builders
{
    public static class AddForeignKeyExtensions
    {
        public static OperationBuilderSurface<CreateForeignKeyConstraintOperation> AddForeignKey(this IMigrationBuilder builder,
            string keyName,
            string dependentTable,
            string dependentColumn,
            string principalTable,
            string dependentSchema = null,
            string dependentCatalog = null,
            string principalCatalog = null,
            string principalSchema = null,
            string principalColumn = null,
            CascadeRule onUpdate = CascadeRule.None,
            CascadeRule onDelete = CascadeRule.None)
        {
            return AddForeignKey(builder, keyName, dependentTable, new[]{dependentColumn}, principalTable, new []{principalColumn}, dependentSchema, dependentCatalog, principalCatalog, principalSchema);
        }

        public static OperationBuilderSurface<CreateForeignKeyConstraintOperation> AddForeignKey(this IMigrationBuilder builder,
            string keyName,
            string dependentTable,
            IEnumerable<string> dependentColumns,
            string principalTable,
            IEnumerable<string> principalColumns,
            string dependentSchema = null,
            string dependentCatalog = null,
            string principalCatalog = null,
            string principalSchema = null,
            
            CascadeRule onUpdate = CascadeRule.None,
            CascadeRule onDelete = CascadeRule.None)
        {
            var op = new CreateForeignKeyConstraintOperation
            {
                Name = new SubObjectName(dependentCatalog, dependentSchema, dependentTable, keyName),
                PrincipalTable = new ObjectName { Catalog = principalCatalog ?? dependentCatalog, Schema = principalSchema ?? dependentSchema, Name = principalTable },
                
                OnDelete = onDelete,
                OnUpdate = onUpdate,
                DependentColumns = dependentColumns.Select(x => new ConstraintColumnDefinition { Column = x }).ToList(),
                PrincipalColumns = principalColumns.Select(x => new ConstraintColumnDefinition { Column = x }).ToList(),
            };

            builder.AddOperation(op);
            return new OperationBuilderSurface<CreateForeignKeyConstraintOperation>(op);
        }
    }
}