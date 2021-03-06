﻿namespace DatabasePJ
{
    partial class supplement_history
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
            this.iid = new System.Windows.Forms.Label();
            this.iidInput = new System.Windows.Forms.TextBox();
            this.sell_id = new System.Windows.Forms.Label();
            this.supIdInput = new System.Windows.Forms.TextBox();
            this.showAllBbutton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.conditionsInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.dateLable = new System.Windows.Forms.Label();
            this.dateInput = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceInput = new System.Windows.Forms.TextBox();
            this.numberLabel = new System.Windows.Forms.Label();
            this.numInput = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.supplementHistoryGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.supplementHistoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iid
            // 
            this.iid.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.iid.AutoSize = true;
            this.iid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iid.Location = new System.Drawing.Point(826, 170);
            this.iid.Name = "iid";
            this.iid.Size = new System.Drawing.Size(40, 29);
            this.iid.TabIndex = 54;
            this.iid.Text = "IID";
            // 
            // iidInput
            // 
            this.iidInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.iidInput.Location = new System.Drawing.Point(828, 209);
            this.iidInput.Name = "iidInput";
            this.iidInput.Size = new System.Drawing.Size(250, 26);
            this.iidInput.TabIndex = 53;
            // 
            // sell_id
            // 
            this.sell_id.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sell_id.AutoSize = true;
            this.sell_id.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sell_id.Location = new System.Drawing.Point(826, 86);
            this.sell_id.Name = "sell_id";
            this.sell_id.Size = new System.Drawing.Size(249, 29);
            this.sell_id.TabIndex = 52;
            this.sell_id.Text = "Sup_ID (Only for search)";
            // 
            // supIdInput
            // 
            this.supIdInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.supIdInput.Location = new System.Drawing.Point(828, 124);
            this.supIdInput.Name = "supIdInput";
            this.supIdInput.Size = new System.Drawing.Size(250, 26);
            this.supIdInput.TabIndex = 51;
            // 
            // showAllBbutton
            // 
            this.showAllBbutton.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllBbutton.Location = new System.Drawing.Point(702, 11);
            this.showAllBbutton.Name = "showAllBbutton";
            this.showAllBbutton.Size = new System.Drawing.Size(108, 37);
            this.showAllBbutton.TabIndex = 50;
            this.showAllBbutton.Text = "Show all";
            this.showAllBbutton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(954, 513);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(124, 49);
            this.searchButton.TabIndex = 49;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // conditionsInfo
            // 
            this.conditionsInfo.AutoSize = true;
            this.conditionsInfo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionsInfo.Location = new System.Drawing.Point(14, 49);
            this.conditionsInfo.Name = "conditionsInfo";
            this.conditionsInfo.Size = new System.Drawing.Size(0, 28);
            this.conditionsInfo.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 24);
            this.label1.TabIndex = 47;
            this.label1.Text = "Querry results of conditions:";
            // 
            // updateButton
            // 
            this.updateButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.updateButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(954, 569);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(124, 49);
            this.updateButton.TabIndex = 46;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // dateLable
            // 
            this.dateLable.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateLable.AutoSize = true;
            this.dateLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLable.Location = new System.Drawing.Point(824, 419);
            this.dateLable.Name = "dateLable";
            this.dateLable.Size = new System.Drawing.Size(60, 29);
            this.dateLable.TabIndex = 45;
            this.dateLable.Text = "Date";
            // 
            // dateInput
            // 
            this.dateInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateInput.Location = new System.Drawing.Point(827, 456);
            this.dateInput.Name = "dateInput";
            this.dateInput.Size = new System.Drawing.Size(250, 26);
            this.dateInput.TabIndex = 44;
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(824, 342);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(61, 29);
            this.priceLabel.TabIndex = 43;
            this.priceLabel.Text = "Price";
            // 
            // priceInput
            // 
            this.priceInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.priceInput.Location = new System.Drawing.Point(827, 381);
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(250, 26);
            this.priceInput.TabIndex = 42;
            // 
            // numberLabel
            // 
            this.numberLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLabel.Location = new System.Drawing.Point(824, 255);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(94, 29);
            this.numberLabel.TabIndex = 41;
            this.numberLabel.Text = "Number";
            // 
            // numInput
            // 
            this.numInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numInput.Location = new System.Drawing.Point(827, 293);
            this.numInput.Name = "numInput";
            this.numInput.Size = new System.Drawing.Size(250, 26);
            this.numInput.TabIndex = 40;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.deleteButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(830, 569);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(108, 49);
            this.deleteButton.TabIndex = 39;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(828, 513);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(110, 49);
            this.addButton.TabIndex = 38;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // supplementHistoryGridView
            // 
            this.supplementHistoryGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.supplementHistoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplementHistoryGridView.Location = new System.Drawing.Point(14, 89);
            this.supplementHistoryGridView.Name = "supplementHistoryGridView";
            this.supplementHistoryGridView.RowTemplate.Height = 28;
            this.supplementHistoryGridView.Size = new System.Drawing.Size(800, 535);
            this.supplementHistoryGridView.TabIndex = 37;
            this.supplementHistoryGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.supplementHistoryGridView_CellClick);
            // 
            // supplement_history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 633);
            this.Controls.Add(this.iid);
            this.Controls.Add(this.iidInput);
            this.Controls.Add(this.sell_id);
            this.Controls.Add(this.supIdInput);
            this.Controls.Add(this.showAllBbutton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.conditionsInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.dateLable);
            this.Controls.Add(this.dateInput);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.priceInput);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.numInput);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.supplementHistoryGridView);
            this.Name = "supplement_history";
            this.Text = "supplement_history";
            this.Load += new System.EventHandler(this.supplement_history_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supplementHistoryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label iid;
        private System.Windows.Forms.TextBox iidInput;
        private System.Windows.Forms.Label sell_id;
        private System.Windows.Forms.TextBox supIdInput;
        private System.Windows.Forms.Button showAllBbutton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label conditionsInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label dateLable;
        private System.Windows.Forms.TextBox dateInput;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceInput;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.TextBox numInput;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView supplementHistoryGridView;
    }
}