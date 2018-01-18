namespace UnfluentMigrations.Operations.Model
{
    public class SubObjectName  
    {
        public SubObjectName() { }

        public SubObjectName(string catalog, string schema, string parentName, string name)
        {
            Catalog = catalog;
            Schema = schema;
            ParentName = parentName;
            Name = name;
        }
        public string Catalog { get; set; }
        public string Schema { get; set; }
        public string Name { get; set; }
        public string ParentName { get; set; }
        public ObjectName ParentObjectName => new ObjectName(Catalog, Schema, ParentName);
    }
}