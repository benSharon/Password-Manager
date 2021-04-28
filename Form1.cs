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
        private string platformsPath = @"D:\Visual Studio\Projects\PasswordManager\Platforms";
        public Form1()
        {
            InitializeComponent();
            CreatePlatformsFolder(platformsPath);
            DisplayFiles(platformsPath);
        }

        private void btnNPlatform_Click(object sender, EventArgs e)
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
        }

        private void CreateFile(string content, string file)
        {
            if (content.Any(c => !char.IsLetterOrDigit(c)) || content.Contains(" "))
                MessageBox.Show("The platform you entered contains either " +
                                "space or a special character.", "Wrong Input");
            else
            {
                if (!File.Exists(file + "\\" + content))  //Two backslashes inside double quotations
                    File.CreateText($"{file}\\{content}.txt");  //to show one backslash.
                DisplayFiles(file);
            }
        }
    }
}
