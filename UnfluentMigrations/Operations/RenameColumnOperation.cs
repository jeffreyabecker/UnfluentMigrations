
using UnfluentMigrations.Operations.Model;

namespace UnfluentMigrations.Operations
{
    public class RenameColumnOperation : MigrationOperationBase
    {
        public SubObjectName OldName { get; set; }
        public SubObjectName NewName { get; set; }


        public override IMigrationOperation Reverse()
        {
            return new RenameColumnOperation { OldName = NewName, NewName =  OldName};
        }


    }
}