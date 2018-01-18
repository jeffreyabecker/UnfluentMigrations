using System;
using System.Collections.Generic;
using System.Text;

namespace UnfluentMigrations.Operations
{
    public interface IMigrationOperation
    {
        IMigrationOperation Reverse();
    }
}
