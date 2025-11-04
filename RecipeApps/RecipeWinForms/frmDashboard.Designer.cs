namespace RecipeWinForms
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            tblMain = new TableLayoutPanel();
            lblDescription = new Label();
            tblInfoCount = new TableLayoutPanel();
            lblRecipes = new Label();
            lblMeals = new Label();
            lblCookbooks = new Label();
            lblRecipesCount = new Label();
            lblMealsCount = new Label();
            lblCookbooksCount = new Label();
            lblType = new Label();
            lblNumber = new Label();
            lblWelcome = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnRecipeList = new Button();
            btnMealList = new Button();
            btnCookbookList = new Button();
            tblMain.SuspendLayout();
            tblInfoCount.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblMain.Controls.Add(lblDescription, 1, 1);
            tblMain.Controls.Add(tblInfoCount, 1, 2);
            tblMain.Controls.Add(lblWelcome, 1, 0);
            tblMain.Controls.Add(tableLayoutPanel1, 1, 3);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 31.7857151F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 43.2142868F));
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.Size = new Size(1100, 630);
            tblMain.TabIndex = 0;
            // 
            // lblDescription
            // 
            lblDescription.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(223, 167);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(654, 124);
            lblDescription.TabIndex = 1;
            lblDescription.Text = resources.GetString("lblDescription.Text");
            lblDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblInfoCount
            // 
            tblInfoCount.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tblInfoCount.ColumnCount = 2;
            tblInfoCount.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblInfoCount.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblInfoCount.Controls.Add(lblRecipes, 0, 1);
            tblInfoCount.Controls.Add(lblMeals, 0, 2);
            tblInfoCount.Controls.Add(lblCookbooks, 0, 3);
            tblInfoCount.Controls.Add(lblRecipesCount, 1, 1);
            tblInfoCount.Controls.Add(lblMealsCount, 1, 2);
            tblInfoCount.Controls.Add(lblCookbooksCount, 1, 3);
            tblInfoCount.Controls.Add(lblType, 0, 0);
            tblInfoCount.Controls.Add(lblNumber, 1, 0);
            tblInfoCount.Dock = DockStyle.Fill;
            tblInfoCount.Location = new Point(223, 321);
            tblInfoCount.Name = "tblInfoCount";
            tblInfoCount.RowCount = 4;
            tblInfoCount.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblInfoCount.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblInfoCount.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblInfoCount.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblInfoCount.Size = new Size(654, 236);
            tblInfoCount.TabIndex = 2;
            tblInfoCount.TabStop = true;
            // 
            // lblRecipes
            // 
            lblRecipes.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblRecipes.AutoSize = true;
            lblRecipes.Location = new Point(4, 73);
            lblRecipes.Name = "lblRecipes";
            lblRecipes.Size = new Size(319, 28);
            lblRecipes.TabIndex = 2;
            lblRecipes.Text = "Recipes";
            lblRecipes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMeals
            // 
            lblMeals.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblMeals.AutoSize = true;
            lblMeals.Location = new Point(4, 131);
            lblMeals.Name = "lblMeals";
            lblMeals.Size = new Size(319, 28);
            lblMeals.TabIndex = 4;
            lblMeals.Text = "Meals";
            lblMeals.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCookbooks
            // 
            lblCookbooks.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblCookbooks.AutoSize = true;
            lblCookbooks.Location = new Point(4, 191);
            lblCookbooks.Name = "lblCookbooks";
            lblCookbooks.Size = new Size(319, 28);
            lblCookbooks.TabIndex = 6;
            lblCookbooks.Text = "Cookbooks";
            lblCookbooks.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRecipesCount
            // 
            lblRecipesCount.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblRecipesCount.AutoSize = true;
            lblRecipesCount.Location = new Point(330, 73);
            lblRecipesCount.Name = "lblRecipesCount";
            lblRecipesCount.Size = new Size(320, 28);
            lblRecipesCount.TabIndex = 3;
            lblRecipesCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMealsCount
            // 
            lblMealsCount.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblMealsCount.AutoSize = true;
            lblMealsCount.Location = new Point(330, 131);
            lblMealsCount.Name = "lblMealsCount";
            lblMealsCount.Size = new Size(320, 28);
            lblMealsCount.TabIndex = 5;
            lblMealsCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCookbooksCount
            // 
            lblCookbooksCount.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblCookbooksCount.AutoSize = true;
            lblCookbooksCount.Location = new Point(330, 191);
            lblCookbooksCount.Name = "lblCookbooksCount";
            lblCookbooksCount.Size = new Size(320, 28);
            lblCookbooksCount.TabIndex = 7;
            lblCookbooksCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.BackColor = SystemColors.ActiveBorder;
            lblType.Dock = DockStyle.Fill;
            lblType.Location = new Point(4, 1);
            lblType.Name = "lblType";
            lblType.Size = new Size(319, 57);
            lblType.TabIndex = 0;
            lblType.Text = "Type";
            lblType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.BackColor = SystemColors.ActiveBorder;
            lblNumber.Dock = DockStyle.Fill;
            lblNumber.Location = new Point(330, 1);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(320, 57);
            lblNumber.TabIndex = 1;
            lblNumber.Text = "Number";
            lblNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWelcome
            // 
            lblWelcome.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(223, 49);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(654, 41);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Hearty Hearth Desktop App";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnRecipeList, 0, 0);
            tableLayoutPanel1.Controls.Add(btnMealList, 1, 0);
            tableLayoutPanel1.Controls.Add(btnCookbookList, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(223, 563);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(654, 64);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // btnRecipeList
            // 
            btnRecipeList.AutoSize = true;
            btnRecipeList.Dock = DockStyle.Fill;
            btnRecipeList.Location = new Point(3, 3);
            btnRecipeList.Name = "btnRecipeList";
            btnRecipeList.Size = new Size(212, 58);
            btnRecipeList.TabIndex = 0;
            btnRecipeList.Text = "Recipe List";
            btnRecipeList.UseVisualStyleBackColor = true;
            // 
            // btnMealList
            // 
            btnMealList.AutoSize = true;
            btnMealList.Dock = DockStyle.Fill;
            btnMealList.Location = new Point(221, 3);
            btnMealList.Name = "btnMealList";
            btnMealList.Size = new Size(212, 58);
            btnMealList.TabIndex = 1;
            btnMealList.Text = "Meal List";
            btnMealList.UseVisualStyleBackColor = true;
            // 
            // btnCookbookList
            // 
            btnCookbookList.AutoSize = true;
            btnCookbookList.Dock = DockStyle.Fill;
            btnCookbookList.Location = new Point(439, 3);
            btnCookbookList.Name = "btnCookbookList";
            btnCookbookList.Size = new Size(212, 58);
            btnCookbookList.TabIndex = 2;
            btnCookbookList.Text = "Cookbook List";
            btnCookbookList.UseVisualStyleBackColor = true;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 630);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmDashboard";
            Text = "Dashboard";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblInfoCount.ResumeLayout(false);
            tblInfoCount.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblWelcome;
        private Label lblDescription;
        private TableLayoutPanel tblInfoCount;
        private Button btnRecipeList;
        private Button btnMealList;
        private Button btnCookbookList;
        private Label lblRecipes;
        private Label lblMeals;
        private Label lblCookbooks;
        private Label lblRecipesCount;
        private Label lblMealsCount;
        private Label lblCookbooksCount;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblType;
        private Label lblNumber;
    }
}