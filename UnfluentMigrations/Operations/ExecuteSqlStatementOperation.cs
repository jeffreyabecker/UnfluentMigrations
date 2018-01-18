
using UnfluentMigrations.Dialects.DataAccess;


namespace UnfluentMigrations.Operations
{
    public class ExecuteSqlStatementOperation : MigrationOperationBase
    {
        public virtual SqlStatement SqlStatement { get; set; }



        public override string ToString()
        {
            return base.ToString() + SqlStatement;
        }
    }
}
