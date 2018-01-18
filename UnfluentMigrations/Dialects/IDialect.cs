using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Threading.Tasks;
using UnfluentMigrations.Dialects.DataAccess;
using UnfluentMigrations.Operations;
using UnfluentMigrations.Operations.Model;

namespace UnfluentMigrations.Dialects
{
    /// <summary>
    /// Converts Expressions into SqlStatements
    /// </summary>
    public interface IDialect
    {
        ISqlExecutor CreateExecutor(DbConnection connection);
        ISqlLogRenderer CreateLogRenderer();
        Task Execute(IEnumerable<IMigrationOperation> expressions, ISqlExecutor executor);

        string Quote(ObjectName name);
        string Quote(SubObjectName name);
        string RenderDbType(IDbColumnType operationDbType);
    }

    public interface ISqlLogRenderer
    {
        Task WriteToLog(SqlStatement statement, TextWriter log);
    }
    
}