namespace ClassSemesterProjectReg_A_LotForm
{
    partial class RegistrarForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridProfessors = new System.Windows.Forms.TabControl();
            this.tabManageCourses = new System.Windows.Forms.TabPage();
            this.dataGridCourse = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBoxUserSearch = new System.Windows.Forms.TextBox();
            this.cmbSearchCourse = new System.Windows.Forms.ComboBox();
            this.btnSearchCourse = new System.Windows.Forms.Button();
            this.btnRemoveCourse = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.tabManageProfessors = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtUserSearchProfessor = new System.Windows.Forms.TextBox();
            this.cmbSearchProfessor = new System.Windows.Forms.ComboBox();
            this.btnSearchProfessor = new System.Windows.Forms.Button();
            this.btnUpdateProfessor = new System.Windows.Forms.Button();
            this.btnRemoveProfessor = new System.Windows.Forms.Button();
            this.btnAddProfessor = new System.Windows.Forms.Button();
            this.tabManageStudents = new System.Windows.Forms.TabPage();
            this.dataGridStudent = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtUserSearchStudent = new System.Windows.Forms.TextBox();
            this.cmbSearchStudent = new System.Windows.Forms.ComboBox();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnRemoveStudent = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.dataGridProfessors.SuspendLayout();
            this.tabManageCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCourse)).BeginInit();
            this.tabManageProfessors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabManageStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Registrar Actions";
            // 
            // dataGridProfessors
            // 
            this.dataGridProfessors.Controls.Add(this.tabManageCourses);
            this.dataGridProfessors.Controls.Add(this.tabManageProfessors);
            this.dataGridProfessors.Controls.Add(this.tabManageStudents);
            this.dataGridProfessors.Location = new System.Drawing.Point(29, 54);
            this.dataGridProfessors.Name = "dataGridProfessors";
            this.dataGridProfessors.SelectedIndex = 0;
            this.dataGridProfessors.Size = new System.Drawing.Size(866, 468);
            this.dataGridProfessors.TabIndex = 21;
            // 
            // tabManageCourses
            // 
            this.tabManageCourses.Controls.Add(this.dataGridCourse);
            this.tabManageCourses.Controls.Add(this.txtBoxUserSearch);
            this.tabManageCourses.Controls.Add(this.cmbSearchCourse);
            this.tabManageCourses.Controls.Add(this.btnSearchCourse);
            this.tabManageCourses.Controls.Add(this.btnRemoveCourse);
            this.tabManageCourses.Controls.Add(this.btnAddCourse);
            this.tabManageCourses.Location = new System.Drawing.Point(4, 22);
            this.tabManageCourses.Name = "tabManageCourses";
            this.tabManageCourses.Padding = new System.Windows.Forms.Padding(3);
            this.tabManageCourses.Size = new System.Drawing.Size(858, 442);
            this.tabManageCourses.TabIndex = 0;
            this.tabManageCourses.Text = "Manage Courses";
            this.tabManageCourses.UseVisualStyleBackColor = true;
            // 
            // dataGridCourse
            // 
            this.dataGridCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.Column9});
            this.dataGridCourse.Location = new System.Drawing.Point(6, 6);
            this.dataGridCourse.Name = "dataGridCourse";
            this.dataGridCourse.Size = new System.Drawing.Size(835, 359);
            this.dataGridCourse.TabIndex = 49;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Course ID #";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Section";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Professor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Department";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Time";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Capacity";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Select";
            this.Column9.Name = "Column9";
            // 
            // txtBoxUserSearch
            // 
            this.txtBoxUserSearch.Location = new System.Drawing.Point(245, 410);
            this.txtBoxUserSearch.Name = "txtBoxUserSearch";
            this.txtBoxUserSearch.Size = new System.Drawing.Size(100, 20);
            this.txtBoxUserSearch.TabIndex = 26;
            // 
            // cmbSearchCourse
            // 
            this.cmbSearchCourse.FormattingEnabled = true;
            this.cmbSearchCourse.Items.AddRange(new object[] {
            "By Course Number",
            "By Course Name",
            "By Professor Last Name",
            "Reset table"});
            this.cmbSearchCourse.Location = new System.Drawing.Point(351, 410);
            this.cmbSearchCourse.Name = "cmbSearchCourse";
            this.cmbSearchCourse.Size = new System.Drawing.Size(109, 21);
            this.cmbSearchCourse.TabIndex = 25;
            // 
            // btnSearchCourse
            // 
            this.btnSearchCourse.Location = new System.Drawing.Point(351, 371);
            this.btnSearchCourse.Name = "btnSearchCourse";
            this.btnSearchCourse.Size = new System.Drawing.Size(109, 32);
            this.btnSearchCourse.TabIndex = 3;
            this.btnSearchCourse.Text = "Search Course";
            this.btnSearchCourse.UseVisualStyleBackColor = true;
            this.btnSearchCourse.Click += new System.EventHandler(this.btnSearchCourse_Click);
            // 
            // btnRemoveCourse
            // 
            this.btnRemoveCourse.Location = new System.Drawing.Point(122, 371);
            this.btnRemoveCourse.Name = "btnRemoveCourse";
            this.btnRemoveCourse.Size = new System.Drawing.Size(109, 32);
            this.btnRemoveCourse.TabIndex = 2;
            this.btnRemoveCourse.Text = "Remove Course";
            this.btnRemoveCourse.UseVisualStyleBackColor = true;
            this.btnRemoveCourse.Click += new System.EventHandler(this.btnRemoveCourse_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(7, 371);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(109, 32);
            this.btnAddCourse.TabIndex = 1;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // tabManageProfessors
            // 
            this.tabManageProfessors.Controls.Add(this.dataGridView1);
            this.tabManageProfessors.Controls.Add(this.txtUserSearchProfessor);
            this.tabManageProfessors.Controls.Add(this.cmbSearchProfessor);
            this.tabManageProfessors.Controls.Add(this.btnSearchProfessor);
            this.tabManageProfessors.Controls.Add(this.btnUpdateProfessor);
            this.tabManageProfessors.Controls.Add(this.btnRemoveProfessor);
            this.tabManageProfessors.Controls.Add(this.btnAddProfessor);
            this.tabManageProfessors.Location = new System.Drawing.Point(4, 22);
            this.tabManageProfessors.Name = "tabManageProfessors";
            this.tabManageProfessors.Padding = new System.Windows.Forms.Padding(3);
            this.tabManageProfessors.Size = new System.Drawing.Size(858, 442);
            this.tabManageProfessors.TabIndex = 1;
            this.tabManageProfessors.Text = "Manage Professors";
            this.tabManageProfessors.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column10});
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(846, 359);
            this.dataGridView1.TabIndex = 23;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Instructor ID #";
            this.Column7.Name = "Column7";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "First Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Last Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Address";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Phone #";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Email";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Fax";
            this.Column6.Name = "Column6";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Select";
            this.Column10.Name = "Column10";
            // 
            // txtUserSearchProfessor
            // 
            this.txtUserSearchProfessor.Location = new System.Drawing.Point(245, 410);
            this.txtUserSearchProfessor.Name = "txtUserSearchProfessor";
            this.txtUserSearchProfessor.Size = new System.Drawing.Size(100, 20);
            this.txtUserSearchProfessor.TabIndex = 26;
            // 
            // cmbSearchProfessor
            // 
            this.cmbSearchProfessor.FormattingEnabled = true;
            this.cmbSearchProfessor.Items.AddRange(new object[] {
            "By ID Number",
            "By Last Name",
            "Reset table"});
            this.cmbSearchProfessor.Location = new System.Drawing.Point(351, 410);
            this.cmbSearchProfessor.Name = "cmbSearchProfessor";
            this.cmbSearchProfessor.Size = new System.Drawing.Size(109, 21);
            this.cmbSearchProfessor.TabIndex = 25;
            // 
            // btnSearchProfessor
            // 
            this.btnSearchProfessor.Location = new System.Drawing.Point(351, 371);
            this.btnSearchProfessor.Name = "btnSearchProfessor";
            this.btnSearchProfessor.Size = new System.Drawing.Size(109, 32);
            this.btnSearchProfessor.TabIndex = 24;
            this.btnSearchProfessor.Text = "Search Professor";
            this.btnSearchProfessor.UseVisualStyleBackColor = true;
            this.btnSearchProfessor.Click += new System.EventHandler(this.btnSearchProfessor_Click);
            // 
            // btnUpdateProfessor
            // 
            this.btnUpdateProfessor.Location = new System.Drawing.Point(237, 371);
            this.btnUpdateProfessor.Name = "btnUpdateProfessor";
            this.btnUpdateProfessor.Size = new System.Drawing.Size(109, 32);
            this.btnUpdateProfessor.TabIndex = 21;
            this.btnUpdateProfessor.Text = "Update Professor";
            this.btnUpdateProfessor.UseVisualStyleBackColor = true;
            this.btnUpdateProfessor.Click += new System.EventHandler(this.btnUpdateProfessor_Click);
            // 
            // btnRemoveProfessor
            // 
            this.btnRemoveProfessor.Location = new System.Drawing.Point(122, 371);
            this.btnRemoveProfessor.Name = "btnRemoveProfessor";
            this.btnRemoveProfessor.Size = new System.Drawing.Size(109, 32);
            this.btnRemoveProfessor.TabIndex = 20;
            this.btnRemoveProfessor.Text = "Remove Professor";
            this.btnRemoveProfessor.UseVisualStyleBackColor = true;
            this.btnRemoveProfessor.Click += new System.EventHandler(this.btnRemoveProfessor_Click);
            // 
            // btnAddProfessor
            // 
            this.btnAddProfessor.Location = new System.Drawing.Point(7, 371);
            this.btnAddProfessor.Name = "btnAddProfessor";
            this.btnAddProfessor.Size = new System.Drawing.Size(109, 32);
            this.btnAddProfessor.TabIndex = 19;
            this.btnAddProfessor.Text = "Add Professor";
            this.btnAddProfessor.UseVisualStyleBackColor = true;
            this.btnAddProfessor.Click += new System.EventHandler(this.btnAddProfessor_Click);
            // 
            // tabManageStudents
            // 
            this.tabManageStudents.Controls.Add(this.dataGridStudent);
            this.tabManageStudents.Controls.Add(this.txtUserSearchStudent);
            this.tabManageStudents.Controls.Add(this.cmbSearchStudent);
            this.tabManageStudents.Controls.Add(this.btnSearchStudent);
            this.tabManageStudents.Controls.Add(this.btnUpdateStudent);
            this.tabManageStudents.Controls.Add(this.btnRemoveStudent);
            this.tabManageStudents.Controls.Add(this.btnAddStudent);
            this.tabManageStudents.Location = new System.Drawing.Point(4, 22);
            this.tabManageStudents.Name = "tabManageStudents";
            this.tabManageStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabManageStudents.Size = new System.Drawing.Size(858, 442);
            this.tabManageStudents.TabIndex = 2;
            this.tabManageStudents.Text = "Manage Students";
            this.tabManageStudents.UseVisualStyleBackColor = true;
            // 
            // dataGridStudent
            // 
            this.dataGridStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.Column11});
            this.dataGridStudent.Location = new System.Drawing.Point(6, 6);
            this.dataGridStudent.Name = "dataGridStudent";
            this.dataGridStudent.Size = new System.Drawing.Size(846, 359);
            this.dataGridStudent.TabIndex = 24;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Student ID #";
            this.Column8.Name = "Column8";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Address";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Phone #";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Email";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Select";
            this.Column11.Name = "Column11";
            // 
            // txtUserSearchStudent
            // 
            this.txtUserSearchStudent.Location = new System.Drawing.Point(245, 410);
            this.txtUserSearchStudent.Name = "txtUserSearchStudent";
            this.txtUserSearchStudent.Size = new System.Drawing.Size(100, 20);
            this.txtUserSearchStudent.TabIndex = 27;
            // 
            // cmbSearchStudent
            // 
            this.cmbSearchStudent.FormattingEnabled = true;
            this.cmbSearchStudent.Items.AddRange(new object[] {
            "By ID Number",
            "By Last Name",
            "Reset table"});
            this.cmbSearchStudent.Location = new System.Drawing.Point(351, 410);
            this.cmbSearchStudent.Name = "cmbSearchStudent";
            this.cmbSearchStudent.Size = new System.Drawing.Size(109, 21);
            this.cmbSearchStudent.TabIndex = 24;
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.Location = new System.Drawing.Point(351, 371);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(109, 32);
            this.btnSearchStudent.TabIndex = 23;
            this.btnSearchStudent.Text = "Search Student";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.Location = new System.Drawing.Point(236, 371);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(109, 32);
            this.btnUpdateStudent.TabIndex = 22;
            this.btnUpdateStudent.Text = "Update Student";
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.Location = new System.Drawing.Point(121, 371);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(109, 32);
            this.btnRemoveStudent.TabIndex = 22;
            this.btnRemoveStudent.Text = "Remove Student";
            this.btnRemoveStudent.UseVisualStyleBackColor = true;
            this.btnRemoveStudent.Click += new System.EventHandler(this.btnRemoveStudent_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(6, 371);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(109, 32);
            this.btnAddStudent.TabIndex = 21;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(816, 528);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 20;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // RegistrarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 563);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridProfessors);
            this.Controls.Add(this.btnLogOut);
            this.Name = "RegistrarForm";
            this.Text = "Registrar Actions";
            this.dataGridProfessors.ResumeLayout(false);
            this.tabManageCourses.ResumeLayout(false);
            this.tabManageCourses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCourse)).EndInit();
            this.tabManageProfessors.ResumeLayout(false);
            this.tabManageProfessors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabManageStudents.ResumeLayout(false);
            this.tabManageStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl dataGridProfessors;
        private System.Windows.Forms.TabPage tabManageCourses;
        private System.Windows.Forms.Button btnSearchCourse;
        private System.Windows.Forms.Button btnRemoveCourse;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.TabPage tabManageProfessors;
        private System.Windows.Forms.Button btnSearchProfessor;
        private System.Windows.Forms.Button btnUpdateProfessor;
        private System.Windows.Forms.Button btnRemoveProfessor;
        private System.Windows.Forms.Button btnAddProfessor;
        private System.Windows.Forms.TabPage tabManageStudents;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Button btnRemoveStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.ComboBox cmbSearchStudent;
        private System.Windows.Forms.ComboBox cmbSearchProfessor;
        private System.Windows.Forms.ComboBox cmbSearchCourse;
        private System.Windows.Forms.TextBox txtBoxUserSearch;
        private System.Windows.Forms.TextBox txtUserSearchProfessor;
        private System.Windows.Forms.TextBox txtUserSearchStudent;
        private System.Windows.Forms.DataGridView dataGridCourse;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
    }
}