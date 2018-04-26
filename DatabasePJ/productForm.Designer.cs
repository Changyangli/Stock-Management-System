namespace DatabasePJ
{
    partial class productForm
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
            this.nameLable = new System.Windows.Forms.Label();
            this.brandInput = new System.Windows.Forms.TextBox();
            this.passwdLabel = new System.Windows.Forms.Label();
            this.cidInput = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.productGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // showAllBbutton
            // 
            this.showAllBbutton.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllBbutton.Location = new System.Drawing.Point(511, 11);
            this.showAllBbutton.Margin = new System.Windows.Forms.Padding(2);
            this.showAllBbutton.Name = "showAllBbutton";
            this.showAllBbutton.Size = new System.Drawing.Size(72, 24);
            this.showAllBbutton.TabIndex = 32;
            this.showAllBbutton.Text = "Show all";
            this.showAllBbutton.UseVisualStyleBackColor = true;
            this.showAllBbutton.Click += new System.EventHandler(this.showAllBbutton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(682, 293);
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
            this.conditionsInfo.Location = new System.Drawing.Point(17, 41);
            this.conditionsInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.conditionsInfo.Name = "conditionsInfo";
            this.conditionsInfo.Size = new System.Drawing.Size(0, 19);
            this.conditionsInfo.TabIndex = 30;
            // 
            // updateButton
            // 
            this.updateButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.updateButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(682, 329);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(83, 31);
            this.updateButton.TabIndex = 28;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // nameLable
            // 
            this.nameLable.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nameLable.AutoSize = true;
            this.nameLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLable.Location = new System.Drawing.Point(596, 199);
            this.nameLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLable.Name = "nameLable";
            this.nameLable.Size = new System.Drawing.Size(47, 19);
            this.nameLable.TabIndex = 25;
            this.nameLable.Text = "Brand";
            // 
            // brandInput
            // 
            this.brandInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.brandInput.Location = new System.Drawing.Point(598, 224);
            this.brandInput.Margin = new System.Windows.Forms.Padding(2);
            this.brandInput.Name = "brandInput";
            this.brandInput.Size = new System.Drawing.Size(168, 20);
            this.brandInput.TabIndex = 24;
            // 
            // passwdLabel
            // 
            this.passwdLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.passwdLabel.AutoSize = true;
            this.passwdLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwdLabel.Location = new System.Drawing.Point(596, 141);
            this.passwdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwdLabel.Name = "passwdLabel";
            this.passwdLabel.Size = new System.Drawing.Size(85, 19);
            this.passwdLabel.TabIndex = 23;
            this.passwdLabel.Text = "Category ID";
            // 
            // cidInput
            // 
            this.cidInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cidInput.Location = new System.Drawing.Point(598, 164);
            this.cidInput.Margin = new System.Windows.Forms.Padding(2);
            this.cidInput.Name = "cidInput";
            this.cidInput.Size = new System.Drawing.Size(168, 20);
            this.cidInput.TabIndex = 22;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(596, 82);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(47, 19);
            this.usernameLabel.TabIndex = 21;
            this.usernameLabel.Text = "Name";
            // 
            // nameInput
            // 
            this.nameInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nameInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nameInput.Location = new System.Drawing.Point(598, 106);
            this.nameInput.Margin = new System.Windows.Forms.Padding(2);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(168, 20);
            this.nameInput.TabIndex = 20;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.deleteButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(599, 329);
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
            this.addButton.Location = new System.Drawing.Point(598, 293);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(73, 31);
            this.addButton.TabIndex = 18;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // productGridView
            // 
            this.productGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridView.Location = new System.Drawing.Point(11, 68);
            this.productGridView.Margin = new System.Windows.Forms.Padding(2);
            this.productGridView.Name = "productGridView";
            this.productGridView.RowTemplate.Height = 28;
            this.productGridView.Size = new System.Drawing.Size(571, 334);
            this.productGridView.TabIndex = 17;
            this.productGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Querry results of conditions:";
            // 
            // productForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 413);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showAllBbutton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.conditionsInfo);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.nameLable);
            this.Controls.Add(this.brandInput);
            this.Controls.Add(this.passwdLabel);
            this.Controls.Add(this.cidInput);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.productGridView);
            this.Name = "productForm";
            this.Text = "productForm";
            this.Load += new System.EventHandler(this.productForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showAllBbutton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label conditionsInfo;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label nameLable;
        private System.Windows.Forms.TextBox brandInput;
        private System.Windows.Forms.Label passwdLabel;
        private System.Windows.Forms.TextBox cidInput;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView productGridView;
        private System.Windows.Forms.Label label1;
    }
}