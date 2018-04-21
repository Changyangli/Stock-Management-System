namespace DatabasePJ
{
    partial class SQLMode
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
            this.commands = new System.Windows.Forms.TextBox();
            this.execButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // commands
            // 
            this.commands.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commands.Location = new System.Drawing.Point(12, 37);
            this.commands.Multiline = true;
            this.commands.Name = "commands";
            this.commands.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.commands.Size = new System.Drawing.Size(776, 333);
            this.commands.TabIndex = 0;
            this.commands.WordWrap = false;
            // 
            // execButton
            // 
            this.execButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.execButton.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.execButton.Location = new System.Drawing.Point(712, 389);
            this.execButton.Name = "execButton";
            this.execButton.Size = new System.Drawing.Size(76, 49);
            this.execButton.TabIndex = 1;
            this.execButton.Text = "Go";
            this.execButton.UseVisualStyleBackColor = true;
            this.execButton.Click += new System.EventHandler(this.execButton_Click);
            // 
            // SQLMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.execButton);
            this.Controls.Add(this.commands);
            this.Name = "SQLMode";
            this.Text = "SQLMode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox commands;
        private System.Windows.Forms.Button execButton;
    }
}