using System;

using System.Linq;

using System.Windows.Forms;

namespace ReflexPro
{
    public partial class frmPatientRecordSearch : Form
    {
        public frmPatientRecord frmPR = new frmPatientRecord();
       

        public frmPatientRecordSearch()
        {
            InitializeComponent();
            LoadLists();
        }

       

      

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadLists()
        {
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
            clsProcess cProc = new clsProcess();
            string sSQL = "";           
            sSQL = "Select pkID, GenderDesc from dbreflexpro.lkgender";
            cProc.LoadlkGender(sSQL, cboGender);

            cProc = null;
            System.Windows.Forms.Cursor.Current = Cursors.Default;
        }

        private void LoadGenderList()
        {

        }


        private void cmdAction_Click(object sender, EventArgs e)
        {
            string sSQL = "";
             if(rdPRAction1.Checked==true)
            {
                //Open a new blank Patient Record=======
                frmPatientRecord frmPR = new frmPatientRecord();
                Variables.giSelectedPatientRecordID = 0;
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
                frmPR.Show();
                System.Windows.Forms.Cursor.Current = Cursors.Default;
            }
             else if(rdPRAction2.Checked==true)
            {

                sSQL = "SELECT  pr.pkID, pt.Title, pr.PatFName, pr.PatSurname, pr.patBirthDate, pr.PatAddressTown, pr.PatPostcode, pr.PatPhoneM, pr.CurrentRecord " +
                    "FROM dbreflexpro.patientrecord pr inner join dbreflexpro.lktitle pt on pr.fkPatientTitleID = pt.pkID " +
                    "WHERE pr.PatSurname like '%" + this.txtSearchText.Text.ToUpper() + "%'";
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
                clsProcess cProc = new clsProcess();
                       
                cProc.LoadPatientlist(sSQL, dgPatientList);
               
                cProc = null;
                System.Windows.Forms.Cursor.Current = Cursors.Default;
            }
             else if(rdPRAction3.Checked==true)
            {
                sSQL = "SELECT  pr.pkID, pt.Title, pr.PatFName, pr.PatSurname, pr.patBirthDate, pr.PatAddressTown, pr.PatPostcode, pr.PatPhoneM,pr.CurrentRecord " +
                    "FROM dbreflexpro.patientrecord pr inner join dbreflexpro.lktitle pt on pr.fkPatientTitleID = pt.pkID " +
                    "WHERE pr.fkPatientGenderID = " + (cboGender.SelectedIndex + 1);
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
                clsProcess cProc = new clsProcess();

                cProc.LoadPatientlist(sSQL, dgPatientList);

                cProc = null;
                System.Windows.Forms.Cursor.Current = Cursors.Default;
            }
        }

        private void dgPatientList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Get the Selected Patient Record ID
            Variables.giSelectedPatientRecordID = Convert.ToInt16(dgPatientList.SelectedRows[0].Cells[0].Value);

            //Tested
            //MessageBox.Show("The selected PatientID :" + Variables.giSelectedPatientRecordID, "Selected Patient", MessageBoxButtons.OK);

            if ((Application.OpenForms.OfType<frmPatientRecord>().Any()))

            //frmPatientRecord frmPR = Application.OpenForms.OfType<frmPatientRecord>().Any())
                {

                Application.OpenForms.OfType<frmPatientRecord>().First().Show();
            }
            else{
                frmPatientRecord frmPR = new frmPatientRecord();
                frmPR.Show();
            }
            
            
        }
    }
}
