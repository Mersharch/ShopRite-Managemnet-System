﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopRite
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Form activeForm;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(childForm);
            contentPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LogInForm form = new LogInForm();
            form.Show();
            this.Close();
        }

        private void stockBtn_Click(object sender, EventArgs e)
        {

        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new HomeForm());
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new ProductsForm());
        }

        private void categoryBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new CategoriesForm());
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new StaffForm());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            openChildForm(new HomeForm());
        }
    }
}
