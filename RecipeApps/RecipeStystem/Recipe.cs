using System.Data;
using System.Data.SqlClient;

namespace RecipeStystem
{
    public class Recipe
    {
        public static DataTable GetUsernameList()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("HHUserGet");
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetCuisineList()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("CuisineGet");
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
        public static DataTable SearchRecipe(string recipename)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeGet");
            cmd.Parameters["@RecipeName"].Value = recipename;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable Load(int recipeid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static void Save(DataTable dtrecipe)
        {
            DataRow r = dtrecipe.Rows[0];
            int id = (int)r["RecipeId"];
            string sql = "";
            if (id > 0)
            {
                sql = string.Join(Environment.NewLine, $"update Recipe set",
                    $"RecipeName = '{r["RecipeName"]}',",
                    $"Calories = '{r["Calories"]}',",
                    $"DateTimeDraft = '{r["DateTimeDraft"]}'",
                    //$"{CheckForNull(r["DateTimePublished"], r, "DateTimePublished")}",
                    //$"{CheckForNull(r["DateTimeArchived"], r, "DateTimeArchived")}",
                    $"where RecipeId = {r["RecipeId"]}");
            }
            else
            {
                sql = "insert Recipe(HHUserId, CuisineId, RecipeName, Calories, DateTimeDraft)";
                sql += $"select '{r["HHUserId"]}', '{r["CuisineId"]}', '{r["RecipeName"]}', '{r["Calories"]}', '{r["DateTimeDraft"]}'";
            }
            SQLUtility.ExecuteSQL(sql);
        }

        public static void Delete(DataTable dtrecipe)
        {
            int id = (int)dtrecipe.Rows[0]["RecipeId"];
            string sql = "delete Recipe where RecipeId = " + id;
            SQLUtility.ExecuteSQL(sql);
        }
    }
}
