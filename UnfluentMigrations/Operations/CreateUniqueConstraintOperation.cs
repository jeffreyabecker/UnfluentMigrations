namespace UnfluentMigrations.Operations
{
    public class CreateUniqueConstraintOperation : CreateConstraintOperation
    {
        
        public override IMigrationOperation Reverse()
        {
            return new DropUniqueConstraintOperation {Name = Name, Columns =  Columns, Decorations = Decorations};
        }
    }
}