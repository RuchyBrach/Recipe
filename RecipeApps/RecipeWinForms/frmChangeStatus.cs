using System.Data;
using System.Diagnostics;

namespace RecipeWinForms
{

    public partial class frmChangeStatus : Form
    {
        DataTable dtrecipe = new();
        BindingSource bindsource = new();
        int recipeid = 0;
        List<Button> lstButton;

        public frmChangeStatus()
        {
            InitializeComponent();
            lblRecipeStatus.TextChanged += LblRecipeStatus_TextChanged;
            lstButton = new() { btnDraft, btnPublish, btnArchive };
            lstButton.ForEach(b => b.Click += B_Click);
        }

        

        public void LoadForm(int recipeval)
        {
            recipeid = recipeval;
            this.Tag = recipeid;
            dtrecipe = Recipe.Load(recipeid);
            bindsource.DataSource = dtrecipe;
            WindowsFormsUtility.SetControlBinding(lblRecipeName, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateTimeDraft, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateTimePublished, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateTimeArchived, bindsource);
            WindowsFormsUtility.SetControlBinding(lblRecipeStatus, bindsource);
        }

        private void EnableDisableStatusButtons()
        {
            Debug.WriteLine(lblRecipeStatus.Text);
            foreach (Button b in lstButton)
            {
                b.Enabled = true;
                if (lblRecipeStatus.Text.Contains(b.Text))
                {
                    b.Enabled = false;
                }
            }
        }

        private void ChangeStatus(string status)
        {
            string date = DateTime.Now.ToString();
            DataRow r = dtrecipe.Rows[0];
            switch (status)
            {
                case "draft":
                    r["DateTimeArchived"] = DBNull.Value;
                    r["DateTimePublished"] = DBNull.Value;
                    r["DateTimeDraft"] = date;
                    break;
                case "publish":
                    r["DateTimeArchived"] = DBNull.Value;
                    r["DateTimePublished"] = date;
                    break;
                case "archive":
                    r["DateTimeArchived"] = date;
                    break;
            }
            
            
        }


        private void UpdateStatus(object? sender)
        {
            if (sender is Button btn)
            {
                string status = btn.Text.ToLower();
                var response = MessageBox.Show($"Are you sure you want to {status} this recipe?", Application.ProductName, MessageBoxButtons.YesNo);
                if (response == DialogResult.No)
                {
                    return;
                }
                Application.UseWaitCursor = true;
                try
                {
                    ChangeStatus(status);
                    Recipe.SaveStatus(dtrecipe);
                    dtrecipe = Recipe.Load(recipeid);
                    bindsource.DataSource = dtrecipe;
                    EnableDisableStatusButtons();

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
        }


        private void B_Click(object? sender, EventArgs e)
        {
            UpdateStatus(sender);
        }

        

        private void LblRecipeStatus_TextChanged(object? sender, EventArgs e)
        {
            EnableDisableStatusButtons();
        }
    }
}
