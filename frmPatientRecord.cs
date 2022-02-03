using System;

using System.Data;

using System.Windows.Forms;

namespace ReflexPro
{
    public partial class frmPatientRecord : Form
    {
        string sPatientSurname = "";
        string sPatientFName = "";
        string sPatientOthernames = "";
        int iPatientTitle = -1;
        int iPatientGender = -1;
        DateTime? dtPatientDOB = null;

        string sAddrLine1 = "";
        string sAddrLine2 = "";
        string sAddrTown = "";
        string sAddrPostcode = "";
        string sPhone_H = "";
        string sPhone_M = "";
        string sEmail = "";



        public frmPatientRecord()
        {
            InitializeComponent();
        }

        private void frmPatientRecord_Load(object sender, EventArgs e)
        {
            LoadLookups();
            if (Variables.giSelectedPatientRecordID > 0)
                LoadPatientRecord();
        }

        private void LoadPatientRecord()
        {
            try
            {
                string sSQL = "";
                DataSet dsData = new DataSet();
                lblPatientRecordID.Text = Variables.giSelectedPatientRecordID.ToString();
                sSQL = "SELECT * FROM dbreflexpro.patientrecord where pkID = " + Variables.giSelectedPatientRecordID;

                clsProcess cProc = new clsProcess();
                cProc.LoadPatientRecord(sSQL, dsData);
                cProc = null;

                //Get the dataset into the controls on the form===

                if (dsData.Tables[0].Rows.Count != 0)
                {
                    //`patientrecord`.`PatFName`,
                    //`patientrecord`.`PatMiddleNames`,
                    //`patientrecord`.`PatAddressLn1`,
                    //`patientrecord`.`PatAddressLn2`,
                    //`patientrecord`.`PatAddressTown`,
                    //`patientrecord`.`PatPostcode`,
                    //`patientrecord`.`PatPhoneH`,
                    //`patientrecord`.`PatPhoneM`,
                    //`patientrecord`.`PatEmail`,
                    //`patientrecord`.`patBirthDate`,

                    this.cboGender.SelectedIndex = Convert.ToInt32(dsData.Tables[0].Rows[0]["fkPatientGenderID"]) -1;
                    this.cboTitle.SelectedIndex = Convert.ToInt32(dsData.Tables[0].Rows[0]["fkPatientTitleID"]) -1;
                    this.txtSurname.Text = Convert.ToString(dsData.Tables[0].Rows[0]["PatSurname"]);
                    this.txtFName.Text = Convert.ToString(dsData.Tables[0].Rows[0]["PatFName"]);
                    if (dsData.Tables[0].Rows[0]["PatMiddleNames"] != null)
                        this.txtOtherNames.Text = Convert.ToString(dsData.Tables[0].Rows[0]["PatMiddleNames"]);
                    else
                        this.txtOtherNames.Text = "";

                    this.txtPhone_H.Text = Convert.ToString(dsData.Tables[0].Rows[0]["PatPhoneH"]);
                    this.txtPhone_M.Text = Convert.ToString(dsData.Tables[0].Rows[0]["PatPhoneM"]);
                    this.txtAddrLine1.Text = Convert.ToString(dsData.Tables[0].Rows[0]["PatAddressLn1"]);
                    this.txtAddrLine2.Text = Convert.ToString(dsData.Tables[0].Rows[0]["PatAddressLn2"]);
                    this.txtAddrPostcode.Text = Convert.ToString(dsData.Tables[0].Rows[0]["PatPostcode"]);
                    this.txtAddrTown.Text = Convert.ToString(dsData.Tables[0].Rows[0]["PatAddressTown"]);
                    this.txtEmail.Text = Convert.ToString(dsData.Tables[0].Rows[0]["PatEmail"]);
                    //Convert.ToDateTime("12/02/21 10:56:09").ToString("MMM.dd,yyyy HH:mm:ss");
                    if (dsData.Tables[0].Rows[0]["patBirthDate"] != null)
                        this.txtDOB.Text = Convert.ToDateTime(dsData.Tables[0].Rows[0]["patBirthDate"]).ToString("yyyy-MM-dd");
                    else
                        this.txtDOB.Text = "";
                    

                }

                dsData = null;
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading Patient Record", MessageBoxButtons.OK);
            }
        }
        private void LoadLookups()
        {
            clsProcess cProc = new clsProcess();
            string sSQL = "";
            sSQL = "Select pkID, Title from dbreflexpro.lktitle";
            cProc.LoadlkTitles(sSQL, cboTitle);
            sSQL = "Select pkID, GenderDesc from dbreflexpro.lkgender";
            cProc.LoadlkGender(sSQL, cboGender);

            cProc = null;

        }
        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void rdPRAction1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GetPatientRecordValues()
        {
            
            //Get all String Values===============
            if (this.txtSurname.Text == "")
                sPatientSurname = null;
            else
                sPatientSurname = this.txtSurname.Text;

            if (this.txtFName.Text == "")
                sPatientFName = null;
            else
                sPatientFName = this.txtFName.Text;

            if (this.txtOtherNames.Text == "")
                sPatientOthernames = null;
            else
                sPatientOthernames = this.txtOtherNames.Text;

            if (txtAddrLine1.Text == "")
                sAddrLine1 = null;
            else
                sAddrLine1 = txtAddrLine1.Text;

            if (txtAddrLine2.Text == "")
                sAddrLine2 = null;
            else
                sAddrLine2 = txtAddrLine2.Text;

            if (txtAddrTown.Text == "")
                sAddrTown = null;
            else
                sAddrTown = txtAddrTown.Text;

            if (txtAddrPostcode.Text == "")
                sAddrPostcode = null;
            else
                sAddrPostcode = txtAddrPostcode.Text;

            if (txtPhone_H.Text == "")
                sPhone_H = null;
            else
                sPhone_H = txtPhone_H.Text;

            if (txtPhone_M.Text == "")
                sPhone_M = null;
            else
                sPhone_M = txtPhone_M.Text;

            if (txtEmail.Text == "")
                sEmail = null;
            else
                sEmail = txtEmail.Text;


            //Get all Listbox Values=================
            iPatientGender = cboGender.SelectedIndex + 1;
            iPatientTitle = cboTitle.SelectedIndex + 1;
            //Get all the Dates======================

            if (txtDOB.Text == "")
                dtPatientDOB = null;
            else
                dtPatientDOB = Convert.ToDateTime(txtDOB.Text);

          }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            string sSQL = "";
            DateTime dtToday = DateTime.Now;
            string sdtToday = Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss");


