
using System;


using System.Windows.Forms;


namespace ReflexPro
{
    public partial class frmStart : Form
    {
        //SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);
        public struct footzone
        {

            public int ZoneID;            
            public int iLeftX;
            public int iRightX;
            public int iTopY;
            public int iBottomY;
            public string ZoneName;

            //public footzone.footzone(int _ZoneID, int _iLeftX, int _iRightX, int _iTopY, int _iBottomY, string _ZoneName)
            //{


            //}


        };
        public frmStart()
        {
            InitializeComponent();
        }

        private void frmStart_Load(object sender, EventArgs e)
        {
            LoadHotspot();
        }
        private void LoadHotspot()
        {
            //this.picStart..AddElipse("Ellipse", 80, 100, 60);
            //this.picStart.
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPatientRecordSearch frmPRS = new frmPatientRecordSearch();
                frmPRS.Show();
        }

        private void llNewPatient_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPatientRecord frmPR = new frmPatientRecord();
            Variables.giSelectedPatientRecordID = 0;
            frmPR.Show();

           
        }

        private void llReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //To view a report you need to choose a Patient
            //A Patient has one or more treatment sessions, each having it's own report.
            //So to view a report you must choose a patient, then a relevent treatment session.

            //MessageBox.Show("You need to first select a Patient!", "Reports are generated from Treatments of Patients!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            frmReporting frmReports = new frmReporting();
            frmReports.Show();
        }

        private void llAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frmAbout frmAx = new frmAbout();
                frmAx.ShowDialog();

        }
    }
}
