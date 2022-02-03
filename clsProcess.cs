using System;

using System.Data;

using System.Windows.Forms;


namespace ReflexPro
{
    public class clsProcess
    {
        public void LoadlkGender(string sSQL, ComboBox cb)
        {
            try {
                DataSet dsData = new DataSet();
                GetTheDataset(sSQL, dsData);
                LoadCombo(cb, dsData);
                }

            
              catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading Patient Gender List", MessageBoxButtons.OK);
            }
        }
        public void LoadlkTitles(string sSQL, ComboBox cb)
        {
            try
            {

            DataSet dsData = new DataSet();
            GetTheDataset(sSQL, dsData);
            LoadCombo(cb, dsData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading Patient Titles List", MessageBoxButtons.OK);
            }
        }

        public void LoadDatagrid(string sSQL, DataGridView dg)
        {
            try
            {
                DataSet dsData = new DataSet();
                GetTheDataset(sSQL, dsData);
                LoadDatagrid(dg, dsData);
                dsData = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading Data Grid List", MessageBoxButtons.OK);
            }
        }

        public void LoadTreatmentList(string sSQL, DataGridView dg)
        {
            try
            {
                DataSet dsData = new DataSet();
                GetTheDataset(sSQL, dsData);
                dg.AutoGenerateColumns = false;
                dg.ColumnCount = 2;
                //dg.Columns[0].Width = 350;
                dg.Columns[0].Name = "Treatment Record";
                dg.Columns[0].DataPropertyName = "TreatmentRecord";
                dg.Columns[0].Width = 350;
                dg.Columns[1].Width = 200;
                dg.Columns[1].Name = "Treatment Date";
                dg.Columns[1].DataPropertyName = "TreatmentDate";

                //Complex process of adding Boolean Values in DGView

                DataGridViewCheckBoxColumn c = new DataGridViewCheckBoxColumn();
                c.HeaderText = "Completed";
                dg.Columns.Add(c);
                dg.Columns[2].Width = 100;
                dg.Columns[2].Name = "Completed";
                dg.Columns[2].DataPropertyName = "Completed";

                
                dg.DataSource = dsData.Tables[0];
                //dg.AutoResizeColumns();
                //dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                //dg.AutoResizeColumns();
                dsData = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading Data Grid List", MessageBoxButtons.OK);
            }
        }


        public void LoadPatientlist(string sSQL, DataGridView dg)
        {

            //If we use the Generic function LoadDatagrid this one will become redundant
            try
            {
                DataSet dsData = new DataSet();
                GetTheDataset(sSQL, dsData);
                LoadDatagrid(dg, dsData);
                dsData = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading Data Grid List", MessageBoxButtons.OK);
            }
        }

        public void LoadCombo(ComboBox myControl, DataSet ds)
        {
            myControl.DataSource = ds.Tables[0];
            myControl.DisplayMember = ds.Tables[0].Columns[1].ColumnName;
            myControl.ValueMember = ds.Tables[0].Columns[0].ColumnName;
            myControl.SelectedIndex = -1;
                
        }

        public void LoadGridDataset(string sSQL, DataGridView dgv)
        {
            try
            {
                //DataSet dsData = new DataSet();
                //Datafeed cData = new Datafeed();
                //cData.GetDataset(sSQL, ref dsData);
                //cData = null;
                //LoadDatagrid(dgv, dsData);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading Data Grid List", MessageBoxButtons.OK);
            }
        }
        public void LoadDatagrid( DataGridView myControl, DataSet ds)
        {

            myControl.DataSource = ds.Tables[0];
            myControl.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader);
            //myControl.DataBindings{ get; };

        }
        public void GetTheDataset(string sSQL, DataSet ds)
        {
            
            Datafeed cData = new Datafeed();
            cData.GetDataset(sSQL, ref ds);
            cData = null;

        }

        public void WritePatientRecord(string sSQL)
        {
            Datafeed cData = new Datafeed();
            cData.RunSQL(sSQL);
            cData = null;
        }

        public void LoadPatientRecord(string sSQL, DataSet ds)
        {            
            GetTheDataset(sSQL, ds);            
        }
        public void WriteNewPatientTreatmentEntry(string sSQL)
        {
            Datafeed cData = new Datafeed();
            cData.RunSQLInserts(sSQL);
            cData = null;

        }

    }
}
