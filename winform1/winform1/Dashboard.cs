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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            CountRooms();
            CountIncome();
            CountCustomer();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
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
            this.Hide();


            // Create an instance of Form2
            booking form2 = new booking();



            // Show Form2
            form2.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

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
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-PL42MBE\SQLEXPRESS;Initial Catalog=winform;Integrated Security=True");

        private void CountRooms()
        {
            conn.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT count(*) FROM room", conn);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            troom.Text = dt.Rows[0][0].ToString() + " " + "Rooms";
            conn.Close();
        }

        private void CountCustomer()
        {
            conn.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT count(*) FROM book", conn);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            tcustomer.Text = dt.Rows[0][0].ToString() + " " + "Customers";
            conn.Close();
        }

        private void CountIncome()
        {
            conn.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT sum(TotalCost) FROM book", conn);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            tincome.Text = dt.Rows[0][0].ToString() + " " + "VNĐ";

            conn.Close();
        }

    }
}
