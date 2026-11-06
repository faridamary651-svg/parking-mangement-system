namespace Parking_System
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            lblUserName = new Label();
            lblPassword = new Label();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            btnlogin = new Button();
            lblParking = new Label();
            pictureBox1 = new PictureBox();
            chkShowPassword = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(200, 187);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(90, 23);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "UserName";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(200, 231);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(82, 23);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(296, 231);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(172, 27);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += textBox1_TextChanged;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(296, 187);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(172, 27);
            txtUserName.TabIndex = 3;
            // 
            // btnlogin
            // 
            btnlogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogin.Location = new Point(200, 316);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(278, 54);
            btnlogin.TabIndex = 5;
            btnlogin.Text = "LOGIN";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // lblParking
            // 
            lblParking.AutoSize = true;
            lblParking.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblParking.Location = new Point(271, 117);
            lblParking.Name = "lblParking";
            lblParking.Size = new Size(152, 28);
            lblParking.TabIndex = 6;
            lblParking.Text = "Parking System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(240, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkShowPassword.Location = new Point(332, 264);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(136, 24);
            chkShowPassword.TabIndex = 8;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(chkShowPassword);
            Controls.Add(pictureBox1);
            Controls.Add(lblParking);
            Controls.Add(btnlogin);
            Controls.Add(txtUserName);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Name = "LoginForm";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserName;
        private Label lblPassword;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Button btnlogin;
        private Label lblParking;
        private PictureBox pictureBox1;
        private CheckBox chkShowPassword;
    }
}