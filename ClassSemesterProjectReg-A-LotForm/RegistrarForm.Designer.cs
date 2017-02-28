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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabManageCourses = new System.Windows.Forms.TabPage();
            this.cmbSearchCourse = new System.Windows.Forms.ComboBox();
            this.btnSearchCourse = new System.Windows.Forms.Button();
            this.btnRemoveCourse = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabManageProfessors = new System.Windows.Forms.TabPage();
            this.cmbSearchProfessor = new System.Windows.Forms.ComboBox();
            this.btnSearchProfessor = new System.Windows.Forms.Button();
            this.btnUpdateProfessor = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemoveProfessor = new System.Windows.Forms.Button();
            this.btnAddProfessor = new System.Windows.Forms.Button();
            this.tabManageStudents = new System.Windows.Forms.TabPage();
            this.cmbSearchStudent = new System.Windows.Forms.ComboBox();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemoveStudent = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxUserSearch = new System.Windows.Forms.TextBox();
            this.txtuserSearch = new System.Windows.Forms.TextBox();
            this.txtuserChange = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabManageCourses.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabManageProfessors.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabManageStudents.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabManageCourses);
            this.tabControl1.Controls.Add(this.tabManageProfessors);
            this.tabControl1.Controls.Add(this.tabManageStudents);
            this.tabControl1.Location = new System.Drawing.Point(29, 54);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(475, 468);
            this.tabControl1.TabIndex = 21;
            // 
            // tabManageCourses
            // 
            this.tabManageCourses.Controls.Add(this.txtBoxUserSearch);
            this.tabManageCourses.Controls.Add(this.cmbSearchCourse);
            this.tabManageCourses.Controls.Add(this.btnSearchCourse);
            this.tabManageCourses.Controls.Add(this.btnRemoveCourse);
            this.tabManageCourses.Controls.Add(this.btnAddCourse);
            this.tabManageCourses.Controls.Add(this.tableLayoutPanel1);
            this.tabManageCourses.Location = new System.Drawing.Point(4, 22);
            this.tabManageCourses.Name = "tabManageCourses";
            this.tabManageCourses.Padding = new System.Windows.Forms.Padding(3);
            this.tabManageCourses.Size = new System.Drawing.Size(467, 442);
            this.tabManageCourses.TabIndex = 0;
            this.tabManageCourses.Text = "Manage Courses";
            this.tabManageCourses.UseVisualStyleBackColor = true;
            // 
            // cmbSearchCourse
            // 
            this.cmbSearchCourse.FormattingEnabled = true;
            this.cmbSearchCourse.Items.AddRange(new object[] {
            "By Course Number",
            "By Course Name",
            "By Professor",
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label8, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label18, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.077994F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.922F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(454, 359);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabManageProfessors
            // 
            this.tabManageProfessors.Controls.Add(this.txtuserSearch);
            this.tabManageProfessors.Controls.Add(this.cmbSearchProfessor);
            this.tabManageProfessors.Controls.Add(this.btnSearchProfessor);
            this.tabManageProfessors.Controls.Add(this.btnUpdateProfessor);
            this.tabManageProfessors.Controls.Add(this.tableLayoutPanel2);
            this.tabManageProfessors.Controls.Add(this.btnRemoveProfessor);
            this.tabManageProfessors.Controls.Add(this.btnAddProfessor);
            this.tabManageProfessors.Location = new System.Drawing.Point(4, 22);
            this.tabManageProfessors.Name = "tabManageProfessors";
            this.tabManageProfessors.Padding = new System.Windows.Forms.Padding(3);
            this.tabManageProfessors.Size = new System.Drawing.Size(467, 442);
            this.tabManageProfessors.TabIndex = 1;
            this.tabManageProfessors.Text = "Manage Professors";
            this.tabManageProfessors.UseVisualStyleBackColor = true;
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.label15, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label14, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.label10, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label13, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label11, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label12, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(454, 359);
            this.tableLayoutPanel2.TabIndex = 19;
            // 
            // btnRemoveProfessor
            // 
            this.btnRemoveProfessor.Location = new System.Drawing.Point(122, 371);
            this.btnRemoveProfessor.Name = "btnRemoveProfessor";
            this.btnRemoveProfessor.Size = new System.Drawing.Size(109, 32);
            this.btnRemoveProfessor.TabIndex = 20;
            this.btnRemoveProfessor.Text = "Remove Professor";
            this.btnRemoveProfessor.UseVisualStyleBackColor = true;
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
            this.tabManageStudents.Controls.Add(this.txtuserChange);
            this.tabManageStudents.Controls.Add(this.cmbSearchStudent);
            this.tabManageStudents.Controls.Add(this.btnSearchStudent);
            this.tabManageStudents.Controls.Add(this.btnUpdateStudent);
            this.tabManageStudents.Controls.Add(this.tableLayoutPanel3);
            this.tabManageStudents.Controls.Add(this.btnRemoveStudent);
            this.tabManageStudents.Controls.Add(this.btnAddStudent);
            this.tabManageStudents.Location = new System.Drawing.Point(4, 22);
            this.tabManageStudents.Name = "tabManageStudents";
            this.tabManageStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabManageStudents.Size = new System.Drawing.Size(467, 442);
            this.tabManageStudents.TabIndex = 2;
            this.tabManageStudents.Text = "Manage Students";
            this.tabManageStudents.UseVisualStyleBackColor = true;
            // 
            // cmbSearchStudent
            // 
            this.cmbSearchStudent.FormattingEnabled = true;
            this.cmbSearchStudent.Items.AddRange(new object[] {
            "Reset table",
            "By ID Number",
            "By Last Name"});
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
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.label22, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.label16, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label21, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.label17, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label20, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label19, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(454, 359);
            this.tableLayoutPanel3.TabIndex = 19;
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.Location = new System.Drawing.Point(121, 371);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(109, 32);
            this.btnRemoveStudent.TabIndex = 22;
            this.btnRemoveStudent.Text = "Remove Student";
            this.btnRemoveStudent.UseVisualStyleBackColor = true;
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
            this.btnLogOut.Location = new System.Drawing.Point(425, 557);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 20;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Professor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Capacity";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1, 0);
            this.label18.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 13);
            this.label18.TabIndex = 49;
            this.label18.Text = "Course ID #";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Department";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Section";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(354, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "Select";
            // 
            // txtBoxUserSearch
            // 
            this.txtBoxUserSearch.Location = new System.Drawing.Point(245, 410);
            this.txtBoxUserSearch.Name = "txtBoxUserSearch";
            this.txtBoxUserSearch.Size = new System.Drawing.Size(100, 20);
            this.txtBoxUserSearch.TabIndex = 26;
            // 
            // txtuserSearch
            // 
            this.txtuserSearch.Location = new System.Drawing.Point(245, 410);
            this.txtuserSearch.Name = "txtuserSearch";
            this.txtuserSearch.Size = new System.Drawing.Size(100, 20);
            this.txtuserSearch.TabIndex = 26;
            // 
            // txtuserChange
            // 
            this.txtuserChange.Location = new System.Drawing.Point(245, 410);
            this.txtuserChange.Name = "txtuserChange";
            this.txtuserChange.Size = new System.Drawing.Size(100, 20);
            this.txtuserChange.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "First Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(66, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Last Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(130, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Address";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(181, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Phone #";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(235, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Email";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(273, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Fax #";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(313, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Instructor ID #";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 23;
            this.label16.Text = "First Name";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(66, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 13);
            this.label17.TabIndex = 24;
            this.label17.Text = "Last Name";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(130, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 13);
            this.label19.TabIndex = 25;
            this.label19.Text = "Address";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(181, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(45, 13);
            this.label20.TabIndex = 26;
            this.label20.Text = "Phone#";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(232, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(32, 13);
            this.label21.TabIndex = 27;
            this.label21.Text = "Email";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(270, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(68, 13);
            this.label22.TabIndex = 28;
            this.label22.Text = "Student ID #";
            // 
            // RegistrarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 592);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnLogOut);
            this.Name = "RegistrarForm";
            this.Text = "Registrar Actions";
            this.tabControl1.ResumeLayout(false);
            this.tabManageCourses.ResumeLayout(false);
            this.tabManageCourses.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabManageProfessors.ResumeLayout(false);
            this.tabManageProfessors.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabManageStudents.ResumeLayout(false);
            this.tabManageStudents.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabManageCourses;
        private System.Windows.Forms.Button btnSearchCourse;
        private System.Windows.Forms.Button btnRemoveCourse;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage tabManageProfessors;
        private System.Windows.Forms.Button btnSearchProfessor;
        private System.Windows.Forms.Button btnUpdateProfessor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnRemoveProfessor;
        private System.Windows.Forms.Button btnAddProfessor;
        private System.Windows.Forms.TabPage tabManageStudents;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnRemoveStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.ComboBox cmbSearchStudent;
        private System.Windows.Forms.ComboBox cmbSearchProfessor;
        private System.Windows.Forms.ComboBox cmbSearchCourse;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxUserSearch;
        private System.Windows.Forms.TextBox txtuserSearch;
        private System.Windows.Forms.TextBox txtuserChange;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
    }
}