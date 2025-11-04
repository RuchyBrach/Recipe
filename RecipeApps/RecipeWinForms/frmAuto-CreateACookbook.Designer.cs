namespace RecipeWinForms
{
    partial class frmAuto_CreateACookbook
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
            lstUserName = new ComboBox();
            btnCreateCookbook = new Button();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.248867F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.502262F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.248867F));
            tblMain.Controls.Add(lstUserName, 0, 0);
            tblMain.Controls.Add(btnCreateCookbook, 2, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 1;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.Size = new Size(736, 226);
            tblMain.TabIndex = 0;
            // 
            // lstUserName
            // 
            lstUserName.Anchor = AnchorStyles.Right;
            lstUserName.Font = new Font("Segoe UI", 13.8F);
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(115, 93);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(215, 39);
            lstUserName.TabIndex = 0;
            // 
            // btnCreateCookbook
            // 
            btnCreateCookbook.Anchor = AnchorStyles.Left;
            btnCreateCookbook.AutoSize = true;
            btnCreateCookbook.Font = new Font("Segoe UI", 13.8F);
            btnCreateCookbook.Location = new Point(405, 89);
            btnCreateCookbook.Name = "btnCreateCookbook";
            btnCreateCookbook.Size = new Size(240, 48);
            btnCreateCookbook.TabIndex = 1;
            btnCreateCookbook.Text = "Create Cookbook";
            btnCreateCookbook.UseVisualStyleBackColor = true;
            // 
            // frmAuto_CreateACookbook
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 226);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmAuto_CreateACookbook";
            Text = "Auto-Create A Cookbook";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnCreateCookbook;
        private ComboBox lstUserName;
    }
}