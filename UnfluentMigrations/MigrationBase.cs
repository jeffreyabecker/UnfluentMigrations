using System;
using System.Collections.Generic;
using UnfluentMigrations.Builders;
using UnfluentMigrations.Operations;

namespace UnfluentMigrations
{
    public abstract class MigrationBase<TKey> : IMigration<TKey> where TKey : IComparable<TKey>
    {
        protected MigrationBase(TKey key)
        {
            Key = key;
        }
        public TKey Key { get; private set; }
        public IEnumerable<IMigrationOperation> UpExpressions
        {
            get
            {
                IMigrationBuilder builder = new MigrationBuilder();
                MigrateUp(builder);
                return builder.GetOperations();
            }
        }



        public IEnumerable<IMigrationOperation> DownExpressions
        {
            get
            {
                IMigrationBuilder builder = new MigrationBuilder();
                MigrateDown(builder);
                return builder.GetOperations();
            }
        }



        protected abstract void MigrateUp(IMigrationBuilder builder);

        protected abstract void MigrateDown(IMigrationBuilder builder);
    }
}