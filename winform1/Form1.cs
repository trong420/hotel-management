namespace winform1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.button1.Click += new System.EventHandler(this.click);
        }

        private void click(object sender, EventArgs e)
        {
            String text = box1.Text;
            textBox1.Text = text;
        }
    }
}
