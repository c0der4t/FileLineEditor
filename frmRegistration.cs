using DeviceId;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileLineEditor
{
    public partial class frmRegistration : Form
    {
        string DeviceSerial = new DeviceIdBuilder()
                .AddProcessorId()
                .ToString();

        string LicFileLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FLE\\1969.lic");

        public frmRegistration()
        {
            InitializeComponent();
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {            
            edtRegSendCode.Text = DeviceSerial;
        }

        private void btnActivateReg_Click(object sender, EventArgs e)
        {
            if (File.Exists(LicFileLocation))
            {
                File.Delete(LicFileLocation);
            }
            using (StreamWriter NewLicFile = new StreamWriter(LicFileLocation))
            {
                NewLicFile.WriteLine("0" + edtRegReturnCode.Text + "#" + edtRegSendCode.Text);
            }
            File.SetAttributes(LicFileLocation, FileAttributes.Hidden);

            this.Close();
        }
    }
}
