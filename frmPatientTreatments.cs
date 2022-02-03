using System;

using System.Windows.Forms;

namespace ReflexPro
{
    public partial class frmPatientTreatments : Form
    {
        public frmPatientTreatments()
        {
            InitializeComponent();
        }
        private static frmPatientTreatments _instance;
        public static frmPatientTreatments GetInstance()
        {
            if (_instance == null) _instance = new frmPatientTreatments();
            return _instance;

        }

        private void llNewTreatment_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Variables.giSelectedPatientTreatmentID = 0;
            frmTreatmentMap frmTM = new frmTreatmentMap();
            frmTM.Show();
        }

        private void frmPatientTreatments_Load(object sender, EventArgs e)
        {
            LoadPatientTreatments();
        }
        //pkID,TreatmentDate, TreatmentCompleted FROM dbreflexpro.treatmentrecords where fkPatientRecordID
        private void LoadPatientTreatments()
        {
            try
            {
                string sSQL = "Select pkID as TreatmentRecord,TreatmentDate, TreatmentCompleted as Completed FROM dbreflexpro.treatmentrecords" +
                    " where fkPatientRecordID = " + Variables.giSelectedPatientRecordID;

                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
                clsProcess cProc = new clsProcess();
                cProc.LoadTreatmentList(sSQL, this.dgData);
                cProc = null;
                System.Windows.Forms.Cursor.Current = Cursors.Default;
                this.lblPatientInfo.Text = Variables.gsPatientHeaderInfo;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading Patient Treatment records", MessageBoxButtons.OK);
            }



        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void dgData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Variables.giSelectedPatientTreatmentID = Convert.ToInt16(dgData.SelectedRows[0].Cells[0].Value);
            Variables.gsTreatmentDate = Convert.ToString(dgData.SelectedRows[0].Cells[1].Value);
            frmTreatmentMap frmTM = new frmTreatmentMap();
            frmTM.Show();
        }

      
    }
}
