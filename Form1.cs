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
        private string platformsPath = @"D:\Visual Studio\Projects\PasswordManager\Platforms.txt";
        public Form1()
        {
            InitializeComponent();
            ReadFile(platformsPath);
        }

        private void btnNPlatform_Click(object sender, EventArgs e)
            => WriteToFile(rtxPlatform.Text, platformsPath);

        private void btnAddAccount_Click(object sender, EventArgs e)
        {

        }

        private void btnRetrieveCreds_Click(object sender, EventArgs e)
        {

        }

        private void ReadFile(string file)
        {
            if (!File.Exists(file))
                File.CreateText(file).Close();
            else
            {
                string line;
                using (var sr = new StreamReader(file))
                    while ((line = sr.ReadLine()) != null)
                        cboPlatform.Items.Add(line);
            }
        }

        private void WriteToFile(string content, string file)
        {
            if (!File.Exists(file))
                File.CreateText(file).Close();
            else
            {
                using (var sw = File.AppendText(file))
                    sw.Write(content + Environment.NewLine);
                cboPlatform.Items.Clear();
                ReadFile(file);
            }
        }
    }
}
