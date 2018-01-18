using System.Collections.Generic;
using UnfluentMigrations.Operations.Model;

namespace UnfluentMigrations.Operations
{
    public class CreateForeignKeyConstraintOperation : CreateConstraintOperation
    {

        public ObjectName DependentTable => Name.ParentObjectName;
        public ObjectName PrincipalTable { get; set; }
        public CascadeRule OnDelete { get; set; }
        public CascadeRule OnUpdate { get; set; }
        public ICollection<ConstraintColumnDefinition> DependentColumns { get; set; } = new List<ConstraintColumnDefinition>();
        public ICollection<ConstraintColumnDefinition> PrincipalColumns { get; set; } = new List<ConstraintColumnDefinition>();

        public override IMigrationOperation Reverse()
        {
            return new DropForeignKeyConstraintOperation
            {
                Name = Name,
                PrincipalTable = PrincipalTable,
                OnDelete = OnDelete,
                OnUpdate = OnUpdate,
                Decorations = Decorations,
                DependentColumns = DependentColumns,
                PrincipalColumns = PrincipalColumns
            };
        }

    }
}