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

namespace CofeShopManagmentSystem
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(
            "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\shehd\\Documents\\cafe.mdf;Integrated Security=True;Connect Timeout=30;");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public bool emptyFields()
        {
            if (login_username.Text == "" || login_password.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        string selectAccount = "SELECT * FROM users WHERE username = @usern AND password = @pass AND status = @status";
                        using (SqlCommand cmd = new SqlCommand(selectAccount, connect))
                        {
                            cmd.Parameters.AddWithValue("@usern" , login_username.Text.Trim());
                            cmd.Parameters.AddWithValue("@pass", login_password.Text.Trim());
                            cmd.Parameters.AddWithValue("@status","Active");

                           SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Login Successfuly!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                AdminMainForm adminForm = new AdminMainForm();
                                adminForm.Show();

                                this.Hide();

                            } else
                            {
                                MessageBox.Show("Incorrect Username/Password or there is no Admin Approval!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }



                        }
                    }
                
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection Faild! "+ ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }

                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_registerBtn_Click(object sender, EventArgs e)
        {
            Register regForm = new Register();
            regForm.Show();

            this.Hide();
        }

        private void Login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = Login_showPass.Checked ? '\0' : '*';
        }

        private void Login_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
