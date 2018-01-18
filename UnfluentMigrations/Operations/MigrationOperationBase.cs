
using System;


namespace UnfluentMigrations.Operations
{
    public abstract class MigrationOperationBase : IMigrationOperation
    {


        public virtual IMigrationOperation Reverse()
        {
            throw new NotSupportedException(String.Format("The {0} cannot be automatically reversed", GetType().Name));
        }


  
    }
}
