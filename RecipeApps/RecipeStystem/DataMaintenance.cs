using System.Data;
using System.Data.SqlClient;

namespace RecipeSystem
{
    public static class DataMaintenance
    {
        public static DataTable GetRecipeDashboard()
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeDashboardGet");
            return SQLUtility.GetDataTable(cmd);
        }
    }
}
