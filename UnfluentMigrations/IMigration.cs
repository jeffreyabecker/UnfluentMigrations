using System;
using System.Collections.Generic;
using UnfluentMigrations.Operations;

namespace UnfluentMigrations
{
    public interface IMigration<out TMigrationKey> where TMigrationKey : IComparable<TMigrationKey>
    {
        TMigrationKey Key { get;  }
        IEnumerable<IMigrationOperation> UpExpressions { get; }
        IEnumerable<IMigrationOperation> DownExpressions { get; }
        
    }
}