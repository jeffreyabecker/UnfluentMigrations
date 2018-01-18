
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
}
