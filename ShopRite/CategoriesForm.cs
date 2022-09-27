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
    public partial class CategoriesForm : Form
    {
        public CategoriesForm()
        {
            InitializeComponent();
        }

        private void getCategories()
        {
            string query = "select * from categories";
            MySqlDataReader dr;

            try
            {
                categpriesDGV.Rows.Clear();
                db.open();
                MySqlCommand command = new MySqlCommand(query, db.connection);
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    categpriesDGV.Rows.Add(dr["cID"].ToString(), dr["cName"].ToString());
                }
                dr.Close();
                db.close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clear()
        {
            catID.Text = "";
            catName.Text = "";
        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            getCategories();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            db.open();
            MySqlCommand command;

            if(catID.Text != "" & catName.Text != "")
            {
                try
                {
                    string countQuery = "select count(*) from categories where cName = '" + catName.Text + "' ";
                    command = new MySqlCommand(countQuery, db.connection);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    if(count > 0)
                    {
                        MessageBox.Show("Category already exists");
                        db.close();

                    }
                    else
                    {
                        string query = "insert into categories values ( '"+catID.Text+"', '"+catName.Text+"')";
                        command = new MySqlCommand(query, db.connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Category successfully added");
                        db.close();
                        clear();
                        getCategories();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
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

            if (catID.Text != "")
            {
                try
                {
                    string countQuery = "select count(*) from categories where cID = '" + catID.Text + "' ";
                    command = new MySqlCommand(countQuery, db.connection);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        string query = "delete from categories where cID = '" + catID.Text + "' ";
                        command = new MySqlCommand(query, db.connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Category deleted Successfully");
                        db.close();
                        clear();
                        getCategories();
                    }
                    else
                    {
                        MessageBox.Show("Category doesn't exist");
                        db.close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Enter Category ID");
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            getCategories();
        }
    }
}
