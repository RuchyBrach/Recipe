using RecipeSystem;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            btnRecipeList.Click += BtnRecipeList_Click;
            btnMealList.Click += BtnMealList_Click;
            btnCookbookList.Click += BtnCookbookList_Click;
            this.Activated += FrmDashboard_Activated;
        }

        private void BtnCookbookList_Click(object? sender, EventArgs e)
        {
            if(this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbookList));
            }
        }

        private void BtnMealList_Click(object? sender, EventArgs e)
        {
            if(this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmMealList));
            }
        }

        private void BtnRecipeList_Click(object? sender, EventArgs e)
        {
            if(this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipeList));
            }
        }

        private void FrmDashboard_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            DataTable dt = DataMaintenance.GetRecipeDashboard();
            SetCountText(dt, "Recipe", lblRecipesCount);
            SetCountText(dt, "Meal", lblMealsCount);
            SetCountText(dt, "Cookbook", lblCookbooksCount);
        }

        private void SetCountText(DataTable dt, string recordtype, Label lbl)
        {
            var rows = dt.Select($"DashboardType = '{recordtype}'");
            if (rows.Length > 0)
            {
                lbl.Text = rows[0]["DashboardCount"].ToString();
            }
        }
    }
}
