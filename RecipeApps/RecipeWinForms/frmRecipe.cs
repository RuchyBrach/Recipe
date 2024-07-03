using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPUFramework;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        public frmRecipe()
        {
            InitializeComponent();
        }

        public void ShowForm(int recipeid)
        {
            string sql = "select c.CuisineName, r.RecipeName, r.Calories, r.RecipeStatus, r.DateTimeDraft, r.DateTimePublished, r.DateTimeArchived, me.MealName, co.CourseName " +
                "from Cuisine c " +
                "join Recipe r " +
                "on c.CuisineId = r.CuisineId " +
                "join HHUser u " +
                "on r.HHUserId = u.HHUserId " +
                "left join MealCourseRecipe mcr "+
                "on r.RecipeId = mcr.RecipeId " +
                "left join MealCourse mc " +
                "on mcr.MealCourseId = mc.MealCourseId " +
                "left join Meal me " +
                "on mc.MealId = me.MealId " +
                "left join Course co " +
                "on mc.CourseId = co.CourseId " +
                "where r.RecipeId = " + recipeid.ToString();
            DataTable dt = SQLUtility.GetDataTable(sql);
            txtRecipeName.DataBindings.Add("Text", dt, "RecipeName");
            txtCuisineName.DataBindings.Add("Text", dt, "CuisineName");
            txtCalories.DataBindings.Add("Text", dt, "Calories");
            txtMealName.DataBindings.Add("Text", dt, "MealName");
            txtCourseName.DataBindings.Add("Text", dt, "CourseName");
            txtRecipeStatus.DataBindings.Add("Text", dt, "RecipeStatus");
            txtDateTimeDraft.DataBindings.Add("Text", dt, "DateTimeDraft");
            txtDateTimePublished.DataBindings.Add("Text", dt, "DateTimePublished");
            txtDateTimeArchived.DataBindings.Add("Text", dt, "DateTimeArchived");
            this.Show();
        }
    }
}
