
using System.Collections.Generic;
using UnfluentMigrations.Operations.Model;

namespace UnfluentMigrations.Operations
{
    public class CreateTableOperation : MigrationOperationBase
    {
        public ObjectName Name { get; set; }
        public virtual IList<ColumnDefinition> Columns { get; set; } = new List<ColumnDefinition>();
        public virtual string TableDescription { get; set; }


        public virtual IList<CreateConstraintOperation> Constraints { get; set; } = new List<CreateConstraintOperation>();
        public virtual IList<CreateIndexOperation> Indexes { get; set; } = new List<CreateIndexOperation>();



        public override IMigrationOperation Reverse()
        {
            return new DropTableOperation
                    {
                        Name = Name
            };
        }


    }
}