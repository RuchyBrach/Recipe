using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    internal class DBManager
    {
        public static void SetConnectionString(string connectionstring)
        {
            SQLUtility.ConnectionString = connectionstring;
        }
    }
}
