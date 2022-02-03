using System;

using System.Data;

using System.Windows.Forms;


namespace ReflexPro
{
    public partial class frmReporting : Form
    {
        public frmReporting()
        {
            InitializeComponent();
        }

        private void frmReporting_Load(object sender, EventArgs e)
        {
           
            ShowCRInViewer();

           
        }

        void ShowCRInViewer()
        {

            try
            {
                DataSet dsData = new DataSet();

                clsProcess cProc = new clsProcess();
                string sSQL = "SELECT * FROM dbreflexpro.customerstreatments_monthly order by treatmentref;";
                cProc.GetTheDataset(sSQL, dsData);
                cProc = null;

                ReportDefs.crCustomers_Monthly rpt1 = new ReportDefs.crCustomers_Monthly();
                rpt1.SetDataSource(dsData.Tables[0]);
                this.crxViewer.Visible = true;
                this.crxViewer.ReportSource = rpt1;
                this.crxViewer.RefreshReport();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error showing your fancy report!", MessageBoxButtons.OK);
            }

        }

       
        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        
     
    }
}
