using System.Threading.Tasks;

namespace UnfluentMigrations.Dialects.DataAccess
{
    public interface ISqlExecutor
    {
        Task Execute(SqlStatement statement);
    }
}
