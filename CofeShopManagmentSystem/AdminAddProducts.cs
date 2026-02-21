using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Web;

namespace CofeShopManagmentSystem
{
    public partial class AdminAddProducts : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shehd\Documents\cafe.mdf;Integrated Security=True;Connect Timeout=30");

        public AdminAddProducts()
        {
            InitializeComponent();
        }

        public bool emptyfield()
        {
            if (adminAddProducts_id.Text == "" || adminAddProducts_name.Text == "" ||
                   adminAddProducts_type.SelectedIndex == -1 || adminAddProducts_stock.Text == ""
                   || adminAddProducts_price.Text == "" || adminAddProducts_status.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void adminAddProducts_addBtn_Click(object sender, EventArgs e)
        {
            if (emptyfield())
            {
                MessageBox.Show("All Fields required to be filled", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        // Checking if the product ID is existing already
                        string selectProdID = "SELECT * FROM products WHERE prod_id = @prodID";
                        using (SqlCommand selectPID = new SqlCommand(selectProdID, connect))
                        {
                            selectPID.Parameters.AddWithValue("@prodID", adminAddProducts_id.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(selectPID);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Product ID = " + adminAddProducts_id.Text.Trim() + "Is taken already", "Error Message",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = @"
                                INSERT INTO products
                                (prod_id, prod_name, prod_type, prod_stock, prod_price, prod_status, prod_image, date_incert)
                                VALUES
                                (@prodID, @prodName, @prodType, @prodStock, @prodPrice, @prodStatus, @prodImage, @dateInsert);";

                                DateTime today = DateTime.Today;
                                string path = Path.Combine("C:\\Users\\shehd\\Source\\Repos\\CofeShopManagmentSystem3\\CofeShopManagmentSystem\\Product_Directory\\"
                                    + adminAddProducts_id.Text.Trim() + ".jpg");

                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(adminAddProducts_imageView.ImageLocation, path, true);

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@prodID", adminAddProducts_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodName", adminAddProducts_name.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodType", adminAddProducts_type.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodStock", adminAddProducts_stock.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodPrice", adminAddProducts_price.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodStatus", adminAddProducts_status.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodImage", path);
                                    cmd.Parameters.AddWithValue("@dateInsert", today);   // <-- MUST match SQL

                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed Connection" + ex, "Error Message",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }

            }
        }

        private void adminAddProducts_importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png) |*.jpg; *.png";
                string imagePath = "";

                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    adminAddProducts_imageView.ImageLocation = imagePath;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void AdminAddProducts_Load(object sender, EventArgs e)
        {

        }

        private void adminAddProducts_clearBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
