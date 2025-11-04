using CPUFramework;
using RecipeStystem;
using RecipeSystem;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmCookBookEdit : Form
    {
        DataTable dtcookbook = new();
        DataTable dtcookbookrecipes = new();
        BindingSource bindsource = new();
        string deletecolname = "deletecol";
        int cookbookid = 0;
        public frmCookBookEdit()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnSaveRecipe.Click += BtnSaveRecipe_Click;
            gCookBookRecipe.CellContentClick += GCookBookRecipe_CellContentClick;
            this.FormClosing += FrmCookBookEdit_FormClosing;
        }

        

        public void LoadForm(int cookbookval)
        {
            cookbookid = cookbookval;
            this.Tag = cookbookid;
            dtcookbook = CookBook.Load(cookbookid);
            bindsource.DataSource = dtcookbook;
            if(cookbookid == 0)
            {
                dtcookbook.Rows.Add();
            }
            DataTable dtuser = CookBook.GetUserList();
            WindowsFormsUtility.SetListBinding(lstUserName, dtuser, dtcookbook, "HHUser");
            WindowsFormsUtility.SetControlBinding(txtCookbookName, bindsource);
            WindowsFormsUtility.SetControlBinding(txtPrice, bindsource);
            WindowsFormsUtility.SetControlBinding(txtCookBookDateCreated, bindsource);
            WindowsFormsUtility.SetControlBinding(cbxCookBookActive, bindsource);
            this.Text = GetCookBookDesc();
            LoadCookBookRecipes();
            SetButtonsEnabledBasedOnNewRecord();
        }

        private void LoadCookBookRecipes()
        {
            dtcookbookrecipes = CookBook.LoadRecipesbyCookbookId(cookbookid);
            gCookBookRecipe.Columns.Clear();
            gCookBookRecipe.DataSource = dtcookbookrecipes;
            WindowsFormsUtility.AddComboBoxToGrid(gCookBookRecipe, DataMaintenance.GetDataList("Recipe"), "Recipe", "RecipeName");
            WindowsFormsUtility.AddDeleteButtonToGrid(gCookBookRecipe, deletecolname);
            WindowsFormsUtility.FormatGridForEdit(gCookBookRecipe, "CookBookRecipe");
            SetColumnIndex(gCookBookRecipe);
        }

        private void SetColumnIndex(DataGridView g)
        {
            int columnindex = 0;
            g.Columns["RecipeSequence"].DisplayIndex = columnindex + 1;
            g.Columns["deletecol"].DisplayIndex = columnindex + 2;
        }

        private bool Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                CookBook.Save(dtcookbook);
                b = true;
                bindsource.ResetBindings(false);
                cookbookid = SQLUtility.GetValueFromFirstRowAsInt(dtcookbook, "CookBookId");
                this.Tag = cookbookid;
                SetButtonsEnabledBasedOnNewRecord();
                this.Text = GetCookBookDesc();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally { Application.UseWaitCursor = false; }
            return b;
        }

        private string GetCookBookDesc()
        {
            string value = "New Cookbook";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtcookbook, "CookBookId");
            if(pkvalue > 0)
            {
                value = SQLUtility.GetValueFromFirstRowAsString(dtcookbook, "CookBookName");
            }
            return value;
        }

        private void SetButtonsEnabledBasedOnNewRecord()
        {
            bool b = cookbookid == 0 ? false : true;
            btnDelete.Enabled = b;
            btnSaveRecipe.Enabled = b;
        }

        private void Delete()
        {
            var response = MessageBox.Show("Are you sure you want to delete this cookbook?", Application.ProductName, MessageBoxButtons.YesNo);
            if(response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                CookBook.Delete(dtcookbook);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }

        private void SaveCookBookRecipe()
        {
            try
            {
                SQLUtility.SaveChildTable(dtcookbookrecipes, cookbookid, "CookBookId", "CookBookRecipeUpdate");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void DeleteCookBookRecipe(int rowindex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gCookBookRecipe, rowindex, "CookBookRecipeId");
            if (id > 0)
            {
                try
                {
                    SQLUtility.DeleteChildTable(id, "CookBookRecipeDelete", "@CookBookRecipeId");
                    LoadCookBookRecipes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < gCookBookRecipe.Rows.Count)
            {
                gCookBookRecipe.Rows.RemoveAt(rowindex);
            }
        }

        private void GCookBookRecipe_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeleteCookBookRecipe(e.RowIndex);
        }


        private void BtnSaveRecipe_Click(object? sender, EventArgs e)
        {
            SaveCookBookRecipe();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        

        private void FrmCookBookEdit_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindsource.EndEdit();
            if (SQLUtility.TableHasChanges(dtcookbook))
            {
                var res = MessageBox.Show($"Do you want to save changes to {this.Text}?", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Yes:
                        bool b = Save();
                        if (b == false)
                        {
                            e.Cancel = true;
                            this.Activate();
                        }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        this.Activate();
                        break;
                }
            }
        }
    }
}
