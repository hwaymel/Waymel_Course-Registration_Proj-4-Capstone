namespace Class_Selection_Capstone
{
    partial class frmCourseSelector
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
            System.Windows.Forms.Label courseNumLabel;
            this.lblNumCourses = new System.Windows.Forms.Label();
            this.txtNumCourses = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.calClassStart = new System.Windows.Forms.MonthCalendar();
            this.lblCourseType = new System.Windows.Forms.Label();
            this.rdoHybrid = new System.Windows.Forms.RadioButton();
            this.rdoOnline = new System.Windows.Forms.RadioButton();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.cUDenverDataSet = new Class_Selection_Capstone.CUDenverDataSet();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesTableAdapter = new Class_Selection_Capstone.CUDenverDataSetTableAdapters.CoursesTableAdapter();
            this.tableAdapterManager = new Class_Selection_Capstone.CUDenverDataSetTableAdapters.TableAdapterManager();
            this.coursesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbCourseNum = new System.Windows.Forms.ComboBox();
            this.txtRetNumCourses = new System.Windows.Forms.TextBox();
            this.lblRetNumCourses = new System.Windows.Forms.Label();
            this.lblRetStudentName = new System.Windows.Forms.Label();
            this.txtRetStudentName = new System.Windows.Forms.TextBox();
            this.lblRetStartDate = new System.Windows.Forms.Label();
            this.txtRetStartDate = new System.Windows.Forms.TextBox();
            this.lblRetCourseNum = new System.Windows.Forms.Label();
            this.txtRetCourseNum = new System.Windows.Forms.TextBox();
            this.lblRetCourseType = new System.Windows.Forms.Label();
            this.txtRetCourseType = new System.Windows.Forms.TextBox();
            this.lblRetValues = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            courseNumLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cUDenverDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // courseNumLabel
            // 
            courseNumLabel.AutoSize = true;
            courseNumLabel.Location = new System.Drawing.Point(39, 294);
            courseNumLabel.Name = "courseNumLabel";
            courseNumLabel.Size = new System.Drawing.Size(116, 13);
            courseNumLabel.TabIndex = 6;
            courseNumLabel.Text = "Select Course Number:";
            // 
            // lblNumCourses
            // 
            this.lblNumCourses.AutoSize = true;
            this.lblNumCourses.Location = new System.Drawing.Point(39, 31);
            this.lblNumCourses.Name = "lblNumCourses";
            this.lblNumCourses.Size = new System.Drawing.Size(100, 13);
            this.lblNumCourses.TabIndex = 0;
            this.lblNumCourses.Text = "Number of Courses:";
            // 
            // txtNumCourses
            // 
            this.txtNumCourses.Location = new System.Drawing.Point(200, 31);
            this.txtNumCourses.Name = "txtNumCourses";
            this.txtNumCourses.Size = new System.Drawing.Size(57, 20);
            this.txtNumCourses.TabIndex = 1;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(39, 58);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(129, 13);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Student Name (First Last):";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(200, 58);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(158, 20);
            this.txtStudentName.TabIndex = 3;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(39, 83);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(94, 13);
            this.lblStartDate.TabIndex = 4;
            this.lblStartDate.Text = "Course Start Date:";
            // 
            // calClassStart
            // 
            this.calClassStart.Location = new System.Drawing.Point(88, 115);
            this.calClassStart.MaxDate = new System.DateTime(2019, 1, 31, 0, 0, 0, 0);
            this.calClassStart.MaxSelectionCount = 1;
            this.calClassStart.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.calClassStart.Name = "calClassStart";
            this.calClassStart.ShowToday = false;
            this.calClassStart.ShowTodayCircle = false;
            this.calClassStart.TabIndex = 5;
            // 
            // lblCourseType
            // 
            this.lblCourseType.AutoSize = true;
            this.lblCourseType.Location = new System.Drawing.Point(39, 325);
            this.lblCourseType.Name = "lblCourseType";
            this.lblCourseType.Size = new System.Drawing.Size(103, 13);
            this.lblCourseType.TabIndex = 8;
            this.lblCourseType.Text = "Select Course Type:";
            // 
            // rdoHybrid
            // 
            this.rdoHybrid.AutoSize = true;
            this.rdoHybrid.Checked = true;
            this.rdoHybrid.Location = new System.Drawing.Point(199, 323);
            this.rdoHybrid.Name = "rdoHybrid";
            this.rdoHybrid.Size = new System.Drawing.Size(55, 17);
            this.rdoHybrid.TabIndex = 9;
            this.rdoHybrid.TabStop = true;
            this.rdoHybrid.Text = "Hybrid";
            this.rdoHybrid.UseVisualStyleBackColor = true;
            // 
            // rdoOnline
            // 
            this.rdoOnline.AutoSize = true;
            this.rdoOnline.Location = new System.Drawing.Point(303, 325);
            this.rdoOnline.Name = "rdoOnline";
            this.rdoOnline.Size = new System.Drawing.Size(55, 17);
            this.rdoOnline.TabIndex = 10;
            this.rdoOnline.Text = "Online";
            this.rdoOnline.UseVisualStyleBackColor = true;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(76, 378);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(95, 23);
            this.btnSet.TabIndex = 11;
            this.btnSet.Text = "Save Selections";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(208, 378);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(95, 23);
            this.btnGet.TabIndex = 12;
            this.btnGet.Text = "Show Selections";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // cUDenverDataSet
            // 
            this.cUDenverDataSet.DataSetName = "CUDenverDataSet";
            this.cUDenverDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.cUDenverDataSet;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CoursesTableAdapter = this.coursesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Class_Selection_Capstone.CUDenverDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // coursesBindingSource1
            // 
            this.coursesBindingSource1.DataMember = "Courses";
            this.coursesBindingSource1.DataSource = this.cUDenverDataSet;
            // 
            // cmbCourseNum
            // 
            this.cmbCourseNum.DataSource = this.coursesBindingSource1;
            this.cmbCourseNum.DisplayMember = "CourseNum";
            this.cmbCourseNum.FormattingEnabled = true;
            this.cmbCourseNum.Location = new System.Drawing.Point(200, 294);
            this.cmbCourseNum.Name = "cmbCourseNum";
            this.cmbCourseNum.Size = new System.Drawing.Size(158, 21);
            this.cmbCourseNum.TabIndex = 7;
            this.cmbCourseNum.ValueMember = "CourseNum";
            // 
            // txtRetNumCourses
            // 
            this.txtRetNumCourses.Location = new System.Drawing.Point(200, 478);
            this.txtRetNumCourses.Name = "txtRetNumCourses";
            this.txtRetNumCourses.ReadOnly = true;
            this.txtRetNumCourses.Size = new System.Drawing.Size(158, 20);
            this.txtRetNumCourses.TabIndex = 15;
            this.txtRetNumCourses.TabStop = false;
            // 
            // lblRetNumCourses
            // 
            this.lblRetNumCourses.AutoSize = true;
            this.lblRetNumCourses.Location = new System.Drawing.Point(39, 481);
            this.lblRetNumCourses.Name = "lblRetNumCourses";
            this.lblRetNumCourses.Size = new System.Drawing.Size(155, 13);
            this.lblRetNumCourses.TabIndex = 16;
            this.lblRetNumCourses.Text = "Number of Courses Requested:";
            // 
            // lblRetStudentName
            // 
            this.lblRetStudentName.AutoSize = true;
            this.lblRetStudentName.Location = new System.Drawing.Point(39, 507);
            this.lblRetStudentName.Name = "lblRetStudentName";
            this.lblRetStudentName.Size = new System.Drawing.Size(65, 13);
            this.lblRetStudentName.TabIndex = 17;
            this.lblRetStudentName.Text = "For Student:";
            // 
            // txtRetStudentName
            // 
            this.txtRetStudentName.Location = new System.Drawing.Point(200, 504);
            this.txtRetStudentName.Name = "txtRetStudentName";
            this.txtRetStudentName.ReadOnly = true;
            this.txtRetStudentName.Size = new System.Drawing.Size(158, 20);
            this.txtRetStudentName.TabIndex = 18;
            this.txtRetStudentName.TabStop = false;
            // 
            // lblRetStartDate
            // 
            this.lblRetStartDate.AutoSize = true;
            this.lblRetStartDate.Location = new System.Drawing.Point(39, 533);
            this.lblRetStartDate.Name = "lblRetStartDate";
            this.lblRetStartDate.Size = new System.Drawing.Size(113, 13);
            this.lblRetStartDate.TabIndex = 19;
            this.lblRetStartDate.Text = "Requested Start Date:";
            // 
            // txtRetStartDate
            // 
            this.txtRetStartDate.Location = new System.Drawing.Point(200, 530);
            this.txtRetStartDate.Name = "txtRetStartDate";
            this.txtRetStartDate.ReadOnly = true;
            this.txtRetStartDate.Size = new System.Drawing.Size(158, 20);
            this.txtRetStartDate.TabIndex = 20;
            this.txtRetStartDate.TabStop = false;
            // 
            // lblRetCourseNum
            // 
            this.lblRetCourseNum.AutoSize = true;
            this.lblRetCourseNum.Location = new System.Drawing.Point(39, 559);
            this.lblRetCourseNum.Name = "lblRetCourseNum";
            this.lblRetCourseNum.Size = new System.Drawing.Size(98, 13);
            this.lblRetCourseNum.TabIndex = 21;
            this.lblRetCourseNum.Text = "Requested Course:";
            // 
            // txtRetCourseNum
            // 
            this.txtRetCourseNum.Location = new System.Drawing.Point(200, 556);
            this.txtRetCourseNum.Name = "txtRetCourseNum";
            this.txtRetCourseNum.ReadOnly = true;
            this.txtRetCourseNum.Size = new System.Drawing.Size(158, 20);
            this.txtRetCourseNum.TabIndex = 22;
            this.txtRetCourseNum.TabStop = false;
            // 
            // lblRetCourseType
            // 
            this.lblRetCourseType.AutoSize = true;
            this.lblRetCourseType.Location = new System.Drawing.Point(39, 585);
            this.lblRetCourseType.Name = "lblRetCourseType";
            this.lblRetCourseType.Size = new System.Drawing.Size(125, 13);
            this.lblRetCourseType.TabIndex = 23;
            this.lblRetCourseType.Text = "Requested Course Type:";
            // 
            // txtRetCourseType
            // 
            this.txtRetCourseType.Location = new System.Drawing.Point(200, 582);
            this.txtRetCourseType.Name = "txtRetCourseType";
            this.txtRetCourseType.ReadOnly = true;
            this.txtRetCourseType.Size = new System.Drawing.Size(158, 20);
            this.txtRetCourseType.TabIndex = 24;
            this.txtRetCourseType.TabStop = false;
            // 
            // lblRetValues
            // 
            this.lblRetValues.AutoSize = true;
            this.lblRetValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetValues.Location = new System.Drawing.Point(34, 446);
            this.lblRetValues.Name = "lblRetValues";
            this.lblRetValues.Size = new System.Drawing.Size(233, 16);
            this.lblRetValues.TabIndex = 25;
            this.lblRetValues.Text = "Confirmation of Selected Values:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(34, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(229, 16);
            this.lblTitle.TabIndex = 26;
            this.lblTitle.Text = "Spring 2019 - Registration Form:";
            // 
            // frmCourseSelector
            // 
            this.AcceptButton = this.btnSet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 632);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblRetValues);
            this.Controls.Add(this.txtRetCourseType);
            this.Controls.Add(this.lblRetCourseType);
            this.Controls.Add(this.txtRetCourseNum);
            this.Controls.Add(this.lblRetCourseNum);
            this.Controls.Add(this.txtRetStartDate);
            this.Controls.Add(this.lblRetStartDate);
            this.Controls.Add(this.txtRetStudentName);
            this.Controls.Add(this.lblRetStudentName);
            this.Controls.Add(this.lblRetNumCourses);
            this.Controls.Add(this.txtRetNumCourses);
            this.Controls.Add(this.cmbCourseNum);
            this.Controls.Add(courseNumLabel);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.rdoOnline);
            this.Controls.Add(this.rdoHybrid);
            this.Controls.Add(this.lblCourseType);
            this.Controls.Add(this.calClassStart);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtNumCourses);
            this.Controls.Add(this.lblNumCourses);
            this.Name = "frmCourseSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration - Spring 2019";
            this.Load += new System.EventHandler(this.frmCourseSelector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cUDenverDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumCourses;
        private System.Windows.Forms.TextBox txtNumCourses;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.MonthCalendar calClassStart;
        private System.Windows.Forms.Label lblCourseType;
        private System.Windows.Forms.RadioButton rdoHybrid;
        private System.Windows.Forms.RadioButton rdoOnline;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnGet;
        private CUDenverDataSet cUDenverDataSet;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private CUDenverDataSetTableAdapters.CoursesTableAdapter coursesTableAdapter;
        private CUDenverDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource coursesBindingSource1;
        private System.Windows.Forms.ComboBox cmbCourseNum;
        private System.Windows.Forms.TextBox txtRetNumCourses;
        private System.Windows.Forms.Label lblRetNumCourses;
        private System.Windows.Forms.Label lblRetStudentName;
        private System.Windows.Forms.TextBox txtRetStudentName;
        private System.Windows.Forms.Label lblRetStartDate;
        private System.Windows.Forms.TextBox txtRetStartDate;
        private System.Windows.Forms.Label lblRetCourseNum;
        private System.Windows.Forms.TextBox txtRetCourseNum;
        private System.Windows.Forms.Label lblRetCourseType;
        private System.Windows.Forms.TextBox txtRetCourseType;
        private System.Windows.Forms.Label lblRetValues;
        private System.Windows.Forms.Label lblTitle;
    }
}

