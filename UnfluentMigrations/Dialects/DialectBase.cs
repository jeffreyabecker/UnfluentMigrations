using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnfluentMigrations.Dialects.DataAccess;
using UnfluentMigrations.Dialects.SqlConversion;

using UnfluentMigrations.Operations;
using UnfluentMigrations.Operations.Model;

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

            var result = new List<IOperationRenderer>();
            //result.Add(new AddColumnRenderer(this));
            //result.Add(new AddForeignKeyRenderer(this));
            //result.Add(new AlterColumnRenderer(this));
            //result.Add(new AlterSchemaRenderer(this));
            //result.Add(new CreateConstraintRenderer(this));
            //result.Add(new CreateIndexRenderer(this));
            //result.Add(new CreateSchemaRenderer(this));
            //result.Add(new CreateSequenceRenderer(this));
            //result.Add(new CreateTableRenderer(this));
            //result.Add(new DropColumnRenderer(this));
            //result.Add(new DropConstraintRenderer(this));
            //result.Add(new DropForeignKeyRenderer(this));
            //result.Add(new DropIndexRenderer(this));
            //result.Add(new DropSchemaRenderer(this));
            //result.Add(new DropSequenceRenderer(this));
            //result.Add(new DropTableRenderer(this));
            //result.Add(new ExecuteSqlStatementRenderer(this));
            //result.Add(new RenameColumnRenderer(this));
            //result.Add(new RenameTableRenderer(this));
            return result;

        }
        protected virtual string BeginQuote {get;} = "\"";
        protected virtual string EndQuote { get; } = "\"";



        protected virtual string Quote(string part)
        {
            part = part.Replace(BeginQuote, BeginQuote + BeginQuote);

            if (EndQuote != EndQuote)
            {
                part = part.Replace(EndQuote, EndQuote + EndQuote);
            }

            return BeginQuote + part + EndQuote;
        }
        public virtual string Quote(ObjectName name)
        {
            var parts = new[] { name.Catalog, name.Schema, name.Name }
                .Where(x => !String.IsNullOrEmpty(x))
                .Select(Quote);
            var quote1 = String.Join(".", parts);
            var quote = quote1;
            return quote;
        }

        public virtual string Quote(SubObjectName name)
        {
            var parts = new[] { name.Catalog, name.Schema, name.ParentName, name.Name }
                .Where(x => !String.IsNullOrEmpty(x))
                .Select(Quote);
            var quote1 = String.Join(".", parts);
            var quote = quote1;
            return quote;
        }

        public virtual ISqlExecutor CreateExecutor(DbConnection connection)
        {
            return new SqlExecutor(connection);
        }

        public abstract ISqlLogRenderer CreateLogRenderer();
        

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
