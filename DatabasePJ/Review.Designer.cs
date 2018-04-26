namespace DatabasePJ
{
    partial class Review
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
            this.label1 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.auzLabel = new System.Windows.Forms.Label();
            this.sellidLable = new System.Windows.Forms.Label();
            this.sellidInput = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateInput = new System.Windows.Forms.TextBox();
            this.contentLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.ReviewGridView = new System.Windows.Forms.DataGridView();
            this.contentInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ReviewGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // showAllBbutton
            // 
            this.showAllBbutton.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllBbutton.Location = new System.Drawing.Point(470, 7);
            this.showAllBbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showAllBbutton.Name = "showAllBbutton";
            this.showAllBbutton.Size = new System.Drawing.Size(72, 27);
            this.showAllBbutton.TabIndex = 32;
            this.showAllBbutton.Text = "Show all";
            this.showAllBbutton.UseVisualStyleBackColor = true;
            this.showAllBbutton.Click += new System.EventHandler(this.showAllBbutton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(642, 325);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(82, 32);
            this.searchButton.TabIndex = 31;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // conditionsInfo
            // 
            this.conditionsInfo.AutoSize = true;
            this.conditionsInfo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionsInfo.Location = new System.Drawing.Point(10, 33);
            this.conditionsInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.conditionsInfo.Name = "conditionsInfo";
            this.conditionsInfo.Size = new System.Drawing.Size(0, 19);
            this.conditionsInfo.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Querry results of conditions:";
            // 
            // updateButton
            // 
            this.updateButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.updateButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(642, 361);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(82, 32);
            this.updateButton.TabIndex = 28;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // auzLabel
            // 
            this.auzLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.auzLabel.AutoSize = true;
            this.auzLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auzLabel.Location = new System.Drawing.Point(556, 245);
            this.auzLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.auzLabel.Name = "auzLabel";
            this.auzLabel.Size = new System.Drawing.Size(0, 19);
            this.auzLabel.TabIndex = 26;
            // 
            // sellidLable
            // 
            this.sellidLable.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sellidLable.AutoSize = true;
            this.sellidLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellidLable.Location = new System.Drawing.Point(555, 266);
            this.sellidLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sellidLable.Name = "sellidLable";
            this.sellidLable.Size = new System.Drawing.Size(54, 19);
            this.sellidLable.TabIndex = 25;
            this.sellidLable.Text = "Sell_ID";
            // 
            // sellidInput
            // 
            this.sellidInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sellidInput.Location = new System.Drawing.Point(557, 291);
            this.sellidInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sellidInput.Name = "sellidInput";
            this.sellidInput.Size = new System.Drawing.Size(168, 20);
            this.sellidInput.TabIndex = 24;
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(553, 208);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(40, 19);
            this.dateLabel.TabIndex = 23;
            this.dateLabel.Text = "Date";
            // 
            // dateInput
            // 
            this.dateInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateInput.Location = new System.Drawing.Point(555, 233);
            this.dateInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateInput.Name = "dateInput";
            this.dateInput.Size = new System.Drawing.Size(168, 20);
            this.dateInput.TabIndex = 22;
            // 
            // contentLabel
            // 
            this.contentLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.contentLabel.AutoSize = true;
            this.contentLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentLabel.Location = new System.Drawing.Point(555, 62);
            this.contentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contentLabel.Name = "contentLabel";
            this.contentLabel.Size = new System.Drawing.Size(60, 19);
            this.contentLabel.TabIndex = 21;
            this.contentLabel.Text = "Content";
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.deleteButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(559, 361);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(72, 32);
            this.deleteButton.TabIndex = 19;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(558, 325);
            this.addButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(74, 32);
            this.addButton.TabIndex = 18;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // ReviewGridView
            // 
            this.ReviewGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReviewGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReviewGridView.Location = new System.Drawing.Point(10, 57);
            this.ReviewGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReviewGridView.Name = "ReviewGridView";
            this.ReviewGridView.RowTemplate.Height = 28;
            this.ReviewGridView.Size = new System.Drawing.Size(532, 341);
            this.ReviewGridView.TabIndex = 17;
            this.ReviewGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reviewGridView_CellClick);
            // 
            // contentInput
            // 
            this.contentInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.contentInput.Location = new System.Drawing.Point(555, 85);
            this.contentInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.contentInput.Multiline = true;
            this.contentInput.Name = "contentInput";
            this.contentInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.contentInput.Size = new System.Drawing.Size(168, 116);
            this.contentInput.TabIndex = 33;
            this.contentInput.WordWrap = false;
            // 
            // Review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 409);
            this.Controls.Add(this.contentInput);
            this.Controls.Add(this.showAllBbutton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.conditionsInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.auzLabel);
            this.Controls.Add(this.sellidLable);
            this.Controls.Add(this.sellidInput);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dateInput);
            this.Controls.Add(this.contentLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.ReviewGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Review";
            this.Text = "Review";
            this.Load += new System.EventHandler(this.Review_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReviewGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showAllBbutton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label conditionsInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label auzLabel;
        private System.Windows.Forms.Label sellidLable;
        private System.Windows.Forms.TextBox sellidInput;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox dateInput;
        private System.Windows.Forms.Label contentLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView ReviewGridView;
        private System.Windows.Forms.TextBox contentInput;
    }
}