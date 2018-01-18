namespace UnfluentMigrations.Operations.Model
{
    public enum CascadeRule
    {
        None = 0,
        Cascade = 1,
        SetDefault = 2,
        SetNull = 3,
        Restrict = 4,
    }
}