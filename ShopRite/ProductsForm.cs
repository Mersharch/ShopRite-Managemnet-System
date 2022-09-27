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
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
            getProducts();
            loadCategories();
        }

        private void loadCategories()
        {
            string query = "select * from categories";
            DataSet ds = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataView dv;
            try
            {
                prodCategory.Items.Clear();
                db.open();
                MySqlCommand command = new MySqlCommand(query, db.connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                db.close();

                dv = ds.Tables[0].DefaultView;
                prodCategory.DataSource = dv;
                prodCategory.DisplayMember = "cName";
                prodCategory.ValueMember = "cName";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getProducts()
        {
            string query = "select * from products";
            MySqlDataReader dr;

            try
            {
                productsDGV.Rows.Clear();
                db.open();
                MySqlCommand command = new MySqlCommand(query, db.connection);
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    productsDGV.Rows.Add(dr["pID"].ToString(), dr["pName"].ToString(), dr["pDesc"].ToString(), dr["pCategory"].ToString(), dr["pQty"].ToString(), dr["pPrice"].ToString());
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
            prodID.Text = "";
            prodName.Text = "";
            prodDesc.Text = "";
            prodCategory.SelectedIndex = 0;
            prodQty.Value = 0;
            prodPrice.Value = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            db.open();
            MySqlCommand command;

            if (prodID.Text != "" & prodName.Text != "" & prodDesc.Text != "" & prodQty.Value != 0 & prodPrice.Value != 0 & prodCategory.SelectedValue.ToString() != "")
            {
                try
                {
                    string countQuery = "select count(*) from products where pID = '" + prodID.Text + "' ";
                    command = new MySqlCommand(countQuery, db.connection);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Product ID already exists");
                        db.close();

                    }
                    else
                    {
                        string query = "insert into products values ( '" + prodID.Text + "', '" + prodName.Text + "', '" + prodDesc.Text + "', '" + prodCategory.SelectedValue.ToString() + "', '" + prodQty.Value + "', '" + prodPrice.Value + "' )";
                        command = new MySqlCommand(query, db.connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Product successfully added");
                        db.close();
                        clear();
                        getProducts();
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

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            getProducts();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            db.open();
            MySqlCommand command;

            if (prodID.Text != "")
            {
                try
                {
                    string countQuery = "select count(*) from products where pID = '" + prodID.Text + "' ";
                    command = new MySqlCommand(countQuery, db.connection);
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        string query = "delete from products where pID = '" + prodID.Text + "' ";
                        command = new MySqlCommand(query, db.connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Product deleted Successfully");
                        db.close();
                        clear();
                        getProducts();
                    }
                    else
                    {
                        MessageBox.Show("Product ID doesn't exist");
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
                MessageBox.Show("Enter Product ID");
            }
        }
    }
}
