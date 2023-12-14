namespace ThreadingDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Process 1 executed!");
            BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Process 2 executed!");
            BackColor = Color.Blue;
        }
    }
}