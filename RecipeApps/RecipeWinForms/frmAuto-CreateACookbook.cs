using RecipeSystem;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmAuto_CreateACookbook : Form
    {
        public frmAuto_CreateACookbook()
        {
            InitializeComponent();
            btnCreateCookbook.Click += BtnCreateCookbook_Click;
            BindData();
        }

        private void BindData()
        {
            DataTable dtuserlist = Recipe.GetUserList();
            WindowsFormsUtility.SetListBinding(lstUserName, dtuserlist, null, "HHUser");
        }

        private void AutoCreate()
        {
            try
            {
                int userid = (int)lstUserName.SelectedValue;
                int cookbookid = CookBook.AutoCreateCookBook(userid);
                ShowCreatedCookbook(cookbookid);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void ShowCreatedCookbook(int cookbookid)
        {
            if (this.MdiParent != null && MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmCookBookEdit), cookbookid);
            }
        }

        private void BtnCreateCookbook_Click(object? sender, EventArgs e)
        {
            AutoCreate();
        }

        
    }
}
