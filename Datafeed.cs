using System;
using System.Windows.Forms;

using System.Data.OleDb;

//using MySqlConnector;
using MySqlConnection = MySqlConnector.MySqlConnection;

namespace ReflexPro
{
    public class Datafeed

    {
        MySqlConnection cMySQLCnn = null;
        OleDbConnection cMSSQLCnn = null;
        //string msConn = "";
        private MySqlConnector.MySqlConnection DBConnection
        {
            get
            {
                //MySqlConnection functionReturnValue = new MySqlConnection DBConnection;
                MySqlConnection functionReturnValue = default(MySqlConnection);
                functionReturnValue = new MySqlConnection();
                functionReturnValue.ConnectionString = ReflexPro.Variables.gsConn;
                functionReturnValue.Open();

                cMySQLCnn = functionReturnValue;
                return functionReturnValue;
            }

        }
        //private OleDbConnection DBConnection
        //{
        //    get
        //    {
        //        OleDbConnection functionReturnValue = default(OleDbConnection);

        //        functionReturnValue = new OleDbConnection();
        //        functionReturnValue.ConnectionString = ReflexPro.Variables.gsConn;
        //        functionReturnValue.Open();

        //        cMyCnn = functionReturnValue;
        //        return functionReturnValue;

        //    }
        //}
        public void SetConnection()
        {
            try
            {
                //The Path of the Access DB is stored in an INI file from where it is extracted and stored in a Public Variable

                //For Access 2013=====Driver install issues========
                //HEFCE_SASPlatformMonitor.Variables.gsConn = "Provider=Microsoft.ACE.OLEDB.15.0;Data Source=" + Application.StartupPath + "\\Data\\HEFCE_PlatformStatus.accdb" + ";Persist Security Info=False;";
                //ReflexPro.Variables.gsConn = "PROVIDER=SQLNCLI11;Server=HEFCE-STATDATA;Database=SAS_PlatformStatus;Trusted_Connection=yes;";
                ReflexPro.Variables.gsConn = "Server=localhost;Port=3306;Database=dbreflexpro;user=root;password=Pr0s3cco;";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error getting Data Connection!", MessageBoxButtons.OK);
            }

        }
        public void SetConnectionMSSQL()
        {
            try
            {
                //The Path of the Access DB is stored in an INI file from where it is extracted and stored in a Public Variable

                //For Access 2013=====Driver install issues========
                //HEFCE_SASPlatformMonitor.Variables.gsConn = "Provider=Microsoft.ACE.OLEDB.15.0;Data Source=" + Application.StartupPath + "\\Data\\HEFCE_PlatformStatus.accdb" + ";Persist Security Info=False;";
               // ReflexPro.Variables.gsConn = "PROVIDER=SQLNCLI11;Server=HEFCE-STATDATA;Database=fsMeta;Trusted_Connection=yes;";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error getting Data Connection!", MessageBoxButtons.OK);
            }

        }

        public void GetDataset(string sSQL, ref System.Data.DataSet dsData)
        {
            //System.Data.OleDb.OleDbDataAdapter daData = new System.Data.OleDb.OleDbDataAdapter();
            MySqlConnector.MySqlDataAdapter daData = new MySqlConnector.MySqlDataAdapter();
            //ref System.Data.DataSet dsData
            try
            {
                SetConnection();

                cMySQLCnn = DBConnection;

                //daData = new System.Data.OleDb.OleDbDataAdapter(sSQL, cMySQLCnn);
                daData = new MySqlConnector.MySqlDataAdapter(sSQL, cMySQLCnn);
                daData.Fill(dsData);

                cMySQLCnn.Close();
                daData.Dispose();
                cMySQLCnn = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error getting Data!", MessageBoxButtons.OK);
            }
        }

        public void GetDatasetfsMeta(string sSQL, ref System.Data.DataSet dsData)
        {
            System.Data.OleDb.OleDbDataAdapter daData = new System.Data.OleDb.OleDbDataAdapter();

            try
            {
                SetConnectionMSSQL();

                cMySQLCnn = DBConnection;
                daData = new System.Data.OleDb.OleDbDataAdapter(sSQL, cMSSQLCnn);
                daData.Fill(dsData);

                cMySQLCnn.Close();
                daData.Dispose();
                //cMyCnn = Nothing

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error getting Data!", MessageBoxButtons.OK);
            }
        }
        public void GetDataset_sp(string sSQL, ref System.Data.DataSet dsData, string sParam = null, string sParamVal = null)
        {

            try
            {
                using (System.Data.OleDb.OleDbDataAdapter daData = new OleDbDataAdapter())
                {
                    SetConnection();
                    cMySQLCnn = DBConnection;
                    daData.SelectCommand = new System.Data.OleDb.OleDbCommand(sSQL, cMSSQLCnn);
                    daData.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    daData.SelectCommand.CommandText = sSQL;
                    if (sParam != null)
                    {
                        daData.SelectCommand.Parameters.AddWithValue(sParam, System.Data.SqlDbType.NVarChar).Value = sParamVal;
                    }

                    daData.Fill(dsData);

                    cMySQLCnn.Close();
                    daData.Dispose();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error getting Data!", MessageBoxButtons.OK);
            }
        }

        public void RunSQLInserts(string sSQL)
        {

            MySqlConnector.MySqlCommand myCommand = null;
            try
            {
                SetConnection();

                cMySQLCnn = DBConnection;


                if (cMySQLCnn.State == System.Data.ConnectionState.Open)
                {
                    //myCommand.CommandText = sSQL
                    //myCommand.CommandType = CommandType.Text
                    myCommand = new MySqlConnector.MySqlCommand(sSQL, cMySQLCnn);
                    myCommand.ExecuteNonQuery();
                    if (myCommand.LastInsertedId != 0) myCommand.Parameters.Add(new MySqlConnector.MySqlParameter("newId", myCommand.LastInsertedId));
                    Variables.giLastInsertedID = Convert.ToInt32(myCommand.LastInsertedId);
                    Int32 iiLastID = Convert.ToInt32(myCommand.Parameters["@newId"].Value);
                    //Convert.ToInt32(cmd.Parameters["@newId"].Value);
                    //string xSql = "SELECT LAST_INSERT_ID();";
                    //Int32 iiLastID = (Int32)myCommand.ExecuteScalar();
                    myCommand.Dispose();

                    cMySQLCnn.Close();
                }
                else
                {
                    MessageBox.Show("Data not captured, Please try again later!", "Error saving Data!", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error getting Data!", MessageBoxButtons.OK);
            }
            finally
            {
                if (cMySQLCnn != null)
                {
                    cMySQLCnn.Close();
                }

            }
        }
        public void RunSQL(string sSQL)
        {
            //This Proc is to do SQL inserts and updates etc============
            MySqlConnector.MySqlCommand myCommand = null;
            try
            {
                SetConnection();

                cMySQLCnn = DBConnection;


                if (cMySQLCnn.State == System.Data.ConnectionState.Open)
                {
                    //myCommand.CommandText = sSQL
                    //myCommand.CommandType = CommandType.Text
                    myCommand = new MySqlConnector.MySqlCommand(sSQL, cMySQLCnn);
                    myCommand.ExecuteNonQuery();                   

                    cMySQLCnn.Close();
                }
                else
                {
                    MessageBox.Show("Data not captured, Please try again later!", "Error saving Data!", MessageBoxButtons.OK);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error getting Data!", MessageBoxButtons.OK);
            }
            finally
            {
                if (cMySQLCnn != null)
                {
                    cMySQLCnn.Close();
                }

            }
        }

    }
}
