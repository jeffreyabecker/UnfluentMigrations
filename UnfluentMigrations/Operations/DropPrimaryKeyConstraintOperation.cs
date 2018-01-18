using UnfluentMigrations.Operations.Model;

namespace UnfluentMigrations.Operations
{
    public class DropPrimaryKeyConstraintOperation : DropConstraintOperation
    {
        public SubObjectName Name { get; set; }
    
    }
}