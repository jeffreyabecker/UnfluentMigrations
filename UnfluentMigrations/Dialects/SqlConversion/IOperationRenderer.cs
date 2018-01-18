using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using JetBrains.Annotations;
using UnfluentMigrations.Dialects.DataAccess;
using UnfluentMigrations.Operations;

namespace UnfluentMigrations.Dialects.SqlConversion
{
    public interface IOperationRenderer
    {
        bool CanRender (IMigrationOperation operation);

        SqlStatement Render(IMigrationOperation operation);
    }

    public abstract class OperationRenderer<TOperation> : IOperationRenderer where TOperation : IMigrationOperation
    {
        public bool CanRender(IMigrationOperation operation)
        {
            if (operation == null) return false;
            return typeof(TOperation).GetTypeInfo().IsAssignableFrom(operation.GetType());
        }

        public virtual SqlStatement Render(IMigrationOperation operation)
        {
            return Render((TOperation) operation);
        }

        protected virtual SqlStatement Render(TOperation operation)
        {
            return new SqlStatement
            {
                Sql = RenderSql(operation),
                Parameters = RenderParameters(operation)
            };
        }

        protected abstract string RenderSql(TOperation operation);

        protected ICollection<SqlParameter> RenderParameters(TOperation operation)
        {
            return new List<SqlParameter>();
        }
    }
}
