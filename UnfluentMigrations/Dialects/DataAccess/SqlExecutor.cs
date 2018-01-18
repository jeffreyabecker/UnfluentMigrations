using System.Data;
using System.Data.Common;
using System.Threading.Tasks;

namespace UnfluentMigrations.Dialects.DataAccess
{
    public class SqlExecutor : ISqlExecutor
    {
        private readonly DbConnection _connection;

        public SqlExecutor(DbConnection connection)
        {
            _connection = connection;
        }

        public  async Task Execute(SqlStatement statement)
        {
            if (_connection.State != ConnectionState.Open)
            {
                await _connection.OpenAsync();
            }
            using (var cmd = _connection.CreateCommand())
            {
                cmd.CommandText = statement.Sql;
                foreach (var p in statement.Parameters)
                {
                    var cp = cmd.CreateParameter();
                    cp.ParameterName = p.ParameterName;
                    cp.DbType = p.DbType;
                    cp.Size = p.Size;
                    cp.Value = p.Value;
                    cmd.Parameters.Add(cp);
                }
                await cmd.ExecuteNonQueryAsync();
            }
        }
    }
}