
using System.Collections.Generic;
using UnfluentMigrations.Operations.Model;

namespace UnfluentMigrations.Operations
{
    
    public abstract class DropConstraintOperation : MigrationOperationBase, IDecoratable
    {
        public SubObjectName Name { get; set; }
        public Dictionary<string, object> Decorations { get; set; } = new Dictionary<string, object>();
        public virtual ICollection<ConstraintColumnDefinition> Columns { get; set; } = new List<ConstraintColumnDefinition>();
    }

    public class DropPrimaryKeyConstraintOperation : DropConstraintOperation
    {
        public SubObjectName Name { get; set; }
    
    }

    public class DropUniqueConstratintOperation : DropConstraintOperation
    {
        
        public override IMigrationOperation Reverse()
        {
            return new CreateUniqueConstratintOperation { };
        }
    }

    public class DropCheckConstraintOperation : DropConstraintOperation
    {
        public new virtual ICollection<CheckConstraintColumnDefinition> Columns { get; set; } = new List<CheckConstraintColumnDefinition>();
        public override IMigrationOperation Reverse()
        {
            return new CreateCheckConstraintOperation { Name = Name, Columns = Columns, Decorations = Decorations };
        }
    }

    public class DropDefaultConstratintOperation : DropConstraintOperation
    {
        public new virtual ICollection<DefaultConstraintColumnDefinition> Columns { get; set; } = new List<DefaultConstraintColumnDefinition>();
        public override IMigrationOperation Reverse()
        {
            return new DropDefaultConstratintOperation { Name = Name, Columns = Columns, Decorations = Decorations };
        }
    }
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
