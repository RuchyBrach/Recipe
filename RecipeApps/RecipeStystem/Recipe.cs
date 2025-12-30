using System.Data;
using System.Data.SqlClient;

namespace RecipeStystem
{
    public class Recipe 
    {
        public static DataTable SearchRecipe(string recipename)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeGet");
            SQLUtility.SetParamValue(cmd, "@RecipeName", recipename);
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable Load(int recipeid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeGet");
            SQLUtility.SetParamValue(cmd, "@RecipeId", recipeid);
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetUserList(bool includeblank = false)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("HHUserGet");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            SQLUtility.SetParamValue(cmd, "@IncludeBlank", includeblank);
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetCuisineList(bool includeblank = false)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("CuisineGet");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            SQLUtility.SetParamValue(cmd, "@IncludeBlank", includeblank);
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetRecipeList()
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeGet");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            SQLUtility.SetParamValue(cmd, "@IncludeBlank", 1);
            return SQLUtility.GetDataTable(cmd);
        }

        public static void Save(DataTable dtrecipe)
        {
            if(dtrecipe.Rows.Count == 0)
            {
                throw new Exception("Cannot call Recipe Save method because there are no rows in the table");
            }

            DataRow r = dtrecipe.Rows[0];
            SQLUtility.SaveDataRow(r, "RecipeUpdate");
        }

        public static void SaveStatus(DataTable dtrecipe)
        {
            DataRow r = dtrecipe.Rows[0];
            SQLUtility.SaveDataRow(r, "RecipeStatusUpdate");
        }

        public static void Delete(DataTable dtrecipe)
        {
            int id = (int)dtrecipe.Rows[0]["RecipeId"];
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeDelete");
            SQLUtility.SetParamValue(cmd, "@RecipeId", id);
            SQLUtility.ExecuteSQL(cmd);
        }

        public static DataTable LoadDirectionsByRecipeId(int recipeid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("DirectionGet");
            SQLUtility.SetParamValue(cmd, "@RecipeId", recipeid);
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable LoadIngredientsByRecipeId(int recipeid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeIngredientGet");
            SQLUtility.SetParamValue(cmd, "@RecipeId", recipeid);
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static int CloneRecipe(int baserecipeid)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeClone");
            SQLUtility.SetParamValue(cmd, "@BaseRecipeId", baserecipeid);
            SQLUtility.ExecuteSQL(cmd);
            int newRecipeId = (int)cmd.Parameters["@RecipeId"].Value;
            return newRecipeId;
        }

        
    }
}
