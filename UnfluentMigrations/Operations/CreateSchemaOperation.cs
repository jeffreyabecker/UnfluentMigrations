using System;
using System.Collections.Generic;
using UnfluentMigrations.Operations.Model;


namespace UnfluentMigrations.Operations
{
    public class CreateSchemaOperation : MigrationOperationBase
    {
        public ObjectName Name { get; set; }


        public override IMigrationOperation Reverse()
        {
            return new DropSchemaOperation { Name = Name };
        }

    }
}
