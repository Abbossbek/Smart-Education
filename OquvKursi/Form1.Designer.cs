namespace OquvKursi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuNew = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewSubject = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewAbiturient = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewTeacher = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.hisobotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmnuNewAbiturient = new System.Windows.Forms.ToolStripButton();
            this.tsmnuTeacher = new System.Windows.Forms.ToolStripButton();
            this.tsmnuCourse = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmnuNewSubject = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmnuSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvAbiturient = new System.Windows.Forms.DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSurName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPasportNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmReyting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvTeacher = new System.Windows.Forms.DataGridView();
            this.clmIdT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLastNameT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNameT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSurNameT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPasportNumberT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAddressT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPhoneNumberT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalaryT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvSubject = new System.Windows.Forms.DataGridView();
            this.clmIdS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNameS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvCourse = new System.Windows.Forms.DataGridView();
            this.clmIdC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCourseNameC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTeacherC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSubjectC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.menuNew.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbiturient)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).BeginInit();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuNew
            // 
            this.menuNew.Dock = System.Windows.Forms.DockStyle.None;
            this.menuNew.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.hisobotToolStripMenuItem});
            this.menuNew.Location = new System.Drawing.Point(0, 0);
            this.menuNew.Name = "menuNew";
            this.menuNew.Size = new System.Drawing.Size(624, 28);
            this.menuNew.TabIndex = 0;
            this.menuNew.Text = "&New";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewSubject,
            this.mnuNewAbiturient,
            this.mnuNewTeacher,
            this.mnuNewCourse,
            this.mnuSave});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(45, 24);
            this.mnuFile.Text = "File";
            // 
            // mnuNewSubject
            // 
            this.mnuNewSubject.Name = "mnuNewSubject";
            this.mnuNewSubject.Size = new System.Drawing.Size(201, 24);
            this.mnuNewSubject.Text = "Yangi fan qoshish";
            this.mnuNewSubject.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuNewAbiturient
            // 
            this.mnuNewAbiturient.Name = "mnuNewAbiturient";
            this.mnuNewAbiturient.Size = new System.Drawing.Size(201, 24);
            this.mnuNewAbiturient.Text = "Yangi abiturient";
            this.mnuNewAbiturient.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuNewTeacher
            // 
            this.mnuNewTeacher.Name = "mnuNewTeacher";
            this.mnuNewTeacher.Size = new System.Drawing.Size(201, 24);
            this.mnuNewTeacher.Text = "Yangi o\'qituvchi";
            this.mnuNewTeacher.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuNewCourse
            // 
            this.mnuNewCourse.Name = "mnuNewCourse";
            this.mnuNewCourse.Size = new System.Drawing.Size(201, 24);
            this.mnuNewCourse.Text = "Yangi kurs";
            this.mnuNewCourse.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(201, 24);
            this.mnuSave.Text = "Saqlash";
            this.mnuSave.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // hisobotToolStripMenuItem
            // 
            this.hisobotToolStripMenuItem.Name = "hisobotToolStripMenuItem";
            this.hisobotToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.hisobotToolStripMenuItem.Text = "Hisobot";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator4,
            this.tsmnuNewAbiturient,
            this.tsmnuTeacher,
            this.tsmnuCourse,
            this.toolStripSeparator2,
            this.tsmnuNewSubject,
            this.toolStripSeparator3,
            this.tsmnuSave,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(151, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsmnuNewAbiturient
            // 
            this.tsmnuNewAbiturient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmnuNewAbiturient.Image = global::SmartEducation.Properties.Resources._446424490_441880;
            this.tsmnuNewAbiturient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmnuNewAbiturient.Name = "tsmnuNewAbiturient";
            this.tsmnuNewAbiturient.Size = new System.Drawing.Size(23, 22);
            this.tsmnuNewAbiturient.Text = "toolStripButton1";
            this.tsmnuNewAbiturient.ToolTipText = "Yangi abiturient qo`shish";
            this.tsmnuNewAbiturient.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // tsmnuTeacher
            // 
            this.tsmnuTeacher.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmnuTeacher.Image = global::SmartEducation.Properties.Resources._439634291_286145;
            this.tsmnuTeacher.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmnuTeacher.Name = "tsmnuTeacher";
            this.tsmnuTeacher.Size = new System.Drawing.Size(23, 22);
            this.tsmnuTeacher.Text = "toolStripButton3";
            this.tsmnuTeacher.ToolTipText = "Yangi o\'qituvchi qo\'shish\r\n";
            this.tsmnuTeacher.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // tsmnuCourse
            // 
            this.tsmnuCourse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmnuCourse.Image = global::SmartEducation.Properties.Resources._446738735_280931;
            this.tsmnuCourse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmnuCourse.Name = "tsmnuCourse";
            this.tsmnuCourse.Size = new System.Drawing.Size(23, 22);
            this.tsmnuCourse.Text = "toolStripButton1";
            this.tsmnuCourse.ToolTipText = "Yangi kurs qo\'shish";
            this.tsmnuCourse.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsmnuNewSubject
            // 
            this.tsmnuNewSubject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmnuNewSubject.Image = global::SmartEducation.Properties.Resources._446731977_126792;
            this.tsmnuNewSubject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmnuNewSubject.Name = "tsmnuNewSubject";
            this.tsmnuNewSubject.Size = new System.Drawing.Size(23, 22);
            this.tsmnuNewSubject.Text = "toolStripButton2";
            this.tsmnuNewSubject.ToolTipText = "Yangi fan qo`shish";
            this.tsmnuNewSubject.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsmnuSave
            // 
            this.tsmnuSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmnuSave.Image = ((System.Drawing.Image)(resources.GetObject("tsmnuSave.Image")));
            this.tsmnuSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmnuSave.Name = "tsmnuSave";
            this.tsmnuSave.Size = new System.Drawing.Size(23, 22);
            this.tsmnuSave.Text = "toolStripButton1";
            this.tsmnuSave.ToolTipText = "Ma`lumotlarni saqlash";
            this.tsmnuSave.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(599, 351);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvAbiturient);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(591, 325);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Abiturientlar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvAbiturient
            // 
            this.dgvAbiturient.AllowUserToAddRows = false;
            this.dgvAbiturient.AllowUserToDeleteRows = false;
            this.dgvAbiturient.AllowUserToResizeColumns = false;
            this.dgvAbiturient.AllowUserToResizeRows = false;
            this.dgvAbiturient.BackgroundColor = System.Drawing.Color.White;
            this.dgvAbiturient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbiturient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clmLastName,
            this.clmName,
            this.clmSurName,
            this.clmPasportNumber,
            this.clmAddress,
            this.clmPhoneNumber,
            this.clmReyting});
            this.dgvAbiturient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAbiturient.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvAbiturient.Location = new System.Drawing.Point(3, 3);
            this.dgvAbiturient.Name = "dgvAbiturient";
            this.dgvAbiturient.Size = new System.Drawing.Size(585, 319);
            this.dgvAbiturient.TabIndex = 0;
            this.dgvAbiturient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAbiturient_CellContentClick);
            this.dgvAbiturient.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAbiturient_CellMouseDoubleClick);
            // 
            // clmId
            // 
            this.clmId.HeaderText = "Id";
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
            this.clmId.Visible = false;
            // 
            // clmLastName
            // 
            this.clmLastName.HeaderText = "Familiyasi";
            this.clmLastName.Name = "clmLastName";
            this.clmLastName.ReadOnly = true;
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Ismi";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            // 
            // clmSurName
            // 
            this.clmSurName.HeaderText = "Sharifi";
            this.clmSurName.Name = "clmSurName";
            this.clmSurName.ReadOnly = true;
            // 
            // clmPasportNumber
            // 
            this.clmPasportNumber.HeaderText = "Pasport nomeri";
            this.clmPasportNumber.Name = "clmPasportNumber";
            this.clmPasportNumber.ReadOnly = true;
            this.clmPasportNumber.Width = 80;
            // 
            // clmAddress
            // 
            this.clmAddress.HeaderText = "Manzili";
            this.clmAddress.Name = "clmAddress";
            this.clmAddress.ReadOnly = true;
            // 
            // clmPhoneNumber
            // 
            this.clmPhoneNumber.HeaderText = "Telefon raqami";
            this.clmPhoneNumber.Name = "clmPhoneNumber";
            this.clmPhoneNumber.ReadOnly = true;
            this.clmPhoneNumber.Width = 80;
            // 
            // clmReyting
            // 
            this.clmReyting.HeaderText = "Reyting";
            this.clmReyting.Name = "clmReyting";
            this.clmReyting.Visible = false;
            this.clmReyting.Width = 50;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvTeacher);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(616, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "O`qituvchilar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvTeacher
            // 
            this.dgvTeacher.AllowUserToAddRows = false;
            this.dgvTeacher.AllowUserToDeleteRows = false;
            this.dgvTeacher.AllowUserToResizeColumns = false;
            this.dgvTeacher.AllowUserToResizeRows = false;
            this.dgvTeacher.BackgroundColor = System.Drawing.Color.White;
            this.dgvTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdT,
            this.clmLastNameT,
            this.clmNameT,
            this.clmSurNameT,
            this.clmPasportNumberT,
            this.clmAddressT,
            this.clmPhoneNumberT,
            this.clmSalaryT});
            this.dgvTeacher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTeacher.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvTeacher.Location = new System.Drawing.Point(3, 3);
            this.dgvTeacher.Name = "dgvTeacher";
            this.dgvTeacher.Size = new System.Drawing.Size(610, 329);
            this.dgvTeacher.TabIndex = 1;
            // 
            // clmIdT
            // 
            this.clmIdT.HeaderText = "Id";
            this.clmIdT.Name = "clmIdT";
            this.clmIdT.ReadOnly = true;
            this.clmIdT.Visible = false;
            // 
            // clmLastNameT
            // 
            this.clmLastNameT.HeaderText = "Familiyasi";
            this.clmLastNameT.Name = "clmLastNameT";
            this.clmLastNameT.ReadOnly = true;
            // 
            // clmNameT
            // 
            this.clmNameT.HeaderText = "Ismi";
            this.clmNameT.Name = "clmNameT";
            this.clmNameT.ReadOnly = true;
            // 
            // clmSurNameT
            // 
            this.clmSurNameT.HeaderText = "Sharifi";
            this.clmSurNameT.Name = "clmSurNameT";
            this.clmSurNameT.ReadOnly = true;
            // 
            // clmPasportNumberT
            // 
            this.clmPasportNumberT.HeaderText = "Pasport nomeri";
            this.clmPasportNumberT.Name = "clmPasportNumberT";
            this.clmPasportNumberT.ReadOnly = true;
            this.clmPasportNumberT.Width = 80;
            // 
            // clmAddressT
            // 
            this.clmAddressT.HeaderText = "Manzili";
            this.clmAddressT.Name = "clmAddressT";
            this.clmAddressT.ReadOnly = true;
            // 
            // clmPhoneNumberT
            // 
            this.clmPhoneNumberT.HeaderText = "Telefon raqami";
            this.clmPhoneNumberT.Name = "clmPhoneNumberT";
            this.clmPhoneNumberT.ReadOnly = true;
            this.clmPhoneNumberT.Width = 80;
            // 
            // clmSalaryT
            // 
            this.clmSalaryT.HeaderText = "Oylik";
            this.clmSalaryT.Name = "clmSalaryT";
            this.clmSalaryT.Width = 50;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvSubject);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage3.Size = new System.Drawing.Size(616, 335);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Fanlar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvSubject
            // 
            this.dgvSubject.AllowUserToAddRows = false;
            this.dgvSubject.AllowUserToDeleteRows = false;
            this.dgvSubject.AllowUserToResizeColumns = false;
            this.dgvSubject.AllowUserToResizeRows = false;
            this.dgvSubject.BackgroundColor = System.Drawing.Color.White;
            this.dgvSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdS,
            this.clmNameS,
            this.clmPrice});
            this.dgvSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubject.Location = new System.Drawing.Point(3, 3);
            this.dgvSubject.Name = "dgvSubject";
            this.dgvSubject.Size = new System.Drawing.Size(610, 329);
            this.dgvSubject.TabIndex = 0;
            // 
            // clmIdS
            // 
            this.clmIdS.HeaderText = "Id";
            this.clmIdS.Name = "clmIdS";
            this.clmIdS.Visible = false;
            // 
            // clmNameS
            // 
            this.clmNameS.HeaderText = "Fan nomi";
            this.clmNameS.Name = "clmNameS";
            // 
            // clmPrice
            // 
            this.clmPrice.HeaderText = "Narxi";
            this.clmPrice.Name = "clmPrice";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvCourse);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage4.Size = new System.Drawing.Size(616, 335);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "O`quv kurslari";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvCourse
            // 
            this.dgvCourse.AllowUserToAddRows = false;
            this.dgvCourse.AllowUserToDeleteRows = false;
            this.dgvCourse.AllowUserToResizeColumns = false;
            this.dgvCourse.AllowUserToResizeRows = false;
            this.dgvCourse.BackgroundColor = System.Drawing.Color.White;
            this.dgvCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdC,
            this.clmCourseNameC,
            this.clmTeacherC,
            this.clmSubjectC});
            this.dgvCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCourse.Location = new System.Drawing.Point(3, 3);
            this.dgvCourse.Name = "dgvCourse";
            this.dgvCourse.Size = new System.Drawing.Size(610, 329);
            this.dgvCourse.TabIndex = 1;
            // 
            // clmIdC
            // 
            this.clmIdC.HeaderText = "Id";
            this.clmIdC.Name = "clmIdC";
            this.clmIdC.Visible = false;
            // 
            // clmCourseNameC
            // 
            this.clmCourseNameC.HeaderText = "Kurs nomi";
            this.clmCourseNameC.Name = "clmCourseNameC";
            // 
            // clmTeacherC
            // 
            this.clmTeacherC.HeaderText = "O`qituvchi";
            this.clmTeacherC.Name = "clmTeacherC";
            // 
            // clmSubjectC
            // 
            this.clmSubjectC.HeaderText = "Fan";
            this.clmSubjectC.Name = "clmSubjectC";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tabControl1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(599, 351);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            this.toolStripContainer1.LeftToolStripPanel.Click += new System.EventHandler(this.toolStripContainer1_LeftToolStripPanel_Click);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(624, 404);
            this.toolStripContainer1.TabIndex = 3;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuNew);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 404);
            this.Controls.Add(this.toolStripContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuNew;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMART EDUCATION";
            this.menuNew.ResumeLayout(false);
            this.menuNew.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbiturient)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).EndInit();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuNew;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuNewSubject;
        private System.Windows.Forms.ToolStripMenuItem mnuNewAbiturient;
        private System.Windows.Forms.ToolStripMenuItem mnuNewTeacher;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsmnuNewAbiturient;
        private System.Windows.Forms.ToolStripButton tsmnuNewSubject;
        private System.Windows.Forms.ToolStripButton tsmnuTeacher;
        private System.Windows.Forms.ToolStripMenuItem mnuNewCourse;
        private System.Windows.Forms.ToolStripMenuItem hisobotToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsmnuCourse;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvAbiturient;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvSubject;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSurName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPasportNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmReyting;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripButton tsmnuSave;
        private System.Windows.Forms.DataGridView dgvTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLastNameT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNameT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSurNameT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPasportNumberT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAddressT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPhoneNumberT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalaryT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdS;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNameS;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrice;
        private System.Windows.Forms.DataGridView dgvCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdC;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCourseNameC;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTeacherC;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSubjectC;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
    }
}

