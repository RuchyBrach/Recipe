using RecipeSystem;
using System.Configuration;
using System.Data;

namespace RecipeTest
{
    public class RecipeTest
    {
        string connstring = ConfigurationManager.ConnectionStrings["devconn"].ConnectionString;
        string testconnstring = ConfigurationManager.ConnectionStrings["unittestconn"].ConnectionString;
        string liveconnstring = ConfigurationManager.ConnectionStrings["liveconn"].ConnectionString;
        [SetUp]
        public void Setup()
        {
            DBManager.SetConnectionString(connstring, true);
        }

        
        private DataTable GetDataTable(string sql)
        {
            DataTable dt = new();
            DBManager.SetConnectionString(testconnstring, false);
            dt = SQLUtility.GetDataTable(sql);
            DBManager.SetConnectionString(connstring, false);
            return dt;
        }
        
        private int GetFirstColumnFirstRowValue(string sql)
        {
            int n = 0;
            DBManager.SetConnectionString(testconnstring, false);
            n = SQLUtility.GetFirstColumnFirstRowValue(sql);
            DBManager.SetConnectionString(connstring, false);
            return n;
        }
        
        private void ExecuteSQL(string sql)
        {
            DBManager.SetConnectionString(testconnstring, false);
            SQLUtility.ExecuteSQL(sql);
            DBManager.SetConnectionString(connstring, false);
        }

        [Test]
        [TestCase(75, "02-02-2010")]
        public void InsertNewRecipe(int calories, DateTime datetimedraft)
        {
            int hhuserid = GetFirstColumnFirstRowValue("select top 1 hhuserid from hhuser");
            Assume.That(hhuserid > 0, "can't run test, no users in DB");
            int cuisineid = GetFirstColumnFirstRowValue("select top 1 cuisineid from cuisine");
            Assume.That(cuisineid > 0, "can't run test, no cuisines in DB");
            DateTime uniquecode = DateTime.Now; 
            TestContext.WriteLine("insert recipe with hhuserid = " + hhuserid);

            bizRecipe rec = new();
            rec.HHUserId = hhuserid;
            rec.CuisineId = cuisineid;
            rec.RecipeName = "TestRecipe " + uniquecode;
            rec.Calories = calories;
            rec.DateTimeDraft = datetimedraft;
            rec.Save();

            int newid = GetFirstColumnFirstRowValue("select * from recipe r where r.recipename = 'TestRecipe " + uniquecode + "'");

            Assert.IsTrue(newid > 0, "recipe with recipename = 'TestRecipe " + uniquecode + "' is not found in DB");
            TestContext.WriteLine("recipe with recipename = 'TestRecipe " + uniquecode + "' is found in DB with pk value = " + newid);
        }

        [Test]
        public void ChangeRecipeCalories()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipe in DB, can't run test");
            int calories = GetFirstColumnFirstRowValue("select calories from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("calories for recipeid " + recipeid + " is " + calories);
            calories = calories + 1;
            TestContext.WriteLine("Change calories to " + calories);
            
            DataTable dt = Recipe.Load(recipeid);
            dt.Rows[0]["calories"] = calories;
            Recipe.Save(dt);
            
            int newcalories = GetFirstColumnFirstRowValue("select calories from recipe where recipeid = " + recipeid);
            Assert.IsTrue(newcalories == calories, "Calories for recipe(" + recipeid + ") = " + newcalories);
            TestContext.WriteLine("Calories for recipe(" + recipeid + ") = " + newcalories);
        }

        [Test]
        public void ChangeRecipeToInvalidCalories()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipe in DB, can't run test");
            int calories = GetFirstColumnFirstRowValue("select calories from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("calories for recipeid " + recipeid + " is " + calories);
            calories = calories - calories - 1;
            TestContext.WriteLine("Change calories to " + calories);

            DataTable dt = Recipe.Load(recipeid);
            dt.Rows[0]["calories"] = calories;
            Exception ex = Assert.Throws<Exception>(() => Recipe.Save(dt));
            TestContext.WriteLine(ex.Message);

        }

        [Test]
        public void ChangeExistingRecipeToInvalidRecipeName()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipe in DB, can't run test");
            string recipename = GetFirstColumnFirstRowValueAsString("select recipename from recipe where recipeid = " + recipeid);
            string newrecipename = GetFirstColumnFirstRowValueAsString("select recipename from recipe where recipeid <> " + recipeid);
            TestContext.WriteLine("recipename for recipeid " + recipeid + " is " + recipename);
            recipename = newrecipename;
            TestContext.WriteLine("Change recipename to " + newrecipename);

