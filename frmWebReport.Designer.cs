namespace ReflexPro
{
    partial class frmWebReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWebReport));
            this.wbViewer = new System.Windows.Forms.WebBrowser();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdSavePDF = new System.Windows.Forms.Button();
            this.dgSave = new System.Windows.Forms.SaveFileDialog();
            this.txtHTMLCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // wbViewer
            // 
            this.wbViewer.Location = new System.Drawing.Point(12, 12);
            this.wbViewer.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbViewer.Name = "wbViewer";
            this.wbViewer.Size = new System.Drawing.Size(796, 373);
            this.wbViewer.TabIndex = 0;
            // 
            // cmdClose
            // 
            this.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdClose.Location = new System.Drawing.Point(717, 558);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(91, 32);
            this.cmdClose.TabIndex = 9;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdSavePDF
            // 
            this.cmdSavePDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdSavePDF.Location = new System.Drawing.Point(620, 558);
            this.cmdSavePDF.Name = "cmdSavePDF";
            this.cmdSavePDF.Size = new System.Drawing.Size(91, 32);
            this.cmdSavePDF.TabIndex = 10;
            this.cmdSavePDF.Text = "Save2PDF";
            this.cmdSavePDF.UseVisualStyleBackColor = true;
            this.cmdSavePDF.Click += new System.EventHandler(this.cmdSavePDF_Click);
            // 
            // dgSave
            // 
            this.dgSave.InitialDirectory = "C:\\\\Users\\\\Len\\\\Documents";
            // 
            // txtHTMLCode
            // 
            this.txtHTMLCode.Location = new System.Drawing.Point(16, 408);
            this.txtHTMLCode.Multiline = true;
            this.txtHTMLCode.Name = "txtHTMLCode";
            this.txtHTMLCode.Size = new System.Drawing.Size(791, 106);
            this.txtHTMLCode.TabIndex = 11;
            // 
            // frmWebReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(820, 594);
            this.Controls.Add(this.txtHTMLCode);
            this.Controls.Add(this.cmdSavePDF);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.wbViewer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmWebReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Web Report";
            this.Load += new System.EventHandler(this.frmWebReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbViewer;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdSavePDF;
        private System.Windows.Forms.SaveFileDialog dgSave;
        private System.Windows.Forms.TextBox txtHTMLCode;
    }
}