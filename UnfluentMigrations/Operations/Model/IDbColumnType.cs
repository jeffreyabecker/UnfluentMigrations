using System.Data;

namespace UnfluentMigrations.Operations.Model
{
    public interface IDbColumnType
    {

        DbType? UnderlyingType { get; }
        int? Size { get; set; }
        int? Precesion { get; set; }
    }
}
