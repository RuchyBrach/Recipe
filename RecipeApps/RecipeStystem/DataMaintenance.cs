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

        public static DataTable GetDataList(string tablename, bool includeblank = false)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(tablename + "Get");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            if(includeblank == true)
            {
                SQLUtility.SetParamValue(cmd, "@IncludeBlank", includeblank);
            }
            return SQLUtility.GetDataTable(cmd);
        }

        public static DataTable GetRecipeList()
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeGet");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            return SQLUtility.GetDataTable(cmd);
        }

        public static DataTable GetCookBookList()
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("CookBookGet");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            return SQLUtility.GetDataTable(cmd);
        }

        public static DataTable GetMealList()
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("MealListGet");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            return SQLUtility.GetDataTable(cmd);
        }

        public static void DeleteRow(string tablename, int id)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(tablename + "Delete");
            SQLUtility.SetParamValue(cmd, $"@{tablename}Id", id);
            SQLUtility.ExecuteSQL(cmd);
        }

        public static void SaveDataList(DataTable dtlist, string tablename)
        {
            SQLUtility.SaveDataTable(dtlist, tablename + "Update");
        }
    }
}
