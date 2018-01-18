using System.Collections.Generic;
using UnfluentMigrations.Operations.Model;

namespace UnfluentMigrations.Operations
{
    public class CreateDefaultConstraintOperation : CreateConstraintOperation
    {
        public new virtual ICollection<DefaultConstraintColumnDefinition> Columns { get; set; } = new List<DefaultConstraintColumnDefinition>();
        public override IMigrationOperation Reverse()
        {
            return new DropDefaultConstraintOperation { Name = Name, Decorations = Decorations, Columns = Columns};
        }
    }
}