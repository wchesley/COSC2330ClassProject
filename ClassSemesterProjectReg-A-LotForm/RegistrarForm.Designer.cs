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
            this.btnCancelCourse = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnViewProfessorProfiles = new System.Windows.Forms.Button();
            this.btnViewStudentProfiles = new System.Windows.Forms.Button();
            this.btnAddProfessor = new System.Windows.Forms.Button();
            this.btnRemoveProfessor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelCourse
            // 
            this.btnCancelCourse.Location = new System.Drawing.Point(204, 30);
            this.btnCancelCourse.Name = "btnCancelCourse";
            this.btnCancelCourse.Size = new System.Drawing.Size(158, 52);
            this.btnCancelCourse.TabIndex = 10;
            this.btnCancelCourse.Text = "Cancel Course";
            this.btnCancelCourse.UseVisualStyleBackColor = true;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(30, 30);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(158, 52);
            this.btnAddCourse.TabIndex = 11;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            // 
            // btnViewProfessorProfiles
            // 
            this.btnViewProfessorProfiles.Location = new System.Drawing.Point(30, 98);
            this.btnViewProfessorProfiles.Name = "btnViewProfessorProfiles";
            this.btnViewProfessorProfiles.Size = new System.Drawing.Size(158, 52);
            this.btnViewProfessorProfiles.TabIndex = 12;
            this.btnViewProfessorProfiles.Text = "View/Update \r\nProfessor Profiles";
            this.btnViewProfessorProfiles.UseVisualStyleBackColor = true;
            // 
            // btnViewStudentProfiles
            // 
            this.btnViewStudentProfiles.Location = new System.Drawing.Point(204, 98);
            this.btnViewStudentProfiles.Name = "btnViewStudentProfiles";
            this.btnViewStudentProfiles.Size = new System.Drawing.Size(158, 52);
            this.btnViewStudentProfiles.TabIndex = 13;
            this.btnViewStudentProfiles.Text = "View/Update \r\nStudent Profiles";
            this.btnViewStudentProfiles.UseVisualStyleBackColor = true;
           
            // 
            // btnAddProfessor
            // 
            this.btnAddProfessor.Location = new System.Drawing.Point(30, 166);
            this.btnAddProfessor.Name = "btnAddProfessor";
            this.btnAddProfessor.Size = new System.Drawing.Size(158, 52);
            this.btnAddProfessor.TabIndex = 14;
            this.btnAddProfessor.Text = "Add Professor";
            this.btnAddProfessor.UseVisualStyleBackColor = true;
            // 
            // btnRemoveProfessor
            // 
            this.btnRemoveProfessor.Location = new System.Drawing.Point(204, 166);
            this.btnRemoveProfessor.Name = "btnRemoveProfessor";
            this.btnRemoveProfessor.Size = new System.Drawing.Size(158, 52);
            this.btnRemoveProfessor.TabIndex = 15;
            this.btnRemoveProfessor.Text = "Remove Professor";
            this.btnRemoveProfessor.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemoveProfessor);
            this.groupBox1.Controls.Add(this.btnCancelCourse);
            this.groupBox1.Controls.Add(this.btnAddProfessor);
            this.groupBox1.Controls.Add(this.btnAddCourse);
            this.groupBox1.Controls.Add(this.btnViewStudentProfiles);
            this.groupBox1.Controls.Add(this.btnViewProfessorProfiles);
            this.groupBox1.Location = new System.Drawing.Point(32, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 242);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Actions";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(346, 280);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 17;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // RegistrarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 319);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistrarForm";
            this.Text = "Registrar Form";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelCourse;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnViewProfessorProfiles;
        private System.Windows.Forms.Button btnViewStudentProfiles;
        private System.Windows.Forms.Button btnAddProfessor;
        private System.Windows.Forms.Button btnRemoveProfessor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLogOut;
    }
}