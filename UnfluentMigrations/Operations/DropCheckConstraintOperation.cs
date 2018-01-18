using System.Collections.Generic;
using UnfluentMigrations.Operations.Model;

namespace UnfluentMigrations.Operations
{
    public class DropCheckConstraintOperation : DropConstraintOperation
    {
        public new virtual ICollection<CheckConstraintColumnDefinition> Columns { get; set; } = new List<CheckConstraintColumnDefinition>();
        public override IMigrationOperation Reverse()
        {
            return new CreateCheckConstraintOperation { Name = Name, Columns = Columns, Decorations = Decorations };
        }
    }
}