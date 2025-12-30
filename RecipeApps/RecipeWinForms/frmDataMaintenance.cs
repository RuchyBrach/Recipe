using CPUFramework;
using Microsoft.Win32;
using RecipeSystem;
using System.Data;
using System.Diagnostics;

namespace RecipeWinForms
{
    public partial class frmDataMaintenance : Form
    {
        private enum TableTypeEnum { HHUser, Cuisine, Ingredient, MeasType, Course};
        DataTable dtlist = new();
        TableTypeEnum currenttabletype = TableTypeEnum.HHUser;
        string deletecolname = "deletecol";
        private bool loading;
        public frmDataMaintenance()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            gData.CellContentClick += GData_CellContentClick;
            gData.DataError += GData_DataError;
            this.FormClosing += FrmDataMaintenance_FormClosing;
            this.Load += FrmDataMaintenance_Load;
        }

        private void FrmDataMaintenance_Load(object? sender, EventArgs e)
        {
            loading = true;
            SetUpRadioButtons();
            currenttabletype = TableTypeEnum.HHUser;
            optUsers.Checked = true;
            BindData(currenttabletype);
            loading = false;

        }

        private void BindData(TableTypeEnum tabletype)
        {
            dtlist = DataMaintenance.GetDataList(currenttabletype.ToString());
            gData.Columns.Clear();
            gData.DataSource = dtlist;
            WindowsFormsUtility.AddDeleteButtonToGrid(gData, deletecolname);
            WindowsFormsUtility.FormatGridForEdit(gData, currenttabletype.ToString());
        }

        private void SetUpRadioButtons()
        {
            optUsers.Tag = TableTypeEnum.HHUser;
            optCuisines.Tag = TableTypeEnum.Cuisine;
            optIngredients.Tag = TableTypeEnum.Ingredient;
            optMeasurements.Tag = TableTypeEnum.MeasType;
            optCourses.Tag = TableTypeEnum.Course;
            foreach (Control c in pnlOptionButtons.Controls)
            {
                if(c is RadioButton rb)
                {
                    rb.CheckedChanged += Rb_CheckedChanged;
                }
            }
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
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Application.ProductName);
                    }
                }
                else if (id == 0)
                {
                    return;
                }
                else if (id < gData.Rows.Count)
                {
                    gData.Rows.RemoveAt(rowindex);
                }
        }

        private void Rb_CheckedChanged(object? sender, EventArgs e)
        {
            if (loading) return;

            var rb = sender as RadioButton;
            if (rb == null) return;

            var table = (TableTypeEnum)rb.Tag;
            if (table == currenttabletype) return;

            currenttabletype = table;
            BindData(table);
        }

        private void GData_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == gData.NewRowIndex)
            {
                return;
            }
            if (gData.Columns[e.ColumnIndex].Name == deletecolname && e.RowIndex > -1)
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

        private void GData_DataError(object? sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("value must be int");
            e.ThrowException = false;
            e.Cancel = true;
            gData.CancelEdit();
        }

    }
}
