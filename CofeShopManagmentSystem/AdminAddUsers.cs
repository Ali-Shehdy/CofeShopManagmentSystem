using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace CofeShopManagmentSystem
{

    public partial class AdminAddUsers : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shehd\Documents\cafe.mdf;Integrated Security=True;Connect Timeout=30");

        public AdminAddUsers()
        {
            InitializeComponent();

            displayAddUsersData();
        }


        public void displayAddUsersData()
        {
            AdminAddUsersData usersData = new AdminAddUsersData();
            List<AdminAddUsersData> listData = usersData.usersListData();
            dataGridView1.DataSource = listData;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public bool emptyFields()
        {
            if (adminAddUsers_addBtn.Text == "" || adminAddUsers_password.Text == ""
                || adminAddUsers_role.Text == "" || adminAddUsers_status.Text == ""
                || adminAddUsers_imageView.Image == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void adminAddUsers_addBtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        // Check if the username already exists in the database
                        string selectUsern = "SELECT COUNT(*) FROM users WHERE username = @usern";
                        using (SqlCommand checkUsern = new SqlCommand(selectUsern, connect))
                        {
                            checkUsern.Parameters.AddWithValue("@usern", adminAddUsers_username.Text.Trim());

                            // Use ExecuteScalar to get the COUNT value instead of checking Rows.Count
                            int existingCount = Convert.ToInt32(checkUsern.ExecuteScalar());

                            if (existingCount > 0)
                            {
                                string usern = adminAddUsers_username.Text.Substring(0, 1).ToUpper() + adminAddUsers_username.Text.Substring(1);
                                MessageBox.Show(usern + " is already Taken.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO users (username, password, profile_image, role, status, date_reg)" +
                                    " VALUES (@usern, @pass, @image, @role, @status, @date)";

                                DateTime today = DateTime.Today;

                                string path = Path.Combine(@"C:\Users\shehd\Source\Repos\CofeShopManagmentSystem3\CofeShopManagmentSystem\User_Directory\"
                                + adminAddUsers_username.Text.Trim() + ".jpg");

                                string directory = Path.GetDirectoryName(path);
                                if (!Directory.Exists(directory))
                                {
                                    Directory.CreateDirectory(directory);
                                }
                                File.Copy(adminAddUsers_imageView.ImageLocation, path, true);

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@usern", adminAddUsers_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass", adminAddUsers_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@image", path);
                                    cmd.Parameters.AddWithValue("@role", adminAddUsers_role.Text.Trim());
                                    cmd.Parameters.AddWithValue("@status", adminAddUsers_status.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date", today);

                                    cmd.ExecuteNonQuery();
                                    clearFields();
                                    MessageBox.Show("User Added Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    displayAddUsersData();
                                }
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection Failed" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void adminAddUsers_importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                string imagepath = "";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagepath = dialog.FileName;
                    adminAddUsers_imageView.ImageLocation = imagepath;
                    // Do something with the selected image file
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int id = 0;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            id = (int)row.Cells[0].Value;
            adminAddUsers_username.Text = row.Cells[1].Value.ToString();
            adminAddUsers_password.Text = row.Cells[2].Value.ToString();
            adminAddUsers_role.Text = row.Cells[3].Value.ToString();
            adminAddUsers_status.Text = row.Cells[4].Value.ToString();

          
            string imagePath = row.Cells[5].Value?.ToString();

            adminAddUsers_imageView.Image?.Dispose();
            adminAddUsers_imageView.Image = null;

            if (!string.IsNullOrWhiteSpace(imagePath) && File.Exists(imagePath))
            {
                // avoids locking the file by using a memory copy
                using (var fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    adminAddUsers_imageView.Image = Image.FromStream(fs);
                }
            }
            else
            {
                // Optional: show a default placeholder image instead of null
                // adminAddUsers_imageView.Image = Properties.Resources.defaultUser;
            }
        }

        private void adminAddUsers_updateBtn_Click(object sender, EventArgs e)
        {
            if(emptyFields())
            {
                MessageBox.Show("All fields are requierd to be filled", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to update Username" + adminAddUsers_username.Text.Trim()
                    + "?", "Confirmation Message" , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        try
                        {
                            connect.Open();

                            string updateDate = "Update users Set username = @usern, password = @pass, role = @role, status = @status WHERE id = @id ";

                            using (SqlCommand cmd = new SqlCommand(updateDate, connect))
                            {
                                cmd.Parameters.AddWithValue("@usern", adminAddUsers_username.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", adminAddUsers_password.Text.Trim());
                                cmd.Parameters.AddWithValue("@role", adminAddUsers_role.Text.Trim());
                                cmd.Parameters.AddWithValue("@status", adminAddUsers_status.Text.Trim());
                                cmd.Parameters.AddWithValue("@id", id);

                                cmd.ExecuteNonQuery();
                                clearFields();


                                MessageBox.Show("Update successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                displayAddUsersData();
                            }
                        }
                        catch (Exception ex)
                        {
                        MessageBox.Show("Connection Faild" + ex , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
                }
        }

        // Add this method to handle the TextChanged event for adminAddUsers_username
        private void adminAddUsers_username_TextChanged(object sender, EventArgs e)
        {
            // You can leave this empty or add logic as needed
        }

        public void clearFields()
        {
            adminAddUsers_username.Text = "";
            adminAddUsers_password.Text = "";
            adminAddUsers_role.SelectedIndex = -1;
            adminAddUsers_status.SelectedIndex = -1;
            adminAddUsers_imageView.Image = null;

        }
        private void adminAddUsers_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}