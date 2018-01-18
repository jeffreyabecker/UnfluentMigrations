using System.Data;

namespace UnfluentMigrations.Operations.Model
{
    public class BasicDbColumnType : IDbColumnType
    {


        public DbType? UnderlyingType { get; set; }
        public string ExplicitStoreType { get; set; }
        public int? Precision { get; set; }
        public int? Size { get; set; }
        public int? Precesion { get; set; }
    }


}