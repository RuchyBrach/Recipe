using CPUFramework;
using RecipeSystem;
using System.Data;
using System.Diagnostics;

namespace RecipeWinForms
{
    public partial class frmRecipeEdit : Form
    {
        DataTable dtrecipe = new();
        DataTable dtrecipeingredient = new();
        DataTable dtdirection = new();
        BindingSource bindsource = new();
        string deletecolname = "deletecol";
        int recipeid = 0;
        public frmRecipeEdit()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnChangeStatus.Click += BtnChangeStatus_Click;
            btnSaveDirection.Click += BtnSaveDirections_Click;
            btnSaveRecipeIngredient.Click += BtnSaveIngredients_Click;
            gIngredients.DataBindingComplete += GIngredients_DataBindingComplete;
            gIngredients.CellContentClick += GIngredients_CellContentClick;
            gDirections.CellContentClick += GDirections_CellContentClick;
            gIngredients.DataError += GIngredients_DataError;
            gDirections.DataError += GDirections_DataError;
            txtCalories.Validating += TxtCalories_Validating;
            this.Activated += FrmRecipeEdit_Activated;
            this.FormClosing += FrmRecipeEdit_FormClosing;
        }

        

        public void LoadForm(int recipeval)
        {
            recipeid = recipeval;
            this.Tag = recipeid;
            dtrecipe = Recipe.Load(recipeid);
            bindsource.DataSource = dtrecipe;
            if(recipeid == 0)
            {
                dtrecipe.Rows.Add();
            }
            DataTable dtusers = Recipe.GetUserList(false);
            DataTable dtcuisine = Recipe.GetCuisineList(false);
            WindowsFormsUtility.SetListBinding(lstUserName, dtusers, dtrecipe, "HHUser");
            WindowsFormsUtility.SetListBinding(lstCuisineName, dtcuisine, dtrecipe, "Cuisine");
            WindowsFormsUtility.SetControlBinding(txtRecipeName, bindsource);
            WindowsFormsUtility.SetControlBinding(txtCalories, bindsource);
            WindowsFormsUtility.SetControlBinding(txtRecipeStatus, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateTimeDraft, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateTimePublished, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateTimeArchived, bindsource);
            this.Text = GetRecipeDesc();
            LoadRecipeIngredients();
            LoadDirections();
            SetButtonsEnabledBasedOnNewRecord();
        }

        

        private void LoadDirections()
        {
            dtdirection = Recipe.LoadDirectionsByRecipeId(recipeid);
            gDirections.Columns.Clear();
            gDirections.DataSource = dtdirection;
            WindowsFormsUtility.AddDeleteButtonToGrid(gDirections, deletecolname);
            WindowsFormsUtility.FormatGridForEdit(gDirections, "Direction");
        }

        private void LoadRecipeIngredients()
        {
            dtrecipeingredient = Recipe.LoadIngredientsByRecipeId(recipeid);
            gIngredients.Columns.Clear();
            gIngredients.DataSource = dtrecipeingredient;
            WindowsFormsUtility.AddComboBoxToGrid(gIngredients, DataMaintenance.GetDataList("MeasType", true), "MeasType", "MeasTypeName");
            WindowsFormsUtility.AddComboBoxToGrid(gIngredients, DataMaintenance.GetDataList("Ingredient"), "Ingredient", "IngredientName");
            WindowsFormsUtility.AddDeleteButtonToGrid(gIngredients, deletecolname);
            WindowsFormsUtility.FormatGridForEdit(gIngredients, "RecipeIngredient");
            foreach (DataGridViewColumn col in gIngredients.Columns)
            {
                Debug.WriteLine($"Name: {col.HeaderText}, DisplayIndex: {col.DisplayIndex}");
            }
            
        }

