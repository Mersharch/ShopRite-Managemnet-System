namespace ShopRite
{
    partial class MainForm
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
            this.nav = new System.Windows.Forms.Panel();
            this.userBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.stockBtn = new System.Windows.Forms.Button();
            this.brandBtn = new System.Windows.Forms.Button();
            this.categoryBtn = new System.Windows.Forms.Button();
            this.productBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.footer = new System.Windows.Forms.Panel();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.nav.SuspendLayout();
            this.SuspendLayout();
            // 
            // nav
            // 
            this.nav.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.nav.Controls.Add(this.userBtn);
            this.nav.Controls.Add(this.logoutBtn);
            this.nav.Controls.Add(this.stockBtn);
            this.nav.Controls.Add(this.brandBtn);
            this.nav.Controls.Add(this.categoryBtn);
            this.nav.Controls.Add(this.productBtn);
            this.nav.Controls.Add(this.homeBtn);
            this.nav.Controls.Add(this.panel2);
            this.nav.Dock = System.Windows.Forms.DockStyle.Top;
            this.nav.Location = new System.Drawing.Point(0, 0);
            this.nav.Name = "nav";
            this.nav.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.nav.Size = new System.Drawing.Size(978, 72);
            this.nav.TabIndex = 0;
            // 
            // userBtn
            // 
            this.userBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.userBtn.FlatAppearance.BorderSize = 0;
            this.userBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userBtn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userBtn.Location = new System.Drawing.Point(674, 0);
            this.userBtn.Margin = new System.Windows.Forms.Padding(0);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(110, 70);
            this.userBtn.TabIndex = 7;
            this.userBtn.Text = "Users";
            this.userBtn.UseVisualStyleBackColor = true;
            this.userBtn.Click += new System.EventHandler(this.userBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logoutBtn.Location = new System.Drawing.Point(881, 22);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(94, 31);
            this.logoutBtn.TabIndex = 6;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // stockBtn
            // 
            this.stockBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.stockBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.stockBtn.FlatAppearance.BorderSize = 0;
            this.stockBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockBtn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stockBtn.Location = new System.Drawing.Point(564, 0);
            this.stockBtn.Margin = new System.Windows.Forms.Padding(0);
            this.stockBtn.Name = "stockBtn";
            this.stockBtn.Size = new System.Drawing.Size(110, 70);
            this.stockBtn.TabIndex = 5;
            this.stockBtn.Text = "Stock";
            this.stockBtn.UseVisualStyleBackColor = true;
            // 
            // brandBtn
            // 
            this.brandBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.brandBtn.FlatAppearance.BorderSize = 0;
            this.brandBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brandBtn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.brandBtn.Location = new System.Drawing.Point(454, 0);
            this.brandBtn.Margin = new System.Windows.Forms.Padding(0);
            this.brandBtn.Name = "brandBtn";
            this.brandBtn.Size = new System.Drawing.Size(110, 70);
            this.brandBtn.TabIndex = 4;
            this.brandBtn.Text = "Brands";
            this.brandBtn.UseVisualStyleBackColor = true;
            this.brandBtn.Click += new System.EventHandler(this.stockBtn_Click);
            // 
            // categoryBtn
            // 
            this.categoryBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.categoryBtn.FlatAppearance.BorderSize = 0;
            this.categoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryBtn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categoryBtn.Location = new System.Drawing.Point(344, 0);
            this.categoryBtn.Margin = new System.Windows.Forms.Padding(0);
            this.categoryBtn.Name = "categoryBtn";
            this.categoryBtn.Size = new System.Drawing.Size(110, 70);
            this.categoryBtn.TabIndex = 3;
            this.categoryBtn.Text = "Categories";
            this.categoryBtn.UseVisualStyleBackColor = true;
            this.categoryBtn.Click += new System.EventHandler(this.categoryBtn_Click);
            // 
            // productBtn
            // 
            this.productBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.productBtn.FlatAppearance.BorderSize = 0;
            this.productBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productBtn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productBtn.Location = new System.Drawing.Point(234, 0);
            this.productBtn.Margin = new System.Windows.Forms.Padding(0);
            this.productBtn.Name = "productBtn";
            this.productBtn.Size = new System.Drawing.Size(110, 70);
            this.productBtn.TabIndex = 2;
            this.productBtn.Text = "Products";
            this.productBtn.UseVisualStyleBackColor = true;
            this.productBtn.Click += new System.EventHandler(this.productBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.homeBtn.Location = new System.Drawing.Point(124, 0);
            this.homeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(110, 70);
            this.homeBtn.TabIndex = 1;
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(124, 70);
            this.panel2.TabIndex = 0;
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(0, 521);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(978, 52);
            this.footer.TabIndex = 1;
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.SystemColors.Control;
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 72);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(978, 449);
            this.contentPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 573);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.nav);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.nav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel nav;
        private Button logoutBtn;
        private Button stockBtn;
        private Button brandBtn;
        private Button categoryBtn;
        private Button productBtn;
        private Button homeBtn;
        private Panel panel2;
        private Panel footer;
        private Panel contentPanel;
        private Button userBtn;
    }
}