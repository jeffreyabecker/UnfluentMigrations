using System.Threading.Tasks;

namespace UnfluentMigrations.Dialects.DataAccess
{
    public class CompositeExecutor : ISqlExecutor
    {
        private readonly ISqlExecutor _a;
        private readonly ISqlExecutor _b;

        public CompositeExecutor(ISqlExecutor a, ISqlExecutor b)
        {
            _a = a;
            _b = b;
        }
        public Task Execute(SqlStatement statement)
        {
            return _a.Execute(statement)
                .ContinueWith(x => _b.Execute(statement));
        }
    }
}