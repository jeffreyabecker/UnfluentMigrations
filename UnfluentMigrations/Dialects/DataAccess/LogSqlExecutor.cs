using System.IO;
using System.Threading.Tasks;

namespace UnfluentMigrations.Dialects.DataAccess
{
    public class LogSqlExecutor : ISqlExecutor
    {
        private readonly TextWriter _tw;
        private readonly ISqlLogRenderer _renderer;

        public LogSqlExecutor(TextWriter tw, ISqlLogRenderer renderer)
        {
            _tw = tw;
            _renderer = renderer;
        }
        public Task Execute(SqlStatement statement)
        {
            return _renderer.WriteToLog(statement, _tw);
        }
    }
}