
using UnfluentMigrations.Operations.Model;

namespace UnfluentMigrations.Operations
{
    public class DropSchemaOperation : MigrationOperationBase
    {
        public virtual ObjectName Name { get; set; }
    }
}