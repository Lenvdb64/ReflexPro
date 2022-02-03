namespace ReflexPro
{
    partial class frmReporting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporting));
            this.cmdClose = new System.Windows.Forms.Button();
            this.crCustomers_Monthly1 = new ReflexPro.ReportDefs.crCustomers_Monthly();
            this.crxViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(833, 566);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(111, 36);
            this.cmdClose.TabIndex = 1;
            this.cmdClose.Text = "&Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // crCustomers_Monthly1
            // 
            
            // 
            // crxViewer
            // 
            this.crxViewer.ActiveViewIndex = 0;
            this.crxViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crxViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crxViewer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crxViewer.Location = new System.Drawing.Point(2, 2);
            this.crxViewer.Name = "crxViewer";
            this.crxViewer.ReportSource = this.crCustomers_Monthly1;
            this.crxViewer.Size = new System.Drawing.Size(942, 558);
            this.crxViewer.TabIndex = 2;
           
            // 
            // frmReporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(956, 614);
            this.Controls.Add(this.crxViewer);
            this.Controls.Add(this.cmdClose);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReporting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View the Report";
            this.Load += new System.EventHandler(this.frmReporting_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmdClose;
        private ReportDefs.crCustomers_Monthly crCustomers_Monthly1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crxViewer;
      
    }
}