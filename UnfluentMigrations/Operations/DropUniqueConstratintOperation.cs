namespace UnfluentMigrations.Operations
{
    public class DropUniqueConstratintOperation : DropConstraintOperation
    {
        
        public override IMigrationOperation Reverse()
        {
            return new CreateUniqueConstratintOperation { };
        }
    }
}