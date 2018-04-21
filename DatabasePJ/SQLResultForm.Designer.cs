namespace DatabasePJ
{
    partial class SQLResultForm
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
            this.selectGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.sqlInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.selectGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // selectGridView
            // 
            this.selectGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectGridView.Location = new System.Drawing.Point(12, 99);
            this.selectGridView.Name = "selectGridView";
            this.selectGridView.RowTemplate.Height = 28;
            this.selectGridView.Size = new System.Drawing.Size(1246, 547);
            this.selectGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Querry results of the command:";
            // 
            // sqlInfo
            // 
            this.sqlInfo.AutoSize = true;
            this.sqlInfo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlInfo.Location = new System.Drawing.Point(12, 53);
            this.sqlInfo.Name = "sqlInfo";
            this.sqlInfo.Size = new System.Drawing.Size(0, 28);
            this.sqlInfo.TabIndex = 3;
            // 
            // SQLResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 658);
            this.Controls.Add(this.sqlInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectGridView);
            this.Name = "SQLResultForm";
            this.Text = "Querry Result";
            ((System.ComponentModel.ISupportInitialize)(this.selectGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView selectGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sqlInfo;
    }
}