            DataTable dt = Recipe.Load(recipeid);
            dt.Rows[0]["recipename"] = newrecipename;
            Exception ex = Assert.Throws<Exception>(() =>Recipe.Save(dt));
            TestContext.WriteLine(ex.Message);
            
        }

        [Test]
        public void DeleteRecipe()
        {
            DataTable dt = GetDataTable("select top 1 r.recipeid, r.recipename from recipe r left join direction d on r.recipeid = d.recipeid where d.directionid is null");
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0) 
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc = dt.Rows[0]["RecipeName"].ToString();
            }
            Assume.That(recipeid > 0, "No recipes without direction in DB, can't run test");
            TestContext.WriteLine("existing recipe without direction, with id = " + recipeid + " " + recipedesc);
            TestContext.WriteLine("ensure that app can delete " + recipeid);
            bizRecipe rec = new();
            rec.Load(recipeid);
            rec.Delete();
            DataTable dtafterdelete = GetDataTable("select * from recipe where recipeid = " + recipeid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "record with recipeid " + recipeid + "exists in DB");
            TestContext.WriteLine("Record with recipeid" + recipeid + "does not exist in DB");
        }
        
        [Test]
        public void DeleteRecipeWhereArchivedLessThan30Days()
        {
            string sql = @"
            select top 1 r.recipeid, r.recipename 
            from recipe r 
            where Datediff(day, r.DateTimeArchived, CURRENT_TIMESTAMP) < 30";
            DataTable dt = GetDataTable(sql);
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc = dt.Rows[0]["RecipeName"].ToString();
            }
            Assume.That(recipeid > 0, "No recipes with datediff of DateTimeArchived < 30 in DB can't run test");
            TestContext.WriteLine("existing recipe where archived for less than 30 days, with id = " + recipeid + " " + recipedesc);
            TestContext.WriteLine("ensure that app can't delete " + recipeid);
            Exception ex = Assert.Throws<Exception>(() => Recipe.Delete(dt));
            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void DeleteRecipeWithPublishedRecipeStatus()
        {
            string sql = @"
            select top 1 r.recipeid, r.recipename 
            from recipe r 
            where r.RecipeStatus = 'Published'";
            DataTable dt = GetDataTable(sql);
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc = dt.Rows[0]["RecipeName"].ToString();
            }
            Assume.That(recipeid > 0, "No recipes with recipe status that = Published, can't run test");
            TestContext.WriteLine("existing recipe with recipe status = Published, with id = " + recipeid + " " + recipedesc);
            TestContext.WriteLine("ensure that app can't delete " + recipeid);
            Exception ex = Assert.Throws<Exception>(() => Recipe.Delete(dt));
            TestContext.WriteLine(ex.Message);
        }
        

        [Test]
        public void LoadRecipe()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");
            TestContext.WriteLine("existing reciep with id + " + recipeid);
            TestContext.WriteLine("ensure that app loads recipe " + recipeid);
            bizRecipe rec = new();
            rec.Load(recipeid);
            int loadedid = rec.RecipeId;
            Assert.IsTrue( loadedid == recipeid, loadedid + " <> " + recipeid);
            TestContext.WriteLine("Loaded recipe (" + loadedid + ")");
        }


        
        [Test]
        [TestCase(true)]
        public void GetListOfRecipes(bool includeblank)
        {
            int recipecount = GetFirstColumnFirstRowValue("select total = count(*) from Recipe");
            if(includeblank == true) { recipecount = recipecount + 1; }
            Assume.That(recipecount > 0, "No recipes in DB, can't test");
            TestContext.WriteLine("Num of recipes in DB = " + recipecount);
            TestContext.WriteLine("Ensure that num of rows return by app matches " + recipecount);
            bizRecipe rec = new();
            var lst = rec.GetList(includeblank);
            Assert.IsTrue(lst.Count == recipecount, "num rows returned by app (" + lst.Count + ") <> " + recipecount);
            TestContext.WriteLine("Number of rows in Recipe return by app = " + lst.Count);
        }
        [Test]
        public void SearchRecipe()
        {
            string recipename = "a";
            int recipecount = GetFirstColumnFirstRowValue("select total = count(*) from recipe r where r.RecipeName like '%" + recipename + "%'");
            Assume.That(recipecount > 0, "There are no recipes in the DB that match search for " + recipename);
            TestContext.WriteLine("There are " + recipecount + " recipes that match search for " + recipename);
            TestContext.WriteLine("Ensure that recipe search returns " + recipecount + " rows");
            bizRecipe rec = new();
            List<bizRecipe> lst = rec.Search(recipename);

            Assert.IsTrue(lst.Count == recipecount, "Results of recipe does not match num of recipes, " + lst.Count + " <> " + recipecount);
            TestContext.WriteLine("Number of rows returned by recipe search is " + lst.Count);
        }

        [Test]
        public void GetListOfIngredients()
        {
            int ingredientcount = GetFirstColumnFirstRowValue("select total = count(*) from Ingredient");
            Assume.That(ingredientcount > 0, "No ingredients in DB, can't test");
            TestContext.WriteLine("Num of ingredients in DB = " + ingredientcount);
            TestContext.WriteLine("Ensure that num of rows return by app matches " + ingredientcount);
            bizIngredient i = new();
            var lst = i.GetList();
            Assert.IsTrue(lst.Count == ingredientcount, "num rows returned by app (" + lst.Count + ") <> " + ingredientcount);
            TestContext.WriteLine("Number of rows in Ingredient return by app = " + lst.Count);
        }
        [Test]
        public void SearchIngredient()
        {
            string ingredientname = "a";
            int ingredientcount = GetFirstColumnFirstRowValue("select total = count(*) from Ingredient i where i.IngredientName like '%" + ingredientname + "%'");
            Assume.That(ingredientcount > 0, "There are no ingredients in the DB that match search for " + ingredientname);
            TestContext.WriteLine("There are " + ingredientcount + " ingredients that match search for " + ingredientname);
            TestContext.WriteLine("Ensure that ingredient search returns " + ingredientcount + " rows");
            bizIngredient i = new();
            List<bizIngredient> lst = i.Search(ingredientname);

            Assert.IsTrue(lst.Count == ingredientcount, "Results of ingredient does not match num of ingredients, " + lst.Count + " <> " + ingredientcount);
            TestContext.WriteLine("Number of rows returned by ingredient search is " + lst.Count);
        }
        [Test]
        public void GetListOfUsers()
        {
            //DataTable dtusercount = GetDataTable("select total = count(*) from HHUser");
            //int usercount = (int)dtusercount.Rows[0]["total"];
            int usercount = GetFirstColumnFirstRowValue("select total = count(*) from HHUser");
            Assume.That(usercount > 0, "No Users in DB, can't test");
            TestContext.WriteLine("Num of users in DB = " + usercount);
            TestContext.WriteLine("Ensure that num of rows return by app matches " + usercount);

            DataTable dt = Recipe.GetUserList();

            Assert.IsTrue(dt.Rows.Count == usercount, "num rows returned by app (" + dt.Rows.Count + ") <> " + usercount);
            TestContext.WriteLine("Number of rows in Users return by app = " + dt.Rows.Count);
        }

        [Test]
        public void GetListOfCuisines()
        {
            DataTable dtcuisinecount = GetDataTable("select total = count(*) from Cuisine");
            int cuisinecount = (int)dtcuisinecount.Rows[0]["total"];
            TestContext.WriteLine("Num of cuisines in DB = " + cuisinecount);
            TestContext.WriteLine("Ensure that num of rows return by app matches " + cuisinecount);

            DataTable dt = Recipe.GetCuisineList();

            Assert.IsTrue(dt.Rows.Count == cuisinecount, "num rows returned by app (" + dt.Rows.Count + ") <> " + cuisinecount);
            TestContext.WriteLine("Number of rows in Users return by app = " + dt.Rows.Count);
        }
        
        private int GetExistingRecipeId()
        {
            return GetFirstColumnFirstRowValue("select top 1 recipeid from recipe");

        }
        
        private string GetFirstColumnFirstRowValueAsString(string sql)
        {
            string s = "";
            DataTable dt = GetDataTable(sql);
            if(dt.Rows.Count > 0 && dt.Columns.Count > 0)
            {
                if (dt.Rows[0][0] != DBNull.Value)
                {
                    s = dt.Rows[0][0].ToString();
                }
            }
            return s;
        
        }
    }
}