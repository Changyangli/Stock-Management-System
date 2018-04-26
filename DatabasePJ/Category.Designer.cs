namespace DatabasePJ
{
    partial class Category
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
            this.showAllBbutton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.conditionsInfo = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.categoryDescriptionLabel = new System.Windows.Forms.Label();
            this.descriptionInput = new System.Windows.Forms.TextBox();
            this.categoryNameLabel = new System.Windows.Forms.Label();
            this.categoryNameInput = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.categoryGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // showAllBbutton
            // 
            this.showAllBbutton.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllBbutton.Location = new System.Drawing.Point(423, 11);
            this.showAllBbutton.Margin = new System.Windows.Forms.Padding(2);
            this.showAllBbutton.Name = "showAllBbutton";
            this.showAllBbutton.Size = new System.Drawing.Size(72, 28);
            this.showAllBbutton.TabIndex = 32;
            this.showAllBbutton.Text = "Show all";
            this.showAllBbutton.UseVisualStyleBackColor = true;
            this.showAllBbutton.Click += new System.EventHandler(this.showAllBbutton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(604, 246);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(83, 31);
            this.searchButton.TabIndex = 31;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // conditionsInfo
            // 
            this.conditionsInfo.AutoSize = true;
            this.conditionsInfo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionsInfo.Location = new System.Drawing.Point(16, 41);
            this.conditionsInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.conditionsInfo.Name = "conditionsInfo";
            this.conditionsInfo.Size = new System.Drawing.Size(0, 19);
            this.conditionsInfo.TabIndex = 30;
            // 
            // updateButton
            // 
            this.updateButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.updateButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(604, 282);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(83, 31);
            this.updateButton.TabIndex = 28;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // categoryDescriptionLabel
            // 
            this.categoryDescriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.categoryDescriptionLabel.AutoSize = true;
            this.categoryDescriptionLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryDescriptionLabel.Location = new System.Drawing.Point(517, 175);
            this.categoryDescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.categoryDescriptionLabel.Name = "categoryDescriptionLabel";
            this.categoryDescriptionLabel.Size = new System.Drawing.Size(83, 19);
            this.categoryDescriptionLabel.TabIndex = 23;
            this.categoryDescriptionLabel.Text = "Description";
            // 
            // descriptionInput
            // 
            this.descriptionInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.descriptionInput.Location = new System.Drawing.Point(519, 198);
            this.descriptionInput.Margin = new System.Windows.Forms.Padding(2);
            this.descriptionInput.Name = "descriptionInput";
            this.descriptionInput.Size = new System.Drawing.Size(168, 20);
            this.descriptionInput.TabIndex = 22;
            // 
            // categoryNameLabel
            // 
            this.categoryNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.categoryNameLabel.AutoSize = true;
            this.categoryNameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryNameLabel.Location = new System.Drawing.Point(517, 116);
            this.categoryNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.categoryNameLabel.Name = "categoryNameLabel";
            this.categoryNameLabel.Size = new System.Drawing.Size(109, 19);
            this.categoryNameLabel.TabIndex = 21;
            this.categoryNameLabel.Text = "Category Name";
            // 
            // categoryNameInput
            // 
            this.categoryNameInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.categoryNameInput.Location = new System.Drawing.Point(519, 140);
            this.categoryNameInput.Margin = new System.Windows.Forms.Padding(2);
            this.categoryNameInput.Name = "categoryNameInput";
            this.categoryNameInput.Size = new System.Drawing.Size(168, 20);
            this.categoryNameInput.TabIndex = 20;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.deleteButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(521, 282);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(72, 31);
            this.deleteButton.TabIndex = 19;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(520, 246);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(73, 31);
            this.addButton.TabIndex = 18;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // categoryGridView
            // 
            this.categoryGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryGridView.Location = new System.Drawing.Point(11, 79);
            this.categoryGridView.Margin = new System.Windows.Forms.Padding(2);
            this.categoryGridView.Name = "categoryGridView";
            this.categoryGridView.RowTemplate.Height = 28;
            this.categoryGridView.Size = new System.Drawing.Size(499, 305);
            this.categoryGridView.TabIndex = 17;
            this.categoryGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoryGridView_CellClic);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Querry results of conditions:";
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 395);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showAllBbutton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.conditionsInfo);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.categoryDescriptionLabel);
            this.Controls.Add(this.descriptionInput);
            this.Controls.Add(this.categoryNameLabel);
            this.Controls.Add(this.categoryNameInput);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.categoryGridView);
            this.Name = "Category";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.Category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showAllBbutton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label conditionsInfo;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label categoryDescriptionLabel;
        private System.Windows.Forms.TextBox descriptionInput;
        private System.Windows.Forms.Label categoryNameLabel;
        private System.Windows.Forms.TextBox categoryNameInput;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView categoryGridView;
        private System.Windows.Forms.Label label1;
    }
}