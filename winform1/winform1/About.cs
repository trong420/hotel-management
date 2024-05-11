using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform1
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
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
            this.Hide();


            // Create an instance of Form2
            Dashboard form2 = new Dashboard();



            // Show Form2
            form2.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();


            // Create an instance of Form2
            Login form2 = new Login();



            // Show Form2
            form2.Show();
        }

        
    }
}
