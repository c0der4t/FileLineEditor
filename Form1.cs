using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileLineEditor
{
    public partial class frmMain : Form
    {
        public string TargetFilename;
        public string Add_Before_Line;
        public string Add_After_Line;

        string LicFileLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FLE\\1969.lic");


        //Progress Variables
        public int TotalStepsRequired;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            dlgBrowseTarget.ShowDialog();
            edtTargetFile.Text = dlgBrowseTarget.FileName;
        }

        private void worker_FileProcessor_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressbar.Maximum = TotalStepsRequired;

            progressbar.Value = e.ProgressPercentage;
            lblProgressMenu.Text = e.UserState.ToString();
        }

        private void worker_FileProcessor_DoWork(object sender, DoWorkEventArgs e)
        {
            var random = new Random();
            string ProcessID = Convert.ToString(random.Next(1, 999999));

            //Calculate the amount of work and get progress reporting values.
            worker_FileProcessor.ReportProgress(0, "Preparing...");
            TotalStepsRequired = 0;

            //Count Lines in File
            var lineCount = 0;
            using (var reader = File.OpenText(TargetFilename))
            {
                while (reader.ReadLine() != null)
                {
                    lineCount++;
                }
            }

            TotalStepsRequired += lineCount;
            worker_FileProcessor.ReportProgress(0, "Preparing...");


            //Make a backup of the file
            if (chckbxMakeBackup.Checked)
            {
                TotalStepsRequired += 2;

                worker_FileProcessor.ReportProgress(progressbar.Value, "Making Backup of File");
                if (!Directory.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FLE\\Backup\\")))
                {
                    Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FLE\\Backup\\"));
                }

                File.Copy(TargetFilename, Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FLE\\Backup\\" + ProcessID + ".txt"),true);
                worker_FileProcessor.ReportProgress(progressbar.Value + 1, "Processing File");

            }

            //Loop through original file and write changed lines to the temp file
            try
            {
                StreamWriter TempFile = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FLE\\" + ProcessID + ".tmp"));
                using (StreamReader OrgFile = new StreamReader(TargetFilename))
                {
                    string line;

                    while ((line = OrgFile.ReadLine()) != null)
                    {
                        TempFile.WriteLine(Add_Before_Line + line + Add_After_Line);
                        worker_FileProcessor.ReportProgress(progressbar.Value + 1, "Processing File");
                    }
                }
                //Close the temp file. OrgFile running in using statement thus will auto close
                TempFile.Close();
            }
            catch
            {
                //If an error occurs during this process we can just abandone the temp file process.
                //On error we notify the user and they can try again.
                worker_FileProcessor.ReportProgress(0, "Error While Processing : Abandoning Temp File");
                if (File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FLE\\" + ProcessID + ".tmp")))
                {
                    File.Delete(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FLE\\" + ProcessID + ".tmp"));
                }
                MessageBox.Show("An Unkown Error Occured While Processing the File.\n Please Try Again","Unable to Process File",MessageBoxButtons.OK,MessageBoxIcon.Error);
                worker_FileProcessor.ReportProgress(0,"An Error Occured. Please try again.");
                return;
            }

            //Once the temp file has been completed, we overwrite the original with the temp file
            try
            {
                worker_FileProcessor.ReportProgress(progressbar.Value + 1,"Finishing Up File");
                File.Copy(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FLE\\" + ProcessID + ".tmp"), TargetFilename, true);
            }
            catch
            {
                //If an error occurs within this process. We would have to 1. Notify the user and 2. Restore the backup file
                MessageBox.Show("An error occured while trying to finish your file.\n The backup will be restored if it exists.\nPlease try to process your file again.","Unable to finish the file.",MessageBoxButtons.OK,MessageBoxIcon.Error);

                //We try catch any errors with the backup replacement
                try
                {
                    if (File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FLE\\Backup\\" + ProcessID + ".txt")))
                    {
                        worker_FileProcessor.ReportProgress(0, "Restoring File Backup");
                        File.Copy(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FLE\\Backup\\" + ProcessID + ".txt"), TargetFilename, true);
                        File.Delete(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FLE\\Backup\\" + ProcessID + ".txt"));
                    }
                    MessageBox.Show("No backup file could be Found for the current session.", "No backup file found", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                catch
                {
                    //If an error occurs within this try catch. There is a clear issue with accessing either of the files. We'll notify the user and request a restart
                    worker_FileProcessor.ReportProgress(0, "Fatal Error : Please restart the applicaiton and try again.");
                    MessageBox.Show("The backup file could not be restored. Please restart the application and try again.", "Unable to restore backup file", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                //After restoring backup file, if we can, we exit excution
                return;
            }


            worker_FileProcessor.ReportProgress(progressbar.Maximum - 1, "Cleaning up our workspace 😊");

            //If everything has been completed wihtout any errors, we remove the left over files

            // Remove the temp file
            if (File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FLE\\" + ProcessID + ".tmp")))
            {
                File.Delete(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FLE\\" + ProcessID + ".tmp"));
            }
            

            // Remove the backup file
            if (File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FLE\\Backup\\" + ProcessID + ".txt")))
            {
                File.Delete(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FLE\\Backup\\" + ProcessID + ".txt"));
            }

            worker_FileProcessor.ReportProgress(progressbar.Maximum, "All Done! Your File is Ready 😁");
            



        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            TargetFilename = edtTargetFile.Text;
            Add_Before_Line = edtBeforeLine.Text;
            Add_After_Line = edtAfterLine.Text;

            //Save current parameters as the defaults
            SaveDefaults();

            lblProgressMenu.Visible = true;
            progressbar.Value = 0;
            worker_FileProcessor.RunWorkerAsync();

    }

        private void worker_FileProcessor_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblProgressMenu.Visible = false;
            MessageBox.Show("All Done! Your File is Ready 😁", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            //Load Defaults for User Ease
            int SettingCount = 1;
            if (File.Exists(Path.Combine(Environment.CurrentDirectory, "default.ini")))
            {
                using (StreamReader iniFile = new StreamReader(Path.Combine(Environment.CurrentDirectory, "default.ini")))
                {
                    string line;

                    while ((line = iniFile.ReadLine()) != null)
                    {
                        switch (SettingCount)
                        {
                            case 1:
                                edtTargetFile.Text = line;
                                break;
                            case 2:
                                edtBeforeLine.Text = line;
                                break;
                            case 3:
                                edtAfterLine.Text = line;
                                break;
                            case 4:
                                if (line == "1")
                                {
                                    chckbxMakeBackup.Checked = true;
                                }
                                else
                                {
                                    chckbxMakeBackup.Checked = false;
                                };
                                break;
                            default:
                                break;
                        }
                        SettingCount += 1;
                    }
                }
            }

            /*Disable registration checking. This can be added in the future if needed*/
            //CheckLicense();
        }

        public void CheckLicense()
        {
            //Check if local reg file exists
            if (File.Exists(LicFileLocation))
            {
                //Reg file is present. Check to see if reg is valid.
                
                StreamReader LicFile = new StreamReader(LicFileLocation);
                string RegKey = LicFile.ReadLine();
                LicFile.Close();

                if (RegKey == null)
                {
                    InvokeRegistration();
                }

                //Check if reg date has arrived
                if (RegKey[0] == '0')
                {
                    //Reg needs to be confirmed. Call REST Server
                    //Make request to reg server to see if license is valid
                   
                    try
                    {
                        WebClient RESTRequestor = new WebClient();
                        string RegURL = "https://example.com/reg.php?key="+ RegKey.Remove(0, 1);
                        byte[] RawHTML = RESTRequestor.DownloadData(RegURL);
                        UTF8Encoding UTFEncoder = new UTF8Encoding();
                        string RegResultString = UTFEncoder.GetString(RawHTML);

                        if (Convert.ToString(RegResultString[RegResultString.LastIndexOf("#") + 1]) == "1") 
                        {
                            if (File.Exists(LicFileLocation))
                            {
                                File.Delete(LicFileLocation);
                            }
                            using (StreamWriter UpdateLicFileDays = new StreamWriter(LicFileLocation))
                            {
                                UpdateLicFileDays.WriteLine("5" + RegKey.Remove(0,1));
                            }
                            File.SetAttributes(LicFileLocation, FileAttributes.Hidden);

                        }
                        else
                        {
                            //The license key has failed to activate. Remove current license key file for safety
                            if (File.Exists(LicFileLocation))
                            {
                                File.Delete(LicFileLocation);
                            }
                            InvokeRegistration();
                        }


                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Unable to contact the registration server. Please try again later.","Registration Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        Application.Exit();
                    }
                    
                }
                else
                {
                    //Reg is stil valid offline.Close reg process
                    int NewOfflineDaysLeft = Convert.ToInt32(RegKey[0].ToString()) - 1;
                    if (File.Exists(LicFileLocation))
                    {
                        File.Delete(LicFileLocation);
                    }
                    using (StreamWriter UpdateLicFileDays = new StreamWriter(LicFileLocation))
                    {
                      UpdateLicFileDays.WriteLine(Convert.ToString(NewOfflineDaysLeft) + RegKey.Remove(0, 1));
                    }
                    File.SetAttributes(LicFileLocation, FileAttributes.Hidden);
                }

               

            }
            else
            {
                //Reg file is missing. A registration is required.
                InvokeRegistration();

            }
        }

        private void InvokeRegistration()
        {
            
            DialogResult RegisterResponse = MessageBox.Show("Please Register This Software Before Using It", "Registration Required", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (RegisterResponse == DialogResult.OK)
            {
                //Continue with the registration process.
                frmRegistration RegWindow = new frmRegistration();
                RegWindow.ShowDialog();
                RegWindow.Dispose();
                MessageBox.Show("Please restart this software package to complete the registration", "Restart Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            else
            {
                //User rejected the registration. Force kill the application
                MessageBox.Show("This Software Cannot be Used Without a Valid License.", "Registration Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }
    
        private void SaveDefaults()
        {
            if (File.Exists(Path.Combine(Environment.CurrentDirectory, "default.ini")))
            {
                File.Delete(Path.Combine(Environment.CurrentDirectory, "default.ini"));
            }

            using (StreamWriter iniFile = new StreamWriter(Path.Combine(Environment.CurrentDirectory, "default.ini")))
            {
                iniFile.WriteLine(edtTargetFile.Text);
                iniFile.WriteLine(edtBeforeLine.Text);
                iniFile.WriteLine(edtAfterLine.Text);
                if (chckbxMakeBackup.Checked)
                {
                    iniFile.WriteLine("1");
                }
                else
                {
                    iniFile.WriteLine("0");
                }
            }
        }

        private void imgLicenseKey_Click(object sender, EventArgs e)
        {
            frmRegistration RegWindow = new frmRegistration();
            RegWindow.ShowDialog();
            RegWindow.Dispose();
            MessageBox.Show("Please restart this software package to complete the registration", "Restart Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}