        private void GIngredients_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (gIngredients.Columns.Contains("deletecol"))
                gIngredients.Columns["deletecol"].DisplayIndex = gIngredients.Columns.Count - 1;
        }

        private string GetRecipeDesc()
        {
            string value = "New Recipe";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
            if (pkvalue > 0)
            {
                value = SQLUtility.GetValueFromFirstRowAsString(dtrecipe,"RecipeName");
            }
            return value;
        }


        private bool Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Save(dtrecipe);
                b = true;
                bindsource.ResetBindings(false);
                recipeid = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
                this.Tag = recipeid;
                SetButtonsEnabledBasedOnNewRecord();
                this.Text = GetRecipeDesc();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            return b;
        }

        

        private void Delete()
        {
            var response = MessageBox.Show("Are you sure you want to delete this Recipe", Application.ProductName, MessageBoxButtons.YesNo);
            if(response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Delete(dtrecipe);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally { Application.UseWaitCursor = false; }
        }

        


        private void SetButtonsEnabledBasedOnNewRecord()
        {
            bool b = recipeid == 0 ? false : true;
            btnChangeStatus.Enabled = b;
            btnDelete.Enabled = b;
            btnSaveDirection.Enabled = b;
            btnSaveRecipeIngredient.Enabled = b;
        }

        private void RecipeIngredientSave()
        {
            try
            {
                SQLUtility.SaveChildTable(dtrecipeingredient, recipeid, "RecipeId", "RecipeIngredientUpdate");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }
        private void DirectionSave()
        {
            try
            {
                SQLUtility.SaveChildTable(dtdirection, recipeid, "RecipeId", "DirectionUpdate");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void RecipeIngredientDelete(int rowindex, int columnindex)
        {
            if (gIngredients.Columns[columnindex].Tag?.ToString() == "deletecol" && rowindex >-1)
            {
                if (rowindex == gIngredients.NewRowIndex)
                {
                    return;
                }
                int id = WindowsFormsUtility.GetIdFromGrid(gIngredients, rowindex, "RecipeIngredientId");
                if (id > 0)
                {
                    try
                    {
                        SQLUtility.DeleteChildTable(id, "RecipeIngredientDelete", "@RecipeIngredientId");
                        LoadRecipeIngredients();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Application.ProductName);
                    }
                }
                else if (id < gIngredients.Rows.Count)
                {
                    gIngredients.Rows.RemoveAt(rowindex);
                }
            }
            
        }

        private void DirectionDelete(int rowindex, int columnindex)
        {
            if (gDirections.Columns[columnindex].Tag?.ToString() == "deletecol" && rowindex > -1)
            {
                if (rowindex == gDirections.NewRowIndex)
                {
                    return;
                }
                int id = WindowsFormsUtility.GetIdFromGrid(gDirections, rowindex, "DirectionId");
                if (id > 0)
                {
                    try
                    {
                        SQLUtility.DeleteChildTable(id, "DirectionDelete", "@DirectionId");
                        LoadDirections();
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
                else if (id < gDirections.Rows.Count)
                {
                    gDirections.Rows.RemoveAt(rowindex);
                }
            }
        }

        private void ChangeStatus()
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmChangeStatus), recipeid);
            }
        }

        private void GDirections_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DirectionDelete(e.RowIndex, e.ColumnIndex);
        }

        private void GIngredients_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            RecipeIngredientDelete(e.RowIndex, e.ColumnIndex);
        }

        

        private void BtnSaveIngredients_Click(object? sender, EventArgs e)
        {
            RecipeIngredientSave();
        }

        

        private void BtnSaveDirections_Click(object? sender, EventArgs e)
        {
            DirectionSave();
        }

        

        private void BtnChangeStatus_Click(object? sender, EventArgs e)
        {
            ChangeStatus();
            

        }

        

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }


        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }


        private void GIngredients_DataError(object? sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("value must be int");
            e.ThrowException = false;
            e.Cancel = true;
            gIngredients.CancelEdit();
        }

        private void GDirections_DataError(object? sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("value must be int");
            e.ThrowException = false;
            e.Cancel = true;
            gDirections.CancelEdit();
        }

        private void FrmRecipeEdit_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindsource.EndEdit();
            if (SQLUtility.TableHasChanges(dtrecipe))
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

        private void TxtCalories_Validating(object? sender, System.ComponentModel.CancelEventArgs e)
        {
            var tb = sender as TextBox;
            if (tb == null) return;

            if (!int.TryParse(tb.Text, out _))
            {
                MessageBox.Show("value must be int", Application.ProductName);
                e.Cancel = true;
                tb.Clear();
            }
        }

        private void FrmRecipeEdit_Activated(object? sender, EventArgs e)
        {
            if (recipeid > 0)
            {
                dtrecipe = Recipe.Load(recipeid);
                bindsource.DataSource = dtrecipe;
            }
        }

    }
}
