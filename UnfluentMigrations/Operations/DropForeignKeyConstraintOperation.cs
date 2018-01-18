using System.Collections.Generic;
using UnfluentMigrations.Operations.Model;

namespace UnfluentMigrations.Operations
{
    public class DropForeignKeyConstraintOperation : DropConstraintOperation
    {


        public ObjectName PrincipalTable { get; set; }
        public CascadeRule OnDelete { get; set; }
        public CascadeRule OnUpdate { get; set; }
        public ICollection<ConstraintColumnDefinition> DependentColumns { get; set; } = new List<ConstraintColumnDefinition>();
        public ICollection<ConstraintColumnDefinition> PrincipalColumns { get; set; } = new List<ConstraintColumnDefinition>();

        public override IMigrationOperation Reverse()
        {
            return new CreateForeignKeyConstraintOperation { Name = Name, Columns = Columns, Decorations = Decorations };
        }

    }
}