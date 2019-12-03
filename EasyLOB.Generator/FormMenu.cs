using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace EasyLOB.Generator
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();

            Text = exeName;
            lblName.Text = exeName;

            lsbLog.Items.Clear();

            #if DEBUG
            // EasyLOB-Generator\bin\Debug\..\..\..\EasyLOB-MyLOB-NuGet-3
            string templateDirectory = Path.Combine(Directory.GetParent(Path.Combine(exeDirectory, "..\\..\\..")).FullName, "EasyLOB-MyLOB-NuGet-3");
            #else
            // EasyLOB-Generator\..\EasyLOB-MyLOB-3
            string templateDirectory = Path.Combine(Directory.GetParent(exeDirectory).FullName, "EasyLOB-MyLOB-3");
            #endif
            if (Directory.Exists(templateDirectory))
            {
                txtTemplateDirectory.Text = templateDirectory;
            }
        }

        #region Properties

        string exeName = "EasyLOB Generator";

        string exePath = Application.ExecutablePath;

        string exeDirectory = Application.StartupPath;

        #endregion Properties

        #region UI

        private void lbllnkEasyLOB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.lbllnkEasyLOB.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/EasyLOB/EasyLOB-3/wiki");
        }

        private void btnTemplateDirectory_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtTemplateDirectory.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnSolutionDirectory_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtSolutionDirectory.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void txtApplicationName_Leave(object sender, EventArgs e)
        {
            txtApplicationName.Text = txtApplicationName.Text.Replace(" ", "").Trim();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                pnlMenu.Enabled = false;
                Cursor.Current = Cursors.WaitCursor;
                if (MessageYesNo("OK"))
                {
                    Generate();
                    Message("OK");
                }
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                pnlMenu.Enabled = true;
            }
        }

        #endregion UI

        #region Generate

        private void Generate()
        {
            try
            {
                List<string> messages = new List<string>();

                string templateDirectory = txtTemplateDirectory.Text;
                string solutionDirectory = txtSolutionDirectory.Text;
                string applicationName = txtApplicationName.Text;

                bool ok = true;
                if (String.IsNullOrEmpty(templateDirectory))
                {
                    ok = false;
                    messages.Add("\"Template Directory\" is required");
                }
                if (String.IsNullOrEmpty(solutionDirectory))
                {
                    ok = false;
                    messages.Add("\"Solution Directory\" is required");
                }
                if (Directory.Exists(Path.Combine(solutionDirectory, applicationName)))
                {
                    ok = false;
                    messages.Add("\"Solution Directory\" exists: PLEASE DELETE IT !");
                }
                if (String.IsNullOrEmpty(applicationName))
                {
                    ok = false;
                    messages.Add("\"Application Name\" is required");
                }

                if (ok)
                {
                    string applicationDirectory = Path.Combine(solutionDirectory, applicationName);

                    // 1
                    if (!Directory.Exists(applicationDirectory))
                    {
                        Log("Creating directory \"" + applicationDirectory + "\"...");
                        Directory.CreateDirectory(applicationDirectory);
                        Log("  Directory created");
                    }

                    // 2
                    //Log("Deleting directory \"" + applicationDirectory + "\" and sub-directories content...");
                    //if (Helper.DeleteDirectoryContents(applicationDirectory)) // solutionName
                    {
                        //Log("  Directory content deleted");

                        // 3
                        Log("Copying directory \"" + applicationDirectory + "\" content...");
                        if (Helper.CopyDirectoryContents(templateDirectory, applicationDirectory))
                        {
                            Log("  Directory content copied");

                            // 4
                            Log("Renaming directory \"" + applicationDirectory + "\" content...");
                            if (Helper.RenameDirectoryContents(applicationDirectory, "MyLOB", applicationName))
                            {
                                Log("  Directory content renamed");

                                // 5
                                Log("Replacing directory \"" + applicationDirectory + "\" content...");
                                Helper.ReplaceDirectoryContents(applicationDirectory, "MyLOB", applicationName);
                                Log("  Directory content replaced");
                            }
                        }
                    }
                }
                else
                {
                    Message(string.Join("\n", messages.ToArray()));
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Log(string message)
        {
            lsbLog.Items.Add(message);
            lsbLog.Refresh();
        }

        private void Message(string message)
        {
            MessageBox.Show(message, exeName);
        }

        private bool MessageYesNo(string message)
        {
            return MessageBox.Show(message, exeName,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes;
        }

        #endregion Generate
    }
}