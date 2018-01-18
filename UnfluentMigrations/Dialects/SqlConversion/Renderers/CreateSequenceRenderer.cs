using System.Text;
using UnfluentMigrations.Operations;
using UnfluentMigrations.Operations.Model;

namespace UnfluentMigrations.Dialects.SqlConversion.Renderers
{
    public class CreateSequenceRenderer : OperationRenderer<CreateSequenceOperation>
    {
        private readonly IDialect _dialect;

        public CreateSequenceRenderer(IDialect dialect) { _dialect = dialect; }
        protected override string RenderSql(CreateSequenceOperation operation)
        {
            var sb = new StringBuilder();
            sb.Append("CREATE SEQUENCE ")
                .Append(_dialect.Quote(operation.Name));
            RenderAsComponent(sb, operation);
            RenderStartWith(sb, operation);
            RenderIncrement(sb, operation);
            RenderMinValue(sb, operation);
            RenderMaxValue(sb, operation);
            RenderCycle(sb, operation);
            RenderCache(sb, operation);
            
            return sb.ToString();
        }

        protected virtual void RenderCache(StringBuilder sb, CreateSequenceOperation operation)
        {
            if (operation.Cache.HasValue)
            {
                sb.AppendFormat(" CACHE {0}", operation.Cache);
            }
        }

        protected virtual void RenderCycle(StringBuilder sb, CreateSequenceOperation operation)
        {
            if (operation.Cycle)
            {
                sb.Append(" CYCLE");
            }
        }

        protected virtual void RenderMaxValue(StringBuilder sb, CreateSequenceOperation operation)
        {
            if (operation.MaxValue.HasValue)
            {
                sb.AppendFormat(" MaxVALUE {0}", operation.MaxValue);
            }
        }

        protected virtual void RenderMinValue(StringBuilder sb, CreateSequenceOperation operation)
        {
            if (operation.MinValue.HasValue)
            {
                sb.AppendFormat(" MINVALUE {0}", operation.MinValue);
            }
        }

        protected virtual void RenderIncrement(StringBuilder sb, CreateSequenceOperation operation)
        {
            if (operation.Increment.HasValue)
            {
                sb.AppendFormat(" INCREMENT BY {0}", operation.Increment);
            }
        }

        protected virtual void RenderStartWith(StringBuilder sb, CreateSequenceOperation operation)
        {
            if (operation.StartWith != null)
            {
                sb.AppendFormat(" START WITH {0}", operation.StartWith);
            }
        }


        protected virtual void RenderAsComponent(StringBuilder sb, CreateSequenceOperation operation)
        {
            
            sb.Append(" AS ");
            sb.Append(_dialect.RenderDbType(operation.DbType.AsDbColumnType()));
        }
    }
}
