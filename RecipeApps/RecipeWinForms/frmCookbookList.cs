using RecipeSystem;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmCookbookList : Form
    {
        public frmCookbookList()
        {
            InitializeComponent();
            this.Activated += FrmCookbookList_Activated;
            gCookBookList.KeyDown += GCookBookList_KeyDown;
            gCookBookList.CellContentDoubleClick += GCookBookList_CellContentDoubleClick;
            btnNewCookbook.Click += BtnNewCookbook_Click;
        }

        

        private void BindData()
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataTable dtcookbooklist = DataMaintenance.GetCookBookList();
                gCookBookList.DataSource = dtcookbooklist;
                WindowsFormsUtility.FormatGridForSearchResults(gCookBookList, "CookBook");
                if(dtcookbooklist.Rows.Count > 0)
                {
                    gCookBookList.Focus();
                    gCookBookList.Rows[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void ShowCookBookEdit(int rowindex)
        {
            int id = 0;
            if(rowindex > -1)
            {
                id = WindowsFormsUtility.GetIdFromGrid(gCookBookList, rowindex, "CookBookId");
            }
            if(this.MdiParent != null && MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmCookBookEdit), id);
            }
        }

        private void FrmCookbookList_Activated(object? sender, EventArgs e)
        {
            this.BindData();
        }

        private void GCookBookList_CellContentDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowCookBookEdit(e.RowIndex);
        }

        private void GCookBookList_KeyDown(object? sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && gCookBookList.SelectedRows.Count > 0)
            {
                ShowCookBookEdit(gCookBookList.SelectedRows[0].Index);
                e.SuppressKeyPress = true;
            }
        }

        private void BtnNewCookbook_Click(object? sender, EventArgs e)
        {
            if(this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmCookBookEdit));
            }
        }
    }
}
