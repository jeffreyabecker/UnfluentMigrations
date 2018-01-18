
using System;
using System.Collections.Generic;
using System.Text;
using UnfluentMigrations.Operations.Model;

namespace UnfluentMigrations.Operations
{
    public class AddColumnOperation : MigrationOperationBase
    {

        public virtual ColumnDefinition Column { get; set; }

 

        public override IMigrationOperation Reverse()
        {
            SubObjectName tempQualifier = Column.Name;
            return new DropColumnOperation
                    {
                        Name = new SubObjectName
                        {
                            Catalog = tempQualifier.Catalog,
                            Name = tempQualifier.Name,
                            ParentName = tempQualifier.ParentName,
                            Schema = tempQualifier.Schema
                        },
                    };
        }


    }
}