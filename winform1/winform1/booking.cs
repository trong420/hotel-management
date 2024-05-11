using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform1
{
    public partial class booking : Form
    {
        public booking()
        {
            InitializeComponent();
            fee();
        }



        private void fee()
        {
            int.TryParse(duration.Text, out int dur);

            int n = 1000000;
            int l = 2000000;
            int v = 5000000;
            if (rtype.Text == "Normal")
            {
                int f = dur * n;
                //CultureInfo cultureInfo = new CultureInfo("de-DE"); // German culture uses dot as thousands separator
                cost.Text = f.ToString();
                
            }
            else if (rtype.Text == "Luxury")
            {
                int f = dur * l;
                //CultureInfo cultureInfo = new CultureInfo("de-DE"); // German culture uses dot as thousands separator
                cost.Text = f.ToString();
            }
            else if (rtype.Text == "VIP")
            {
                int f = dur * v;
                //CultureInfo cultureInfo = new CultureInfo("de-DE"); // German culture uses dot as thousands separator
                cost.Text = f.ToString();
            }
            else
            {
                cost.Text = "ERROR";
            }
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();


            // Create an instance of Form2
            Rooms form2 = new Rooms();



            // Show Form2
            form2.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();


            // Create an instance of Form2
            Dashboard form2 = new Dashboard();



            // Show Form2
            form2.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();


            // Create an instance of Form2
            About form2 = new About();



            // Show Form2
            form2.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();


            // Create an instance of Form2
            Login form2 = new Login();



            // Show Form2
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-PL42MBE\SQLEXPRESS;Initial Catalog=winform;Integrated Security=True"))
            {
                try
                {
                    conn.Open();
                    // Assuming the columns to match the placeholders in VALUES
                    string query = "INSERT INTO book (CustomerName, Gender, PhoneNumber, RoomType, Duration, TotalCost) VALUES (@Name, @Gender, @Phone, @Type, @Duration, @Total)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Add parameters to avoid SQL injection
                    cmd.Parameters.AddWithValue("@Name", cusName.Text);
                    cmd.Parameters.AddWithValue("@Gender", gender.Text);
                    cmd.Parameters.AddWithValue("@Phone", phone.Text);
                    cmd.Parameters.AddWithValue("@Duration", duration.Text);
                    cmd.Parameters.AddWithValue("@Type", rtype.Text);
                    cmd.Parameters.AddWithValue("@Total", cost.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Insert Data Completed");

                    // Data retrieval after insertion
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM book", conn);
                    DataTable dt = new DataTable();
                    sqlDataAdapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            string Customer = (string)dataGridView1.Rows[rowIndex].Cells["CustomerName"].Value;
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-PL42MBE\SQLEXPRESS;Initial Catalog=winform;Integrated Security=True");

            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM book WHERE CustomerName =@CustomerName", conn);
                cmd.Parameters.AddWithValue("@CustomerName", Customer);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete Data Completed");
                conn.Close();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from book", conn);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        private void cost_TextChanged(object sender, EventArgs e)
        {
            fee();
        }



        private void duration_TextChanged_1(object sender, EventArgs e)
        {
            fee();
        }

        private void rtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            fee();
        }
    }
}
