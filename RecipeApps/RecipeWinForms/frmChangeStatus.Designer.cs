namespace RecipeWinForms
{
    partial class frmChangeStatus
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
            lblDrafted = new Label();
            lblPublished = new Label();
            lblArchived = new Label();
            lblStatusDates = new Label();
            txtDateTimeDraft = new TextBox();
            txtDateTimePublished = new TextBox();
            txtDateTimeArchived = new TextBox();
            tblButtons = new TableLayoutPanel();
            btnDraft = new Button();
            btnPublish = new Button();
            btnArchive = new Button();
            lblRecipeName = new Label();
            lblCurrentStatus = new Label();
            lblRecipeStatus = new Label();
            tblMain.SuspendLayout();
            tblButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 5;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.Controls.Add(lblDrafted, 1, 2);
            tblMain.Controls.Add(lblPublished, 2, 2);
            tblMain.Controls.Add(lblArchived, 3, 2);
            tblMain.Controls.Add(lblStatusDates, 0, 3);
            tblMain.Controls.Add(txtDateTimeDraft, 1, 3);
            tblMain.Controls.Add(txtDateTimePublished, 2, 3);
            tblMain.Controls.Add(txtDateTimeArchived, 3, 3);
            tblMain.Controls.Add(tblButtons, 0, 4);
            tblMain.Controls.Add(lblRecipeName, 1, 0);
            tblMain.Controls.Add(lblCurrentStatus, 2, 1);
            tblMain.Controls.Add(lblRecipeStatus, 3, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 5;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 24.415247F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 18.6704826F));
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 27.08246F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 29.8318062F));
            tblMain.Size = new Size(983, 571);
            tblMain.TabIndex = 0;
            // 
            // lblDrafted
            // 
            lblDrafted.Anchor = AnchorStyles.Right;
            lblDrafted.AutoSize = true;
            lblDrafted.Location = new Point(302, 233);
            lblDrafted.Name = "lblDrafted";
            lblDrafted.Size = new Size(78, 28);
            lblDrafted.TabIndex = 3;
            lblDrafted.Text = "Drafted";
            // 
            // lblPublished
            // 
            lblPublished.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblPublished.AutoSize = true;
            lblPublished.Location = new Point(386, 233);
            lblPublished.Name = "lblPublished";
            lblPublished.Size = new Size(210, 28);
            lblPublished.TabIndex = 4;
            lblPublished.Text = "Published";
            lblPublished.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblArchived
            // 
            lblArchived.Anchor = AnchorStyles.Left;
            lblArchived.AutoSize = true;
            lblArchived.Location = new Point(602, 233);
            lblArchived.Name = "lblArchived";
            lblArchived.Size = new Size(89, 28);
            lblArchived.TabIndex = 5;
            lblArchived.Text = "Archived";
            // 
            // lblStatusDates
            // 
            lblStatusDates.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStatusDates.AutoSize = true;
            lblStatusDates.Location = new Point(45, 261);
            lblStatusDates.Name = "lblStatusDates";
            lblStatusDates.Size = new Size(119, 28);
            lblStatusDates.TabIndex = 6;
            lblStatusDates.Text = "Status Dates";
            // 
            // txtDateTimeDraft
            // 
            txtDateTimeDraft.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDateTimeDraft.Location = new Point(170, 264);
            txtDateTimeDraft.Name = "txtDateTimeDraft";
            txtDateTimeDraft.Size = new Size(210, 34);
            txtDateTimeDraft.TabIndex = 7;
            txtDateTimeDraft.Tag = "";
            // 
            // txtDateTimePublished
            // 
            txtDateTimePublished.Anchor = AnchorStyles.Top;
            txtDateTimePublished.Location = new Point(386, 264);
            txtDateTimePublished.Name = "txtDateTimePublished";
            txtDateTimePublished.Size = new Size(210, 34);
            txtDateTimePublished.TabIndex = 8;
            txtDateTimePublished.Tag = "";
            // 
            // txtDateTimeArchived
            // 
            txtDateTimeArchived.Location = new Point(602, 264);
            txtDateTimeArchived.Name = "txtDateTimeArchived";
            txtDateTimeArchived.Size = new Size(210, 34);
            txtDateTimeArchived.TabIndex = 9;
            txtDateTimeArchived.Tag = "";
            // 
            // tblButtons
            // 
            tblButtons.ColumnCount = 3;
            tblMain.SetColumnSpan(tblButtons, 5);
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblButtons.Controls.Add(btnDraft, 0, 0);
            tblButtons.Controls.Add(btnPublish, 1, 0);
            tblButtons.Controls.Add(btnArchive, 2, 0);
            tblButtons.Dock = DockStyle.Fill;
            tblButtons.Location = new Point(3, 411);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblButtons.Size = new Size(977, 157);
            tblButtons.TabIndex = 10;
            // 
            // btnDraft
            // 
            btnDraft.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDraft.AutoSize = true;
            btnDraft.Location = new Point(198, 3);
            btnDraft.Name = "btnDraft";
            btnDraft.Size = new Size(124, 54);
            btnDraft.TabIndex = 0;
            btnDraft.Text = "Draft";
            btnDraft.UseVisualStyleBackColor = true;
            // 
            // btnPublish
            // 
            btnPublish.Anchor = AnchorStyles.Top;
            btnPublish.AutoSize = true;
            btnPublish.Location = new Point(425, 3);
            btnPublish.Name = "btnPublish";
            btnPublish.Size = new Size(124, 54);
            btnPublish.TabIndex = 1;
            btnPublish.Text = "Publish";
            btnPublish.UseVisualStyleBackColor = true;
            // 
            // btnArchive
            // 
            btnArchive.AutoSize = true;
            btnArchive.Location = new Point(653, 3);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(124, 54);
            btnArchive.TabIndex = 2;
            btnArchive.Text = "Archive";
            btnArchive.UseVisualStyleBackColor = true;
            // 
            // lblRecipeName
            // 
            lblRecipeName.AutoSize = true;
            tblMain.SetColumnSpan(lblRecipeName, 3);
            lblRecipeName.Dock = DockStyle.Fill;
            lblRecipeName.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecipeName.Location = new Point(170, 0);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(642, 132);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.Text = "Recipe Name";
            lblRecipeName.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblCurrentStatus
            // 
            lblCurrentStatus.AutoSize = true;
            lblCurrentStatus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentStatus.Location = new Point(386, 132);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(163, 31);
            lblCurrentStatus.TabIndex = 1;
            lblCurrentStatus.Text = "Current Status:";
            // 
            // lblRecipeStatus
            // 
            lblRecipeStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblRecipeStatus.AutoSize = true;
            lblRecipeStatus.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecipeStatus.Location = new Point(602, 132);
            lblRecipeStatus.Name = "lblRecipeStatus";
            lblRecipeStatus.Size = new Size(210, 31);
            lblRecipeStatus.TabIndex = 2;
            // 
            // frmChangeStatus
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 571);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmChangeStatus";
            Text = "Recipe - Change Status";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblButtons.ResumeLayout(false);
            tblButtons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblRecipeName;
        private Label lblCurrentStatus;
        private Label lblDrafted;
        private Label lblPublished;
        private Label lblArchived;
        private Label lblStatusDates;
        private TextBox txtDateTimeDraft;
        private TextBox txtDateTimePublished;
        private TextBox txtDateTimeArchived;
        private TableLayoutPanel tblButtons;
        private Button btnDraft;
        private Button btnPublish;
        private Button btnArchive;
        private Label lblRecipeStatus;
    }
}