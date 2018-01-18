using System;
using System.Collections.Generic;
using UnfluentMigrations.Operations;

namespace UnfluentMigrations
{
    public interface IGeneratedMigration<TMigrationKey> : IMigration<TMigrationKey>
        where TMigrationKey : IComparable<TMigrationKey>
    {
        IEnumerable<IMigrationOperation> CurrentStateExpressions { get; }
    }
}