namespace RecipeWinForms
{
    partial class frmRecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecipe));
            tblMain = new TableLayoutPanel();
            lblCaptionRecipeName = new Label();
            lblCaptionCalories = new Label();
            lblCaptionRecipeStatus = new Label();
            lblCaptionDateTimeDraft = new Label();
            lblCaptionDateTimePublished = new Label();
            lblCaptionDateTimeArchived = new Label();
            txtRecipeName = new TextBox();
            txtCalories = new TextBox();
            txtDateTimePublished = new TextBox();
            txtDateTimeArchived = new TextBox();
            lblRecipeStatus = new Label();
            dtpDateTimeDraft = new DateTimePicker();
            lblCaptionUserName = new Label();
            lblCaptionCuisineName = new Label();
            lstUserName = new ComboBox();
            lstCuisineName = new ComboBox();
            tsMain = new ToolStrip();
            btnSave = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnDelete = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tblMain.SuspendLayout();
            tsMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(lblCaptionRecipeName, 0, 2);
            tblMain.Controls.Add(lblCaptionCalories, 0, 3);
            tblMain.Controls.Add(lblCaptionRecipeStatus, 0, 4);
            tblMain.Controls.Add(lblCaptionDateTimeDraft, 0, 5);
            tblMain.Controls.Add(lblCaptionDateTimePublished, 0, 6);
            tblMain.Controls.Add(lblCaptionDateTimeArchived, 0, 7);
            tblMain.Controls.Add(txtRecipeName, 1, 2);
            tblMain.Controls.Add(txtCalories, 1, 3);
            tblMain.Controls.Add(txtDateTimePublished, 1, 6);
            tblMain.Controls.Add(txtDateTimeArchived, 1, 7);
            tblMain.Controls.Add(lblRecipeStatus, 1, 4);
            tblMain.Controls.Add(dtpDateTimeDraft, 1, 5);
            tblMain.Controls.Add(lblCaptionUserName, 0, 0);
            tblMain.Controls.Add(lblCaptionCuisineName, 0, 1);
            tblMain.Controls.Add(lstUserName, 1, 0);
            tblMain.Controls.Add(lstCuisineName, 1, 1);
            tblMain.Location = new Point(0, 66);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 8;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblMain.Size = new Size(1025, 508);
            tblMain.TabIndex = 0;
            // 
            // lblCaptionRecipeName
            // 
            lblCaptionRecipeName.Anchor = AnchorStyles.Left;
            lblCaptionRecipeName.AutoSize = true;
            lblCaptionRecipeName.Location = new Point(3, 105);
            lblCaptionRecipeName.Name = "lblCaptionRecipeName";
            lblCaptionRecipeName.Size = new Size(126, 28);
            lblCaptionRecipeName.TabIndex = 4;
            lblCaptionRecipeName.Text = "Recipe Name";
            // 
            // lblCaptionCalories
            // 
            lblCaptionCalories.Anchor = AnchorStyles.Left;
            lblCaptionCalories.AutoSize = true;
            lblCaptionCalories.Location = new Point(3, 175);
            lblCaptionCalories.Name = "lblCaptionCalories";
            lblCaptionCalories.Size = new Size(81, 28);
            lblCaptionCalories.TabIndex = 6;
            lblCaptionCalories.Text = "Calories";
            // 
            // lblCaptionRecipeStatus
            // 
            lblCaptionRecipeStatus.Anchor = AnchorStyles.Left;
            lblCaptionRecipeStatus.AutoSize = true;
            lblCaptionRecipeStatus.Location = new Point(3, 245);
            lblCaptionRecipeStatus.Name = "lblCaptionRecipeStatus";
            lblCaptionRecipeStatus.Size = new Size(127, 28);
            lblCaptionRecipeStatus.TabIndex = 8;
            lblCaptionRecipeStatus.Text = "Recipe Status";
            // 
            // lblCaptionDateTimeDraft
            // 
            lblCaptionDateTimeDraft.Anchor = AnchorStyles.Left;
            lblCaptionDateTimeDraft.AutoSize = true;
            lblCaptionDateTimeDraft.Location = new Point(3, 315);
            lblCaptionDateTimeDraft.Name = "lblCaptionDateTimeDraft";
            lblCaptionDateTimeDraft.Size = new Size(152, 28);
            lblCaptionDateTimeDraft.TabIndex = 10;
            lblCaptionDateTimeDraft.Text = "Date/Time Draft";
            // 
            // lblCaptionDateTimePublished
            // 
            lblCaptionDateTimePublished.Anchor = AnchorStyles.Left;
            lblCaptionDateTimePublished.AutoSize = true;
            lblCaptionDateTimePublished.Location = new Point(3, 385);
            lblCaptionDateTimePublished.Name = "lblCaptionDateTimePublished";
            lblCaptionDateTimePublished.Size = new Size(193, 28);
            lblCaptionDateTimePublished.TabIndex = 12;
            lblCaptionDateTimePublished.Text = "Date/Time Published";
            // 
            // lblCaptionDateTimeArchived
            // 
            lblCaptionDateTimeArchived.Anchor = AnchorStyles.Left;
            lblCaptionDateTimeArchived.AutoSize = true;
            lblCaptionDateTimeArchived.Location = new Point(3, 457);
            lblCaptionDateTimeArchived.Name = "lblCaptionDateTimeArchived";
            lblCaptionDateTimeArchived.Size = new Size(185, 28);
            lblCaptionDateTimeArchived.TabIndex = 14;
            lblCaptionDateTimeArchived.Text = "Date/Time Archived";
            // 
            // txtRecipeName
            // 
            txtRecipeName.Dock = DockStyle.Fill;
            txtRecipeName.Location = new Point(202, 87);
            txtRecipeName.Multiline = true;
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(820, 64);
            txtRecipeName.TabIndex = 5;
            // 
            // txtCalories
            // 
            txtCalories.Dock = DockStyle.Fill;
            txtCalories.Location = new Point(202, 157);
            txtCalories.Multiline = true;
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(820, 64);
            txtCalories.TabIndex = 7;
            // 
            // txtDateTimePublished
            // 
            txtDateTimePublished.BackColor = SystemColors.Window;
            txtDateTimePublished.Dock = DockStyle.Fill;
            txtDateTimePublished.Location = new Point(202, 367);
            txtDateTimePublished.Multiline = true;
            txtDateTimePublished.Name = "txtDateTimePublished";
            txtDateTimePublished.ReadOnly = true;
            txtDateTimePublished.Size = new Size(820, 64);
            txtDateTimePublished.TabIndex = 13;
            // 
            // txtDateTimeArchived
            // 
            txtDateTimeArchived.BackColor = SystemColors.Window;
            txtDateTimeArchived.Dock = DockStyle.Fill;
            txtDateTimeArchived.Location = new Point(202, 437);
            txtDateTimeArchived.Multiline = true;
            txtDateTimeArchived.Name = "txtDateTimeArchived";
            txtDateTimeArchived.ReadOnly = true;
            txtDateTimeArchived.Size = new Size(820, 68);
            txtDateTimeArchived.TabIndex = 15;
            // 
            // lblRecipeStatus
            // 
            lblRecipeStatus.AutoSize = true;
            lblRecipeStatus.BackColor = SystemColors.Window;
            lblRecipeStatus.Dock = DockStyle.Fill;
            lblRecipeStatus.Location = new Point(202, 224);
            lblRecipeStatus.Name = "lblRecipeStatus";
            lblRecipeStatus.Size = new Size(820, 70);
            lblRecipeStatus.TabIndex = 9;
            // 
            // dtpDateTimeDraft
            // 
            dtpDateTimeDraft.Location = new Point(202, 297);
            dtpDateTimeDraft.Name = "dtpDateTimeDraft";
            dtpDateTimeDraft.Size = new Size(331, 34);
            dtpDateTimeDraft.TabIndex = 11;
            // 
            // lblCaptionUserName
            // 
            lblCaptionUserName.Anchor = AnchorStyles.Left;
            lblCaptionUserName.AutoSize = true;
            lblCaptionUserName.Location = new Point(3, 7);
            lblCaptionUserName.Name = "lblCaptionUserName";
            lblCaptionUserName.Size = new Size(99, 28);
            lblCaptionUserName.TabIndex = 0;
            lblCaptionUserName.Text = "Username";
            // 
            // lblCaptionCuisineName
            // 
            lblCaptionCuisineName.Anchor = AnchorStyles.Left;
            lblCaptionCuisineName.AutoSize = true;
            lblCaptionCuisineName.Location = new Point(3, 49);
            lblCaptionCuisineName.Name = "lblCaptionCuisineName";
            lblCaptionCuisineName.Size = new Size(131, 28);
            lblCaptionCuisineName.TabIndex = 2;
            lblCaptionCuisineName.Text = "Cuisine Name";
            // 
            // lstUserName
            // 
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(202, 3);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(253, 36);
            lstUserName.TabIndex = 1;
            // 
            // lstCuisineName
            // 
            lstCuisineName.FormattingEnabled = true;
            lstCuisineName.Location = new Point(202, 45);
            lstCuisineName.Name = "lstCuisineName";
            lstCuisineName.Size = new Size(253, 36);
            lstCuisineName.TabIndex = 3;
            // 
            // tsMain
            // 
            tsMain.ImageScalingSize = new Size(20, 20);
            tsMain.Items.AddRange(new ToolStripItem[] { btnSave, toolStripSeparator1, btnDelete, toolStripSeparator2 });
            tsMain.Location = new Point(0, 0);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(1025, 27);
            tsMain.TabIndex = 0;
            tsMain.Text = "toolStrip1";
            // 
            // btnSave
            // 
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(44, 24);
            btnSave.Text = "&Save";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // btnDelete
            // 
            btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(57, 24);
            btnDelete.Text = "&Delete";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 574);
            Controls.Add(tsMain);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmRecipe";
            Text = "Recipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tsMain.ResumeLayout(false);
            tsMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblCaptionRecipeName;
        private Label lblCaptionCalories;
        private Label lblCaptionRecipeStatus;
        private Label lblCaptionDateTimeDraft;
        private Label lblCaptionDateTimePublished;
        private Label lblCaptionDateTimeArchived;
        private TextBox txtRecipeName;
        private TextBox txtCalories;
        private TextBox txtDateTimePublished;
        private TextBox txtDateTimeArchived;
        private Label lblRecipeStatus;
        private DateTimePicker dtpDateTimeDraft;
        private ToolStrip tsMain;
        private ToolStripButton btnSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnDelete;
        private ToolStripSeparator toolStripSeparator2;
        private Label lblCaptionUserName;
        private Label lblCaptionCuisineName;
        private ComboBox lstUserName;
        private ComboBox lstCuisineName;
    }
}