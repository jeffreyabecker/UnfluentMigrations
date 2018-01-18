

using System.Collections.Generic;
using UnfluentMigrations.Operations.Model;

namespace UnfluentMigrations.Operations
{
    public class CreateIndexOperation : MigrationOperationBase, IDecoratable
    {
        public SubObjectName Name { get; set; }


        public virtual ICollection<IndexColumnDefinition> Columns { get; set; }
        public virtual ICollection<IndexColumnDefinition> Includes { get; set; }
        public virtual string Filter { get; set; }
        public bool Unique { get; set; } = false;

        public Dictionary<string, object> Decorations { get; set; } = new Dictionary<string, object>();


        public override IMigrationOperation Reverse()
        {
            return new DropIndexOperation { Name = Name };
        }


    }
}