using MySql.Data.MySqlClient;
using System;
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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void leftLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            db.open();
            MySqlCommand command;

            if (loginUserName.Text != "" & loginPassword.Text != "")
            {
                try
                {
                    string countQuery = "select count(*) from staff where uUsername = '" + loginUserName.Text + "' and uPassword = '"+loginPassword.Text+"' ";
                    command = new MySqlCommand(countQuery, db.connection);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        MainForm form = new MainForm();
                        form.Show();
                        this.Hide();
                        db.close();

                    }
                    else
                    {
                        MessageBox.Show("Invalid Credentials");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("All fields are required");
            }
        }
    }
}
