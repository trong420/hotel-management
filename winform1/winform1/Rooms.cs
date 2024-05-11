using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform1
{
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
            ShowData();
        }



        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-PL42MBE\SQLEXPRESS;Initial Catalog=winform;Integrated Security=True");

        private void InsertRooms()
        {
            string rnum, rtype, rstatus;
            rnum = comboBox3.Text;
            rtype = comboBox1.Text;
            rstatus = comboBox2.Text;

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into room values('" + comboBox3.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Insert Data Completed");
                conn.Close();
                ShowData();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void ShowData()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from room", conn);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

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


        //
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

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            InsertRooms();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            int RoomNumber = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["RoomNumber"].Value);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM room WHERE RoomNumber =@RoomNumber", conn);
                cmd.Parameters.AddWithValue("@RoomNumber", RoomNumber);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete Data Completed");
                conn.Close();
                ShowData();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            string originalRoomNumber = dataGridView1.Rows[rowIndex].Cells["RoomNumber"].Value.ToString();


            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE room SET RoomNumber =@RoomNumber, RoomType =@RoomType, RoomStatus =@RoomStatus  WHERE RoomNumber =@OriginalRoomNumber", conn);
                cmd.Parameters.AddWithValue("@OriginalRoomNumber", originalRoomNumber);
                cmd.Parameters.AddWithValue("@RoomType", comboBox1.Text);
                cmd.Parameters.AddWithValue("@RoomStatus", comboBox2.Text);
                cmd.Parameters.AddWithValue("@RoomNumber", comboBox3.Text);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Update Data Completed");
                }
                else
                {
                    MessageBox.Show("No data was updated. Check the original room number.");
                }
                conn.Close();
                ShowData();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
