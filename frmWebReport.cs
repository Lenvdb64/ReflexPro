using System;

using System.Data;

using System.Windows.Forms;
using PdfSharp;
using PdfSharp.Pdf;

using TheArtOfDev.HtmlRenderer.PdfSharp;


namespace ReflexPro
{
    public partial class frmWebReport : Form
    {
        
        public frmWebReport()
        {
            InitializeComponent();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadTreatmentReport()
        {

                DataSet dsData1 = new DataSet();
                DataSet dsData2 = new DataSet();
                DataSet dsData3 = new DataSet(); 
            clsProcess cProc = new clsProcess();
            try
            {
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
                string sDorsalLNotes = "";
                string sDorsalRNotes = "";
                string sSQL1 = "SELECT PR.PatFName,PR.PatSurname,PR.PatAddressTown,TR.pkID as TreatmentID,TR.TreatmentDate, "
                    + "TR.Notes_DorsalR, TR.Notes_DorsalL FROM dbreflexpro.treatmentrecords TR "
                    + "inner join dbreflexpro.patientrecord PR on TR.fkPatientRecordID = PR.pkID "
                    + "WHERE TR.pkID = " + Variables.giSelectedPatientTreatmentID;



                string sSQL2 = "SELECT TAP.TreatmentAreaProblem,TA.TreatmentAreaCode, TA.TreatmentAreaDesc, TAPF.TAProblemFindingDesc as Problem "
                    + "FROM dbreflexpro.treatmentrecords TR "
                    + "inner join dbreflexpro.treatmentrecordareas TRA on TR.pkID = TRA.fkTreatmentRecordID "
                    + "left outer join dbreflexpro.lktreatmentareaproblem TAP on TRA.fkTreatmentAreaProblemID = TAP.pkID "
                    + "inner join  dbreflexpro.lktreatmentareas TA on TRA.fkTreatmentAreaID = TA.pkID "
                    + "left outer join dbreflexpro.lktreatmentareaproblemfinding TAPF on (TRA.fkTreatmentAreaID = TAPF.fkTreatmentAreaID and TRA.fkTreatmentAreaProblemID = TAPF.fkTreatmentAreaProblemID) "
                    + "WHERE TR.pkID = " + Variables.giSelectedPatientTreatmentID + " and TA.fkTreatmentMapArea = 1";

                string sSQL3 = "SELECT TAP.TreatmentAreaProblem,TA.TreatmentAreaCode, TA.TreatmentAreaDesc, TAPF.TAProblemFindingDesc as Problem "
                    + "FROM dbreflexpro.treatmentrecords TR "
                    + "inner join dbreflexpro.treatmentrecordareas TRA on TR.pkID = TRA.fkTreatmentRecordID "
                    + "left outer join dbreflexpro.lktreatmentareaproblem TAP on TRA.fkTreatmentAreaProblemID = TAP.pkID "
                    + "inner join  dbreflexpro.lktreatmentareas TA on TRA.fkTreatmentAreaID = TA.pkID "
                    + "left outer join dbreflexpro.lktreatmentareaproblemfinding TAPF on (TRA.fkTreatmentAreaID = TAPF.fkTreatmentAreaID and TRA.fkTreatmentAreaProblemID = TAPF.fkTreatmentAreaProblemID) "
                    + "WHERE TR.pkID = " + Variables.giSelectedPatientTreatmentID + " and TA.fkTreatmentMapArea = 2";


                cProc.LoadPatientRecord(sSQL1, dsData1);
                cProc.LoadPatientRecord(sSQL2, dsData2);
                cProc.LoadPatientRecord(sSQL3, dsData3);
                cProc = null;

                 if (dsData1.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow row in dsData1.Tables[0].Rows)
                        //Not working as need to load RTF values
                        {
                        sDorsalRNotes =Convert.ToString(row["Notes_DorsalR"]);
                        sDorsalLNotes = Convert.ToString(row["Notes_DorsalL"]);

                        }

                    }
                    dsData1 = null;
                
                wbViewer.Navigate("about:blank");
                if (wbViewer.Document != null)
                   
                {
                    
                     HtmlDocument doc = wbViewer.Document.OpenNew(true);
                    doc.Write(@"<!DOCTYPE html><HTML><head><meta charset=""utf-8""></meta><title>Treatment Report for " + Variables.gsPatientHeaderInfo + "</title></head><body>");
                    doc.Write(@"<link rel=""stylesheet"" type=""text/css"" href=""C:\Users\Len\Documents\VSProjects\ReflexPro\Reporting\css\style.css"">");
                    doc.Write(@"<header><h2>REFLEX Treatment Report for </h2></header>");
                    doc.Write(@"<header><h2>" + Variables.gsPatientHeaderInfo + "</h2></header>");
                    doc.Write(@"<header><h3>Treatment Date: " + Variables.gsTreatmentDate  +"</h3></header><HR/>");
                    doc.Write(@"<h3>Treatment Notes: Left Dorsal</h3><p>" + sDorsalLNotes + "</p>");
                    doc.Write(@"<h3>Treatment Notes: Right Dorsal</h3><p>" + sDorsalRNotes + "</p><HR/>");
                    doc.Write(@"<h3>Treatment Areas: Right Sole</h3>");

                    doc.Write(@"<Table>");
                    doc.Write(@"<tr><th>Problem</th><th>Area Code</th><th>Area Description</th><th>Problem Description</th></tr>");
                    if (dsData2.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow row in dsData2.Tables[0].Rows)
                        
                        {
                            doc.Write(@"<tr><td>" + Convert.ToString(row["TreatmentAreaProblem"]) + "</td>");
                            doc.Write(@"<td>" + Convert.ToString(row["TreatmentAreaCode"]) + "</td>");
                            doc.Write(@"<td>" + Convert.ToString(row["TreatmentAreaDesc"]) + "</td>");
                            doc.Write(@"<td>" + Convert.ToString(row["Problem"]) + "</td></tr>");
                            
                        }

                    }
                    doc.Write(@"</Table>");
                    dsData2 = null;
                    doc.Write(@"<h3>Treatment Areas: Left Sole</h3>");
                    doc.Write(@"<Table>");
                    doc.Write(@"<tr><th>Problem</th><th>Area Code</th><th>Area Description</th><th>Problem Description</th></tr>");
                    if (dsData3.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow row in dsData3.Tables[0].Rows)

                        {
                            doc.Write(@"<tr><td>" + Convert.ToString(row["TreatmentAreaProblem"]) + "</td>");
                            doc.Write(@"<td>" + Convert.ToString(row["TreatmentAreaCode"]) + "</td>");
                            doc.Write(@"<td>" + Convert.ToString(row["TreatmentAreaDesc"]) + "</td>");
                            doc.Write(@"<td>" + Convert.ToString(row["Problem"]) + "</td></tr>");

                        }

                    }
                    doc.Write(@"</Table>");

                    dsData3 = null;
                                        
                    doc.Write(@"</body></html>");

                    txtHTMLCode.Text = wbViewer.DocumentText;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.Cursor.Current = Cursors.Default;
                dsData1 = null;
                dsData2 = null;
                dsData3 = null;
                cProc = null;
                MessageBox.Show(ex.Message, "Error loading Patient Treatment Report", MessageBoxButtons.OK);
            }

