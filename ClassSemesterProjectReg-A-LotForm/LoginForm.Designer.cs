namespace ClassSemesterProjectReg_A_LotForm
{
    partial class LoginForm
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.linkToRegister = new System.Windows.Forms.LinkLabel();
            this.btnTestStudentForm = new System.Windows.Forms.Button();
            this.btnTestTeacherForm = new System.Windows.Forms.Button();
            this.btnTestRegistrarForm = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Made-Up College";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please Login to continue";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(176, 152);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(170, 20);
            this.txtID.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(176, 196);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(170, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Login ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(224, 225);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // linkToRegister
            // 
            this.linkToRegister.AutoSize = true;
            this.linkToRegister.Location = new System.Drawing.Point(151, 274);
            this.linkToRegister.Name = "linkToRegister";
            this.linkToRegister.Size = new System.Drawing.Size(224, 13);
            this.linkToRegister.TabIndex = 7;
            this.linkToRegister.TabStop = true;
            this.linkToRegister.Text = "Don\'t have an account? Click here to register.";
            this.linkToRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkToRegister_LinkClicked);
            // 
            // btnTestStudentForm
            // 
            this.btnTestStudentForm.Location = new System.Drawing.Point(24, 51);
            this.btnTestStudentForm.Name = "btnTestStudentForm";
            this.btnTestStudentForm.Size = new System.Drawing.Size(89, 71);
            this.btnTestStudentForm.TabIndex = 8;
            this.btnTestStudentForm.Text = "Test StudentForm";
            this.btnTestStudentForm.UseVisualStyleBackColor = true;
            this.btnTestStudentForm.Click += new System.EventHandler(this.btnTestStudentForm_Click);
            // 
            // btnTestTeacherForm
            // 
            this.btnTestTeacherForm.Location = new System.Drawing.Point(24, 137);
            this.btnTestTeacherForm.Name = "btnTestTeacherForm";
            this.btnTestTeacherForm.Size = new System.Drawing.Size(89, 71);
            this.btnTestTeacherForm.TabIndex = 9;
            this.btnTestTeacherForm.Text = "Test TeacherForm";
            this.btnTestTeacherForm.UseVisualStyleBackColor = true;
            this.btnTestTeacherForm.Click += new System.EventHandler(this.btnTestTeacherForm_Click);
            // 
            // btnTestRegistrarForm
            // 
            this.btnTestRegistrarForm.Location = new System.Drawing.Point(24, 225);
            this.btnTestRegistrarForm.Name = "btnTestRegistrarForm";
            this.btnTestRegistrarForm.Size = new System.Drawing.Size(89, 71);
            this.btnTestRegistrarForm.TabIndex = 10;
            this.btnTestRegistrarForm.Text = "Test RegistrarForm";
            this.btnTestRegistrarForm.UseVisualStyleBackColor = true;
            this.btnTestRegistrarForm.Click += new System.EventHandler(this.btnTestRegistrarForm_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "DELETE LATER:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "TEST BUTTONS";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 341);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTestRegistrarForm);
            this.Controls.Add(this.btnTestTeacherForm);
            this.Controls.Add(this.btnTestStudentForm);
            this.Controls.Add(this.linkToRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel linkToRegister;
        private System.Windows.Forms.Button btnTestStudentForm;
        private System.Windows.Forms.Button btnTestTeacherForm;
        private System.Windows.Forms.Button btnTestRegistrarForm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

