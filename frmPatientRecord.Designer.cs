namespace ReflexPro
{
    partial class frmPatientRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatientRecord));
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtOtherNames = new System.Windows.Forms.TextBox();
            this.txtAddrLine1 = new System.Windows.Forms.TextBox();
            this.txtAddrLine2 = new System.Windows.Forms.TextBox();
            this.txtAddrTown = new System.Windows.Forms.TextBox();
            this.txtAddrPostcode = new System.Windows.Forms.TextBox();
            this.txtPhone_M = new System.Windows.Forms.TextBox();
            this.txtPhone_H = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblPatientRecordID = new System.Windows.Forms.Label();
            this.cmdTreatments = new System.Windows.Forms.Button();
            this.cboTitle = new System.Windows.Forms.ComboBox();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.cmdSetData = new System.Windows.Forms.Button();
            this.tbPatientDetails = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbPatientDetails.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdSave
            // 
            this.cmdSave.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdSave.Location = new System.Drawing.Point(644, 415);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(138, 32);
            this.cmdSave.TabIndex = 0;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdClose.Location = new System.Drawing.Point(818, 461);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(138, 32);
            this.cmdClose.TabIndex = 1;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Patient ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Patient Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Patient Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Patient First Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Patient Other Names";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Patient Address Ln1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Patient Address Ln2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Patient Address Town";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Patient Address Postcode";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 333);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Patient Mobile Phone";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 360);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Patient Home Phone";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 388);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Patient Email";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(205, 64);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(294, 26);
            this.txtSurname.TabIndex = 14;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(205, 97);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(294, 26);
            this.txtFName.TabIndex = 15;
            // 
            // txtOtherNames
            // 
            this.txtOtherNames.Location = new System.Drawing.Point(205, 129);
            this.txtOtherNames.Name = "txtOtherNames";
            this.txtOtherNames.Size = new System.Drawing.Size(294, 26);
            this.txtOtherNames.TabIndex = 16;
            // 
            // txtAddrLine1
            // 
            this.txtAddrLine1.Location = new System.Drawing.Point(205, 214);
            this.txtAddrLine1.Name = "txtAddrLine1";
            this.txtAddrLine1.Size = new System.Drawing.Size(294, 26);
            this.txtAddrLine1.TabIndex = 17;
            // 
            // txtAddrLine2
            // 
            this.txtAddrLine2.Location = new System.Drawing.Point(205, 242);
            this.txtAddrLine2.Name = "txtAddrLine2";
            this.txtAddrLine2.Size = new System.Drawing.Size(294, 26);
            this.txtAddrLine2.TabIndex = 18;
            // 
            // txtAddrTown
            // 
            this.txtAddrTown.Location = new System.Drawing.Point(205, 270);
            this.txtAddrTown.Name = "txtAddrTown";
            this.txtAddrTown.Size = new System.Drawing.Size(294, 26);
            this.txtAddrTown.TabIndex = 19;
            // 
            // txtAddrPostcode
            // 
            this.txtAddrPostcode.Location = new System.Drawing.Point(205, 298);
            this.txtAddrPostcode.Name = "txtAddrPostcode";
            this.txtAddrPostcode.Size = new System.Drawing.Size(133, 26);
            this.txtAddrPostcode.TabIndex = 20;
            // 
            // txtPhone_M
            // 
            this.txtPhone_M.Location = new System.Drawing.Point(205, 326);
            this.txtPhone_M.Name = "txtPhone_M";
            this.txtPhone_M.Size = new System.Drawing.Size(176, 26);
            this.txtPhone_M.TabIndex = 21;
            // 
            // txtPhone_H
            // 
            this.txtPhone_H.Location = new System.Drawing.Point(205, 354);
            this.txtPhone_H.Name = "txtPhone_H";
            this.txtPhone_H.Size = new System.Drawing.Size(176, 26);
            this.txtPhone_H.TabIndex = 22;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(205, 382);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(176, 26);
            this.txtEmail.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(332, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "Gender";
            // 
            // lblPatientRecordID
            // 
            this.lblPatientRecordID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPatientRecordID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPatientRecordID.Location = new System.Drawing.Point(205, 4);
            this.lblPatientRecordID.Name = "lblPatientRecordID";
            this.lblPatientRecordID.Size = new System.Drawing.Size(121, 22);
            this.lblPatientRecordID.TabIndex = 27;
            this.lblPatientRecordID.Text = "00000";
            this.lblPatientRecordID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmdTreatments
            // 
            this.cmdTreatments.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdTreatments.Location = new System.Drawing.Point(818, 423);
            this.cmdTreatments.Name = "cmdTreatments";
            this.cmdTreatments.Size = new System.Drawing.Size(138, 32);
            this.cmdTreatments.TabIndex = 28;
            this.cmdTreatments.Text = "Treatments";
            this.cmdTreatments.UseVisualStyleBackColor = true;
            this.cmdTreatments.Click += new System.EventHandler(this.cmdTreatments_Click);
            // 
            // cboTitle
            // 
            this.cboTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTitle.FormattingEnabled = true;
            this.cboTitle.Location = new System.Drawing.Point(205, 29);
            this.cboTitle.Name = "cboTitle";
            this.cboTitle.Size = new System.Drawing.Size(121, 28);
            this.cboTitle.TabIndex = 29;
            // 
            // cboGender
            // 
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Location = new System.Drawing.Point(392, 29);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(107, 28);
            this.cboGender.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 159);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(191, 20);
            this.label15.TabIndex = 31;
            this.label15.Text = "Date of Birth(yyyy-MM-dd)";
            // 
            // dtDate
            // 
            this.dtDate.CustomFormat = "yyyy-MM-dd";
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDate.Location = new System.Drawing.Point(374, 159);
            this.dtDate.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.dtDate.MinDate = new System.DateTime(1901, 1, 1, 0, 0, 0, 0);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(133, 26);
            this.dtDate.TabIndex = 32;
            this.dtDate.Visible = false;
            this.dtDate.CloseUp += new System.EventHandler(this.dtDate_CloseUp);
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(205, 159);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(121, 26);
            this.txtDOB.TabIndex = 33;
            // 
            // cmdSetData
            // 
            this.cmdSetData.Location = new System.Drawing.Point(332, 155);
            this.cmdSetData.Name = "cmdSetData";
            this.cmdSetData.Size = new System.Drawing.Size(36, 34);
            this.cmdSetData.TabIndex = 34;
            this.cmdSetData.Text = "...";
            this.cmdSetData.UseVisualStyleBackColor = true;
            this.cmdSetData.Click += new System.EventHandler(this.cmdSetData_Click);
            // 
            // tbPatientDetails
            // 
            this.tbPatientDetails.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tbPatientDetails.Controls.Add(this.tabPage1);
            this.tbPatientDetails.Controls.Add(this.tabPage2);
            this.tbPatientDetails.Location = new System.Drawing.Point(12, 12);
            this.tbPatientDetails.Name = "tbPatientDetails";
            this.tbPatientDetails.SelectedIndex = 0;
            this.tbPatientDetails.Size = new System.Drawing.Size(800, 493);
            this.tbPatientDetails.TabIndex = 35;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cboGender);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.cmdSave);
            this.tabPage1.Controls.Add(this.dtDate);
            this.tabPage1.Controls.Add(this.txtPhone_H);
            this.tabPage1.Controls.Add(this.cmdSetData);
            this.tabPage1.Controls.Add(this.txtPhone_M);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.txtAddrPostcode);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtAddrTown);
            this.tabPage1.Controls.Add(this.txtDOB);
            this.tabPage1.Controls.Add(this.txtAddrLine2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtAddrLine1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.cboTitle);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.lblPatientRecordID);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.txtSurname);
            this.tabPage1.Controls.Add(this.txtFName);
            this.tabPage1.Controls.Add(this.txtOtherNames);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 457);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Patient record";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 457);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Patient History";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmPatientRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(960, 542);
            this.Controls.Add(this.tbPatientDetails);
            this.Controls.Add(this.cmdTreatments);
            this.Controls.Add(this.cmdClose);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmPatientRecord";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Record";
            this.Load += new System.EventHandler(this.frmPatientRecord_Load);
            this.tbPatientDetails.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtOtherNames;
        private System.Windows.Forms.TextBox txtAddrLine1;
        private System.Windows.Forms.TextBox txtAddrLine2;
        private System.Windows.Forms.TextBox txtAddrTown;
        private System.Windows.Forms.TextBox txtAddrPostcode;
        private System.Windows.Forms.TextBox txtPhone_M;
        private System.Windows.Forms.TextBox txtPhone_H;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblPatientRecordID;
        private System.Windows.Forms.Button cmdTreatments;
        private System.Windows.Forms.ComboBox cboTitle;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.Button cmdSetData;
        private System.Windows.Forms.TabControl tbPatientDetails;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}