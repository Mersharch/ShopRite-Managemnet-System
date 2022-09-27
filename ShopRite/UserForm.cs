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
using System.Drawing.Text;

namespace ShopRite
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void getUsers()
        {
            string query = "select * from users";
            MySqlDataReader dr;

            try
            {
                usersDGV.Rows.Clear();
                db.open();
                MySqlCommand command = new MySqlCommand(query, db.connection);
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    usersDGV.Rows.Add(dr["uID"].ToString(), dr["uFullname"].ToString(), dr["uUsername"].ToString(), dr["uPassword"].ToString(), dr["uContact"].ToString());
                }
                dr.Close();
                db.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clear()
        {
            userID.Text = "";
            fullName.Text = "";
            userUserName.Text = "";
            userPassword.Text = "";
            userContact.Text = "";
            adminNum.Value = 0;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            getUsers();
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void usersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            db.open();
            MySqlCommand command;
            Int32 adminCode = 4519;

            if (userID.Text != "" & adminNum.Value != 0)
            {
                if(adminNum.Value != adminCode)
                {
                    MessageBox.Show("Incorrect Admin Code");
                }
                else
                {
                    try
                    {
                        string countQuery = "select count(*) from users where uUsername = '" + userUserName.Text + "' ";
                        command = new MySqlCommand(countQuery, db.connection);
                        Int32 count = Convert.ToInt32(command.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("Username already exists");
                            db.close();
                        }
                        else
                        {
                            string query = "insert into users values ( '" + userID.Text + "', '" + fullName.Text + "', '" + userUserName.Text + "', '" + userPassword.Text + "', '" + userContact.Text + "')";
                            command = new MySqlCommand(query, db.connection);
                            command.ExecuteNonQuery();
                            MessageBox.Show("User successfully added");
                            db.close();
                            clear();
                            getUsers();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                
            }
            else
            {
                MessageBox.Show("All fields are required");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            db.open();
            MySqlCommand command;
            Int32 adminCode = 4519;

            if (userID.Text != "" & adminNum.Value != 0)
            {
                if (adminNum.Value != adminCode)
                {
                    MessageBox.Show("Incorrect Admin Code");
                }
                else
                {
                    try
                    {
                        string countQuery = "select count(*) from users where uID = '" + userID.Text + "' ";
                        command = new MySqlCommand(countQuery, db.connection);
                        Int32 count = Convert.ToInt32(command.ExecuteScalar());
                        if (count > 0)
                        {
                            string query = "delete from users where uID = '" + userID.Text + "' ";
                            command = new MySqlCommand(query, db.connection);
                            command.ExecuteNonQuery();
                            MessageBox.Show("User successfully deleted");
                            db.close();
                            clear();
                            getUsers();
                        }
                        else
                        {
                            MessageBox.Show("User ID doesn't exist");
                            db.close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }


            }
            else
            {
                MessageBox.Show("User ID and Admin Code are required for this operation");
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            getUsers();
        }
    }
}
