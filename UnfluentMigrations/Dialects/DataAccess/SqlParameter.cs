using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace UnfluentMigrations.Dialects.DataAccess
{
    public class SqlParameter
    {
        public DbType DbType { get; set; }
        public string ParameterName { get; set; }
        public object Value { get; set; }
        public int Size { get; set; }

        public IDictionary<string, object> AdditionalFeatures { get; } = new Dictionary<string, object>();

    }
}
