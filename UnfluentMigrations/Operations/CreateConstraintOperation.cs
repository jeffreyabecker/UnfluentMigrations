
using System.Collections.Generic;
using UnfluentMigrations.Operations.Model;

namespace UnfluentMigrations.Operations
{
    
    public abstract class CreateConstraintOperation : MigrationOperationBase, IDecoratable
    {
        public SubObjectName Name { get; set; }
        public Dictionary<string, object> Decorations { get; set; } = new Dictionary<string, object>();
        public virtual ICollection<ConstraintColumnDefinition> Columns { get; set; } = new List<ConstraintColumnDefinition>();
    }

    public class CreatePrimaryKeyConstraintOperation : CreateConstraintOperation
    {
        
        public override IMigrationOperation Reverse()
        {
            return new DropPrimaryKeyConstraintOperation {Name = Name};
        }
    }

    public class CreateUniqueConstratintOperation : CreateConstraintOperation
    {
        
        public override IMigrationOperation Reverse()
        {
            return new DropUniqueConstratintOperation {Name = Name, Columns =  Columns, Decorations = Decorations};
        }
    }

    public class CreateCheckConstraintOperation : CreateConstraintOperation
    {
        public new virtual ICollection<CheckConstraintColumnDefinition> Columns { get; set; } = new List<CheckConstraintColumnDefinition>();
        public override IMigrationOperation Reverse()
        {
            return new DropCheckConstraintOperation { Name = Name, Columns = Columns, Decorations =  Decorations};
        }
    }

    public class CreateDefaultConstratintOperation : CreateConstraintOperation
    {
        public new virtual ICollection<DefaultConstraintColumnDefinition> Columns { get; set; } = new List<DefaultConstraintColumnDefinition>();
        public override IMigrationOperation Reverse()
        {
            return new DropDefaultConstratintOperation { Name = Name, Decorations = Decorations, Columns = Columns};
        }
    }
}