            try
            {
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
            GetPatientRecordValues();
            if (Variables.giSelectedPatientRecordID == 0)
                //Do Insert
                sSQL = "INSERT INTO `dbreflexpro`.`patientrecord`" +
                    "(`fkPatientTitleID`, `fkPatientGenderID`, `PatSurname`, `PatFName`, `PatMiddleNames`," +
                    "`PatAddressLn1`, `PatAddressLn2`, `PatAddressTown`, `PatPostcode`, `PatPhoneH`, `PatPhoneM`," +
                    "`PatEmail`, `patBirthDate`, `CurrentRecord`, `RecordOpenedDt`, `RecordLastModifiedDt`) Values" +
                    "(" + iPatientTitle + "," + iPatientGender + ",'" + sPatientSurname + "','" + sPatientFName + "','" + sPatientOthernames + "','" +
                   sAddrLine1 + "','" + sAddrLine2 + "','" + sAddrTown + "','" + sAddrPostcode + "','" + sPhone_H + "','" + sPhone_M + "','" + sEmail + "','" +
                  txtDOB.Text + "',1,'" + sdtToday + "','" + sdtToday + "')";
            
            else
                //Do Update
                sSQL = "Update `dbreflexpro`.`patientrecord`" +
                    " SET `fkPatientTitleID` = " + iPatientTitle + "," +
                    "`fkPatientGenderID` = " + iPatientGender + "," +
                    "`PatSurname` = '" + sPatientSurname + "'," +
                    "`PatFName` = '" + sPatientFName + "'," +
                    "`PatMiddleNames` = '" + sPatientOthernames + "'," +
                    "`PatAddressLn1` = '" + sAddrLine1 + "'," +
                    "`PatAddressLn2` = '" + sAddrLine2 + "'," +
                    "`PatAddressTown` = '" + sAddrTown + "'," +
                    "`PatPostcode` = '" + sAddrPostcode + "'," +
                    "`PatPhoneH` = '" + sPhone_H + "'," +
                    "`PatPhoneM` = '" + sPhone_M + "'," +
                    "`PatEmail` = '" + sEmail + "'," +
                    "`patBirthDate` = '" + txtDOB.Text + 
                    "',`CurrentRecord` = 1," +
                    "`RecordLastModifiedDt` = '" + sdtToday +
                    "' WHERE `pkID` = " + Convert.ToInt32(this.lblPatientRecordID.Text);

                clsProcess cProc = new clsProcess();
                cProc.WritePatientRecord(sSQL);
                cProc = null;
                System.Windows.Forms.Cursor.Current = Cursors.Default;
                MessageBox.Show("Patient record has been saved!", "Saving Patient Record", MessageBoxButtons.OK);
            }

            catch (Exception ex)
            {
                System.Windows.Forms.Cursor.Current = Cursors.Default;
                MessageBox.Show(ex.Message, "Error saving Patient Record", MessageBoxButtons.OK);
            }


        }

        private void cmdTreatments_Click(object sender, EventArgs e)
        {

            Variables.gsPatientHeaderInfo = this.cboTitle.Text + " " + this.txtFName.Text + " " + this.txtSurname.Text;
          
            frmPatientTreatments frmPT = frmPatientTreatments.GetInstance();
            //This will open the form only one (modally) and prevent more forms to open
            try
            {

                if (!frmPT.Visible)
                {
                    //Check if form is disposed = if so create a new one
                    if (frmPT.IsDisposed)
                    {
                        frmPatientTreatments frmPTx = new frmPatientTreatments();
                        frmPTx.Show();
                    }
                    else
                    {
                        frmPT.Show();
                    }

                   
                }
                else
                {
                    frmPT.BringToFront();
                }
            }

            catch (Exception ex)
            {
                System.Windows.Forms.Cursor.Current = Cursors.Default;
                MessageBox.Show(ex.Message, "Error opening Patient Treatments", MessageBoxButtons.OK);
            }

        }

        private void cmdSetData_Click(object sender, EventArgs e)
        {
            this.dtDate.Visible = true;
        }

        
        private void dtDate_CloseUp(object sender, EventArgs e)
        {
            this.txtDOB.Text = dtDate.Text;
            this.dtDate.Visible = false;
        }
    }
}
