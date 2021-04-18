
namespace PasswordManager
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
            this.cboPlatform = new System.Windows.Forms.ComboBox();
            this.btnNPlatform = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.btnRetrieveCreds = new System.Windows.Forms.Button();
            this.rtxPlatform = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cboPlatform
            // 
            this.cboPlatform.FormattingEnabled = true;
            this.cboPlatform.Location = new System.Drawing.Point(12, 245);
            this.cboPlatform.Name = "cboPlatform";
            this.cboPlatform.Size = new System.Drawing.Size(266, 24);
            this.cboPlatform.TabIndex = 0;
            this.cboPlatform.Text = "Choose a platform...";
            // 
            // btnNPlatform
            // 
            this.btnNPlatform.Location = new System.Drawing.Point(174, 137);
            this.btnNPlatform.Name = "btnNPlatform";
            this.btnNPlatform.Size = new System.Drawing.Size(104, 24);
            this.btnNPlatform.TabIndex = 1;
            this.btnNPlatform.Text = "New Platform";
            this.btnNPlatform.UseVisualStyleBackColor = true;
            this.btnNPlatform.Click += new System.EventHandler(this.btnNPlatform_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(309, 137);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(275, 164);
            this.listBox2.TabIndex = 2;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(457, 325);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(127, 66);
            this.btnAddAccount.TabIndex = 3;
            this.btnAddAccount.Text = "Add Account";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // btnRetrieveCreds
            // 
            this.btnRetrieveCreds.Location = new System.Drawing.Point(309, 327);
            this.btnRetrieveCreds.Name = "btnRetrieveCreds";
            this.btnRetrieveCreds.Size = new System.Drawing.Size(127, 64);
            this.btnRetrieveCreds.TabIndex = 4;
            this.btnRetrieveCreds.Text = "Retrieve";
            this.btnRetrieveCreds.UseVisualStyleBackColor = true;
            this.btnRetrieveCreds.Click += new System.EventHandler(this.btnRetrieveCreds_Click);
            // 
            // rtxPlatform
            // 
            this.rtxPlatform.Location = new System.Drawing.Point(12, 137);
            this.rtxPlatform.Name = "rtxPlatform";
            this.rtxPlatform.Size = new System.Drawing.Size(151, 24);
            this.rtxPlatform.TabIndex = 5;
            this.rtxPlatform.Text = "";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(616, 459);
            this.Controls.Add(this.rtxPlatform);
            this.Controls.Add(this.btnRetrieveCreds);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnNPlatform);
            this.Controls.Add(this.cboPlatform);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnNewPlatform;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.ComboBox cboPlatform;
        private System.Windows.Forms.Button btnNPlatform;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Button btnRetrieveCreds;
        private System.Windows.Forms.RichTextBox rtxPlatform;
    }
}

