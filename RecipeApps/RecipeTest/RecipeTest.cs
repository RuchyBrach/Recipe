using System.Data;

namespace RecipeTest
{
    public class RecipeTest
    {
        [SetUp]
        public void Setup()
        {
            DBManager.SetConnectionString("Server=.\\SQLExpress;Database=HeartyHearthDB;Trusted_Connection=true");
        }
        [Test]
        [TestCase(75, "02-02-2010")]
        [TestCase(150, "12-02-2020")]
        public void InsertNewRecipe(int calories, DateTime datetimedraft)
        {
            DataTable dt = SQLUtility.GetDataTable("select * from recipe where recipeid = 0");
            DataRow r = dt.Rows.Add();
            Assume.That(dt.Rows.Count == 1);
            int hhuserid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 hhuserid from hhuser");
            Assume.That(hhuserid > 0, "can't run test, no users in DB");
            int cuisineid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 cuisineid from cuisine");
            Assume.That(cuisineid > 0, "can't run test, no cuisines in DB");
            DateTime uniquecode = DateTime.Now; 
            TestContext.WriteLine("insert president with hhuserid = " + hhuserid);

            r["HHUserId"] = hhuserid;
            r["CuisineId"] = cuisineid;
            r["RecipeName"] = "TestRecipe " + uniquecode;
            r["Calories"] = calories;
            r["DateTimeDraft"] = datetimedraft;
            Recipe.Save(dt);

            int newid = SQLUtility.GetFirstColumnFirstRowValue("select * from recipe r where r.recipename = 'TestRecipe " + uniquecode + "'");

            Assert.IsTrue(newid > 0, "recipe with recipename = 'TestRecipe " + uniquecode + "' is not found in DB");
            TestContext.WriteLine("recipe with recipename = 'TestRecipe " + uniquecode + "' is found in DB with pk value = " + newid);
        }

        [Test]
        public void ChangeExistingRecipeCalories()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipe in DB, can't run test");
            int calories = SQLUtility.GetFirstColumnFirstRowValue("select calories from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("calories for recipeid " + recipeid + " is " + calories);
            calories = calories + 1;
            TestContext.WriteLine("Change calories to " + calories);
            
            DataTable dt = Recipe.Load(recipeid);
            dt.Rows[0]["calories"] = calories;
            Recipe.Save(dt);
            
            int newcalories = SQLUtility.GetFirstColumnFirstRowValue("select calories from recipe where recipeid = " + recipeid);
            Assert.IsTrue(newcalories == calories, "Calories for recipe(" + recipeid + ") = " + newcalories);
            TestContext.WriteLine("Calories for recipe(" + recipeid + ") = " + newcalories);
        }

        [Test]
        public void DeleteRecipe()
        {
            DataTable dt = SQLUtility.GetDataTable("select top 1 r.recipeid, r.recipename from recipe r left join direction d on r.recipeid = d.recipeid where d.directionid is null");
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0) 
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc = dt.Rows[0]["RecipeName"].ToString();
            }
            Assume.That(recipeid > 0, "No recipes without direction in DB, can't run test");
            TestContext.WriteLine("existing president without direction, with id = " + recipeid + " " + recipedesc);
            TestContext.WriteLine("ensure that app can delete " + recipeid);
            Recipe.Delete(dt);
            DataTable dtafterdelete = SQLUtility.GetDataTable("select * from recipe where recipeid = " + recipeid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "record with recipeid " + recipeid + "exists in DB");
            TestContext.WriteLine("Record with recipeid" + recipeid + "does not exist in DB");

        }

        [Test]
        public void LoadRecipe()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");
            TestContext.WriteLine("existing reciep with id + " + recipeid);
            TestContext.WriteLine("ensure that app loads recipe " + recipeid);
            DataTable dt = Recipe.Load(recipeid);
            int loadedid = (int)dt.Rows[0]["recipeid"];
            Assert.IsTrue( loadedid == recipeid, loadedid + " <> " + recipeid);
            TestContext.WriteLine("Loaded recipe (" + loadedid + ")");
        }

        [Test] 
        public void GetListOfUsers()
        {
            //DataTable dtusercount = SQLUtility.GetDataTable("select total = count(*) from HHUser");
            //int usercount = (int)dtusercount.Rows[0]["total"];
            int usercount = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from HHUser");
            Assume.That(usercount > 0, "No Users in DB, can't test");
            TestContext.WriteLine("Num of users in DB = " + usercount);
            TestContext.WriteLine("Ensure that num of rows return by app matches " + usercount);

            DataTable dt = Recipe.GetUsernameList();

            Assert.IsTrue(dt.Rows.Count == usercount, "num rows returned by app (" + dt.Rows.Count + ") <> " + usercount);
            TestContext.WriteLine("Number of rows in Users return by app = " + dt.Rows.Count);
        }
        [Test]
        public void GetListOfCuisines()
        {
            DataTable dtcuisinecount = SQLUtility.GetDataTable("select total = count(*) from Cuisine");
            int cuisinecount = (int)dtcuisinecount.Rows[0]["total"];
            TestContext.WriteLine("Num of users in DB = " + cuisinecount);
            TestContext.WriteLine("Ensure that num of rows return by app matches " + cuisinecount);

            DataTable dt = Recipe.GetUsernameList();

            Assert.IsTrue(dt.Rows.Count == cuisinecount, "num rows returned by app (" + dt.Rows.Count + ") <> " + cuisinecount);
            TestContext.WriteLine("Number of rows in Users return by app = " + dt.Rows.Count);
        }

        private int GetExistingRecipeId()
        {
            return SQLUtility.GetFirstColumnFirstRowValue("select top 1 recipeid from recipe");

        }
    }
}