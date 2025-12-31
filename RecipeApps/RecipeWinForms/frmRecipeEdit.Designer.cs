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
            tblButtons = new TableLayoutPanel();
            btnSave = new Button();
            btnDelete = new Button();
            btnChangeStatus = new Button();
            tblMain.SuspendLayout();
            tbChildRecords.SuspendLayout();
            tbIngredients.SuspendLayout();
            tblIngredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gIngredients).BeginInit();
            tbDirections.SuspendLayout();
            tblDirections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gDirections).BeginInit();
            tblButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 4;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222252F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222252F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222252F));
            tblMain.Controls.Add(lblRecipeName, 0, 1);
            tblMain.Controls.Add(lblUser, 0, 2);
            tblMain.Controls.Add(lblCuisine, 0, 3);
            tblMain.Controls.Add(lblNumCalories, 0, 4);
            tblMain.Controls.Add(lblCurrentStatus, 0, 5);
            tblMain.Controls.Add(lblStatusDates, 0, 7);
            tblMain.Controls.Add(lblDrafted, 1, 6);
            tblMain.Controls.Add(lblPublished, 2, 6);
            tblMain.Controls.Add(lblArchived, 3, 6);
            tblMain.Controls.Add(txtRecipeName, 1, 1);
            tblMain.Controls.Add(txtCalories, 1, 4);
            tblMain.Controls.Add(lstUserName, 1, 2);
            tblMain.Controls.Add(lstCuisineName, 1, 3);
            tblMain.Controls.Add(txtRecipeStatus, 1, 5);
            tblMain.Controls.Add(txtDateTimeDraft, 1, 7);
            tblMain.Controls.Add(txtDateTimePublished, 2, 7);
            tblMain.Controls.Add(txtDateTimeArchived, 3, 7);
            tblMain.Controls.Add(tbChildRecords, 0, 8);
            tblMain.Controls.Add(tblButtons, 0, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 9;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.50750875F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.50750637F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.50750637F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.50750637F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.50750637F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.50750637F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.50750637F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 47.44745F));
            tblMain.Size = new Size(809, 695);
            tblMain.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            lblRecipeName.AutoSize = true;
            lblRecipeName.Dock = DockStyle.Fill;
            lblRecipeName.Location = new Point(3, 48);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(263, 48);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.Text = "Recipe Name";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(3, 96);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(51, 28);
            lblUser.TabIndex = 2;
            lblUser.Text = "User";
            // 
            // lblCuisine
            // 
            lblCuisine.AutoSize = true;
            lblCuisine.Dock = DockStyle.Fill;
            lblCuisine.Location = new Point(3, 144);
            lblCuisine.Name = "lblCuisine";
            lblCuisine.Size = new Size(263, 48);
            lblCuisine.TabIndex = 4;
            lblCuisine.Text = "Cuisine";
            // 
            // lblNumCalories
            // 
            lblNumCalories.AutoSize = true;
            lblNumCalories.Dock = DockStyle.Fill;
            lblNumCalories.Location = new Point(3, 192);
            lblNumCalories.Name = "lblNumCalories";
            lblNumCalories.Size = new Size(263, 48);
            lblNumCalories.TabIndex = 6;
            lblNumCalories.Text = "Num Calories";
            // 
            // lblCurrentStatus
            // 
            lblCurrentStatus.AutoSize = true;
            lblCurrentStatus.Dock = DockStyle.Fill;
            lblCurrentStatus.Location = new Point(3, 240);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(263, 48);
            lblCurrentStatus.TabIndex = 8;
            lblCurrentStatus.Text = "Current Status";
            // 
            // lblStatusDates
            // 
            lblStatusDates.AutoSize = true;
            lblStatusDates.Dock = DockStyle.Fill;
            lblStatusDates.Location = new Point(3, 336);
            lblStatusDates.Name = "lblStatusDates";
            lblStatusDates.Size = new Size(263, 48);
            lblStatusDates.TabIndex = 13;
            lblStatusDates.Text = "Status Dates";
            // 
            // lblDrafted
            // 
            lblDrafted.AutoSize = true;
            lblDrafted.Dock = DockStyle.Fill;
            lblDrafted.Location = new Point(272, 288);
            lblDrafted.Name = "lblDrafted";
            lblDrafted.Size = new Size(173, 48);
            lblDrafted.TabIndex = 10;
            lblDrafted.Text = "Drafted";
            lblDrafted.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPublished
            // 
            lblPublished.AutoSize = true;
            lblPublished.Dock = DockStyle.Fill;
            lblPublished.Location = new Point(451, 288);
            lblPublished.Name = "lblPublished";
            lblPublished.Size = new Size(173, 48);
            lblPublished.TabIndex = 11;
            lblPublished.Text = "Published";
            lblPublished.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblArchived
            // 
            lblArchived.AutoSize = true;
            lblArchived.Dock = DockStyle.Fill;
            lblArchived.Location = new Point(630, 288);
            lblArchived.Name = "lblArchived";
            lblArchived.Size = new Size(176, 48);
            lblArchived.TabIndex = 12;
            lblArchived.Text = "Archived";
            lblArchived.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtRecipeName
            // 
            tblMain.SetColumnSpan(txtRecipeName, 3);
            txtRecipeName.Dock = DockStyle.Fill;
            txtRecipeName.Location = new Point(272, 51);
            txtRecipeName.Margin = new Padding(3, 3, 25, 3);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(512, 34);
            txtRecipeName.TabIndex = 1;
            // 
            // txtCalories
            // 
            tblMain.SetColumnSpan(txtCalories, 3);
            txtCalories.Dock = DockStyle.Fill;
            txtCalories.Location = new Point(272, 195);
            txtCalories.Margin = new Padding(3, 3, 25, 3);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(512, 34);
            txtCalories.TabIndex = 7;
            // 
            // lstUserName
            // 
            tblMain.SetColumnSpan(lstUserName, 3);
            lstUserName.Dock = DockStyle.Fill;
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(272, 99);
            lstUserName.Margin = new Padding(3, 3, 25, 3);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(512, 36);
            lstUserName.TabIndex = 3;
            // 
            // lstCuisineName
            // 
            tblMain.SetColumnSpan(lstCuisineName, 3);
            lstCuisineName.Dock = DockStyle.Fill;
            lstCuisineName.FormattingEnabled = true;
            lstCuisineName.Location = new Point(272, 147);
            lstCuisineName.Margin = new Padding(3, 3, 25, 3);
            lstCuisineName.Name = "lstCuisineName";
            lstCuisineName.Size = new Size(512, 36);
            lstCuisineName.TabIndex = 5;
            // 
            // txtRecipeStatus
            // 
            tblMain.SetColumnSpan(txtRecipeStatus, 3);
            txtRecipeStatus.Dock = DockStyle.Fill;
            txtRecipeStatus.Location = new Point(272, 243);
            txtRecipeStatus.Margin = new Padding(3, 3, 25, 3);
            txtRecipeStatus.Name = "txtRecipeStatus";
            txtRecipeStatus.ReadOnly = true;
            txtRecipeStatus.Size = new Size(512, 34);
            txtRecipeStatus.TabIndex = 9;
            // 
            // txtDateTimeDraft
            // 
            txtDateTimeDraft.Dock = DockStyle.Fill;
            txtDateTimeDraft.Location = new Point(272, 339);
            txtDateTimeDraft.Name = "txtDateTimeDraft";
            txtDateTimeDraft.ReadOnly = true;
            txtDateTimeDraft.Size = new Size(173, 34);
            txtDateTimeDraft.TabIndex = 14;
            // 
            // txtDateTimePublished
            // 
            txtDateTimePublished.Dock = DockStyle.Fill;
            txtDateTimePublished.Location = new Point(451, 339);
            txtDateTimePublished.Name = "txtDateTimePublished";
            txtDateTimePublished.ReadOnly = true;
            txtDateTimePublished.Size = new Size(173, 34);
            txtDateTimePublished.TabIndex = 15;
            // 
            // txtDateTimeArchived
            // 
            txtDateTimeArchived.Dock = DockStyle.Fill;
            txtDateTimeArchived.Location = new Point(630, 339);
            txtDateTimeArchived.Name = "txtDateTimeArchived";
            txtDateTimeArchived.ReadOnly = true;
            txtDateTimeArchived.Size = new Size(176, 34);
            txtDateTimeArchived.TabIndex = 16;
            // 
            // tbChildRecords
            // 
            tblMain.SetColumnSpan(tbChildRecords, 4);
            tbChildRecords.Controls.Add(tbIngredients);
            tbChildRecords.Controls.Add(tbDirections);
            tbChildRecords.Dock = DockStyle.Fill;
            tbChildRecords.Location = new Point(3, 387);
            tbChildRecords.Name = "tbChildRecords";
            tbChildRecords.SelectedIndex = 0;
            tbChildRecords.Size = new Size(803, 305);
            tbChildRecords.TabIndex = 17;
            // 
            // tbIngredients
            // 
            tbIngredients.Controls.Add(tblIngredients);
            tbIngredients.ForeColor = SystemColors.ControlDarkDark;
            tbIngredients.Location = new Point(4, 37);
            tbIngredients.Name = "tbIngredients";
            tbIngredients.Padding = new Padding(3);
            tbIngredients.Size = new Size(795, 264);
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
            tblIngredients.Size = new Size(789, 258);
            tblIngredients.TabIndex = 1;
            // 
            // gIngredients
            // 
            gIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gIngredients.Dock = DockStyle.Fill;
            gIngredients.Location = new Point(3, 47);
            gIngredients.Name = "gIngredients";
            gIngredients.RowHeadersWidth = 51;
            gIngredients.Size = new Size(783, 208);
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
            tbDirections.Location = new Point(4, 29);
            tbDirections.Name = "tbDirections";
            tbDirections.Padding = new Padding(3);
            tbDirections.Size = new Size(795, 272);
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
            tblDirections.Size = new Size(789, 266);
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
            gDirections.Size = new Size(783, 216);
            gDirections.TabIndex = 1;
            // 
            // tblButtons
            // 
            tblButtons.ColumnCount = 3;
            tblMain.SetColumnSpan(tblButtons, 4);
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.75F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.75F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.5F));
            tblButtons.Controls.Add(btnSave, 0, 0);
            tblButtons.Controls.Add(btnDelete, 1, 0);
            tblButtons.Controls.Add(btnChangeStatus, 2, 0);
            tblButtons.Dock = DockStyle.Fill;
            tblButtons.Location = new Point(3, 3);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle());
            tblButtons.Size = new Size(803, 42);
            tblButtons.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top;
            btnSave.AutoSize = true;
            btnSave.Location = new Point(28, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 38);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top;
            btnDelete.AutoSize = true;
            btnDelete.Location = new Point(178, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 38);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnChangeStatus
            // 
            btnChangeStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnChangeStatus.AutoSize = true;
            btnChangeStatus.Location = new Point(624, 3);
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Padding = new Padding(15, 0, 15, 0);
            btnChangeStatus.Size = new Size(176, 38);
            btnChangeStatus.TabIndex = 2;
            btnChangeStatus.Text = "Change Status";
            btnChangeStatus.UseVisualStyleBackColor = true;
            // 
            // frmRecipeEdit
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 695);
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
            tblButtons.ResumeLayout(false);
            tblButtons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
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
        private TableLayoutPanel tblButtons;
        private Button btnSave;
        private Button btnDelete;
        private Button btnChangeStatus;
    }
}