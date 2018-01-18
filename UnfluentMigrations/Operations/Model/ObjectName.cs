namespace UnfluentMigrations.Operations.Model
{
    public class ObjectName
    {
        public ObjectName() { }

        public ObjectName(string catalog, string schema, string name)
        {
            Catalog = catalog;
            Schema = schema;
            Name = name;
        }
        public string Catalog { get; set; }
        public string Schema { get; set; }
        public string Name { get; set; }

        public SubObjectName MakeSubObjectName(string subName)
        {
            return new SubObjectName(Catalog, Schema,Name, subName);
        }
    }
}
