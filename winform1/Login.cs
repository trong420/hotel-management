using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace winform1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-PL42MBE\SQLEXPRESS;Initial Catalog=winform;Integrated Security=True");
        
        private void b1_login_Click(object sender, EventArgs e)
        {
            string email, password;
            textBox1.Focus();
            email = textBox1.Text;
            password = textBox2.Text;

            try
            {
                string querry = "SELECT * FROM login WHERE email = '"+textBox1.Text+"' AND password = '"+textBox2.Text+"'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(querry,conn);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);

                if(dt.Rows.Count > 0 )
                {
                    email = textBox1.Text;
                    password = textBox2.Text;
                    this.Hide();

                    // Create an instance of Form2
                    Home form2 = new Home();

                    // Show Form2
                    form2.Show();
                }
                else
                {
                    MessageBox.Show("Wrong email or password","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Invalid Login");
            }
            finally
            {
                conn.Close();
            }

            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            // Create an instance of Form2
            Sign_up form3 = new Sign_up();

            // Show Form2
            form3.Show();
        }
    }
}
