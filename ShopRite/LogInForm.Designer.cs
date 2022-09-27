namespace ShopRite
{
    partial class LogInForm
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
            this.mainLogin = new System.Windows.Forms.Panel();
            this.middleLogin = new System.Windows.Forms.Panel();
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.loginPassword = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.loginUserName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.leftLogin = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainLogin.SuspendLayout();
            this.middleLogin.SuspendLayout();
            this.leftLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLogin
            // 
            this.mainLogin.Controls.Add(this.middleLogin);
            this.mainLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLogin.Location = new System.Drawing.Point(0, 0);
            this.mainLogin.Name = "mainLogin";
            this.mainLogin.Size = new System.Drawing.Size(978, 573);
            this.mainLogin.TabIndex = 0;
            // 
            // middleLogin
            // 
            this.middleLogin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.middleLogin.Controls.Add(this.loginLabel);
            this.middleLogin.Controls.Add(this.loginBtn);
            this.middleLogin.Controls.Add(this.loginPassword);
            this.middleLogin.Controls.Add(this.panel2);
            this.middleLogin.Controls.Add(this.loginUserName);
            this.middleLogin.Controls.Add(this.panel1);
            this.middleLogin.Location = new System.Drawing.Point(572, 128);
            this.middleLogin.Name = "middleLogin";
            this.middleLogin.Size = new System.Drawing.Size(294, 300);
            this.middleLogin.TabIndex = 0;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginLabel.Location = new System.Drawing.Point(107, 31);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(86, 32);
            this.loginLabel.TabIndex = 3;
            this.loginLabel.Text = "Log In";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginBtn.Location = new System.Drawing.Point(63, 212);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(175, 39);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Log In";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // loginPassword
            // 
            this.loginPassword.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.loginPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginPassword.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.loginPassword.Location = new System.Drawing.Point(50, 155);
            this.loginPassword.Name = "loginPassword";
            this.loginPassword.PlaceholderText = "Password...";
            this.loginPassword.Size = new System.Drawing.Size(200, 24);
            this.loginPassword.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(50, 187);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 0;
            // 
            // loginUserName
            // 
            this.loginUserName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.loginUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginUserName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.loginUserName.Location = new System.Drawing.Point(50, 103);
            this.loginUserName.Name = "loginUserName";
            this.loginUserName.PlaceholderText = "Username...";
            this.loginUserName.Size = new System.Drawing.Size(200, 24);
            this.loginUserName.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(50, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 0;
            // 
            // leftLogin
            // 
            this.leftLogin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.leftLogin.Controls.Add(this.label2);
            this.leftLogin.Controls.Add(this.label3);
            this.leftLogin.Controls.Add(this.label1);
            this.leftLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftLogin.Location = new System.Drawing.Point(0, 0);
            this.leftLogin.Name = "leftLogin";
            this.leftLogin.Size = new System.Drawing.Size(458, 573);
            this.leftLogin.TabIndex = 1;
            this.leftLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.leftLogin_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(71, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "ShopRite\'s Management";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(168, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(139, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome To";
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 573);
            this.Controls.Add(this.leftLogin);
            this.Controls.Add(this.mainLogin);
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.mainLogin.ResumeLayout(false);
            this.middleLogin.ResumeLayout(false);
            this.middleLogin.PerformLayout();
            this.leftLogin.ResumeLayout(false);
            this.leftLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel mainLogin;
        private Panel middleLogin;
        private Label loginLabel;
        private Button loginBtn;
        private TextBox loginPassword;
        private Panel panel2;
        private TextBox loginUserName;
        private Panel panel1;
        private Panel leftLogin;
        private Label label2;
        private Label label3;
        private Label label1;
    }
}