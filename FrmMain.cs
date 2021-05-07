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
            {
                //"this" refers to FrmMain.
                FrmAccount secondForm = new FrmAccount(this);
                secondForm.Show();
            }
            else MessageBox.Show("You need to select a platform in the drop-down menu.");
        }

        private void btnRetrieveCreds_Click(object sender, EventArgs e)
        {

        }

        private void DisplayFiles(string path)
        {
            //Windows already arranges with alphabetical order.
            cboPlatform.Items.Clear();
            DirectoryInfo folder = new DirectoryInfo(path);
            foreach (var file in folder.GetFiles("*"))
                cboPlatform.Items.Add(file.ToString()
                                          .Substring(0, file.ToString().Length - 4));
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
                    File.Create($"{path}\\{file}.txt").Close();
                    accList.Items.Clear();
                    rtxPlatform.Clear();
                    DisplayFiles(path);
                }
                else MessageBox.Show("File already exists.");
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
                    string line;
                    while ((line = sr.ReadLine()) != null)
                        accList.Items.Add(line);
                    sr.Close();
                }
        }
    }
}
