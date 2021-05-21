using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class FrmAccount : Form
    {
        FrmMain firstForm;
        private string platformsPath = @"Platforms";
        private string selectedFile = string.Empty;
        public FrmAccount(FrmMain formMain)
        {
            firstForm = formMain;
            selectedFile = formMain.cboPlatform.SelectedItem.ToString();
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            #region Explanation for the encountered null problem.
            //'selectedFile' is null - keeps throwing null exception, don't know why, along
            //with "Object reference not set to an instance of an object".
            //--why ?
            //Because the 'cboPlatform.SelectedItem' in Form1 variable was not
            //properly passed from Form1.
            //Hence, 'selectedFile' was null.
            //So we had to create two parameters in Form2's constructor in order to pass
            //the variable from Form1 to Form2.
            #endregion
            WriteToFile(selectedFile, platformsPath);
            //Close(); //This is to close FrmAccount automatically.
        }

        private void WriteToFile(string file, string path)
        {
            if (!File.Exists($"{path}\\{file}.txt"))
                MessageBox.Show($"{file} file does not exist.");
            else
            {
                string errorMessage = CheckAccountError(rtxEmailUsername.Text,
                                                        rtxPassword.Text,
                                                        rtxRetypePassword.Text);
                if (errorMessage == "")
                    using (var sw = File.AppendText($"{path}\\{file}.txt"))
                    {
                        sw.Write($"{rtxEmailUsername.Text} ==> {rtxPassword.Text}" +
                                                            $"{Environment.NewLine}");
                        rtxEmailUsername.Clear();
                        rtxPassword.Clear();
                        rtxRetypePassword.Clear();
                        sw.Close();
                        firstForm.ReadFile(file, path);
                    }
                else MessageBox.Show(errorMessage);
            }
        }

        private string CheckAccountError(string username, string password, string passwordConfirmation)
        {
            //Email/Username cannot be empty.
            if (username == string.Empty)
                return $"Username cannot be empty.{Environment.NewLine}" +
                       $"Please re-enter username.";
            //If any of the password fields is empty.
            else if (password == string.Empty || passwordConfirmation == string.Empty)
                return $"One of the 'password' field is empty.{Environment.NewLine}" +
                       $"Please fill both 'password' fields.";
            //Email/Username must be unique.
            else if (firstForm.accList.ToString()
                                      .Split(' ')
                                      .Any(str => str == username))
            {
                rtxEmailUsername.Clear();
                return $"Username already exists.{Environment.NewLine}" +
                       $"Please enter a different username.";
            }
            //If password fields do not match.
            else if (password != passwordConfirmation)
            {
                rtxPassword.Clear();
                rtxRetypePassword.Clear();
                return $"Password did not match.{Environment.NewLine}" +
                       $"Please retype password.";
            }
            return "";
        }
    }
}
