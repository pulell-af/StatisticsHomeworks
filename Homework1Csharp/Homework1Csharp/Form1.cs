namespace Homework1Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Displaylabel.Text = "Hello, I am '" + txt_name.Text + "', I am from '" + txt_from.Text + "'";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}