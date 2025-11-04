using RecipeSystem;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmMealList : Form
    {
        public frmMealList()
        {
            InitializeComponent();
            this.Activated += FrmMealList_Activated;
        }

        private void BindData()
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataTable dtMealList = DataMaintenance.GetMealList();
                gMealList.DataSource = dtMealList;
                WindowsFormsUtility.FormatGridForSearchResults(gMealList, "Meal");
                if (gMealList.Rows.Count > 0)
                {
                    gMealList.Focus();
                    gMealList.Rows[0].Selected = true;
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

        private void FrmMealList_Activated(object? sender, EventArgs e)
        {
            this.BindData();
        }
    }
}
