using System.Data;
using UnfluentMigrations.Operations.Model;

namespace UnfluentMigrations.Operations
{
    using System.Collections.Generic;

    public class CreateSequenceOperation : MigrationOperationBase
    {
 

        public virtual ObjectName Name { get; set; }

        public virtual long? Increment { get; set; }

        public virtual long? MinValue { get; set; }
        public virtual long? MaxValue { get; set; }

        public virtual long? StartWith { get; set; }



        public virtual bool Cycle { get; set; }
        public DbType DbType { get; set; }
        public int? Cache { get; set; }
    }
}