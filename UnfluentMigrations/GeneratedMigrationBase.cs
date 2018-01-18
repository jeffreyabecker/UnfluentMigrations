using System;
using System.Collections.Generic;
using UnfluentMigrations.Builders;
using UnfluentMigrations.Operations;

namespace UnfluentMigrations
{
    public abstract class GeneratedMigrationBase<TKey> : 
        MigrationBase<TKey>, IGeneratedMigration<TKey>
        where TKey : IComparable<TKey>
    {
        public IEnumerable<IMigrationOperation> CurrentStateExpressions
        {
            get
            {
                IMigrationBuilder builder = new MigrationBuilder();
                BuildCurrentState(builder);
                return builder.GetOperations();
            }
        }

        protected abstract void BuildCurrentState(IMigrationBuilder builder);

        protected GeneratedMigrationBase(TKey key) : base(key)
        {
        }
    }
}