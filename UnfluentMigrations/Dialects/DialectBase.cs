using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnfluentMigrations.Dialects.DataAccess;
using UnfluentMigrations.Dialects.SqlConversion;
using UnfluentMigrations.Dialects.SqlConversion.Operations;
using UnfluentMigrations.Operations;

namespace UnfluentMigrations.Dialects
{
    public abstract class DialectBase : IDialect
    {
        protected readonly
            Lazy<List<IOperationRenderer>>
            Renderers;
    
        protected DialectBase()
        {
            Renderers = new Lazy<List<IOperationRenderer>>(()=> GenerateRenderers().ToList());
        }

        protected virtual List<IOperationRenderer> GenerateRenderers()
        {
            INameQuoter quoter = GenerateNameQuoter();
            var result = new List<IOperationRenderer>();
            result.Add(new AddColumnRenderer(quoter));
            result.Add(new AddForeignKeyRenderer(quoter));
            result.Add(new AlterColumnRenderer(quoter));
            result.Add(new AlterSchemaRenderer(quoter));
            result.Add(new CreateConstraintRenderer(quoter));
            result.Add(new CreateIndexRenderer(quoter));
            result.Add(new CreateSchemaRenderer(quoter));
            result.Add(new CreateSequenceRenderer(quoter));
            result.Add(new CreateTableRenderer(quoter));
            result.Add(new DropColumnRenderer(quoter));
            result.Add(new DropConstraintRenderer(quoter));
            result.Add(new DropForeignKeyRenderer(quoter));
            result.Add(new DropIndexRenderer(quoter));
            result.Add(new DropSchemaRenderer(quoter));
            result.Add(new DropSequenceRenderer(quoter));
            result.Add(new DropTableRenderer(quoter));
            result.Add(new ExecuteSqlStatementRenderer(quoter));
            result.Add(new RenameColumnRenderer(quoter));
            result.Add(new RenameTableRenderer(quoter));
            return result;

        }

        protected virtual INameQuoter GenerateNameQuoter()
        {
            return new NameQuoter();
        }

        public virtual ISqlExecutor CreateExecutor(DbConnection connection)
        {
            return new SqlExecutor(connection);
        }

        public async Task Execute(IEnumerable<IMigrationOperation> expressions, ISqlExecutor executor)
        {
            var statements = Render(expressions).ToList();
            foreach (var s in statements)
            {
                await executor.Execute(s);
            }
        }

        protected virtual IEnumerable<SqlStatement> Render(IEnumerable<IMigrationOperation> expressions)
        {
            foreach (var e in expressions)
            {
                var r = FindRenderer(e);
                yield return r.Render(e);
            }
        }

        protected virtual IOperationRenderer FindRenderer(IMigrationOperation migrationOperation)
        {
            return Renderers.Value.First(x => x.CanRender(migrationOperation));

        }
    }
}
