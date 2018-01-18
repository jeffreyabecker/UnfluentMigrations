namespace UnfluentMigrations.Operations
{
    public class CreatePrimaryKeyConstraintOperation : CreateConstraintOperation
    {
        
        public override IMigrationOperation Reverse()
        {
            return new DropPrimaryKeyConstraintOperation {Name = Name};
        }
    }
}