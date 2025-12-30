using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class CookBook
    {
        public static DataTable Load(int cookbookid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("CookBookGet");
            SQLUtility.SetParamValue(cmd, "@CookBookId", cookbookid);
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
            
        }
        public static void Save(DataTable dtcookbook)
        {
            if(dtcookbook.Rows.Count == 0)
            {
                throw new Exception("Cannot call Cookbook Save method because there are no rows in the table");
            }
            DataRow r = dtcookbook.Rows[0];
            SQLUtility.SaveDataRow(r, "CookBookUpdate");
        }

        public static void Delete(DataTable dtcookbook)
        {
            int id = (int)dtcookbook.Rows[0]["CookBookId"];
            SqlCommand cmd = SQLUtility.GetSQLCommand("CookBookDelete");
            SQLUtility.SetParamValue(cmd, "@CookBookId", id);
            SQLUtility.ExecuteSQL(cmd);
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

        public static DataTable LoadRecipesbyCookbookId(int cookbookid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("CookBookRecipeGet");
            SQLUtility.SetParamValue(cmd, "@CookBookId", cookbookid);
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
        public static int AutoCreateCookBook(int hhuserid)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("CookBookAutoCreate");
            SQLUtility.SetParamValue(cmd, "@HHUserId", hhuserid);
            SQLUtility.ExecuteSQL(cmd);
            int newcookbookid = (int)cmd.Parameters["@CookBookId"].Value;
            return newcookbookid;
        }
    }
}
