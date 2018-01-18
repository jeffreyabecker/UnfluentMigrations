

using UnfluentMigrations.Operations.Model;

namespace UnfluentMigrations.Operations
{
    public class DropColumnOperation : MigrationOperationBase
    {
        public SubObjectName Name { get; set; }
    }
}