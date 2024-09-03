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
            toolStrip1 = new ToolStrip();
            btnSave = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnDelete = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tblMain.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(lblCaptionRecipeName, 0, 0);
            tblMain.Controls.Add(lblCaptionCalories, 0, 1);
            tblMain.Controls.Add(lblCaptionRecipeStatus, 0, 2);
            tblMain.Controls.Add(lblCaptionDateTimeDraft, 0, 3);
            tblMain.Controls.Add(lblCaptionDateTimePublished, 0, 4);
            tblMain.Controls.Add(lblCaptionDateTimeArchived, 0, 5);
            tblMain.Controls.Add(txtRecipeName, 1, 0);
            tblMain.Controls.Add(txtCalories, 1, 1);
            tblMain.Controls.Add(txtDateTimePublished, 1, 4);
            tblMain.Controls.Add(txtDateTimeArchived, 1, 5);
            tblMain.Controls.Add(lblRecipeStatus, 1, 2);
            tblMain.Controls.Add(dtpDateTimeDraft, 1, 3);
            tblMain.Location = new Point(0, 66);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 6;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.Size = new Size(1025, 508);
            tblMain.TabIndex = 0;
            // 
            // lblCaptionRecipeName
            // 
            lblCaptionRecipeName.Anchor = AnchorStyles.Left;
            lblCaptionRecipeName.AutoSize = true;
            lblCaptionRecipeName.Location = new Point(3, 28);
            lblCaptionRecipeName.Name = "lblCaptionRecipeName";
            lblCaptionRecipeName.Size = new Size(126, 28);
            lblCaptionRecipeName.TabIndex = 0;
            lblCaptionRecipeName.Text = "Recipe Name";
            // 
            // lblCaptionCalories
            // 
            lblCaptionCalories.Anchor = AnchorStyles.Left;
            lblCaptionCalories.AutoSize = true;
            lblCaptionCalories.Location = new Point(3, 112);
            lblCaptionCalories.Name = "lblCaptionCalories";
            lblCaptionCalories.Size = new Size(81, 28);
            lblCaptionCalories.TabIndex = 2;
            lblCaptionCalories.Text = "Calories";
            // 
            // lblCaptionRecipeStatus
            // 
            lblCaptionRecipeStatus.Anchor = AnchorStyles.Left;
            lblCaptionRecipeStatus.AutoSize = true;
            lblCaptionRecipeStatus.Location = new Point(3, 196);
            lblCaptionRecipeStatus.Name = "lblCaptionRecipeStatus";
            lblCaptionRecipeStatus.Size = new Size(127, 28);
            lblCaptionRecipeStatus.TabIndex = 5;
            lblCaptionRecipeStatus.Text = "Recipe Status";
            // 
            // lblCaptionDateTimeDraft
            // 
            lblCaptionDateTimeDraft.Anchor = AnchorStyles.Left;
            lblCaptionDateTimeDraft.AutoSize = true;
            lblCaptionDateTimeDraft.Location = new Point(3, 280);
            lblCaptionDateTimeDraft.Name = "lblCaptionDateTimeDraft";
            lblCaptionDateTimeDraft.Size = new Size(152, 28);
            lblCaptionDateTimeDraft.TabIndex = 6;
            lblCaptionDateTimeDraft.Text = "Date/Time Draft";
            // 
            // lblCaptionDateTimePublished
            // 
            lblCaptionDateTimePublished.Anchor = AnchorStyles.Left;
            lblCaptionDateTimePublished.AutoSize = true;
            lblCaptionDateTimePublished.Location = new Point(3, 364);
            lblCaptionDateTimePublished.Name = "lblCaptionDateTimePublished";
            lblCaptionDateTimePublished.Size = new Size(193, 28);
            lblCaptionDateTimePublished.TabIndex = 7;
            lblCaptionDateTimePublished.Text = "Date/Time Published";
            // 
            // lblCaptionDateTimeArchived
            // 
            lblCaptionDateTimeArchived.Anchor = AnchorStyles.Left;
            lblCaptionDateTimeArchived.AutoSize = true;
            lblCaptionDateTimeArchived.Location = new Point(3, 450);
            lblCaptionDateTimeArchived.Name = "lblCaptionDateTimeArchived";
            lblCaptionDateTimeArchived.Size = new Size(185, 28);
            lblCaptionDateTimeArchived.TabIndex = 8;
            lblCaptionDateTimeArchived.Text = "Date/Time Archived";
            // 
            // txtRecipeName
            // 
            txtRecipeName.Dock = DockStyle.Fill;
            txtRecipeName.Location = new Point(202, 3);
            txtRecipeName.Multiline = true;
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(820, 78);
            txtRecipeName.TabIndex = 9;
            // 
            // txtCalories
            // 
            txtCalories.Dock = DockStyle.Fill;
            txtCalories.Location = new Point(202, 87);
            txtCalories.Multiline = true;
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(820, 78);
            txtCalories.TabIndex = 11;
            // 
            // txtDateTimePublished
            // 
            txtDateTimePublished.Dock = DockStyle.Fill;
            txtDateTimePublished.Location = new Point(202, 339);
            txtDateTimePublished.Multiline = true;
            txtDateTimePublished.Name = "txtDateTimePublished";
            txtDateTimePublished.Size = new Size(820, 78);
            txtDateTimePublished.TabIndex = 16;
            // 
            // txtDateTimeArchived
            // 
            txtDateTimeArchived.Dock = DockStyle.Fill;
            txtDateTimeArchived.Location = new Point(202, 423);
            txtDateTimeArchived.Multiline = true;
            txtDateTimeArchived.Name = "txtDateTimeArchived";
            txtDateTimeArchived.Size = new Size(820, 82);
            txtDateTimeArchived.TabIndex = 17;
            // 
            // lblRecipeStatus
            // 
            lblRecipeStatus.AutoSize = true;
            lblRecipeStatus.BackColor = SystemColors.Window;
            lblRecipeStatus.Dock = DockStyle.Fill;
            lblRecipeStatus.Location = new Point(202, 168);
            lblRecipeStatus.Name = "lblRecipeStatus";
            lblRecipeStatus.Size = new Size(820, 84);
            lblRecipeStatus.TabIndex = 18;
            // 
            // dtpDateTimeDraft
            // 
            dtpDateTimeDraft.Location = new Point(202, 255);
            dtpDateTimeDraft.Name = "dtpDateTimeDraft";
            dtpDateTimeDraft.Size = new Size(331, 34);
            dtpDateTimeDraft.TabIndex = 19;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnSave, toolStripSeparator1, btnDelete, toolStripSeparator2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1025, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
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
            Controls.Add(toolStrip1);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmRecipe";
            Text = "Recipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
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
        private ToolStrip toolStrip1;
        private ToolStripButton btnSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnDelete;
        private ToolStripSeparator toolStripSeparator2;
    }
}