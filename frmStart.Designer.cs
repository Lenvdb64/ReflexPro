namespace ReflexPro
{
    partial class frmStart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStart));
            this.picStart = new System.Windows.Forms.PictureBox();
            this.lblTitle_1 = new System.Windows.Forms.Label();
            this.lblTitle_2 = new System.Windows.Forms.Label();
            this.cmdExit = new System.Windows.Forms.Button();
            this.llNewPatient = new System.Windows.Forms.LinkLabel();
            this.llOpenPatientRecord = new System.Windows.Forms.LinkLabel();
            this.llReport = new System.Windows.Forms.LinkLabel();
            this.llAbout = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picStart)).BeginInit();
            this.SuspendLayout();
            // 
            // picStart
            // 
            this.picStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picStart.Image = ((System.Drawing.Image)(resources.GetObject("picStart.Image")));
            this.picStart.Location = new System.Drawing.Point(433, 1);
            this.picStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picStart.Name = "picStart";
            this.picStart.Size = new System.Drawing.Size(291, 572);
            this.picStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStart.TabIndex = 0;
            this.picStart.TabStop = false;
            // 
            // lblTitle_1
            // 
            this.lblTitle_1.AutoSize = true;
            this.lblTitle_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle_1.Location = new System.Drawing.Point(50, 58);
            this.lblTitle_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle_1.Name = "lblTitle_1";
            this.lblTitle_1.Size = new System.Drawing.Size(280, 29);
            this.lblTitle_1.TabIndex = 1;
            this.lblTitle_1.Text = "Welcome to Reflex Pro";
            // 
            // lblTitle_2
            // 
            this.lblTitle_2.AutoSize = true;
            this.lblTitle_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle_2.Location = new System.Drawing.Point(50, 101);
            this.lblTitle_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle_2.Name = "lblTitle_2";
            this.lblTitle_2.Size = new System.Drawing.Size(317, 25);
            this.lblTitle_2.TabIndex = 2;
            this.lblTitle_2.Text = "What would you like to do next?";
            // 
            // cmdExit
            // 
            this.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdExit.Location = new System.Drawing.Point(130, 535);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(90, 38);
            this.cmdExit.TabIndex = 3;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // llNewPatient
            // 
            this.llNewPatient.AutoSize = true;
            this.llNewPatient.Location = new System.Drawing.Point(89, 186);
            this.llNewPatient.Name = "llNewPatient";
            this.llNewPatient.Size = new System.Drawing.Size(169, 20);
            this.llNewPatient.TabIndex = 4;
            this.llNewPatient.TabStop = true;
            this.llNewPatient.Text = "Register a new Patient";
            this.llNewPatient.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llNewPatient_LinkClicked);
            // 
            // llOpenPatientRecord
            // 
            this.llOpenPatientRecord.AutoSize = true;
            this.llOpenPatientRecord.Location = new System.Drawing.Point(92, 225);
            this.llOpenPatientRecord.Name = "llOpenPatientRecord";
            this.llOpenPatientRecord.Size = new System.Drawing.Size(171, 20);
            this.llOpenPatientRecord.TabIndex = 5;
            this.llOpenPatientRecord.TabStop = true;
            this.llOpenPatientRecord.Text = "Open a Patient Record";
            this.llOpenPatientRecord.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // llReport
            // 
            this.llReport.AutoSize = true;
            this.llReport.Location = new System.Drawing.Point(118, 263);
            this.llReport.Name = "llReport";
            this.llReport.Size = new System.Drawing.Size(102, 20);
            this.llReport.TabIndex = 6;
            this.llReport.TabStop = true;
            this.llReport.Text = "View a report";
            this.llReport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llReport_LinkClicked);
            // 
            // llAbout
            // 
            this.llAbout.AutoSize = true;
            this.llAbout.Location = new System.Drawing.Point(144, 294);
            this.llAbout.Name = "llAbout";
            this.llAbout.Size = new System.Drawing.Size(52, 20);
            this.llAbout.TabIndex = 7;
            this.llAbout.TabStop = true;
            this.llAbout.Text = "About";
            this.llAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAbout_LinkClicked);
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(737, 587);
            this.Controls.Add(this.llAbout);
            this.Controls.Add(this.llReport);
            this.Controls.Add(this.llOpenPatientRecord);
            this.Controls.Add(this.llNewPatient);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.lblTitle_2);
            this.Controls.Add(this.lblTitle_1);
            this.Controls.Add(this.picStart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to ReflexPro";
            this.Load += new System.EventHandler(this.frmStart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picStart;
        private System.Windows.Forms.Label lblTitle_1;
        private System.Windows.Forms.Label lblTitle_2;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.LinkLabel llNewPatient;
        private System.Windows.Forms.LinkLabel llOpenPatientRecord;
        private System.Windows.Forms.LinkLabel llReport;
        private System.Windows.Forms.LinkLabel llAbout;
    }
}

