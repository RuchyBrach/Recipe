namespace RecipeWinForms
{
    partial class frmRecipeEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecipeEdit));
            tblMain = new TableLayoutPanel();
            lblRecipeName = new Label();
            lblUser = new Label();
            lblCuisine = new Label();
            lblNumCalories = new Label();
            lblCurrentStatus = new Label();
            lblStatusDates = new Label();
            lblDrafted = new Label();
            lblPublished = new Label();
            lblArchived = new Label();
            txtRecipeName = new TextBox();
            txtCalories = new TextBox();
            lstUserName = new ComboBox();
            lstCuisineName = new ComboBox();
            txtRecipeStatus = new TextBox();
            txtDateTimeDraft = new TextBox();
            txtDateTimePublished = new TextBox();
            txtDateTimeArchived = new TextBox();
            tbChildRecords = new TabControl();
            tbIngredients = new TabPage();
            tblIngredients = new TableLayoutPanel();
            gIngredients = new DataGridView();
            btnSaveRecipeIngredient = new Button();
            tbDirections = new TabPage();
            tblDirections = new TableLayoutPanel();
            btnSaveDirection = new Button();
            gDirections = new DataGridView();
            tsMain = new ToolStrip();
            btnSave = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnDelete = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnChangeStatus = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            tblMain.SuspendLayout();
            tbChildRecords.SuspendLayout();
            tbIngredients.SuspendLayout();
            tblIngredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gIngredients).BeginInit();
            tbDirections.SuspendLayout();
            tblDirections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gDirections).BeginInit();
            tsMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tblMain.ColumnCount = 4;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222214F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222214F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222214F));
            tblMain.Controls.Add(lblRecipeName, 0, 0);
            tblMain.Controls.Add(lblUser, 0, 1);
            tblMain.Controls.Add(lblCuisine, 0, 2);
            tblMain.Controls.Add(lblNumCalories, 0, 3);
            tblMain.Controls.Add(lblCurrentStatus, 0, 4);
            tblMain.Controls.Add(lblStatusDates, 0, 6);
            tblMain.Controls.Add(lblDrafted, 1, 5);
            tblMain.Controls.Add(lblPublished, 2, 5);
            tblMain.Controls.Add(lblArchived, 3, 5);
            tblMain.Controls.Add(txtRecipeName, 1, 0);
            tblMain.Controls.Add(txtCalories, 1, 3);
            tblMain.Controls.Add(lstUserName, 1, 1);
            tblMain.Controls.Add(lstCuisineName, 1, 2);
            tblMain.Controls.Add(txtRecipeStatus, 1, 4);
            tblMain.Controls.Add(txtDateTimeDraft, 1, 6);
            tblMain.Controls.Add(txtDateTimePublished, 2, 6);
            tblMain.Controls.Add(txtDateTimeArchived, 3, 6);
            tblMain.Controls.Add(tbChildRecords, 0, 7);
            tblMain.Location = new Point(0, 38);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 8;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.507509F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.50750732F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.50750732F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.50750732F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.50750732F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.50750732F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.50750732F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 47.44745F));
            tblMain.Size = new Size(713, 593);
            tblMain.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            lblRecipeName.AutoSize = true;
            lblRecipeName.Dock = DockStyle.Fill;
            lblRecipeName.Location = new Point(3, 0);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(231, 44);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.Text = "Recipe Name";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(3, 44);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(51, 28);
            lblUser.TabIndex = 2;
            lblUser.Text = "User";
            // 
            // lblCuisine
            // 
            lblCuisine.AutoSize = true;
            lblCuisine.Dock = DockStyle.Fill;
            lblCuisine.Location = new Point(3, 88);
            lblCuisine.Name = "lblCuisine";
            lblCuisine.Size = new Size(231, 44);
            lblCuisine.TabIndex = 4;
            lblCuisine.Text = "Cuisine";
            // 
            // lblNumCalories
            // 
            lblNumCalories.AutoSize = true;
            lblNumCalories.Dock = DockStyle.Fill;
            lblNumCalories.Location = new Point(3, 132);
            lblNumCalories.Name = "lblNumCalories";
            lblNumCalories.Size = new Size(231, 44);
            lblNumCalories.TabIndex = 6;
            lblNumCalories.Text = "Num Calories";
            // 
            // lblCurrentStatus
            // 
            lblCurrentStatus.AutoSize = true;
            lblCurrentStatus.Dock = DockStyle.Fill;
            lblCurrentStatus.Location = new Point(3, 176);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(231, 44);
            lblCurrentStatus.TabIndex = 8;
            lblCurrentStatus.Text = "Current Status";
            // 
            // lblStatusDates
            // 
            lblStatusDates.AutoSize = true;
            lblStatusDates.Dock = DockStyle.Fill;
            lblStatusDates.Location = new Point(3, 264);
            lblStatusDates.Name = "lblStatusDates";
            lblStatusDates.Size = new Size(231, 44);
            lblStatusDates.TabIndex = 13;
            lblStatusDates.Text = "Status Dates";
            // 
            // lblDrafted
            // 
            lblDrafted.AutoSize = true;
            lblDrafted.Dock = DockStyle.Fill;
            lblDrafted.Location = new Point(240, 220);
            lblDrafted.Name = "lblDrafted";
            lblDrafted.Size = new Size(152, 44);
            lblDrafted.TabIndex = 10;
            lblDrafted.Text = "Drafted";
            lblDrafted.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPublished
            // 
            lblPublished.AutoSize = true;
            lblPublished.Dock = DockStyle.Fill;
            lblPublished.Location = new Point(398, 220);
            lblPublished.Name = "lblPublished";
            lblPublished.Size = new Size(152, 44);
            lblPublished.TabIndex = 11;
            lblPublished.Text = "Published";
            lblPublished.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblArchived
            // 
            lblArchived.AutoSize = true;
            lblArchived.Dock = DockStyle.Fill;
            lblArchived.Location = new Point(556, 220);
            lblArchived.Name = "lblArchived";
            lblArchived.Size = new Size(154, 44);
            lblArchived.TabIndex = 12;
            lblArchived.Text = "Archived";
            lblArchived.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtRecipeName
            // 
            tblMain.SetColumnSpan(txtRecipeName, 3);
            txtRecipeName.Dock = DockStyle.Fill;
            txtRecipeName.Location = new Point(240, 3);
            txtRecipeName.Margin = new Padding(3, 3, 25, 3);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(448, 34);
            txtRecipeName.TabIndex = 1;
            // 
            // txtCalories
            // 
            tblMain.SetColumnSpan(txtCalories, 3);
            txtCalories.Dock = DockStyle.Fill;
            txtCalories.Location = new Point(240, 135);
            txtCalories.Margin = new Padding(3, 3, 25, 3);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(448, 34);
            txtCalories.TabIndex = 7;
            // 
            // lstUserName
            // 
            tblMain.SetColumnSpan(lstUserName, 3);
            lstUserName.Dock = DockStyle.Fill;
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(240, 47);
            lstUserName.Margin = new Padding(3, 3, 25, 3);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(448, 36);
            lstUserName.TabIndex = 3;
            // 
            // lstCuisineName
            // 
            tblMain.SetColumnSpan(lstCuisineName, 3);
            lstCuisineName.Dock = DockStyle.Fill;
            lstCuisineName.FormattingEnabled = true;
            lstCuisineName.Location = new Point(240, 91);
            lstCuisineName.Margin = new Padding(3, 3, 25, 3);
            lstCuisineName.Name = "lstCuisineName";
            lstCuisineName.Size = new Size(448, 36);
            lstCuisineName.TabIndex = 5;
            // 
            // txtRecipeStatus
            // 
            tblMain.SetColumnSpan(txtRecipeStatus, 3);
            txtRecipeStatus.Dock = DockStyle.Fill;
            txtRecipeStatus.Location = new Point(240, 179);
            txtRecipeStatus.Margin = new Padding(3, 3, 25, 3);
            txtRecipeStatus.Name = "txtRecipeStatus";
            txtRecipeStatus.ReadOnly = true;
            txtRecipeStatus.Size = new Size(448, 34);
            txtRecipeStatus.TabIndex = 9;
            // 
            // txtDateTimeDraft
            // 
            txtDateTimeDraft.Dock = DockStyle.Fill;
            txtDateTimeDraft.Location = new Point(240, 267);
            txtDateTimeDraft.Name = "txtDateTimeDraft";
            txtDateTimeDraft.ReadOnly = true;
            txtDateTimeDraft.Size = new Size(152, 34);
            txtDateTimeDraft.TabIndex = 14;
            // 
            // txtDateTimePublished
            // 
            txtDateTimePublished.Dock = DockStyle.Fill;
            txtDateTimePublished.Location = new Point(398, 267);
            txtDateTimePublished.Name = "txtDateTimePublished";
            txtDateTimePublished.ReadOnly = true;
            txtDateTimePublished.Size = new Size(152, 34);
            txtDateTimePublished.TabIndex = 15;
            // 
            // txtDateTimeArchived
            // 
            txtDateTimeArchived.Dock = DockStyle.Fill;
            txtDateTimeArchived.Location = new Point(556, 267);
            txtDateTimeArchived.Name = "txtDateTimeArchived";
            txtDateTimeArchived.ReadOnly = true;
            txtDateTimeArchived.Size = new Size(154, 34);
            txtDateTimeArchived.TabIndex = 16;
            // 
            // tbChildRecords
            // 
            tblMain.SetColumnSpan(tbChildRecords, 4);
            tbChildRecords.Controls.Add(tbIngredients);
            tbChildRecords.Controls.Add(tbDirections);
            tbChildRecords.Dock = DockStyle.Fill;
            tbChildRecords.Location = new Point(3, 311);
            tbChildRecords.Name = "tbChildRecords";
            tbChildRecords.SelectedIndex = 0;
            tbChildRecords.Size = new Size(707, 279);
            tbChildRecords.TabIndex = 17;
            // 
            // tbIngredients
            // 
            tbIngredients.Controls.Add(tblIngredients);
            tbIngredients.ForeColor = SystemColors.ControlDarkDark;
            tbIngredients.Location = new Point(4, 37);
            tbIngredients.Name = "tbIngredients";
            tbIngredients.Padding = new Padding(3);
            tbIngredients.Size = new Size(699, 238);
            tbIngredients.TabIndex = 0;
            tbIngredients.Text = "Ingredients";
            tbIngredients.UseVisualStyleBackColor = true;
            // 
            // tblIngredients
            // 
            tblIngredients.ColumnCount = 1;
            tblIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblIngredients.Controls.Add(gIngredients, 0, 1);
            tblIngredients.Controls.Add(btnSaveRecipeIngredient, 0, 0);
            tblIngredients.Dock = DockStyle.Fill;
            tblIngredients.Location = new Point(3, 3);
            tblIngredients.Name = "tblIngredients";
            tblIngredients.RowCount = 2;
            tblIngredients.RowStyles.Add(new RowStyle());
            tblIngredients.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblIngredients.Size = new Size(693, 232);
            tblIngredients.TabIndex = 1;
            // 
            // gIngredients
            // 
            gIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gIngredients.Dock = DockStyle.Fill;
            gIngredients.Location = new Point(3, 47);
            gIngredients.Name = "gIngredients";
            gIngredients.RowHeadersWidth = 51;
            gIngredients.Size = new Size(687, 182);
            gIngredients.TabIndex = 1;
            // 
            // btnSaveRecipeIngredient
            // 
            btnSaveRecipeIngredient.AutoSize = true;
            btnSaveRecipeIngredient.ForeColor = SystemColors.ControlText;
            btnSaveRecipeIngredient.Location = new Point(3, 3);
            btnSaveRecipeIngredient.Name = "btnSaveRecipeIngredient";
            btnSaveRecipeIngredient.Size = new Size(94, 38);
            btnSaveRecipeIngredient.TabIndex = 0;
            btnSaveRecipeIngredient.Text = "Save";
            btnSaveRecipeIngredient.UseVisualStyleBackColor = true;
            // 
            // tbDirections
            // 
            tbDirections.Controls.Add(tblDirections);
            tbDirections.Location = new Point(4, 37);
            tbDirections.Name = "tbDirections";
            tbDirections.Padding = new Padding(3);
            tbDirections.Size = new Size(699, 238);
            tbDirections.TabIndex = 1;
            tbDirections.Text = "Directions";
            tbDirections.UseVisualStyleBackColor = true;
            // 
            // tblDirections
            // 
            tblDirections.ColumnCount = 1;
            tblDirections.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblDirections.Controls.Add(btnSaveDirection, 0, 0);
            tblDirections.Controls.Add(gDirections, 0, 1);
            tblDirections.Dock = DockStyle.Fill;
            tblDirections.Location = new Point(3, 3);
            tblDirections.Name = "tblDirections";
            tblDirections.RowCount = 2;
            tblDirections.RowStyles.Add(new RowStyle());
            tblDirections.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDirections.Size = new Size(693, 232);
            tblDirections.TabIndex = 0;
            // 
            // btnSaveDirection
            // 
            btnSaveDirection.AutoSize = true;
            btnSaveDirection.Location = new Point(3, 3);
            btnSaveDirection.Name = "btnSaveDirection";
            btnSaveDirection.Size = new Size(94, 38);
            btnSaveDirection.TabIndex = 0;
            btnSaveDirection.Text = "Save";
            btnSaveDirection.UseVisualStyleBackColor = true;
            // 
            // gDirections
            // 
            gDirections.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gDirections.Dock = DockStyle.Fill;
            gDirections.Location = new Point(3, 47);
            gDirections.Name = "gDirections";
            gDirections.RowHeadersWidth = 51;
            gDirections.Size = new Size(687, 182);
            gDirections.TabIndex = 1;
            // 
            // tsMain
            // 
            tsMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tsMain.ImageScalingSize = new Size(20, 20);
            tsMain.Items.AddRange(new ToolStripItem[] { btnSave, toolStripSeparator1, btnDelete, toolStripSeparator2, btnChangeStatus, toolStripSeparator3 });
            tsMain.Location = new Point(0, 0);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(713, 35);
            tsMain.TabIndex = 0;
            tsMain.TabStop = true;
            tsMain.Text = "toolStrip1";
            // 
            // btnSave
            // 
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(57, 32);
            btnSave.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 35);
            // 
            // btnDelete
            // 
            btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(72, 32);
            btnDelete.Text = "Delete";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 35);
            // 
            // btnChangeStatus
            // 
            btnChangeStatus.Alignment = ToolStripItemAlignment.Right;
            btnChangeStatus.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnChangeStatus.Image = (Image)resources.GetObject("btnChangeStatus.Image");
            btnChangeStatus.ImageTransparentColor = Color.Magenta;
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Size = new Size(140, 32);
            btnChangeStatus.Text = "Change Status";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 35);
            // 
            // frmRecipeEdit
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 630);
            Controls.Add(tsMain);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmRecipeEdit";
            Text = "Recipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tbChildRecords.ResumeLayout(false);
            tbIngredients.ResumeLayout(false);
            tblIngredients.ResumeLayout(false);
            tblIngredients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gIngredients).EndInit();
            tbDirections.ResumeLayout(false);
            tblDirections.ResumeLayout(false);
            tblDirections.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gDirections).EndInit();
            tsMain.ResumeLayout(false);
            tsMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tblMain;
        private ToolStrip tsMain;
        private ToolStripButton btnSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnDelete;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnChangeStatus;
        private ToolStripSeparator toolStripSeparator3;
        private Label lblRecipeName;
        private Label lblUser;
        private Label lblCuisine;
        private Label lblNumCalories;
        private Label lblCurrentStatus;
        private Label lblStatusDates;
        private Label lblDrafted;
        private Label lblPublished;
        private Label lblArchived;
        private TextBox txtRecipeName;
        private TextBox txtCalories;
        private ComboBox lstUserName;
        private ComboBox lstCuisineName;
        private TextBox txtRecipeStatus;
        private TextBox txtDateTimeDraft;
        private TextBox txtDateTimePublished;
        private TextBox txtDateTimeArchived;
        private TabControl tbChildRecords;
        private TabPage tbIngredients;
        private TabPage tbDirections;
        private DataGridView gIngredients;
        private TableLayoutPanel tblIngredients;
        private Button btnSaveRecipeIngredient;
        private TableLayoutPanel tblDirections;
        private Button btnSaveDirection;
        private DataGridView gDirections;
    }
}