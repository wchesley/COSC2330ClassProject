namespace ClassSemesterProjectReg_A_LotForm
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblProfileEmail = new System.Windows.Forms.Label();
            this.lblProfilePhoneNumber = new System.Windows.Forms.Label();
            this.lblProfileAddress = new System.Windows.Forms.Label();
            this.lblStudentProfileID = new System.Windows.Forms.Label();
            this.lblProfileName = new System.Windows.Forms.Label();
            this.lnkUpdateProfileInfo = new System.Windows.Forms.LinkLabel();
            this.picProfilePicture = new System.Windows.Forms.PictureBox();
            this.btnViewSchedule = new System.Windows.Forms.Button();
            this.btnRegisterForSections = new System.Windows.Forms.Button();
            this.lnkChangePassword = new System.Windows.Forms.LinkLabel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblProfileEmail);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblProfilePhoneNumber);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblProfileAddress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblStudentProfileID);
            this.groupBox1.Controls.Add(this.lblProfileName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 166);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your Profile";
            // 
            // lblProfileEmail
            // 
            this.lblProfileEmail.AutoSize = true;
            this.lblProfileEmail.Location = new System.Drawing.Point(103, 131);
            this.lblProfileEmail.Name = "lblProfileEmail";
            this.lblProfileEmail.Size = new System.Drawing.Size(59, 13);
            this.lblProfileEmail.TabIndex = 10;
            this.lblProfileEmail.Text = "TempEmail";
            // 
            // lblProfilePhoneNumber
            // 
            this.lblProfilePhoneNumber.AutoSize = true;
            this.lblProfilePhoneNumber.Location = new System.Drawing.Point(103, 106);
            this.lblProfilePhoneNumber.Name = "lblProfilePhoneNumber";
            this.lblProfilePhoneNumber.Size = new System.Drawing.Size(102, 13);
            this.lblProfilePhoneNumber.TabIndex = 9;
            this.lblProfilePhoneNumber.Text = "TempPhoneNumber";
            // 
            // lblProfileAddress
            // 
            this.lblProfileAddress.AutoSize = true;
            this.lblProfileAddress.Location = new System.Drawing.Point(103, 81);
            this.lblProfileAddress.Name = "lblProfileAddress";
            this.lblProfileAddress.Size = new System.Drawing.Size(72, 13);
            this.lblProfileAddress.TabIndex = 8;
            this.lblProfileAddress.Text = "TempAddress";
            // 
            // lblStudentProfileID
            // 
            this.lblStudentProfileID.AutoSize = true;
            this.lblStudentProfileID.Location = new System.Drawing.Point(103, 56);
            this.lblStudentProfileID.Name = "lblStudentProfileID";
            this.lblStudentProfileID.Size = new System.Drawing.Size(82, 13);
            this.lblStudentProfileID.TabIndex = 7;
            this.lblStudentProfileID.Text = "TempStudentID";
            this.lblStudentProfileID.Click += new System.EventHandler(this.lblStudentProfileID_Click);
            // 
            // lblProfileName
            // 
            this.lblProfileName.AutoSize = true;
            this.lblProfileName.Location = new System.Drawing.Point(103, 31);
            this.lblProfileName.Name = "lblProfileName";
            this.lblProfileName.Size = new System.Drawing.Size(99, 13);
            this.lblProfileName.TabIndex = 6;
            this.lblProfileName.Text = "TempStudentName";
            // 
            // lnkUpdateProfileInfo
            // 
            this.lnkUpdateProfileInfo.AutoSize = true;
            this.lnkUpdateProfileInfo.Location = new System.Drawing.Point(22, 208);
            this.lnkUpdateProfileInfo.Name = "lnkUpdateProfileInfo";
            this.lnkUpdateProfileInfo.Size = new System.Drawing.Size(143, 13);
            this.lnkUpdateProfileInfo.TabIndex = 7;
            this.lnkUpdateProfileInfo.TabStop = true;
            this.lnkUpdateProfileInfo.Text = "Update my profile information";
            this.lnkUpdateProfileInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkUpdateProfileInfo_LinkClicked);
            // 
            // picProfilePicture
            // 
            this.picProfilePicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picProfilePicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picProfilePicture.BackgroundImage")));
            this.picProfilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picProfilePicture.Location = new System.Drawing.Point(379, 47);
            this.picProfilePicture.Name = "picProfilePicture";
            this.picProfilePicture.Size = new System.Drawing.Size(150, 150);
            this.picProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picProfilePicture.TabIndex = 8;
            this.picProfilePicture.TabStop = false;
            // 
            // btnViewSchedule
            // 
            this.btnViewSchedule.Location = new System.Drawing.Point(86, 255);
            this.btnViewSchedule.Name = "btnViewSchedule";
            this.btnViewSchedule.Size = new System.Drawing.Size(158, 52);
            this.btnViewSchedule.TabIndex = 9;
            this.btnViewSchedule.Text = "View Schedule";
            this.btnViewSchedule.UseVisualStyleBackColor = true;
            this.btnViewSchedule.Click += new System.EventHandler(this.btnViewSchedule_Click);
            // 
            // btnRegisterForSections
            // 
            this.btnRegisterForSections.Location = new System.Drawing.Point(259, 255);
            this.btnRegisterForSections.Name = "btnRegisterForSections";
            this.btnRegisterForSections.Size = new System.Drawing.Size(216, 52);
            this.btnRegisterForSections.TabIndex = 10;
            this.btnRegisterForSections.Text = "Register / Drop Sections";
            this.btnRegisterForSections.UseVisualStyleBackColor = true;
            this.btnRegisterForSections.Click += new System.EventHandler(this.btnRegisterForSections_Click);
            // 
            // lnkChangePassword
            // 
            this.lnkChangePassword.AutoSize = true;
            this.lnkChangePassword.Location = new System.Drawing.Point(22, 223);
            this.lnkChangePassword.Name = "lnkChangePassword";
            this.lnkChangePassword.Size = new System.Drawing.Size(93, 13);
            this.lnkChangePassword.TabIndex = 12;
            this.lnkChangePassword.TabStop = true;
            this.lnkChangePassword.Text = "Change Password";
            this.lnkChangePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkChangePassword_LinkClicked);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(454, 208);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 18;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 336);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lnkChangePassword);
            this.Controls.Add(this.btnRegisterForSections);
            this.Controls.Add(this.btnViewSchedule);
            this.Controls.Add(this.picProfilePicture);
            this.Controls.Add(this.lnkUpdateProfileInfo);
            this.Controls.Add(this.groupBox1);
            this.Name = "StudentForm";
            this.Text = "Student Profile";
            
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblProfileEmail;
        private System.Windows.Forms.Label lblProfilePhoneNumber;
        private System.Windows.Forms.Label lblProfileAddress;
        private System.Windows.Forms.Label lblStudentProfileID;
        private System.Windows.Forms.Label lblProfileName;
        private System.Windows.Forms.LinkLabel lnkUpdateProfileInfo;
        private System.Windows.Forms.PictureBox picProfilePicture;
        private System.Windows.Forms.Button btnViewSchedule;
        private System.Windows.Forms.Button btnRegisterForSections;
        private System.Windows.Forms.LinkLabel lnkChangePassword;
        private System.Windows.Forms.Button btnLogOut;
    }
}