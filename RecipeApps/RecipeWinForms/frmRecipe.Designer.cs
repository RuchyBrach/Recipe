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
            tblMain = new TableLayoutPanel();
            lblCaptionRecipeName = new Label();
            lblCaptionCuisineName = new Label();
            lblCaptionCalories = new Label();
            lblCaptionMealName = new Label();
            lblCaptionCourseName = new Label();
            lblCaptionRecipeStatus = new Label();
            lblCaptionDateTimeDraft = new Label();
            lblCaptionDateTimePublished = new Label();
            lblCaptionDateTimeArchived = new Label();
            txtRecipeName = new TextBox();
            txtCuisineName = new TextBox();
            txtCalories = new TextBox();
            txtMealName = new TextBox();
            txtCourseName = new TextBox();
            txtRecipeStatus = new TextBox();
            txtDateTimeDraft = new TextBox();
            txtDateTimePublished = new TextBox();
            txtDateTimeArchived = new TextBox();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(lblCaptionRecipeName, 0, 0);
            tblMain.Controls.Add(lblCaptionCuisineName, 0, 1);
            tblMain.Controls.Add(lblCaptionCalories, 0, 2);
            tblMain.Controls.Add(lblCaptionMealName, 0, 3);
            tblMain.Controls.Add(lblCaptionCourseName, 0, 4);
            tblMain.Controls.Add(lblCaptionRecipeStatus, 0, 5);
            tblMain.Controls.Add(lblCaptionDateTimeDraft, 0, 6);
            tblMain.Controls.Add(lblCaptionDateTimePublished, 0, 7);
            tblMain.Controls.Add(lblCaptionDateTimeArchived, 0, 8);
            tblMain.Controls.Add(txtRecipeName, 1, 0);
            tblMain.Controls.Add(txtCuisineName, 1, 1);
            tblMain.Controls.Add(txtCalories, 1, 2);
            tblMain.Controls.Add(txtMealName, 1, 3);
            tblMain.Controls.Add(txtCourseName, 1, 4);
            tblMain.Controls.Add(txtRecipeStatus, 1, 5);
            tblMain.Controls.Add(txtDateTimeDraft, 1, 6);
            tblMain.Controls.Add(txtDateTimePublished, 1, 7);
            tblMain.Controls.Add(txtDateTimeArchived, 1, 8);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 9;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tblMain.Size = new Size(1025, 574);
            tblMain.TabIndex = 0;
            // 
            // lblCaptionRecipeName
            // 
            lblCaptionRecipeName.Anchor = AnchorStyles.Left;
            lblCaptionRecipeName.AutoSize = true;
            lblCaptionRecipeName.Location = new Point(3, 17);
            lblCaptionRecipeName.Name = "lblCaptionRecipeName";
            lblCaptionRecipeName.Size = new Size(126, 28);
            lblCaptionRecipeName.TabIndex = 0;
            lblCaptionRecipeName.Text = "Recipe Name";
            // 
            // lblCaptionCuisineName
            // 
            lblCaptionCuisineName.Anchor = AnchorStyles.Left;
            lblCaptionCuisineName.AutoSize = true;
            lblCaptionCuisineName.Location = new Point(3, 80);
            lblCaptionCuisineName.Name = "lblCaptionCuisineName";
            lblCaptionCuisineName.Size = new Size(131, 28);
            lblCaptionCuisineName.TabIndex = 1;
            lblCaptionCuisineName.Text = "Cuisine Name";
            // 
            // lblCaptionCalories
            // 
            lblCaptionCalories.Anchor = AnchorStyles.Left;
            lblCaptionCalories.AutoSize = true;
            lblCaptionCalories.Location = new Point(3, 143);
            lblCaptionCalories.Name = "lblCaptionCalories";
            lblCaptionCalories.Size = new Size(81, 28);
            lblCaptionCalories.TabIndex = 2;
            lblCaptionCalories.Text = "Calories";
            // 
            // lblCaptionMealName
            // 
            lblCaptionMealName.Anchor = AnchorStyles.Left;
            lblCaptionMealName.AutoSize = true;
            lblCaptionMealName.Location = new Point(3, 206);
            lblCaptionMealName.Name = "lblCaptionMealName";
            lblCaptionMealName.Size = new Size(112, 28);
            lblCaptionMealName.TabIndex = 3;
            lblCaptionMealName.Text = "Meal Name";
            // 
            // lblCaptionCourseName
            // 
            lblCaptionCourseName.Anchor = AnchorStyles.Left;
            lblCaptionCourseName.AutoSize = true;
            lblCaptionCourseName.Location = new Point(3, 269);
            lblCaptionCourseName.Name = "lblCaptionCourseName";
            lblCaptionCourseName.Size = new Size(129, 28);
            lblCaptionCourseName.TabIndex = 4;
            lblCaptionCourseName.Text = "Course Name";
            // 
            // lblCaptionRecipeStatus
            // 
            lblCaptionRecipeStatus.Anchor = AnchorStyles.Left;
            lblCaptionRecipeStatus.AutoSize = true;
            lblCaptionRecipeStatus.Location = new Point(3, 332);
            lblCaptionRecipeStatus.Name = "lblCaptionRecipeStatus";
            lblCaptionRecipeStatus.Size = new Size(127, 28);
            lblCaptionRecipeStatus.TabIndex = 5;
            lblCaptionRecipeStatus.Text = "Recipe Status";
            // 
            // lblCaptionDateTimeDraft
            // 
            lblCaptionDateTimeDraft.Anchor = AnchorStyles.Left;
            lblCaptionDateTimeDraft.AutoSize = true;
            lblCaptionDateTimeDraft.Location = new Point(3, 395);
            lblCaptionDateTimeDraft.Name = "lblCaptionDateTimeDraft";
            lblCaptionDateTimeDraft.Size = new Size(152, 28);
            lblCaptionDateTimeDraft.TabIndex = 6;
            lblCaptionDateTimeDraft.Text = "Date/Time Draft";
            // 
            // lblCaptionDateTimePublished
            // 
            lblCaptionDateTimePublished.Anchor = AnchorStyles.Left;
            lblCaptionDateTimePublished.AutoSize = true;
            lblCaptionDateTimePublished.Location = new Point(3, 458);
            lblCaptionDateTimePublished.Name = "lblCaptionDateTimePublished";
            lblCaptionDateTimePublished.Size = new Size(193, 28);
            lblCaptionDateTimePublished.TabIndex = 7;
            lblCaptionDateTimePublished.Text = "Date/Time Published";
            // 
            // lblCaptionDateTimeArchived
            // 
            lblCaptionDateTimeArchived.Anchor = AnchorStyles.Left;
            lblCaptionDateTimeArchived.AutoSize = true;
            lblCaptionDateTimeArchived.Location = new Point(3, 525);
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
            txtRecipeName.Size = new Size(820, 57);
            txtRecipeName.TabIndex = 9;
            // 
            // txtCuisineName
            // 
            txtCuisineName.Dock = DockStyle.Fill;
            txtCuisineName.Location = new Point(202, 66);
            txtCuisineName.Multiline = true;
            txtCuisineName.Name = "txtCuisineName";
            txtCuisineName.Size = new Size(820, 57);
            txtCuisineName.TabIndex = 10;
            // 
            // txtCalories
            // 
            txtCalories.Dock = DockStyle.Fill;
            txtCalories.Location = new Point(202, 129);
            txtCalories.Multiline = true;
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(820, 57);
            txtCalories.TabIndex = 11;
            // 
            // txtMealName
            // 
            txtMealName.Dock = DockStyle.Fill;
            txtMealName.Location = new Point(202, 192);
            txtMealName.Multiline = true;
            txtMealName.Name = "txtMealName";
            txtMealName.Size = new Size(820, 57);
            txtMealName.TabIndex = 12;
            // 
            // txtCourseName
            // 
            txtCourseName.Dock = DockStyle.Fill;
            txtCourseName.Location = new Point(202, 255);
            txtCourseName.Multiline = true;
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(820, 57);
            txtCourseName.TabIndex = 13;
            // 
            // txtRecipeStatus
            // 
            txtRecipeStatus.Dock = DockStyle.Fill;
            txtRecipeStatus.Location = new Point(202, 318);
            txtRecipeStatus.Multiline = true;
            txtRecipeStatus.Name = "txtRecipeStatus";
            txtRecipeStatus.Size = new Size(820, 57);
            txtRecipeStatus.TabIndex = 14;
            // 
            // txtDateTimeDraft
            // 
            txtDateTimeDraft.Dock = DockStyle.Fill;
            txtDateTimeDraft.Location = new Point(202, 381);
            txtDateTimeDraft.Multiline = true;
            txtDateTimeDraft.Name = "txtDateTimeDraft";
            txtDateTimeDraft.Size = new Size(820, 57);
            txtDateTimeDraft.TabIndex = 15;
            // 
            // txtDateTimePublished
            // 
            txtDateTimePublished.Dock = DockStyle.Fill;
            txtDateTimePublished.Location = new Point(202, 444);
            txtDateTimePublished.Multiline = true;
            txtDateTimePublished.Name = "txtDateTimePublished";
            txtDateTimePublished.Size = new Size(820, 57);
            txtDateTimePublished.TabIndex = 16;
            // 
            // txtDateTimeArchived
            // 
            txtDateTimeArchived.Dock = DockStyle.Fill;
            txtDateTimeArchived.Location = new Point(202, 507);
            txtDateTimeArchived.Multiline = true;
            txtDateTimeArchived.Name = "txtDateTimeArchived";
            txtDateTimeArchived.Size = new Size(820, 64);
            txtDateTimeArchived.TabIndex = 17;
            // 
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 574);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmRecipe";
            Text = "Recipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblCaptionRecipeName;
        private Label lblCaptionCuisineName;
        private Label lblCaptionCalories;
        private Label lblCaptionMealName;
        private Label lblCaptionCourseName;
        private Label lblCaptionRecipeStatus;
        private Label lblCaptionDateTimeDraft;
        private Label lblCaptionDateTimePublished;
        private Label lblCaptionDateTimeArchived;
        private TextBox txtRecipeName;
        private TextBox txtCuisineName;
        private TextBox txtCalories;
        private TextBox txtMealName;
        private TextBox txtCourseName;
        private TextBox txtRecipeStatus;
        private TextBox txtDateTimeDraft;
        private TextBox txtDateTimePublished;
        private TextBox txtDateTimeArchived;
    }
}