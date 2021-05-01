
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
            this.btnNewPlatform = new System.Windows.Forms.Button();
            this.accList = new System.Windows.Forms.ListBox();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.btnRetrieveCreds = new System.Windows.Forms.Button();
            this.rtxPlatform = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cboPlatform
            // 
            this.cboPlatform.FormattingEnabled = true;
            this.cboPlatform.Location = new System.Drawing.Point(12, 190);
            this.cboPlatform.Name = "cboPlatform";
            this.cboPlatform.Size = new System.Drawing.Size(266, 24);
            this.cboPlatform.TabIndex = 2;
            this.cboPlatform.Text = "Choose a platform...";
            // 
            // btnNewPlatform
            // 
            this.btnNewPlatform.Location = new System.Drawing.Point(174, 137);
            this.btnNewPlatform.Name = "btnNewPlatform";
            this.btnNewPlatform.Size = new System.Drawing.Size(104, 24);
            this.btnNewPlatform.TabIndex = 1;
            this.btnNewPlatform.Text = "New Platform";
            this.btnNewPlatform.UseVisualStyleBackColor = true;
            this.btnNewPlatform.Click += new System.EventHandler(this.btnNewPlatform_Click);
            // 
            // accList
            // 
            this.accList.FormattingEnabled = true;
            this.accList.ItemHeight = 16;
            this.accList.Location = new System.Drawing.Point(309, 137);
            this.accList.Name = "accList";
            this.accList.Size = new System.Drawing.Size(275, 164);
            this.accList.TabIndex = 3;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(457, 325);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(127, 66);
            this.btnAddAccount.TabIndex = 5;
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
            this.rtxPlatform.TabIndex = 0;
            this.rtxPlatform.Text = "";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(616, 459);
            this.Controls.Add(this.rtxPlatform);
            this.Controls.Add(this.btnRetrieveCreds);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.accList);
            this.Controls.Add(this.btnNewPlatform);
            this.Controls.Add(this.cboPlatform);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.ComboBox cboPlatform;
        private System.Windows.Forms.Button btnNewPlatform;
        private System.Windows.Forms.ListBox accList;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Button btnRetrieveCreds;
        private System.Windows.Forms.RichTextBox rtxPlatform;
    }
}

