using System.Data;

namespace UnfluentMigrations.Operations.Model
{
    public interface IDbColumnType
    {

        DbType? UnderlyingType { get; }
        int? Size { get; set; }
        int? Precision { get; set; }
        string ExplicitStoreType { get; set; }
    }

    public static class DbTypeExtensions
    {
        public static IDbColumnType AsDbColumnType(this DbType underlyingType, int? size = null, int? precision = null,
            string explicitStoreType = null)
        {
            return new BasicDbColumnType
            {
                UnderlyingType = underlyingType,
                Size = size,
                Precision = precision,
                ExplicitStoreType = explicitStoreType

            };
        }
    }
}
