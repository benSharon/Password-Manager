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
    public partial class Form1 : Form
    {
        private string platformsPath = @"Platforms";
        public Form1()
        {
            InitializeComponent();
            CreatePlatformsFolder(platformsPath);
        }

        private void btnNewPlatform_Click(object sender, EventArgs e)
            => CreateFile(rtxPlatform.Text, platformsPath);

        private void btnAddAccount_Click(object sender, EventArgs e)
        {

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

        private void CreateFile(string file, string path)
        {
            if (file.Any(c => !char.IsLetterOrDigit(c)) || file.Contains(" ") ||
                file == string.Empty)
                MessageBox.Show($"Platform name cannot:{Environment.NewLine}" +
                                $"- Contain a space.{Environment.NewLine}" +
                                $"- Contain special characters.{Environment.NewLine}" +
                                $"- Be empty.", "Wrong Input");
            else
            {   //Two backslashes inside double quotations to show one backslash.
                if (!File.Exists(path + "\\" + file))
                {                                      
                    File.CreateText($"{path}\\{file}.txt");
                    DisplayFiles(path);
                }
                else MessageBox.Show("File already exists.");
            }
        }
    }
}
