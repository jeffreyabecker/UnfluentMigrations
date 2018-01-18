namespace UnfluentMigrations.Operations
{
    public class DropUniqueConstraintOperation : DropConstraintOperation
    {
        
        public override IMigrationOperation Reverse()
        {
            return new CreateUniqueConstraintOperation { };
        }
    }
}