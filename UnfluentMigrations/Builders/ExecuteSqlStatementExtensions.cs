using System.Linq;
using UnfluentMigrations.Dialects.DataAccess;
using UnfluentMigrations.Operations;

namespace UnfluentMigrations.Builders
{
    public static class ExecuteSqlStatementExtensions
    {
        public static OperationBuilderSurface<ExecuteSqlStatementOperation> ExecuteSqlStatement(this IMigrationBuilder builder, string sql, params SqlParameter[] sqlParameters)
        {
            var op = new ExecuteSqlStatementOperation
            {
                SqlStatement =  new SqlStatement
                {
                    Sql = sql,
                    Parameters = (sqlParameters?? new SqlParameter[0]).ToList()
                }
            };
            builder.AddOperation(op);
            return new OperationBuilderSurface<ExecuteSqlStatementOperation>(op);
        }
    }
}