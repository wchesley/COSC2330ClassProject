namespace ClassSemesterProjectReg_A_LotForm
{
    partial class AddCourseForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtCourseCode = new System.Windows.Forms.TextBox();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTimeSlot = new System.Windows.Forms.ComboBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course Code:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Course Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Department:";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(108, 48);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(213, 20);
            this.txtCourseName.TabIndex = 5;
            // 
            // txtCourseCode
            // 
            this.txtCourseCode.Location = new System.Drawing.Point(108, 75);
            this.txtCourseCode.Name = "txtCourseCode";
            this.txtCourseCode.Size = new System.Drawing.Size(213, 20);
            this.txtCourseCode.TabIndex = 6;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(149, 188);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(75, 23);
            this.btnAddCourse.TabIndex = 14;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(108, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Create a Course";
            // 
            // cmbTimeSlot
            // 
            this.cmbTimeSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTimeSlot.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmbTimeSlot.FormattingEnabled = true;
            this.cmbTimeSlot.Items.AddRange(new object[] {
            "8:00am -  9:00am",
            "9:30am - 10:30am",
            "11:00am - 12:30pm",
            "1:00pm - 2:00pm",
            "2:30pm - 3:30pm "});
            this.cmbTimeSlot.Location = new System.Drawing.Point(108, 128);
            this.cmbTimeSlot.Name = "cmbTimeSlot";
            this.cmbTimeSlot.Size = new System.Drawing.Size(208, 21);
            this.cmbTimeSlot.TabIndex = 12;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Items.AddRange(new object[] {
            "ABDR - Auto Collision Technology",
            "ACCT - Accounting",
            "AIRP - Aviation / Aircraft",
            "ANTH - Anthropology",
            "ARCH - Architecture",
            "ARTS - Art / Graphic Design",
            "BAS - Basic Academic Skills",
            "BASM - Basic Academeic Skills Math",
            "BASR - Basic Academic Skills Reading",
            "BASW - Basic Academic Writing",
            "BCIS - Computer Information Systems",
            "BCISL - Compter Information Systems",
            "BIOL - Biology",
            "BGMT - Managment",
            "BUSI - Buisness Administration",
            "CDEC - Child Development/Early Child",
            "CETT - Electronics",
            "CHEF - Food Services",
            "CHEM - Chemistry",
            "CJLE - Criminal Justice",
            "COMG - Communications, General",
            "COMM - Mass Com.",
            "COSC - CIS/Eng Computer Sci.",
            "COSCL - Computer Info Systems Labs",
            "CPMT - Electronis Technology",
            "CRIJ - Criminal Justice",
            "CRTR - Court Reporting",
            "CTMT - Computer Tomography",
            "CVOP - Commercial Vehicle Operation"});
            this.cmbDepartment.Location = new System.Drawing.Point(108, 155);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(208, 21);
            this.cmbDepartment.TabIndex = 13;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(231, 188);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbSection
            // 
            this.cmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSection.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbSection.Location = new System.Drawing.Point(108, 101);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(208, 21);
            this.cmbSection.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Section:";
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 232);
            this.Controls.Add(this.cmbSection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.cmbTimeSlot);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.txtCourseCode);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCourseForm";
            this.Text = "Add Course";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtCourseCode;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTimeSlot;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.Label label3;
    }
}