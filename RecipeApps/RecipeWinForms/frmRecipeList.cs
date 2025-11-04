using RecipeSystem;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmRecipeList : Form
    {
        public frmRecipeList()
        {
            InitializeComponent();
            gRecipeList.CellContentDoubleClick += GRecipeList_CellContentDoubleClick;
            gRecipeList.KeyDown += GRecipeList_KeyDown;
            btnNewRecipe.Click += BtnNewRecipe_Click;
            this.Activated += FrmRecipeList_Activated;
        }

        

        private void BindData()
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataTable dtRecipeList = DataMaintenance.GetRecipeList();
                gRecipeList.DataSource = dtRecipeList;
                WindowsFormsUtility.FormatGridForSearchResults(gRecipeList, "Recipe");
                if (gRecipeList.Rows.Count > 0)
                {
                    gRecipeList.Focus();
                    gRecipeList.Rows[0].Selected = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void ShowRecipeEditForm(int rowindex)
        {
            int id = 0;
            if(rowindex > -1)
            {
                id = WindowsFormsUtility.GetIdFromGrid(gRecipeList, rowindex, "RecipeId");
            }
            if (this.MdiParent != null && MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipeEdit), id);
            }

        }

        private void GRecipeList_KeyDown(object? sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && gRecipeList.SelectedRows.Count > 0)
            {
                ShowRecipeEditForm(gRecipeList.SelectedRows[0].Index);
                e.SuppressKeyPress = true;
            }
        }

        private void GRecipeList_CellContentDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {

            ShowRecipeEditForm(e.RowIndex);
            
        }

        private void FrmRecipeList_Activated(object? sender, EventArgs e)
        {
            this.BindData();
        }

        private void BtnNewRecipe_Click(object? sender, EventArgs e)
        {
            if(this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipeEdit));
            }
        }

    }
}
