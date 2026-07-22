using System.Net.Mail;

namespace HelloForm
{
    public partial class Form1 : Form
    {
        int no1, no2;
        public Form1()
        {
            InitializeComponent();
        }
        private void GetData()
        {
            no1 = Convert.ToInt32(textBox1.Text);
            no2 = Convert.ToInt32(textBox2.Text);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            }

        private void B1_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Run Time button");
            Console.WriteLine("Hello, World");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetData();
            int sum = no1 + no2;
            label3.Text = sum.ToString();
            MessageBox.Show(sum.ToString(), "Calc", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetData();
            int sum = no1 - no2;
            label3.Text = sum.ToString();
            MessageBox.Show(sum.ToString(),"Calc", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetData();
            int sum = no1 * no2;
            label3.Text = sum.ToString();
            MessageBox.Show(sum.ToString(), "Calc", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetData();
            int sum = no1 / no2;
            label3.Text = sum.ToString();
            MessageBox.Show(sum.ToString(), "Calc", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
