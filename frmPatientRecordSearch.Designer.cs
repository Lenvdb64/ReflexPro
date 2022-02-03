using System;

namespace ReflexPro
{
    partial class frmPatientRecordSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatientRecordSearch));
            this.gbPatientAction = new System.Windows.Forms.GroupBox();
            this.cmdAction = new System.Windows.Forms.Button();
            this.rdPRAction3 = new System.Windows.Forms.RadioButton();
            this.txtSearchText = new System.Windows.Forms.TextBox();
            this.rdPRAction2 = new System.Windows.Forms.RadioButton();
            this.rdPRAction1 = new System.Windows.Forms.RadioButton();
            this.dgPatientList = new System.Windows.Forms.DataGridView();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.gbPatientAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPatientList)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPatientAction
            // 
            this.gbPatientAction.Controls.Add(this.cboGender);
            this.gbPatientAction.Controls.Add(this.cmdAction);
            this.gbPatientAction.Controls.Add(this.rdPRAction3);
            this.gbPatientAction.Controls.Add(this.txtSearchText);
            this.gbPatientAction.Controls.Add(this.rdPRAction2);
            this.gbPatientAction.Controls.Add(this.rdPRAction1);
            this.gbPatientAction.Location = new System.Drawing.Point(28, 19);
            this.gbPatientAction.Name = "gbPatientAction";
            this.gbPatientAction.Size = new System.Drawing.Size(645, 184);
            this.gbPatientAction.TabIndex = 0;
            this.gbPatientAction.TabStop = false;
            this.gbPatientAction.Text = "What would you like to do?";
            // 
            // cmdAction
            // 
            this.cmdAction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdAction.Location = new System.Drawing.Point(534, 139);
            this.cmdAction.Name = "cmdAction";
            this.cmdAction.Size = new System.Drawing.Size(96, 33);
            this.cmdAction.TabIndex = 8;
            this.cmdAction.Text = "OK";
            this.cmdAction.UseVisualStyleBackColor = true;
            this.cmdAction.Click += new System.EventHandler(this.cmdAction_Click);
            // 
            // rdPRAction3
            // 
            this.rdPRAction3.AutoSize = true;
            this.rdPRAction3.Location = new System.Drawing.Point(24, 85);
            this.rdPRAction3.Name = "rdPRAction3";
            this.rdPRAction3.Size = new System.Drawing.Size(335, 24);
            this.rdPRAction3.TabIndex = 6;
            this.rdPRAction3.TabStop = true;
            this.rdPRAction3.Text = "Lookup a current Patient Record by Gender";
            this.rdPRAction3.UseVisualStyleBackColor = true;
            // 
            // txtSearchText
            // 
            this.txtSearchText.Location = new System.Drawing.Point(376, 55);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(198, 26);
            this.txtSearchText.TabIndex = 5;
            this.txtSearchText.Text = "enter surname here...";
            // 
            // rdPRAction2
            // 
            this.rdPRAction2.AutoSize = true;
            this.rdPRAction2.Location = new System.Drawing.Point(24, 55);
            this.rdPRAction2.Name = "rdPRAction2";
            this.rdPRAction2.Size = new System.Drawing.Size(346, 24);
            this.rdPRAction2.TabIndex = 3;
            this.rdPRAction2.TabStop = true;
            this.rdPRAction2.Text = "Lookup a current Patient Record by Surname";
            this.rdPRAction2.UseVisualStyleBackColor = true;
            
            // 
            // rdPRAction1
            // 
            this.rdPRAction1.AutoSize = true;
            this.rdPRAction1.Checked = true;
            this.rdPRAction1.Location = new System.Drawing.Point(24, 25);
            this.rdPRAction1.Name = "rdPRAction1";
            this.rdPRAction1.Size = new System.Drawing.Size(231, 24);
            this.rdPRAction1.TabIndex = 2;
            this.rdPRAction1.TabStop = true;
            this.rdPRAction1.Text = "Create a new Patient Record";
            this.rdPRAction1.UseVisualStyleBackColor = true;
            // 
            // dgPatientList
            // 
            this.dgPatientList.AllowUserToAddRows = false;
            this.dgPatientList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPatientList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgPatientList.ColumnHeadersHeight = 28;
            this.dgPatientList.Location = new System.Drawing.Point(28, 223);
            this.dgPatientList.MultiSelect = false;
            this.dgPatientList.Name = "dgPatientList";
            this.dgPatientList.ReadOnly = true;
            this.dgPatientList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPatientList.Size = new System.Drawing.Size(951, 157);
            this.dgPatientList.TabIndex = 3;
         
            this.dgPatientList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPatientList_CellDoubleClick);
            // 
            // cmdClose
            // 
            this.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdClose.Location = new System.Drawing.Point(875, 386);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(104, 32);
            this.cmdClose.TabIndex = 4;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cboGender
            // 
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Location = new System.Drawing.Point(376, 87);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(107, 28);
            this.cboGender.TabIndex = 31;
            // 
            // frmPatientRecordSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(991, 427);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.dgPatientList);
            this.Controls.Add(this.gbPatientAction);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPatientRecordSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Engine for Patient Records";
       
            this.gbPatientAction.ResumeLayout(false);
            this.gbPatientAction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPatientList)).EndInit();
            this.ResumeLayout(false);

        }

     

        #endregion

        private System.Windows.Forms.GroupBox gbPatientAction;
        private System.Windows.Forms.RadioButton rdPRAction1;
        private System.Windows.Forms.RadioButton rdPRAction2;
        private System.Windows.Forms.TextBox txtSearchText;
        private System.Windows.Forms.RadioButton rdPRAction3;
        private System.Windows.Forms.DataGridView dgPatientList;
        private System.Windows.Forms.Button cmdAction;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.ComboBox cboGender;
     
    }
}