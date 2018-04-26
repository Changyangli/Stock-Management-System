namespace DatabasePJ
{
    partial class itemForm
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
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceInput = new System.Windows.Forms.TextBox();
            this.passwdLabel = new System.Windows.Forms.Label();
            this.pidInput = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.sidInput = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.itemGridView = new System.Windows.Forms.DataGridView();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sold_numInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stock_numInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pic_urlInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // showAllBbutton
            // 
            this.showAllBbutton.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllBbutton.Location = new System.Drawing.Point(504, 11);
            this.showAllBbutton.Margin = new System.Windows.Forms.Padding(2);
            this.showAllBbutton.Name = "showAllBbutton";
            this.showAllBbutton.Size = new System.Drawing.Size(72, 26);
            this.showAllBbutton.TabIndex = 32;
            this.showAllBbutton.Text = "Show all";
            this.showAllBbutton.UseVisualStyleBackColor = true;
            this.showAllBbutton.Click += new System.EventHandler(this.showAllBbutton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(690, 407);
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
            this.conditionsInfo.Location = new System.Drawing.Point(17, 39);
            this.conditionsInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.conditionsInfo.Name = "conditionsInfo";
            this.conditionsInfo.Size = new System.Drawing.Size(0, 19);
            this.conditionsInfo.TabIndex = 30;
            // 
            // updateButton
            // 
            this.updateButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.updateButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(690, 443);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(83, 31);
            this.updateButton.TabIndex = 28;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(604, 157);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(41, 19);
            this.priceLabel.TabIndex = 25;
            this.priceLabel.Text = "Price";
            // 
            // priceInput
            // 
            this.priceInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.priceInput.Location = new System.Drawing.Point(606, 180);
            this.priceInput.Margin = new System.Windows.Forms.Padding(2);
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(168, 20);
            this.priceInput.TabIndex = 24;
            // 
            // passwdLabel
            // 
            this.passwdLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.passwdLabel.AutoSize = true;
            this.passwdLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwdLabel.Location = new System.Drawing.Point(604, 110);
            this.passwdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwdLabel.Name = "passwdLabel";
            this.passwdLabel.Size = new System.Drawing.Size(76, 19);
            this.passwdLabel.TabIndex = 23;
            this.passwdLabel.Text = "Product ID";
            // 
            // pidInput
            // 
            this.pidInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pidInput.Location = new System.Drawing.Point(606, 132);
            this.pidInput.Margin = new System.Windows.Forms.Padding(2);
            this.pidInput.Name = "pidInput";
            this.pidInput.Size = new System.Drawing.Size(168, 20);
            this.pidInput.TabIndex = 22;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(604, 62);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(63, 19);
            this.usernameLabel.TabIndex = 21;
            this.usernameLabel.Text = "Seller ID";
            // 
            // sidInput
            // 
            this.sidInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sidInput.Location = new System.Drawing.Point(606, 85);
            this.sidInput.Margin = new System.Windows.Forms.Padding(2);
            this.sidInput.Name = "sidInput";
            this.sidInput.Size = new System.Drawing.Size(168, 20);
            this.sidInput.TabIndex = 20;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.deleteButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(607, 443);
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
            this.addButton.Location = new System.Drawing.Point(606, 407);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(73, 31);
            this.addButton.TabIndex = 18;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // itemGridView
            // 
            this.itemGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGridView.Location = new System.Drawing.Point(11, 60);
            this.itemGridView.Margin = new System.Windows.Forms.Padding(2);
            this.itemGridView.Name = "itemGridView";
            this.itemGridView.RowTemplate.Height = 28;
            this.itemGridView.Size = new System.Drawing.Size(565, 417);
            this.itemGridView.TabIndex = 17;
            this.itemGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemGridView_CellClick);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(604, 300);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(83, 19);
            this.descriptionLabel.TabIndex = 38;
            this.descriptionLabel.Text = "Description";
            // 
            // descriptionInput
            // 
            this.descriptionInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.descriptionInput.Location = new System.Drawing.Point(606, 323);
            this.descriptionInput.Margin = new System.Windows.Forms.Padding(2);
            this.descriptionInput.Name = "descriptionInput";
            this.descriptionInput.Size = new System.Drawing.Size(168, 20);
            this.descriptionInput.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(604, 252);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 36;
            this.label2.Text = "Sold Number";
            // 
            // sold_numInput
            // 
            this.sold_numInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sold_numInput.Location = new System.Drawing.Point(606, 275);
            this.sold_numInput.Margin = new System.Windows.Forms.Padding(2);
            this.sold_numInput.Name = "sold_numInput";
            this.sold_numInput.Size = new System.Drawing.Size(168, 20);
            this.sold_numInput.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(604, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 34;
            this.label3.Text = "Stock Number";
            // 
            // stock_numInput
            // 
            this.stock_numInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.stock_numInput.Location = new System.Drawing.Point(606, 227);
            this.stock_numInput.Margin = new System.Windows.Forms.Padding(2);
            this.stock_numInput.Name = "stock_numInput";
            this.stock_numInput.Size = new System.Drawing.Size(168, 20);
            this.stock_numInput.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(604, 348);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 40;
            this.label4.Text = "Picture URL";
            // 
            // pic_urlInput
            // 
            this.pic_urlInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pic_urlInput.Location = new System.Drawing.Point(606, 370);
            this.pic_urlInput.Margin = new System.Windows.Forms.Padding(2);
            this.pic_urlInput.Name = "pic_urlInput";
            this.pic_urlInput.Size = new System.Drawing.Size(168, 20);
            this.pic_urlInput.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "Querry results of conditions:";
            // 
            // itemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pic_urlInput);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.descriptionInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sold_numInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stock_numInput);
            this.Controls.Add(this.showAllBbutton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.conditionsInfo);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.priceInput);
            this.Controls.Add(this.passwdLabel);
            this.Controls.Add(this.pidInput);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.sidInput);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.itemGridView);
            this.Name = "itemForm";
            this.Text = "itemForm";
            this.Load += new System.EventHandler(this.itemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showAllBbutton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label conditionsInfo;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceInput;
        private System.Windows.Forms.Label passwdLabel;
        private System.Windows.Forms.TextBox pidInput;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox sidInput;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView itemGridView;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox descriptionInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sold_numInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stock_numInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pic_urlInput;
        private System.Windows.Forms.Label label1;
    }
}