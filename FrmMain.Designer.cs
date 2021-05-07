
namespace PasswordManager
{
    partial class FrmMain
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
            this.cboPlatform.DropDownWidth = 266;
            this.cboPlatform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPlatform.FormattingEnabled = true;
            this.cboPlatform.Location = new System.Drawing.Point(12, 88);
            this.cboPlatform.Name = "cboPlatform";
            this.cboPlatform.Size = new System.Drawing.Size(266, 24);
            this.cboPlatform.TabIndex = 2;
            this.cboPlatform.Text = "Choose a platform...";
            this.cboPlatform.SelectedIndexChanged += new System.EventHandler(this.cboPlatform_SelectedIndexChanged);
            // 
            // btnNewPlatform
            // 
            this.btnNewPlatform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewPlatform.Location = new System.Drawing.Point(174, 35);
            this.btnNewPlatform.Name = "btnNewPlatform";
            this.btnNewPlatform.Size = new System.Drawing.Size(104, 26);
            this.btnNewPlatform.TabIndex = 1;
            this.btnNewPlatform.Text = "New Platform";
            this.btnNewPlatform.UseVisualStyleBackColor = true;
            this.btnNewPlatform.Click += new System.EventHandler(this.btnNewPlatform_Click);
            // 
            // accList
            // 
            this.accList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.accList.FormattingEnabled = true;
            this.accList.ItemHeight = 18;
            this.accList.Location = new System.Drawing.Point(310, 35);
            this.accList.Name = "accList";
            this.accList.Size = new System.Drawing.Size(275, 130);
            this.accList.TabIndex = 3;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAccount.Location = new System.Drawing.Point(310, 192);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(127, 66);
            this.btnAddAccount.TabIndex = 4;
            this.btnAddAccount.Text = "Add Account";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // btnRetrieveCreds
            // 
            this.btnRetrieveCreds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetrieveCreds.Location = new System.Drawing.Point(456, 192);
            this.btnRetrieveCreds.Name = "btnRetrieveCreds";
            this.btnRetrieveCreds.Size = new System.Drawing.Size(129, 66);
            this.btnRetrieveCreds.TabIndex = 5;
            this.btnRetrieveCreds.Text = "Retrieve";
            this.btnRetrieveCreds.UseVisualStyleBackColor = true;
            this.btnRetrieveCreds.Click += new System.EventHandler(this.btnRetrieveCreds_Click);
            // 
            // rtxPlatform
            // 
            this.rtxPlatform.Location = new System.Drawing.Point(12, 35);
            this.rtxPlatform.Name = "rtxPlatform";
            this.rtxPlatform.Size = new System.Drawing.Size(151, 26);
            this.rtxPlatform.TabIndex = 0;
            this.rtxPlatform.Text = "";
            // 
            // FrmMain
            // 
            this.ClientSize = new System.Drawing.Size(616, 282);
            this.Controls.Add(this.rtxPlatform);
            this.Controls.Add(this.btnRetrieveCreds);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.accList);
            this.Controls.Add(this.btnNewPlatform);
            this.Controls.Add(this.cboPlatform);
            this.Name = "FrmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.Button btnNewPlatform;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Button btnRetrieveCreds;
        private System.Windows.Forms.RichTextBox rtxPlatform;
        public System.Windows.Forms.ComboBox cboPlatform;
        public System.Windows.Forms.ListBox accList;
    }
}