            finally
            {
                System.Windows.Forms.Cursor.Current = Cursors.Default;
            }
        }

        private void frmWebReport_Load(object sender, EventArgs e)
        {
            LoadTreatmentReport();
        }

        private void cmdSavePDF_Click(object sender, EventArgs e)
        {
            try
            {
                //rptHTML
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
                // string htmlStringx = wbViewer.DocumentText;
                string htmlString = wbViewer.DocumentText;
                //string Css = File.ReadAllText(@"C:\Users\Len\Documents\VSProjects\ReflexPro\Reporting\css\style.css", Encoding.UTF8); ;

                
                PdfDocument pdf = PdfGenerator.GeneratePdf(htmlString, PdfSharp.PageSize.A4);
               
                // save pdf document
                // Save Directory can be modified later.


                dgSave.InitialDirectory = "C:\\Users\\Len\\Documents";
                //SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                dgSave.Filter = "PDF Files|*.pdf";
                dgSave.Title = "Save a PDF File";
                dgSave.FileName = "Reflex Treatment Report for " + Variables.gsPatientHeaderInfo;


                dgSave.ShowDialog();
                if (dgSave.FileName != "")
                {
                    pdf.Save(dgSave.FileName);

                }

                // close pdf document
                pdf.Close();

                //Another Example ==
                /// <summary>
                /// Create PDF using PdfSharp project, save to file and open that file.
                /// </summary>
                //private void OnGeneratePdf_Click(object sender, EventArgs e)
                //{
                //    PdfGenerateConfig config = new PdfGenerateConfig();
                //    config.PageSize = PageSize.A4;
                //    config.SetMargins(20);

                //    var doc = PdfGenerator.GeneratePdf(_mainControl.GetHtml(), config, null, DemoUtils.OnStylesheetLoad, HtmlRenderingHelper.OnImageLoadPdfSharp);
                //    var tmpFile = Path.GetTempFileName();
                //    tmpFile = Path.GetFileNameWithoutExtension(tmpFile) + ".pdf";
                //    doc.Save(tmpFile);
                //    Process.Start(tmpFile);
                // https://csharp.hotexamples.com/examples/TheArtOfDev.HtmlRenderer.PdfSharp/PdfGenerateConfig/-/php-pdfgenerateconfig-class-examples.html
                //}

            }
            catch (Exception ex)
            {
                System.Windows.Forms.Cursor.Current = Cursors.Default;
               
                MessageBox.Show(ex.Message, "Error saving Patient Treatment Report", MessageBoxButtons.OK);
            }

            finally
            {
                
                System.Windows.Forms.Cursor.Current = Cursors.Default;
            }
                


        }
     

     
       
    }
}
