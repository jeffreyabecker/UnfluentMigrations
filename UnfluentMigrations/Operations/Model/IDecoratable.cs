using System.Collections.Generic;

namespace UnfluentMigrations.Operations.Model
{
    public interface IDecoratable
    {
        Dictionary<string, object> Decorations { get;}
    }
}