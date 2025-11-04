namespace RecipeWinForms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            mnuDashboard.Click += MnuDashboard_Click;
            mnuRecipeList.Click += MnuRecipeList_Click;
            mnuNewRecipe.Click += MnuNewRecipe_Click;
            mnuCookbookList.Click += MnuCookbookList_Click;
            mnuNewCookbook.Click += MnuNewCookbook_Click;
            mnuTile.Click += MnuTile_Click;
            mnuCascade.Click += MnuCascade_Click;
            mnuMealsList.Click += MnuMealsList_Click;
            mnuEditData.Click += MnuEditData_Click;
            mnuCloneARecipe.Click += MnuCloneARecipe_Click;
            mnuAutoCreate.Click += MnuAutoCreate_Click;
            this.Shown += FrmMain_Shown;
        }

        private void FrmMain_Shown(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDashboard));
        }

        public void OpenForm(Type frmtype, int pkvalue = 0)
        {
            bool b = WindowsFormsUtility.IsFormOpen(frmtype, pkvalue);

            if (b == false)
            {
                Form? newfrm = null;
                if(frmtype == typeof(frmRecipeEdit))
                {
                    frmRecipeEdit f= new();
                    newfrm = f;
                    f.LoadForm(pkvalue);
                }
                if (frmtype == typeof(frmDashboard))
                {
                    frmDashboard f = new();
                    newfrm = f;
                }
                if(frmtype == typeof(frmRecipeList))
                {
                    frmRecipeList f = new();
                    newfrm = f;
                }
                if(frmtype == typeof(frmCookbookList))
                {
                    frmCookbookList f = new();
                    newfrm = f;
                }
                if(frmtype == typeof(frmCookBookEdit))
                {
                    frmCookBookEdit f = new();
                    newfrm = f;
                    f.LoadForm(pkvalue);
                }
                if(frmtype == typeof(frmMealList))
                {
                    frmMealList f = new();
                    newfrm = f;
                }
                if(frmtype == typeof(frmChangeStatus))
                {
                    frmChangeStatus f = new();
                    newfrm = f;
                    f.LoadForm(pkvalue);
                }
                if(frmtype == typeof(frmDataMaintenance))
                {
                    frmDataMaintenance f = new();
                    newfrm = f;
                }
                if(frmtype == typeof(frmCloneaRecipe))
                {
                    frmCloneaRecipe f = new();
                    newfrm = f;
                }
                if(frmtype == typeof(frmAuto_CreateACookbook))
                {
                    frmAuto_CreateACookbook f = new();
                    newfrm = f;
                }
                
                if (newfrm != null)
                {
                    newfrm.MdiParent = this;
                    newfrm.WindowState = FormWindowState.Maximized;
                    newfrm.FormClosed += Newfrm_FormClosed;
                    newfrm.TextChanged += Newfrm_TextChanged;
                    newfrm.Show();
                }
                WindowsFormsUtility.SetupNav(tsMain);
            }
        }

        private void MnuCascade_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void MnuTile_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void Newfrm_TextChanged(object? sender, EventArgs e)
        {
            WindowsFormsUtility.SetupNav(tsMain);
        }

        private void Newfrm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            WindowsFormsUtility.SetupNav(tsMain);
        }

        private void MnuMealsList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmMealList));
        }

        private void MnuCookbookList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCookbookList));
        }

        private void MnuNewCookbook_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCookBookEdit));
        }

        private void MnuNewRecipe_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipeEdit));
        }

        private void MnuRecipeList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipeList));
        }

        private void MnuEditData_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDataMaintenance));
        }

        private void MnuCloneARecipe_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCloneaRecipe));
        }

        private void MnuAutoCreate_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmAuto_CreateACookbook));
        }

        private void MnuDashboard_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDashboard));
        }

    }
}
