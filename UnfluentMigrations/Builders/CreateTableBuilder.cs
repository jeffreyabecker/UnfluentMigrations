using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using UnfluentMigrations.Operations;
using UnfluentMigrations.Operations.Model;

namespace UnfluentMigrations.Builders
{
    public class CreateTableBuilder<TColumns>
    {
        private readonly TColumns _instance;
        private readonly CreateTableOperation _operation;

        public CreateTableBuilder(TColumns instance, CreateTableOperation operation)
        {
            _instance = instance;
            _operation = operation;
        }
        public OperationBuilderSurface<CreatePrimaryKeyConstraintOperation>
            PrimaryKey<TKeyColumns>(string name, Func<TColumns, TKeyColumns> columns)
        {
            var keyCols = columns(_instance);
            var cols = typeof(TKeyColumns).GetRuntimeProperties()
                .Where(p => p.CanRead)
                .Select(p =>
                    new
                    {
                        Name = p.Name,
                        Value = p.GetValue(keyCols)
                    })
                .Where(x => x.Value != null)
                .Select(x =>
                {
                    if (x.Value is ConstraintColumnDefinition definition)
                    {
                        definition.Column = x.Name;
                        return definition;
                    }
                    else if (x.Value is ColumnDefinition def)
                    {
                        return new ConstraintColumnDefinition
                        {
                            Column = def.Name.Name,
                        };
                    }
                    else return null;
                }).ToList();

            var res = new CreatePrimaryKeyConstraintOperation
            {
                Name = _operation.Name.MakeSubObjectName(name),
                Columns = cols
            };
            _operation.Constraints.Add(res);
            return new OperationBuilderSurface<CreatePrimaryKeyConstraintOperation>(res);
        }

        public OperationBuilderSurface<CreatePrimaryKeyConstraintOperation> PrimaryKey(string name,
            Func<TColumns, ColumnDefinition> column, SortDirection direction = SortDirection.Asc)
        {
            var col = column(_instance);
            var res = new CreatePrimaryKeyConstraintOperation
            {
                Name = _operation.Name.MakeSubObjectName(name),
                Columns = new List<ConstraintColumnDefinition> {new ConstraintColumnDefinition {Column = col.Name.Name, Direction = direction}}
            };
            _operation.Constraints.Add(res);
            return new OperationBuilderSurface<CreatePrimaryKeyConstraintOperation>(res);
        }
        public OperationBuilderSurface<CreateForeignKeyConstraintOperation> ForeignKey(string name,
            Func<TColumns, IEnumerable<ConstraintColumnDefinition>> dependentColumns, string principalTable,
            string principalSchema = null, string principalCatalog = null,
            IEnumerable<string> principalColumns = null,
            CascadeRule onUpdate = CascadeRule.None,
            CascadeRule onDelete = CascadeRule.None)
        {
            var constraintColumnDefinitions = dependentColumns(_instance).ToList();
            principalColumns = principalColumns ?? constraintColumnDefinitions.Select(x => x.Column);
            var op = new CreateForeignKeyConstraintOperation
            {
                Name = _operation.Name.MakeSubObjectName(name),
                PrincipalTable = new ObjectName { Catalog = principalCatalog ?? _operation.Name.Catalog, Schema = principalSchema ?? _operation.Name.Schema, Name = principalTable },

                OnDelete = onDelete,
                OnUpdate = onUpdate,
                DependentColumns = constraintColumnDefinitions,
                PrincipalColumns = principalColumns.Select(x => new ConstraintColumnDefinition { Column = x }).ToList(),
            };

            _operation.Constraints.Add(op);
            return new OperationBuilderSurface<CreateForeignKeyConstraintOperation>(op);
        }
    }
}