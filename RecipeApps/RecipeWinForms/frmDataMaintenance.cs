using CPUFramework;
using RecipeSystem;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmDataMaintenance : Form
    {
        private enum TableTypeEnum { HHUser, Cuisine, Ingredient, MeasType, Course};
        DataTable dtlist = new();
        TableTypeEnum currenttabletype = TableTypeEnum.HHUser;
        string deletecolname = "deletecol";

        public frmDataMaintenance()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            SetUpRadioButtons();
            BindData(currenttabletype);
            gData.CellContentClick += GData_CellContentClick;
            this.FormClosing += FrmDataMaintenance_FormClosing;
        }

        private void BindData(TableTypeEnum tabletype)
        {
            currenttabletype = tabletype;
            dtlist = DataMaintenance.GetDataList(currenttabletype.ToString());
            gData.Columns.Clear();
            gData.DataSource = dtlist;
            WindowsFormsUtility.AddDeleteButtonToGrid(gData, deletecolname);
            WindowsFormsUtility.FormatGridForEdit(gData, currenttabletype.ToString());
        }

        private void SetUpRadioButtons()
        {
            foreach(Control c in pnlOptionButtons.Controls)
            {
                if(c is RadioButton)
                {
                    c.Click += C_Click;
                }
            }
            optUsers.Tag = TableTypeEnum.HHUser;
            optCuisines.Tag = TableTypeEnum.Cuisine;
            optIngredients.Tag = TableTypeEnum.Ingredient;
            optMeasurements.Tag = TableTypeEnum.MeasType;
            optCourses.Tag = TableTypeEnum.Course;
        }

        private bool Save()
        {
            bool b = false;
            Cursor = Cursors.WaitCursor;
            try
            {
                DataMaintenance.SaveDataList(dtlist, currenttabletype.ToString());
                b = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
            return b;
        }

        private void Delete(int rowindex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gData, rowindex, currenttabletype.ToString() + "Id");
            if (id != 0)
            {
                try
                {
                    DataMaintenance.DeleteRow(currenttabletype.ToString(), id);
                    BindData(currenttabletype);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }  
            else if(id == 0 && rowindex < gData.Rows.Count)
            {
                gData.Rows.Remove(gData.Rows[rowindex]);
            }
        }

        private void C_Click(object? sender, EventArgs e)
        {
            if(sender is Control && ((Control)sender).Tag is TableTypeEnum)
            {
                BindData((TableTypeEnum)((Control)sender).Tag);
;           }
        }

        private void GData_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (gData.Columns[e.ColumnIndex].Name == deletecolname)
            {
                string message = $"Are you sure you want to delete this {currenttabletype.ToString()}?";
                if (currenttabletype == TableTypeEnum.HHUser)
                {
                    message = "Are you sure you want to delete this user and all related recipes, meals, and cookbooks?";
                }
                var res = MessageBox.Show(message, Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Yes:
                        Delete(e.RowIndex);
                        break;
                }
            }

        }

        

        private void FrmDataMaintenance_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (SQLUtility.TableHasChanges(dtlist))
            {
                var res = MessageBox.Show($"Do you want to save changes to {this.Text} before closing the form", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Yes:
                        bool b = Save();
                        if(b == false)
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

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        
    }
}
