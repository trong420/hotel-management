using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace winform1
{
    public partial class Sign_up : Form
    {
        public Sign_up()
        {
            InitializeComponent();
        }

        private void b1_signup_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-PL42MBE\SQLEXPRESS;Initial Catalog=winform;Integrated Security=True"))
            {
                try
                {
                    conn.Open();
                    // Assuming the columns to match the placeholders in VALUES
                    // First, check if the email already exists
                    string checkQuery = "SELECT COUNT(*) FROM login WHERE email = @Email";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@Email", textBox3.Text);

                    int userExists = (int)checkCmd.ExecuteScalar(); // ExecuteScalar returns the first column of the first row

                    if (userExists > 0)
                    {
                        MessageBox.Show("An account with this email already exists.");
                    }
                    else
                    {
                        string query = "INSERT INTO login (email, password) VALUES (@Email, @Password)";
                        SqlCommand cmd = new SqlCommand(query, conn);

                        // Add parameters to avoid SQL injection
                        cmd.Parameters.AddWithValue("@Email", textBox3.Text);
                        cmd.Parameters.AddWithValue("@Password", textBox4.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sign-up was successful.");

                        // Data retrieval after insertion
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM login", conn);
                        DataTable dt = new DataTable();
                        sqlDataAdapter.Fill(dt);
                        this.Hide();


                        // Create an instance of Form2
                        Login form2 = new Login();



                        // Show Form2
                        form2.Show();
                    }
                    
                    
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }


           
        }

        private void link_signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();


            // Create an instance of Form2
            Login form2 = new Login();



            // Show Form2
            form2.Show();
        }
    }
}
