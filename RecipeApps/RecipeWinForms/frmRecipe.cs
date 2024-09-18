using System.Data;
using CPUFramework;
using CPUWindowsFormFramework;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        DataTable dtrecipe;

        public frmRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click; 
        }


        public void ShowForm(int recipeid)
        {
            string sql = "select * from Recipe r where r.RecipeId = " + recipeid.ToString();
            dtrecipe = SQLUtility.GetDataTable(sql);
            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();
            }
            WindowsFormsUtility.SetControlBinding(txtRecipeName, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtCalories, dtrecipe);
            WindowsFormsUtility.SetControlBinding(lblRecipeStatus, dtrecipe);
            WindowsFormsUtility.SetControlBinding(dtpDateTimeDraft, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtDateTimePublished, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtDateTimeArchived, dtrecipe);
            
            this.Show();
        }

        private void Save()
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
                sql = "insert Recipe(RecipeName, Calories, DateTimeDraft)";
                sql += $"select '{r["RecipeName"]}', '{r["Calories"]}', '{r["DateTimeDraft"]}'";
            }
            SQLUtility.ExecuteSQL(sql);
        }


        //private object? CheckForNull(object? columnvalue, DataRow r, string column)
        //{
        //    object? s = columnvalue;
        //    bool b = columnvalue.ToString() == "";
        //    if (b == false)
        //    {
        //        if(column == "DateTimePublished")
        //        {
        //            s = $", DateTimePublished = '{r["DateTimePublished"]}'";
        //        }
        //        else
        //        {
        //            s = $", DateTimeArchived = '{r["DateTimeArchived"]}'";
        //        }
        //
        //    }
        //    return s;
        //}

        private void Delete()
        {
            int id = (int)dtrecipe.Rows[0]["RecipeId"];
            string sql = "delete Recipe where RecipeId = " + id;
            SQLUtility.ExecuteSQL(sql);
            this.Close();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
    }
}
