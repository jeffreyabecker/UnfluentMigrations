
using UnfluentMigrations.Operations.Model;

namespace UnfluentMigrations.Operations
{
    public class RenameTableOperation : MigrationOperationBase
    {
        public virtual ObjectName OldName { get; set; }
        public virtual ObjectName NewName { get; set; }


        public override IMigrationOperation Reverse()
        {
            return new RenameTableOperation { NewName = OldName, OldName = NewName };
        }


    }
}