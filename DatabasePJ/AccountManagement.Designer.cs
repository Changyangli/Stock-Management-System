namespace DatabasePJ
{
    partial class AccountManagement
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
            this.accountGridView = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwdLabel = new System.Windows.Forms.Label();
            this.passwdInput = new System.Windows.Forms.TextBox();
            this.nameLable = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.auzLabel = new System.Windows.Forms.Label();
            this.auzList = new System.Windows.Forms.ComboBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.conditionsInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.showAllBbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.accountGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // accountGridView
            // 
            this.accountGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accountGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountGridView.Location = new System.Drawing.Point(12, 87);
            this.accountGridView.Name = "accountGridView";
            this.accountGridView.RowTemplate.Height = 28;
            this.accountGridView.Size = new System.Drawing.Size(799, 507);
            this.accountGridView.TabIndex = 0;
            this.accountGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.accountGridView_CellClick);
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(831, 488);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(110, 49);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.deleteButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(833, 543);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(108, 49);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // usernameInput
            // 
            this.usernameInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.usernameInput.Location = new System.Drawing.Point(831, 124);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(250, 26);
            this.usernameInput.TabIndex = 3;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(828, 86);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(113, 29);
            this.usernameLabel.TabIndex = 5;
            this.usernameLabel.Text = "Username";
            // 
            // passwdLabel
            // 
            this.passwdLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.passwdLabel.AutoSize = true;
            this.passwdLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwdLabel.Location = new System.Drawing.Point(828, 176);
            this.passwdLabel.Name = "passwdLabel";
            this.passwdLabel.Size = new System.Drawing.Size(105, 29);
            this.passwdLabel.TabIndex = 7;
            this.passwdLabel.Text = "Password";
            // 
            // passwdInput
            // 
            this.passwdInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.passwdInput.Location = new System.Drawing.Point(831, 214);
            this.passwdInput.Name = "passwdInput";
            this.passwdInput.Size = new System.Drawing.Size(250, 26);
            this.passwdInput.TabIndex = 6;
            // 
            // nameLable
            // 
            this.nameLable.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nameLable.AutoSize = true;
            this.nameLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLable.Location = new System.Drawing.Point(828, 267);
            this.nameLable.Name = "nameLable";
            this.nameLable.Size = new System.Drawing.Size(72, 29);
            this.nameLable.TabIndex = 9;
            this.nameLable.Text = "Name";
            // 
            // nameInput
            // 
            this.nameInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nameInput.Location = new System.Drawing.Point(831, 305);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(250, 26);
            this.nameInput.TabIndex = 8;
            // 
            // auzLabel
            // 
            this.auzLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.auzLabel.AutoSize = true;
            this.auzLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auzLabel.Location = new System.Drawing.Point(828, 365);
            this.auzLabel.Name = "auzLabel";
            this.auzLabel.Size = new System.Drawing.Size(148, 29);
            this.auzLabel.TabIndex = 10;
            this.auzLabel.Text = "Authorization";
            // 
            // auzList
            // 
            this.auzList.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.auzList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.auzList.FormattingEnabled = true;
            this.auzList.Items.AddRange(new object[] {
            "Super administrator",
            "Administrator",
            "Reader",
            "N/A"});
            this.auzList.Location = new System.Drawing.Point(831, 406);
            this.auzList.Name = "auzList";
            this.auzList.Size = new System.Drawing.Size(250, 28);
            this.auzList.TabIndex = 11;
            // 
            // updateButton
            // 
            this.updateButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.updateButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(957, 543);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(124, 49);
            this.updateButton.TabIndex = 12;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // conditionsInfo
            // 
            this.conditionsInfo.AutoSize = true;
            this.conditionsInfo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionsInfo.Location = new System.Drawing.Point(12, 48);
            this.conditionsInfo.Name = "conditionsInfo";
            this.conditionsInfo.Size = new System.Drawing.Size(0, 28);
            this.conditionsInfo.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Querry results of conditions:";
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(957, 488);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(124, 49);
            this.searchButton.TabIndex = 15;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // showAllBbutton
            // 
            this.showAllBbutton.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllBbutton.Location = new System.Drawing.Point(701, 9);
            this.showAllBbutton.Name = "showAllBbutton";
            this.showAllBbutton.Size = new System.Drawing.Size(108, 32);
            this.showAllBbutton.TabIndex = 16;
            this.showAllBbutton.Text = "Show all";
            this.showAllBbutton.UseVisualStyleBackColor = true;
            this.showAllBbutton.Click += new System.EventHandler(this.showAllBbutton_Click);
            // 
            // AccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 606);
            this.Controls.Add(this.showAllBbutton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.conditionsInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.auzList);
            this.Controls.Add(this.auzLabel);
            this.Controls.Add(this.nameLable);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.passwdLabel);
            this.Controls.Add(this.passwdInput);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.accountGridView);
            this.Name = "AccountManagement";
            this.Text = "AccountManagement";
            this.Load += new System.EventHandler(this.AccountManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView accountGridView;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwdLabel;
        private System.Windows.Forms.TextBox passwdInput;
        private System.Windows.Forms.Label nameLable;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label auzLabel;
        private System.Windows.Forms.ComboBox auzList;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label conditionsInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button showAllBbutton;
    }
}