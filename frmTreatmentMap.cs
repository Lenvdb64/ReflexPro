using System;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReflexPro
{
    public partial class frmTreatmentMap : Form
    {
        //see https://www.youtube.com/watch?v=2txkPUBb-Nc&t=127s
        private int NOT_IN_ZONE = 99999;
        SolidBrush sbGreen = new SolidBrush(Color.LimeGreen);
        SolidBrush sbYellow = new SolidBrush(Color.LightYellow);
        SolidBrush sbLightblue = new SolidBrush(Color.LightSteelBlue);
        
        
        List<clsTreatmentZones> tZones = new List<clsTreatmentZones>();
        List<clsTreatmentZones> tZones2 = new List<clsTreatmentZones>();
        List<clsTreatmentZones> tZones3 = new List<clsTreatmentZones>();
        List<clsTreatmentZones> tZones4 = new List<clsTreatmentZones>();
        Int32 miSelectedTreatmentZoneID = 0;
        string msSelectedZoneDesc = "";


        public void LoadTreatmentZone_RSole()
        {
            //this can now be loaded into table and pulled from dataset into class if so desired
            //Use Test Colour for visibility sbPaintbrush=Color.Bisque and Transparent for functionality
            System.Drawing.Color sbPCol = Color.Cornsilk;
            //System.Drawing.Color sbPCol = Color.Transparent;

            try
            {
                string sSQL = "SELECT pkID, TreatmentAreaCode, TreatmentAreaDesc, ZoneX, ZoneY, ZoneH,ZoneW FROM dbreflexpro.lktreatmentareas WHERE fkTreatmentMapArea = 1; ";
                Datafeed cData = new Datafeed();
                DataSet dsData = new DataSet();
                cData.GetDataset(sSQL, ref dsData);
                cData = null;

                if (dsData.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in dsData.Tables[0].Rows)
                    {
                        tZones.Add(new clsTreatmentZones()
                        {
                            nZoneID = Convert.ToInt32(row["pkID"].ToString()),
                            sZoneCode = row["TreatmentAreaCode"].ToString(),
                            sZoneDesc = row["TreatmentAreaDesc"].ToString(),
                            sbPaintbrush = sbPCol,
                            nZoneX = Convert.ToInt32(row["ZoneX"].ToString()),
                            nZoneY = Convert.ToInt32(row["ZoneY"].ToString()),
                            nZonewidth = Convert.ToInt32(row["ZoneW"].ToString()),
                            nZoneheight = Convert.ToInt32(row["ZoneH"].ToString())
                        });
                    }
                }

                dsData = null;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading Treatment Zones - R Sole", MessageBoxButtons.OK);
            }
            //tZones.Add(new clsTreatmentZones() { nZoneID= 1, sZoneCode="R1", sZoneDesc="Brain", sbPaintbrush= sbPCol, nZoneX=160, nZoneY=30, nZonewidth=25, nZoneheight = 20 });
            //tZones.Add(new clsTreatmentZones() { nZoneID = 2, sZoneCode = "R2", sZoneDesc = "Hypothalamus", sbPaintbrush = sbPCol, nZoneX = 184, nZoneY = 55, nZonewidth = 12, nZoneheight = 12 });
            //tZones.Add(new clsTreatmentZones() { nZoneID = 3, sZoneCode = "R3a", sZoneDesc = "Pineal ", sbPaintbrush = sbPCol, nZoneX = 160, nZoneY = 58, nZonewidth = 12, nZoneheight = 12 });
            //tZones.Add(new clsTreatmentZones() { nZoneID = 63, sZoneCode = "R3b", sZoneDesc = "Pituitary ", sbPaintbrush = sbPCol, nZoneX = 177, nZoneY = 68, nZonewidth = 12, nZoneheight = 12 });
            //tZones.Add(new clsTreatmentZones() { nZoneID = 4, sZoneCode = "R4", sZoneDesc = "Neck – big toe", sbPaintbrush = sbPCol, nZoneX = 160, nZoneY = 90, nZonewidth = 25, nZoneheight = 15 });
            //tZones.Add(new clsTreatmentZones() { nZoneID = 5, sZoneCode = "R5", sZoneDesc = "Thyroid and Parathyroid", sbPaintbrush = sbPCol, nZoneX = 160, nZoneY = 115, nZonewidth = 15, nZoneheight = 10 });
            //tZones.Add(new clsTreatmentZones() { nZoneID = 6, sZoneCode = "R6", sZoneDesc = "Occiput", sbPaintbrush = sbPCol, nZoneX = 147, nZoneY = 80, nZonewidth = 10, nZoneheight = 10 });
            //tZones.Add(new clsTreatmentZones() { nZoneID = 7, sZoneCode = "R7", sZoneDesc = "Thymus", sbPaintbrush = sbPCol, nZoneX = 186, nZoneY = 135, nZonewidth = 12, nZoneheight = 20 });
            //tZones.Add(new clsTreatmentZones() { nZoneID = 8, sZoneCode = "R8", sZoneDesc = "Heart", sbPaintbrush = sbPCol, nZoneX = 170, nZoneY = 145, nZonewidth = 20, nZoneheight = 30 });
            //tZones.Add(new clsTreatmentZones() { nZoneID = 9, sZoneCode = "R9", sZoneDesc = "Thyroid Helper", sbPaintbrush = sbPCol, nZoneX = 151, nZoneY = 180, nZonewidth = 33, nZoneheight = 20 });

            //tZones.Add(new clsTreatmentZones() { nZoneID = 10, sZoneCode = "R10", sZoneDesc = "Neck – toe 2", sbPaintbrush = sbPCol, nZoneX = 118, nZoneY = 60, nZonewidth = 25, nZoneheight = 20 });
            //tZones.Add(new clsTreatmentZones() { nZoneID = 11, sZoneCode = "R11", sZoneDesc = "Sinus – toe 2", sbPaintbrush = sbPCol, nZoneX = 120, nZoneY = 40, nZonewidth = 20, nZoneheight = 10 });
            //tZones.Add(new clsTreatmentZones() { nZoneID = 12, sZoneCode = "R12", sZoneDesc = "Neck – toe 3", sbPaintbrush = sbPCol, nZoneX = 90, nZoneY = 70, nZonewidth = 25, nZoneheight = 20 });
            //tZones.Add(new clsTreatmentZones() { nZoneID = 13, sZoneCode = "R13", sZoneDesc = "Sinus – toe 3", sbPaintbrush = sbPCol, nZoneX = 93, nZoneY = 50, nZonewidth = 20, nZoneheight = 10 });
            //tZones.Add(new clsTreatmentZones() { nZoneID = 14, sZoneCode = "R14", sZoneDesc = "Neck – toe 4", sbPaintbrush = sbPCol, nZoneX = 68, nZoneY = 88, nZonewidth = 25, nZoneheight = 20 });
            //tZones.Add(new clsTreatmentZones() { nZoneID = 15, sZoneCode = "R15", sZoneDesc = "Sinus – toe 4", sbPaintbrush = sbPCol, nZoneX = 68, nZoneY = 65, nZonewidth = 20, nZoneheight = 10 });
            //tZones.Add(new clsTreatmentZones() { nZoneID = 16, sZoneCode = "R16", sZoneDesc = "Neck – toe 5", sbPaintbrush = sbPCol, nZoneX = 40, nZoneY =110, nZonewidth = 20, nZoneheight = 15 });
            //tZones.Add(new clsTreatmentZones() { nZoneID = 17, sZoneCode = "R17", sZoneDesc = "Sinus – toe 5", sbPaintbrush = sbPCol, nZoneX = 50, nZoneY = 95, nZonewidth = 20, nZoneheight = 10 });

            //tZones.Add(new clsTreatmentZones() { nZoneID = 18, sZoneCode = "R18", sZoneDesc = "Right eye", sbPaintbrush = sbPCol, nZoneX = 110, nZoneY = 100, nZonewidth = 20, nZoneheight = 10 });
            //tZones.Add(new clsTreatmentZones() { nZoneID = 19, sZoneCode = "R19", sZoneDesc = "Right ear / Eustachian tube", sbPaintbrush = sbPCol, nZoneX = 85, nZoneY = 103, nZonewidth = 20, nZoneheight = 10 });
            //tZones.Add(new clsTreatmentZones() { nZoneID = 20, sZoneCode = "R20", sZoneDesc = "Balance", sbPaintbrush = sbPCol, nZoneX = 60, nZoneY = 116, nZonewidth = 20, nZoneheight = 10 });
            //tZones.Add(new clsTreatmentZones() { nZoneID = 21, sZoneCode = "R21", sZoneDesc = "Trapezius", sbPaintbrush = sbPCol, nZoneX = 145, nZoneY = 106, nZonewidth = 30, nZoneheight = 10 });

            //tZones.Add(new clsTreatmentZones() { nZoneID = 22, sZoneCode = "R22", sZoneDesc = "Right shoulder", sbPaintbrush = sbPCol, nZoneX = 30, nZoneY = 145, nZonewidth = 20, nZoneheight = 30 });
            //tZones.Add(new clsTreatmentZones() { nZoneID = 23, sZoneCode = "R23", sZoneDesc = "Right arm", sbPaintbrush = sbPCol, nZoneX = 30, nZoneY = 180, nZonewidth = 20, nZoneheight = 20 });
            //tZones.Add(new clsTreatmentZones() { nZoneID = 24, sZoneCode = "R24", sZoneDesc = "Right lung / brochus", sbPaintbrush = sbPCol, nZoneX = 70, nZoneY = 125, nZonewidth = 75, nZoneheight = 50 });
            //tZones.Add(new clsTreatmentZones() { nZoneID = 25, sZoneCode = "R25", sZoneDesc = "Diaphragm", sbPaintbrush = sbPCol, nZoneX = 70, nZoneY = 185, nZonewidth = 40, nZoneheight = 15 });
            //tZones.Add(new clsTreatmentZones() { nZoneID = 26, sZoneCode = "R26", sZoneDesc = "Solar Plexus", sbPaintbrush = sbPCol, nZoneX = 110, nZoneY = 192, nZonewidth = 25, nZoneheight = 15 });
            //tZones.Add(new clsTreatmentZones() { nZoneID = 27, sZoneCode = "R27", sZoneDesc = "Liver", sbPaintbrush = sbPCol, nZoneX = 80, nZoneY = 210, nZonewidth = 40, nZoneheight = 40 });
            //tZones.Add(new clsTreatmentZones() { nZoneID = 28, sZoneCode = "R28", sZoneDesc = "Pancreas", sbPaintbrush = sbPCol, nZoneX = 145, nZoneY = 253, nZonewidth = 25, nZoneheight = 15 });
            //tZones.Add(new clsTreatmentZones() { nZoneID = 29, sZoneCode = "R29", sZoneDesc = "Gall bladder", sbPaintbrush = sbPCol, nZoneX = 60, nZoneY = 220, nZonewidth = 15, nZoneheight = 15 });
            //tZones.Add(new clsTreatmentZones() { nZoneID = 30, sZoneCode = "R30", sZoneDesc = "Adrenal gland", sbPaintbrush = sbPCol, nZoneX = 135, nZoneY = 230, nZonewidth = 20, nZoneheight = 15 });
            //tZones.Add(new clsTreatmentZones() { nZoneID = 31, sZoneCode = "R31", sZoneDesc = "Kidney", sbPaintbrush = sbPCol, nZoneX = 110, nZoneY = 250, nZonewidth = 30, nZoneheight = 35 });
            //tZones.Add(new clsTreatmentZones() { nZoneID = 32, sZoneCode = "R32", sZoneDesc = "Uretera", sbPaintbrush = sbPCol, nZoneX = 147, nZoneY = 285, nZonewidth = 10, nZoneheight = 35 });
            //tZones.Add(new clsTreatmentZones() { nZoneID = 33, sZoneCode = "R33", sZoneDesc = "Bladder", sbPaintbrush = sbPCol, nZoneX = 165, nZoneY = 330, nZonewidth = 10, nZoneheight = 25 });
            //tZones.Add(new clsTreatmentZones() { nZoneID = 34, sZoneCode = "R34", sZoneDesc = "Small intestine", sbPaintbrush = sbPCol, nZoneX = 80, nZoneY = 295, nZonewidth = 60, nZoneheight = 50 });
            //tZones.Add(new clsTreatmentZones() { nZoneID = 35, sZoneCode = "R35", sZoneDesc = "Ileocaecal valve", sbPaintbrush = sbPCol, nZoneX = 70, nZoneY = 350, nZonewidth = 15, nZoneheight = 15 });
            //tZones.Add(new clsTreatmentZones() { nZoneID = 36, sZoneCode = "R36", sZoneDesc = "Appendix", sbPaintbrush = sbPCol, nZoneX = 60, nZoneY = 360, nZonewidth = 10, nZoneheight = 10 });
            //tZones.Add(new clsTreatmentZones() { nZoneID = 37, sZoneCode = "R37", sZoneDesc = "Ascending Colon", sbPaintbrush = sbPCol, nZoneX =55, nZoneY = 305, nZonewidth = 15, nZoneheight = 40 });
            //tZones.Add(new clsTreatmentZones() { nZoneID = 38, sZoneCode = "R38", sZoneDesc = "Transverse Colon", sbPaintbrush = sbPCol, nZoneX = 70, nZoneY = 275, nZonewidth = 40, nZoneheight = 15 });
            //tZones.Add(new clsTreatmentZones() { nZoneID = 39, sZoneCode = "R39", sZoneDesc = "Pelvic muscles", sbPaintbrush = sbPCol, nZoneX = 80, nZoneY = 390, nZonewidth = 60, nZoneheight = 40 });
            //tZones.Add(new clsTreatmentZones() { nZoneID = 40, sZoneCode = "R40", sZoneDesc = "Sciatic nerve", sbPaintbrush = sbPCol, nZoneX = 85, nZoneY = 370, nZonewidth = 40, nZoneheight = 15 });




        }

        public void LoadTreatmentZone_LSole()
        {
            try
            {
                System.Drawing.Color sbPCol = Color.Coral;

                string sSQL = "SELECT pkID, TreatmentAreaCode, TreatmentAreaDesc, ZoneX, ZoneY, ZoneW, ZoneH FROM dbreflexpro.lktreatmentareas WHERE fkTreatmentMapArea = 2; ";
                Datafeed cData = new Datafeed();
                DataSet dsData = new DataSet();
                cData.GetDataset(sSQL, ref dsData);
                cData = null;

                if (dsData.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in dsData.Tables[0].Rows)
                    {
                        tZones2.Add(new clsTreatmentZones()
                        {
                            nZoneID = Convert.ToInt32(row["pkID"].ToString()),
                            sZoneCode = row["TreatmentAreaCode"].ToString(),
                            sZoneDesc = row["TreatmentAreaDesc"].ToString(),
                            sbPaintbrush = sbPCol,
                            nZoneX = Convert.ToInt32(row["ZoneX"].ToString()),
                            nZoneY = Convert.ToInt32(row["ZoneY"].ToString()),
                            nZonewidth = Convert.ToInt32(row["ZoneW"].ToString()),
                            nZoneheight = Convert.ToInt32(row["ZoneH"].ToString())
                        });
                    }
                }

                dsData = null;
                //tZones2.Add(new clsTreatmentZones() { nZoneID= 42, sZoneCode="LS1", sZoneDesc="Brain", sbPaintbrush= sbPCol, nZoneX=50, nZoneY=30, nZonewidth=25, nZoneheight = 20 });
                //tZones2.Add(new clsTreatmentZones() { nZoneID = 43, sZoneCode = "LS2", sZoneDesc = "Pituitary", sbPaintbrush = sbPCol, nZoneX = 55, nZoneY = 55, nZonewidth = 12, nZoneheight = 12 });
                //tZones2.Add(new clsTreatmentZones() { nZoneID = 44, sZoneCode = "LS3", sZoneDesc = "Hypothalamus", sbPaintbrush = sbPCol, nZoneX = 34, nZoneY = 55, nZonewidth = 12, nZoneheight = 12 });
                //tZones2.Add(new clsTreatmentZones() { nZoneID = 45, sZoneCode = "LS4", sZoneDesc = "Pineal", sbPaintbrush = sbPCol, nZoneX = 37, nZoneY = 65, nZonewidth = 15, nZoneheight = 15 });
                //tZones2.Add(new clsTreatmentZones() { nZoneID = 46, sZoneCode = "LS5", sZoneDesc = "Occiput", sbPaintbrush = sbPCol, nZoneX = 70, nZoneY = 80, nZonewidth = 12, nZoneheight = 12 });
                //tZones2.Add(new clsTreatmentZones() { nZoneID = 47, sZoneCode = "LS6", sZoneDesc = "Neck – big toe", sbPaintbrush = sbPCol, nZoneX = 45, nZoneY = 90, nZonewidth = 25, nZoneheight =15 });
                //tZones2.Add(new clsTreatmentZones() { nZoneID = 48, sZoneCode = "LS7", sZoneDesc = "Thyroid / Parathyroid", sbPaintbrush = sbPCol, nZoneX = 45, nZoneY = 114, nZonewidth = 20, nZoneheight = 10 });

                //tZones2.Add(new clsTreatmentZones() { nZoneID = 49, sZoneCode = "LS8", sZoneDesc = "Sinus – toe 2", sbPaintbrush = sbPCol, nZoneX = 85, nZoneY = 65, nZonewidth = 20, nZoneheight = 15 });
                //tZones2.Add(new clsTreatmentZones() { nZoneID = 50, sZoneCode = "LS9", sZoneDesc = "Neck – toe 2", sbPaintbrush = sbPCol, nZoneX = 88, nZoneY = 40, nZonewidth = 15, nZoneheight = 12 });
                //tZones2.Add(new clsTreatmentZones() { nZoneID = 51, sZoneCode = "LS10", sZoneDesc = "Sinus – toe 3", sbPaintbrush = sbPCol, nZoneX = 115, nZoneY = 70, nZonewidth = 20, nZoneheight = 15 });
                //tZones2.Add(new clsTreatmentZones() { nZoneID = 52, sZoneCode = "LS11", sZoneDesc = "Neck – toe 3", sbPaintbrush = sbPCol, nZoneX = 118, nZoneY = 48, nZonewidth = 15, nZoneheight = 12 });
                //tZones2.Add(new clsTreatmentZones() { nZoneID = 53, sZoneCode = "LS12", sZoneDesc = "Sinus – toe 4", sbPaintbrush = sbPCol, nZoneX = 137, nZoneY = 80, nZonewidth = 20, nZoneheight = 15 });
                //tZones2.Add(new clsTreatmentZones() { nZoneID = 54, sZoneCode = "LS13", sZoneDesc = "Neck – toe 4", sbPaintbrush = sbPCol, nZoneX = 145, nZoneY = 65, nZonewidth = 15, nZoneheight = 12 });
                //tZones2.Add(new clsTreatmentZones() { nZoneID = 55, sZoneCode = "LS14", sZoneDesc = "Sinus – toe 5", sbPaintbrush = sbPCol, nZoneX = 165, nZoneY = 102, nZonewidth = 20, nZoneheight = 15 });
                //tZones2.Add(new clsTreatmentZones() { nZoneID = 56, sZoneCode = "LS15", sZoneDesc = "Neck – toe 5", sbPaintbrush = sbPCol, nZoneX = 165, nZoneY = 90, nZonewidth = 15, nZoneheight = 12 });
                //tZones2.Add(new clsTreatmentZones() { nZoneID = 57, sZoneCode = "LS16", sZoneDesc = "Left Eye", sbPaintbrush = sbPCol, nZoneX = 98, nZoneY = 98, nZonewidth = 20, nZoneheight = 10 });
                //tZones2.Add(new clsTreatmentZones() { nZoneID = 58, sZoneCode = "LS17", sZoneDesc = "Left Ear / Eustachian tube", sbPaintbrush = sbPCol, nZoneX = 125, nZoneY = 103, nZonewidth = 20, nZoneheight = 10 });
                //tZones2.Add(new clsTreatmentZones() { nZoneID = 59, sZoneCode = "LS18", sZoneDesc = "Balance", sbPaintbrush = sbPCol, nZoneX = 155, nZoneY = 113, nZonewidth = 20, nZoneheight = 10 });
                //tZones2.Add(new clsTreatmentZones() { nZoneID = 60, sZoneCode = "LS19", sZoneDesc = "Trapezius", sbPaintbrush = sbPCol, nZoneX = 165, nZoneY = 130, nZonewidth = 30, nZoneheight = 10 });

                //tZones2.Add(new clsTreatmentZones() { nZoneID = 61, sZoneCode = "LS20", sZoneDesc = "Thymus", sbPaintbrush = sbPCol, nZoneX = 30, nZoneY = 130, nZonewidth = 10, nZoneheight = 20 });
                //tZones2.Add(new clsTreatmentZones() { nZoneID = 62, sZoneCode = "LS21", sZoneDesc = "Brochus", sbPaintbrush = sbPCol, nZoneX = 55, nZoneY = 140, nZonewidth = 30, nZoneheight = 10 });
                //tZones2.Add(new clsTreatmentZones() { nZoneID = 63, sZoneCode = "LS22", sZoneDesc = "Heart", sbPaintbrush = sbPCol, nZoneX = 40, nZoneY = 150, nZonewidth = 30, nZoneheight = 30 });
                //tZones2.Add(new clsTreatmentZones() { nZoneID = 64, sZoneCode = "LS23", sZoneDesc = "Thyroid Helper", sbPaintbrush = sbPCol, nZoneX = 43, nZoneY = 185, nZonewidth = 30, nZoneheight = 10 });

                //tZones2.Add(new clsTreatmentZones() { nZoneID = 65, sZoneCode = "LS24", sZoneDesc = "Left shoulder", sbPaintbrush = sbPCol, nZoneX = 175, nZoneY = 150, nZonewidth = 15, nZoneheight = 15 });
                //tZones2.Add(new clsTreatmentZones() { nZoneID = 66, sZoneCode = "LS25", sZoneDesc = "Left arm", sbPaintbrush = sbPCol, nZoneX = 175, nZoneY = 178, nZonewidth = 15, nZoneheight = 15 });
                //tZones2.Add(new clsTreatmentZones() { nZoneID = 67, sZoneCode = "LS26", sZoneDesc = "Left lung", sbPaintbrush = sbPCol, nZoneX = 95, nZoneY = 130, nZonewidth = 60, nZoneheight = 50 });
                //tZones2.Add(new clsTreatmentZones() { nZoneID = 68, sZoneCode = "LS27", sZoneDesc = "Oesophagus", sbPaintbrush = sbPCol, nZoneX = 50, nZoneY = 125, nZonewidth = 15, nZoneheight = 10 });
                //tZones2.Add(new clsTreatmentZones() { nZoneID = 69, sZoneCode = "LS28", sZoneDesc = "Diaphragm", sbPaintbrush = sbPCol, nZoneX = 125, nZoneY = 182, nZonewidth = 30, nZoneheight = 12 });
                //tZones2.Add(new clsTreatmentZones() { nZoneID = 70, sZoneCode = "LS29", sZoneDesc = "Solar Plexus", sbPaintbrush = sbPCol, nZoneX = 95, nZoneY = 195, nZonewidth = 30, nZoneheight = 12 });

                //tZones2.Add(new clsTreatmentZones() { nZoneID = 71, sZoneCode = "LS30", sZoneDesc = "Liver", sbPaintbrush = sbPCol, nZoneX = 60, nZoneY = 220, nZonewidth = 25, nZoneheight = 10 });
                //tZones2.Add(new clsTreatmentZones() { nZoneID = 72, sZoneCode = "LS31", sZoneDesc = "Stomach", sbPaintbrush = sbPCol, nZoneX = 105, nZoneY = 215, nZonewidth = 25, nZoneheight = 25 });
                //tZones2.Add(new clsTreatmentZones() { nZoneID = 73, sZoneCode = "LS32", sZoneDesc = "Adrenal gland", sbPaintbrush = sbPCol, nZoneX = 75, nZoneY = 230, nZonewidth = 17, nZoneheight = 15 });
                //tZones2.Add(new clsTreatmentZones() { nZoneID = 74, sZoneCode = "LS33", sZoneDesc = "Spleen", sbPaintbrush = sbPCol, nZoneX = 140, nZoneY = 215, nZonewidth = 25, nZoneheight = 25 });
                //tZones2.Add(new clsTreatmentZones() { nZoneID = 75, sZoneCode = "LS34", sZoneDesc = "Pancreas", sbPaintbrush = sbPCol, nZoneX = 65, nZoneY = 250, nZonewidth = 20, nZoneheight = 20 });
                //tZones2.Add(new clsTreatmentZones() { nZoneID = 76, sZoneCode = "LS35", sZoneDesc = "Kidney", sbPaintbrush = sbPCol, nZoneX = 85, nZoneY = 245, nZonewidth = 30, nZoneheight = 30 });

                //tZones2.Add(new clsTreatmentZones() { nZoneID = 77, sZoneCode = "LS36", sZoneDesc = "Ureter", sbPaintbrush = sbPCol, nZoneX = 70, nZoneY = 285, nZonewidth = 10, nZoneheight = 35 });
                //tZones2.Add(new clsTreatmentZones() { nZoneID = 78, sZoneCode = "LS37", sZoneDesc = "Bladder", sbPaintbrush = sbPCol, nZoneX = 60, nZoneY = 325, nZonewidth = 10, nZoneheight = 15 });
                //tZones2.Add(new clsTreatmentZones() { nZoneID = 79, sZoneCode = "LS38", sZoneDesc = "Small intestine", sbPaintbrush = sbPCol, nZoneX = 90, nZoneY = 285, nZonewidth = 65, nZoneheight = 50 });
                //tZones2.Add(new clsTreatmentZones() { nZoneID = 80, sZoneCode = "LS39", sZoneDesc = "Transverse Colon", sbPaintbrush = sbPCol, nZoneX =125, nZoneY = 270, nZonewidth = 30, nZoneheight = 10 });
                //tZones2.Add(new clsTreatmentZones() { nZoneID = 81, sZoneCode = "LS40", sZoneDesc = "Descending Colon", sbPaintbrush = sbPCol, nZoneX = 160, nZoneY = 285, nZonewidth = 10, nZoneheight = 35 });
                //tZones2.Add(new clsTreatmentZones() { nZoneID = 82, sZoneCode = "LS41", sZoneDesc = "Sigmoid colon", sbPaintbrush = sbPCol, nZoneX = 125, nZoneY = 350, nZonewidth = 30, nZoneheight = 10 });

                //tZones2.Add(new clsTreatmentZones() { nZoneID = 83, sZoneCode = "LS42", sZoneDesc = "Pelvic muscles", sbPaintbrush = sbPCol, nZoneX = 85, nZoneY = 380, nZonewidth = 65, nZoneheight = 50 });
                //tZones2.Add(new clsTreatmentZones() { nZoneID = 84, sZoneCode = "LS43", sZoneDesc = "Sciatic nerve", sbPaintbrush = sbPCol, nZoneX = 110, nZoneY = 365, nZonewidth = 30, nZoneheight = 10 });



            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading Treatment Zones - L Sole", MessageBoxButtons.OK);
            }
        }
        private void LoadTreatmentReport()
        {
            try
            {
                //This will load the Datagrid with the parts recorded during treatment.
                //You will need to load the report for several parts
                //Right Sole, Left Sole == > and TA.fkTreatmentMapArea = 1 or 2
                //or Right Dorsal and Left Dorsal


                string sSQL = "Select TA.TreatmentAreaCode, TA.TreatmentAreaDesc, " +
                            "TAP.TreatmentAreaProblem, " +
                            "TAPF.TAProblemFindingDesc as Problem " +
                            "FROM dbreflexpro.treatmentrecordareas TRA " +
                            "inner join  dbreflexpro.lktreatmentareas TA on TRA.fkTreatmentAreaID = TA.pkID " +
                            "inner join dbreflexpro.lktreatmentareaproblemfinding TAPF " +
                            "on(TRA.fkTreatmentAreaID = TAPF.fkTreatmentAreaID and TRA.fkTreatmentAreaProblemID = TAPF.fkTreatmentAreaProblemID) " +
                            "inner join dbreflexpro.lktreatmentareaproblem TAP on TAPF.fkTreatmentAreaProblemID = TAP.pkID " +
                            " WHERE TRA.fkPatientRecordID = " + Variables.giSelectedPatientRecordID + " = 1 " +
                            " AND TRA.fkTreatmentRecordID = " + Variables.giSelectedPatientTreatmentID  + " order by TA.fkTreatmentMapArea ";
                   


                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
                clsProcess cProc = new clsProcess();
                cProc.LoadPatientlist(sSQL, this.dgData);
                cProc = null;
                System.Windows.Forms.Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading Patient Treatment Entries", MessageBoxButtons.OK);
            }
        }

        private void LoadTreatmentNotes()
        {
        DataSet dsData = new DataSet();
            try
            {
                string sSQL = "Select Notes_DorsalR, Notes_DorsalL from dbreflexpro.treatmentrecords where pkID = " + Variables.giSelectedPatientTreatmentID;
                
                clsProcess cProc = new clsProcess();
                cProc.LoadPatientRecord(sSQL, dsData);
                cProc = null;

                if (dsData.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in dsData.Tables[0].Rows)
                        //Not working as need to load RTF values
                    {
                        this.rtbNotes_1.Text = Convert.ToString(row["Notes_DorsalR"]);
                        this.rtbNotes_2.Text = Convert.ToString(row["Notes_DorsalL"]);

                    }

                }
                dsData = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading Patient Treatment Entries", MessageBoxButtons.OK);
            }

            finally
            {
                dsData = null;
            }

        }
        public frmTreatmentMap()
        {
            InitializeComponent();
            LoadTreatmentZone_RSole();
            LoadTreatmentZone_LSole();
            if (Variables.giSelectedPatientTreatmentID == 0)
            {
                this.lblTitle_2.Text = "New Treatment for " + Variables.gsPatientHeaderInfo;
                this.lblTreatmentID.Text = "0";

            }

            else
            {
                this.lblTitle_2.Text = "Previous Treatment for " + Variables.gsPatientHeaderInfo;
                this.lblTreatmentID.Text = Variables.giSelectedPatientTreatmentID.ToString();
                this.txtTreatmentDate.Text = Variables.gsTreatmentDate;
                LoadTreatmentNotes();
                LoadTreatmentReport();
            }

        }

      
        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private int ZoneClickedRS(int mouseX, int mouseY,int TreatmentArea)
        {
            
            switch (TreatmentArea)
            {
                case 1:
                    {
                    int ix;
                        for (ix = 0; ix < tZones.Count; ix++)
                        {
                            if ((mouseX >= tZones[ix].nZoneX) && (mouseX <= (tZones[ix].nZoneX + tZones[ix].nZonewidth)) &&
                        (mouseY >= tZones[ix].nZoneY) && (mouseY <= (tZones[ix].nZoneY + tZones[ix].nZoneheight)))
                                return ix;
                            //else return NOT_IN_ZONE;
                        }
                        //return NOT_IN_ZONE;
                        break;
                    }
                case 2:
                    {

                        int ix;
                        for (ix = 0; ix < tZones2.Count; ix++)
                        {
                            if ((mouseX >= tZones2[ix].nZoneX) && (mouseX <= (tZones2[ix].nZoneX + tZones2[ix].nZonewidth)) &&
                        (mouseY >= tZones2[ix].nZoneY) && (mouseY <= (tZones2[ix].nZoneY + tZones2[ix].nZoneheight)))
                                return ix;
                            //else return NOT_IN_ZONE;
                        }
                        break;
                        //return NOT_IN_ZONE;
                    }

            }

            return NOT_IN_ZONE;

        }
      
                 

        private void pic_TreatmentZones1_RightSole_MouseClick(object sender, MouseEventArgs e)
        {
            int SelectedZoneID = ZoneClickedRS(e.X, e.Y,1);
            if (SelectedZoneID == NOT_IN_ZONE)
                return;
            string sZone = tZones[SelectedZoneID].sZoneDesc;
            miSelectedTreatmentZoneID = tZones[SelectedZoneID].nZoneID;
            msSelectedZoneDesc = tZones[SelectedZoneID].sZoneCode;
            lblTreating.Text = "Treating " + tZones[SelectedZoneID].sZoneCode + Environment.NewLine + sZone;
           // MessageBox.Show("The selected Zone:" + sZone, "Selected Treatment Zone", MessageBoxButtons.OK);
        }

        private void pic_TreatmentZones1_RightSole_Paint(object sender, PaintEventArgs e)
        {
            //LoadTreatmentZone_RSole();
            int ii;
            for (ii = 0; ii < tZones.Count; ii++)
            {
                e.Graphics.FillEllipse(new System.Drawing.SolidBrush(tZones[ii].sbPaintbrush), tZones[ii].nZoneX, tZones[ii].nZoneY, tZones[ii].nZonewidth, tZones[ii].nZoneheight);
            }
                
           // e.Graphics.FillEllipse(new System.Drawing.SolidBrush(tZones[1].sbPaintbrush), tZones[1].nZoneX, tZones[1].nZoneY, tZones[1].nZonewidth, tZones[1].nZoneheight);
        }

       

        private void pic_TreatmentZones1_RightSole_MouseMove(object sender, MouseEventArgs e)
        {
            int SelectedZoneID = ZoneClickedRS(e.X, e.Y,1);
            string sZone = "";
           
            if (SelectedZoneID == NOT_IN_ZONE)
                //return;
                tipTreatmentArea.RemoveAll();
            else
                sZone = tZones[SelectedZoneID].sZoneDesc;
            tipTreatmentArea.SetToolTip(pic_TreatmentZones1_RightSole, "Treating " + sZone);

        }
        
        
        //TREATING A PATIENT=====NOTES=====================================
        //WHEN TREATING A PATIENT WE CAN HAVE 2 PATHS :::::::::::::::
        //PATH ONE : A NEW TREATMENT SESSION
        //REQUIRES INSERTING A ROW INTO THE TREATMENT RECORDS TABLE, then extracting the pkID
        //THEN WE ARE REQUIRED TO INSERT ROWS INTO THE TREATMENTRECORDAREAS TABLE USING the TREATMENTRECORDID AND PATIENTID
        //================================
        //PATH TWO : EDITING AN EXISTING TREATMENT RECORD
        //UPDATING THE TREATMENTRECORDAREAS TABLE USING the TREATMENTRECORDID AND PATIENTID
        //==========================================================
        // TO DO ==== WORK LIST:
       // 




        private void cmdRS_Add_Click(object sender, EventArgs e)
        {



            //we need to prevent duplicate entries ==========
            //check the grid to see if this TreatmentZone is not already listed
            for (int nCounter = 0; nCounter <= this.dgData.RowCount - 1; nCounter++)
            {
                if(msSelectedZoneDesc == this.dgData[0,nCounter].Value.ToString())
                {
                    MessageBox.Show("This Zone has already been treated!", "Cannot add again!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.lblTreating.Text = "";
                    return;
                }

            }

                string sSQL = "";
            Int32 iiTreatmentAreaProblemID = 0;

            if (rdNormal.Checked == true)
                iiTreatmentAreaProblemID =1;
            else if (rdSwollen.Checked == true)
                iiTreatmentAreaProblemID = 2;
            else if (rdPuffy.Checked == true)
                iiTreatmentAreaProblemID = 3;
            else if (rdCrunchy.Checked == true)
                iiTreatmentAreaProblemID = 4;
            else iiTreatmentAreaProblemID = 5;

            clsProcess cProc = new clsProcess();
            DateTime dtToday = DateTime.Now;
            string sdtToday = Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss");
            DateTime dtTreatmentDate = Convert.ToDateTime(this.txtTreatmentDate.Text);
            //The Treatment Date could be today or another date in the past.
            //
            
            // SELECT LAST_INSERT_ID();
            if (lblTreatmentID.Text == "0")
            { sSQL = "Insert into dbreflexpro.treatmentrecords(fkPatientRecordID, TreatmentDate) VALUES(" + Variables.giSelectedPatientRecordID + ",'" + sdtToday + "'); ";
                cProc.WriteNewPatientTreatmentEntry(sSQL); //This proc also gets the last inserted TreatmentID for this Patient
                //We want to keep this ID in a safe place.
                Variables.giSelectedPatientTreatmentID = Variables.giLastInsertedID;
                this.lblTreatmentID.Text = Variables.giSelectedPatientTreatmentID.ToString();

                sSQL = "INSERT INTO dbreflexpro.treatmentrecordareas(fkPatientRecordID,fkTreatmentRecordID,fkTreatmentAreaID,fkTreatmentAreaProblemID) " +
                   "VALUES(" + Variables.giSelectedPatientRecordID + "," + Convert.ToInt32(lblTreatmentID.Text) + "," + miSelectedTreatmentZoneID + "," + iiTreatmentAreaProblemID + ")";
                cProc.WritePatientRecord(sSQL);

                lblTreating.Text = "";
            }
              
            else
            {

                sSQL = "INSERT INTO dbreflexpro.treatmentrecordareas(fkPatientRecordID,fkTreatmentRecordID,fkTreatmentAreaID,fkTreatmentAreaProblemID) " +
                    "VALUES(" + Variables.giSelectedPatientRecordID + "," + Convert.ToInt32(lblTreatmentID.Text) + "," + miSelectedTreatmentZoneID + "," + iiTreatmentAreaProblemID + ")";
                cProc.WritePatientRecord(sSQL);
                lblTreating.Text = "";
            }

            LoadTreatmentReport();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdLS_Add_Click(object sender, EventArgs e)
        {
            string sSQL = "";
            Int32 iiTreatmentAreaProblemID = 0;
            //we need to prevent duplicate entries ==========
            //check the grid to see if this TreatmentZone is not already listed
            for (int nCounter = 0; nCounter <= this.dgData.RowCount - 1; nCounter++)
            {
                if (msSelectedZoneDesc == this.dgData[0, nCounter].Value.ToString())
                {
                    MessageBox.Show("This Zone has already been treated!", "Cannot add again!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.lblTreating2.Text = "";
                    return;
                }

            }


            if (rdNormal_LS.Checked == true)
                iiTreatmentAreaProblemID = 1;
            else if (rdSwollen_LS.Checked == true)
                iiTreatmentAreaProblemID = 2;
            else if (rdPuffy_LS.Checked == true)
                iiTreatmentAreaProblemID = 3;
            else if (rdCrunchy_LS.Checked == true)
                iiTreatmentAreaProblemID = 4;
            else iiTreatmentAreaProblemID = 5;

            clsProcess cProc = new clsProcess();
            DateTime dtToday = DateTime.Now;
            string sdtToday = Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss");
            // SELECT LAST_INSERT_ID();
            if (lblTreatmentID.Text == "0")
            {
                sSQL = "Insert into dbreflexpro.treatmentrecords(fkPatientRecordID, TreatmentDate) VALUES(" + Variables.giSelectedPatientRecordID + ",'" + sdtToday + "'); ";
                cProc.WriteNewPatientTreatmentEntry(sSQL); //This proc also gets the last inserted TreatmentID for this Patient
                //We want to keep this ID in a safe place.
                Variables.giSelectedPatientTreatmentID = Variables.giLastInsertedID;
                this.lblTreatmentID.Text = Variables.giSelectedPatientTreatmentID.ToString();

                sSQL = "INSERT INTO dbreflexpro.treatmentrecordareas(fkPatientRecordID,fkTreatmentRecordID,fkTreatmentAreaID,fkTreatmentAreaProblemID) " +
                   "VALUES(" + Variables.giSelectedPatientRecordID + "," + Convert.ToInt32(lblTreatmentID.Text) + "," + miSelectedTreatmentZoneID + "," + iiTreatmentAreaProblemID + ")";
                cProc.WritePatientRecord(sSQL);

                lblTreating2.Text = "";
            }

            else
            {

                sSQL = "INSERT INTO dbreflexpro.treatmentrecordareas(fkPatientRecordID,fkTreatmentRecordID,fkTreatmentAreaID,fkTreatmentAreaProblemID) " +
                    "VALUES(" + Variables.giSelectedPatientRecordID + "," + Convert.ToInt32(lblTreatmentID.Text) + "," + miSelectedTreatmentZoneID + "," + iiTreatmentAreaProblemID + ")";
                cProc.WritePatientRecord(sSQL);
                lblTreating2.Text = "";
            }

            LoadTreatmentReport();
        }

        private void pic_TreatmentZones2_LeftSole_Paint(object sender, PaintEventArgs e)
        {
            int ii;
            for (ii = 0; ii < (tZones2.Count); ii++)
            {
                e.Graphics.FillEllipse(new System.Drawing.SolidBrush(tZones2[ii].sbPaintbrush), tZones2[ii].nZoneX, tZones2[ii].nZoneY, tZones2[ii].nZonewidth, tZones2[ii].nZoneheight);
            }
        }

        private void pic_TreatmentZones2_LeftSole_MouseMove(object sender, MouseEventArgs e)
        {
            int SelectedZoneID = ZoneClickedRS(e.X, e.Y, 2);
            string sZone = "";

            if (SelectedZoneID == NOT_IN_ZONE)
                //return;
                tipTreatmentArea.RemoveAll();
            else
                sZone = tZones2[SelectedZoneID].sZoneDesc;
            tipTreatmentArea.SetToolTip(pic_TreatmentZones2_LeftSole, "Treating " + sZone);
        }

        private void pic_TreatmentZones2_LeftSole_MouseClick(object sender, MouseEventArgs e)
        {
            int SelectedZoneID = ZoneClickedRS(e.X, e.Y, 2);
            if (SelectedZoneID == NOT_IN_ZONE)
                return;
            string sZone = tZones2[SelectedZoneID].sZoneDesc;
            miSelectedTreatmentZoneID = tZones2[SelectedZoneID].nZoneID;
            msSelectedZoneDesc = tZones2[SelectedZoneID].sZoneCode;
            lblTreating2.Text = "Treating " + tZones2[SelectedZoneID].sZoneCode + Environment.NewLine + sZone;
        }

        private void cmdEmail_Click(object sender, EventArgs e)
        {

            // see examples here https://stackoverflow.com/questions/32260/sending-email-in-net-through-gmail
            //Specify senders gmail address
            string SendersAddress = "lenvdb64@gmail.com";
            //Specify The Address You want to sent Email To(can be any valid email address)
            string ReceiversAddress = "adey73@gmail.com";
            //Specify The password of gmial account u are using to sent mail(pw of sender@gmail.com)
            const string SendersPassword = "D00gf@ce";
            //Write the subject of ur mail
            const string subject = "Testing Reflex Pro Email";
            //Write the contents of your mail
            const string body = "Hi This Is my Test eMail From from Reflex Pro - Len";

            try
            {
                //we will use Smtp client which allows us to send email using SMTP Protocol
                //i have specified the properties of SmtpClient smtp within{}
                //gmails smtp server name is smtp.gmail.com and port number is 587
                SmtpClient smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new NetworkCredential(SendersAddress, SendersPassword),
                    Timeout = 3000
                };
                //MailMessage represents a mail message
                //it is 4 parameters(From,TO,subject,body)

                MailMessage message = new MailMessage(SendersAddress, ReceiversAddress, subject, body);
                /*WE use smtp sever we specified above to send the message(MailMessage message)*/

                smtp.Send(message);

                MessageBox.Show("Patient Treatment Report successfully emailed","Email Sent!", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error emailing Patient Treatment Report", MessageBoxButtons.OK);
            }

        }

        private void cmdAdd_RSole_Click(object sender, EventArgs e)
        {
            string sSQL = "";

            try
            {
                sSQL = "Update dbreflexpro.treatmentrecords set Notes_DorsalR = '" + this.rtbNotes_1.Text + "' where pkID = " + Variables.giSelectedPatientTreatmentID;
                             

                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
                clsProcess cProc = new clsProcess();
                cProc.WritePatientRecord(sSQL);
                cProc = null;
                System.Windows.Forms.Cursor.Current = Cursors.Default;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error saving Patient Notes Right Dorsal", MessageBoxButtons.OK);
            }
        }

        private void cmdClearNotes_RSole_Click(object sender, EventArgs e)
        {
            this.rtbNotes_1.Text = "";
        }

        private void cmdSave_LSole_Click(object sender, EventArgs e)
        {
            string sSQL = "";

            try
            {
                sSQL = "Update dbreflexpro.treatmentrecords set Notes_DorsalL = '" + this.rtbNotes_2.Text + "' where pkID = " + Variables.giSelectedPatientTreatmentID;


                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
                clsProcess cProc = new clsProcess();
                cProc.WritePatientRecord(sSQL);
                cProc = null;
                System.Windows.Forms.Cursor.Current = Cursors.Default;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error saving Patient Notes Left Dorsal", MessageBoxButtons.OK);
            }
        }

        private void cmdClearNotes_LSole_Click(object sender, EventArgs e)
        {
            this.rtbNotes_2.Text = "";
        }

        private void cmdReport_Click(object sender, EventArgs e)
        {
            //frmPatientRecord frmPR = new frmPatientRecord();
            //Variables.giSelectedPatientRecordID = 0;
            //System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
            //frmPR.Show();
            //System.Windows.Forms.Cursor.Current = Cursors.Default;

            frmWebReport frmWBRpt = new frmWebReport();
            frmWBRpt.Show();

        }

        private void cmdDate_Click(object sender, EventArgs e)
        {
            this.txtTreatmentDate.Text = dtDate.Text;
        }
    }
}
