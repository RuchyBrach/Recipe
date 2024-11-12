﻿using System.Data;
using CPUFramework;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        DataTable dtrecipe = new();

        public frmRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
        }


        public void ShowForm(int recipeid)
        {
            dtrecipe = Recipe.Load(recipeid);
            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();
            }
            DataTable dthhuser = Recipe.GetUsernameList();
            DataTable dtcuisine = Recipe.GetCuisineList();
            WindowsFormsUtility.SetListBinding(lstUserName, dthhuser, dtrecipe, "HHUser");
            WindowsFormsUtility.SetListBinding(lstCuisineName, dtcuisine, dtrecipe, "Cuisine");
            WindowsFormsUtility.SetControlBinding(txtRecipeName, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtCalories, dtrecipe);
            WindowsFormsUtility.SetControlBinding(lblRecipeStatus, dtrecipe);
            WindowsFormsUtility.SetControlBinding(dtpDateTimeDraft, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtDateTimePublished, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtDateTimeArchived, dtrecipe);
            this.Show();
        }

        private void Save()
        {
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Save(dtrecipe);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hearty Hearth");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }


        //private object? CheckForNull(object? columnvalue, DataRow r, string column)
        //{
        //    object? s = columnvalue;
        //    bool b = columnvalue.ToString() == "";
        //    if (b == false)
        //    {
        //        if(column == "DateTimePublished")
        //        {
        //            s = $", DateTimePublished = '{r["DateTimePublished"]}'";
        //        }
        //        else
        //        {
        //            s = $", DateTimeArchived = '{r["DateTimeArchived"]}'";
        //        }
        //
        //    }
        //    return s;
        //}

        private void Delete()
        {
            var response = MessageBox.Show("Are you sure you want to delete this recipe?", "Hearty Hearth", MessageBoxButtons.YesNo);
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
                MessageBox.Show(ex.Message, "Hearty Hearth");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
    }
}
