using UnfluentMigrations.Operations;

namespace UnfluentMigrations.Builders
{
    public class OperationBuilderSurface<TOperation> where TOperation : IMigrationOperation 
    {
        public OperationBuilderSurface(TOperation operation)
        {
            Operation = operation;
        }
        public TOperation Operation { get; }
    }
}