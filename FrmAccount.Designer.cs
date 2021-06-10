
namespace PasswordManager
{
    partial class FrmAccount
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
            this.rtxPassword = new System.Windows.Forms.RichTextBox();
            this.rtxRetypePassword = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rtxEmailUsername = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtxPassword
            // 
            this.rtxPassword.Location = new System.Drawing.Point(157, 95);
            this.rtxPassword.Name = "rtxPassword";
            this.rtxPassword.Size = new System.Drawing.Size(220, 31);
            this.rtxPassword.TabIndex = 2;
            this.rtxPassword.Text = "";
            // 
            // rtxRetypePassword
            // 
            this.rtxRetypePassword.Location = new System.Drawing.Point(157, 145);
            this.rtxRetypePassword.Name = "rtxRetypePassword";
            this.rtxRetypePassword.Size = new System.Drawing.Size(156, 31);
            this.rtxRetypePassword.TabIndex = 3;
            this.rtxRetypePassword.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(12, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(12, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Retype Password:";
            // 
            // btnEnter
            // 
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Location = new System.Drawing.Point(319, 145);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(58, 31);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(12, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email/username:";
            // 
            // rtxEmailUsername
            // 
            this.rtxEmailUsername.Location = new System.Drawing.Point(157, 41);
            this.rtxEmailUsername.Name = "rtxEmailUsername";
            this.rtxEmailUsername.Size = new System.Drawing.Size(220, 31);
            this.rtxEmailUsername.TabIndex = 1;
            this.rtxEmailUsername.Text = "";
            // 
            // FrmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 210);
            this.Controls.Add(this.rtxEmailUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxRetypePassword);
            this.Controls.Add(this.rtxPassword);
            this.Name = "FrmAccount";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtxRetypePassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.RichTextBox rtxPassword;
        public System.Windows.Forms.RichTextBox rtxEmailUsername;
    }
}