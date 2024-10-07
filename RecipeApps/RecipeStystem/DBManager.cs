
namespace RecipeStystem
{
    public class DBManager
    {
        public static void SetConnectionString(string connectionstring)
        {
            SQLUtility.ConnectionString = connectionstring;
        }
    }

}
