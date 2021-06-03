using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class FrmMain : Form
    {
        private string platformsPath = @"Platforms";
        private List<Account> accountList = new List<Account>();

        public FrmMain()
        {
            InitializeComponent();
            CreatePlatformsFolder(platformsPath);
        }

        private void cboPlatform_SelectedIndexChanged(object sender, EventArgs e)
            => ReadFile(cboPlatform.SelectedItem.ToString(), platformsPath);

        private void btnNewPlatform_Click(object sender, EventArgs e)
            => CreatePlatformFile(rtxPlatform.Text, platformsPath);

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            if (cboPlatform.Text != "Choose a platform...")
                new FrmAccount(this).Show(); //"this" refers to FrmMain.
            else MessageBox.Show("You need to select a platform in the drop-down menu.");
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
            => DeleteFromFile(cboPlatform.SelectedItem.ToString(), platformsPath);

        private void btnRetrieveCreds_Click(object sender, EventArgs e)
            => RetrieveCredentials(accList.SelectedItem.ToString());

        private void DisplayFiles(string path)
        {
            //Windows already arranges with alphabetical order.
            cboPlatform.Items.Clear();
            DirectoryInfo folder = new DirectoryInfo(path);
            foreach (var file in folder.GetFiles("*"))
                cboPlatform.Items.Add(file.ToString()
                                          .Substring(0, file.ToString()
                                                            .Length - 4));
        }
        
        private void CreatePlatformsFolder(string path)
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            else DisplayFiles(path);
        }

        private void CreatePlatformFile(string file, string path)
        {
            if (file.Any(c => !char.IsLetterOrDigit(c)) || file.Contains(" ") ||
                file == string.Empty)
                MessageBox.Show($"Platform name cannot:{Environment.NewLine}" +
                                $"- Contain a space.{Environment.NewLine}" +
                                $"- Contain special characters.{Environment.NewLine}" +
                                $"- Be empty.", "Wrong Input");
            else
            {   //Two backslashes inside double quotations to show one backslash.
                if (!File.Exists($"{path}\\{file}.txt"))
                {
                    File.Create($"{path}\\{file}.txt")
                        .Close();

                    accList.Items.Clear();
                    rtxPlatform.Clear();
                    DisplayFiles(path);
                }
                else MessageBox.Show("File already exists.");
            }
        }

        private void DeleteFromFile(string file, string path)
        {
            if (accList.SelectedItem == null)
                MessageBox.Show("An account must be selected for deletion.", "Error");
            else
            {
                DialogResult confirmation = MessageBox.Show("Are you sure you want to delete the selected account ?", "Confirmation",
                                                             MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (confirmation == DialogResult.OK)
                {
                    File.WriteAllLines($"{path}\\{file}.txt",
                    File.ReadAllLines($"{path}\\{file}.txt")
                        .Where(account => account.Split(new string[] { " ==> " }, StringSplitOptions.None)[0]
                                          != accList.SelectedItem.ToString()));
                    ReadFile(file, path);
                }
            }
        }

        public void ReadFile(string file, string path)
        {
            accList.Items.Clear();
            if (!File.Exists($"{path}\\{file}.txt"))
                MessageBox.Show($"{file} file does not exist.");
            else
                using (var sr = File.OpenText($"{path}\\{file}.txt"))
                {
                    accountList.Clear();
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] account = line.Split(new string[] { " ==> " }, StringSplitOptions.None);
                        accountList.Add(new Account(account[0], account[1]));
                        accList.Items.Add(account[0]);
                    }
                    sr.Close();
                }
        }

        private void RetrieveCredentials(string username)
        {
            if (accList.SelectedItem == null)
                MessageBox.Show("An account must be selected in order " +
                                "to retrieve the accounts' credentials.");
            else
            {
                rtxUsername.Text = username;
                rtxPassword.Text = accountList.FirstOrDefault(account => account.Username == username)
                                              .Password;                              
            }
        }
    }
}
