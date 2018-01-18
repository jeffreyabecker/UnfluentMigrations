namespace UnfluentMigrations.Operations
{
    public class CreateUniqueConstratintOperation : CreateConstraintOperation
    {
        
        public override IMigrationOperation Reverse()
        {
            return new DropUniqueConstratintOperation {Name = Name, Columns =  Columns, Decorations = Decorations};
        }
    }
}