using System.Collections.Generic;
using System.Data;
using System.Text;
using UnfluentMigrations.Operations;

namespace UnfluentMigrations.Builders
{
    public interface IMigrationBuilder
    {
        IEnumerable<IMigrationOperation> GetOperations();
        void AddOperation(IMigrationOperation operation);
    }
}
