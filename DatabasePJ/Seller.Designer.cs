namespace DatabasePJ
{
    partial class Seller
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.ssnLabel = new System.Windows.Forms.Label();
            this.ssnInput = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.sellerGridView = new System.Windows.Forms.DataGridView();
            this.telLabel = new System.Windows.Forms.Label();
            this.telInput = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressInput = new System.Windows.Forms.TextBox();
            this.creditLabel = new System.Windows.Forms.Label();
            this.creditInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sellerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // showAllBbutton
            // 
            this.showAllBbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showAllBbutton.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllBbutton.Location = new System.Drawing.Point(408, 7);
            this.showAllBbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.searchButton.Location = new System.Drawing.Point(583, 307);
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
            this.updateButton.Location = new System.Drawing.Point(583, 343);
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
            this.auzLabel.Location = new System.Drawing.Point(497, 215);
            this.auzLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.auzLabel.Name = "auzLabel";
            this.auzLabel.Size = new System.Drawing.Size(0, 19);
            this.auzLabel.TabIndex = 26;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(497, 85);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(47, 19);
            this.nameLabel.TabIndex = 25;
            this.nameLabel.Text = "Name";
            // 
            // nameInput
            // 
            this.nameInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nameInput.Location = new System.Drawing.Point(499, 109);
            this.nameInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(168, 20);
            this.nameInput.TabIndex = 24;
            // 
            // ssnLabel
            // 
            this.ssnLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ssnLabel.AutoSize = true;
            this.ssnLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssnLabel.Location = new System.Drawing.Point(497, 33);
            this.ssnLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ssnLabel.Name = "ssnLabel";
            this.ssnLabel.Size = new System.Drawing.Size(33, 19);
            this.ssnLabel.TabIndex = 23;
            this.ssnLabel.Text = "SSN";
            // 
            // ssnInput
            // 
            this.ssnInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ssnInput.Location = new System.Drawing.Point(499, 56);
            this.ssnInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ssnInput.Name = "ssnInput";
            this.ssnInput.Size = new System.Drawing.Size(168, 20);
            this.ssnInput.TabIndex = 22;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.deleteButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(501, 343);
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
            this.addButton.Location = new System.Drawing.Point(499, 307);
            this.addButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(74, 32);
            this.addButton.TabIndex = 18;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // sellerGridView
            // 
            this.sellerGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sellerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sellerGridView.Location = new System.Drawing.Point(10, 57);
            this.sellerGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sellerGridView.Name = "sellerGridView";
            this.sellerGridView.RowTemplate.Height = 28;
            this.sellerGridView.Size = new System.Drawing.Size(472, 309);
            this.sellerGridView.TabIndex = 17;
            this.sellerGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sellerGridView_CellClick);
            // 
            // telLabel
            // 
            this.telLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.telLabel.AutoSize = true;
            this.telLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telLabel.Location = new System.Drawing.Point(497, 136);
            this.telLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.telLabel.Name = "telLabel";
            this.telLabel.Size = new System.Drawing.Size(28, 19);
            this.telLabel.TabIndex = 34;
            this.telLabel.Text = "Tel";
            // 
            // telInput
            // 
            this.telInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.telInput.Location = new System.Drawing.Point(499, 160);
            this.telInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.telInput.Name = "telInput";
            this.telInput.Size = new System.Drawing.Size(168, 20);
            this.telInput.TabIndex = 33;
            // 
            // addressLabel
            // 
            this.addressLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(497, 194);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(61, 19);
            this.addressLabel.TabIndex = 36;
            this.addressLabel.Text = "Address";
            // 
            // addressInput
            // 
            this.addressInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addressInput.Location = new System.Drawing.Point(499, 217);
            this.addressInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(168, 20);
            this.addressInput.TabIndex = 35;
            // 
            // creditLabel
            // 
            this.creditLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.creditLabel.AutoSize = true;
            this.creditLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditLabel.Location = new System.Drawing.Point(499, 249);
            this.creditLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(48, 19);
            this.creditLabel.TabIndex = 38;
            this.creditLabel.Text = "Credit";
            // 
            // creditInput
            // 
            this.creditInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.creditInput.Location = new System.Drawing.Point(501, 272);
            this.creditInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.creditInput.Name = "creditInput";
            this.creditInput.Size = new System.Drawing.Size(168, 20);
            this.creditInput.TabIndex = 37;
            // 
            // Seller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 377);
            this.Controls.Add(this.creditLabel);
            this.Controls.Add(this.creditInput);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.addressInput);
            this.Controls.Add(this.telLabel);
            this.Controls.Add(this.telInput);
            this.Controls.Add(this.showAllBbutton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.conditionsInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.auzLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.ssnLabel);
            this.Controls.Add(this.ssnInput);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.sellerGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Seller";
            this.Text = "re";
            this.Load += new System.EventHandler(this.Seller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sellerGridView)).EndInit();
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
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label ssnLabel;
        private System.Windows.Forms.TextBox ssnInput;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView sellerGridView;
        private System.Windows.Forms.Label telLabel;
        private System.Windows.Forms.TextBox telInput;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressInput;
        private System.Windows.Forms.Label creditLabel;
        private System.Windows.Forms.TextBox creditInput;
    }
}