namespace UnfluentMigrations.Operations.Model
{
    public class ConstraintColumnDefinition
    {
        public string Column { get; set; }
        public SortDirection Direction { get; set; } = SortDirection.Asc;        
    }

    public class CheckConstraintColumnDefinition : ConstraintColumnDefinition
    {
        public string SqlExpression { get; set; }
    }

    public class DefaultConstraintColumnDefinition : ConstraintColumnDefinition
    {
        public string SqlDefaultValue { get; set; }
    }
}