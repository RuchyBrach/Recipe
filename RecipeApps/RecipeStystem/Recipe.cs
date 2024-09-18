using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RecipeStystem
{
    public class Recipe
    {
        public static DataTable SearchRecipe(string recipename)
        {
            string sql = "select r.RecipeId, r.RecipeName, r.Calories, r.RecipeStatus from JustRecipe r where r.RecipeName like '%" + recipename + "%'";
            return SQLUtility.GetDataTable(sql);
        }

        public static DataTable Load(int recipeid)
        {
            string sql = "select * from JustRecipe r where r.RecipeId = " + recipeid.ToString();
            return SQLUtility.GetDataTable(sql);
        }

        public static void Save(DataTable dtrecipe)
        {
            DataRow r = dtrecipe.Rows[0];
            int id = (int)r["RecipeId"];
            string sql = "";
            if (id > 0)
            {
                sql = string.Join(Environment.NewLine, $"update JustRecipe set",
                    $"RecipeName = '{r["RecipeName"]}',",
                    $"Calories = '{r["Calories"]}',",
                    $"DateTimeDraft = '{r["DateTimeDraft"]}'",
                    //$"{CheckForNull(r["DateTimePublished"], r, "DateTimePublished")}",
                    //$"{CheckForNull(r["DateTimeArchived"], r, "DateTimeArchived")}",
                    $"where RecipeId = {r["RecipeId"]}");
            }
            else
            {
                sql = "insert JustRecipe(RecipeName, Calories, DateTimeDraft)";
                sql += $"select '{r["RecipeName"]}', '{r["Calories"]}', '{r["DateTimeDraft"]}'";
            }
            SQLUtility.ExecuteSQL(sql);
        }
        
        public static void Delete(DataTable dtrecipe)
        {
            int id = (int)dtrecipe.Rows[0]["RecipeId"];
            string sql = "delete JustRecipe where RecipeId = " + id;
            SQLUtility.ExecuteSQL(sql);
        }
    }
}
