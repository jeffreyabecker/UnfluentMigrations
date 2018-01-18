using System.Collections.Generic;
using UnfluentMigrations.Operations;

namespace UnfluentMigrations.Builders
{
    public class MigrationBuilder : IMigrationBuilder
    {
        private readonly List<IMigrationOperation> _operations = new List<IMigrationOperation>();
        public IEnumerable<IMigrationOperation> GetOperations()
        {
            return _operations;
        }

        public void AddOperation(IMigrationOperation operation)
        {
            _operations.Add(operation);
        }
    }
}