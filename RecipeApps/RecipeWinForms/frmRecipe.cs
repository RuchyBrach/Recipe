using System.Data;
using CPUFramework;
using CPUWindowsFormFramework;
using RecipeStystem;

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
            dtrecipe = Recipe.Load(recipeid);
            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();
            }
            DataTable dthhuser = Recipe.GetList("HHUser");
            DataTable dtcuisine = Recipe.GetList("Cuisine");
            WindowsFormsUtility.SetListBinding(lstUsername, dthhuser, dtrecipe, "HHUser");
            WindowsFormsUtility.SetListBinding(lstCuisineName, dtcuisine, dtrecipe, "Cuisine");
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
            Recipe.Save(dtrecipe);
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
            Recipe.Delete(dtrecipe);
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
