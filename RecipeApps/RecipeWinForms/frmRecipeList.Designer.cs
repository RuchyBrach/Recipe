namespace RecipeWinForms
{
    partial class frmRecipeList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tblMain = new TableLayoutPanel();
            btnNewRecipe = new Button();
            gRecipeList = new DataGridView();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipeList).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.Controls.Add(btnNewRecipe, 0, 0);
            tblMain.Controls.Add(gRecipeList, 0, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMain.Size = new Size(1000, 609);
            tblMain.TabIndex = 0;
            // 
            // btnNewRecipe
            // 
            btnNewRecipe.Anchor = AnchorStyles.Left;
            btnNewRecipe.AutoSize = true;
            btnNewRecipe.Location = new Point(3, 15);
            btnNewRecipe.Margin = new Padding(3, 15, 3, 15);
            btnNewRecipe.Name = "btnNewRecipe";
            btnNewRecipe.Size = new Size(168, 38);
            btnNewRecipe.TabIndex = 0;
            btnNewRecipe.Text = "New Recipe";
            btnNewRecipe.UseVisualStyleBackColor = true;
            // 
            // gRecipeList
            // 
            gRecipeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gRecipeList.Dock = DockStyle.Fill;
            gRecipeList.Location = new Point(3, 71);
            gRecipeList.MultiSelect = false;
            gRecipeList.Name = "gRecipeList";
            gRecipeList.RowHeadersWidth = 51;
            gRecipeList.Size = new Size(994, 535);
            gRecipeList.TabIndex = 1;
            // 
            // frmRecipeList
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 609);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmRecipeList";
            Text = "Recipe List";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipeList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnNewRecipe;
        private DataGridView gRecipeList;
    }
}