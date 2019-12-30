namespace AgileInsights
{
    public class AgileInsightsConsts
    {
        public const string LocalizationSourceName = "AgileInsights";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;

        public static class MaxLengths
        {
            public const int DatabaseName = 50;
            public const int ConnectionString = 200;
            public const int TableName = 50;
            public const int ColumnName = 50;
            public const int MappedColumnName = 50;
        }

        public static class ColumnNames
        {
            public const string OrganizationId = "OrganizationId";
            public const string DepartmentId = "DepartmentId";
            public const string Earning = "Earning";
        }
    }
}
