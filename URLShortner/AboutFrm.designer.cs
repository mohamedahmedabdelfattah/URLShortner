namespace URLShortner
{
    partial class AboutFrm
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
            this.txtchange = new System.Windows.Forms.RichTextBox();
            this.btnCoolExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtchange
            // 
            this.txtchange.BackColor = System.Drawing.SystemColors.Control;
            this.txtchange.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtchange.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchange.ForeColor = System.Drawing.Color.Black;
            this.txtchange.Location = new System.Drawing.Point(13, 12);
            this.txtchange.Name = "txtchange";
            this.txtchange.ReadOnly = true;
            this.txtchange.ShortcutsEnabled = false;
            this.txtchange.Size = new System.Drawing.Size(343, 88);
            this.txtchange.TabIndex = 0;
            this.txtchange.TabStop = false;
            this.txtchange.Text = "URLShortner v 0.1\nDeveloped by: Mohamed Ahmed Abdel Fattah\nFeedback & Support: en" +
                "g.mafattah@hotmail.com\nCopyright (c) 2012, All Rights Reserved.";
            // 
            // btnCoolExit
            // 
            this.btnCoolExit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCoolExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCoolExit.Location = new System.Drawing.Point(133, 96);
            this.btnCoolExit.Name = "btnCoolExit";
            this.btnCoolExit.Size = new System.Drawing.Size(102, 33);
            this.btnCoolExit.TabIndex = 1;
            this.btnCoolExit.Text = "Cool";
            this.btnCoolExit.UseVisualStyleBackColor = true;
            this.btnCoolExit.Click += new System.EventHandler(this.btnCoolExit_Click);
            // 
            // AboutFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 137);
            this.ControlBox = false;
            this.Controls.Add(this.btnCoolExit);
            this.Controls.Add(this.txtchange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutFrm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtchange;
        private System.Windows.Forms.Button btnCoolExit;
    }
}