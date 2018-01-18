using System.Collections.Generic;
using UnfluentMigrations.Operations.Model;

namespace UnfluentMigrations.Operations
{
    public class CreateCheckConstraintOperation : CreateConstraintOperation
    {
        public new virtual ICollection<CheckConstraintColumnDefinition> Columns { get; set; } = new List<CheckConstraintColumnDefinition>();
        public override IMigrationOperation Reverse()
        {
            return new DropCheckConstraintOperation { Name = Name, Columns = Columns, Decorations =  Decorations};
        }
    }
}