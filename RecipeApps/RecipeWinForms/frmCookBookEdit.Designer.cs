namespace RecipeWinForms
{
    partial class frmCookBookEdit
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
            tblCookBookRecipes = new TableLayoutPanel();
            btnSaveRecipe = new Button();
            gCookBookRecipe = new DataGridView();
            btnDelete = new Button();
            lblCookbookName = new Label();
            lblUser = new Label();
            txtCookbookName = new TextBox();
            lstUserName = new ComboBox();
            lblDateCreated = new Label();
            lblPrice = new Label();
            lblActive = new Label();
            txtPrice = new TextBox();
            txtCookBookDateCreated = new TextBox();
            cbxCookBookActive = new CheckBox();
            btnSave = new Button();
            tblMain.SuspendLayout();
            tblCookBookRecipes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gCookBookRecipe).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.Controls.Add(tblCookBookRecipes, 0, 6);
            tblMain.Controls.Add(btnDelete, 1, 0);
            tblMain.Controls.Add(lblCookbookName, 0, 1);
            tblMain.Controls.Add(lblUser, 0, 2);
            tblMain.Controls.Add(txtCookbookName, 1, 1);
            tblMain.Controls.Add(lstUserName, 1, 2);
            tblMain.Controls.Add(lblDateCreated, 2, 3);
            tblMain.Controls.Add(lblPrice, 0, 4);
            tblMain.Controls.Add(lblActive, 0, 5);
            tblMain.Controls.Add(txtPrice, 1, 4);
            tblMain.Controls.Add(txtCookBookDateCreated, 2, 4);
            tblMain.Controls.Add(cbxCookBookActive, 1, 5);
            tblMain.Controls.Add(btnSave, 0, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 7;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.Size = new Size(638, 630);
            tblMain.TabIndex = 0;
            // 
            // tblCookBookRecipes
            // 
            tblCookBookRecipes.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tblCookBookRecipes.ColumnCount = 1;
            tblMain.SetColumnSpan(tblCookBookRecipes, 3);
            tblCookBookRecipes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblCookBookRecipes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblCookBookRecipes.Controls.Add(btnSaveRecipe, 0, 0);
            tblCookBookRecipes.Controls.Add(gCookBookRecipe, 0, 1);
            tblCookBookRecipes.Dock = DockStyle.Fill;
            tblCookBookRecipes.Location = new Point(3, 259);
            tblCookBookRecipes.Name = "tblCookBookRecipes";
            tblCookBookRecipes.RowCount = 2;
            tblCookBookRecipes.RowStyles.Add(new RowStyle());
            tblCookBookRecipes.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblCookBookRecipes.Size = new Size(632, 368);
            tblCookBookRecipes.TabIndex = 0;
            // 
            // btnSaveRecipe
            // 
            btnSaveRecipe.AutoSize = true;
            btnSaveRecipe.Location = new Point(4, 4);
            btnSaveRecipe.Name = "btnSaveRecipe";
            btnSaveRecipe.Size = new Size(94, 38);
            btnSaveRecipe.TabIndex = 0;
            btnSaveRecipe.Text = "Save";
            btnSaveRecipe.UseVisualStyleBackColor = true;
            // 
            // gCookBookRecipe
            // 
            gCookBookRecipe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gCookBookRecipe.Dock = DockStyle.Fill;
            gCookBookRecipe.Location = new Point(4, 49);
            gCookBookRecipe.Name = "gCookBookRecipe";
            gCookBookRecipe.RowHeadersWidth = 51;
            gCookBookRecipe.Size = new Size(624, 315);
            gCookBookRecipe.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Left;
            btnDelete.AutoSize = true;
            btnDelete.Location = new Point(170, 16);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 38);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblCookbookName
            // 
            lblCookbookName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblCookbookName.AutoSize = true;
            lblCookbookName.Location = new Point(3, 76);
            lblCookbookName.Name = "lblCookbookName";
            lblCookbookName.Size = new Size(161, 28);
            lblCookbookName.TabIndex = 3;
            lblCookbookName.Text = "Cookbook Name";
            // 
            // lblUser
            // 
            lblUser.Anchor = AnchorStyles.Left;
            lblUser.AutoSize = true;
            lblUser.Location = new Point(3, 117);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(51, 28);
            lblUser.TabIndex = 5;
            lblUser.Text = "User";
            // 
            // txtCookbookName
            // 
            tblMain.SetColumnSpan(txtCookbookName, 2);
            txtCookbookName.Dock = DockStyle.Fill;
            txtCookbookName.Location = new Point(170, 73);
            txtCookbookName.Margin = new Padding(3, 3, 15, 3);
            txtCookbookName.Name = "txtCookbookName";
            txtCookbookName.Size = new Size(453, 34);
            txtCookbookName.TabIndex = 4;
            // 
            // lstUserName
            // 
            tblMain.SetColumnSpan(lstUserName, 2);
            lstUserName.Dock = DockStyle.Fill;
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(170, 113);
            lstUserName.Margin = new Padding(3, 3, 15, 3);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(453, 36);
            lstUserName.TabIndex = 6;
            // 
            // lblDateCreated
            // 
            lblDateCreated.Anchor = AnchorStyles.Right;
            lblDateCreated.AutoSize = true;
            lblDateCreated.Location = new Point(493, 152);
            lblDateCreated.Margin = new Padding(3, 0, 15, 0);
            lblDateCreated.Name = "lblDateCreated";
            lblDateCreated.Size = new Size(130, 28);
            lblDateCreated.TabIndex = 7;
            lblDateCreated.Text = "Date Created:";
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Left;
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(3, 186);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(54, 28);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Price";
            // 
            // lblActive
            // 
            lblActive.AutoSize = true;
            lblActive.Location = new Point(3, 220);
            lblActive.Name = "lblActive";
            lblActive.Size = new Size(66, 28);
            lblActive.TabIndex = 11;
            lblActive.Text = "Active";
            // 
            // txtPrice
            // 
            txtPrice.Anchor = AnchorStyles.Left;
            txtPrice.Location = new Point(170, 183);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 34);
            txtPrice.TabIndex = 9;
            // 
            // txtCookBookDateCreated
            // 
            txtCookBookDateCreated.Anchor = AnchorStyles.Right;
            txtCookBookDateCreated.Location = new Point(449, 183);
            txtCookBookDateCreated.Margin = new Padding(3, 3, 15, 3);
            txtCookBookDateCreated.Name = "txtCookBookDateCreated";
            txtCookBookDateCreated.ReadOnly = true;
            txtCookBookDateCreated.Size = new Size(174, 34);
            txtCookBookDateCreated.TabIndex = 10;
            // 
            // cbxCookBookActive
            // 
            cbxCookBookActive.Anchor = AnchorStyles.Left;
            cbxCookBookActive.Location = new Point(170, 223);
            cbxCookBookActive.Name = "cbxCookBookActive";
            cbxCookBookActive.Size = new Size(137, 30);
            cbxCookBookActive.TabIndex = 12;
            cbxCookBookActive.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Left;
            btnSave.AutoSize = true;
            btnSave.Location = new Point(3, 16);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 38);
            btnSave.TabIndex = 1;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // frmCookBookEdit
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 630);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmCookBookEdit";
            Text = "Cookbook";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblCookBookRecipes.ResumeLayout(false);
            tblCookBookRecipes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gCookBookRecipe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblCookBookRecipes;
        private Button btnSave;
        private Button btnDelete;
        private Label lblCookbookName;
        private Label lblUser;
        private TextBox txtCookbookName;
        private ComboBox lstUserName;
        private Label lblDateCreated;
        private Label lblPrice;
        private Label lblActive;
        private Button btnSaveRecipe;
        private DataGridView gCookBookRecipe;
        private TextBox txtPrice;
        private TextBox txtCookBookDateCreated;
        private CheckBox cbxCookBookActive;
    }
}