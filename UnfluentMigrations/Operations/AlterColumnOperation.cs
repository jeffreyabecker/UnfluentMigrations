

using System;
using System.Collections.Generic;

using UnfluentMigrations.Operations;
using UnfluentMigrations.Operations.Model;

namespace UnfluentMigrations.Operations
{
    public class AlterColumnOperation : MigrationOperationBase
    {
        public virtual ColumnDefinition Column { get; set; }


    }
}
