namespace Project
{
    partial class Form1
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
            this.TermekTextBox = new System.Windows.Forms.TextBox();
            this.TermekListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TermekTextBox
            // 
            this.TermekTextBox.Location = new System.Drawing.Point(13, 14);
            this.TermekTextBox.Name = "TermekTextBox";
            this.TermekTextBox.Size = new System.Drawing.Size(152, 20);
            this.TermekTextBox.TabIndex = 0;
            this.TermekTextBox.TextChanged += new System.EventHandler(this.TermekTextBox_TextChanged);
            // 
            // TermekListBox
            // 
            this.TermekListBox.FormattingEnabled = true;
            this.TermekListBox.Location = new System.Drawing.Point(13, 40);
            this.TermekListBox.Name = "TermekListBox";
            this.TermekListBox.Size = new System.Drawing.Size(152, 95);
            this.TermekListBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TermekListBox);
            this.Controls.Add(this.TermekTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TermekTextBox;
        private System.Windows.Forms.ListBox TermekListBox;
    }
}

