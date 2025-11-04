namespace RecipeWinForms
{
    partial class frmCookbookList
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
            btnNewCookbook = new Button();
            gCookBookList = new DataGridView();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gCookBookList).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(btnNewCookbook, 0, 0);
            tblMain.Controls.Add(gCookBookList, 0, 1);
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.Size = new Size(1100, 630);
            tblMain.TabIndex = 0;
            // 
            // btnNewCookbook
            // 
            btnNewCookbook.Anchor = AnchorStyles.Left;
            btnNewCookbook.AutoSize = true;
            btnNewCookbook.Location = new Point(3, 15);
            btnNewCookbook.Margin = new Padding(3, 15, 3, 15);
            btnNewCookbook.Name = "btnNewCookbook";
            btnNewCookbook.Size = new Size(158, 38);
            btnNewCookbook.TabIndex = 0;
            btnNewCookbook.Text = "New Cookbook";
            btnNewCookbook.UseVisualStyleBackColor = true;
            // 
            // gCookBookList
            // 
            gCookBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gCookBookList.Dock = DockStyle.Fill;
            gCookBookList.Location = new Point(3, 71);
            gCookBookList.Name = "gCookBookList";
            gCookBookList.RowHeadersWidth = 51;
            gCookBookList.Size = new Size(1094, 556);
            gCookBookList.TabIndex = 1;
            // 
            // frmCookbookList
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 630);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmCookbookList";
            Text = "Cookbook List";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gCookBookList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnNewCookbook;
        private DataGridView gCookBookList;
    }
}