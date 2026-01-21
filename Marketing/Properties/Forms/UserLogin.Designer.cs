namespace Marketing
{
    partial class UserLogin
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
            textBox_Name = new TextBox();
            textBox_Password = new TextBox();
            name = new Label();
            password = new Label();
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(60, 170);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(226, 27);
            textBox_Name.TabIndex = 0;
            // 
            // textBox_Password
            // 
            textBox_Password.Location = new Point(60, 243);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(226, 27);
            textBox_Password.TabIndex = 1;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            name.Location = new Point(60, 139);
            name.Name = "name";
            name.Size = new Size(55, 28);
            name.TabIndex = 2;
            name.Text = "Имя";
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            password.Location = new Point(60, 212);
            password.Name = "password";
            password.Size = new Size(85, 28);
            password.TabIndex = 3;
            password.Text = "Пароль";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.OrangeRed;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnLogin.ForeColor = SystemColors.ControlLightLight;
            btnLogin.Location = new Point(93, 310);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(151, 56);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Frame_1;
            pictureBox1.Location = new Point(60, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(226, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // UserLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(348, 436);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogin);
            Controls.Add(password);
            Controls.Add(name);
            Controls.Add(textBox_Password);
            Controls.Add(textBox_Name);
            Name = "UserLogin";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Name;
        private TextBox textBox_Password;
        private Label name;
        private Label password;
        private Button btnLogin;
        private PictureBox pictureBox1;
    }
}