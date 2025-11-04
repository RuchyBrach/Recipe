using System.Data;

namespace RecipeWinForms
{
    public partial class frmCloneaRecipe : Form
    {
        
        public frmCloneaRecipe()
        {
            InitializeComponent();
            BindData();
            btnClone.Click += BtnClone_Click;
            this.Activated += FrmCloneaRecipe_Activated;
        }

        

        private void BindData()
        {
            DataTable dtrecipelist = Recipe.GetRecipeList();
            WindowsFormsUtility.SetListBinding(lstRecipeName, dtrecipelist, null, "Recipe");
        }

        private void Clone()
        {
            try
            {
                int baserecipeid = (int)lstRecipeName.SelectedValue;
                int recipeid = Recipe.CloneRecipe(baserecipeid);
                ShowClonedRecipeForm(recipeid);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void ShowClonedRecipeForm(int recipeid)
        {
            if (this.MdiParent != null && MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipeEdit), recipeid);
            }
        }

        private void BtnClone_Click(object? sender, EventArgs e)
        {
            Clone();
        }

        private void FrmCloneaRecipe_Activated(object? sender, EventArgs e)
        {
            this.BindData();
        }


    }
}
