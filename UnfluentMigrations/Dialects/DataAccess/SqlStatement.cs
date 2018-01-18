using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace UnfluentMigrations.Dialects.DataAccess
{
    public class SqlStatement
    {
        public string Sql { get; set; }
        public ICollection<SqlParameter> Parameters { get; set; } = new List<SqlParameter>();
        public IDictionary<string, object> AdditionalFeatures { get; } = new Dictionary<string, object>();

    }
}