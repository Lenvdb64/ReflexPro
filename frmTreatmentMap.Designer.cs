namespace ReflexPro
{
    partial class frmTreatmentMap
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTreatmentMap));
            this.lblTitle_2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTreatmentDate = new System.Windows.Forms.TextBox();
            this.cmdClose = new System.Windows.Forms.Button();
            this.tbTreatmentZones = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblTreating = new System.Windows.Forms.Label();
            this.cmdRS_Add = new System.Windows.Forms.Button();
            this.cmdClearNotes_RSole = new System.Windows.Forms.Button();
            this.cmdAdd_RSole = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbNotes_1 = new System.Windows.Forms.RichTextBox();
            this.gbxTreatmentArea = new System.Windows.Forms.GroupBox();
            this.rdSpongy = new System.Windows.Forms.RadioButton();
            this.rdCrunchy = new System.Windows.Forms.RadioButton();
            this.rdPuffy = new System.Windows.Forms.RadioButton();
            this.rdSwollen = new System.Windows.Forms.RadioButton();
            this.rdNormal = new System.Windows.Forms.RadioButton();
            this.pic_TreatmentZones1_RightSole = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmdSave_LSole = new System.Windows.Forms.Button();
            this.cmdClearNotes_LSole = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbNotes_2 = new System.Windows.Forms.RichTextBox();
            this.cmdLS_Add = new System.Windows.Forms.Button();
            this.lblTreating2 = new System.Windows.Forms.Label();
            this.gbxTreatmentArea2 = new System.Windows.Forms.GroupBox();
            this.rdSpongy_LS = new System.Windows.Forms.RadioButton();
            this.rdCrunchy_LS = new System.Windows.Forms.RadioButton();
            this.rdPuffy_LS = new System.Windows.Forms.RadioButton();
            this.rdSwollen_LS = new System.Windows.Forms.RadioButton();
            this.rdNormal_LS = new System.Windows.Forms.RadioButton();
            this.pic_TreatmentZones2_LeftSole = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tipTreatmentArea = new System.Windows.Forms.ToolTip(this.components);
            this.cmdDate = new System.Windows.Forms.Button();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.lblTreatmentID = new System.Windows.Forms.Label();
            this.dgData = new System.Windows.Forms.DataGridView();
            this.cmdEmail = new System.Windows.Forms.Button();
            this.cmdReport = new System.Windows.Forms.Button();
            this.tbTreatmentZones.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbxTreatmentArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_TreatmentZones1_RightSole)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.gbxTreatmentArea2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_TreatmentZones2_LeftSole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle_2
            // 
            this.lblTitle_2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblTitle_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitle_2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTitle_2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle_2.Location = new System.Drawing.Point(20, 14);
            this.lblTitle_2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitle_2.Name = "lblTitle_2";
            this.lblTitle_2.Size = new System.Drawing.Size(534, 26);
            this.lblTitle_2.TabIndex = 3;
            this.lblTitle_2.Text = "New Treatment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(664, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Treatment Date";
            // 
            // txtTreatmentDate
            // 
            this.txtTreatmentDate.Location = new System.Drawing.Point(791, 8);
            this.txtTreatmentDate.Name = "txtTreatmentDate";
            this.txtTreatmentDate.Size = new System.Drawing.Size(116, 26);
            this.txtTreatmentDate.TabIndex = 6;
            // 
            // cmdClose
            // 
            this.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdClose.Location = new System.Drawing.Point(1141, 612);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(91, 32);
            this.cmdClose.TabIndex = 8;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // tbTreatmentZones
            // 
            this.tbTreatmentZones.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tbTreatmentZones.Controls.Add(this.tabPage1);
            this.tbTreatmentZones.Controls.Add(this.tabPage2);
            this.tbTreatmentZones.Controls.Add(this.tabPage3);
            this.tbTreatmentZones.Controls.Add(this.tabPage4);
            this.tbTreatmentZones.Controls.Add(this.tabPage5);
            this.tbTreatmentZones.Controls.Add(this.tabPage6);
            this.tbTreatmentZones.Location = new System.Drawing.Point(25, 44);
            this.tbTreatmentZones.Name = "tbTreatmentZones";
            this.tbTreatmentZones.SelectedIndex = 0;
            this.tbTreatmentZones.Size = new System.Drawing.Size(529, 576);
            this.tbTreatmentZones.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblTreating);
            this.tabPage1.Controls.Add(this.cmdRS_Add);
            this.tabPage1.Controls.Add(this.cmdClearNotes_RSole);
            this.tabPage1.Controls.Add(this.cmdAdd_RSole);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.rtbNotes_1);
            this.tabPage1.Controls.Add(this.gbxTreatmentArea);
            this.tabPage1.Controls.Add(this.pic_TreatmentZones1_RightSole);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(521, 540);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Right Sole";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblTreating
            // 
            this.lblTreating.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTreating.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTreating.Location = new System.Drawing.Point(261, 179);
            this.lblTreating.Name = "lblTreating";
            this.lblTreating.Size = new System.Drawing.Size(196, 35);
            this.lblTreating.TabIndex = 15;
            this.lblTreating.Text = "Treating...";
            // 
            // cmdRS_Add
            // 
            this.cmdRS_Add.Location = new System.Drawing.Point(463, 179);
            this.cmdRS_Add.Name = "cmdRS_Add";
            this.cmdRS_Add.Size = new System.Drawing.Size(46, 29);
            this.cmdRS_Add.TabIndex = 14;
            this.cmdRS_Add.Text = ">>";
            this.cmdRS_Add.UseVisualStyleBackColor = true;
            this.cmdRS_Add.Click += new System.EventHandler(this.cmdRS_Add_Click);
            // 
            // cmdClearNotes_RSole
            // 
            this.cmdClearNotes_RSole.Location = new System.Drawing.Point(261, 492);
            this.cmdClearNotes_RSole.Name = "cmdClearNotes_RSole";
            this.cmdClearNotes_RSole.Size = new System.Drawing.Size(102, 30);
            this.cmdClearNotes_RSole.TabIndex = 13;
            this.cmdClearNotes_RSole.Text = "Clear Notes";
            this.cmdClearNotes_RSole.UseVisualStyleBackColor = true;
            this.cmdClearNotes_RSole.Click += new System.EventHandler(this.cmdClearNotes_RSole_Click);
            // 
            // cmdAdd_RSole
            // 
            this.cmdAdd_RSole.Location = new System.Drawing.Point(409, 492);
            this.cmdAdd_RSole.Name = "cmdAdd_RSole";
            this.cmdAdd_RSole.Size = new System.Drawing.Size(91, 31);
            this.cmdAdd_RSole.TabIndex = 12;
            this.cmdAdd_RSole.Text = "Save";
            this.cmdAdd_RSole.UseVisualStyleBackColor = true;
            this.cmdAdd_RSole.Click += new System.EventHandler(this.cmdAdd_RSole_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Additional Notes";
            // 
            // rtbNotes_1
            // 
            this.rtbNotes_1.Location = new System.Drawing.Point(261, 246);
            this.rtbNotes_1.Name = "rtbNotes_1";
            this.rtbNotes_1.Size = new System.Drawing.Size(242, 239);
            this.rtbNotes_1.TabIndex = 10;
            this.rtbNotes_1.Text = "";
            this.rtbNotes_1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // gbxTreatmentArea
            // 
            this.gbxTreatmentArea.Controls.Add(this.rdSpongy);
            this.gbxTreatmentArea.Controls.Add(this.rdCrunchy);
            this.gbxTreatmentArea.Controls.Add(this.rdPuffy);
            this.gbxTreatmentArea.Controls.Add(this.rdSwollen);
            this.gbxTreatmentArea.Controls.Add(this.rdNormal);
            this.gbxTreatmentArea.Location = new System.Drawing.Point(261, 6);
            this.gbxTreatmentArea.Name = "gbxTreatmentArea";
            this.gbxTreatmentArea.Size = new System.Drawing.Size(242, 170);
            this.gbxTreatmentArea.TabIndex = 9;
            this.gbxTreatmentArea.TabStop = false;
            this.gbxTreatmentArea.Text = "Describe the treatment Area:";
            // 
            // rdSpongy
            // 
            this.rdSpongy.AutoSize = true;
            this.rdSpongy.Location = new System.Drawing.Point(22, 145);
            this.rdSpongy.Name = "rdSpongy";
            this.rdSpongy.Size = new System.Drawing.Size(81, 24);
            this.rdSpongy.TabIndex = 4;
            this.rdSpongy.Text = "Spongy";
            this.rdSpongy.UseVisualStyleBackColor = true;
            // 
            // rdCrunchy
            // 
            this.rdCrunchy.AutoSize = true;
            this.rdCrunchy.Location = new System.Drawing.Point(22, 115);
            this.rdCrunchy.Name = "rdCrunchy";
            this.rdCrunchy.Size = new System.Drawing.Size(85, 24);
            this.rdCrunchy.TabIndex = 3;
            this.rdCrunchy.Text = "Crunchy";
            this.rdCrunchy.UseVisualStyleBackColor = true;
            // 
            // rdPuffy
            // 
            this.rdPuffy.AutoSize = true;
            this.rdPuffy.Location = new System.Drawing.Point(22, 85);
            this.rdPuffy.Name = "rdPuffy";
            this.rdPuffy.Size = new System.Drawing.Size(63, 24);
            this.rdPuffy.TabIndex = 2;
            this.rdPuffy.Text = "Puffy";
            this.rdPuffy.UseVisualStyleBackColor = true;
            // 
            // rdSwollen
            // 
            this.rdSwollen.AutoSize = true;
            this.rdSwollen.Location = new System.Drawing.Point(22, 55);
            this.rdSwollen.Name = "rdSwollen";
            this.rdSwollen.Size = new System.Drawing.Size(82, 24);
            this.rdSwollen.TabIndex = 1;
            this.rdSwollen.Text = "Swollen";
            this.rdSwollen.UseVisualStyleBackColor = true;
            // 
            // rdNormal
            // 
            this.rdNormal.AutoSize = true;
            this.rdNormal.Checked = true;
            this.rdNormal.Location = new System.Drawing.Point(22, 25);
            this.rdNormal.Name = "rdNormal";
            this.rdNormal.Size = new System.Drawing.Size(77, 24);
            this.rdNormal.TabIndex = 0;
            this.rdNormal.TabStop = true;
            this.rdNormal.Text = "Normal";
            this.rdNormal.UseVisualStyleBackColor = true;
            // 
            // pic_TreatmentZones1_RightSole
            // 
            this.pic_TreatmentZones1_RightSole.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pic_TreatmentZones1_RightSole.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_TreatmentZones1_RightSole.Image = global::ReflexPro.Properties.Resources.Footsole_Right;
            this.pic_TreatmentZones1_RightSole.InitialImage = global::ReflexPro.Properties.Resources.Footsole_Right;
            this.pic_TreatmentZones1_RightSole.Location = new System.Drawing.Point(6, 6);
            this.pic_TreatmentZones1_RightSole.Name = "pic_TreatmentZones1_RightSole";
            this.pic_TreatmentZones1_RightSole.Size = new System.Drawing.Size(240, 479);
            this.pic_TreatmentZones1_RightSole.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_TreatmentZones1_RightSole.TabIndex = 8;
            this.pic_TreatmentZones1_RightSole.TabStop = false;
            this.pic_TreatmentZones1_RightSole.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_TreatmentZones1_RightSole_Paint);
            this.pic_TreatmentZones1_RightSole.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_TreatmentZones1_RightSole_MouseClick);
            this.pic_TreatmentZones1_RightSole.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_TreatmentZones1_RightSole_MouseMove);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmdSave_LSole);
            this.tabPage2.Controls.Add(this.cmdClearNotes_LSole);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.rtbNotes_2);
            this.tabPage2.Controls.Add(this.cmdLS_Add);
            this.tabPage2.Controls.Add(this.lblTreating2);
            this.tabPage2.Controls.Add(this.gbxTreatmentArea2);
            this.tabPage2.Controls.Add(this.pic_TreatmentZones2_LeftSole);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(521, 540);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Left Sole";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmdSave_LSole
            // 
            this.cmdSave_LSole.Location = new System.Drawing.Point(413, 490);
            this.cmdSave_LSole.Name = "cmdSave_LSole";
            this.cmdSave_LSole.Size = new System.Drawing.Size(91, 31);
            this.cmdSave_LSole.TabIndex = 21;
            this.cmdSave_LSole.Text = "Save";
            this.cmdSave_LSole.UseVisualStyleBackColor = true;
            this.cmdSave_LSole.Click += new System.EventHandler(this.cmdSave_LSole_Click);
            // 
            // cmdClearNotes_LSole
            // 
            this.cmdClearNotes_LSole.Location = new System.Drawing.Point(259, 491);
            this.cmdClearNotes_LSole.Name = "cmdClearNotes_LSole";
            this.cmdClearNotes_LSole.Size = new System.Drawing.Size(102, 30);
            this.cmdClearNotes_LSole.TabIndex = 20;
            this.cmdClearNotes_LSole.Text = "Clear Notes";
            this.cmdClearNotes_LSole.UseVisualStyleBackColor = true;
            this.cmdClearNotes_LSole.Click += new System.EventHandler(this.cmdClearNotes_LSole_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Additional Notes";
            // 
            // rtbNotes_2
            // 
            this.rtbNotes_2.Location = new System.Drawing.Point(262, 246);
            this.rtbNotes_2.Name = "rtbNotes_2";
            this.rtbNotes_2.Size = new System.Drawing.Size(242, 239);
            this.rtbNotes_2.TabIndex = 18;
            this.rtbNotes_2.Text = "";
            // 
            // cmdLS_Add
            // 
            this.cmdLS_Add.Location = new System.Drawing.Point(458, 178);
            this.cmdLS_Add.Name = "cmdLS_Add";
            this.cmdLS_Add.Size = new System.Drawing.Size(46, 29);
            this.cmdLS_Add.TabIndex = 17;
            this.cmdLS_Add.Text = ">>";
            this.cmdLS_Add.UseVisualStyleBackColor = true;
            this.cmdLS_Add.Click += new System.EventHandler(this.cmdLS_Add_Click);
            // 
            // lblTreating2
            // 
            this.lblTreating2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTreating2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTreating2.Location = new System.Drawing.Point(262, 178);
            this.lblTreating2.Name = "lblTreating2";
            this.lblTreating2.Size = new System.Drawing.Size(196, 35);
            this.lblTreating2.TabIndex = 16;
            this.lblTreating2.Text = "Treating...";
            // 
            // gbxTreatmentArea2
            // 
            this.gbxTreatmentArea2.Controls.Add(this.rdSpongy_LS);
            this.gbxTreatmentArea2.Controls.Add(this.rdCrunchy_LS);
            this.gbxTreatmentArea2.Controls.Add(this.rdPuffy_LS);
            this.gbxTreatmentArea2.Controls.Add(this.rdSwollen_LS);
            this.gbxTreatmentArea2.Controls.Add(this.rdNormal_LS);
            this.gbxTreatmentArea2.Location = new System.Drawing.Point(262, 6);
            this.gbxTreatmentArea2.Name = "gbxTreatmentArea2";
            this.gbxTreatmentArea2.Size = new System.Drawing.Size(242, 170);
            this.gbxTreatmentArea2.TabIndex = 10;
            this.gbxTreatmentArea2.TabStop = false;
            this.gbxTreatmentArea2.Text = "Describe the treatment Area:";
            // 
            // rdSpongy_LS
            // 
            this.rdSpongy_LS.AutoSize = true;
            this.rdSpongy_LS.Location = new System.Drawing.Point(22, 145);
            this.rdSpongy_LS.Name = "rdSpongy_LS";
            this.rdSpongy_LS.Size = new System.Drawing.Size(81, 24);
            this.rdSpongy_LS.TabIndex = 4;
            this.rdSpongy_LS.Text = "Spongy";
            this.rdSpongy_LS.UseVisualStyleBackColor = true;
            // 
            // rdCrunchy_LS
            // 
            this.rdCrunchy_LS.AutoSize = true;
            this.rdCrunchy_LS.Location = new System.Drawing.Point(22, 115);
            this.rdCrunchy_LS.Name = "rdCrunchy_LS";
            this.rdCrunchy_LS.Size = new System.Drawing.Size(85, 24);
            this.rdCrunchy_LS.TabIndex = 3;
            this.rdCrunchy_LS.Text = "Crunchy";
            this.rdCrunchy_LS.UseVisualStyleBackColor = true;
            // 
            // rdPuffy_LS
            // 
            this.rdPuffy_LS.AutoSize = true;
            this.rdPuffy_LS.Location = new System.Drawing.Point(22, 85);
            this.rdPuffy_LS.Name = "rdPuffy_LS";
            this.rdPuffy_LS.Size = new System.Drawing.Size(63, 24);
            this.rdPuffy_LS.TabIndex = 2;
            this.rdPuffy_LS.Text = "Puffy";
            this.rdPuffy_LS.UseVisualStyleBackColor = true;
            // 
            // rdSwollen_LS
            // 
            this.rdSwollen_LS.AutoSize = true;
            this.rdSwollen_LS.Location = new System.Drawing.Point(22, 55);
            this.rdSwollen_LS.Name = "rdSwollen_LS";
            this.rdSwollen_LS.Size = new System.Drawing.Size(82, 24);
            this.rdSwollen_LS.TabIndex = 1;
            this.rdSwollen_LS.Text = "Swollen";
            this.rdSwollen_LS.UseVisualStyleBackColor = true;
            // 
            // rdNormal_LS
            // 
            this.rdNormal_LS.AutoSize = true;
            this.rdNormal_LS.Checked = true;
            this.rdNormal_LS.Location = new System.Drawing.Point(22, 25);
            this.rdNormal_LS.Name = "rdNormal_LS";
            this.rdNormal_LS.Size = new System.Drawing.Size(77, 24);
            this.rdNormal_LS.TabIndex = 0;
            this.rdNormal_LS.TabStop = true;
            this.rdNormal_LS.Text = "Normal";
            this.rdNormal_LS.UseVisualStyleBackColor = true;
            // 
            // pic_TreatmentZones2_LeftSole
            // 
            this.pic_TreatmentZones2_LeftSole.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pic_TreatmentZones2_LeftSole.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_TreatmentZones2_LeftSole.Image = global::ReflexPro.Properties.Resources.Footsole_Left;
            this.pic_TreatmentZones2_LeftSole.InitialImage = global::ReflexPro.Properties.Resources.Footsole_Left;
            this.pic_TreatmentZones2_LeftSole.Location = new System.Drawing.Point(6, 6);
            this.pic_TreatmentZones2_LeftSole.Name = "pic_TreatmentZones2_LeftSole";
            this.pic_TreatmentZones2_LeftSole.Size = new System.Drawing.Size(240, 479);
            this.pic_TreatmentZones2_LeftSole.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_TreatmentZones2_LeftSole.TabIndex = 9;
            this.pic_TreatmentZones2_LeftSole.TabStop = false;
            this.pic_TreatmentZones2_LeftSole.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_TreatmentZones2_LeftSole_Paint);
            this.pic_TreatmentZones2_LeftSole.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_TreatmentZones2_LeftSole_MouseClick);
            this.pic_TreatmentZones2_LeftSole.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_TreatmentZones2_LeftSole_MouseMove);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(521, 540);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Dorsal R";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 32);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(521, 540);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Dorsal L";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 32);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(521, 540);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Medial R";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 32);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(521, 540);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Medial L";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // cmdDate
            // 
            this.cmdDate.Location = new System.Drawing.Point(913, 8);
            this.cmdDate.Name = "cmdDate";
            this.cmdDate.Size = new System.Drawing.Size(35, 27);
            this.cmdDate.TabIndex = 11;
            this.cmdDate.Text = "...";
            this.cmdDate.UseVisualStyleBackColor = true;
            this.cmdDate.Click += new System.EventHandler(this.cmdDate_Click);
            // 
            // dtDate
            // 
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDate.Location = new System.Drawing.Point(954, 9);
            this.dtDate.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.dtDate.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(132, 26);
            this.dtDate.TabIndex = 12;
            // 
            // lblTreatmentID
            // 
            this.lblTreatmentID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTreatmentID.Location = new System.Drawing.Point(567, 12);
            this.lblTreatmentID.Name = "lblTreatmentID";
            this.lblTreatmentID.Size = new System.Drawing.Size(88, 27);
            this.lblTreatmentID.TabIndex = 13;
            this.lblTreatmentID.Text = "0";
            // 
            // dgData
            // 
            this.dgData.AllowUserToAddRows = false;
            this.dgData.AllowUserToDeleteRows = false;
            this.dgData.AllowUserToOrderColumns = true;
            this.dgData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgData.Location = new System.Drawing.Point(560, 44);
            this.dgData.MultiSelect = false;
            this.dgData.Name = "dgData";
            this.dgData.ReadOnly = true;
            this.dgData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgData.Size = new System.Drawing.Size(672, 524);
            this.dgData.TabIndex = 14;
            // 
            // cmdEmail
            // 
            this.cmdEmail.Location = new System.Drawing.Point(566, 579);
            this.cmdEmail.Name = "cmdEmail";
            this.cmdEmail.Size = new System.Drawing.Size(123, 33);
            this.cmdEmail.TabIndex = 15;
            this.cmdEmail.Text = "Send Email";
            this.cmdEmail.UseVisualStyleBackColor = true;
            this.cmdEmail.Click += new System.EventHandler(this.cmdEmail_Click);
            // 
            // cmdReport
            // 
            this.cmdReport.Location = new System.Drawing.Point(695, 579);
            this.cmdReport.Name = "cmdReport";
            this.cmdReport.Size = new System.Drawing.Size(123, 33);
            this.cmdReport.TabIndex = 16;
            this.cmdReport.Text = "Report";
            this.cmdReport.UseVisualStyleBackColor = true;
            this.cmdReport.Click += new System.EventHandler(this.cmdReport_Click);
            // 
            // frmTreatmentMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1256, 656);
            this.Controls.Add(this.cmdReport);
            this.Controls.Add(this.cmdEmail);
            this.Controls.Add(this.dgData);
            this.Controls.Add(this.lblTreatmentID);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.cmdDate);
            this.Controls.Add(this.tbTreatmentZones);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.txtTreatmentDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTitle_2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTreatmentMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Treatment Map - Select Zones";
            this.tbTreatmentZones.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gbxTreatmentArea.ResumeLayout(false);
            this.gbxTreatmentArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_TreatmentZones1_RightSole)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.gbxTreatmentArea2.ResumeLayout(false);
            this.gbxTreatmentArea2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_TreatmentZones2_LeftSole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle_2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTreatmentDate;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.TabControl tbTreatmentZones;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pic_TreatmentZones1_RightSole;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.ToolTip tipTreatmentArea;
        private System.Windows.Forms.GroupBox gbxTreatmentArea;
        private System.Windows.Forms.RadioButton rdCrunchy;
        private System.Windows.Forms.RadioButton rdPuffy;
        private System.Windows.Forms.RadioButton rdSwollen;
        private System.Windows.Forms.RadioButton rdNormal;
        private System.Windows.Forms.Button cmdAdd_RSole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbNotes_1;
        private System.Windows.Forms.Button cmdClearNotes_RSole;
        private System.Windows.Forms.Button cmdDate;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label lblTreatmentID;
        private System.Windows.Forms.Button cmdRS_Add;
        private System.Windows.Forms.DataGridView dgData;
        private System.Windows.Forms.RadioButton rdSpongy;
        private System.Windows.Forms.Label lblTreating;
        private System.Windows.Forms.GroupBox gbxTreatmentArea2;
        private System.Windows.Forms.RadioButton rdSpongy_LS;
        private System.Windows.Forms.RadioButton rdCrunchy_LS;
        private System.Windows.Forms.RadioButton rdPuffy_LS;
        private System.Windows.Forms.RadioButton rdSwollen_LS;
        private System.Windows.Forms.RadioButton rdNormal_LS;
        private System.Windows.Forms.PictureBox pic_TreatmentZones2_LeftSole;
        private System.Windows.Forms.Label lblTreating2;
        private System.Windows.Forms.Button cmdLS_Add;
        private System.Windows.Forms.RichTextBox rtbNotes_2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdEmail;
        private System.Windows.Forms.Button cmdSave_LSole;
        private System.Windows.Forms.Button cmdClearNotes_LSole;
        private System.Windows.Forms.Button cmdReport;
    }
}