using UnfluentMigrations.Operations.Model;

namespace UnfluentMigrations.Builders
{
    public static class DecorationExtensions
    {
        public static T Decoration<T>(this T instance, string key, object value) where T : IDecoratable
        {
            instance.Decorations[key] = value;
            return instance;
        }
    }
}