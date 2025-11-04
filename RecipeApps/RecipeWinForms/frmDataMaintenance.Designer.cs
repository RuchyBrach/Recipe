namespace RecipeWinForms
{
    partial class frmDataMaintenance
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
            gData = new DataGridView();
            pnlOptionButtons = new FlowLayoutPanel();
            optUsers = new RadioButton();
            optCuisines = new RadioButton();
            optIngredients = new RadioButton();
            optMeasurements = new RadioButton();
            optCourses = new RadioButton();
            btnSave = new Button();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gData).BeginInit();
            pnlOptionButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.Controls.Add(gData, 1, 0);
            tblMain.Controls.Add(pnlOptionButtons, 0, 0);
            tblMain.Controls.Add(btnSave, 1, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.Size = new Size(1100, 630);
            tblMain.TabIndex = 0;
            // 
            // gData
            // 
            gData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gData.Dock = DockStyle.Fill;
            gData.Location = new Point(223, 3);
            gData.Name = "gData";
            gData.RowHeadersWidth = 51;
            gData.Size = new Size(874, 580);
            gData.TabIndex = 1;
            // 
            // pnlOptionButtons
            // 
            pnlOptionButtons.Controls.Add(optUsers);
            pnlOptionButtons.Controls.Add(optCuisines);
            pnlOptionButtons.Controls.Add(optIngredients);
            pnlOptionButtons.Controls.Add(optMeasurements);
            pnlOptionButtons.Controls.Add(optCourses);
            pnlOptionButtons.Dock = DockStyle.Fill;
            pnlOptionButtons.FlowDirection = FlowDirection.TopDown;
            pnlOptionButtons.Location = new Point(3, 3);
            pnlOptionButtons.Name = "pnlOptionButtons";
            tblMain.SetRowSpan(pnlOptionButtons, 2);
            pnlOptionButtons.Size = new Size(214, 624);
            pnlOptionButtons.TabIndex = 0;
            // 
            // optUsers
            // 
            optUsers.AutoSize = true;
            optUsers.Checked = true;
            optUsers.Font = new Font("Segoe UI", 13.8F);
            optUsers.Location = new Point(10, 10);
            optUsers.Margin = new Padding(10);
            optUsers.Name = "optUsers";
            optUsers.Size = new Size(91, 35);
            optUsers.TabIndex = 0;
            optUsers.TabStop = true;
            optUsers.Text = "Users";
            optUsers.UseVisualStyleBackColor = true;
            // 
            // optCuisines
            // 
            optCuisines.AutoSize = true;
            optCuisines.Font = new Font("Segoe UI", 13.8F);
            optCuisines.Location = new Point(10, 65);
            optCuisines.Margin = new Padding(10);
            optCuisines.Name = "optCuisines";
            optCuisines.Size = new Size(119, 35);
            optCuisines.TabIndex = 1;
            optCuisines.TabStop = true;
            optCuisines.Text = "Cuisines";
            optCuisines.UseVisualStyleBackColor = true;
            // 
            // optIngredients
            // 
            optIngredients.AutoSize = true;
            optIngredients.Font = new Font("Segoe UI", 13.8F);
            optIngredients.Location = new Point(10, 120);
            optIngredients.Margin = new Padding(10);
            optIngredients.Name = "optIngredients";
            optIngredients.Size = new Size(151, 35);
            optIngredients.TabIndex = 2;
            optIngredients.TabStop = true;
            optIngredients.Text = "Ingredients";
            optIngredients.UseVisualStyleBackColor = true;
            // 
            // optMeasurements
            // 
            optMeasurements.AutoSize = true;
            optMeasurements.Font = new Font("Segoe UI", 13.8F);
            optMeasurements.Location = new Point(10, 175);
            optMeasurements.Margin = new Padding(10);
            optMeasurements.Name = "optMeasurements";
            optMeasurements.Size = new Size(186, 35);
            optMeasurements.TabIndex = 3;
            optMeasurements.TabStop = true;
            optMeasurements.Text = "Measurements";
            optMeasurements.UseVisualStyleBackColor = true;
            // 
            // optCourses
            // 
            optCourses.AutoSize = true;
            optCourses.Font = new Font("Segoe UI", 13.8F);
            optCourses.Location = new Point(10, 230);
            optCourses.Margin = new Padding(10);
            optCourses.Name = "optCourses";
            optCourses.Size = new Size(115, 35);
            optCourses.TabIndex = 4;
            optCourses.TabStop = true;
            optCourses.Text = "Courses";
            optCourses.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.AutoSize = true;
            btnSave.Location = new Point(977, 589);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 38);
            btnSave.TabIndex = 2;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // frmDataMaintenance
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 630);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmDataMaintenance";
            Text = "Hearty Hearth - Data Maintenance";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gData).EndInit();
            pnlOptionButtons.ResumeLayout(false);
            pnlOptionButtons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private DataGridView gData;
        private FlowLayoutPanel pnlOptionButtons;
        private RadioButton optUsers;
        private RadioButton optCuisines;
        private RadioButton optIngredients;
        private RadioButton optMeasurements;
        private RadioButton optCourses;
        private Button btnSave;
    }
}