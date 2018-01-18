using System.Collections.Generic;
using UnfluentMigrations.Operations.Model;

namespace UnfluentMigrations.Operations
{
    public class DropDefaultConstratintOperation : DropConstraintOperation
    {
        public new virtual ICollection<DefaultConstraintColumnDefinition> Columns { get; set; } = new List<DefaultConstraintColumnDefinition>();
        public override IMigrationOperation Reverse()
        {
            return new DropDefaultConstratintOperation { Name = Name, Columns = Columns, Decorations = Decorations };
        }
    }
}