namespace RecipeWinForms
{
    partial class frmCloneaRecipe
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
            lstRecipeName = new ComboBox();
            btnClone = new Button();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 372F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblMain.Controls.Add(lstRecipeName, 0, 0);
            tblMain.Controls.Add(btnClone, 0, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMain.Size = new Size(713, 182);
            tblMain.TabIndex = 0;
            // 
            // lstRecipeName
            // 
            lstRecipeName.Anchor = AnchorStyles.Right;
            lstRecipeName.FormattingEnabled = true;
            lstRecipeName.Location = new Point(20, 20);
            lstRecipeName.Margin = new Padding(20, 20, 3, 20);
            lstRecipeName.Name = "lstRecipeName";
            lstRecipeName.Size = new Size(318, 36);
            lstRecipeName.TabIndex = 0;
            // 
            // btnClone
            // 
            btnClone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClone.AutoSize = true;
            btnClone.Location = new Point(244, 79);
            btnClone.Name = "btnClone";
            btnClone.Size = new Size(94, 38);
            btnClone.TabIndex = 1;
            btnClone.Text = "Clone";
            btnClone.UseVisualStyleBackColor = true;
            // 
            // frmCloneaRecipe
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 182);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmCloneaRecipe";
            Text = "Hearty Hearth - Clone a Recipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private ComboBox lstRecipeName;
        private Button btnClone;
    }
}